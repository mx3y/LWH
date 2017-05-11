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
            $("#dcity_2").html("<option value=''>请选择</option>");
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
                        $("#dcity_2").append("<option title='"+n.cid+"'>"+n.cregion_name+"</option>");
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
                    $("#dhospital").append("<option title='"+n.hid+"'>"+n.hname+"</option>");
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
            $("#dept").html("<option value=''>请选择</option>");
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
                        $("#ddept").append("<option title='"+n.did+"'>"+n.dname+"</option>");
                    });  
                },
                error:function(){
                    console.log("dept error.");
                }
            });
        });


        var editor = new wangEditor("editor");
        editor.config.uploadImgUrl = 'http://192.168.1.172/api/editorImage';
        editor.config.hideLinkImg = true;
        editor.config.menus = [
            'bold',
            'underline',
            'italic',
            'strikethrough',
            'eraser',
            'forecolor',
            'bgcolor',
            'quote',
            'fontfamily',
            'fontsize',
            'head',
            'unorderlist',
            'orderlist',
            'alignleft',
            'aligncenter',
            'alignright',
            'table',
            'emotion',
            'img',
            'location',
            'undo'
        ];
        editor.config.emotions = {
            'default': {
                title: '默认',
                data: './dist/emotions.data'
            }
        }
        editor.create();


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
                    default_city = data["dcity"].split(" ");
                    default_hospital = data["dhospital"];
                    default_dept = data["ddept"];
                    $("#dcity_1").val(default_city[0]);
                    $("#dcity_2").append("<option>"+default_city[1]+"</option>");
                    $("#dcity_2").val(default_city[1]);
                    $("#ddept").append("<option>"+default_dept+"</option>");
                    $("#ddept").val(default_dept); 
                    $("#dhospital").val(default_hospital);
                    $("#dhospital").val(data["dhospital"]);
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
                    $("input:radio[name='dishot'][value='"+data.dishot+"']").attr("checked","checked");
                    $("input:radio[name='dstate'][value='"+data.dstate+"']").attr("checked","checked");
                    $("#d_count").val(data["d_count"]);
                    $("#d_score").val(data["d_score"]);
                    $("#d_professionscore").val(data["d_professionscore"]);
                    $("#d_professioncount").val(data["d_professioncount"]);
                    $("#d_servicesscore").val(data["d_servicesscore"]);
                    $("#d_servicescount").val(data["d_servicescount"]);
                    $("#d_replyscore").val(data["d_replyscore"]);
                    $("#d_replycount").val(data["d_replycount"]);
                    var img_url = "http://192.168.1.172/upload/"+data["dimage"];
                    $("#image").attr("src",img_url);
                    var d_message = data.d_message.replace(/&(gt);/g,">").replace(/&(lt);/g,"<");
                    console.log(d_message);
                    $("#editor").html(d_message);

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
                "ddeptid": $("#ddept option:selected").attr("title"),
                "dcity": $("#dcity_1").val()+" "+$("#dcity_2").val(),
                "dcityid": $("#dcity_2 option:selected").attr("title"),
                "dhospital": $("#dhospital").val(),
                "dhospitalid": $("#dhospital option:selected").attr("title"),
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
                "dishot": $("input:radio[name='dishot']:checked").val(),
                "dstate": $("input:radio[name='dstate']:checked").val(),
                "d_count": $("#d_count").val(),
                "d_score": $("#d_score").val(),
                "d_professionscore": $("#d_professionscore").val(),
                "d_professioncount": $("#d_professioncount").val(),
                "d_servicesscore": $("#d_servicesscore").val(),
                "d_servicescount": $("#d_servicescount").val(),
                "d_replyscore": $("#d_replyscore").val(),
                "d_replycount": $("#d_replycount").val(),
				"dimage": $("#dname").val()+"_img.jpg",
                "d_message": editor.$txt.html().replace(/>/g,"&gt;").replace(/</g,"&lt;")

            }
            console.log(doctor);
            doctor = JSON.stringify(doctor);
            var ddoctor={
                'json':doctor
            };
            $.ajax({ 
                type:"post", 
                url:"http://192.168.1.172/api/doctorUpdate",
                data:ddoctor, 
                dataType:"jsonp",
                jsonp:"callback", 
                success:function(data){
                    $("#img_name").val($("#dname").val()+"_img.jpg");
                    $("#img_sbt").trigger("click");
                    $(".success").fadeIn("slow").delay(1000).fadeOut("slow",function(){                   
                        window.location.href = "doctor_list.html";
                    }); 
                },
                error:function(){
                    alert('fail');
                }
            }); 
        });
        $("#file").change(function(){
            var reader = new FileReader();
            var file = this.files[0];
            reader.onload = function(e) {
                $("#image").attr("src",e.target.result);
            };
            reader.readAsDataURL(file);
        });
        $(".select").bind("click",function(){
            $("#file").trigger("click");
        });
});