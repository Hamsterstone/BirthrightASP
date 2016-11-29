using System.Web;
using System.Web.Optimization;

namespace BirthrightASP
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
                      "~/Scripts/respond.js"//,
                                      ));
            //bundles.Add(new ScriptBundle("~/bundles/PtolemyJS").Include(


            //"~/Scripts/PtolemyJS/app.js",

            //"~/Scripts/PtolemyJS/bower_components/raphael-pan-zoom/src/raphael.pan-zoom.min.js",
                
            //    "~/Scripts/PtolemyJS/bower_components/Javascript-Voronoi/rhill-voronoi-core.min.js",
            //    "~/Scripts/PtolemyJS/bower_components/raphael/raphael-min.js",


                
            //     "~/Scripts/PtolemyJS/ptolemy/Cell.js", "~/Scripts/PtolemyJS/ptolemy/util/util.js",
            //     "~/Scripts/PtolemyJS/bower_components/noisejs/perlin.js",



            //     "~/Scripts/PtolemyJS/ptolemy/plugins/Ptolemy.worldgeneration.js",
            //     "~/Scripts/PtolemyJS/ptolemy/Ptolemy.js",
            //     "~/Scripts/PtolemyJS/node_modules/requirejs/require.js",
            //     "~/Scripts/PtolemyJS/ptolemy/app.js"

            //     ));
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            

            //                < script data - main = "ptolemy/app" src = "//Scripts/" ></ script >

            //D:\Dropbox\Vision\Projects\Birthright\BirthrightASP\BirthrightASP\Scripts\PtolemyJS\app.js

        }
    }
}
