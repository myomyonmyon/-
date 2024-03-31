# FlaskとSQLAlchemyのモジュールをインポート
from flask import Flask, request, jsonify
from flask_sqlalchemy import SQLAlchemy
import os

# スクリプトが実行されるディレクトリのパスを取得
current_directory = os.path.dirname(os.path.abspath(__file__))

# Flaskアプリケーションの作成,flaskクラス,クラスがないとオブジェクトを作成できない,appはflask特有の変数
app = Flask(__name__)
# SQLiteデータベースの設定
app.config['SQLALCHEMY_DATABASE_URI'] = 'sqlite:///books.db' #Flaskアプリケーションの設定 (app.config) に、データベースの接続情報を設定
db = SQLAlchemy(app) #インスタンスの作成,SQLAlchemyクラス,FlaskアプリケーションとSQLiteデータベースを結びつける

# Bookモデルの定義
class Book(db.Model): #SQLAlchemyライブラリ,db.Modelクラスを継承(既存のクラスから、新しく作ったクラスに「変数定義」や「メソッド」などを引き継ぐこと)
    # Bookクラス(オブジェクト)がデータベースのテーブルとして振る舞う
    # プライマリーキー(id)、本の名前(name)、感想(impression)のカラムを定義
    id = db.Column(db.Integer, primary_key=True)
    name = db.Column(db.String(255), nullable=False)
    impression = db.Column(db.Text)

# /add_book エンドポイントの定義
@app.route('/add_book', methods=['POST']) #@app.route(Flaskのデコレータ) は、指定されたURLパス（この場合は /add_book）に対するリクエストを処理するための関数を指定
def add_book(): #add_book関数の定義
    # POSTリクエストからJSONデータを取得
    data = request.get_json()

    # 新しいBookオブジェクトを作成
    new_book = Book(name=data['name'], impression=data['impression'])

    # データベースに新しい本を追加
    db.session.add(new_book) #dbはSQLAlchemyクラスのインスタンス
    # 変更を保存
    db.session.commit()

    # レスポンスを返す
    return jsonify({'message': 'Book added successfully'}), 201

# /get_books エンドポイントの定義
@app.route('/get_books', methods=['GET'])
def get_books():
    # データベースからすべての本を取得
    books = Book.query.all()

    # 本のリストを作成
    book_list = []
    for book in books:
        # 本のデータを辞書に追加
        book_data = {
            'name': book.name,
            'impression': book.impression
        }
        book_list.append(book_data)

    # JSON形式で本のリストを返す
    return jsonify({'books': book_list})

# アプリケーションのエントリーポイント
if __name__ == '__main__':
    with app.app_context():  # アプリケーションコンテキストを確立
        db.create_all()
    app.run(debug=True)
