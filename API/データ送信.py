import requests

url = 'http://127.0.0.1:5000/add_book'
data = {'name': 'The Great Gatsby', 'impression': 'A classic novel.'}

response = requests.post(url, json=data)

# レスポンスの確認
print(response.status_code)
print(response.json())
