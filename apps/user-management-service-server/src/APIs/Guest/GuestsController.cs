using Microsoft.AspNetCore.Mvc;

namespace UserManagementService.APIs;

[ApiController()]
public class GuestsController : GuestsControllerBase
{
    public GuestsController(IGuestsService service)
        : base(service) { }
}
