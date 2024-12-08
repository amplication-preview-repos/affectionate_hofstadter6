using UserManagementService.Infrastructure;

namespace UserManagementService.APIs;

public class GuestsService : GuestsServiceBase
{
    public GuestsService(UserManagementServiceDbContext context)
        : base(context) { }
}
