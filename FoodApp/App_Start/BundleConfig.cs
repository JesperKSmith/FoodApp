﻿using System.Web;
using System.Web.Optimization;

namespace FoodApp
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/bootstrap-multiselect-css").Include(
                    "~/Content/bootstrap-multiselect.css"
                ));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap-multiselect").Include(
                    "~/Scripts/bootstrap-multiselect.js"
                ));
            
            // Angular App
            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                   "~/Scripts/angular.js",
                   "~/Scripts/food_app.js"
               ));

            bundles.Add(new StyleBundle("~/Content/fontawesome").Include(
                    "~/Content/fontawesome.css"
                ));

            // SignalR
            bundles.Add(new ScriptBundle("~/bundles/signal-r").Include(
                   "~/Scripts/jquery.signalR-2.2.2.min.js"
               ));
        }
    }
}
