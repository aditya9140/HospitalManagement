#pragma checksum "C:\Users\adity\source\repos\WebApplication1\WebApplication1\Pages\Customer\EditCustomer.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ff08ab7f3f47349da8a114579b1131a8656f57b"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApplication1.Pages.Customer
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\adity\source\repos\WebApplication1\WebApplication1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\adity\source\repos\WebApplication1\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\adity\source\repos\WebApplication1\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\adity\source\repos\WebApplication1\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\adity\source\repos\WebApplication1\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\adity\source\repos\WebApplication1\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\adity\source\repos\WebApplication1\WebApplication1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\adity\source\repos\WebApplication1\WebApplication1\_Imports.razor"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\adity\source\repos\WebApplication1\WebApplication1\_Imports.razor"
using WebApplication1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\adity\source\repos\WebApplication1\WebApplication1\Pages\Customer\EditCustomer.razor"
using WebApplication1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\adity\source\repos\WebApplication1\WebApplication1\Pages\Customer\EditCustomer.razor"
using System;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EditCustomer/{CurretnID}")]
    public partial class EditCustomer : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Edit Customer</h2>\r\n<hr>\r\n");
            __builder.OpenElement(1, "form");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-md-8");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "form-group");
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.OpenElement(12, "input");
            __builder.AddAttribute(13, "for", "Id");
            __builder.AddAttribute(14, "class", "form-control");
            __builder.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "C:\Users\adity\source\repos\WebApplication1\WebApplication1\Pages\Customer\EditCustomer.razor"
                                                             objCI.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objCI.Id = __value, objCI.Id));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "form-group");
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.AddMarkupContent(22, "<label for=\"Name\" class=\"control-label\">Name</label>\r\n                ");
            __builder.OpenElement(23, "input");
            __builder.AddAttribute(24, "for", "Name");
            __builder.AddAttribute(25, "class", "form-control");
            __builder.AddAttribute(26, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\Users\adity\source\repos\WebApplication1\WebApplication1\Pages\Customer\EditCustomer.razor"
                                                               objCI.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objCI.Name = __value, objCI.Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "form-group");
            __builder.AddMarkupContent(32, "\r\n                ");
            __builder.AddMarkupContent(33, "<label for=\"Email\" class=\"control-label\">Email</label>\r\n                ");
            __builder.OpenElement(34, "input");
            __builder.AddAttribute(35, "for", "Email");
            __builder.AddAttribute(36, "class", "form-control");
            __builder.AddAttribute(37, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "C:\Users\adity\source\repos\WebApplication1\WebApplication1\Pages\Customer\EditCustomer.razor"
                                                                objCI.Email

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objCI.Email = __value, objCI.Email));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n\r\n            ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "form-group");
            __builder.AddMarkupContent(43, "\r\n                ");
            __builder.AddMarkupContent(44, "<label for=\"Age\" class=\"control-label\">Country</label>\r\n                ");
            __builder.OpenElement(45, "input");
            __builder.AddAttribute(46, "for", "Age");
            __builder.AddAttribute(47, "class", "form-control");
            __builder.AddAttribute(48, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "C:\Users\adity\source\repos\WebApplication1\WebApplication1\Pages\Customer\EditCustomer.razor"
                                                              objCI.Age

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objCI.Age = __value, objCI.Age));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n            ");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "form-group");
            __builder.AddMarkupContent(54, "\r\n                ");
            __builder.AddMarkupContent(55, "<label for=\"Salary\" class=\"control-label\">City</label>\r\n                ");
            __builder.OpenElement(56, "input");
            __builder.AddAttribute(57, "for", "Salary");
            __builder.AddAttribute(58, "class", "form-control");
            __builder.AddAttribute(59, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "C:\Users\adity\source\repos\WebApplication1\WebApplication1\Pages\Customer\EditCustomer.razor"
                                                                 objCI.Salary

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(60, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objCI.Salary = __value, objCI.Salary));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n    ");
            __builder.OpenElement(65, "div");
            __builder.AddAttribute(66, "class", "row");
            __builder.AddMarkupContent(67, "\r\n        ");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "class", "col-md-4");
            __builder.AddMarkupContent(70, "\r\n            ");
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "class", "form-group");
            __builder.AddMarkupContent(73, "\r\n                ");
            __builder.OpenElement(74, "input");
            __builder.AddAttribute(75, "type", "button");
            __builder.AddAttribute(76, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\Users\adity\source\repos\WebApplication1\WebApplication1\Pages\Customer\EditCustomer.razor"
                                                UpdateCustomer

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(77, "class", "btn btn-primary");
            __builder.AddAttribute(78, "value", "Save");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n                ");
            __builder.OpenElement(80, "input");
            __builder.AddAttribute(81, "type", "button");
            __builder.AddAttribute(82, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\adity\source\repos\WebApplication1\WebApplication1\Pages\Customer\EditCustomer.razor"
                                                Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(83, "class", "btn btn-primary");
            __builder.AddAttribute(84, "value", "Cancel");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "C:\Users\adity\source\repos\WebApplication1\WebApplication1\Pages\Customer\EditCustomer.razor"
       
    [Parameter]
    public string CurretnID { get; set; }
    CustomerInfo objCI = new CustomerInfo();

    protected override async Task OnInitializedAsync()
    {
        objCI = await Task.Run(() => ObjCustomService.GetCustomerByID(Convert.ToInt32(CurretnID)));
    }
    protected void UpdateCustomer()
    {
        ObjCustomService.UpdateCustomer(objCI);
        NavigationManager.NavigateTo("customer");
    }
    void Cancel()
    {
        NavigationManager.NavigateTo("customer");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CustomerService ObjCustomService { get; set; }
    }
}
#pragma warning restore 1591
