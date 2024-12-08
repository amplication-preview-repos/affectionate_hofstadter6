using UserManagementService.APIs.Common;
using UserManagementService.APIs.Dtos;

namespace UserManagementService.APIs;

public interface IGuestsService
{
    /// <summary>
    /// Create one Guest
    /// </summary>
    public Task<Guest> CreateGuest(GuestCreateInput guest);

    /// <summary>
    /// Delete one Guest
    /// </summary>
    public Task DeleteGuest(GuestWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many Guests
    /// </summary>
    public Task<List<Guest>> Guests(GuestFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about Guest records
    /// </summary>
    public Task<MetadataDto> GuestsMeta(GuestFindManyArgs findManyArgs);

    /// <summary>
    /// Get one Guest
    /// </summary>
    public Task<Guest> Guest(GuestWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one Guest
    /// </summary>
    public Task UpdateGuest(GuestWhereUniqueInput uniqueId, GuestUpdateInput updateDto);
}
