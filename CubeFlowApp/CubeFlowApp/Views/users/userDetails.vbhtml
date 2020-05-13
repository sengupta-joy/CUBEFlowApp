
@Code
    Layout = Nothing
    Dim keys = ViewData.Keys
    Dim userImg =ViewData("userid").ToString()
    Dim i = keys.Count
End Code

<div class="row">

    <img src="~/img/userImg/@(userImg).jpg" height="100" onerror="loadDefaultImg(this);" />
    @ViewData("name").ToString()

    <div Class="card header-with-border">
        <div Class="card-header">
            <h3 Class="card-title">
                <i Class="ion ion-clipboard mr-1"></i>
                About
            </h3>

        </div>
        <!-- /.card-header -->
        <div Class="card-body user-detail">
            <table>
                <tr>
                    <td></td>
                    <td>@ViewData("about").ToString()</td>
                </tr>
                <tr>
                    <td></td>
                    <td>@ViewData("userid").ToString()</td>
                </tr>
                <tr>
                    <td></td>
                    <td>@ViewData("email").ToString()</td>
                </tr>
                <tr>
                    <td></td>
                    <td>@ViewData("phone").ToString()</td>
                </tr>
                <tr>
                    <td></td>
                    <td>Extn-</td>
                </tr>
            </table>
        </div>
        <!-- /.card-body -->
        <div Class="card-footer clearfix">

        </div>
    </div>

    <div Class="card header-with-border">
        <div Class="card-header">
            <h3 Class="card-title">
                <i Class="ion ion-clipboard mr-1"></i>
                Reporting to
            </h3>

        </div>
        <!-- /.card-header -->
        <div Class="card-body user-detail">
            <table>
                <tr>
                    <td></td>
                    <td><img height="50" /></td>
                </tr>
                <tr>
                    <td></td>
                    <td>@ViewData("boss").ToString()</td>
                </tr>

            </table>
        </div>
        <!-- /.card-body -->
        <div Class="card-footer clearfix">
        </div>
    </div>

    <div Class="card header-with-border">
        <div Class="card-header">
            <h3 Class="card-title">
                <i Class="ion ion-clipboard mr-1"></i>
                Work
            </h3>

        </div>
        <!-- /.card-header -->
        <div Class="card-body user-detail">
            <table>
                <tr>
                    <td></td>
                    <td>@ViewData("desig").ToString()</td>
                </tr>
                <tr>
                    <td></td>
                    <td>@ViewData("dept").ToString()</td>
                </tr>
                <tr>
                    <td></td>
                    <td>@ViewData("branch").ToString()</td>
                </tr>
            </table>
        </div>
        <!-- /.card-body -->
        <div Class="card-footer clearfix">

        </div>
    </div>


    <div Class="card header-with-border">
        <div Class="card-header">
            <h3 Class="card-title">
                <i Class="ion ion-clipboard mr-1"></i>
                Personal
            </h3>

        </div>
        <!-- /.card-header -->
        <div Class="card-body user-detail">
            <table>
                <tr>
                    <td></td>
                    <td>@ViewData("address").ToString()</td>
                </tr>
                <tr>
                    <td></td>
                    <td>@ViewData("city").ToString()</td>
                </tr>
                <tr>
                    <td></td>
                    <td>@ViewData("country").ToString()</td>
                </tr>
            </table>
        </div>
        <!-- /.card-body -->
        <div Class="card-footer clearfix">
        </div>
    </div>
</div>
