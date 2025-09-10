namespace library.core.domain._Constants;
public static class KafkaConnection
{
  public const string Kafka_HostName = "localhost";
  public const string Kafka_Port = "29092";
  public const string Author_Topic = "AUTHOR_TOPIC";
  public const string Book_Topic = "BOOK_TOPIC";

  public static readonly string[] Author_Topics = { Author_Topic, Book_Topic };
  public static readonly string[] Book_Topics = { Book_Topic, Author_Topic };
}