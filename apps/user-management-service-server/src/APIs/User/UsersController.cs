using Microsoft.AspNetCore.Mvc;

namespace UserManagementService.APIs;

[ApiController()]
public class UsersController : UsersControllerBase
{
    public UsersController(IUsersService service)
        : base(service) { }
}
