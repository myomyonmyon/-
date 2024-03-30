import pandas as pd
from geopy.distance import geodesic
import requests
import os

# Google Maps APIキー(YOUR_API_KEYをAPIキーにすると動きます)
API_KEY = 'YOUR_API_KEY'

# スクリプトのディレクトリとファイル名を結合
file_path = os.path.join(os.path.dirname(os.path.abspath(__file__)), '役所.xlsx')

# エクセルファイルから地点情報を読み取る,pandasライブラリのpd.read_excel関数による
df = pd.read_excel(file_path, header=None, names=['出発', '終着', '終着地点名'])  # ヘッダーがない場合は header=None を追加

# 結果を保存するデータフレームを作成,データフレームはpandas特有の機能
results = []

# すべての1列目の地点から2列目の各地点への距離を計算
#読み取ったデータの行数だけ繰り返す(len(df)),i：0→データ行数まで繰り返す
for i in range(len(df)):
    origin = (df.iloc[i, 0])  # 1列目を出発地の緯度経度とする,[行,列]
    
    # 1列目から2列目の各地点への距離を格納するリスト
    distances_to_destinations = []
    
    #以下のループで2列目の各地点への距離をすべて求める
    for j in range(len(df)):
        destination = (df.iloc[j, 1])  # 2列目を終着地の緯度経度とする

        # リクエストURLの構築
        url = f'https://maps.googleapis.com/maps/api/distancematrix/json?units=metric&origins={origin}&destinations={destination}&mode=walking&key={API_KEY}'

        # APIにリクエストを送信して結果を取得
        response = requests.get(url)
        #取得したjsonデータ（距離1つだけ）をPythonの辞書に変換,dataの"型"は"辞書"
        data = response.json()

        # 距離を取得,以下はPythonによる処理（ライブラリ不使用）,distanceキーはAPIが作成（多分）
        distance = data['rows'][0]['elements'][0].get('distance', {}).get('text', 'N/A')
        
        # 所要時間を取得
        duration = data['rows'][0]['elements'][0].get('duration', {}).get('text', 'N/A')
        
        # 距離(distance)と所要時間(duration)をリスト(distances_to_destinations)に追加,終着地を最終行まで繰り返し
        distances_to_destinations.append((distance, duration))
    
    # 最も短い距離を取得,minはPythonの関数,出発地から各終着地のなかで最短距離をリストから取り出す
    min_distance, min_duration = min(distances_to_destinations, key=lambda x: x[0])
    
    # 最も短い距離の終着地を特定
    min_distance_index = distances_to_destinations.index((min_distance, min_duration)) #最短距離の行数をindexで探す
    min_distance_destination = df.iloc[min_distance_index, 2]  # 3列目の終着地点名を取得
    
    # geopyライブラリを使用して最も短い距離の直線距離を取得
    min_distance_destination_location = df.iloc[min_distance_index, 1]  # 2列目の終着地点（位置）を取得
    straight_distance = geodesic(origin, min_distance_destination_location).meters
    
    # 結果をリストに追加
    results.append([origin, min_distance_destination, min_distance, min_duration, straight_distance])

# 結果をデータフレームに変換
result_df = pd.DataFrame(results, columns=['出発', '最短距離の終着', '最短距離', '所要時間', '直線距離'])

# スクリプトのディレクトリとファイル名を結合
output_file_path = os.path.join(os.path.dirname(os.path.abspath(__file__)), 'output.xlsx')

# 結果を新しいエクセルファイルに保存
with pd.ExcelWriter(output_file_path, engine='openpyxl') as writer:
    result_df.to_excel(writer, sheet_name='Sheet1', index=False)
