using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crud.Model
{
    public class TokenResponseDto
    {
        public string accessToken { get; set; }
        public string refreshToken { get; set; }
        public string tokenType { get; set; }

        public TokenResponseDto Builder()
        {
            return new TokenResponseDto();
        }

        public TokenResponseDto AccessToken(string accessToken)
        {
            this.accessToken = accessToken;
            return this;
        }

        public TokenResponseDto RefreshToken(string refreshToken)
        {
            this.refreshToken = refreshToken;
            return this;
        }

        public TokenResponseDto TokenType(string tokenType)
        {
            this.tokenType = tokenType;
            return this;
        }

        public TokenResponseDto Build()
        {
            return this;
        }
    }
}
