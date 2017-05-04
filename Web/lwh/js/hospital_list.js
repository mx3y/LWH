function del(hid){
    $.ajax({
        type:"post", 
        url:"http://192.168.1.172/api/hospitalDelete",
        data:{id: hid}, 
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
}
$(document).ready(function(){
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
    $("#hospital-list").DataTable({
        "bFilter": false,
        "info":true,
        "bLengthChange" : false,  
        "iDisplayLength" : 12,
        "bRetrieve": true,
        "bDestroy": true,
        "oLanguage" : {  
                "sLengthMenu" : "每页显示 _MENU_ 条记录",  
                "sZeroRecords" : "对不起，没有匹配的数据",  
                "sInfo" : "第 _START_ - _END_ 条 / 共 _TOTAL_ 条数据",  
                "sInfoEmpty" : "没有匹配的数据",  
                "sInfoFiltered" : "(数据表中共 _MAX_ 条记录)",  
                "sProcessing" : "正在加载中...",  
                "sSearch" : "全文搜索：",  
                "oPaginate" : {  
                    "sFirst" : "第一页",  
                    "sPrevious" : " 上一页 ",  
                    "sNext" : " 下一页 ",  
                    "sLast" : " 最后一页 "  
                }

        },
        "ajax": {
            "url": "http://192.168.1.172/api/hospitalList",
            "dataType": "jsonp"
        },
        "columns" : [
            {"data": "hname"},
            {"data": "hcity"},
            {"data": "hlevel"},
            {"data": "haddress"},
            {"data": null}
        ],
       "columnDefs": [
            {
                "targets": [4],
                "render": function(data, type, row, full) {
                    return "<a class='btn btn-sm btn-link' href='hospital_edit.html?id="+data.hid+"'><span class='glyphicon glyphicon-wrench' style='margin-right:5px;'></span>修改</a>"
                    +"<button class='btn btn-sm btn-link' onclick='del("+data.hid+")'><span class='glyphicon glyphicon-trash' style='margin-right:5px;'></span>删除</button>"
                    +"<a class='btn btn-sm btn-link' href='dept_list.html?id="+data.hid+"'><span class='glyphicon glyphicon-search' style='margin-right:5px;'></span>查看科室</a>";
                }
            }
        ]
    });

});