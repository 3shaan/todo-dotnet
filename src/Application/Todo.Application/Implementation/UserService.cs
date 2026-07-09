using Todo.Application.Contracts;
using Todo.Application.DTOs.Request;

namespace Todo.Application.Implementation;

public class UserService : IUserService
{
    public Task<bool> CreateUserAsync(CreateUserDto userDto)
    {
        throw new NotImplementedException();
    }
}
