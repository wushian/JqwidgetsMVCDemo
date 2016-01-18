using System.Web;
using System.Web.Optimization;

namespace JqwidgetsMVCDemo
{
    public class BundleConfig
    {
        // 有关绑定的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // 使用要用于开发和学习的 Modernizr 的开发版本。然后，当你做好
            // 生产准备时，请使用 http://modernizr.com 上的生成工具来仅选择所需的测试。
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/jqwidgets").Include(
            "~/Scripts/jqxcore.js",
            "~/Scripts/jqxdata.js",
            "~/Scripts/jqxgrid.js",
            "~/Scripts/jqxgrid.selection.js",
            "~/Scripts/jqxgrid.pager.js",
            "~/Scripts/jqxlistbox.js",
            "~/Scripts/jqxbuttons.js",
            "~/Scripts/jqxscrollbar.js",
            "~/Scripts/jqxdatatable.js",
            "~/Scripts/jqxtreegrid.js",
            "~/Scripts/jqxmenu.js",
            "~/Scripts/jqxcalendar.js",
            "~/Scripts/jqxgrid.sort.js",
            "~/Scripts/jqxgrid.filter.js",
            "~/Scripts/jqxdatetimeinput.js",
            "~/Scripts/jqxdropdownlist.js",
            "~/Scripts/jqxslider.js",
            "~/Scripts/jqxeditor.js",
            "~/Scripts/jqxinput.js",
            "~/Scripts/jqxdraw.js",
            "~/Scripts/jqxchart.core.js",
            "~/Scripts/jqxchart.rangeselector.js",
            "~/Scripts/jqxtree.js",
            "~/Scripts/globalization/globalize.js",
            "~/Scripts/jqxbulletchart.js",
            "~/Scripts/jqxcheckbox.js",
            "~/Scripts/jqxradiobutton.js",
            "~/Scripts/jqxvalidator.js",
            "~/Scripts/jqxpanel.js",
            "~/Scripts/jqxpasswordinput.js",
            "~/Scripts/jqxnumberinput.js",
            "~/Scripts/jqxcombobox.js",
            "~/Scripts/jqxwindow.js",
            "~/Scripts/jqxtooltip.js",
            "~/Scripts/jqxtabs.js",
            "~/Scripts/jqxdocking.js",
            "~/Scripts/jqxsplitter.js",
            "~/Scripts/jqxangular.js"
            ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/jqx.base.css",
                "~/Content/jqx.arctic.css",
                "~/Content/jqx.black.css",
                "~/Content/jqx.bootstrap.css",
                "~/Content/jqx.classic.css",
                "~/Content/jqx.darkblue.css",
                "~/Content/jqx.energyblue.css",
                "~/Content/jqx.fresh.css",
                "~/Content/jqx.highcontrast.css",
                "~/Content/jqx.metro.css",
                "~/Content/jqx.metrodark.css",
                "~/Content/jqx.office.css",
                "~/Content/jqx.orange.css",
                "~/Content/jqx.shinyblack.css",
                "~/Content/jqx.summer.css",
                "~/Content/jqx.web.css",
                "~/Content/jqx.ui-darkness.css",
                "~/Content/jqx.ui-lightness.css",
                "~/Content/jqx.ui-le-frog.css",
                "~/Content/jqx.ui-overcast.css",
                "~/Content/jqx.ui-redmond.css",
                "~/Content/jqx.ui-smoothness.css",
                "~/Content/jqx.ui-start.css",
                "~/Content/jqx.ui-sunny.css",
                "~/Content/bootstrap.css",
                "~/Content/site.css"
                ));


        }



    }
}
