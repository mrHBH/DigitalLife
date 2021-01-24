// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace HBHplayground.UI.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\dev\recentHostable\UI\_Imports.razor"
using System.Diagnostics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\dev\recentHostable\UI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\dev\recentHostable\UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\dev\recentHostable\UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\dev\recentHostable\UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\dev\recentHostable\UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\dev\recentHostable\UI\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\dev\recentHostable\UI\_Imports.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\dev\recentHostable\UI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\dev\recentHostable\UI\_Imports.razor"
using HBHplayground.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\dev\recentHostable\UI\_Imports.razor"
using HBHplayground.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\dev\recentHostable\UI\_Imports.razor"
using HBHplayground.UI.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\dev\recentHostable\UI\_Imports.razor"
using HBHplayground.UI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\dev\recentHostable\UI\_Imports.razor"
using HBHplayground.Abstractions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\dev\recentHostable\UI\_Imports.razor"
using Stl.Fusion;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\dev\recentHostable\UI\_Imports.razor"
using Stl.Fusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\dev\recentHostable\UI\_Imports.razor"
using Stl.Fusion.Blazor.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\dev\recentHostable\UI\_Imports.razor"
using Stl.Fusion.Bridge;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\dev\recentHostable\UI\_Imports.razor"
using Stl.Fusion.Bridge.Messages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\dev\recentHostable\UI\_Imports.razor"
using Stl.Fusion.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\dev\recentHostable\UI\_Imports.razor"
using Stl.Serialization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\dev\recentHostable\UI\_Imports.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\dev\recentHostable\UI\_Imports.razor"
using System.Text.Json.Serialization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\dev\recentHostable\UI\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\dev\recentHostable\UI\_Imports.razor"
using MudBlazor.Dialog;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "C:\dev\recentHostable\UI\Shared\MainLayout.razor"
        private bool IsDrawerOpen { get; set; } = true;
    private string customString { get; set; } = "Empty";
    private bool IsDarkTheme { get; set; }
    private MudTheme CurrentTheme => IsDarkTheme ? Themes.Dark : Themes.Default;

    private void DrawerToggle() => IsDrawerOpen = !IsDrawerOpen;
    private void ThemeToggle() => IsDarkTheme = !IsDarkTheme;
    private void ChangeBlazorMode() => Dialog.Show<BlazorModeDialog>("Change Blazor Mode"); 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDialogService Dialog { get; set; }
    }
}
#pragma warning restore 1591
