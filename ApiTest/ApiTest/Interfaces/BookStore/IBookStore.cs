using ApiTest.DTO;
using ApiTest.DTO.BookStore;
using Refit;
using CreateUserResponseDTO = ApiTest.DTO.BookStore.CreateUserResponseDTO;

namespace DefaultNamespace.BookStore;

public interface IBookStore
{
    [Post("/Account/v1/User")]
    Task<CreateUserResponseDTO> CreateUserAsync([Body] UserDTO user);

    [Post("/Account/v1/GenerateToken")]
    Task<GenerateTokenDTO> GenerateTokenAsync([Body] UserDTO user);


    [Post("/Account/v1/Login")]
    Task<LoginUserResponseDTO> LoginUserAsync([Body] UserDTO user);

    [Post("/BookStore/v1/Books")]
    Task<AddBookResponseDTO> AddBookAsync([Body] AddBookRequestDTO book,
        [Header("Authorization")] string token);

    [Get("/BookStore/v1/Books")]
    Task<BooksListDTO> GetAllBookAsync();

    [Get("/BookStore/v1/Book")]
    Task<BookDTO> GetBookByIsbnAsync([Query] string ISBN);

    [Delete("/BookStore/v1/Book")]
    Task DeleteBookByIsbnAndByUserIdAsync([Body] DeleteBookRequestDTO book,
        [Header("Authorization")] string token);
    //при успешном удалении сервер отдает 204 no content, данная модель не нужна <DeleteBookResponseDTO>

    [Get("/Account/v1/User/{UUID}")]
    Task<AddBookResponseDTO> GetUserAsync(string UUID, [Header("Authorization")] string token);
}