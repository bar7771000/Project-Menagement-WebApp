#pragma checksum "C:\Users\bar77\source\repos\EADFinalCoursework\EADFinalCoursework\Client\Pages\Project\Delete.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "656e923c4b38daedd6914b74bcc1ee6e91e4ecc8"
// <auto-generated/>
#pragma warning disable 1591
namespace EADFinalCoursework.Client.Pages.Project
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\bar77\source\repos\EADFinalCoursework\EADFinalCoursework\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bar77\source\repos\EADFinalCoursework\EADFinalCoursework\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\bar77\source\repos\EADFinalCoursework\EADFinalCoursework\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\bar77\source\repos\EADFinalCoursework\EADFinalCoursework\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\bar77\source\repos\EADFinalCoursework\EADFinalCoursework\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\bar77\source\repos\EADFinalCoursework\EADFinalCoursework\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\bar77\source\repos\EADFinalCoursework\EADFinalCoursework\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\bar77\source\repos\EADFinalCoursework\EADFinalCoursework\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\bar77\source\repos\EADFinalCoursework\EADFinalCoursework\Client\_Imports.razor"
using EADFinalCoursework.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\bar77\source\repos\EADFinalCoursework\EADFinalCoursework\Client\_Imports.razor"
using EADFinalCoursework.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\bar77\source\repos\EADFinalCoursework\EADFinalCoursework\Client\_Imports.razor"
using EADFinalCoursework.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\bar77\source\repos\EADFinalCoursework\EADFinalCoursework\Client\_Imports.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Projects/delete/{Id:guid}")]
    public partial class Delete : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style></style>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "d-flex flex-column align-items-center justify-content-around");
            __builder.AddMarkupContent(3, "<h3>Delete Project</h3>\r\n\r\n    ");
            __builder.OpenElement(4, "p");
            __builder.AddContent(5, "Name: ");
            __builder.AddContent(6, 
#nullable restore
#line 12 "C:\Users\bar77\source\repos\EADFinalCoursework\EADFinalCoursework\Client\Pages\Project\Delete.razor"
              Project.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "p");
            __builder.AddContent(9, "Description: ");
            __builder.AddContent(10, 
#nullable restore
#line 13 "C:\Users\bar77\source\repos\EADFinalCoursework\EADFinalCoursework\Client\Pages\Project\Delete.razor"
                     Project.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.OpenElement(12, "p");
            __builder.AddContent(13, "Id: ");
            __builder.AddContent(14, 
#nullable restore
#line 14 "C:\Users\bar77\source\repos\EADFinalCoursework\EADFinalCoursework\Client\Pages\Project\Delete.razor"
            Project.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n\r\n    ");
            __builder.OpenElement(16, "button");
            __builder.AddAttribute(17, "type", "button");
            __builder.AddAttribute(18, "class", "btn btn-danger w-25");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\bar77\source\repos\EADFinalCoursework\EADFinalCoursework\Client\Pages\Project\Delete.razor"
                                                                DeleteProject

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(20, "<i class=\"fas fa-save\"></i> Remove\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(22);
            __builder.AddAttribute(23, "href", "projects");
            __builder.AddAttribute(24, "class", "btn btn-info w-25");
            __builder.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(26, "Back");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "C:\Users\bar77\source\repos\EADFinalCoursework\EADFinalCoursework\Client\Pages\Project\Delete.razor"
       
    [Parameter]
    public Guid Id { get; set; }
    private Project Project { get; set; } = new Project();


    protected override async Task OnInitializedAsync()
    {
        Project = await Http.GetFromJsonAsync<Project>($"/api/Projects/{Id}");
    }

    private async void DeleteProject()
    {
        var response = await Http.DeleteAsync($"/api/Projects/{Project.Id}");
        response.EnsureSuccessStatusCode();
        Navigation.NavigateTo("/Projects");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
    }
}
#pragma warning restore 1591
