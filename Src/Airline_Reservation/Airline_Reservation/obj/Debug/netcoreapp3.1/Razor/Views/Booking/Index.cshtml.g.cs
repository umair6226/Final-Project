#pragma checksum "C:\Users\LENOVO\Documents\Final-Project\Src\Airline_Reservation\Airline_Reservation\Views\Booking\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d65be69a4924df694186317d5d00947143cee05f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Booking_Index), @"mvc.1.0.view", @"/Views/Booking/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\LENOVO\Documents\Final-Project\Src\Airline_Reservation\Airline_Reservation\Views\_ViewImports.cshtml"
using Airline_Reservation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LENOVO\Documents\Final-Project\Src\Airline_Reservation\Airline_Reservation\Views\_ViewImports.cshtml"
using Airline_Reservation.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d65be69a4924df694186317d5d00947143cee05f", @"/Views/Booking/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b42fde6496c460ec46053cd93508a2c8d7f992f1", @"/Views/_ViewImports.cshtml")]
    public class Views_Booking_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Bussiness_Logic_Layer.FlightsBL>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<style>
    h5,h6{
        color : darkblue;
        font-weight:600;
        display:inline;
    }
    .panel {
        border-radius: 0.5rem;
        box-shadow: 5px 5px 15px lightgrey;
    }

    .lblheading {
        font-weight: 500;
    }
    .PriceCard {
        box-shadow: 5px 5px 15px lightgrey;
        height:max-content;
    }
    .leftlbl{
        float:right;
        font-weight:500;
    }
</style>
<div class=""row"">
");
#nullable restore
#line 27 "C:\Users\LENOVO\Documents\Final-Project\Src\Airline_Reservation\Airline_Reservation\Views\Booking\Index.cshtml"
     foreach (var item in Model)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-md-8\">\r\n\r\n            <div>\r\n                <div class=\"mt-3 ml-3\">\r\n                    <h5>Review Your Booking</h5>\r\n                    <div style=\"display:inline-block;float:right;\" class=\"mr-5\">\r\n                        <h6>");
#nullable restore
#line 36 "C:\Users\LENOVO\Documents\Final-Project\Src\Airline_Reservation\Airline_Reservation\Views\Booking\Index.cshtml"
                       Write(Html.ActionLink("Flight Selection", "Index", "Booking", new { id = item.FlightNo }, new { style = "color:gray" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>&nbsp; &gt; &nbsp;\r\n                        <h6> ");
#nullable restore
#line 37 "C:\Users\LENOVO\Documents\Final-Project\Src\Airline_Reservation\Airline_Reservation\Views\Booking\Index.cshtml"
                        Write(Html.ActionLink("Booking", "Index", "Booking", new { id = item.FlightNo }, new { style = "color:darkblue" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>&nbsp; &gt; &nbsp;\r\n                        <h6> ");
#nullable restore
#line 38 "C:\Users\LENOVO\Documents\Final-Project\Src\Airline_Reservation\Airline_Reservation\Views\Booking\Index.cshtml"
                        Write(Html.ActionLink("Payment", "Index", "Booking", new { id = item.FlightNo }, new { style = "color:gray" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                    </div>\r\n                    <hr />\r\n                </div>\r\n                <div class=\"panel panel-default m-3 p-3\">\r\n                    <div class=\"m-1 p-1\">\r\n                        <h6>");
#nullable restore
#line 44 "C:\Users\LENOVO\Documents\Final-Project\Src\Airline_Reservation\Airline_Reservation\Views\Booking\Index.cshtml"
                       Write(item.Source);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>&nbsp;-&nbsp;<h6>");
#nullable restore
#line 44 "C:\Users\LENOVO\Documents\Final-Project\Src\Airline_Reservation\Airline_Reservation\Views\Booking\Index.cshtml"
                                                         Write(item.Destination);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h6>
                        <div style=""display:inline-block;float:right;margin-top:-1rem;"">
                              <select id=""ClassID"" class=""form-control"" style=""width:15rem;"" onchange=""callChangefunc(this.value)"" >
                                  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d65be69a4924df694186317d5d00947143cee05f7105", async() => {
                WriteLiteral("Economy");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d65be69a4924df694186317d5d00947143cee05f8299", async() => {
                WriteLiteral("Bussiness");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                              </select>
                        </div>
                        <hr />

                    </div>
                    <div class=""panel-body row"">
                        <div class=""col-md-12"">
                            <img");
            BeginWriteAttribute("src", " src=\"", 2145, "\"", 2180, 1);
#nullable restore
#line 56 "C:\Users\LENOVO\Documents\Final-Project\Src\Airline_Reservation\Airline_Reservation\Views\Booking\Index.cshtml"
WriteAttributeValue("", 2151, Url.Content(@item.ImagePath), 2151, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"height:70px; width:6rem;\" />\r\n                            <div class=\"ml-4\" style=\"display:inline-block;\">\r\n                                <span>");
#nullable restore
#line 58 "C:\Users\LENOVO\Documents\Final-Project\Src\Airline_Reservation\Airline_Reservation\Views\Booking\Index.cshtml"
                                 Write(item.AirlineName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><br />\r\n                                <span>");
#nullable restore
#line 59 "C:\Users\LENOVO\Documents\Final-Project\Src\Airline_Reservation\Airline_Reservation\Views\Booking\Index.cshtml"
                                 Write(item.FlightName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                            </div>
                            <hr />
                        </div>

                        <div class=""col-md-12 row"">
                            <div class=""col-md-4"">
                                <h6>");
#nullable restore
#line 66 "C:\Users\LENOVO\Documents\Final-Project\Src\Airline_Reservation\Airline_Reservation\Views\Booking\Index.cshtml"
                               Write(item.DepartureTime.ToString("HH : mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6><br />\r\n                                <span>");
#nullable restore
#line 67 "C:\Users\LENOVO\Documents\Final-Project\Src\Airline_Reservation\Airline_Reservation\Views\Booking\Index.cshtml"
                                 Write(item.DepartureTime.ToString("ddd, dd MMM,yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><br />\r\n                                <span>");
#nullable restore
#line 68 "C:\Users\LENOVO\Documents\Final-Project\Src\Airline_Reservation\Airline_Reservation\Views\Booking\Index.cshtml"
                                 Write(item.Source);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </div>\r\n                            <div class=\"col-md-4 text-center pt-3\">\r\n                                <span>");
#nullable restore
#line 71 "C:\Users\LENOVO\Documents\Final-Project\Src\Airline_Reservation\Airline_Reservation\Views\Booking\Index.cshtml"
                                 Write(item.TravelDuration);

#line default
#line hidden
#nullable disable
            WriteLiteral(" hr</span>\r\n                            </div>\r\n                            <div class=\"col-md-4\">\r\n                                <h6 style=\"float:right\">");
#nullable restore
#line 74 "C:\Users\LENOVO\Documents\Final-Project\Src\Airline_Reservation\Airline_Reservation\Views\Booking\Index.cshtml"
                                                   Write(item.ArrivalTime.ToString("HH : mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6><br />\r\n                                <span style=\"float:right;margin-right:-3rem;\">");
#nullable restore
#line 75 "C:\Users\LENOVO\Documents\Final-Project\Src\Airline_Reservation\Airline_Reservation\Views\Booking\Index.cshtml"
                                                                         Write(item.DepartureTime.ToString("ddd, dd MMM,yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><br />\r\n                                <span style=\"float:right\">");
#nullable restore
#line 76 "C:\Users\LENOVO\Documents\Final-Project\Src\Airline_Reservation\Airline_Reservation\Views\Booking\Index.cshtml"
                                                     Write(item.Destination);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n\r\n\r\n\r\n");
            WriteLiteral(@"                <div class=""mt-4 ml-3"">
                    <h5>Traveller Details</h5>
                    <hr />
                </div>
                <div class=""panel panel-default m-3 p-3"">
                    <div class=""m-1 p-1"">
                        <h6>Passenger 1<span class=""badge-secondary m-2"" style=""padding:3px; border-radius:3px;"">Adult</span> Primary Contact </h6>
                        <hr />

                    </div>
                    <div>
                       <h5>Personal Details</h5>
                       <div class=""row mt-3"">
                           <div class=""form-group col-md-6"">
                               <label class=""control-label"">First Name</label>
                               <input  id=""Image"" class=""form-control"" />
");
            WriteLiteral("                           </div>\r\n                           <div class=\"form-group col-md-6\">\r\n                               <label class=\"control-label\">Last Name</label>\r\n                               <input id=\"Image\" class=\"form-control\" />\r\n");
            WriteLiteral("                           </div>\r\n                       </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            WriteLiteral("        <div class=\"col-md-3 mt-5 pt-4 PriceCard\" >\r\n            <h6>Book Now Before Tickets run out</h6><hr />\r\n            <div style=\"margin-top:-15px;\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 5255, "\"", 5290, 1);
#nullable restore
#line 117 "C:\Users\LENOVO\Documents\Final-Project\Src\Airline_Reservation\Airline_Reservation\Views\Booking\Index.cshtml"
WriteAttributeValue("", 5261, Url.Content(@item.ImagePath), 5261, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"height:50px; width:4.5rem; display:inline-block; margin-top:-2.5rem;\" />\r\n                <div style=\"display:inline-block\" class=\"p-3\">\r\n                    Flight<br />\r\n                    <h6>");
#nullable restore
#line 120 "C:\Users\LENOVO\Documents\Final-Project\Src\Airline_Reservation\Airline_Reservation\Views\Booking\Index.cshtml"
                   Write(item.Source.Substring(0, 3).ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>&nbsp;-&nbsp;\r\n                    <h6>");
#nullable restore
#line 121 "C:\Users\LENOVO\Documents\Final-Project\Src\Airline_Reservation\Airline_Reservation\Views\Booking\Index.cshtml"
                   Write(item.Destination.Substring(0, 3).ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6><br />\r\n                    One Way\r\n                </div>\r\n            </div>\r\n            <hr />\r\n            <div>\r\n                <h6>Fare Sumary</h6><label style=\"float:right;\">( ");
#nullable restore
#line 127 "C:\Users\LENOVO\Documents\Final-Project\Src\Airline_Reservation\Airline_Reservation\Views\Booking\Index.cshtml"
                                                             Write(item.ClassType);

#line default
#line hidden
#nullable disable
            WriteLiteral(" )</label>\r\n                <div class=\"mt-2\">Adult ( 1 traveler )</div>\r\n                <div>\r\n                    <label>Base Fare</label>\r\n                    <label class=\"leftlbl\">PKR ");
#nullable restore
#line 131 "C:\Users\LENOVO\Documents\Final-Project\Src\Airline_Reservation\Airline_Reservation\Views\Booking\Index.cshtml"
                                          Write(item.Fare.ToString("#,##,###"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                </div>\r\n                <div>\r\n                    <label>Tax</label>\r\n                    <label class=\"leftlbl\">PKR ");
#nullable restore
#line 135 "C:\Users\LENOVO\Documents\Final-Project\Src\Airline_Reservation\Airline_Reservation\Views\Booking\Index.cshtml"
                                          Write(item.Tax.ToString("#,##,###"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                </div>\r\n                <hr />\r\n                <div>\r\n                    <label>Sub Total</label>\r\n                    <label class=\"leftlbl\">PKR ");
#nullable restore
#line 140 "C:\Users\LENOVO\Documents\Final-Project\Src\Airline_Reservation\Airline_Reservation\Views\Booking\Index.cshtml"
                                          Write(item.SubTotal.ToString("#,##,###"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                </div>\r\n                <div>\r\n                    <label>Hot Deals</label>\r\n                    <label class=\"leftlbl\" style=\"color:lightseagreen\">&Theta; PKR ");
#nullable restore
#line 144 "C:\Users\LENOVO\Documents\Final-Project\Src\Airline_Reservation\Airline_Reservation\Views\Booking\Index.cshtml"
                                                                              Write(item.Discount.ToString("#,##,###"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                </div>\r\n                <div>\r\n                    <label>Convenience Charges</label>\r\n                    <label class=\"leftlbl\">+ PKR ");
#nullable restore
#line 148 "C:\Users\LENOVO\Documents\Final-Project\Src\Airline_Reservation\Airline_Reservation\Views\Booking\Index.cshtml"
                                            Write(item.ConvenienceCharge.ToString("#,##,###"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                </div>
                <div class=""mt-4 p-3"" style=""background-color: #e8f0fa; margin: -1rem; "" >
                    
                    <div>
                        <h6>You Pay </h6><label>( for 1 traveler )</label>
                        <h6><label class=""leftlbl"">PKR ");
#nullable restore
#line 154 "C:\Users\LENOVO\Documents\Final-Project\Src\Airline_Reservation\Airline_Reservation\Views\Booking\Index.cshtml"
                                                  Write(item.GrandTotal.ToString("#,##,###"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label></h6>\r\n                    </div>\r\n                    <div>\r\n                        <label style=\"color:lightseagreen\">You Save</label>\r\n                        <label class=\"leftlbl\" style=\"color:lightseagreen\">PKR ");
#nullable restore
#line 158 "C:\Users\LENOVO\Documents\Final-Project\Src\Airline_Reservation\Airline_Reservation\Views\Booking\Index.cshtml"
                                                                          Write(item.Discount.ToString("#,##,###"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                    </div>\r\n                </div>\r\n                \r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 164 "C:\Users\LENOVO\Documents\Final-Project\Src\Airline_Reservation\Airline_Reservation\Views\Booking\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
<script>
    function callChangefunc(id) {
        $.ajax({
            url: '/Booking/Index/' + id,
            type: 'GET',
            data: { ID : id },
            contentType: 'application/json; charset=utf-8',
            success: function () {
                alert(""updated"");
            }
            });
    }
</script>
 ");
            }
            );
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Bussiness_Logic_Layer.FlightsBL>> Html { get; private set; }
    }
}
#pragma warning restore 1591
