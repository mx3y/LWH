function del(cid){
    $.ajax({
        type:"post", 
        url:"http://192.168.1.172/api/userDelete",
        data:{id: cid}, 
        dataType:"jsonp",
        jsonp:"callback", 
        success:function(data){ 
            $(".success").fadeIn("slow").delay(1000).fadeOut("slow",function(){                   
                window.location.href = "user_list.html";
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
    $("#user-list").DataTable({
        "bFilter": false,
        "info":true,
        "bLengthChange" : false,  
        "iDisplayLength" : 15,
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
            "url": "http://192.168.1.172/api/userList",
            "dataType": "jsonp"
        },
        "columns" : [
            {"data": null},
            {"data": "uaccount"},
            {"data": "uname"},
            {"data": "ucardnumber"},
            {"data": "usex"},
            {"data": null},
            {"data": null},
            {"data": null},
            {"data": null}
        ],
       "columnDefs": [
            {
                "targets": [0],
                "data": "utijtid",
                "render": function(data, type, row, full) {
                    if(data.utijtid == 0)
                        return "个人用户";
                    else
                        return "体检通用户";

                }
            },
            {
                "targets": [5],
                "render": function(data, type, row, full) {
                        return "待填充";
                }
            },
            {
                "targets": [6],
                "render": function(data, type, row, full) {
                        return "待填充";
                }
            },
            {
                "targets": [7],
                "render": function(data, type, row, full) {
                    var date = data.ulastdatetime.split("T")[0];
                    return date;
                }
            },
            {
                "targets": [8],
                "render": function(data, type, row, full) {
                    return "<a class='btn btn-sm btn-link' href='user_edit.html?id="+data.uuid+"''><span class='glyphicon glyphicon-wrench' style='margin-right:5px;'></span>修改</a>"
                    +"<button class='btn btn-sm btn-link' onclick='del("+data.uuid+")'><span class='glyphicon glyphicon-trash' style='margin-right:5px;'></span>删除</button>";
                }
            }
        ]
    });
});