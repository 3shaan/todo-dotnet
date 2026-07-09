using MapsterMapper;
using Todo.Application.Contracts;
using Todo.Application.DTOs.Request;
using Todo.Domain.DomainEntities;
using Todo.Domain.RepositoryInterface;

namespace Todo.Application.Implementation;

public class UserService(IUserRepository userRepository, IMapper mapper) : IUserService
{
    public async Task<bool> CreateUserAsync(CreateUserDto userDto)
    {
        var domain = mapper.Map<UserDomain>(userDto);

        domain.Password = BCrypt.Net.BCrypt.HashPassword(domain.Password);

        await userRepository.AddAsync(domain);
        var result = await userRepository.CommitAsync();

        return result > 0;

    }
}
