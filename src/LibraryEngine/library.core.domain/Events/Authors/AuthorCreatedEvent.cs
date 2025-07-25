namespace library.core.domain.Events.Authors;
public class AuthorCreatedEvent : BaseEvent
{
  public AuthorCreatedEvent() : base(nameof(AuthorCreatedEvent))
  {
  }

  public required string AuthorFirstName { get; set; }
  public required string AuthorLastName { get; set; }
  public required int AuthorPhone { get; set; }
}