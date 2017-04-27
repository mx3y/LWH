$(document).ready(function(){
    $("#master_name").text($.cookie("mname"));
    $(".nav-open").bind("click",function(){
        $(".nav-left").css("left","0px");
        $(".main").css("left","12%");
        $(".main").css("width","88%");
        $(".nav-open").hide();
        $(".nav-close").show();

    });
    $(".nav-close").bind("click",function(){
        $(".nav-left").css("left","-12%");
        $(".main").css("left","0px");
        $(".main").css("width","100%");
        $(".nav-close").hide();
        $(".nav-open").show();
    });
    $.ajax({ 
        type:"post", 
        url:"http://192.168.1.168/api/showLog",
        dataType:"jsonp",
        jsonp:"callback", 
        success:function(data){
            for(item in data){
                $(".show_log").append("<li>"+data[item]+"</li>");
            }
        },
        error:function(){
            alert('fail');
        }
    }); 
});