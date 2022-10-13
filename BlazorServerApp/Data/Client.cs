namespace BlazorServerApp.Data
{
    public abstract class Client
    {
        public abstract string Name { get; }
        public abstract string Description { get; }
        public long Id { get; set; }

    }
}
