﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using DevTrends.MvcDonutCaching;
    using Frapid.Web;
    
    #line 1 "..\..\Views\Blog\Home.cshtml"
    using Frapid.WebsiteBuilder;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Blog\Home.cshtml"
    using Frapid.WebsiteBuilder.Extensions;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Blog/Home.cshtml")]
    public partial class _Views_Blog_Home_cshtml : System.Web.Mvc.WebViewPage<Frapid.WebsiteBuilder.ViewModels.Blog>
    {
        public _Views_Blog_Home_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 5 "..\..\Views\Blog\Home.cshtml"
  
    ViewBag.Description = Model.Description;
    ViewBag.Title = Model.Title;
    Layout = Model.LayoutPath + Model.Layout;
    ViewBag.LayoutPath = Model.LayoutPath;

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 12 "..\..\Views\Blog\Home.cshtml"
 foreach (var content in Model.Contents.OrderByDescending(x => x.PublishOn))
{

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"post\"");

WriteLiteral(">\r\n        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 414), Tuple.Create("\"", 464)
, Tuple.Create(Tuple.Create("", 421), Tuple.Create("/blog/", 421), true)
            
            #line 15 "..\..\Views\Blog\Home.cshtml"
, Tuple.Create(Tuple.Create("", 427), Tuple.Create<System.Object, System.Int32>(content.CategoryAlias
            
            #line default
            #line hidden
, 427), false)
, Tuple.Create(Tuple.Create("", 449), Tuple.Create("/", 449), true)
            
            #line 15 "..\..\Views\Blog\Home.cshtml"
, Tuple.Create(Tuple.Create("", 450), Tuple.Create<System.Object, System.Int32>(content.Alias
            
            #line default
            #line hidden
, 450), false)
);

WriteAttribute("title", Tuple.Create(" title=\"", 465), Tuple.Create("\"", 487)
            
            #line 15 "..\..\Views\Blog\Home.cshtml"
, Tuple.Create(Tuple.Create("", 473), Tuple.Create<System.Object, System.Int32>(content.Title
            
            #line default
            #line hidden
, 473), false)
);

WriteLiteral(" class=\"blog header\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 16 "..\..\Views\Blog\Home.cshtml"
       Write(content.Title);

            
            #line default
            #line hidden
WriteLiteral("\r\n        </a>\r\n        <div");

WriteLiteral(" class=\"meta\"");

WriteLiteral(">\r\n            <a");

WriteLiteral(" class=\"item\"");

WriteAttribute("title", Tuple.Create(" title=\"", 608), Tuple.Create("\"", 634)
            
            #line 19 "..\..\Views\Blog\Home.cshtml"
, Tuple.Create(Tuple.Create("", 616), Tuple.Create<System.Object, System.Int32>(content.PublishOn
            
            #line default
            #line hidden
, 616), false)
);

WriteLiteral(">\r\n                <i");

WriteLiteral(" class=\"time icon\"");

WriteLiteral("></i>\r\n");

WriteLiteral("                ");

            
            #line 21 "..\..\Views\Blog\Home.cshtml"
           Write(content.PublishOn.ToString("D"));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </a>\r\n            <a");

WriteLiteral(" class=\"item\"");

WriteLiteral(">\r\n                <i");

WriteLiteral(" class=\"user icon\"");

WriteLiteral("></i>\r\n");

WriteLiteral("                ");

            
            #line 25 "..\..\Views\Blog\Home.cshtml"
           Write(content.AuthorName);

            
            #line default
            #line hidden
WriteLiteral("\r\n            </a>\r\n            <a");

WriteLiteral(" class=\"item\"");

WriteLiteral(">\r\n                <i");

WriteLiteral(" class=\"folder icon\"");

WriteLiteral("></i>\r\n");

WriteLiteral("                ");

            
            #line 29 "..\..\Views\Blog\Home.cshtml"
           Write(content.CategoryName);

            
            #line default
            #line hidden
WriteLiteral("\r\n            </a>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"content\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 33 "..\..\Views\Blog\Home.cshtml"
       Write(Html.Raw(content.Contents));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <a");

WriteLiteral(" class=\"ui basic button\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1147), Tuple.Create("\"", 1197)
, Tuple.Create(Tuple.Create("", 1154), Tuple.Create("/blog/", 1154), true)
            
            #line 35 "..\..\Views\Blog\Home.cshtml"
, Tuple.Create(Tuple.Create("", 1160), Tuple.Create<System.Object, System.Int32>(content.CategoryAlias
            
            #line default
            #line hidden
, 1160), false)
, Tuple.Create(Tuple.Create("", 1182), Tuple.Create("/", 1182), true)
            
            #line 35 "..\..\Views\Blog\Home.cshtml"
, Tuple.Create(Tuple.Create("", 1183), Tuple.Create<System.Object, System.Int32>(content.Alias
            
            #line default
            #line hidden
, 1183), false)
);

WriteLiteral(">Read More</a>\r\n    </div>\r\n");

            
            #line 37 "..\..\Views\Blog\Home.cshtml"

}

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591