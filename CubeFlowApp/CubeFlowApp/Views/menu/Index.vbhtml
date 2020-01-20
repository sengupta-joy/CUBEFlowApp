
@Code
    Layout = Nothing
    Dim items As Newtonsoft.Json.Linq.JArray = Newtonsoft.Json.JsonConvert.DeserializeObject(ViewData("menuObj"))

End Code

<!-- Font Awesome -->
@*<link rel="stylesheet" href="plugins/fontawesome-free/css/all.min.css">*@
<!-- Ionicons -->
<link rel="stylesheet" href="https://code.ionicframework.com/ionicons/2.0.1/css/ionicons.min.css">
<!-- Tempusdominus Bbootstrap 4 -->
@*<link rel="stylesheet" href="plugins/tempusdominus-bootstrap-4/css/tempusdominus-bootstrap-4.min.css">
    <!-- iCheck -->
    <link rel="stylesheet" href="plugins/icheck-bootstrap/icheck-bootstrap.min.css">
    <!-- JQVMap -->
    <link rel="stylesheet" href="plugins/jqvmap/jqvmap.min.css">
    <!-- Theme style -->
    <link rel="stylesheet" href="dist/css/adminlte.min.css">
    <!-- overlayScrollbars -->
    <link rel="stylesheet" href="plugins/overlayScrollbars/css/OverlayScrollbars.min.css">
    <!-- Daterange picker -->
    <link rel="stylesheet" href="plugins/daterangepicker/daterangepicker.css">
    <!-- summernote -->
    <link rel="stylesheet" href="plugins/summernote/summernote-bs4.css">*@
<!-- Google Font: Source Sans Pro -->
@*<link href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,400i,700" rel="stylesheet">*@

<title>[@ViewBag.Title] CUBE</title>
@Styles.Render("~/Content/css")
@Styles.Render("~/Content/plugin")

@Scripts.Render("~/bundles/modernizr")
@Scripts.Render("~/bundles/jsplugin")
@Scripts.Render("~/bundles/layout")

<ul class="nav nav-pills nav-sidebar flex-column" data-widget="treeview" role="menu" data-accordion="false">
    <!-- Add icons to the links using the .nav-icon class
         with font-awesome or any other icon font library -->
    @For Each item In items.Where(Function(x) DirectCast(x, Newtonsoft.Json.Linq.JObject)("Parent").ToString() = "")
        Dim i = item
        @<li class="nav-item has-treeview">
            <a href="#" Class="nav-link">
                <i Class="nav-icon fas fa-copy"></i>
                <p>
                    @DirectCast(item, Newtonsoft.Json.Linq.JObject)("Name")
                    <i Class="fas fa-angle-left right"></i>
                    <span Class="badge badge-info right">6</span>
                </p>
            </a>
            <ul Class="nav nav-treeview">
                @For Each subItem In items.Where(Function(y) DirectCast(y, Newtonsoft.Json.Linq.JObject)("Parent").ToString() = DirectCast(item, Newtonsoft.Json.Linq.JObject)("ID").ToString())
                    @<li Class="nav-item">
                        <a href="pages/layout/top-nav.html" Class="nav-link">
                            <i Class="far fa-circle nav-icon"></i>
                            <p>@DirectCast(subItem, Newtonsoft.Json.Linq.JObject)("Name")</p>
                        </a>
                    </li>
                Next
            </ul>
        </li>
    Next

</ul>

@Scripts.Render("~/bundles/bootstrap")

