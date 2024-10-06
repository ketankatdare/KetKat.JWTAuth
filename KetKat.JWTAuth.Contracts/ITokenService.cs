using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetKat.JWTAuth.Contracts
{
    public interface ITokenService
    {
        string GenerateAccessToken();
        string RenewAccessToken();
        bool ValidateAccessToken();
        string RenewRefreshToken();
    }
}
