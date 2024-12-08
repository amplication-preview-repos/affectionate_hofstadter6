using UserManagementService.Infrastructure;

namespace UserManagementService.APIs;

public class UsersService : UsersServiceBase
{
    public UsersService(UserManagementServiceDbContext context)
        : base(context) { }
}
