namespace library.core.domain.Events.Authors;
public class AuthorUpdatedEvent : BaseEvent
{
  public AuthorUpdatedEvent() : base(nameof(AuthorUpdatedEvent))
  {
  }

  public required string AuthorFirstName { get; set; }
  public required string AuthorLastName { get; set; }
  public required int AuthorPhone { get; set; }
}