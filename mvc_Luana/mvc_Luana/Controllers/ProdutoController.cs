using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace mvc_Luana.Controllers
{
    public class ProdutoController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }
       
        public string Welcome()
        {
            return "Olá, seja bem vindo!";
        }

        public string Contato()
        {
            return "Telefone para contato: (11) 5642-3400 \nEmail: secretaria115@sp.senai.br";
        }
    }
}