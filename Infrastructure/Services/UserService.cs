using Infrastructure.Entities;
using Infrastructure.Factories;
using Infrastructure.Helpers;
using Infrastructure.Models;
using Infrastructure.Repositories;
using System.Diagnostics;

namespace Infrastructure.Services;

public class UserService(UserRepository repository, AddressService addressService)
{
    private readonly UserRepository _repository = repository;
    private readonly AddressService _addressService = addressService;


    public async Task<ResponseResult> CreateUserAsync(SignUpModel model)
    {
        try
        {
            var exists = await _repository.ExistsAsync(x => x.Email == model.Email);
            if (exists.StatusCode == StatusCode.EXISTS)
                return exists;
            
            var result = await _repository.CreateOneAsync(UserFactory.Create(model));
            if (result.StatusCode != StatusCode.OK)
                return result;

            return ResponseFactory.Ok("User was created");
        }
        catch (Exception ex)
        {
            return ResponseFactory.Error(ex.Message);
        }
    }


    public async Task<UserModel> SignInUserAsync(SignInModel model)
    {
        try
        {
            var result = await _repository.GetOneAsync(x => x.Email == model.Email);
            if (result.ContentResult != null)
            {
                var userEntity = new UserEntity();
                userEntity = (UserEntity)result.ContentResult;

                if (PasswordHasher.ValidateSercurePassword(model.Password, userEntity.SecurityKey, userEntity.Password))
                    return new UserModel 
                    {
                        Id = userEntity.Id,
                        FirstName = userEntity.FirstName,
                        LastName = userEntity.LastName,
                        Email = userEntity.Email
                    };
            }
            return null!;
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            return null!;
        }
    }
}
