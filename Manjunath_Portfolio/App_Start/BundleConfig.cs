using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Optimization;

namespace Manjunath_Portfolio
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery-3.4.1.min.js"));

            //bootstrap 
            bundles.Add(new StyleBundle("~/bundles/bootstrapstyles").Include(
                "~/Content/Bootstrap5/css/bootstrap.min.css"
                ));

            bundles.Add(new Bundle("~/bundles/bootstrapjs").Include(
                "~/Content/Bootstrap5/js/bootstrap.min.js"
                ));

            //fontawesome
            bundles.Add(new StyleBundle("~/bundles/fontawesome").Include(
                "~/content/font-awesome.min.css"
                ));

            //css : custom css
            bundles.Add(new Bundle("~/bundles/customcss").Include(
                   "~/Content/CustomCSS/customcss1.css"
                   ));
        }
    }
}
