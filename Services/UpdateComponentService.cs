namespace B.Services
{
    public class UpdateComponentService : IUpdateComponentService
    {
        public event Action UpdateRequested;

        public void RequestUpdate() => UpdateRequested?.Invoke();

    }
}
