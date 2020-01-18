﻿$(document).ready(function () {
    getMenus();

});


function setCookie(name, value) {
    var expires;   
    var date = new Date();
    date.setTime(date.getTime() + (1 * 24 * 60 * 60 * 1000));
    expires = "; expires=" + date.toGMTString();
    
    document.cookie = encodeURIComponent(name) + "=" + encodeURIComponent(value) + expires + "; path=/";

}

function getCookie(name) {
    var nameEQ = encodeURIComponent(name) + "=";
    var ca = document.cookie.split(';');
    for (var i = 0; i < ca.length; i++) {
        var c = ca[i];
        while (c.charAt(0) === ' ')
            c = c.substring(1, c.length);
        if (c.indexOf(nameEQ) === 0)
            return decodeURIComponent(c.substring(nameEQ.length, c.length));
    }
    return null;
}

var x;

getMenus = function () {
    var url = getCookie("APIUrl")+"/menu";
    
    $.ajax({
        url: url,
        data: {},
        type: 'GET',
        dataType: 'json',
        contentType: 'application/json; charset=utf-8',
        beforeSend: function (xhr) { xhr.setRequestHeader('token', getCookie("APIKey")); },
        success: function (result) {
            x=(result);
            //$(".nav-pills.nav-sidebar").children().remove();
            $(result).each(function (k, v) {
                if (v.Address == "" && v.Parent=="") {
                    var item = "<li class=nav-item><a href='pages/widgets.html' class='nav-link'><i class='nav-icon fas fa-th'></i><p>" + v.Name + "<i class='right fas fa-angle - left'></i></p></a></li>";
                    var menuItem = $(".nav-pills.nav-sidebar").append(item);
                    var subMenu = $(result).filter(function () { return this.Parent == v.ID });
                    if ($(subMenu).length > 0) {
                        $(menuItem.children().last()).attr("class", "nav-item has-treeview")
                        console.log(menuItem);
                    }
                }
                
               
            });
        },
        error: function (error) {
            //console.log(error);
            $("#lblMsg").text("invalid attempt");
        }
    });
}