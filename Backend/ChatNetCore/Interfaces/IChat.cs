namespace ChatNetCore.Interfaces
{
    public interface IChat
    {
        List<string> ListaGrupos();

        Task MensajeEnviado(int sala, string user, string mensaje);

        Task AddGroup(string salas);
    }
}
