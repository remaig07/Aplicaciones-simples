#pragma checksum "C:\Users\Daniel\Documents\2019\Prac_BlazorCRUD\Prac_BlazorCRUD\Pages\BookDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "545ebdd8b70a5b87425f0d898f10fc3f7134d43e"
// <auto-generated/>
#pragma warning disable 1591
namespace Prac_BlazorCRUD.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Daniel\Documents\2019\Prac_BlazorCRUD\Prac_BlazorCRUD\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Daniel\Documents\2019\Prac_BlazorCRUD\Prac_BlazorCRUD\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Daniel\Documents\2019\Prac_BlazorCRUD\Prac_BlazorCRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Daniel\Documents\2019\Prac_BlazorCRUD\Prac_BlazorCRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Daniel\Documents\2019\Prac_BlazorCRUD\Prac_BlazorCRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Daniel\Documents\2019\Prac_BlazorCRUD\Prac_BlazorCRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Daniel\Documents\2019\Prac_BlazorCRUD\Prac_BlazorCRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Daniel\Documents\2019\Prac_BlazorCRUD\Prac_BlazorCRUD\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Daniel\Documents\2019\Prac_BlazorCRUD\Prac_BlazorCRUD\_Imports.razor"
using Prac_BlazorCRUD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Daniel\Documents\2019\Prac_BlazorCRUD\Prac_BlazorCRUD\_Imports.razor"
using Prac_BlazorCRUD.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Daniel\Documents\2019\Prac_BlazorCRUD\Prac_BlazorCRUD\_Imports.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Daniel\Documents\2019\Prac_BlazorCRUD\Prac_BlazorCRUD\_Imports.razor"
using Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/bookDetails")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/bookDetails/{id:int}")]
    public partial class BookDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Book Details</h3>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 8 "C:\Users\Daniel\Documents\2019\Prac_BlazorCRUD\Prac_BlazorCRUD\Pages\BookDetails.razor"
                  book

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(4, "table");
                __builder2.AddAttribute(5, "class", "table");
                __builder2.OpenElement(6, "tr");
                __builder2.AddMarkupContent(7, "<td>Title:</td>\r\n            ");
                __builder2.OpenElement(8, "td");
                __builder2.OpenElement(9, "input");
                __builder2.AddAttribute(10, "class", "form-control col-sm-4");
                __builder2.AddAttribute(11, "type", "text");
                __builder2.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "C:\Users\Daniel\Documents\2019\Prac_BlazorCRUD\Prac_BlazorCRUD\Pages\BookDetails.razor"
                                                                        book.Title

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => book.Title = __value, book.Title));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\r\n\r\n        ");
                __builder2.OpenElement(15, "tr");
                __builder2.AddMarkupContent(16, "<td>Author:</td>\r\n            ");
                __builder2.OpenElement(17, "td");
                __builder2.OpenElement(18, "input");
                __builder2.AddAttribute(19, "class", "form-control col-sm-4");
                __builder2.AddAttribute(20, "type", "text");
                __builder2.AddAttribute(21, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "C:\Users\Daniel\Documents\2019\Prac_BlazorCRUD\Prac_BlazorCRUD\Pages\BookDetails.razor"
                                                                        book.Author

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => book.Author = __value, book.Author));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n\r\n        ");
                __builder2.OpenElement(24, "tr");
                __builder2.OpenElement(25, "td");
                __builder2.OpenElement(26, "input");
                __builder2.AddAttribute(27, "type", "submit");
                __builder2.AddAttribute(28, "value", "Save");
                __builder2.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\Daniel\Documents\2019\Prac_BlazorCRUD\Prac_BlazorCRUD\Pages\BookDetails.razor"
                                                            SaveBook

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n                ");
                __builder2.OpenElement(31, "input");
                __builder2.AddAttribute(32, "type", "button");
                __builder2.AddAttribute(33, "value", "Cancel");
                __builder2.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\Daniel\Documents\2019\Prac_BlazorCRUD\Prac_BlazorCRUD\Pages\BookDetails.razor"
                                                              Cancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "C:\Users\Daniel\Documents\2019\Prac_BlazorCRUD\Prac_BlazorCRUD\Pages\BookDetails.razor"
       
    private Book book = new Book();

    protected async Task SaveBook()
    {
        await BookServiceClass.SaveBook(book);
        NavigationManager.NavigateTo("/");
    }

    protected void Cancel()
    {
        NavigationManager.NavigateTo("/");
    }

    [Parameter]
    public int id { get; set; }

    protected override async Task OnInitializedAsync()
    {
        if (id != 0)
        {
            book = await BookServiceClass.GetBookDetails(id);
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBookServiceClass BookServiceClass { get; set; }
    }
}
#pragma warning restore 1591
