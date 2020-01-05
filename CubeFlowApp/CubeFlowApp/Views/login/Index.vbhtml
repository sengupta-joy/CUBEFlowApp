
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    @Styles.Render("~/Content/login")
    @Scripts.Render("~/bundles/jquery")

    <script type="text/javascript">
        $(document).ready(function () {
            $("#btnLogin").click(function () {
                var url = "/login/get";
                var uid = $("#txtUser").val();
                var pass = $("#txtPass").val();

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
                        if (result.msg != "SUCCESS") {
                            $("#lblMsg").text(result.msg);
                        } else {
                            $(location).attr("href", "home/index");
                        }
                    },
                    error: function (error) {
                        console.log(error);
                        alert("error");
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
                    <div class='welcome'>FlowR</div>
                    <div class='subtitle'>We're almost done. Before using our services you need to create an account.</div>
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
