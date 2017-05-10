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
        $('#ubrithday').datetimepicker({
            format: 'yyyy-mm-dd',//日期的格式
            startDate:'2000-01-01',//选择器的开始日期
            autoclose:true,//日期选择完成后是否关闭选择框
            bootcssVer:3,//显示向左向右的箭头
            language:'zh_CN',//语言
            minView: "month",//表示日期选择的最小范围，默认是hour
        });
        if(getUrlParam("id")){
            $.ajax({ 
                type:"post", 
                url:"http://192.168.1.172/api/userSendUpdate",
                data:{id:getUrlParam("id")}, 
                dataType:"jsonp",
                jsonp:"callback", 
                success:function(data){
                    $("#utijtid").val(data["utijtid"]);
                    $("#uname").val(data["uname"]);
                    $("#ucompanymonery").val(data["ucompanymonery"]);
                    $("#umonery").val(data["umonery"]);
                    $("#uaccount").val(data["uaccount"]);
                    $("#upassword").val(data["upassword"]);
                    $("#ucardnumber").val(data["ucardnumber"]);
                    $("#umail").val(data["umail"]);
                    var date = data.ubrithday.split("T")[0];
                    $("#ubrithday").val(date);
                    var usex = data.usex;
                    $("input:radio[name='usex'][value='"+usex+"']").attr("checked","checked");
                    date = data.uregisterdatetime.split("T").join(" ");
                    $("#uregisterdatetime").val(date);
                    date = data.ulastdatetime.split("T").join(" ");
                    $("#ulastdatetime").val(date);
                    $("#ulastip").val(data["ulastip"]);
                    $("#ucompanyid").val(data["name"]);
                    var ustate = data.ustate;
                    $("input:radio[name='ustate'][value='"+ustate+"']").attr("checked","checked");
                },
                error:function(){
                    alert('get-url-fail');
                }
            });
        }
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
                "uuid": getUrlParam("id"),
                "uname": $("#uname").val(),
                "uaccount": $("#uaccount").val(),
                "umail": $("#umail").val(),
                "ubrithday": $("#ubrithday").val()
            }
            console.log(user);
            user = JSON.stringify(user);
            var uuser={
                'json':user
            };
            $.ajax({ 
                type:"post", 
                url:"http://192.168.1.172/api/userUpdate",
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
