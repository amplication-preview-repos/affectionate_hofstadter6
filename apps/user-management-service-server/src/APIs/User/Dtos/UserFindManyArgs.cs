using Microsoft.AspNetCore.Mvc;
using UserManagementService.APIs.Common;
using UserManagementService.Infrastructure.Models;

namespace UserManagementService.APIs.Dtos;

[BindProperties(SupportsGet = true)]
public class UserFindManyArgs : FindManyInput<User, UserWhereInput> { }
