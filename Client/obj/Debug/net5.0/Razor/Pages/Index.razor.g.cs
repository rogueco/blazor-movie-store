#pragma checksum "/home/tfletcher/Git/Development/ASP.NET/BlazorMovieStore/BlazorMovieStore/Client/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f86f0d32b84e1223b70be790d425a2423b004afb"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorMovieStore.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/tfletcher/Git/Development/ASP.NET/BlazorMovieStore/BlazorMovieStore/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/tfletcher/Git/Development/ASP.NET/BlazorMovieStore/BlazorMovieStore/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/tfletcher/Git/Development/ASP.NET/BlazorMovieStore/BlazorMovieStore/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/tfletcher/Git/Development/ASP.NET/BlazorMovieStore/BlazorMovieStore/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/tfletcher/Git/Development/ASP.NET/BlazorMovieStore/BlazorMovieStore/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/tfletcher/Git/Development/ASP.NET/BlazorMovieStore/BlazorMovieStore/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/tfletcher/Git/Development/ASP.NET/BlazorMovieStore/BlazorMovieStore/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/tfletcher/Git/Development/ASP.NET/BlazorMovieStore/BlazorMovieStore/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/tfletcher/Git/Development/ASP.NET/BlazorMovieStore/BlazorMovieStore/Client/_Imports.razor"
using BlazorMovieStore.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/tfletcher/Git/Development/ASP.NET/BlazorMovieStore/BlazorMovieStore/Client/_Imports.razor"
using BlazorMovieStore.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/home/tfletcher/Git/Development/ASP.NET/BlazorMovieStore/BlazorMovieStore/Client/_Imports.razor"
using BlazorMovieStore.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/home/tfletcher/Git/Development/ASP.NET/BlazorMovieStore/BlazorMovieStore/Client/_Imports.razor"
using BlazorMovieStore.Shared.Entities;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddMarkupContent(1, "<h3>Movies</h3>\r\n    ");
            __builder.OpenComponent<BlazorMovieStore.Client.Shared.MovieList>(2);
            __builder.AddAttribute(3, "Movies", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<BlazorMovieStore.Shared.Entities.Movie>>(
#nullable restore
#line 5 "/home/tfletcher/Git/Development/ASP.NET/BlazorMovieStore/BlazorMovieStore/Client/Pages/Index.razor"
                       _movies

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenElement(5, "div");
            __builder.AddMarkupContent(6, "<h2>Create a Movie</h2>\r\n    ");
            __builder.OpenComponent<BlazorMovieStore.Client.Shared.DummyTextbox>(7);
            __builder.AddAttribute(8, "placeholder", "movie name");
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "/home/tfletcher/Git/Development/ASP.NET/BlazorMovieStore/BlazorMovieStore/Client/Pages/Index.razor"
 
    private List<Movie> _movies;

    protected override void OnInitialized()
    {
        _movies = new List<Movie>()
        {
            new Movie
            {
                Title = "Spider-Man: Far From Home",
                ReleaseDate = new DateTime(2017, 7, 2)
            },
            new Movie
            {
                Title = "Moana",
                ReleaseDate = new DateTime(2016, 11, 23)
            },
            new Movie
            {
                Title = "Inception",
                ReleaseDate = new DateTime(2010, 7, 16)
            }
        };
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591