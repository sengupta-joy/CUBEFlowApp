function loadDefaultImg(th) {
    $(th).attr("src","\\img\\default.png");
}

$(document).ready(function () {
    $(".user-block").on("click", function () {
        var uid = $(this).find("#hdnID").val();
        var url = getCookie("APIUrl") + "/users";

        $.ajax({
            url: url,
            data: {id:uid},
            type: 'GET',
            dataType: 'json',
            contentType: 'application/json; charset=utf-8',
            beforeSend: function (xhr) { xhr.setRequestHeader('token', getCookie("APIKey")); },
            success: function (result) {
                console.log(result);
            },
            error: function (error) {

            }
        });


    }); 
});