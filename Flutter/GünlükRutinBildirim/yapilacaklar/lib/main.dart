import 'dart:async';
import 'dart:io';

import 'package:flutter/material.dart';
import 'package:flutter_local_notifications/flutter_local_notifications.dart';

FlutterLocalNotificationsPlugin bildirimPlugin;
void main() {
  WidgetsFlutterBinding.ensureInitialized();
  var initializationAndroid = new AndroidInitializationSettings("app_icon");
  var initializationIOS = new IOSInitializationSettings();
  var initializationAyarlari =
      new InitializationSettings(initializationAndroid, initializationIOS);
  bildirimPlugin = new FlutterLocalNotificationsPlugin();
  bildirimPlugin.initialize(initializationAyarlari,
      onSelectNotification: (String payload) async {
    if (payload != null) {
      debugPrint('notification payload: ' + payload);
    }
  });

  runApp(MyApp());
}

var saat = [
  "23:30 - 07:30;Uyku",
  "22:00 - 23:30;Boş zaman, Yemek",
  "21:00 - 22:00;Boş zaman, Yemek",
  "20:00 - 21:00;Boş zaman, Yemek",
  "19:00 - 20:00;Boş zaman, Yemek",
  "18:30 - 19:00;Egzersiz",
  "17:00 - 18:30;Yaratıcı İş",
  "16:00 - 17:00;Yaratıcı İş",
  "15:00 - 16:00;Yaratıcı İş",
  "14:00 - 15:00;Yaratıcı İş",
  "13:00 - 14:00;Boş zaman, Yemek",
  "11:30 - 13:00;Yaratıcı İş",
  "11:00 - 11:30;Egzersiz",
  "10:00 - 11:00;Yaratıcı İş",
  "08:30 - 10:00;Boş zaman, Yemek",
  "07:30 - 08:30;Boş zaman, Yemek"
];
bool ilk = false;
Future bildirimleriGoster(String baslik, String aciklama, int channel) async {
  var androidDetails = new AndroidNotificationDetails(
      "id", "name", "description",
      enableVibration: false, playSound: false, channelShowBadge: false);

  var ios = new IOSNotificationDetails(
      presentAlert: false, presentBadge: false, presentSound: false);
  var genelBildirimDetay = new NotificationDetails(androidDetails, ios);
  //await bildirimPlugin.show(i, "title", "body", genelBildirimDetay);
  if (ilk == false) {
    await bildirimPlugin.show(channel, baslik, aciklama, genelBildirimDetay);
    ilk = true;
  } else {}
  await bildirimPlugin.periodicallyShow(
      channel, baslik, aciklama, RepeatInterval.Daily, genelBildirimDetay);
}

class MyApp extends StatelessWidget {
  // This widget is the root of your application.
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      theme: ThemeData(
        primarySwatch: Colors.blue,
        visualDensity: VisualDensity.adaptivePlatformDensity,
      ),
      home: Giris(),
    );
  }
}

class Giris extends StatefulWidget {
  @override
  _GirisState createState() => _GirisState();
}

class _GirisState extends State<Giris> {
  @override
  void initState() {
    super.initState();
  }

  @override
  Widget build(BuildContext context) {
    return Container(
      color: Colors.blue,
      child: FloatingActionButton(
        onPressed: () async {
          for (var i = 0; i < saat.length; i++) {
            sleep(Duration(milliseconds: 100));
            bildirimleriGoster(
                saat[i].split(";")[0].trim(), saat[i].split(";")[1], i);
          }
        },
      ),
    );
  }
}
