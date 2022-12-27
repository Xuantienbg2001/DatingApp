namespace API.Service
{
    internal class SigningCredentials
    {
        private SymmetricSecurityKey key;
        private object hmacSha512Signature;

        public SigningCredentials(string hmacSha512Signature)
        {
            this.hmacSha512Signature = hmacSha512Signature;
        }

        public SigningCredentials(SymmetricSecurityKey key, object hmacSha512Signature)
        {
            this.key = key;
            this.hmacSha512Signature = hmacSha512Signature;
        }
    }
}