using System;

namespace PSafe.Core.SharedKernel
{
    public class ApplicationUser
    {
        public virtual string Username { get; private set; }
        public virtual string Name { get; private set; }
        public virtual string EmailAddress { get; private set; }
        public virtual string PasswordHash { get; private set; }
        public virtual string PasswordSalt { get; private set; }

        public ApplicationUser Create(string username, string name, string email, string passwordHash, string passwordSalt)
        {
            var user = new ApplicationUser();
            user.Username = username;
            user.Name = name;
            user.EmailAddress = email;
            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;

            return user;
        }

    }
}
