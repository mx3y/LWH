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
        // $('#birth').datetimepicker({
        //     format: 'yyyy-mm-dd',//日期的格式
        //     startDate:'1900-01-01',//选择器的开始日期
        //     autoclose:true,//日期选择完成后是否关闭选择框
        //     bootcssVer:3,//显示向左向右的箭头
        //     language:'zh_CN',//语言
        //     minView: "month",//表示日期选择的最小范围，默认是hour
        // });
        if(getUrlParam("id")){
            $.ajax({ 
                type:"post", 
                url:"http://192.168.1.168/api/updateTest",
                data:{id:getUrlParam("id")}, 
                dataType:"jsonp",
                jsonp:"callback", 
                success:function(data){ 
                    $("#cparent_id").val(data["cparent_id"]);
                    $("#cregion_grade").val(data["cregion_grade"]);
                    $("#cregion_name").val(data["cregion_name"]);
                    $("#cdistrict_code").val(data["cdistrict_code"]);
                    $("#carea_code").val(data["carea_code"]);
                    $("#cstatus").val(data["cstatus"]);
                },
                error:function(){
                    alert('get-url-fail');
                }
            }); 
        }
        $(".panel .sbt").click(function(){
            if($("#name").val()==""){
                $("#name").parent().addClass("has-error");
                $("#name").siblings(".help-block").html("名字不能为空");
                return false;
            }
            //验证邮箱格式
            var reg = /^([a-zA-Z0-9]+[_|\_|\.]?)*[a-zA-Z0-9]+@([a-zA-Z0-9]+[_|\_|\.]?)*[a-zA-Z0-9]+\.[a-zA-Z]{2,3}$/;
            if(!reg.test($("#email").val())){
                $("#email").parent().addClass("has-error");
                $("#email").siblings(".help-block").html("邮箱格式不正确");
                return false;
            }
            var user={
                "name": $("#name").val(),
                "birth": $("#birth").val(),
                "moblie-phone": $("#moblie-phone").val(),
                "email": $("#email").val(),
                "id-number": $("#id-number").val(),
                "post": $("#post").val(),
                "address": $("#address").val(),
                "sex": $("#sex").val(),
            }
            user = JSON.stringify(user);
            var uuser={
                'json':user
            };
            console.log(uuser);
            $.ajax({ 
                type:"post", 
                url:"http://192.168.1.168/api/addtest",
                data:city, 
                dataType:"jsonp",
                jsonp:"callback", 
                success:function(data){ 
                        console.log(data);
                },
                error:function(){
                    alert('fail');
                }
            }); 
        });
    });