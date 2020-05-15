function loadDefaultImg(th) {
    $(th).attr("src","\\img\\default.png");
}


var api = "";



function user_block_click() {
    var uid = $(this).find("#hdnID").val();
    var url = "/users/userDetails";
  
    $.ajax({
        url: url,
        data: { id: uid },
        type: 'GET',
        dataType: 'html',
        contentType: 'text/html',
        success: function (result) {
            $(".user-detail").html(result);
            user_details();
            $(".user-block").click(user_block_click);
           
        },
        error: function (error) {
            console.log(error);
        }
    });
}

function user_details() {
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
}


$(document).ready(function () {

    api = getCookie("APIUrl");
    

    $(".user-block").click(user_block_click);

    user_details();


});


