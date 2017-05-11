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
        var city = null;
        $.ajax({ 
            type:"post", 
            url:"http://192.168.1.172/api/selectCity",
            dataType:"jsonp",
            data:{
                cid: null
            },
            jsonp:"callback", 
            success:function(data){
                city = data;
                $.each(data,function(i,n){
                    $("#dcity_1").append("<option>"+n.cregion_name+"</option>");
                });
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
                        $("#dcity_2").append("<option>"+n.cregion_name+"</option>");
                    });  
                },
                error:function(){
                    console.log("city_2 error.");
                }
            });
        });
        $(".panel .cancal").click(function(){
            window.location.href = "hospital_list.html";
        });
        $(".panel .sbt").click(function(){
            var hospital={
                "hname": $("#hname").val(),
                "hcity": $("#dcity_1").val()+" "+$("#dcity_2").val(),
                "hcityid": $("#hcityid").val(),
                "hlevel": $("#hlevel").val(),
                "haddress": $("#haddress").val(),
                "hcontent": $("#hcontent").val(),
            }
            hospital = JSON.stringify(hospital);
            $.ajax({ 
                type:"post", 
                url:"http://192.168.1.172/api/hospitalAdd",
                data:{json: hospital}, 
                dataType:"jsonp",
                jsonp:"callback", 
                success:function(data){
                    $(".success").fadeIn("slow").delay(1000).fadeOut("slow",function(){                   
                        window.location.href = "hospital_list.html";
                    }); 
                    console.log(data);
                },
                error:function(){
                    alert('fail');
                }
            }); 
        });
});