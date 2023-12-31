namespace B.Services
{
    public interface IUpdateComponentService
    {
        event Action UpdateRequested;
        void RequestUpdate();
    }
}
