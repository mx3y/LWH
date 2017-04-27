 $(document).ready(function (){
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
            url:"http://192.168.1.172/api/masterSendEdit",
            dataType:"jsonp",
            jsonp:"callback", 
            success:function(data){
                $("#mname").val(data["mname"]);
                $("#msex").val(data["msex"]);
                $("#memail").val(data["memail"]);
                $("#mtell").val(data["mtell"]);
                $("#maddress").val(data["maddress"]);
                $("#mremark").val(data["mremark"]);
            },
            error:function(){
                console.log("Get message error.")
            }
        });
        $(".panel .cancal").click(function(){
            window.location.href = "doctor_list.html";
        });
        $(".panel .sbt").click(function(){
            var master={
                "mname": $("#mname").val(),
                "msex": $("#msex").val(),
                "memail": $("#memail").val(),
                "mtell": $("#mtell").val(),
                "maddress": $("#maddress").val(),
                "mremark": $("#mremark").val(),
            }
            master = JSON.stringify(master);
            $.ajax({ 
                type:"post", 
                url:"http://192.168.1.172/api/doctorUpdate",
                data:{json: master},
                dataType:"jsonp",
                jsonp:"callback", 
                success:function(data){
                    $(".success").fadeIn("slow").delay(1000).fadeOut("slow",function(){                   
                        window.location.href = "doctor_list.html";
                    }); 
                    console.log(data);
                },
                error:function(){
                    console.log("Send message error.")
                }
            }); 
        });
});