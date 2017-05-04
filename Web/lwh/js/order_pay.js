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
            "url": "http://192.168.1.172/api/orderPayList",
            "dataType": "jsonp"
        },
        "columns" : [
            {"data": "oid"},
            {"data": "uuid"},
            {"data": "porder"},
            {"data": "pwxorder"},
            {"data": "pmonery"},
            {"data": null},
            {"data": null},
            {"data": "popenid"},
            {"data": null}
        ],
       "columnDefs": [
            {
                "targets": [5],
                "render": function(data, type, row, full) {
                    var date = data.pcreatetime.split("T")[0];
                    return date;
                }
            },
            {
                "targets": [6],
                "render": function(data, type, row, full) {
                    var date = data.povertime.split("T")[0];
                    return date;
                }
            },
            {
                "targets": [8],
                "render": function(data, type, row, full) {
                    if(data.pstatus == 0)
                        return "未完成";
                    else if(data.pstatus == 1)
                        return "已完成";

                }
            }
        ]
    });
});