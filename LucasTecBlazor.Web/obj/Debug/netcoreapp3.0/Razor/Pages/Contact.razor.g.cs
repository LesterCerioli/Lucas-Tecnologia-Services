#pragma checksum "Z:\R4epositoriuos\Azure\LucasTecnologiaServices\LucasTecBlazor.Web\Pages\Contact.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9027bbbf26af3eebcc392281aba7bf37648b3150"
// <auto-generated/>
#pragma warning disable 1591
namespace LucasTecBlazor.Web.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "Z:\R4epositoriuos\Azure\LucasTecnologiaServices\LucasTecBlazor.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "Z:\R4epositoriuos\Azure\LucasTecnologiaServices\LucasTecBlazor.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "Z:\R4epositoriuos\Azure\LucasTecnologiaServices\LucasTecBlazor.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "Z:\R4epositoriuos\Azure\LucasTecnologiaServices\LucasTecBlazor.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "Z:\R4epositoriuos\Azure\LucasTecnologiaServices\LucasTecBlazor.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "Z:\R4epositoriuos\Azure\LucasTecnologiaServices\LucasTecBlazor.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "Z:\R4epositoriuos\Azure\LucasTecnologiaServices\LucasTecBlazor.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "Z:\R4epositoriuos\Azure\LucasTecnologiaServices\LucasTecBlazor.Web\_Imports.razor"
using LucasTecBlazor.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "Z:\R4epositoriuos\Azure\LucasTecnologiaServices\LucasTecBlazor.Web\_Imports.razor"
using LucasTecBlazor.Web.Shared;

#line default
#line hidden
#nullable disable
    public partial class Contact : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Contato</h3>\r\n\r\n\r\n\r\n");
            __builder.AddMarkupContent(1, "<style>\r\n    body {\r\n        color: white;\r\n    }\r\n</style>\r\n\r\n");
            __builder.AddMarkupContent(2, "<address>\r\n    Avenida Vicente de Carvalho, 1086 Rua \"I\" 22<br>\r\n    Rio de Janeiro, RJ- Brasil<br> 21210-630<br>\r\n    <abbr title=\"Telefone\">P:</abbr>\r\n    <p><a class=\"btn btn-primary btn-lg\">+55 21 3042-5441</a></p>\r\n</address>\r\n\r\n");
            __builder.AddMarkupContent(3, "<address>\r\n    <p><a href=\"mailto:comercial2018@lucastecnologiaservices.com.br\" class=\"btn btn-primary btn-lg\">Email/Comercial &raquo;</a></p>\r\n\r\n</address>\r\n");
            __builder.AddMarkupContent(4, @"<div class=""container"" style=""background-color: orange"">


    <h1>Envie-nos sua mensagem</h1>

    <form method=""post"" action=""/Agradecimento/Index"">
        <input type=""hidden"" name=""redirect"" value=""/Agradecimento/Index"">
        <input name=""recipient"" value=""comercial2018@lucastecnologiaservices.com.br"" type=""hidden"">
        <input name=""required"" value=""recipient,email,realname,subject,message"" type=""hidden"">
        <input type=""hidden"" name=""sort"" value=""order:recipient,email,realname,subject,message"">
        <input type=""hidden"" name=""subject"" value=""Contato"">

        Nome: <input name=""realname"" size=""25""> Email: <input name=""email"" size=""30""> <br> <br>
        Empresa: <input name=""realname"" size=""25""> Cidade/Estado: <input name=""email"" size=""30""> <br> <br>
        Assunto: <input name=""subject"" size=""30""> <br>
        Mensagem :<br> <textarea name=""message"" rows=""8"" cols=""50""> </textarea> <br>
        <input type=""submit"" value=""Envie sua mensagem"" name=""submit"">
        <input type=""reset"" value=""Limpar"" name=""reset"">
    </form>






</div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
