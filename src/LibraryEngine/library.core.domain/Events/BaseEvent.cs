using library.core.domain.Messages;

namespace library.core.domain.Events;
public abstract class BaseEvent(string type) : Message
{
  public int Version { get; set; }
  public string Type { get; set; } = type;
}