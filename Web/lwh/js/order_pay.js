 $(document).ready(function (){
        function getUrlParam(name) {
            var reg = new RegExp("(^|&)" + name + "=([^&]*)(&|$)"); //构造一个含有目标参数的正则表达式对象
            var r = window.location.search.substr(1).match(reg);  //匹配目标参数
            if (r != null) return unescape(r[2]); return null; //返回参数值
        }
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
        if(getUrlParam("id")){
            $.ajax({ 
                type:"post", 
                url:"http://192.168.1.172/api/orderPayDetial",
                data:{id:getUrlParam("id")}, 
                dataType:"jsonp",
                jsonp:"callback", 
                success:function(data){
                    $("#oid").val(data["oid"]);
                    $("#uuid").val(data["uuid"]);
                    $("#porder").val(data["porder"]);
                    $("#pwxorder").val(data["pwxorder"]);
                    $("#pmonery").val(data["pmonery"]);
                    $("#pcreatetime").val(data["pcreatetime"]);
                    $("#povertime").val(data["povertime"]);
                    $("#popenid").val(data["popenid"]);
                    $("#pstatus").val(data["pstatus"]);
                },
                error:function(){
                    alert('get-url-fail');
                }
            });
        }
        $(".panel .cancal").click(function(){
            window.location.href = "order_list.html";
        });
        $(".panel .sbt").click(function(){
            window.location.href = "order_list.html";

        });
});
