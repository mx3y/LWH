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
        $('#birth').datetimepicker({
            format: 'yyyy-mm-dd',//日期的格式
            startDate:'1900-01-01',//选择器的开始日期
            autoclose:true,//日期选择完成后是否关闭选择框
            bootcssVer:3,//显示向左向右的箭头
            language:'zh_CN',//语言
            minView: "month",//表示日期选择的最小范围，默认是hour
        });
        $(".panel .sbt").click(function(){

            if($("#name").val()==""){
                $("#name").parent().addClass("has-error");
                $("#name").siblings(".help-block").html("名字不能为空");
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
                url:"http://localhost:3448/api/updateTest",
                data:uuser, 
                dataType:"jsonp",
                jsonp:"callback", 
                success:function(data){ 
                    alert(data); 
                },
                error:function(){
                    alert('fail');
                }
            }); 
        });
    });