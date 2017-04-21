$(function () {





    $(".window-btn, .window-share-bottom a").click(function () {
        $(".window-bg, .window").hide();
    });
    $(".bottomCon").toggle(function () {
        $(".bottomCon-con").stop(true, true).slideDown();
    }, function () {
        $(".bottomCon-con").stop(true, true).slideUp();
    });

    $(".userIndex-img-tips").click(function () {
        $(this).hide();
    });

    $(".header-left-toggle").click(function () {
        $(".userIndex-img-tips").toggle();
    });


  
    $(".haha").click(function () {
        $(this).find(".icon-icon30").removeClass().addClass("icon-icon19");
        var urls = $(this).attr("haha");
        setTimeout(_show(urls), 400);
    });

	$(".haha").click(function () {
        $(this).find(".icon-icon30").removeClass().addClass("icon-icon19");
        var urls = $(this).attr("haha");
        setTimeout(_show(urls), 400);
    });

		$(".list-active li").click(function () {
        $(this).find(".icon-icon30").removeClass().addClass("icon-icon19");
        var urls = $(this).find("a").attr("haha");
        setTimeout(_show(urls), 400);
    });


	
   

});


function show(urls)
{ location.href = urls; }

function _show(urls) {
    return function () {
        show(urls)
    } 
}