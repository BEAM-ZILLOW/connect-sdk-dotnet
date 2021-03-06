/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Token.Definitions
{
    public class TokenCard : AbstractToken
    {
        public CustomerToken Customer { get; set; } = null;

        public TokenCardData Data { get; set; } = null;
    }
}
