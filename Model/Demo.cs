namespace DependencyDome.Model
{
    public class Demo : IDemoTransient, IDemoScoped, IDemoSingleton
    {
        public Guid id { get; private set; }

        public Demo()
        {
            id = Guid.NewGuid();
        }

        public Guid GetID()
        {
            return id;
        }
    }
}