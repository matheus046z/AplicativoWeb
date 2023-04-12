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

}

/* PESQUISAR SOBRE ENCAPSULAMENTO (O NOME É ESCONDIDO/ESCPASULADO. As classes se relacionam, )
public void SetNome(string_nome){
    nome=_nome;
}

public string GetNome(){
    return nome;
}
no C# é a automatico as propriedades de get e set



*/