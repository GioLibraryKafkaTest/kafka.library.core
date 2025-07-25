namespace library.core.domain.Consumers;
public interface IEventConsumer
{
  void Consume(string topic);
}