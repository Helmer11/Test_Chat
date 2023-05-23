using ChatNetCore.Interfaces;
using ChatNetCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChatNetCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChatController : Controller
    {
        private readonly IChat _chat;


        public ChatController()
        {
            _chat = new HubChat();
        }

        [HttpGet]
        [Route("api/Acceso/grupolist")]
        public IActionResult getListaGrupo()
        {
            try
            {
                var list = _chat.ListaGrupos();
                return new JsonResult(list);

            } catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/Acceso/Chat")]
        public IActionResult Mensaje(int sala, string user, string mensaje )
        {
            try
            {
                var _mensaje = _chat.MensajeEnviado(sala, user, mensaje);

                return new JsonResult(_mensaje);

            } catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }

        [HttpPost]
        [Route("api/Acceso/Group")]
        public IActionResult Grupos(string salas)
        {
            try
            {
                var grupo = _chat.AddGroup(salas);

                return new JsonResult(grupo);


            }catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
