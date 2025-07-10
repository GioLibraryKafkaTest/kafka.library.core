using MongoDB.Bson.Serialization.Attributes;

namespace library.core.domain.Messages;
public abstract class Message
{
  protected Message()
  {
    
  }

  [BsonId]
  public string Id { get; set; }
}