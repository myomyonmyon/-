from bs4 import BeautifulSoup
import requests
from openpyxl import Workbook
import os

# スクリプトが実行されるディレクトリのパスを取得
current_directory = os.path.dirname(os.path.abspath(__file__))

# 対象のURL
url = "https://sumaity.com/chintai/hiroshima/higashihiroshima/"

# ページのHTMLを取得
response = requests.get(url)
html = response.text

# BeautifulSoupでHTMLを解析
soup = BeautifulSoup(html, "html.parser")

# 建物名を収集するための空のリスト
building_names = []

# classがbuildingNameのdivタグを取得,building_divsはリスト
building_divs = soup.find_all("div", class_="buildingName")

# 取得したdivタグ内のaタグから建物名を抽出してリストに追加
for div in building_divs: #buildeing_divsリストを一つずつdivに代入
    a_tag = div.find("a")  # div内から最初のaタグを取得
    if a_tag: #aタグがない場合はa_tag変数は存在しないためif以下は無視される
        building_names.append(a_tag.text.strip()) #aタグ内の文字列を取得し、空白を取り除いてリストに追加

# エクセルファイルに結果をまとめる
wb = Workbook()
ws = wb.active

# タイトル行
ws.append(["建物名"])

# 建物名をエクセルに書き込む
for name in building_names:
    ws.append([name])

# エクセルファイルの保存先パス
excel_file_path = os.path.join(current_directory, "building_names.xlsx")

# エクセルファイル保存
wb.save(excel_file_path)
print(f"エクセルファイルが保存されました: {excel_file_path}")
