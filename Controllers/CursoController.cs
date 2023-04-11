using AplicativoWeb.Models; // camada Model
using Microsoft.AspNetCore.Mvc; // MIcrosoft
namespace AplicativoWeb.Controllers; // Definindo

public class CursoController:Controller{

/*
    Ações ou Actions
    Objetivo: redirecionar para as páginas
    View

*/
/*
Interface = Interface Gráfica

*/

public IActionResult Index(){

    Curso c1 = new Curso();
    //set
    c1.Descricao = "Primeiros Passos no ASP.NET Core"; // Está chamando o SET (Atribuir, inserir, setar)
    c1.TituloInterno = "Desenvolverdor C#";
    c1.TituloMarketing = "Crie Aplicativos Incríveis";

    //get
    ViewData["desc"] = c1.Descricao;
    ViewData["titInt"] = c1.TituloInterno;
    ViewData["titMark"] = c1.TituloMarketing;
    return View();
}

}