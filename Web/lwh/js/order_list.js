function totuu(oid){
    $("#change-date").modal("show");
    $(".modal-body span").html(oid);
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
    $("#order-list").DataTable({
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
            "url": "http://192.168.1.172/api/orderList",
            "dataType": "jsonp"
        },
        "columns" : [
            {"data": "ouid"},
            {"data": "odid"},
            {"data": null},
            {"data": "oresult"},
            {"data": "ostate"},
            {"data": null},
            {"data": null},
            {"data": "opublicmonery"},
            {"data": "oprivatemonery"},
            {"data": "ototalmonery"},
            {"data": "otransid"},
            {"data": "ocallresult"},
            {"data": "ocallid"},
            {"data": "ocalldate"}
        ],
       "columnDefs": [
            {
                "targets": [2],
                "data": "otype",
                "render": function(data, type, row, full) {
                    if(data.otype == 0)
                        return "预约挂号请求";
                    else if(data.otype == 1)
                        return "电话视频请求";
                    else if(data.otype == 2)
                        return "视频请求";

                }
            },
            {
                "targets": [5],
                "render": function(data, type, row, full) {
                    var date = data.ocreatetime.split("T");
                    return date;
                }
            },
            {
                "targets": [6],
                "render": function(data, type, row, full) {
                    var date = data.ocommittime.split("T");
                    return date+"<a style='margin-left:10px;' onclick='totuu("+data.oid+")'>修改</a>";
                }
            }
        ]
    });
    $("#change-sbt").click(function(){
        var ooid = $(".modal-body span").html();
        var year = $("#year").val();
        var month = $("#month").val();
        var day = $("#day").val();
        var time = year+"-"+month+"-"+day;
        var change_date = {
            "oid": ooid,
            "ocommittime":time
        }
        change_date = JSON.stringify(change_date);
        $.ajax({ 
            type:"post", 
            url:"http://192.168.1.172/api/orderUpdate",
            data:{"json": change_date},
            dataType:"jsonp",
            jsonp:"callback", 
            success:function(data){
                console.log("success.");
                $("#change-date").modal("hide");
            },
            error:function(){
                console.log("error.");
            }
        });
    });
});