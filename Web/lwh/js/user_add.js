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
        $('#ubrithday').datetimepicker({
            format: 'yyyy-mm-dd',//日期的格式
            startDate:'1900-01-01',//选择器的开始日期
            autoclose:true,//日期选择完成后是否关闭选择框
            bootcssVer:3,//显示向左向右的箭头
            language:'zh_CN',//语言
            minView: "month",//表示日期选择的最小范围，默认是hour
        });
        $(".panel .cancal").click(function(){
            window.location.href = "user_list.html";
        });
        $(".panel .sbt").click(function(){
            if($("#utijtid").val()==""){
                $("#utijtid").parent().addClass("has-error");
                $("#utijtid").siblings(".help-block").html("用户类型不能为空");
                return false;
            }
            if($("#ucompanymonery").val()==""){
                $("#ucompanymonery").parent().addClass("has-error");
                $("#ucompanymonery").siblings(".help-block").html("公司额度不能为空");
                return false;
            }
            if($("#umonery").val()==""){
                $("#umonery").parent().addClass("has-error");
                $("#umonery").siblings(".help-block").html("充值金额不能为空");
                return false;
            }
            if($("#uaccount").val()==""){
                $("#uaccount").parent().addClass("has-error");
                $("#uaccount").siblings(".help-block").html("用户帐号不能为空");
                return false;
            }
            if($("#upassword").val()==""){
                $("#upassword").parent().addClass("has-error");
                $("#upassword").siblings(".help-block").html("用户密码不能为空");
                return false;
            }
            if($("#ucardnumber").val()==""){
                $("#ucardnumber").parent().addClass("has-error");
                $("#ucardnumber").siblings(".help-block").html("身份证号不能为空");
                return false;
            }
            if($("#ubrithday").val()==""){
                $("#ubrithday").parent().addClass("has-error");
                $("#ubrithday").siblings(".help-block").html("用户出生日期不能为空");
                return false;
            }
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
            //验证邮箱格式
            var reg = /^([a-zA-Z0-9]+[_|\_|\.]?)*[a-zA-Z0-9]+@([a-zA-Z0-9]+[_|\_|\.]?)*[a-zA-Z0-9]+\.[a-zA-Z]{2,3}$/;
            if(!reg.test($("#umail").val())){
                $("#umail").parent().addClass("has-error");
                $("#umail").siblings(".help-block").html("邮箱格式不正确");
                return false;
            }
            
            var user={
                "utijtid": $("#utijtid").val(),
                "ucompanymonery": $("#ucompanymonery").val(),
                "umonery": $("#umonery").val(),
                "uaccount": $("#uaccount").val(),
                "upassword": $("#upassword").val(),
                "ucardnumber": $("#ucardnumber").val(),
                "umail": $("#umail").val(),
                "ubrithday": $("#ubrithday").val(),
                "usex": $("#usex").val(),
                "ucompanyid": $("#ucompanyid").val(),
                "ustate": $("#ustate").val(),
            }
            user = JSON.stringify(user);
            var uuser={
                'json':user
            };
            console.log(uuser);
            $.ajax({ 
                type:"post", 
                url:"http://192.168.1.172/api/userAdd",
                data:uuser, 
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