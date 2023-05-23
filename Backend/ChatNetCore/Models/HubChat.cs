using Microsoft.AspNetCore.SignalR;
using ChatNetCore.Interfaces;


namespace ChatNetCore.Models
{
    public class HubChat : Hub, IChat
    {

        private string[] grupos = new string[] { "Tecnologia", "Mercadeo", "Recursos Humanos", "Administracion", "Finanza", "Contabilidad" };

        public string[] Grupos { get => grupos; set => grupos = value; }

        public List<string> ListaGrupos()
        {
            return Grupos.ToList();
        }


        public async Task MensajeEnviado(int sala, string user, string mensaje)
        {
            await Clients.Group(sala.ToString()).SendAsync("RecibirMesaje", user, mensaje);

        }

        public async Task AddGroup(string salas)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, salas);
        }


    }
}
