using PillReminder.Core.Domain.Entities;

namespace PillReminder.Core.Application.Interfaces.Services;

public interface IUserService
{
    Task CheckIfUserExists(string email);
    Task<User> CreateUserAsync(User user);
    Task<User> GetUserByEmail(string email);
}