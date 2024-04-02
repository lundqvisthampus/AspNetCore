using Infrastructures.Contexts;
using Infrastructures.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructures.Services;

public class AddressManager(DataContext context)
{
    private readonly DataContext _context = context;

    public async Task<AddressModel> GetAddressAsync(string UserId)
    {
        var addressModel = await _context.Address.FirstOrDefaultAsync(x => x.UserId == UserId);
        return addressModel!;
    }

    public async Task<bool> CreateAddressAsync(AddressModel address)
    {
        _context.Address.Add(address);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> UpdateAddressAsync(AddressModel address)
    {
        var existingAddress = await _context.Address.FirstOrDefaultAsync(x => x.UserId == address.UserId);

        if (existingAddress != null)
        {
            _context.Entry(existingAddress).CurrentValues.SetValues(address);
            await _context.SaveChangesAsync();

            return true;
        }
        return false;
    }

    public async Task<bool> DeleteAddressAsync(string userId)
    {
        var existingAddress = await _context.Address.FirstOrDefaultAsync(x => x.UserId == userId);

        if (existingAddress != null)
        {
            _context.Address.Remove(existingAddress);
            await _context.SaveChangesAsync();
            return true;
        }
        return false;
    }
}
