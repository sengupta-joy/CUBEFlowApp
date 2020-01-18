
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    @Styles.Render("~/Content/login")
    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/layout")


    <script type="text/javascript">
        $(document).ready(function () {

            $("#btnLogin").click(function () {
                var url = getCookie("APIUrl")+ "login";
               
                var uid = $("#txtUser").val();
                var pass = $("#txtPass").val();

                uid = "AUBUSR190690000W";
                pass = "123456";

                $("#lblMsg").text("waiting for server..");

                $.ajax({
                    url: url,
                    data: { id: uid, password: pass },
                    type: 'GET',
                    dataType: 'json',
                    contentType: 'application/json; charset=utf-8',
                    success: function (result) {
                        console.log(result);
                        //if result = success, navigate home page
                        //else display error message
                        if (result == null) {
                            $("#lblMsg").text("login failed");
                        } else {
                            if (result.Tocken == "") {
                                $("#lblMsg").text("login failed");
                            } else {
                                setCookie('APIKey', result.Tocken);
                                $(location).attr("href", "../home/index?key=" + result.Tocken);
                            }
                        }


                    },
                    error: function (error) {
                        //console.log(error);
                        $("#lblMsg").text("invalid attempt");
                    }
                });
            });
        });
    </script>


</head>
<body>
    <form id="form1" runat="server">
        <div class='bold-line'></div>
        <div class='container'>
            <div class='window'>
                <div class='overlay'></div>
                <div class='content'>
                    <div class='welcome'>CUBE</div>
                    <div class='subtitle'></div>
                    <div class='input-fields'>
                       
                       <input type="Text" id="txtUser" placeholder='Username' class='input-line full-width' />

                        <input type='password' id="txtPass" placeholder='Password' class='input-line full-width' />

                    </div>

                    <div>
                        <input type="button" id="btnLogin" class='ghost-round full-width login-button' value="Let me in" />
                    </div>
                    <div class='spacing'><span id="lblMsg"></span></div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
