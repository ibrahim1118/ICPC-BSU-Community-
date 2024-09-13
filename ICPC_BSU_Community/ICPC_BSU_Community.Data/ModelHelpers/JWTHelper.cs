

namespace ICPC_BSU_Community.Data.ModelHelpers
{
    public class JWTHelper
    {
        public string Key { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public int DurationInDays { get; set; }
    }

}
