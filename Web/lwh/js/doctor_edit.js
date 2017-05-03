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
        var default_hospital = null;
        var default_dept = null;
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
        var hospital = null;
        $.ajax({ 
            type:"post", 
            url:"http://192.168.1.172/api/selectHospital",
            dataType:"jsonp",
            jsonp:"callback", 
            success:function(data){
                $.each(data,function(i,n){
                    $("#dhospital").append("<option>"+n.hname+"</option>");
                });
                $("#dhospital").val(default_hospital);
                $("#ddept").append("<option>"+default_dept+"</option>");
                $("#ddept").val(default_dept);
            },
            error:function(){
                console.log("hospital error.");
            }
        });
        $("#dhospital").change(function(){
            var hospital_id = null;
            $.each(hospital,function(i,n){
                 if(n.hname == $("#dhospital").val())
                    hospital_id = n.hid;
            });
            $("#dept").html("<option>请选择</option>");
            $.ajax({ 
                type:"post", 
                url:"http://192.168.1.172/api/selectDept",
                data:{
                    hid: 0
                },
                dataType:"jsonp",
                jsonp:"callback", 
                success:function(data){
                    $.each(data,function(i,n){
                        $("#ddept").append("<option>"+n.dname+"</option>");
                    });  
                },
                error:function(){
                    console.log("dept error.");
                }
            });
        });
        if(getUrlParam("id")){
            $.ajax({ 
                type:"post", 
                url:"http://192.168.1.172/api/doctorSendUpdate",
                data:{id:getUrlParam("id")}, 
                dataType:"jsonp",
                jsonp:"callback", 
                success:function(data){
                    $("#dname").val(data["dname"]);
                    $("#dtype").val(data["dtype"]);
                    $("#ddept").val(data["ddept"]);
                    $("#ddeptid").val(data["ddeptid"]);
                    default_city = data["dcity"].split(" ");
                    default_hospital = data["dhospital"];
                    default_dept = data["ddept"];
                    $("#dcity_1").val(default_city[0]);
                    $("#dcity_2").append("<option>"+default_city[1]+"</option>");
                    $("#dcity_2").val(default_city[1]);
                    $("#ddept").append("<option>"+default_dept+"</option>");
                    $("#ddept").val(default_dept); 
                    $("#dhospital").val(default_hospital);      
                    $("#dcityid").val(data["dcityid"]);
                    $("#dhospital").val(data["dhospital"]);
                    $("#dhospitalid").val(data["dhospitalid"]);
                    $("#dprofessor").val(data["dprofessor"]);
                    $("#dcontent").val(data["dcontent"]);
                    $("#dmonery").val(data["dmonery"]);
                    $("#ddiscount").val(data["ddiscount"]);
                    $("#dtell").val(data["dtell"]);
                    $("#dshowregister").val(data["dshowregister"]);
                    $("#dsrealregister").val(data["dsrealregister"]);
                    $("#dshowtell").val(data["dshowtell"]);
                    $("#dsrealtell").val(data["dsrealtell"]);
                    $("#dshowvideo").val(data["dshowvideo"]);
                    $("#dsrealvideo").val(data["dsrealvideo"]);
                    $("#dbankaccount").val(data["dbankaccount"]);
                    $("#dbankaname").val(data["dbankaname"]);
                    $("#dbanktype").val(data["dbanktype"]);
                    $("#dqq").val(data["dqq"]);
                    $("#daccount").val(data["daccount"]);
                    $("#dpassword").val(data["dpassword"]);
                    $("#dsort").val(data["dsort"]);
                    $("#dishot").val(data["dishot"]);
                    $("#dstate").val(data["dstate"]);
                    var d_onlinedate = data["d_onlinedate"].split(",");
                    for(var i in d_onlinedate){
                        $("input:checkbox[value='"+d_onlinedate[i]+"']").attr("checked","checked");                        
                    }
                    $("#d_message").val(data["d_message"]);
                    $("#d_count").val(data["d_count"]);
                    $("#d_score").val(data["d_score"]);
                    $("#d_professionscore").val(data["d_professionscore"]);
                    $("#d_professioncount").val(data["d_professioncount"]);
                    $("#d_servicesscore").val(data["d_servicesscore"]);
                    $("#d_servicescount").val(data["d_servicescount"]);
                    $("#d_replyscore").val(data["d_replyscore"]);
                    $("#d_replycount").val(data["d_replycount"]);
                },
                error:function(){
                    alert('get-url-fail');
                }
            });
        }
        $(".panel .cancal").click(function(){
            window.location.href = "doctor_list.html";
        });
        $(".panel .sbt").click(function(){
            if($("#dname").val()==""){
                $("#dname").parent().addClass("has-error");
                $("#dname").siblings(".help-block").html("名称不能为空");
                return false;
            }
            if($("#dtype").val()==""){
                $("#dtype").parent().addClass("has-error");
                $("#dtype").siblings(".help-block").html("医生类型不能为空");
                return false;
            }
            if($("#ddept").val()==""){
                $("#ddept").parent().addClass("has-error");
                $("#ddept").siblings(".help-block").html("医生科室不能为空");
                return false;
            }
            if($("#ddeptid").val()==""){
                $("#ddeptid").parent().addClass("has-error");
                $("#ddeptid").siblings(".help-block").html("医生科室编号不能为空");
                return false;
            }
            var onlinedate =  $("input:checkbox[name='d_onlinedate']:checked").map(function(index,el) {return $(el).val();}).get().join(',');
            var doctor={
                "did": getUrlParam("id"),
                "dname": $("#dname").val(),
                "dtype": $("#dtype").val(),
                "ddept": $("#ddept").val(),
                "ddeptid": $("#ddeptid").val(),
                "dcity": $("#dcity_1").val()+" "+$("#dcity_2").val(),
                "dcityid": $("#dcityid").val(),
                "dhospital": $("#dhospital").val(),
                "dhospitalid": $("#dhospitalid").val(),
                "dprofessor": $("#dprofessor").val(),
                "dcontent": $("#dcontent").val(),
                "dmonery": $("#dmonery").val(),
                "ddiscount": $("#ddiscount").val(),
                "dtell": $("#dtell").val(),
                "dshowregister": $("#dshowregister").val(),
                "dsrealregister": $("#dsrealregister").val(),
                "dshowtell": $("#dshowtell").val(),
                "dsrealtell": $("#dsrealtell").val(),
                "dshowvideo": $("#dshowvideo").val(),
                "dsrealvideo": $("#dsrealvideo").val(),
                "dbankaccount": $("#dbankaccount").val(),
                "dbankaname": $("#dbankaname").val(),
                "dbanktype": $("#dbanktype").val(),
                "dqq": $("#dqq").val(),
                "daccount": $("#daccount").val(),
                "dpassword": $("#dpassword").val(),
                "dsort": $("#dsort").val(),
                "dishot": $("#dishot").val(),
                "dstate": $("#dstate").val(),
                "d_onlinedate": onlinedate,
                "d_message": $("#d_message").val(),
                "d_count": $("#d_count").val(),
                "d_score": $("#d_score").val(),
                "d_professionscore": $("#d_professionscore").val(),
                "d_professioncount": $("#d_professioncount").val(),
                "d_servicesscore": $("#d_servicesscore").val(),
                "d_servicescount": $("#d_servicescount").val(),
                "d_replyscore": $("#d_replyscore").val(),
                "d_replycount": $("#d_replycount").val(),
            }
            doctor = JSON.stringify(doctor);
            var ddoctor={
                'json':doctor
            };
            console.log(ddoctor);
            $.ajax({ 
                type:"post", 
                url:"http://192.168.1.172/api/doctorUpdate",
                data:ddoctor, 
                dataType:"jsonp",
                jsonp:"callback", 
                success:function(data){
                    $(".success").fadeIn("slow").delay(1000).fadeOut("slow",function(){                   
                        window.location.href = "doctor_list.html";
                    }); 
                    console.log(data);
                },
                error:function(){
                    alert('fail');
                }
            }); 
        });
});