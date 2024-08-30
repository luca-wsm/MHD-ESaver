using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;

namespace MHD_ESaver.Password
{
    public class PasswordService
    {
       public String HashPassword(String password)
        {
            return Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: Convert.FromBase64String(PasswordConstants.PASSWORD_HASHED_SALT),
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 100000,
                numBytesRequested: 256 / 8));
        }
    }
}
