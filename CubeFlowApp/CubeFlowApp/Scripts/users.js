function loadDefaultImg(th) {
    $(th).attr("src","\\img\\default.png");
}


var api = "";

$(document).ready(function () {

    api = getCookie("APIUrl");
    

    $(".user-block").on("click", function () {
        var uid = $(this).find("#hdnID").val();
        var url = "/users/userDetails";
        console.log(uid);
        console.log(url)
        $.ajax({
            url: url,
            data: {id:uid},
            type: 'GET',
            dataType: 'html',
            contentType: 'text/html',
            success: function (result) {
                $(".user-detail").html(result);
                console.log(result);
                //$("#tabContSubUser").html("");
                //var childUsers = "";

                //$.each(result.SubOrdinates, function (k, v) {
                   
                //    childUsers = childUsers + 
                //        "<div class='user-block user-block-x' title='"+k+"'><table border='0'><tr> <td rowspan='3'><img src='img/userImg/"+k+".jpg' onerror='loadDefaultImg(this);' /> </td>             <td>                 <input type='hidden' id='hdnID' value='"+k+"' />                 <span class='usr-Name'>"+v+"</span>             </td>         </tr>         <tr>             <td><div class='userDesig'></div></td>         </tr>         <tr>             <td><div class='userDept'></div></td>         </tr>     </table> </div>"
                //});

                //$("#tabContSubUser").html(childUsers);

            },
            error: function (error) {
                console.log(error);
            }
        });


    });
    var users = $(".user-block-x");
    $.each(users, function (i, v) {
        var uid = $(v).find("#hdnID").val();
        var url = api + "users";

        $.ajax({
            url: url,
            data: { id: uid },
            type: 'GET',
            dataType: 'json',
            contentType: 'application/json; charset=utf-8',
            beforeSend: function (xhr) { xhr.setRequestHeader('token', getCookie("APIKey")); },
            success: function (result) {
                var desigID = result.Designation;
                var deptID = result.Depertment;

                $.ajax({
                    url: api + "depertment",
                    data: { id: deptID },
                    type: 'GET',
                    dataType: 'json',
                    contentType: 'application/json; charset=utf-8',
                    beforeSend: function (xhr) { xhr.setRequestHeader('token', getCookie("APIKey")); },
                    success: function (result) {
                        $(v).find(".userDept").html(result.Name);
                    },
                    error: function (error) {

                    }
                });


                $.ajax({
                    url: api + "designation",
                    data: { id: desigID },
                    type: 'GET',
                    dataType: 'json',
                    contentType: 'application/json; charset=utf-8',
                    beforeSend: function (xhr) { xhr.setRequestHeader('token', getCookie("APIKey")); },
                    success: function (result) {
                        //console.log(result);
                        $(v).find(".userDesig").html(result.Name);
                    },
                    error: function (error) {

                    }
                });




            },
            error: function (error) {

            }
        });
    });


});


