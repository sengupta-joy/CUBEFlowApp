Imports System.Web.Optimization

Public Module BundleConfig
    ' For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
    Public Sub RegisterBundles(ByVal bundles As BundleCollection)

        bundles.Add(New ScriptBundle("~/bundles/jquery").Include(
                    "~/Scripts/jquery-3.3.1.min.js"))

        'bundles.Add(New ScriptBundle("~/bundles/jqueryval").Include(
        '            "~/Scripts/jquery.validate*"))

        ' Use the development version of Modernizr to develop with and learn from. Then, when you're
        ' ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
        'bundles.Add(New ScriptBundle("~/bundles/modernizr").Include(
        '            "~/Scripts/modernizr-*"))

        'bundles.Add(New ScriptBundle("~/bundles/bootstrap").Include(
        '          "~/Scripts/bootstrap.js"))

        'bundles.Add(New StyleBundle("~/Content/css").Include(
        '          "~/Content/bootstrap.css",
        '          "~/Content/site.css"))

        bundles.Add(New StyleBundle("~/Content/login").Include("~/Content/login.css"))

        bundles.Add(New StyleBundle("~/Content/plugin").Include(
        "~/plugins/fontawesome-free/css/all.min.css",
        "~/Content/ionicons.min.css",
        "~/plugins/tempusdominus-bootstrap-4/css/tempusdominus-bootstrap-4.min.css",
        "~/plugins/icheck-bootstrap/icheck-bootstrap.min.css",
        "~/plugins/jqvmap/jqvmap.min.css",
        "~/dist/css/adminlte.min.css",
        "~/plugins/overlayScrollbars/css/OverlayScrollbars.min.css",
        "~/plugins/daterangepicker/daterangepicker.css",
        "~/plugins/summernote/summernote-bs4.css",
        "~/Content/google_fonts.css"))

        bundles.Add(New ScriptBundle("~/bundles/jsplugin").Include(
                "~/Scripts/jquery-3.3.1.min.js",
                "~/plugins/jquery-ui/jquery-ui.min.js",
                "~/plugins/bootstrap/js/bootstrap.bundle.min.js",
                "~/plugins/chart.js/Chart.min.js",
                "~/plugins/sparklines/sparkline.js",
                "~/plugins/jqvmap/jquery.vmap.min.js",
                "~/plugins/jqvmap/maps/jquery.vmap.usa.js",
                "~/plugins/jquery-knob/jquery.knob.min.js",
                "~/plugins/moment/moment.min.js",
                "~/plugins/daterangepicker/daterangepicker.js",
                "~/plugins/tempusdominus-bootstrap-4/js/tempusdominus-bootstrap-4.min.js",
                "~/plugins/summernote/summernote-bs4.min.js",
                "~/plugins/overlayScrollbars/js/jquery.overlayScrollbars.min.js",
                "~/dist/js/adminlte.js",
                "~/dist/js/pages/dashboard.js",
                "~/dist/js/demo.js"
        ))

        bundles.Add(New ScriptBundle("~/bundles/layout").Include(
            "~/Scripts/layout.js"
            ))

        bundles.Add(New ScriptBundle("~/bundles/Cookie").Include(
           "~/Scripts/CookieHelper.js"
           ))

    End Sub
End Module

