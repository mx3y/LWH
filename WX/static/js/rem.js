browser();
$(window).resize(function() {
 browser();
});
function browser(){
	var browser={  
    versions:function(){   
     	var u = navigator.userAgent, app = navigator.appVersion;   
     	return {   
	       trident: u.indexOf('Trident') > -1, //IE 
	       presto: u.indexOf('Presto') > -1, //opera
	       webKit: u.indexOf('AppleWebKit') > -1, //
	       gecko: u.indexOf('Gecko') > -1 && u.indexOf('KHTML') == -1, //
	       mobile: !!u.match(/AppleWebKit.*Mobile.*/), // 
	       ios: !!u.match(/\(i[^;]+;( U;)? CPU.+Mac OS X/), //
	       android: u.indexOf('Android') > -1 || u.indexOf('Linux') > -1, //
	       iPhone: u.indexOf('iPhone') > -1 , //
	       iPad: u.indexOf('iPad') > -1, //  
	       webApp: u.indexOf('Safari') == -1 //
	      };  
	      }(),  
	      language:(navigator.browserLanguage || navigator.language).toLowerCase()  
	}  
  	if(browser.versions.mobile || browser.versions.ios || browser.versions.android ||   
    browser.versions.iPhone || browser.versions.iPad || !!1){	   
    	var myHTML = document.querySelector("html"),
			myWidth = window.innerWidth > 414 ? 414 : window.innerWidth;
			
		var size = 	100 * myWidth / 414;	

		myHTML.style.fontSize = size + 'px';
		window.onresize = function() {
			var myHTML = document.querySelector("html"),
			myWidth = window.innerWidth;
			myHTML.style.fontSize = size + 'px';
		}
  }
}



