using MapsterMapper;
using Todo.Domain.DomainEntities;
using Todo.Domain.RepositoryInterface;
using Todo.Infra.Persistance.Entities;

namespace Todo.Infra.Repository;

public class UserRepository(TodoDbContext dbContext, IMapper mapper) : GenericRepository<UserDomain, User>(dbContext, mapper), IUserRepository
{
}
