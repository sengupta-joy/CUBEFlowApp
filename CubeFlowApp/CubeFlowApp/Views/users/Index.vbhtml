@Code
    ViewData("Title") = "Users"
    Layout = "~/Views/Shared/_Layout.vbhtml"
    Dim UsersObj = ViewData("userObj")
    Dim alphabetObj = ViewData("alphabetObj")
End Code

<style type="text/css">
    .user-block-x {
        margin: 5px;
        width: 150px;
        box-shadow:   #e9e7e7 1px 2px 8px 1px
    }
        .user-block-x img {
            height:50px;
            width:55px;
            border-radius:50%;
        }
    .header-with-border {
        border-top: 5px solid #0d783d;
        border-top-left-radius: 5px;
        border-top-right-radius: 5px;
        /*width:98%;*/
    }
</style>

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
                                        @For Each item In UsersObj
                                            @<div class="user-block user-block-x">
                                                <table>
                                                    <tr>
                                                        <td><img src="~/img/userImg/@(item.key).jpg" onerror="this.src='/img/default.png" /> </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <input type="hidden" value="@item.key" />
                                                            @item.value
                                                        </td>
                                                    </tr>
                                                </table>
                                            </div>
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
                        <div Class="card-tools">
                            <ul Class="pagination pagination-sm">
                                <li Class="page-item"><a href="#" class="page-link">&laquo;</a></li>
                                <li Class="page-item"><a href="#" class="page-link">1</a></li>
                                <li Class="page-item"><a href="#" class="page-link">2</a></li>
                                <li Class="page-item"><a href="#" class="page-link">3</a></li>
                                <li Class="page-item"><a href="#" class="page-link">&raquo;</a></li>
                            </ul>
                        </div>
                    </div>
                    <!-- /.card-header -->
                    <div Class="card-body">
                        <ul Class="todo-list" data-widget="todo-list">
                            @*<li>
                                <!-- drag handle -->
                                <span Class="handle">
                                    <i Class="fas fa-ellipsis-v"></i>
                                    <i Class="fas fa-ellipsis-v"></i>
                                </span>
                                <!-- checkbox -->
                                <div Class="icheck-primary d-inline ml-2">
                                    <input type="checkbox" value="" name="todo1" id="todoCheck1">
                                    <Label for="todoCheck1"></Label>
                                </div>
                                <!-- todo text -->
                                <span Class="text">Design a nice theme</span>
                                <!-- Emphasis label -->
                                <small Class="badge badge-danger"><i class="far fa-clock"></i> 2 mins</small>
                                <!-- General tools such as edit Or delete-->
                                <div Class="tools">
                                    <i Class="fas fa-edit"></i>
                                    <i Class="fas fa-trash-o"></i>
                                </div>
                            </li>
                            <li>
                                <span Class="handle">
                                    <i Class="fas fa-ellipsis-v"></i>
                                    <i Class="fas fa-ellipsis-v"></i>
                                </span>
                                <div Class="icheck-primary d-inline ml-2">
                                    <input type="checkbox" value="" name="todo2" id="todoCheck2" checked>
                                    <Label for="todoCheck2"></Label>
                                </div>
                                <span Class="text">Make the theme responsive</span>
                                <small Class="badge badge-info"><i class="far fa-clock"></i> 4 hours</small>
                                <div Class="tools">
                                    <i Class="fas fa-edit"></i>
                                    <i Class="fas fa-trash-o"></i>
                                </div>
                            </li>
                            <li>
                                <span Class="handle">
                                    <i Class="fas fa-ellipsis-v"></i>
                                    <i Class="fas fa-ellipsis-v"></i>
                                </span>
                                <div Class="icheck-primary d-inline ml-2">
                                    <input type="checkbox" value="" name="todo3" id="todoCheck3">
                                    <Label for="todoCheck3"></Label>
                                </div>
                                <span Class="text">Let theme shine Like a star</span>
                                <small Class="badge badge-warning"><i class="far fa-clock"></i> 1 day</small>
                                <div Class="tools">
                                    <i Class="fas fa-edit"></i>
                                    <i Class="fas fa-trash-o"></i>
                                </div>
                            </li>
                            <li>
                                <span Class="handle">
                                    <i Class="fas fa-ellipsis-v"></i>
                                    <i Class="fas fa-ellipsis-v"></i>
                                </span>
                                <div Class="icheck-primary d-inline ml-2">
                                    <input type="checkbox" value="" name="todo4" id="todoCheck4">
                                    <Label for="todoCheck4"></Label>
                                </div>
                                <span Class="text">Let theme shine Like a star</span>
                                <small Class="badge badge-success"><i class="far fa-clock"></i> 3 days</small>
                                <div Class="tools">
                                    <i Class="fas fa-edit"></i>
                                    <i Class="fas fa-trash-o"></i>
                                </div>
                            </li>
                            <li>
                                <span Class="handle">
                                    <i Class="fas fa-ellipsis-v"></i>
                                    <i Class="fas fa-ellipsis-v"></i>
                                </span>
                                <div Class="icheck-primary d-inline ml-2">
                                    <input type="checkbox" value="" name="todo5" id="todoCheck5">
                                    <Label for="todoCheck5"></Label>
                                </div>
                                <span Class="text">Check your messages And notifications</span>
                                <small Class="badge badge-primary"><i class="far fa-clock"></i> 1 week</small>
                                <div Class="tools">
                                    <i Class="fas fa-edit"></i>
                                    <i Class="fas fa-trash-o"></i>
                                </div>
                            </li>
                            <li>
                                <span Class="handle">
                                    <i Class="fas fa-ellipsis-v"></i>
                                    <i Class="fas fa-ellipsis-v"></i>
                                </span>
                                <div Class="icheck-primary d-inline ml-2">
                                    <input type="checkbox" value="" name="todo6" id="todoCheck6">
                                    <Label for="todoCheck6"></Label>
                                </div>
                                <span Class="text">Let theme shine Like a star</span>
                                <small Class="badge badge-secondary"><i class="far fa-clock"></i> 1 month</small>
                                <div Class="tools">
                                    <i Class="fas fa-edit"></i>
                                    <i Class="fas fa-trash-o"></i>
                                </div>
                            </li>*@
                        </ul>
                        
                    </div>
                    <!-- /.card-body -->
                    <div Class="card-footer clearfix">
                        <Button type="button" Class="btn btn-info float-right"><i Class="fas fa-plus"></i> Add item</Button>
                    </div>
                </div>
            </section>
        </div>
    </div>
</section>
