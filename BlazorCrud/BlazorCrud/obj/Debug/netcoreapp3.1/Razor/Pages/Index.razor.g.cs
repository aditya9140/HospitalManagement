#pragma checksum "C:\Users\adity\source\repos\BlazorCrud\BlazorCrud\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae2904562a1707e4ae517f0adb13e899d5e67212"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorCrud.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\adity\source\repos\BlazorCrud\BlazorCrud\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\adity\source\repos\BlazorCrud\BlazorCrud\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\adity\source\repos\BlazorCrud\BlazorCrud\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\adity\source\repos\BlazorCrud\BlazorCrud\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\adity\source\repos\BlazorCrud\BlazorCrud\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\adity\source\repos\BlazorCrud\BlazorCrud\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\adity\source\repos\BlazorCrud\BlazorCrud\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\adity\source\repos\BlazorCrud\BlazorCrud\_Imports.razor"
using BlazorCrud;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\adity\source\repos\BlazorCrud\BlazorCrud\_Imports.razor"
using BlazorCrud.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\adity\source\repos\BlazorCrud\BlazorCrud\Pages\Index.razor"
using BlazorCrud.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>EF Core Blazor Example</h1>\r\n\r\n\r\n\r\n");
            __builder.OpenElement(1, "input");
            __builder.AddAttribute(2, "type", "text");
            __builder.AddAttribute(3, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "C:\Users\adity\source\repos\BlazorCrud\BlazorCrud\Pages\Index.razor"
                                 employee.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => employee.Name = __value, employee.Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n<br>\r\n<br>\r\n");
            __builder.OpenElement(6, "input");
            __builder.AddAttribute(7, "type", "text");
            __builder.AddAttribute(8, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\adity\source\repos\BlazorCrud\BlazorCrud\Pages\Index.razor"
                                 employee.City

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => employee.City = __value, employee.City));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n<br>\r\n<br>\r\n");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "type", "text");
            __builder.AddAttribute(13, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "C:\Users\adity\source\repos\BlazorCrud\BlazorCrud\Pages\Index.razor"
                                 employee.Country

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => employee.Country = __value, employee.Country));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n<br>\r\n<br>\r\n");
            __builder.OpenElement(16, "input");
            __builder.AddAttribute(17, "type", "text");
            __builder.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "C:\Users\adity\source\repos\BlazorCrud\BlazorCrud\Pages\Index.razor"
                                 employee.Age

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => employee.Age = __value, employee.Age));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n<br>\r\n<br>\r\n\r\n\r\n\r\n");
            __builder.OpenElement(21, "button");
            __builder.AddAttribute(22, "class", "btn btn-success");
            __builder.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "C:\Users\adity\source\repos\BlazorCrud\BlazorCrud\Pages\Index.razor"
                                            e=>SaveItem()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(24, "Save");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n\r\n<br>\r\n<br>\r\n\r\n");
            __builder.OpenElement(26, "table");
            __builder.AddAttribute(27, "class", "table table-striped table-bordered");
            __builder.AddMarkupContent(28, "\r\n\r\n\r\n    ");
            __builder.AddMarkupContent(29, "<thead>\r\n        <tr>\r\n            <th>Name</th>\r\n            <th>City</th>\r\n            <th>Country</th>\r\n            <th>Age</th>\r\n        </tr>\r\n    </thead>\r\n    ");
            __builder.OpenElement(30, "tbody");
            __builder.AddMarkupContent(31, "\r\n\r\n");
#nullable restore
#line 44 "C:\Users\adity\source\repos\BlazorCrud\BlazorCrud\Pages\Index.razor"
         foreach (Employee item in Employees)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(32, "            ");
            __builder.OpenElement(33, "tr");
            __builder.AddMarkupContent(34, "\r\n\r\n                ");
            __builder.OpenElement(35, "td");
            __builder.AddContent(36, 
#nullable restore
#line 48 "C:\Users\adity\source\repos\BlazorCrud\BlazorCrud\Pages\Index.razor"
                     item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                ");
            __builder.OpenElement(38, "td");
            __builder.AddContent(39, 
#nullable restore
#line 49 "C:\Users\adity\source\repos\BlazorCrud\BlazorCrud\Pages\Index.razor"
                     item.City

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                ");
            __builder.OpenElement(41, "td");
            __builder.AddContent(42, 
#nullable restore
#line 50 "C:\Users\adity\source\repos\BlazorCrud\BlazorCrud\Pages\Index.razor"
                     item.Country

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                ");
            __builder.OpenElement(44, "td");
            __builder.AddContent(45, 
#nullable restore
#line 51 "C:\Users\adity\source\repos\BlazorCrud\BlazorCrud\Pages\Index.razor"
                     item.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                ");
            __builder.OpenElement(47, "td");
            __builder.AddMarkupContent(48, "\r\n                    ");
            __builder.OpenElement(49, "button");
            __builder.AddAttribute(50, "class", "=btn btn-primary");
            __builder.AddAttribute(51, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "C:\Users\adity\source\repos\BlazorCrud\BlazorCrud\Pages\Index.razor"
                                                                 e=>SetItemValue(@item)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(52, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                    ");
            __builder.OpenElement(54, "button");
            __builder.AddAttribute(55, "class", "=btn btn-danger");
            __builder.AddAttribute(56, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 54 "C:\Users\adity\source\repos\BlazorCrud\BlazorCrud\Pages\Index.razor"
                                                                e=>DeleteItem(@item.EmployeeId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(57, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n");
#nullable restore
#line 57 "C:\Users\adity\source\repos\BlazorCrud\BlazorCrud\Pages\Index.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(61, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n\r\n\r\n\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 78 "C:\Users\adity\source\repos\BlazorCrud\BlazorCrud\Pages\Index.razor"
      

    Employee employee = new Employee();
    List<Employee> Employees = new List<Employee>();


    protected override void OnInitialized()
    {
        LoadItems();
    }



    private void LoadItems()
    {
        Employees = new List<Employee>();
        Employees = itemRepository.Gets();
    }


    private void GetItem(int itemId)
    {
        employee = itemRepository.Get(itemId);

    }

    private void DeleteItem(int itemId)
    {

        string message = itemRepository.Delete(itemId);
    }



    private void SaveItem()
    {
        if (employee.EmployeeId == 0) employee = itemRepository.Save(employee);
        else employee = itemRepository.Update(employee);
        employee = new Employee();
        LoadItems();
    }


    private void SetItemValue(Employee item)
    {
        employee = item;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BlazorCrud.IRepository.IItemRepository itemRepository { get; set; }
    }
}
#pragma warning restore 1591