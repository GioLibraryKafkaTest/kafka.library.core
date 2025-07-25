using library.core.domain.Events;

namespace library.core.domain.Producers;
public interface IEventProducer
{
  Task ProducerAsync(string topic, BaseEvent @event);
}