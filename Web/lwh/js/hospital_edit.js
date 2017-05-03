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
        var city = null;
        var default_city = null;
        $.ajax({ 
            type:"post", 
            url:"http://192.168.1.172/api/selectCity",
            data:{
                cid: null
            },
            dataType:"jsonp",
            jsonp:"callback", 
            success:function(data){
                city = data;
                $.each(data,function(i,n){
                    $("#dcity_1").append("<option>"+n.cregion_name+"</option>");
                });
                if(default_city){                    
                    $("#dcity_1").val(default_city[0]);
                    $("#dcity_2").append("<option>"+default_city[1]+"</option>");
                    $("#dcity_2").val(default_city[1]);
                }
            },
            error:function(){
                console.log("city_1 error.");
            }
        });
        $("#dcity_1").change(function(){
            var city_id = null;
            $.each(city,function(i,n){
                 if(n.cregion_name == $("#dcity_1").val())
                    city_id = n.cid;
            });
            $("#dcity_2").html("<option>请选择</option>");
            $.ajax({ 
                type:"post", 
                url:"http://192.168.1.172/api/selectCity",
                data:{
                    cid: city_id
                },
                dataType:"jsonp",
                jsonp:"callback", 
                success:function(data){
                    $.each(data,function(i,n){
                        $("#dcity_2").append("<option value='"+n.cregion_name+"'>"+n.cregion_name+"</option>");
                    });  
                },
                error:function(){
                    console.log("city_2 error.");
                }
            });
        });
        if(getUrlParam("id")){
            $.ajax({ 
                type:"post", 
                url:"http://192.168.1.172/api/hospitalSendUpdate",
                data:{id:getUrlParam("id")}, 
                dataType:"jsonp",
                jsonp:"callback", 
                success:function(data){
                    $("#hname").val(data["hname"]);
                    default_city = data["hcity"].split(" ");
                    $("#dcity_1").val(default_city[0]);
                    $("#dcity_2").append("<option>"+default_city[1]+"</option>");
                    $("#dcity_2").val(default_city[1]);
                    $("#hcityid").val(data["hcityid"]);
                    $("#hlevel").val(data["hlevel"]);
                    $("#haddress").val(data["haddress"]);
                    $("#hcontent").val(data["hcontent"]);
                },
                error:function(){
                    alert('get-url-fail');
                }
            });
        }
        $(".panel .cancal").click(function(){
            window.location.href = "hospital_list.html";
        });
        $(".panel .sbt").click(function(){
            var hospital={
                "hid": getUrlParam("id"),
                "hname": $("#hname").val(),
                "hcity": $("#dcity_1").val()+" "+$("#dcity_2").val(),
                "hcityid": $("#hcityid").val(),
                "hlevel": $("#hlevel").val(),
                "haddress": $("#haddress").val(),
                "hcontent": $("#hcontent").val()
            }
            console.log(hospital);
            hospital = JSON.stringify(hospital);
            $.ajax({ 
                type:"post", 
                url:"http://192.168.1.172/api/hospitalUpdate",
                data:{json: hospital},
                dataType:"jsonp",
                jsonp:"callback", 
                success:function(data){
                    $(".success").fadeIn("slow").delay(1000).fadeOut("slow",function(){                   
                        window.location.href = "hospital_list.html";
                    });
                },
                error:function(){
                    alert('fail');
                }
            }); 
        });
});