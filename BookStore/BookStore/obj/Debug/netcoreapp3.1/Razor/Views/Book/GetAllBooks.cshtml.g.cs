#pragma checksum "C:\Users\it2\Desktop\BookStore\05-May-2021\BookStore\BookStore\BookStore\Views\Book\GetAllBooks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a68b84851bfb2a14f5542ffe53063e32f86b041"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_GetAllBooks), @"mvc.1.0.view", @"/Views/Book/GetAllBooks.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a68b84851bfb2a14f5542ffe53063e32f86b041", @"/Views/Book/GetAllBooks.cshtml")]
    public class Views_Book_GetAllBooks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BookStore.Models.BookModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\it2\Desktop\BookStore\05-May-2021\BookStore\BookStore\BookStore\Views\Book\GetAllBooks.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3 class=\"display-4\" >All Book List </h3>\r\n\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n\r\n         \r\n");
#nullable restore
#line 13 "C:\Users\it2\Desktop\BookStore\05-May-2021\BookStore\BookStore\BookStore\Views\Book\GetAllBooks.cshtml"
         foreach (var book in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""col-md-4"">
                <h3 class=""display-4"">All books</h3>
                <div class=""card mb-4 shadow-sm"">
                    <svg class=""bd-placeholder-img card-img-top "" width=""100%"" height=""225"" xmlns=""http://www.w3.org/2000/svg"" aria-label=""Card image cap"" />
                    <div class=""card-body"">
                        <h3 class=""card-title"">");
#nullable restore
#line 20 "C:\Users\it2\Desktop\BookStore\05-May-2021\BookStore\BookStore\BookStore\Views\Book\GetAllBooks.cshtml"
                                          Write(book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                        <p class=\"card\">");
#nullable restore
#line 21 "C:\Users\it2\Desktop\BookStore\05-May-2021\BookStore\BookStore\BookStore\Views\Book\GetAllBooks.cshtml"
                                   Write(book.description);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                        <div class=\"d-flex justif-content-between  align-items-center\">\r\n                            <div class=\"btn-group\">\r\n                                <a");
            BeginWriteAttribute("href", " href= \"", 890, "\"", 920, 2);
            WriteAttributeValue("", 898, "/book/getbook/", 898, 14, true);
#nullable restore
#line 24 "C:\Users\it2\Desktop\BookStore\05-May-2021\BookStore\BookStore\BookStore\Views\Book\GetAllBooks.cshtml"
WriteAttributeValue("", 912, book.Id, 912, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm btn-outline-danger-secondery\">View details</a>\r\n                            </div>\r\n                            <small class=\" text-muted\">");
#nullable restore
#line 26 "C:\Users\it2\Desktop\BookStore\05-May-2021\BookStore\BookStore\BookStore\Views\Book\GetAllBooks.cshtml"
                                                  Write(book.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                        </div>\r\n\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 33 "C:\Users\it2\Desktop\BookStore\05-May-2021\BookStore\BookStore\BookStore\Views\Book\GetAllBooks.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BookStore.Models.BookModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
