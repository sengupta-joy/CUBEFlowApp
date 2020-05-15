@Code
    ViewData("Title") = "Users"
    Layout = "~/Views/Shared/_Layout.vbhtml"
    Dim UsersObj = ViewData("userObj")
    Dim alphabetObj = ViewData("alphabetObj")
    Dim brnchObj As Dictionary(Of String, String) = ViewData("brnchObj")
    Dim deptObj As Dictionary(Of String, String) = ViewData("deptObj")
    Dim desigObj As Dictionary(Of String, String) = ViewData("desigObj")
End Code

<style type="text/css">
    .user-block-x {
        margin: 5px;
        width: 150px;
        box-shadow:   #e9e7e7 1px 2px 8px 1px;
        font-size: 12px;
        cursor:pointer;
    }
        .user-block-x:hover {
            box-shadow: #ccc6c6 1px 2px 8px 1px;
        }

        .user-block-x span.usr-Name {
            color:#808080;
            font-family:Tahoma;
            font-size:10pt;
        }
        .user-block-x .userDesig, .user-block-x .userDept {
            color: #808080;
            font-family: Tahoma;
            font-size: 8pt;
        }

    .user-block-x td {
        vertical-align: top;
    }
        .user-block-x img {
            height: 50px;
            width: 55px;
            border-radius: 50%;
        }
    .header-with-border {
        border-top: 5px solid #0d783d;
        border-top-left-radius: 5px;
        border-top-right-radius: 5px;
        /*width:98%;*/
    }
    .users-name-header {
        font-size: 16pt;
        font-weight: bold;
        color: #0e65d2;
    }
    .users-about {
        font-size: 11pt;
        color: gray;
    }

    .user-detail-card
    {
        width:90%;
    }


</style>
<script src="~/Scripts/users.js"></script>
<section class="content">
    <div class="container-fluid">
        <div class="row">
            <!-- Left col -->
            <section class="col-lg-4 connectedSortable">
                <!-- Custom tabs (Charts with tabs)-->
                <div class="card header-with-border">
                        <div Class="card-header">
                            <h3 Class="card-title">
                                <i Class="ion ion-clipboard mr-1"></i>
                                Find user
                            </h3>
                        </div>
                        <div class="panel with-nav-tabs panel-default">
                            <div class="panel-heading">
                                <ul class="nav nav-tabs">
                                    <li class="active nav-item"><a class="nav-link" href="#tab1default" data-toggle="tab">By name</a></li>
                                    <li class="nav-item"><a class="nav-link" href="#tab2default" data-toggle="tab">By role</a></li>
                                    <li class="nav-item dropdown">
                                        <a class="nav-link" href="#" data-toggle="dropdown">More<span class="caret"></span></a>
                                        <ul class="dropdown-menu" role="menu">
                                            <li class="nav-item"><a class="nav-link" href="#tab4default" data-toggle="tab">By depertment</a></li>
                                            <li class="nav-item"><a class="nav-link" href="#tab5default" data-toggle="tab">By branch</a></li>
                                            <li class="nav-item"><a class="nav-link" href="#tab6default" data-toggle="tab">By designation</a></li>
                                        </ul>
                                    </li>
                                </ul>
                            </div>
                            <div class="panel-body">
                                <div class="tab-content">
                                    <div class="tab-pane fade in active" id="tab1default">
                                        <div style="margin-left:3px;">
                                            @for Each item In alphabetObj
                                                @<span style="display:block;padding:1px;float:left;margin:2px;font-size:12px;">
                                                        @item
                                                 </span>
                                            Next
                                        </div>
                                        <br />
                                        @For Each item In UsersObj
                                            @Html.Partial("_userPertialView", item)
                                        Next
                                    </div>
                                    <div Class="tab-pane fade" id="tab2default">users by role</div>
                                    <div Class="tab-pane fade" id="tab4default">users by depertment</div>
                                    <div Class="tab-pane fade" id="tab5default">users byy branch</div>
                                    <div Class="tab-pane fade" id="tab6default">users byy branch</div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <!-- /.card -->
                    <!-- TO DO List -->
                    <!-- /.card -->
            </section>
            <section class="col-lg-8 connectedSortable">
                <div Class="card header-with-border">
                    <div Class="card-header">
                        <h3 Class="card-title">
                            <i Class="ion ion-clipboard mr-1"></i>
                            User details
                        </h3>
                        
                    </div>
                    <!-- /.card-header -->
                    <div Class="card-body user-detail">
                        @*Dim obj = New With {.id = item}
                        @Html.Action("userDetails", "users", New With {.id = item})*@
                    </div>
                    <!-- /.card-body -->
                    <div Class="card-footer clearfix">
                        <Button type="button" Class="btn btn-info float-right"><i Class="fas fa-plus"></i> Add item</Button>
                    </div>
                </div>
                <div Class="card header-with-border">
                    <div Class="card-header">
                        <h3 Class="card-title">
                            <i Class="ion ion-clipboard mr-1"></i>
                            Hgherarchy
                        </h3>
                    </div>
                    <div Class="card-body">
                        <div class="panel with-nav-tabs panel-default">
                            <div class="panel-heading">
                                <ul class="nav nav-tabs">
                                    <li class="active nav-item"><a class="nav-link" href="#tabContPrntUser" data-toggle="tab">By name</a></li>
                                    <li class="nav-item"><a class="nav-link" href="#tabContSubUser" data-toggle="tab">Subordinates</a></li>
                                </ul>
                            </div>
                            <div class="panel-body">
                                <div class="tab-content">
                                    <div class="tab-pane fade in active" id="tabContPrntUser">
                                        
                                    </div>
                                    <div Class="tab-pane fade" id="tabContSubUser">

                                    </div>
                                   
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </section>
        </div>
    </div>
</section>
