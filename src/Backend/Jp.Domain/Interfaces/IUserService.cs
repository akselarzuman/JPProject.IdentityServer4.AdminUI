using Jp.Domain.Commands.User;
using Jp.Domain.Commands.UserManagement;
using Jp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Jp.Domain.Core.ViewModels;

namespace Jp.Domain.Interfaces
{
    public interface IUserService
    {
        Task<long?> CreateUserWithPass(IDomainUser user, string password);
        Task<long?> CreateUserWithProvider(IDomainUser user, string provider, string providerUserId);
        Task<long?> CreateUserWithProviderAndPass(IDomainUser user, string password, string provider, string providerId);
        Task<bool> UsernameExist(string userName);
        Task<bool> EmailExist(string email);
        Task<User> FindByLoginAsync(string provider, string providerUserId);
        Task<long?> SendResetLink(string email, string username);
        Task<long?> ResetPassword(ResetPasswordCommand request);
        Task<long?> ConfirmEmailAsync(string email, string code);
        Task<bool> UpdateProfileAsync(UpdateProfileCommand command);
        Task<bool> UpdateProfilePictureAsync(UpdateProfilePictureCommand command);
        Task<bool> CreatePasswordAsync(SetPasswordCommand request);
        Task<bool> ChangePasswordAsync(ChangePasswordCommand request);
        Task<bool> RemoveAccountAsync(RemoveAccountCommand request);
        Task<bool> HasPassword(long userId);
        Task<IEnumerable<User>> GetByIdAsync(params string[] id);
        Task<IEnumerable<User>> GetUsers(PagingViewModel page);
        Task<User> FindByEmailAsync(string email);
        Task<User> FindByNameAsync(string username);
        Task<User> FindByProviderAsync(string provider, string providerUserId);
        Task<User> GetUserAsync(long user);
        Task UpdateUserAsync(User user);
        Task<IEnumerable<Claim>> GetClaimByName(string userName);
        Task<bool> SaveClaim(long userId, Claim claim);
        Task<bool> RemoveClaim(long userId, string claimType);
        Task<IEnumerable<string>> GetRoles(string userName);
        Task<bool> RemoveRole(long userDbId, string requestRole);
        Task<bool> SaveRole(long userId, string role);
        Task<IEnumerable<UserLogin>> GetUserLogins(string userName);
        Task<bool> RemoveLogin(long userId, string requestLoginProvider, string requestProviderKey);
        Task<IEnumerable<User>> GetUserFromRole(string[] role);
        Task<bool> RemoveUserFromRole(string name, string username);
        Task<bool> ResetPasswordAsync(string username, string password);
        Task<int> Count(string search);
        Task<long?> AddLoginAsync(string email, string provider, string providerId);
    }
}