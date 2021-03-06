#pragma checksum "C:\Users\Ivan\source\repos\IdleCounters\IdleCounters\Shared\Count.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "409b7eed38556879a99d1b675df90e24044a8749"
// <auto-generated/>
#pragma warning disable 1591
namespace IdleCounters.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Ivan\source\repos\IdleCounters\IdleCounters\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ivan\source\repos\IdleCounters\IdleCounters\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ivan\source\repos\IdleCounters\IdleCounters\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ivan\source\repos\IdleCounters\IdleCounters\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Ivan\source\repos\IdleCounters\IdleCounters\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Ivan\source\repos\IdleCounters\IdleCounters\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Ivan\source\repos\IdleCounters\IdleCounters\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Ivan\source\repos\IdleCounters\IdleCounters\_Imports.razor"
using IdleCounters;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Ivan\source\repos\IdleCounters\IdleCounters\_Imports.razor"
using IdleCounters.Shared;

#line default
#line hidden
#nullable disable
    public partial class Count : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 2 "C:\Users\Ivan\source\repos\IdleCounters\IdleCounters\Shared\Count.razor"
 if (Unlocked)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Current count: ");
            __builder.AddContent(3, 
#nullable restore
#line 4 "C:\Users\Ivan\source\repos\IdleCounters\IdleCounters\Shared\Count.razor"
                       CurrentCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "class", "btn btn-primary");
            __builder.AddAttribute(7, "disabled", 
#nullable restore
#line 5 "C:\Users\Ivan\source\repos\IdleCounters\IdleCounters\Shared\Count.razor"
                                              Disabled

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "C:\Users\Ivan\source\repos\IdleCounters\IdleCounters\Shared\Count.razor"
                                                                 InvokeOnBuy

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(9, 
#nullable restore
#line 5 "C:\Users\Ivan\source\repos\IdleCounters\IdleCounters\Shared\Count.razor"
                                                                               BuyButtonText()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 6 "C:\Users\Ivan\source\repos\IdleCounters\IdleCounters\Shared\Count.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(11, "    <p></p>\r\n    ");
            __builder.OpenElement(12, "button");
            __builder.AddAttribute(13, "class", "btn btn-primary");
            __builder.AddAttribute(14, "disabled", 
#nullable restore
#line 10 "C:\Users\Ivan\source\repos\IdleCounters\IdleCounters\Shared\Count.razor"
                                              Disabled

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\Ivan\source\repos\IdleCounters\IdleCounters\Shared\Count.razor"
                                                                 InvokeOnPrestige

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(16, "Prestige");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n");
#nullable restore
#line 11 "C:\Users\Ivan\source\repos\IdleCounters\IdleCounters\Shared\Count.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "C:\Users\Ivan\source\repos\IdleCounters\IdleCounters\Shared\Count.razor"
       

    [Parameter]
    public bool Unlocked { get; set; }

    [Parameter]
    public bool Disabled { get; set; }

    [Parameter]
    public bool CanPrestige { get; set; }

    [Parameter]
    public int Level { get; set; }

    [Parameter]
    public ulong CurrentCount { get; set; }

    [Parameter]
    public Action<int> OnBuy { get; set; }

    [Parameter]
    public Action<int> OnPrestige { get; set; }

    private string BuyButtonText()
    {
        if (Level == 0)
        {
            return "Create matter";
        }
        else
        {
            var tekst = "Create matter";
            for (int l = 0; l < Level; l++)
            {
                tekst += " machine";
            }
            return tekst;
        }
    }

    private void InvokeOnBuy()
    {
        OnBuy?.Invoke(Level);
    }

    private void InvokeOnPrestige()
    {
        OnPrestige?.Invoke(Level);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
