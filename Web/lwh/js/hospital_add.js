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
        $(".panel .cancal").click(function(){
            window.location.href = "user_list.html";
        });
        $(".panel .sbt").click(function(){
            if($("#ucompanyid").val()==""){
                $("#ucompanyid").parent().addClass("has-error");
                $("#ucompanyid").siblings(".help-block").html("用户公司编号不能为空");
                return false;
            }
            if($("#ustate").val()==""){
                $("#ustate").parent().addClass("has-error");
                $("#ustate").siblings(".help-block").html("用户状态不能为空");
                return false;
            }
            var hospital={
                "hname": $("#hname").val(),
                "hcity": $("#hcity").val(),
                "hcityid": $("#hcityid").val(),
                "hlevel": $("#hlevel").val(),
                "haddress": $("#haddress").val(),
                "hcontent": $("#hcontent").val(),
            }
            hospital = JSON.stringify(hospital);
            $.ajax({ 
                type:"post", 
                url:"http://192.168.1.172/api/userAdd",
                data:{json: hospital}, 
                dataType:"jsonp",
                jsonp:"callback", 
                success:function(data){
                    $(".success").fadeIn("slow").delay(1000).fadeOut("slow",function(){                   
                        window.location.href = "user_list.html";
                    }); 
                    console.log(data);
                },
                error:function(){
                    alert('fail');
                }
            }); 
        });
});