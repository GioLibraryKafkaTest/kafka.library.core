namespace library.core.domain.Events.Books;
public class BookUpdatedEvent : BaseEvent
{
  public BookUpdatedEvent()
  : base(nameof(BookUpdatedEvent))
  {
  }

  public required string Title { get; set; }
  public required string Description { get; set; }
  public required DateTime CreationDate { get; set; }
}