 $(document).ready(function (){
        function getUrlParam(name) {
            var reg = new RegExp("(^|&)" + name + "=([^&]*)(&|$)"); //构造一个含有目标参数的正则表达式对象
            var r = window.location.search.substr(1).match(reg);  //匹配目标参数
            if (r != null) return unescape(r[2]); return null; //返回参数值
        }
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
                url:"http://192.168.1.168/api/doctorSendUpdate",
                data:{id:getUrlParam("id")}, 
                dataType:"jsonp",
                jsonp:"callback", 
                success:function(data){
                    $("#dname").val(data["dname"]);
                    $("#dtype").val(data["dtype"]);
                    $("#ddept").val(data["ddept"]);
                    $("#ddeptid").val(data["ddeptid"]);
                    $("#dcity").val(data["dcity"]);
                    $("#dcityid").val(data["dcityid"]);
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

            var doctor={
                "did": getUrlParam("id"),
                "dname": $("#dname").val(),
                "dtype": $("#dtype").val(),
                "ddept": $("#ddept").val(),
                "ddeptid": $("#ddeptid").val(),
                "dcity": $("#dcity").val(),
                "dcityid": $("#dcityid").val(),
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
            }
            doctor = JSON.stringify(doctor);
            var ddoctor={
                'json':doctor
            };
            console.log(ddoctor);
            $.ajax({ 
                type:"post", 
                url:"http://192.168.1.168/api/doctorUpdate",
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