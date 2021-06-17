// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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