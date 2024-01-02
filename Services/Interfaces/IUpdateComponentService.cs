namespace B.Services.Interfaces
{
    public interface IUpdateComponentService
    {
        event Action UpdateRequested;
        void RequestUpdate();
    }
}
