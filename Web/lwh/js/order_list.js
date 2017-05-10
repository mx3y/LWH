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
        "iDisplayLength" : 12,
        "bRetrieve": true,
        "bDestroy": true,
        "order" : [6,"desc"], 
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
            {"data": "dname"},
            {"data": null},
            {"data": null},
            {"data": null},
            {"data": null},
            {"data": null},
            {"data": null},
            {"data": "opublicmonery"},
            {"data": "oprivatemonery"},
            {"data": "ototalmonery"},
            {"data": null},
            {"data": null},
            {"data": null}
        ],
       "columnDefs": [
            {
                "targets": [2],
                "render": function(data, type, row, full) {
                    var msg = data.oillid;
                    if(msg != 0 ){
                        msg = msg + "<a style='margin-left: 10px' href='ill_persion.html?id="+data.oillid+"'>详情</a>";
                    }
                    return msg;
                }
            },
            {
                "targets": [3],
                "render": function(data, type, row, full) {
                    if(data.otype == 0)
                        return "预约挂号";
                    else if(data.otype == 1)
                        return "电话视频";
                    else if(data.otype == 2)
                        return "视频";
                }
            },
            {
                "targets": [4],
                "render": function(data, type, row, full) {
                    if(data.oresult == 0)
                        return "已取消";
                    else if(data.oresult == 1)
                        return "已预约";
                }
            },
            {
                "targets": [5],
                "render": function(data, type, row, full) {
                    if(data.ostate == 0)
                        return "未执行";
                    else if(data.ostate == 1)
                        return "已执行";
                }
            },
            {
                "targets": [6],
                "render": function(data, type, row, full) {
                    var date = data.ocreatetime.split("T").join(" ");
                    return date;
                }
            },
            {
                "targets": [7],
                "render": function(data, type, row, full) {
                    var date = data.ocommittime.split("T").join(" ");
                    return date+"<a style='margin-left:10px;' onclick='totuu("+data.oid+")'>修改</a>";
                }
            },
            {
                "targets": [11],
                "render": function(data, type, row, full) {
                    var msg = data.otransid;
                    if(msg != 0 ){
                        msg = msg + "<a style='margin-left: 10px' href='order_pay.html?id="+data.otransid+"'>详情</a>";
                    }
                    return msg;
                }
            },
            {
                "targets": [12],
                "render": function(data, type, row, full) {
                    var msg = data.ocallid;
                    if(msg != 0 ){
                        msg = msg + "<a style='margin-left: 10px' href='ucpaas.html?id="+data.ocallid+"'>详情</a>";
                    }
                    return msg;
                }
            },
            {
                "targets": [13],
                "render": function(data, type, row, full) {
                    return "<a style='text-align: center;' href='order_pay.html?id="+data.oid+"'>查看</a>";
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