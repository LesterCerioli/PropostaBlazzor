#pragma checksum "C:\Users\Administrator\source\repos\Blazor-Proposta-A-Blend\PropostaBlazzor.Web\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef570f3532107d8a4f9b5b48bf1d888818a27060"
// <auto-generated/>
#pragma warning disable 1591
namespace PropostaBlazzor.Web.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Administrator\source\repos\Blazor-Proposta-A-Blend\PropostaBlazzor.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\source\repos\Blazor-Proposta-A-Blend\PropostaBlazzor.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Administrator\source\repos\Blazor-Proposta-A-Blend\PropostaBlazzor.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Administrator\source\repos\Blazor-Proposta-A-Blend\PropostaBlazzor.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Administrator\source\repos\Blazor-Proposta-A-Blend\PropostaBlazzor.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Administrator\source\repos\Blazor-Proposta-A-Blend\PropostaBlazzor.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Administrator\source\repos\Blazor-Proposta-A-Blend\PropostaBlazzor.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Administrator\source\repos\Blazor-Proposta-A-Blend\PropostaBlazzor.Web\_Imports.razor"
using PropostaBlazzor.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Administrator\source\repos\Blazor-Proposta-A-Blend\PropostaBlazzor.Web\_Imports.razor"
using PropostaBlazzor.Web.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"text-center\">\r\n    <form class=\"form-signin\">\r\n        <h1 class=\"h4 mb-2 login\">Login de Acesso</h1>\r\n\r\n        <label for=\"inputEmail\" class=\"sr-only\">Email</label>\r\n        <input type=\"email\" id=\"inputEmail\" name=\"email\" placeholder=\"Informe o seu Email\" class=\"form-control mb-2\">\r\n\r\n        <label for=\"inputSenha\" class=\"sr-only\">Senha</label>\r\n        <input type=\"password\" id=\"inputSenha\" name=\"senha\" placeholder=\"Senha\" class=\"form-control mb-2\">\r\n\r\n\r\n        <button class=\"btn btn-primary btn-block mb-3\" type=\"submit\" (click)=\"entrar()\" [disabled]=\"ativar_spinner\">\r\n            <span class=\"spinner-border spinner-border-sm\" role=\"status\" aria-hidden=\"true\"></span>\r\n            Entrar\r\n        </button>\r\n\r\n        <img src=\"data:image/png;base64,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\">\r\n\r\n\r\n    </form>\r\n</div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
