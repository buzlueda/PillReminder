using PillReminder.Core.Application.Interfaces.Repositories.Common;
using PillReminder.Core.Application.Services.UserService.Constants;
using PillReminder.Core.Domain.Entities;
using CorePackages.Core.Application.Rules;
using CorePackages.Infrastructure.Infrastructure.CrossCuttingConcerns.Exception.Types;
using Microsoft.EntityFrameworkCore;

namespace PillReminder.Core.Application.Services.UserService.Rules;

public class UserBusinessRules(IUnitOfWork unitOfWork) : BaseBusinessRules
{
    internal async Task<User> CheckIfUserExists(Guid userId)
    {
        var user = await unitOfWork.UserRepository.GetAsync(
            predicate: u => u.Id == userId,
            include: source => source
                .Include(u => u.OperationClaim)
        );
        if(user is null) throw new BusinessException(UserConstants.UserDoesNotExist);
        return user;
    }
}