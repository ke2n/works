function goMenu(name){
	switch(name){
		case 'main':{
			$.get('log.aspx?p=main',function(data){
				location.href = "index2.aspx";
			});
		}break;

		case 'twit':{
			$.get('log.aspx?p=twit');
			//window.open("http://twitter.com/home?status=스마트IBK 스마트모닝 이벤트! 매일 아침 8시부터 선착순 100명에게 드리는 모닝커피 기프티콘! 실시간으로 받아가세요^^ http://blog.ibk.co.kr/157");
			location.href = "http://twitter.com/home?status=IBK 기업은행 CF 캐릭터들의 재밌는 애니메이션 영상을 즐겨보세요_http://tagtv.co.kr/ibk";
		}break;
		
		case 'twit_phone':{
			$.get('log.aspx?p=twit_phone');
			//window.open("http://twitter.com/home?status=핸드폰 요금 자동 이체하면, 전국 모든 은행 ATM수수료가 무료! http://blog.ibk.co.kr/157");
			location.href = "http://twitter.com/home?status=IBK 기업은행 CF 캐릭터들의 재밌는 애니메이션 영상을 즐겨보세요_http://tagtv.co.kr/ibk";
		}break;

		case 'twit_pay':{
			$.get('log.aspx?p=twit_pay');
			//window.open("http://twitter.com/home?status=월급 자동 이체만 해도, 전국 모든 은행 ATM 수수료가 무료! http://blog.ibk.co.kr/157");
			location.href = "http://twitter.com/home?status=IBK 기업은행 CF 캐릭터들의 재밌는 애니메이션 영상을 즐겨보세요_http://tagtv.co.kr/ibk";
		}break;

		case 'twit_style':{
			$.get('log.aspx?p=twit_style');
			//window.open("http://twitter.com/home?status=월급 자동 이체만 해도, 전국 모든 은행 ATM 수수료가 무료! http://blog.ibk.co.kr/157");
			location.href = "http://twitter.com/home?status=IBK 기업은행 CF 캐릭터들의 재밌는 애니메이션 영상을 즐겨보세요_http://tagtv.co.kr/ibk";
		}break;

		case 'ani_back':{
			$.get('log.aspx?p=ani',function(data){
				location.href = "insert_toon.aspx";
			});
		}break;

		case 'ani_1':{
			$.get('log.aspx?p=ani_1',function(data){
				location.href = "insert_toon1.html";
			});
		}break;

		case 'ani_2':{
			$.get('log.aspx?p=ani_2',function(data){
				location.href = "insert_toon2.html";
			});
		}break;

		case 'ani_3':{
			$.get('log.aspx?p=ani_3',function(data){
				location.href = "insert_toon3.html";
			});
		}break;

		case 'ani_4':{
			$.get('log.aspx?p=ani_4',function(data){
				location.href = "insert_toon4.html";
			});
		}break;

		case 'ani_5':{
			$.get('log.aspx?p=ani_5',function(data){
				location.href = "insert_toon5.html";
			});
		}break;

		case 'char':{
			$.get('log.aspx?p=char',function(data){
				location.href = "insert_char.aspx";
			});
		}break;
		
		case 'char_1':{
			$.get('log.aspx?p=char_1',function(data){
				location.href = "http://brightcove.vo.llnwd.net/d14/unsecured/media/88960803001/88960803001_790232875001_Oasis-ep01.mp4?pub-id=88960803001";
			});
		}break;

		case 'char_2':{
			$.get('log.aspx?p=char_2',function(data){
				location.href = "http://brightcove.vo.llnwd.net/d14/unsecured/media/88960803001/88960803001_790232223001_Oasis-ep04.mp4?pub-id=88960803001";
			});
		}break;

		case 'char_3':{
			$.get('log.aspx?p=char_3',function(data){
				location.href = "http://brightcove.vo.llnwd.net/d12/unsecured/media/88960803001/88960803001_639669661001_----ep6.mp4?pub-id=88960803001";
			});
		}break;

		case 'char_4':{
			$.get('log.aspx?p=char_4',function(data){
				location.href = "http://brightcove.vo.llnwd.net/d12/unsecured/media/88960803001/88960803001_639669575001_----ep7.mp4?pub-id=88960803001";
			});
		}break;


		case 'info_back':{
			if (localStorage.getItem('IBK_LOGIC') == null){
				$.get('log.aspx?p=info',function(data){
					location.href = "insert_info.aspx";
				});
			}else{
				location.href = "index2.aspx?logic="+localStorage.getItem('IBK_LOGIC');
				localStorage.removeItem('IBK_LOGIC');
			}
		}break;

		case 'info_0':{
			$.get('log.aspx?p=info_0',function(data){
				location.href = "insert_info3.html";
			});
		}break;

		case 'info_1':{
			$.get('log.aspx?p=info_1',function(data){
				location.href = "insert_info1.html";
			});
		}break;

		case 'info_2':{
			$.get('log.aspx?p=info_2',function(data){
				location.href = "insert_info2.html";
			});
		}break;
	}
}
function enableVideoClicks() {
  var videos = document.getElementsByTagName('video') || [];
  for (var i = 0; i < videos.length; i++) {
	// TODO: use attachEvent in IE
	videos[i].addEventListener('click', function(videoNode) {
	  return function() {
		videoNode.play();
	  };
	}(videos[i]));
  }
}