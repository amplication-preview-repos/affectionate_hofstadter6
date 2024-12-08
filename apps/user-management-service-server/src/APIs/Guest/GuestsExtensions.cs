using UserManagementService.APIs.Dtos;
using UserManagementService.Infrastructure.Models;

namespace UserManagementService.APIs.Extensions;

public static class GuestsExtensions
{
    public static Guest ToDto(this GuestDbModel model)
    {
        return new Guest
        {
            Address = model.Address,
            BirthDate = model.BirthDate,
            CreatedAt = model.CreatedAt,
            Email = model.Email,
            FullName = model.FullName,
            Id = model.Id,
            PassportSeries = model.PassportSeries,
            PhoneNumber = model.PhoneNumber,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static GuestDbModel ToModel(
        this GuestUpdateInput updateDto,
        GuestWhereUniqueInput uniqueId
    )
    {
        var guest = new GuestDbModel
        {
            Id = uniqueId.Id,
            Address = updateDto.Address,
            BirthDate = updateDto.BirthDate,
            Email = updateDto.Email,
            FullName = updateDto.FullName,
            PassportSeries = updateDto.PassportSeries,
            PhoneNumber = updateDto.PhoneNumber
        };

        if (updateDto.CreatedAt != null)
        {
            guest.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            guest.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return guest;
    }
}
