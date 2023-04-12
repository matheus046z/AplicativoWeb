using AplicativoWeb.Models; // camada Model
using Microsoft.AspNetCore.Mvc; // MIcrosoft
namespace AplicativoWeb.Controllers; // Definindo

public class CursoController:Controller{
public IActionResult Index(){

    Curso c1 = new Curso();
    //set
    c1.Descricao = "Primeiros Passos no ASP.NET Core"; // Está chamando o SET (Atribuir, inserir, setar)
    c1.TituloInterno = "Desenvolverdor C#";
    c1.TituloMarketing = "Crie Aplicativos Incríveis";

    //get
    ViewData["curso"] = c1;
    return View();
}

//Action
public IActionResult Create (){
    ViewData["titulo"] = "Cadastro de Cursos";
    ViewBag.DataHora = DateTime.Now;
    return View();
}

}
