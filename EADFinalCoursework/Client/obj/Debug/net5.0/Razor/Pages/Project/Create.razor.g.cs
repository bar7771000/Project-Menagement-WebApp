#pragma checksum "C:\Users\bar77\source\repos\EADFinalCoursework\EADFinalCoursework\Client\Pages\Project\Create.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0f7c1b17da015958df5c79eef151c3046e7d32f"
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
#nullable restore
#line 4 "C:\Users\bar77\source\repos\EADFinalCoursework\EADFinalCoursework\Client\Pages\Project\Create.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Projects/create")]
    public partial class Create : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    select{\r\n        height:40px;\r\n        width:80px;\r\n    }\r\n</style>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row mt-2 mb-5");
            __builder.OpenElement(3, "h3");
            __builder.AddAttribute(4, "class", "card-title text-info mb-3 ml-3");
            __builder.AddContent(5, 
#nullable restore
#line 16 "C:\Users\bar77\source\repos\EADFinalCoursework\EADFinalCoursework\Client\Pages\Project\Create.razor"
                                                Title

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(6, " Project");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "col-md-12");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "card");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "card-body");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(14);
            __builder.AddAttribute(15, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 20 "C:\Users\bar77\source\repos\EADFinalCoursework\EADFinalCoursework\Client\Pages\Project\Create.razor"
                                 Project

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 20 "C:\Users\bar77\source\repos\EADFinalCoursework\EADFinalCoursework\Client\Pages\Project\Create.razor"
                                                         HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(18);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\n                    ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "form-group");
                __builder2.AddMarkupContent(22, "<label>Name</label>\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(23);
                __builder2.AddAttribute(24, "class", "form-control");
                __builder2.AddAttribute(25, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "C:\Users\bar77\source\repos\EADFinalCoursework\EADFinalCoursework\Client\Pages\Project\Create.razor"
                                                Project.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Project.Name = __value, Project.Name))));
                __builder2.AddAttribute(27, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Project.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\r\n                        ");
                __Blazor.EADFinalCoursework.Client.Pages.Project.Create.TypeInference.CreateValidationMessage_0(__builder2, 29, 30, 
#nullable restore
#line 25 "C:\Users\bar77\source\repos\EADFinalCoursework\EADFinalCoursework\Client\Pages\Project\Create.razor"
                                                () => Project.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n                    ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "form-group");
                __builder2.AddMarkupContent(34, "<label>Description</label>\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(35);
                __builder2.AddAttribute(36, "class", "form-control");
                __builder2.AddAttribute(37, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 29 "C:\Users\bar77\source\repos\EADFinalCoursework\EADFinalCoursework\Client\Pages\Project\Create.razor"
                                                    Project.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Project.Description = __value, Project.Description))));
                __builder2.AddAttribute(39, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Project.Description));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n                    ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "form-group");
                __builder2.OpenElement(43, "button");
                __builder2.AddAttribute(44, "type", "submit");
                __builder2.AddAttribute(45, "class", "btn btn-primary");
                __builder2.AddContent(46, 
#nullable restore
#line 32 "C:\Users\bar77\source\repos\EADFinalCoursework\EADFinalCoursework\Client\Pages\Project\Create.razor"
                                                                       Title

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(47, " Project");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(49);
                __builder2.AddAttribute(50, "class", "btn btn-primary");
                __builder2.AddAttribute(51, "href", "projects");
                __builder2.AddAttribute(52, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(53, "Back");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
#nullable restore
#line 35 "C:\Users\bar77\source\repos\EADFinalCoursework\EADFinalCoursework\Client\Pages\Project\Create.razor"
                     if (employee != null)
                    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(54, "select");
                __builder2.AddAttribute(55, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 37 "C:\Users\bar77\source\repos\EADFinalCoursework\EADFinalCoursework\Client\Pages\Project\Create.razor"
                                       empToAdd

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(56, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => empToAdd = __value, empToAdd));
                __builder2.SetUpdatesAttributeName("value");
#nullable restore
#line 38 "C:\Users\bar77\source\repos\EADFinalCoursework\EADFinalCoursework\Client\Pages\Project\Create.razor"
                             foreach (var emp in employee)
                            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(57, "option");
                __builder2.AddAttribute(58, "value", 
#nullable restore
#line 40 "C:\Users\bar77\source\repos\EADFinalCoursework\EADFinalCoursework\Client\Pages\Project\Create.razor"
                                                emp.FrirstName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(59, 
#nullable restore
#line 40 "C:\Users\bar77\source\repos\EADFinalCoursework\EADFinalCoursework\Client\Pages\Project\Create.razor"
                                                                 emp.FrirstName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 41 "C:\Users\bar77\source\repos\EADFinalCoursework\EADFinalCoursework\Client\Pages\Project\Create.razor"
                            }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n                        ");
                __builder2.OpenElement(61, "button");
                __builder2.AddAttribute(62, "type", "button");
                __builder2.AddAttribute(63, "class", "btn btn-info");
                __builder2.AddAttribute(64, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "C:\Users\bar77\source\repos\EADFinalCoursework\EADFinalCoursework\Client\Pages\Project\Create.razor"
                                                                             AddEmployee

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(65, "Add Employee");
                __builder2.CloseElement();
#nullable restore
#line 44 "C:\Users\bar77\source\repos\EADFinalCoursework\EADFinalCoursework\Client\Pages\Project\Create.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\bar77\source\repos\EADFinalCoursework\EADFinalCoursework\Client\Pages\Project\Create.razor"
                     if (employeeList != null)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\bar77\source\repos\EADFinalCoursework\EADFinalCoursework\Client\Pages\Project\Create.razor"
                         foreach (var emp in employeeList)
                        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(66, "p");
                __builder2.AddContent(67, 
#nullable restore
#line 49 "C:\Users\bar77\source\repos\EADFinalCoursework\EADFinalCoursework\Client\Pages\Project\Create.razor"
                                emp.FrirstName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(68, " ");
                __builder2.AddContent(69, 
#nullable restore
#line 49 "C:\Users\bar77\source\repos\EADFinalCoursework\EADFinalCoursework\Client\Pages\Project\Create.razor"
                                                emp.SurName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(70, " ");
                __builder2.OpenElement(71, "button");
                __builder2.AddAttribute(72, "type", "button");
                __builder2.AddAttribute(73, "class", "btn btn-danger");
                __builder2.AddAttribute(74, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 49 "C:\Users\bar77\source\repos\EADFinalCoursework\EADFinalCoursework\Client\Pages\Project\Create.razor"
                                                                                                                    () =>employeeList.Remove(emp)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(75, "Delete");
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 50 "C:\Users\bar77\source\repos\EADFinalCoursework\EADFinalCoursework\Client\Pages\Project\Create.razor"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\bar77\source\repos\EADFinalCoursework\EADFinalCoursework\Client\Pages\Project\Create.razor"
                         
                    }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 64 "C:\Users\bar77\source\repos\EADFinalCoursework\EADFinalCoursework\Client\Pages\Project\Create.razor"
       

    private List<Employee> employeeList { get; set; } = new List<Employee>();
    private string empToAdd = "";
    [Parameter]
    public Guid Id { get; set; } = Guid.NewGuid();
    private Project Project { get; set; } = new Project();
    private Employee[] employee;
    private string Title { get; set; } = "Create";

    private async void HandleValidSubmit()
    {
        DateTime newProjectDate = DateTime.Now;
        Project.Date = newProjectDate;
        await Http.PostAsJsonAsync("/api/Projects", Project);
        Navigation.NavigateTo("/Projects");
       

    }

    private async void AddEmployee()
    {
        foreach(var emp in employee)
        {
            if(emp.FrirstName == empToAdd)
            {
                emp.ProjectId = Id;
                employeeList.Add(emp);
                var response = await Http.PutAsJsonAsync($"/api/Employees/{emp.Id}", emp);
                response.EnsureSuccessStatusCode();
            }
        }
    }
    protected override async Task OnInitializedAsync()
    {
        employee = await Http.GetFromJsonAsync<Employee[]>("/api/Employees");
        Project.Id = Id;
    }




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
    }
}
namespace __Blazor.EADFinalCoursework.Client.Pages.Project.Create
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591