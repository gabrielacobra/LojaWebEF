using LojaWebEF.Models;
using Microsoft.AspNetCore.Mvc;

namespace LojaWebEF.Controllers
{
    [Route("api/[controller]")]
    public class ClienteController:Controller
    {
        Cliente cliente = new Cliente();                   
        readonly ClienteContexto contexto;

        public ClienteController(ClienteContexto contexto){
            this.contexto = contexto;
        }
        
    }
}