using System.Web;
using System.Web.Optimization;

namespace TemplateGentelella
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new ScriptBundle("~/bundles/js")
                .Include(
                "~/Content/js/custom.js",
                "~/Content/vendors/jquery/dist/jquery.min.js",
                "~/Content/vendors/bootstrap/dist/js/bootstrap.min.js",
                "~/Content/vendors/fastclick/lib/fastclick.js",
                "~/Content/vendors/nprogress/nprogress.js",
                "~/Content/vendors/Chart.js/dist/Chart.min.js",
                "~/Content/vendors/gauge.js/dist/gauge.min.js",
                "~/Content/vendors/bootstrap-progressbar/bootstrap-progressbar.min.js",
                "~/Content/vendors/iCheck/icheck.min.js",
                "~/Content/vendors/skycons/skycons.js",
                "~/Content/vendors/Flot/jquery.flot.js",
                "~/Content/vendors/Flot/jquery.flot.pie.js",
                "~/Content/vendors/Flot/jquery.flot.time.js",
                "~/Content/vendors/Flot/jquery.flot.stack.js",
                "~/Content/vendors/Flot/jquery.flot.resize.js",
                "~/Content/vendors/flot.orderbars/js/jquery.flot.orderBars.js",
                "~/Content/vendors/flot-spline/js/jquery.flot.spline.min.js",
                "~/Content/vendors/flot.curvedlines/curvedLines.js",
                "~/Content/vendors/DateJS/build/date.js",
                "~/Content/vendors/jqvmap/dist/jquery.vmap.js",
                "~/Content/vendors/jqvmap/dist/maps/jquery.vmap.world.js",
                "~/Content/vendors/jqvmap/examples/js/jquery.vmap.sampledata.js",
                "~/Content/vendors/moment/min/moment.min.js",
                "~/Content/vendors/bootstrap-daterangepicker/daterangepicker.js",
                "~/Content/build/js/custom.min.js"
                ));

            bundles.Add(new StyleBundle("~/Content/css")
                .Include("~/Content/css/custom.min.css",
                "~/Content/vendors/bootstrap/dist/css/bootstrap.min.css",
                "~/Content/vendors/font-awesome/css/font-awesome.min.css",
                "~/Content/vendors/nprogress/nprogress.css",
                "~/Content/vendors/iCheck/skins/flat/green.css",
                "~/Content/vendors/bootstrap-progressbar/css/bootstrap-progressbar-3.3.4.min.css",
                "~/Content/vendors/jqvmap/dist/jqvmap.min.css",
                "~/Content/vendors/bootstrap-daterangepicker/daterangepicker.css",
                "~/Content/build/css/custom.min.css"

                ));
        }
    }
}
