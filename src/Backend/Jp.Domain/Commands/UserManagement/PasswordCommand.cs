using System;
using Jp.Domain.Core.Commands;

namespace Jp.Domain.Commands.UserManagement
{
    public abstract class PasswordCommand : Command
    {
        public long? Id { get; protected set; }
        public string Password { get; protected set; }
        public string ConfirmPassword { get; protected set; }
        public string OldPassword { get; protected set; }
    }
}