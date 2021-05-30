import 'dart:io';

import 'package:path_provider/path_provider.dart';
import 'package:sqflite/sqflite.dart';
import "package:path/path.dart";

class DatabaseHelper {
  static final _dbname = 'kutuphane.db';
  static final _dbVersion = 1;
  static final table = 'Kutuphane';
  static final columnid = 'id';
  static final columnKAdi = 'kitap_ad';
  static final columnYAdi = 'yazar_ad';
  static final columnKK = 'kitap_kapak';
  static final columnUser = 'kullanici_ad';

  static Database _database;

  DatabaseHelper._privateConstructor();
  static final DatabaseHelper instance = DatabaseHelper._privateConstructor();
  Future<Database> get database async {
    if (_database != null) return _database;
    _database = await initDatabase();
    return _database;
  }

  initDatabase() async {
    Directory directory = await getApplicationDocumentsDirectory();
    String path = join(directory.path, _dbname);
    return await openDatabase(path, version: _dbVersion, onCreate: _onCreate);
  }

  Future _onCreate(Database db, int version) {
    return db.execute('''
        CREATE TABLE $table ( 
        $columnid INTEGER PRIMARY KEY,
        $columnKAdi TEXT NOT NULL,
        $columnYAdi TEXT NOT NULL,
        $columnKK  TEXT NOT NULL,
        $columnUser TEXT NOT NULL)
      ''');
  }

  Future<int> insert(Map<String, dynamic> row) async {
    Database db = await instance.database;
    return await db.insert(table, row);
  }

  Future<List<Map<String, dynamic>>> queryall() async {
    Database db = await instance.database;
    return await db.query(table, orderBy: columnKAdi);
  }

  Future<int> deleteData(int id) async {
    Database db = await instance.database;
    var res = await db.delete(table, where: "id = ?", whereArgs: [id]);
    return res;
  }

  Future<List<Map<String, dynamic>>> arama(String arama) async {
    Database db = await instance.database;
    var res = await db.query(table,
        where: "kitap_ad LIKE ? or yazar_ad LIKE ?",
        whereArgs: ['%$arama%', '%$arama%'],
        orderBy: columnKAdi);
    return res;
  }

  Future<List<Map<String, dynamic>>> yazarAdi(String arama) async {
    Database db = await instance.database;
    var res = await db.rawQuery(
        "Select distinct $columnYAdi  from $table where $columnYAdi Like ('%$arama%')");

    return res;
  }
}
