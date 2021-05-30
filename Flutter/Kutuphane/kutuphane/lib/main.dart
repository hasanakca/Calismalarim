import 'package:flutter/material.dart';
import 'dart:async';

import 'package:flutter/foundation.dart';
import 'package:flutter/rendering.dart';
import 'package:flutter/scheduler.dart';
import 'package:flutter_inappwebview/flutter_inappwebview.dart';
import 'package:giris/database/database_helper.dart';
import 'package:auto_size_text/auto_size_text.dart';

void main() {
  WidgetsFlutterBinding.ensureInitialized();

  runApp(MyApp());
}

int kitapsayisi = 0;
String soru = "";
int id = 0;
String hatamesaji = "boş";
bool hatavisible = false;
String aramametni = "";
bool oneri = false;
bool girisGorunur = false;
bool sayfa2Gorunur = false;

class MyApp extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      home: Scaffold(
        body: Container(
          alignment: Alignment.center,
          decoration: BoxDecoration(
              image: DecorationImage(
                  image: AssetImage("giris.jpg"), fit: BoxFit.cover)),
          child: Giris(),
        ),
      ),
    );
  }
}

final TextEditingController isim = new TextEditingController();
InAppWebViewController web;

class Giris extends StatefulWidget {
  @override
  _GirisState createState() => _GirisState();
}

class _GirisState extends State<Giris> {
  String ad;
  List<String> kutuphane = new List<String>();
  var giriskontrol;
  final dbhelper = DatabaseHelper.instance;
  Future queryall() async {
    var allrows = await dbhelper.queryall();
    return allrows;
  }

  void initState() {
    super.initState();
    SchedulerBinding.instance.addPostFrameCallback((timeStamp) {
      setState(() {
        girisGorunur = true;
      });
    });
    queryall().then((value) => {
          setState(() {
            if (value != null) {
              isim.text = value
                  .toString()
                  .split(',')[4]
                  .split(':')[1]
                  .split('}')[0]
                  .trim();
              var route = MaterialPageRoute(
                builder: (BuildContext context) => Sayfa2(ad: isim.text),
              );
              Navigator.of(context).push(route);
              print(isim.text);
            }
          })
        });
  }

  @override
  Widget build(BuildContext context) {
    return AnimatedOpacity(
      opacity: girisGorunur ? 1.0 : 0.0,
      duration: Duration(seconds: 1),
      child: AnimatedAlign(
        duration: Duration(seconds: 1),
        alignment: girisGorunur ? Alignment.center : Alignment.centerLeft,
        child: Container(
          height: 180,
          width: 320,
          color: Colors.black.withOpacity(0.5),
          child: Container(
            margin: EdgeInsets.only(left: 19, top: 19),
            child: Column(
              mainAxisAlignment: MainAxisAlignment.start,
              crossAxisAlignment: CrossAxisAlignment.start,
              children: <Widget>[
                RichText(
                    text: TextSpan(
                  text: "Giriş",
                  style: TextStyle(
                      color: Colors.white.withOpacity(1), fontSize: 30),
                )),
                Container(
                  padding: EdgeInsets.fromLTRB(0, 20, 0, 0),
                  child: Row(
                    children: <Widget>[
                      Container(
                        color: Color(0xffffc107),
                        child: Icon(
                          Icons.person,
                          color: Colors.black,
                        ),
                        width: 30,
                        height: 35,
                      ),
                      Container(
                        height: 35,
                        width: 250,
                        color: Colors.white,
                        child: TextField(
                            maxLines: 1,
                            textAlign: TextAlign.justify,
                            controller: isim,
                            decoration: InputDecoration(
                              border: InputBorder.none,
                              hintText: 'İsminizi girin',
                            )),
                      )
                    ],
                  ),
                ),
                Container(
                  padding: EdgeInsets.fromLTRB(0, 18, 21, 0),
                  child: Row(
                    mainAxisAlignment: MainAxisAlignment.center,
                    children: <Widget>[
                      Container(
                        color: Color(0xffffc107),
                        child: RaisedButton(
                          onPressed: () {
                            girisGorunur = false;
                            var route = MaterialPageRoute(
                              builder: (BuildContext context) =>
                                  Sayfa2(ad: isim.text),
                            );

                            Navigator.of(context).push(route);
                          },
                          color: Color(0xffffc107),
                          child: Text(
                            "Giriş Yap",
                            textAlign: TextAlign.start,
                            style: TextStyle(
                                fontSize: 17, fontWeight: FontWeight.bold),
                          ),
                        ),
                        width: 120,
                        height: 25,
                      ),
                    ],
                  ),
                ),
              ],
            ),
          ),
        ),
      ),
    );
  }
}

Future kitap;
bool gostergizle = false;
bool kitapekle = false;
bool webviewVisible = false;
List<TextEditingController> _kontoller =
    List.generate(3, (index) => TextEditingController());
final TextEditingController oneriListe = TextEditingController();
String oneriListeString;

class Sayfa2 extends StatefulWidget {
  final String ad;

  Sayfa2({Key key, this.ad}) : super(key: key);

  @override
  _Sayfa2State createState() => _Sayfa2State();
}

class _Sayfa2State extends State<Sayfa2> {
  final dbhelper = DatabaseHelper.instance;
  List<String> kutuphane = new List<String>();
  List<String> yazarAdi = new List<String>();
  void insertData() async {
    Map<String, dynamic> row = {
      DatabaseHelper.columnKAdi: _kontoller[0].text.trim(),
      DatabaseHelper.columnYAdi: _kontoller[1].text.trim(),
      DatabaseHelper.columnKK: _kontoller[2].text,
      DatabaseHelper.columnUser: isim.text.trim(),
    };
    final id = await dbhelper.insert(row);
    print(id);
  }

  void queryall() async {
    kitapsayisi = 0;
    var allrows = await dbhelper.queryall();
    allrows.forEach((element) {
      kutuphane.add(element.toString());
      kitapsayisi++;
    });
  }

  void yazarAdiBul() async {
    var allrows = await dbhelper.yazarAdi(_kontoller[1].text);
    yazarAdi.clear();
    allrows.forEach((element) {
      yazarAdi.add(element.toString().split(':')[1].split('}')[0]);
      print(element.toString().split(':')[1].split('}')[0]);
    });
  }

  void arama(String deger) async {
    var allrows = await dbhelper.arama(deger);
    kutuphane.clear();
    allrows.forEach((element) {
      kutuphane.add(element.toString());
    });
    print(allrows);
  }

  void deleteWithId(int id) async {
    var result = await dbhelper.deleteData(id);
    print(result);
  }

  void initState() {
    queryall();
    super.initState();

    SchedulerBinding.instance.addPostFrameCallback((timeStamp) {
      setState(() {
        sayfa2Gorunur = true;
      });
    });
    arama(aramametni);
  }

  @override
  Widget build(BuildContext context) {
    return AnimatedOpacity(
      opacity: sayfa2Gorunur ? 1.0 : 0.0,
      duration: Duration(seconds: 1),
      child: AnimatedAlign(
        duration: Duration(seconds: 1),
        alignment: sayfa2Gorunur ? Alignment.center : Alignment.topCenter,
        child: MaterialApp(
          debugShowCheckedModeBanner: false,
          home: Scaffold(
            body: Container(
              alignment: Alignment.topRight,
              decoration: BoxDecoration(
                  image: DecorationImage(
                      image: AssetImage("giris.jpg"), fit: BoxFit.cover)),
              child: SingleChildScrollView(
                physics: NeverScrollableScrollPhysics(),
                child: Column(
                  children: <Widget>[
                    Container(
                      margin: EdgeInsets.only(top: 50, left: 10),
                      width: MediaQuery.of(context).copyWith().size.width,
                      height: 49,
                      color: Colors.black.withOpacity(0.8),
                      child: Row(
                        children: <Widget>[
                          Container(
                            height:
                                MediaQuery.of(context).copyWith().size.height /
                                    30,
                            width:
                                MediaQuery.of(context).copyWith().size.width /
                                    1.5,
                            margin:
                                EdgeInsets.only(bottom: 0, left: 8, right: 8),
                            child: TextField(
                                onChanged: (text) {
                                  setState(() {
                                    aramametni = text;
                                    arama(aramametni);
                                  });
                                },
                                maxLines: 1,
                                textAlign: TextAlign.center,
                                textAlignVertical: TextAlignVertical.bottom,
                                style: TextStyle(
                                    fontSize: 13, fontWeight: FontWeight.bold),
                                decoration: InputDecoration(
                                  border: InputBorder.none,
                                  hintText: 'Kitap veya Yazar İsmi',
                                  filled: true,
                                  fillColor: Colors.white.withOpacity(1),
                                )),
                          ),
                          Container(
                            margin: EdgeInsets.only(left: 1),
                            height:
                                MediaQuery.of(context).copyWith().size.height /
                                    18,
                            width:
                                MediaQuery.of(context).copyWith().size.width /
                                    4.15,
                            color: Colors.black.withOpacity(0),
                            child: Container(
                              alignment: Alignment.centerRight,
                              margin: EdgeInsets.only(top: 0, right: 0),
                              child: RaisedButton(
                                color: Colors.black.withOpacity(0),
                                onPressed: () {
                                  setState(() {
                                    if (gostergizle == false) {
                                      gostergizle = true;
                                    } else {
                                      gostergizle = false;
                                    }
                                  });
                                },
                                child: Row(
                                  children: <Widget>[
                                    Text(
                                      "${widget.ad}",
                                      textAlign: TextAlign.end,
                                      style: TextStyle(
                                        color: Colors.white,
                                        fontSize: 15,
                                      ),
                                    ),
                                    Icon(
                                      Icons.menu,
                                      color: Colors.white,
                                    )
                                  ],
                                ),
                              ),
                            ),
                          ),
                        ],
                      ),
                    ),
                    Row(
                      children: <Widget>[
                        Expanded(
                          child: Stack(children: <Widget>[
                            Column(
                              children: <Widget>[
                                SingleChildScrollView(
                                    scrollDirection: Axis.vertical,
                                    child: Container(
                                      height:
                                          MediaQuery.of(context).size.height /
                                              1.14,
                                      width: MediaQuery.of(context).size.width,
                                      child: FutureBuilder<Object>(
                                          future: DatabaseHelper.instance
                                              .arama(aramametni),
                                          builder: (context, snapshot) {
                                            if (snapshot.data.toString() ==
                                                "[]") {
                                              return Column(
                                                  mainAxisAlignment:
                                                      MainAxisAlignment.center,
                                                  children: <Widget>[
                                                    Container(
                                                        height:
                                                            MediaQuery.of(
                                                                        context)
                                                                    .size
                                                                    .height /
                                                                3,
                                                        width: MediaQuery.of(
                                                                    context)
                                                                .size
                                                                .width /
                                                            1,
                                                        color: Colors.black
                                                            .withOpacity(0.5),
                                                        child:
                                                            Column(children: <
                                                                Widget>[
                                                          SizedBox(
                                                            height: 40,
                                                          ),
                                                          Container(
                                                            child: Text(
                                                              "Haydi ilk kitabımızı ekleyelim",
                                                              style: TextStyle(
                                                                fontSize: 35,
                                                                color: Colors
                                                                    .white,
                                                              ),
                                                              textAlign:
                                                                  TextAlign
                                                                      .center,
                                                            ),
                                                          ),
                                                          SizedBox(
                                                            height: 30,
                                                          ),
                                                          Container(
                                                            alignment: Alignment
                                                                .centerRight,
                                                            width: MediaQuery.of(
                                                                        context)
                                                                    .copyWith()
                                                                    .size
                                                                    .width /
                                                                2.8,
                                                            height: MediaQuery.of(
                                                                        context)
                                                                    .copyWith()
                                                                    .size
                                                                    .height /
                                                                16,
                                                            color: Color(
                                                                0xffffc107),
                                                            child: SizedBox(
                                                              height: double
                                                                  .infinity,
                                                              width: double
                                                                  .infinity,
                                                              child: FlatButton(
                                                                onPressed: () {
                                                                  setState(() {
                                                                    kitapekle =
                                                                        true;
                                                                  });
                                                                },
                                                                color: Color(
                                                                        0xffffc107)
                                                                    .withOpacity(
                                                                        0),
                                                                hoverColor: Color(
                                                                    0xffffc107),
                                                                child: Row(
                                                                  children: <
                                                                      Widget>[
                                                                    Text(
                                                                      "Kitap Ekle",
                                                                      style: TextStyle(
                                                                          fontSize:
                                                                              20),
                                                                    ),
                                                                    Icon(Icons
                                                                        .note_add)
                                                                  ],
                                                                ),
                                                              ),
                                                            ),
                                                          )
                                                        ]))
                                                  ]);
                                            } else {
                                              return ListView.builder(
                                                  scrollDirection:
                                                      Axis.vertical,
                                                  shrinkWrap: true,
                                                  itemCount: kutuphane.length,
                                                  itemBuilder:
                                                      (context, index) {
                                                    return Container(
                                                        margin: EdgeInsets.only(
                                                          top: 0,
                                                        ),
                                                        height: MediaQuery.of(
                                                                    context)
                                                                .copyWith()
                                                                .size
                                                                .height /
                                                            2.4,
                                                        width: MediaQuery.of(
                                                                context)
                                                            .copyWith()
                                                            .size
                                                            .width,
                                                        child: Column(
                                                            mainAxisAlignment:
                                                                MainAxisAlignment
                                                                    .start,
                                                            crossAxisAlignment:
                                                                CrossAxisAlignment
                                                                    .center,
                                                            children: <Widget>[
                                                              Container(
                                                                child: Column(
                                                                  children: <
                                                                      Widget>[
                                                                    Stack(
                                                                      children: <
                                                                          Widget>[
                                                                        Container(
                                                                            height:
                                                                                260,
                                                                            child:
                                                                                Image(
                                                                              image: NetworkImage(kutuphane[index].split(',')[3].substring(13, kutuphane[index].split(',')[3].length).trim()),
                                                                              fit: BoxFit.fill,
                                                                            )),
                                                                        Container(
                                                                            height:
                                                                                20,
                                                                            width:
                                                                                20,
                                                                            color:
                                                                                Color(0xffffc107),
                                                                            margin: EdgeInsets.only(left: MediaQuery.of(context).size.width / 3, top: MediaQuery.of(context).size.height / 50),
                                                                            child: FlatButton(
                                                                              onPressed: () {
                                                                                deleteWithId(int.parse(kutuphane[index].split(',')[0].substring(5).trim()));

                                                                                setState(() {
                                                                                  var route = MaterialPageRoute(
                                                                                    builder: (BuildContext context) => Sayfa2(ad: isim.text),
                                                                                  );

                                                                                  Navigator.of(context).push(route);
                                                                                });
                                                                              },
                                                                              child: Text(
                                                                                "X",
                                                                                style: TextStyle(color: Colors.black),
                                                                                textAlign: TextAlign.end,
                                                                              ),
                                                                            )),
                                                                      ],
                                                                    ),
                                                                    Container(
                                                                        child:
                                                                            AutoSizeText(
                                                                      kutuphane[index]
                                                                          .split(',')[
                                                                              1]
                                                                          .substring(
                                                                              10)
                                                                          .trim(),
                                                                      style: TextStyle(
                                                                          color: Colors
                                                                              .white,
                                                                          fontSize:
                                                                              20),
                                                                      maxLines:
                                                                          1,
                                                                    )),
                                                                    SizedBox(
                                                                      height: 5,
                                                                    ),
                                                                    Container(
                                                                        child:
                                                                            AutoSizeText(
                                                                      kutuphane[index]
                                                                          .split(',')[
                                                                              2]
                                                                          .substring(
                                                                              10)
                                                                          .trim(),
                                                                      style: TextStyle(
                                                                          color: Colors
                                                                              .white,
                                                                          fontSize:
                                                                              18),
                                                                      maxLines:
                                                                          1,
                                                                    ))
                                                                  ],
                                                                ),
                                                                color: Colors
                                                                    .black
                                                                    .withOpacity(
                                                                        0.5),
                                                                height: MediaQuery.of(
                                                                            context)
                                                                        .copyWith()
                                                                        .size
                                                                        .height /
                                                                    2.5,
                                                                width: MediaQuery.of(
                                                                            context)
                                                                        .copyWith()
                                                                        .size
                                                                        .width /
                                                                    2.4,
                                                                margin: EdgeInsets
                                                                    .only(
                                                                        top: 6),
                                                              )
                                                            ]));
                                                  });
                                            }
                                          }),
                                    )),
                              ],
                            ),
                            Positioned(
                              left:
                                  MediaQuery.of(context).copyWith().size.width /
                                      2.85,
                              child: AnimatedOpacity(
                                opacity: gostergizle ? 1.0 : 0.0,
                                duration: Duration(seconds: 1),
                                child: Visibility(
                                  visible: gostergizle,
                                  child: AnimatedOpacity(
                                    opacity: gostergizle ? 1.0 : 0.0,
                                    duration: Duration(seconds: 1),
                                    child: Container(
                                      height: 120,
                                      width: MediaQuery.of(context)
                                              .copyWith()
                                              .size
                                              .width /
                                          1.6,
                                      color: Colors.black.withOpacity(0.9),
                                      margin: EdgeInsets.only(left: 9),
                                      child: Column(
                                        children: <Widget>[
                                          SizedBox(
                                            height: 10,
                                          ),
                                          Container(
                                              alignment: Alignment.topLeft,
                                              margin: EdgeInsets.only(left: 20),
                                              child: Text(
                                                  "Okunan Kitap Sayısı: " +
                                                      kitapsayisi.toString(),
                                                  style: TextStyle(
                                                      color: Colors.white,
                                                      fontSize: 20))),
                                          SizedBox(
                                            height: 20,
                                          ),
                                          Container(
                                            alignment: Alignment.centerRight,
                                            width: MediaQuery.of(context)
                                                    .copyWith()
                                                    .size
                                                    .width /
                                                2.8,
                                            height: MediaQuery.of(context)
                                                    .copyWith()
                                                    .size
                                                    .height /
                                                16,
                                            color: Color(0xffffc107),
                                            child: SizedBox(
                                              height: double.infinity,
                                              width: double.infinity,
                                              child: FlatButton(
                                                onPressed: () {
                                                  setState(() {
                                                    gostergizle = false;
                                                    kitapekle = true;
                                                  });
                                                },
                                                color: Color(0xffffc107)
                                                    .withOpacity(0),
                                                hoverColor: Color(0xffffc107),
                                                child: Row(
                                                  children: <Widget>[
                                                    Text(
                                                      "Kitap Ekle",
                                                      style: TextStyle(
                                                          fontSize: 20),
                                                    ),
                                                    Icon(Icons.note_add)
                                                  ],
                                                ),
                                              ),
                                            ),
                                          )
                                        ],
                                      ),
                                    ),
                                  ),
                                ),
                              ),
                            ),
                            Positioned(
                              left:
                                  MediaQuery.of(context).copyWith().size.width /
                                      8,
                              top: MediaQuery.of(context)
                                      .copyWith()
                                      .size
                                      .height /
                                  4,
                              child: AnimatedOpacity(
                                opacity: kitapekle ? 1.0 : 0.0,
                                duration: Duration(seconds: 1),
                                child: Visibility(
                                    visible: kitapekle,
                                    child: Container(
                                      decoration: BoxDecoration(
                                        borderRadius: BorderRadius.circular(50),
                                        color: Colors.black.withOpacity(0.9),
                                      ),
                                      padding: EdgeInsetsDirectional.only(
                                          bottom: 20),
                                      height: MediaQuery.of(context)
                                              .copyWith()
                                              .size
                                              .height /
                                          3.2,
                                      width: MediaQuery.of(context)
                                              .copyWith()
                                              .size
                                              .width /
                                          1.3,
                                      child: Column(
                                        children: <Widget>[
                                          Row(
                                            children: <Widget>[
                                              Container(
                                                  width: MediaQuery.of(context)
                                                          .size
                                                          .width /
                                                      2.3,
                                                  margin: EdgeInsets.only(
                                                      left:
                                                          MediaQuery.of(context)
                                                                  .size
                                                                  .width /
                                                              8,
                                                      top:
                                                          MediaQuery.of(context)
                                                                  .size
                                                                  .height /
                                                              50),
                                                  child: Visibility(
                                                    visible: hatavisible,
                                                    child: Text(
                                                      hatamesaji,
                                                      style: TextStyle(
                                                          color: Colors.red,
                                                          fontSize: 15),
                                                    ),
                                                  )),
                                              Container(
                                                  height: 20,
                                                  width: 20,
                                                  color: Color(0xffffc107),
                                                  margin: EdgeInsets.only(
                                                      left:
                                                          MediaQuery.of(context)
                                                                  .size
                                                                  .width /
                                                              10,
                                                      top:
                                                          MediaQuery.of(context)
                                                                  .size
                                                                  .height /
                                                              50),
                                                  child: FlatButton(
                                                    onPressed: () {
                                                      setState(() {
                                                        kitapekle = false;
                                                        oneri = false;
                                                      });
                                                    },
                                                    child: Text(
                                                      "X",
                                                      style: TextStyle(
                                                          color: Colors.black),
                                                      textAlign: TextAlign.end,
                                                    ),
                                                  )),
                                            ],
                                          ),
                                          Expanded(
                                            child: Stack(
                                              children: <Widget>[
                                                Container(
                                                    width:
                                                        MediaQuery.of(context)
                                                                .copyWith()
                                                                .size
                                                                .width /
                                                            2,
                                                    child: YaziAlani()),
                                              ],
                                            ),
                                          ),
                                          Container(
                                            width: MediaQuery.of(context)
                                                    .copyWith()
                                                    .size
                                                    .width /
                                                2,
                                            alignment: Alignment.topCenter,
                                            margin: EdgeInsetsDirectional.only(
                                                bottom: 10),
                                            color: Colors.white,
                                            child: Row(
                                              children: <Widget>[
                                                Container(
                                                  color: Color(0xffffc107),
                                                  width: 30,
                                                  height: 35,
                                                  child: Icon(
                                                    Icons.person,
                                                    color: Colors.black,
                                                  ),
                                                ),
                                                Expanded(
                                                  child: Column(
                                                    children: <Widget>[
                                                      Container(
                                                        height: 35,
                                                        color: Colors.white,
                                                        child:
                                                            SingleChildScrollView(
                                                          padding:
                                                              EdgeInsets.only(
                                                                  bottom: 2),
                                                          reverse: true,
                                                          child: TextField(
                                                            onChanged: (text) {
                                                              setState(() {
                                                                oneri = true;

                                                                print(
                                                                    oneriListeString);

                                                                yazarAdiBul();
                                                                oneriListe
                                                                        .text =
                                                                    yazarAdi[0];
                                                              });
                                                            },
                                                            onEditingComplete:
                                                                () {
                                                              setState(() {
                                                                oneri = false;
                                                              });
                                                            },
                                                            onTap: () {
                                                              setState(() {
                                                                oneri = false;
                                                              });
                                                            },
                                                            scrollPhysics:
                                                                NeverScrollableScrollPhysics(),
                                                            minLines: 1,
                                                            maxLines: 1,
                                                            style: TextStyle(
                                                                fontSize: 20),
                                                            textAlign:
                                                                TextAlign.start,
                                                            decoration:
                                                                InputDecoration(
                                                              border:
                                                                  InputBorder
                                                                      .none,
                                                              hintText:
                                                                  "Yazar Adı Giriniz",
                                                            ),
                                                            controller:
                                                                _kontoller[1],
                                                          ),
                                                        ),
                                                      ),
                                                    ],
                                                  ),
                                                )
                                              ],
                                            ),
                                          ),
                                          Container(
                                            width: MediaQuery.of(context)
                                                    .copyWith()
                                                    .size
                                                    .width /
                                                2,
                                            alignment: Alignment.topCenter,
                                            margin: EdgeInsetsDirectional.only(
                                                bottom: 10),
                                            color: Colors.white,
                                            child: Row(
                                              children: <Widget>[
                                                Container(
                                                  color: Color(0xffffc107),
                                                  width: 30,
                                                  height: 35,
                                                  child: Icon(
                                                    Icons.person,
                                                    color: Colors.black,
                                                  ),
                                                ),
                                                Expanded(
                                                  child: Column(
                                                    children: <Widget>[
                                                      Container(
                                                        height: 35,
                                                        color: Colors.white,
                                                        child:
                                                            SingleChildScrollView(
                                                          padding:
                                                              EdgeInsets.only(
                                                                  bottom: 2),
                                                          reverse: true,
                                                          child: TextField(
                                                            onTap: () {
                                                              var route =
                                                                  MaterialPageRoute(
                                                                builder: (BuildContext
                                                                        context) =>
                                                                    Tarayici(),
                                                              );
                                                              Navigator.of(
                                                                      context)
                                                                  .push(route);
                                                              setState(() {
                                                                webviewVisible =
                                                                    true;
                                                              });
                                                            },
                                                            scrollPhysics:
                                                                NeverScrollableScrollPhysics(),
                                                            minLines: 1,
                                                            maxLines: 1,
                                                            style: TextStyle(
                                                                fontSize: 20),
                                                            textAlign:
                                                                TextAlign.start,
                                                            decoration:
                                                                InputDecoration(
                                                              border:
                                                                  InputBorder
                                                                      .none,
                                                              hintText:
                                                                  "Kapak Fotosu",
                                                            ),
                                                            controller:
                                                                _kontoller[2],
                                                          ),
                                                        ),
                                                      ),
                                                    ],
                                                  ),
                                                )
                                              ],
                                            ),
                                          ),
                                          Container(
                                            width: MediaQuery.of(context)
                                                    .copyWith()
                                                    .size
                                                    .width /
                                                2.8,
                                            height: MediaQuery.of(context)
                                                    .copyWith()
                                                    .size
                                                    .height /
                                                16,
                                            color: Color(0xffffc107),
                                            child: FlatButton(
                                              onPressed: () {
                                                setState(() {
                                                  int x = 0;
                                                  _kontoller.forEach((element) {
                                                    if (element.text == "") {
                                                      x = x + 1;
                                                    }
                                                  });
                                                  if (x != 0) {
                                                    hatamesaji =
                                                        "*Lütfen boş bırakmayınız";
                                                    hatavisible = true;
                                                  } else {
                                                    kitapekle = false;
                                                    hatavisible = false;
                                                    hatamesaji =
                                                        "*Lütfen boş bırakmayınız";
                                                    insertData();
                                                    _kontoller
                                                        .forEach((element) {
                                                      element.text = "";
                                                    });
                                                    x = 0;
                                                  }

                                                  var route = MaterialPageRoute(
                                                    builder: (BuildContext
                                                            context) =>
                                                        Sayfa2(ad: isim.text),
                                                  );

                                                  Navigator.of(context)
                                                      .push(route);
                                                  oneri = false;
                                                });
                                              },
                                              color: Color(0xffffc107)
                                                  .withOpacity(0),
                                              child: Text(
                                                "Kitap Ekle",
                                                style: TextStyle(fontSize: 20),
                                              ),
                                            ),
                                          ),
                                        ],
                                      ),
                                    )),
                              ),
                            ),
                            Positioned(
                                width: MediaQuery.of(context).size.width / 2,
                                top: MediaQuery.of(context).size.height / 2.46,
                                left:
                                    MediaQuery.of(context).size.width / 3.85541,
                                child: Container(
                                  height: 50,
                                  width: 100,
                                  child: Visibility(
                                    visible: oneri,
                                    child: ListView.builder(
                                        itemCount: 1,
                                        reverse: true,
                                        itemBuilder:
                                            (BuildContext context, int index) {
                                          return Container(
                                            height: 50,
                                            alignment: Alignment.topCenter,
                                            margin: EdgeInsetsDirectional.only(
                                                bottom: 1),
                                            color:
                                                Colors.black.withOpacity(0.7),
                                            child: IntrinsicHeight(
                                              child: Row(
                                                crossAxisAlignment:
                                                    CrossAxisAlignment.stretch,
                                                children: <Widget>[
                                                  Expanded(
                                                    child: Container(
                                                      child:
                                                          SingleChildScrollView(
                                                        child: TextField(
                                                          textAlign:
                                                              TextAlign.center,
                                                          style: TextStyle(
                                                              color:
                                                                  Colors.white,
                                                              fontSize: 20),
                                                          controller:
                                                              oneriListe,
                                                          readOnly: true,
                                                          onTap: () {
                                                            _kontoller[1].text =
                                                                oneriListe.text;
                                                            oneri = false;
                                                          },
                                                        ),
                                                      ),
                                                    ),
                                                  )
                                                ],
                                              ),
                                            ),
                                          );
                                        }),
                                  ),
                                )),
                          ]),
                        ),
                      ],
                    ),
                  ],
                ),
              ),
            ),
          ),
        ),
      ),
    );
  }
}

class YaziAlani extends StatefulWidget {
  @override
  _YaziAlaniState createState() => _YaziAlaniState();
}

class _YaziAlaniState extends State<YaziAlani> {
  var yaziAlaniText = ["Kitap adı giriniz"];

  @override
  Widget build(BuildContext context) {
    return ListView.builder(
        physics: NeverScrollableScrollPhysics(),
        itemCount: yaziAlaniText.length,
        reverse: true,
        itemBuilder: (BuildContext context, int index) {
          return Container(
            alignment: Alignment.topCenter,
            margin: EdgeInsetsDirectional.only(bottom: 10),
            color: Colors.white,
            child: Row(
              children: <Widget>[
                Container(
                  color: Color(0xffffc107),
                  width: 30,
                  height: 35,
                  child: Icon(
                    Icons.person,
                    color: Colors.black,
                  ),
                ),
                Expanded(
                  child: Column(
                    children: <Widget>[
                      Container(
                        height: 35,
                        color: Colors.white,
                        child: SingleChildScrollView(
                          reverse: true,
                          child: TextField(
                            scrollPhysics: NeverScrollableScrollPhysics(),
                            minLines: 1,
                            maxLines: 1,
                            style: TextStyle(fontSize: 20),
                            textAlign: TextAlign.start,
                            decoration: InputDecoration(
                              border: InputBorder.none,
                              hintText: "${yaziAlaniText[index]}",
                            ),
                            controller: _kontoller[index],
                          ),
                        ),
                      ),
                    ],
                  ),
                )
              ],
            ),
          );
        });
  }
}

class Tarayici extends StatefulWidget {
  @override
  _TarayiciState createState() => _TarayiciState();
}

class _TarayiciState extends State<Tarayici> {
  var x;
  void urlYaz() async {
    x = await web.requestImageRef();

    print(x);
    x.toString();
    x = x.toString().split('url:')[1].split('}')[0].trim();
    print(x);
    if (x.toString().endsWith(".jpg")) {
      web.loadUrl(url: "https://www.google.com.tr/imghp?hl=tr&tab=wi&ogbl");
      setState(() {
        var route = MaterialPageRoute(
          builder: (BuildContext context) => Sayfa2(ad: isim.text),
        );
        Navigator.of(context).push(route);
        _kontoller[2].text = x;

        x = null;
      });
    }
  }

  @override
  Widget build(BuildContext context) {
    return SafeArea(
      child: Stack(
        children: <Widget>[
          Container(
              height: MediaQuery.of(context).size.height,
              width: MediaQuery.of(context).size.width,
              child: InAppWebView(
                  onWebViewCreated: (InAppWebViewController c) {
                    web = c;
                  },
                  initialUrl:
                      'https://www.google.com.tr/imghp?hl=tr&tab=wi&ogbl')),
          Align(
              heightFactor: 11,
              alignment: Alignment.bottomCenter,
              child: Container(
                  child: FloatingActionButton(
                heroTag: "indir",
                onPressed: () {
                  urlYaz();
                },
                child: Icon(Icons.file_download),
              ))),
          Align(
              alignment: Alignment.topLeft,
              child: Container(
                  child: FloatingActionButton(
                heroTag: "geri",
                onPressed: () {
                  web.goBack();
                },
                child: Icon(
                  Icons.arrow_back,
                ),
              ))),
          Align(
              alignment: Alignment.topRight,
              child: Container(
                  child: FloatingActionButton(
                      heroTag: "kapat",
                      onPressed: () {
                        web.loadUrl(
                            url:
                                "https://www.google.com.tr/imghp?hl=tr&tab=wi&ogbl");
                        setState(() {
                          var route = MaterialPageRoute(
                            builder: (BuildContext context) =>
                                Sayfa2(ad: isim.text),
                          );
                          Navigator.of(context).push(route);
                        });
                      },
                      child: Icon(Icons.close))))
        ],
      ),
    );
  }
}
