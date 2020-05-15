
@Code
    Layout = Nothing
    Dim keys = ViewData.Keys
    Dim userImg = ViewData("userid").ToString()
    Dim bossDetails = ViewBag.bossDetails
    Dim i = keys.Count
End Code

<div class="row">

    

    <table style="border-bottom:5px;">
        <tr>
            <td rowspan="2"><img src="~/img/userImg/@(userImg).jpg" height="100" onerror="loadDefaultImg(this);" style="border-radius:50%;" /></td>
            <td><span class="users-name-header"> @ViewData("name").ToString()</span></td>
        </tr>
        <tr>
            
            <td><span class="users-about">@ViewData("about").ToString()</span> </td>
        </tr>
    </table>
    
    <div Class="card header-with-border user-detail-card">
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

    <div Class="card header-with-border user-detail-card">
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
                    <td>@Html.Partial("_userPertialView", bossDetails)</td>
                </tr>
            </table>
        </div>
        <!-- /.card-body -->
        <div Class="card-footer clearfix">
        </div>
    </div>

    <div Class="card header-with-border user-detail-card">
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


    <div Class="card header-with-border user-detail-card">
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
