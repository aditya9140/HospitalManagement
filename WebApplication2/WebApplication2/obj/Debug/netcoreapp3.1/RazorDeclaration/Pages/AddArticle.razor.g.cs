// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebApplication2.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\adity\source\repos\WebApplication2\WebApplication2\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\adity\source\repos\WebApplication2\WebApplication2\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\adity\source\repos\WebApplication2\WebApplication2\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\adity\source\repos\WebApplication2\WebApplication2\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\adity\source\repos\WebApplication2\WebApplication2\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\adity\source\repos\WebApplication2\WebApplication2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\adity\source\repos\WebApplication2\WebApplication2\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\adity\source\repos\WebApplication2\WebApplication2\_Imports.razor"
using WebApplication2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\adity\source\repos\WebApplication2\WebApplication2\_Imports.razor"
using WebApplication2.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\adity\source\repos\WebApplication2\WebApplication2\Pages\AddArticle.razor"
using WebApplication2.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/addArticle")]
    public partial class AddArticle : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "C:\Users\adity\source\repos\WebApplication2\WebApplication2\Pages\AddArticle.razor"
       

    Article article = new Article();

    protected async Task CreateArticle()
    {
        await articleManager.Create(article);
        navigationManager.NavigateTo("/articlelist");
    }

    void cancel()
    {
        navigationManager.NavigateTo("/articlelist");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Components.NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IArticleManager articleManager { get; set; }
    }
}
#pragma warning restore 1591
