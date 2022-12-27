using System;
using System.Security.Claims;

namespace API.Service
{
    internal class SecurityTokenDescriptor
    {
        public ClaimsIdentity Subject { get; set; }
        public DateTime Expires { get; set; }
        public SigningCredentials SigningCredentials { get; set; }
    }
}