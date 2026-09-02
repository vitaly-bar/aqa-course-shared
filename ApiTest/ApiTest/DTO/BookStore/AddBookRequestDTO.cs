namespace ApiTest.DTO.BookStore;

public class AddBookRequestDTO
{
    public string UserId { get; set; }
    public List<BookDTO> CollectionOfIsbns { get; set; }
}