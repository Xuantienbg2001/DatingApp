﻿using System;

namespace API.Service
{
    internal class JwtSecurityTokenHandler
    {
        public JwtSecurityTokenHandler()
        {
        }

        internal object CreateToken(SecurityTokenDescriptor tokenDescriptor)
        {
            throw new NotImplementedException();
        }

        internal string WriteToken(object token)
        {
            throw new NotImplementedException();
        }
    }
}