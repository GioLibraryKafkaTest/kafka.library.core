namespace library.core.domain.Events.Books;
public class BookCreatedEvent : BaseEvent
{
  public BookCreatedEvent()
  : base(nameof(BookCreatedEvent))
  {
  }

  public required string Title { get; set; }
  public required string Description { get; set; }
  public required DateTime CreationDate { get; set; }
}