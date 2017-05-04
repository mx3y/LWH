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
    $("#patient-list").DataTable({
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
            "url": "http://192.168.1.172/api/illpersionList",
            "dataType": "jsonp"
        },
        "columns" : [
            {"data": "uid"},
            {"data": "iname"},
            {"data": "iphone"},
            {"data": "icardtype"},
            {"data": "icard"},
            {"data": "isex"},
            {"data": null},
            {"data": "iaddress"}
        ],
       "columnDefs": [
            {
                "targets": [6],
                "render": function(data, type, row, full) {
                    var date = data.ibirthday.split("T").join(" ");
                    console.log(date);
                    return date;
                }
            }
        ]
    });
});