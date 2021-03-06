﻿$(document).ready(function () {
    getMenus();
    
});




function getParentMenu(menuText,ID) {
    var str = "<li class='nav-item has-treeview rootMenu' tag='"+ ID +"'><a href = '#' class='nav-link' ><i class=''></i><p>" + menuText + "<i class='fas fa-angle-left right'></i></p></a ><ul class='nav nav-treeview subMenu'></ul></li >";
    return str;
}

function getChildMenu(Name, Address) {
    var str = "<li class='nav-item'><a href='../" + Address + "' class='nav-link child-Menu'><i class='far fa-circle nav-icon'></i><p>" + Name + "</p></a></li>";
    return str;
}
getMenus = function () {
    var url = getCookie("APIUrl") + "/menu";
    
    if (sessionStorage.getItem("menus") != null) {
        loadMenu();
        
    } else {
        $.ajax({
            url: url,
            data: {},
            type: 'GET',
            dataType: 'json',
            contentType: 'application/json; charset=utf-8',
            beforeSend: function (xhr) { xhr.setRequestHeader('token', getCookie("APIKey")); },
            success: function (result) {
                sessionStorage.setItem("menus", JSON.stringify(result));
                loadMenu();
            },
            error: function (error) {
           
            }
        });
    }
    
   
}

function loadMenu() {
    var result = JSON.parse(sessionStorage.getItem("menus"));
    
    $(".nav-pills.nav-sidebar").children().remove();
    $(".nav-pills.nav-sidebar").append("<li class='nav-header menu-grp'>Menus</li>");
    $(result).filter(function () { return this.MenuType == 0 }).each(function (k, v) {
        console.log(result.length);
        if (v.Address == "" && v.Parent == "") {
            var item = getParentMenu(v.Name, v.ID);
            var menuItem = $(".nav-pills.nav-sidebar").append(item);
        }
    });
    $(".nav-pills.nav-sidebar").append("<li class='nav-header  menu-grp'>Plugins</li>");
    $(result).filter(function () { return this.MenuType == 1 }).each(function (k, v) {
        if (v.Address == "" && v.Parent == "") {
            var item = getParentMenu(v.Name, v.ID);
            var menuItem = $(".nav-pills.nav-sidebar").append(item);
        }
    });
    $("li.rootMenu").each(function (x, y) {
        var rid = $(y).attr("tag");
        var subMenu = $(result).filter(function () { return this.Parent == rid });

        $(subMenu).each(function (x1, y1) {
            $(y).children("ul.subMenu").append(getChildMenu(y1.Name, y1.Address));
        });
    });
    
}
