import requests

# GETリクエストを作成し、/get_books エンドポイントに送信
response = requests.get('http://localhost:5000/get_books')  # サーバーがローカルで実行されている場合
# response = requests.get('http://your_server_address/get_books')  # サーバーアドレスを指定する場合

# レスポンスのステータスコードを確認
if response.status_code == 200:
    # レスポンスからJSONデータを取得
    books_data = response.json()
    # 取得した本の情報を出力
    for book in books_data['books']:
        print(f"Book Name: {book['name']}, Impression: {book['impression']}")
else:
    print("Failed to fetch books data:", response.text)
