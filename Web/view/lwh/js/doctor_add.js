 $(document).ready(function (){
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
            data:{
                cid: null
            },
            dataType:"jsonp",
            jsonp:"callback", 
            success:function(data){
                city = data.ds;
                $.each(data.ds,function(i,n){
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
                    $.each(data.data,function(i,n){
                        $("#dcity_2").append("<option>"+n.cregion_name+"</option>");
                    });  
                },
                error:function(){
                    console.log("city_2 error.");
                }
            });
        });
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
                "dname": $("#dname").val(),
                "dtype": $("#dtype").val(),
                "ddept": $("#ddept").val(),
                "ddeptid": $("#ddeptid").val(),
                "dcity": $("#dcity_2").val(),
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
            }
            doctor = JSON.stringify(doctor);
            var ddoctor={
                'json':doctor
            };
            console.log(ddoctor);
            $.ajax({ 
                type:"post", 
                url:"http://192.168.1.172/api/doctorAdd",
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