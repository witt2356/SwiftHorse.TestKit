namespace SwiftHorse.TestKit.Core.Domain
{
    public interface IAggregateRoot
    {
    }

    public class AggregateRoot<PKey> : IAggregateRoot
    {
        public virtual PKey Id { get; set; }
    }
}
