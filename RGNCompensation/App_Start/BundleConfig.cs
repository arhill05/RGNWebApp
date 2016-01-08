using System.Web;
using System.Web.Optimization;

namespace RGNCompensation
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/knockout").Include(
                "~/Scripts/knockout-3.4.0.js"));
            bundles.Add(new ScriptBundle("~/bundles/toastr").Include(
                "~/Scripts/toastr.min.js"));

            //bundles.Add(new ScriptBundle("~/bundles/DataTables").Include(
            //    "~/Scripts/DataTables/jquery.dataTables.js",
            //    "~/Scripts/DataTables/responsive.bootstrap.js",
            //    "~/Scripts/DataTables/dataTables.responsive.js",
            //    "~/Scripts/DataTables/dataTables.bootstrap.js",
            //    "~/Scripts/DataTables/jqueryui.js",
            //    "~/Scripts/DataTables/responsive.foundation.js",
            //    "~/Scripts/DataTables/responise.jqueryui.js"));



            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/toastr.min.css"));

            bundles.Add(new StyleBundle("~/Content/DataTables").IncludeDirectory(
                "~/Content/DataTables/css", "*.css", true));

        }
    }
}
