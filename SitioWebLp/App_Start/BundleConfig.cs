using System.Web;
using System.Web.Optimization;

namespace SitioWebLp
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

            bundles.Add(new Bundle("~/bundles/bootstrap").Include(
                       "~/Scripts/bootstrap.bundle.min.js",
                              "~/Scripts/bootstrap.min.js",


                              //  "~/Scripts/Theme/vendor/bootstrap/js/bootstrap.min.js",
                              "~/Scripts/Theme/js/theme.js",
                              "~/Scripts/Theme/vendor/jquery.appear/jquery.appear.min.js",
                              "~/Scripts/Theme/vendor/jquery.easing/jquery.easing.min.js",
                              "~/Scripts/Theme/vendor/jquery-cookie/jquery-cookie.min.js",
                              //       "~/Scripts/Theme/vendor/popper/umd/popper.min.js",
                              "~/Scripts/Theme/vendor/common/common.min.js",
                              "~/Scripts/Theme/vendor/jquery.validation/jquery.validation.min.js",
                              "~/Scripts/Theme/vendor/jquery.easy-pie-chart/jquery.easy-pie-chart.min.js",
                              "~/Scripts/Theme/vendor/jquery.gmap/jquery.gmap.min.js",
                              "~/Scripts/Theme/vendor/jquery.lazyload/jquery.lazyload.min.js",
                              "~/Scripts/Theme/vendor/isotope/jquery.isotope.min.js",
                              "~/Scripts/Theme/vendor/owl.carousel/owl.carousel.min.js",
                              "~/Scripts/Theme/vendor/magnific-popup/jquery.magnific-popup.min.js",
                              "~/Scripts/Theme/vendor/vide/vide.min.js",
                              "~/Scripts/Theme/vendor/rs-plugin/js/jquery.themepunch.tools.min.js",
                              "~/Scripts/Theme/vendor/rs-plugin/js/jquery.themepunch.revolution.min.js",
                              "~/Scripts/Theme/js/custom.js",
                              "~/Scripts/Theme/js/theme.init.js"
                               //"~/Scripts/jquery.blockUI.js",
                               //"~/Scripts/toastr.min.js",
                               //  "~/Scripts/select2.min.js",
                               //    "~/Scripts/jquery.dataTables.min.js",
                               //"~/Scripts/jquery-ui-{version}.js"
                               ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Scripts/Theme/vendor/bootstrap/css/bootstrap.min.css",
                    "~/Scripts/Theme/vendor/font-awesome/css/fontawesome-all.min.css",
                    "~/Scripts/Theme/vendor/animate/animate.min.css",
                    "~/Scripts/Theme/vendor/simple-line-icons/css/simple-line-icons.min.css",
                 "~/Content/bootstrap.min.css",                   
                   
                    "~/Scripts/Theme/vendor/owl.carousel/assets/owl.carousel.min.css",
                    "~/Scripts/Theme/vendor/owl.carousel/assets/owl.theme.default.min.css",
                    "~/Scripts/Theme/vendor/magnific-popup/magnific-popup.min.css",
                     "~/Scripts/Theme/css/theme.css",
                     "~/Scripts/Theme/css/theme-elements.css",
                     "~/Scripts/Theme/css/theme-blog.css",
                     "~/Scripts/Theme/css/theme-shop.css",
                    //"~/Scripts/Theme/vendor/rs-plugin/css/settings.css",
                    //"~/Scripts/Theme/vendor/rs-plugin/css/layers.css",
                    //"~/Scripts/Theme/vendor/rs-plugin/css/navigation.css",
                     //   "~/Scripts/Theme/css/skins/skin-corporate-5.css",
                     "~/Scripts/Theme/css/skins/default.css",
                      "~/Scripts/Theme/css/custom.css"
                   ));
        }
    }
}
