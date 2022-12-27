using Microsoft.IdentityModel.Tokens;
using System;

namespace API.Service
{
    internal class SymmetricSecurityKey
    {
        private byte[] vs;

        public SymmetricSecurityKey(byte[] vs)
        {
            this.vs = vs;
        }

        public static implicit operator SecurityKey(SymmetricSecurityKey v)
        {
            throw new NotImplementedException();
        }
    }
}