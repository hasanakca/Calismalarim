import 'package:giris/database/database_helper.dart';

class Kutuphane {
  int columnid;
  String kitapAdi;
  String yazarAdi;
  String kitapKapak;
  String kullanici;

  List<Kutuphane> kutuphane = [];
  Kutuphane(
      {this.columnid,
      this.kitapAdi,
      this.yazarAdi,
      this.kitapKapak,
      this.kullanici});

  Map<String, dynamic> toMap() {
    var map = <String, dynamic>{
      DatabaseHelper.columnKAdi: kitapAdi,
      DatabaseHelper.columnYAdi: yazarAdi,
      DatabaseHelper.columnKK: kitapKapak,
      DatabaseHelper.columnUser: kullanici,
    };
    if (columnid != null) {
      map[DatabaseHelper.columnid] = columnid;
    }
    return map;
  }

  Kutuphane.fromMap(Map<String, dynamic> map) {
    columnid = map[DatabaseHelper.columnid];
    kitapAdi = map[DatabaseHelper.columnKAdi];
    yazarAdi = map[DatabaseHelper.columnYAdi];
    kitapKapak = map[DatabaseHelper.columnKK];
    kullanici = map[DatabaseHelper.columnUser];
  }
}
