using ChatNetCore.Interfaces;
using ChatNetCore.Models;

namespace PruebaUnitaria
{
    [TestClass]
    public class Mensajes
    {
        private readonly IChat _chat;

        public Mensajes()
        {
            _chat = new HubChat();
        }

        [TestMethod]
        public void ListaGrupo()
        {

            var result = _chat.ListaGrupos;

            Assert.IsNotNull(result);

        }

        [TestMethod]
        public void MensajeSend()
        {
            var mensaje = _chat.MensajeEnviado;

            Assert.IsNotNull(mensaje);

        }

        [TestMethod]
        public void AddGrupo()
        {
            var mensaje = _chat.AddGroup;

            Assert.IsNotNull(mensaje);

        }
    }
}