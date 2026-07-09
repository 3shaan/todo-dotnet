using Mapster;
using Todo.Application.DTOs.Request;
using Todo.Domain.DomainEntities;

namespace Todo.Application.Mappers;

public class UserMappingExtension : IRegister
{


    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<CreateUserDto, UserDomain>();
    }
}
