using KetKat.JWTAuth.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetKat.JWTAuth.Services
{
    public class TokenService : ITokenService
    {
        public string GenerateAccessToken()
        {
            throw new NotImplementedException();
        }

        public string RenewAccessToken()
        {
            throw new NotImplementedException();
        }

        public string RenewRefreshToken()
        {
            throw new NotImplementedException();
        }

        public bool ValidateAccessToken()
        {
            throw new NotImplementedException();
        }
    }
}
