// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebClient.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\GitHubProjects\marker99\DNP1_Assignment3\WebClient\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\GitHubProjects\marker99\DNP1_Assignment3\WebClient\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\GitHubProjects\marker99\DNP1_Assignment3\WebClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\GitHubProjects\marker99\DNP1_Assignment3\WebClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\GitHubProjects\marker99\DNP1_Assignment3\WebClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\GitHubProjects\marker99\DNP1_Assignment3\WebClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\GitHubProjects\marker99\DNP1_Assignment3\WebClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\GitHubProjects\marker99\DNP1_Assignment3\WebClient\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\GitHubProjects\marker99\DNP1_Assignment3\WebClient\_Imports.razor"
using WebClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\GitHubProjects\marker99\DNP1_Assignment3\WebClient\_Imports.razor"
using WebClient.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\GitHubProjects\marker99\DNP1_Assignment3\WebClient\Pages\Adults.razor"
using global::Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\GitHubProjects\marker99\DNP1_Assignment3\WebClient\Pages\Adults.razor"
using WebClient.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Adults")]
    public partial class Adults : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 88 "D:\GitHubProjects\marker99\DNP1_Assignment3\WebClient\Pages\Adults.razor"
       
    private IList<Adult> _allAdults;
    private IList<Adult> _shownAdults;

    protected override async Task OnInitializedAsync()
    {
        _allAdults = await _personHandler.LoadAdults();
        _shownAdults = _allAdults;
        Adult a = _shownAdults.First();
    }

    private async void RemovePerson(int id)
    {
        string statusCode = await _personHandler.RemoveAdult(id);
        OnInitializedAsync();
    }


    private void FilterByName(ChangeEventArgs evt)
    {
        string name = evt.Value?.ToString();

        if (name.Length != 0)
        {
            _shownAdults = _allAdults.Where(a => a.FirstName.ToLower().Contains(name.ToLower()) || a.LastName.ToLower().Contains(name.ToLower())).ToList();
        }
        else
        {
            _shownAdults = _allAdults;
        }
    }

    private void EditPerson(int id)
    {
        _navMgr.NavigateTo($"/EditPage/{id}");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider _auth { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPersonHandler _personHandler { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navMgr { get; set; }
    }
}
#pragma warning restore 1591
