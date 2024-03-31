//======================================================================
// Main function
//======================================================================

var map = L.map('map', {
	 //center: [35.6920, 140.0486], 
	 center: [34.4310, 132.7437], 
	 maxBounds: [[34.6500, 132.5300], [34.2500, 133.0000]],
     zoom: 17,
     preferCanvas: true, //trueとし、Canvasレンダラーを選択
     closePopupOnClick: false // ポップアップを開いたままにする default true
});

map.attributionControl.addAttribution('Adjustment：<a href="http://www.chuo-kantei.co.jp/", class="your_class">中央鑑定所</a>');

// 背景地図設定

// 背景図①
var t_std = new L.tileLayer('http://cyberjapandata.gsi.go.jp/xyz/std/{z}/{x}/{y}.png', {
    attribution: "<a href='http://maps.gsi.go.jp/development/ichiran.html' target='_blank'>地理院タイル（標準地図）</a>",
    maxNativeZoom: 18,    // 背景地図の最大Zoomレベル
    maxZoom: 21,          // 拡大したいZoomレベル
    opacity:1.0             // 透過度
});

// 背景図②
var t_pale18 = new L.tileLayer('http://cyberjapandata.gsi.go.jp/xyz/pale/{z}/{x}/{y}.png', {
    attribution: "<a href='http://maps.gsi.go.jp/development/ichiran.html' target='_blank'>地理院タイル（淡色地図）</a>",
    minNativeZoom: 18,    // 背景地図の最小Zoomレベル
    maxNativeZoom: 18,    // 背景地図の最大Zoomレベル
    minZoom: 16,          // 縮小したいZoomレベル
    maxZoom: 21,          // 拡大したいZoomレベル
    opacity:1.0           // 透過度
}).addTo(map);

// 背景図③
var t_pale16 = new L.tileLayer('http://cyberjapandata.gsi.go.jp/xyz/pale/{z}/{x}/{y}.png', {
    attribution: "<a href='http://maps.gsi.go.jp/development/ichiran.html' target='_blank'>地理院タイル（淡色地図）</a>",
    minNativeZoom: 15,    // 背景地図の最小Zoomレベル
    maxNativeZoom: 16,    // 背景地図の最大Zoomレベル
    minZoom: 13,          // 縮小したいZoomレベル
    maxZoom: 17,          // 拡大したいZoomレベル
    opacity:0.8           // 透過度
});

// 背景図④
var t_pale14 = new L.tileLayer('http://cyberjapandata.gsi.go.jp/xyz/pale/{z}/{x}/{y}.png', {
    attribution: "<a href='http://maps.gsi.go.jp/development/ichiran.html' target='_blank'>地理院タイル（淡色地図）</a>",
    minNativeZoom: 14,    // 背景地図の最小Zoomレベル
    maxNativeZoom: 14,    // 背景地図の最大Zoomレベル
    minZoom: 11,          // 縮小したいZoomレベル
    maxZoom: 14,          // 拡大したいZoomレベル
    opacity:0.8           // 透過度
});

// 背景図⑤
var t_blank = new L.tileLayer('https://cyberjapandata.gsi.go.jp/xyz/blank/{z}/{x}/{y}.png', {
    attribution: "<a href='http://maps.gsi.go.jp/development/ichiran.html' target='_blank'>地理院タイル（白地図）</a>",
    maxNativeZoom: 14,    // 背景地図の最大Zoomレベル
    maxZoom: 20,          // 拡大したいZoomレベル
    opacity:1.0           // 透過度
});

// 背景図⑥
var t_ort = new L.tileLayer('https://cyberjapandata.gsi.go.jp/xyz/seamlessphoto/{z}/{x}/{y}.jpg', {
    attribution: "<a href='http://maps.gsi.go.jp/development/ichiran.html' target='_blank'>地理院タイル（空中写真）</a>",
    maxNativeZoom: 18,    // 背景地図の最大Zoomレベル
    minZoom: 14,          // 縮小したいZoomレベル
    maxZoom: 21,          // 拡大したいZoomレベル
    opacity:0.6           // 透過度
});

// 背景図レイヤ設定
var base_Map = {
    "地理院タイル（標準地図）": t_std,
    "地理院タイル（淡色18）": t_pale18,
    "地理院タイル（淡色16）": t_pale16,
    "地理院タイル（淡色14）": t_pale14,
    "地理院タイル（白地図）": t_blank
};


//var myRenderer = L.canvas({ padding: 0.5 });
// ペイン 'CircleMarkers' を作る
map.createPane('CircleMarkers');
map.createPane('Polygon');
// ペイン 'CircleMarkers' のスタイルを設定（zIndexの設定）
map.getPane('CircleMarkers').style.zIndex = 655;
//map.getPane('Polygon').style.zIndex = 250;
//マウスポインターのイベントの無効化
//map.getPane('CircleMarkers').style.pointerEvents = 'none';


//マーカー情報保持
var markers=[];

    //マーカー情報を配列に保持する
    markers[0]=L.marker([34.42640, 132.74330]).bindPopup("東広島市役所");
    markers[1]=L.marker([34.44077, 132.69221]).bindPopup("八本松出張所");
    markers[2]=L.marker([34.44786, 132.78764]).bindPopup("高屋出張所");
    markers[3]=L.marker([34.49925, 132.66025]).bindPopup("志和出張所");
    markers[4]=L.marker([34.32474, 132.67625]).bindPopup("黒瀬支所");
    markers[5]=L.marker([34.53625, 132.77813]).bindPopup("福富支所");
    markers[6]=L.marker([34.56357, 132.82479]).bindPopup("豊栄支所");
    markers[7]=L.marker([34.47221, 132.88838]).bindPopup("河内支所");
    markers[8]=L.marker([34.31958, 132.81372]).bindPopup("安芸津支所");

var markerLayer_1 = L.layerGroup([markers[0], markers[1], markers[2], markers[3],markers[4], markers[5], markers[6], markers[7], markers[8] ]);
markerLayer_1.addTo(map);   //Adding layer group to map

//var GeoJSONLayer_1 = L.geoJson(HP).addTo(map);
var GeoJSONLayer_1 = L.geoJson(HP,{
	//filter: function(feature) { return feature.properties.L02_001 == 5 || feature.properties.L02_001 == 9},  //フィルター
    pointToLayer: function(feature,latlng){
    	var TNO = feature.properties.通し番号;
    	var CO1 = feature.properties.分類コード;
    	   //色分け設定
            var SENTc = feature.properties.分類コード;
              if( SENTc == "1" ) { var col = "#ff0000"; }
              	   else if( SENTc == "21" ) { var col = "#0000ff"; }
              	   else if( SENTc == "22" ) { var col = "#006400"; }
              	            else { var col = "#000000"; }; 
    	    //色分け設定ここまで
    	    
    	var JNO = feature.properties.番号;
    	var SYO = feature.properties.所在;
    	var TIB = feature.properties.地番;
    	var EST = feature.properties.想定;
    	var PRI = feature.properties.単価;
    	var TOS = feature.properties.建付;
    	var TOT = feature.properties.登記上地目;
    	var TOM = feature.properties.登記上地積.toLocaleString();

        var Puptxt = "通番： " + TNO + "<br>" +  "番号： " + JNO + "<br>" + SYO + TIB + "<br>" +  "想定： " + EST + "<br>" + "単価： " + PRI + " " + TOS + "<br>" + TOT + " " + TOM + " ㎡";
        var Ttiptxt = "通番： " + TNO + "<br>" +  "番号： " + JNO + "<br>" + SYO + TIB + "<br>" +  "想定： " + EST + "<br>" + "単価： " + PRI + " " + TOS + "<br>" + TOT + " " + TOM + " ㎡";

        //var Ttiptxt = "標 " + Hname + " "  + R04HI + "<br>" + R02AT + "<br>" + R02HKp + "<br>" + R02KKp + "<br>" + R02JSp + "<br>" + R03JSp + "<br>" + R04JSp + "<br>"  + R04HKp;

        // ポイントのスタイルを設定
        var CM1 = L.circleMarker(latlng,{
        	                           //renderer: myRenderer, 
        	                           color: '#ff0000',
        	                           zIndexOffset: 800,    // z-index が +200 される
           	                           weight: 2,
           	                           opacity: 1.0,
           	                           fillColor: col,
           	                           fillOpacity: 0.7,
           	                           radius: 7
                }).bindPopup(Puptxt,{autoClose:false})
                  .bindTooltip(Ttiptxt).openTooltip();
           	                                       //　popupを自動で閉じない
        return CM1;
    }
}).addTo(map);
//.bringToFront();

///////////////////////検索用//////////////////////////////////////////
// Plugin leaflet-fusesearch の設定
var searchCtrl = L.control.fuseSearch()
searchCtrl.addTo(map);

// Layer control, setting
var layerCtrl = L.control.layers();
var featureLayer = L.featureGroup();
layerCtrl.addOverlay(featureLayer);
featureLayer.addTo(map);

// 各地点（Feature）をマーカーで表示・ポップアップの設定
displayFeatures(HP.features, featureLayer);

var props = ['通し番号', '番号', '所在','地番','登記上地目']; // 検索の文言に使用する properties を指定
searchCtrl.indexFeatures(HP.features, props);

function displayFeatures(features, layer) {
    for (var id in features) {
        var feat = features[id];
        var site = L.geoJson(feat, {
            pointToLayer: function(feature, latLng) {
                marker = L.circleMarker(latLng, {
                     keyboard: false,
                     interactive: false,  //マウスイベントを発生させない
                     riseOnHover: true,
                     opacity: 0.0,
           	         fillOpacity: 0.0
                });
                return marker;
            },
            onEachFeature: bindPopup
        });
        layer.addLayer(site);
    }
    return layer;
}

function bindPopup(feature, layer) {
    feature.layer = layer;
    var props = feature.properties;
    if (props) {
        var desc = '<span id="feature-popup" style="background-color:#FFCBCB;">';
            desc += '<strong>' + props.通し番号 + '</strong> '+feature.properties.登記上地目+'<br/>';
            desc += props.所在 + props.地番 + '</span>';
        layer.bindPopup(desc);
    }
}

////////////////////////////////////////////////////////////////////////////////////////////////////

// MiniMapの表示
var t_pale = new L.tileLayer('http://cyberjapandata.gsi.go.jp/xyz/pale/{z}/{x}/{y}.png', {
    minZoom: 0,          // 縮小したいZoomレベル
    maxZoom: 20,          // 拡大したいZoomレベル
    opacity:1.0           // 透過度
});

var layers = new L.LayerGroup([t_pale]);
var MiniMap = new L.Control.MiniMap(layers, { toggleDisplay: true, width: 240, height:160, zoomLevelOffset:-4 }).addTo(map);


// 経度･緯度の表示
map.on('click ', function(e) {
    // クリック位置の経度･緯度の取得
        lat = e.latlng.lat;
        lng = e.latlng.lng;
    // 四捨五入処理
        lat2 = Math.round( lat * 100000) / 100000
        lng2 = Math.round( lng * 100000) / 100000
    // 経緯度表示
        //alert("緯度: " + lat2 + "\n経度: " + lng2);
        //prompt( "クリック位置の座標 緯度 , 経度" , lat2 + ", " + lng2 );
        prompt( "クリック位置の座標 経度 , 緯度" , lng2 + ", " + lat2 );
});


//別ウィンドウで開くサンプル
function hanrei01() {
    window.open("./hanrei01.html","mywindow","width=200,height=500");
}


//オーバーレイヤ設定
var overlays = {
   "施設（市役所・支所）": markerLayer_1,
   "新スキーム": GeoJSONLayer_1,
   "地理院タイル（空中写真）": t_ort
}


// ズームレベルに応じてレイヤを表示-非表示
map.on('zoomend', function(e) {
  var zoom = map.getZoom();
  if (map.hasLayer(t_std) == true ){""
  }
  else{
    if (zoom <= 11) {
      if (map.hasLayer(t_blank)  == false){map.addLayer(t_blank);};
      if (map.hasLayer(t_pale14) == true ){map.removeLayer(t_pale14);};
      if (map.hasLayer(t_pale16) == true ){map.removeLayer(t_pale16);};
      if (map.hasLayer(t_pale18) == true ){map.removeLayer(t_pale18);};
      if (map.hasLayer(t_ort) == true ){map.removeLayer(t_ort);}
    }
    else if (zoom > 11 && zoom <= 13) {
      if (map.hasLayer(t_blank)  == true ){map.removeLayer(t_blank);};
      if (map.hasLayer(t_pale14) == false){map.addLayer(t_pale14);};
      if (map.hasLayer(t_pale16) == true ){map.removeLayer(t_pale16);};
      if (map.hasLayer(t_pale18) == true ){map.removeLayer(t_pale18);};
      if (map.hasLayer(t_ort) == true ){map.removeLayer(t_ort);}
    }
    else if (zoom > 13 && zoom <= 16) {
      if (map.hasLayer(t_blank)  == true ){map.removeLayer(t_blank);};
      if (map.hasLayer(t_pale14) == true ){map.removeLayer(t_pale14);};
      if (map.hasLayer(t_pale16) == false){map.addLayer(t_pale16);};
      if (map.hasLayer(t_pale18) == true ){map.removeLayer(t_pale18);}
    }
      else if (zoom > 16) {
      if (map.hasLayer(t_blank)  == true ){map.removeLayer(t_blank);};
      if (map.hasLayer(t_pale14) == true ){map.removeLayer(t_pale14);};
      if (map.hasLayer(t_pale16) == true ){map.removeLayer(t_pale16);};
      if (map.hasLayer(t_pale18) == false){map.addLayer(t_pale18);}
    }
  }
});


// レイヤのコントロールパネル設定
//L.control.layers(overlays).addTo(map);
L.control.layers(base_Map, overlays, { collapsed: false, position: 'topleft' }).addTo(map);
//L.control.opacityLayers(base_Map, overlays, { collapsed: false }).addTo(map);//透過


//目標へ移動
function popupOn(id){
    var latlng=markers[id].getLatLng();
    //alert('経度･緯度の表示 '+(latlng));
    markers[id].openPopup();
    //↑↓順番を変えると動作が少し変わります
    //map.panTo(latlng);
    map.flyTo(latlng);
}


//スケールバーの設置
//L.control.scale({ metric: true }).addTo(map);
L.control.scale({ imperial: false , metric: true , maxWidth: 150 }).addTo(map);


