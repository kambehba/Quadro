#pragma checksum "C:\Users\Kam\Documents\GitHub\Quadro\Quadro\Quadro\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d2119e93676e0fd9381316c10e3c7167cbaa23c"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Quadro.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Kam\Documents\GitHub\Quadro\Quadro\Quadro\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kam\Documents\GitHub\Quadro\Quadro\Quadro\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Kam\Documents\GitHub\Quadro\Quadro\Quadro\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Kam\Documents\GitHub\Quadro\Quadro\Quadro\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Kam\Documents\GitHub\Quadro\Quadro\Quadro\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Kam\Documents\GitHub\Quadro\Quadro\Quadro\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Kam\Documents\GitHub\Quadro\Quadro\Quadro\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Kam\Documents\GitHub\Quadro\Quadro\Quadro\_Imports.razor"
using Quadro;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Kam\Documents\GitHub\Quadro\Quadro\Quadro\_Imports.razor"
using Quadro.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "C:\Users\Kam\Documents\GitHub\Quadro\Quadro\Quadro\Pages\Index.razor"
 
    private int a = 0;
    private int b = 0;
    private int c = 0;

    private double x1=0;
    private double x2=0;
    
    private void Solve()
    {
       
        x1 = (b * -1 + Math.Sqrt(Math.Pow(b,2) - 4 * a * c)) / (2*a);

        x2 = (b * -1 - Math.Sqrt(Math.Pow(b,2) - 4 * a * c)) / (2*a);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
