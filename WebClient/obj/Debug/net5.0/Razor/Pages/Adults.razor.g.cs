#pragma checksum "D:\GitHubProjects\marker99\DNP1_Assignment3\WebClient\Pages\Adults.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "250bcc16b89c49a10f4f710f7de1b21c6267bfce"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h3>Adult list</h3>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddMarkupContent(2, "\r\n    Name Search\r\n    ");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "type", "text");
            __builder.AddAttribute(5, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 15 "D:\GitHubProjects\marker99\DNP1_Assignment3\WebClient\Pages\Adults.razor"
                                   (arg) => FilterByName(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 18 "D:\GitHubProjects\marker99\DNP1_Assignment3\WebClient\Pages\Adults.razor"
 if (_shownAdults == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(6, "<p><em>Loading...</em></p>");
#nullable restore
#line 23 "D:\GitHubProjects\marker99\DNP1_Assignment3\WebClient\Pages\Adults.razor"
}
else if (!_shownAdults.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(7, "<p><em>No Adults exist. Please add some.</em></p>");
#nullable restore
#line 29 "D:\GitHubProjects\marker99\DNP1_Assignment3\WebClient\Pages\Adults.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "table");
            __builder.AddAttribute(9, "class", "table");
            __builder.OpenElement(10, "thead");
            __builder.OpenElement(11, "tr");
            __builder.AddMarkupContent(12, "<th>Adult ID</th>\r\n            ");
            __builder.AddMarkupContent(13, "<th>First Name</th>\r\n            ");
            __builder.AddMarkupContent(14, "<th>Last Name</th>\r\n            ");
            __builder.AddMarkupContent(15, "<th>Hair Color</th>\r\n            ");
            __builder.AddMarkupContent(16, "<th>Eye Color</th>\r\n            ");
            __builder.AddMarkupContent(17, "<th>Age</th>\r\n            ");
            __builder.AddMarkupContent(18, "<th>Weight</th>\r\n            ");
            __builder.AddMarkupContent(19, "<th>Height</th>\r\n            ");
            __builder.AddMarkupContent(20, "<th>Sex</th>\r\n            ");
            __builder.AddMarkupContent(21, "<th>Job</th>\r\n            ");
            __builder.AddMarkupContent(22, "<th>Salary</th>\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(23);
            __builder.AddAttribute(24, "Policy", "SecurityLevel3");
            __builder.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(26, "<th>Delete</th>\r\n                ");
                __builder2.AddMarkupContent(27, "<th>Edit</th>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n        ");
            __builder.OpenElement(29, "tbody");
#nullable restore
#line 53 "D:\GitHubProjects\marker99\DNP1_Assignment3\WebClient\Pages\Adults.razor"
         foreach (Adult item in _shownAdults)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(30, "tr");
            __builder.OpenElement(31, "td");
#nullable restore
#line 56 "D:\GitHubProjects\marker99\DNP1_Assignment3\WebClient\Pages\Adults.razor"
__builder.AddContent(32, item.Id);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                ");
            __builder.OpenElement(34, "td");
#nullable restore
#line 57 "D:\GitHubProjects\marker99\DNP1_Assignment3\WebClient\Pages\Adults.razor"
__builder.AddContent(35, item.FirstName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                ");
            __builder.OpenElement(37, "td");
#nullable restore
#line 58 "D:\GitHubProjects\marker99\DNP1_Assignment3\WebClient\Pages\Adults.razor"
__builder.AddContent(38, item.LastName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                ");
            __builder.OpenElement(40, "td");
#nullable restore
#line 59 "D:\GitHubProjects\marker99\DNP1_Assignment3\WebClient\Pages\Adults.razor"
__builder.AddContent(41, item.HairColor);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                ");
            __builder.OpenElement(43, "td");
#nullable restore
#line 60 "D:\GitHubProjects\marker99\DNP1_Assignment3\WebClient\Pages\Adults.razor"
__builder.AddContent(44, item.EyeColor);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                ");
            __builder.OpenElement(46, "td");
#nullable restore
#line 61 "D:\GitHubProjects\marker99\DNP1_Assignment3\WebClient\Pages\Adults.razor"
__builder.AddContent(47, item.Age);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                ");
            __builder.OpenElement(49, "td");
#nullable restore
#line 62 "D:\GitHubProjects\marker99\DNP1_Assignment3\WebClient\Pages\Adults.razor"
__builder.AddContent(50, item.Weight);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                ");
            __builder.OpenElement(52, "td");
#nullable restore
#line 63 "D:\GitHubProjects\marker99\DNP1_Assignment3\WebClient\Pages\Adults.razor"
__builder.AddContent(53, item.Height);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                ");
            __builder.OpenElement(55, "td");
#nullable restore
#line 64 "D:\GitHubProjects\marker99\DNP1_Assignment3\WebClient\Pages\Adults.razor"
__builder.AddContent(56, item.Sex);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                ");
            __builder.OpenElement(58, "td");
#nullable restore
#line 65 "D:\GitHubProjects\marker99\DNP1_Assignment3\WebClient\Pages\Adults.razor"
__builder.AddContent(59, item.Job.JobTitle);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n                ");
            __builder.OpenElement(61, "td");
#nullable restore
#line 66 "D:\GitHubProjects\marker99\DNP1_Assignment3\WebClient\Pages\Adults.razor"
__builder.AddContent(62, item.Job.Salary);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(64);
            __builder.AddAttribute(65, "Policy", "SecurityLevel3");
            __builder.AddAttribute(66, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(67, "td");
                __builder2.OpenElement(68, "button");
                __builder2.AddAttribute(69, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 70 "D:\GitHubProjects\marker99\DNP1_Assignment3\WebClient\Pages\Adults.razor"
                                            () => RemovePerson(item.Id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(70, "<i class=\"oi oi-trash\" style=\"color: #ff0000\"></i>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n                    ");
                __builder2.OpenElement(72, "td");
                __builder2.OpenElement(73, "button");
                __builder2.AddAttribute(74, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 75 "D:\GitHubProjects\marker99\DNP1_Assignment3\WebClient\Pages\Adults.razor"
                                            () => EditPerson(item.Id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(75, "<i class=\"oi oi-pencil\" style=\"color: #1b6ec2\"></i>");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 82 "D:\GitHubProjects\marker99\DNP1_Assignment3\WebClient\Pages\Adults.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 85 "D:\GitHubProjects\marker99\DNP1_Assignment3\WebClient\Pages\Adults.razor"
}

#line default
#line hidden
#nullable disable
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
