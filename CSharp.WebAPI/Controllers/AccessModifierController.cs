using System.Web.Http;

namespace CSharp.WebAPI.Controllers
{
    public class AccessModifierController : ApiController
    {
        [Route("api/v1/access-modifier/public")]
        public string PublicAccessModifier()
        {
            return "Access is not restricted.";
        }
        [Route("api/v1/access-modifier/protected")]
        public string ProtectedAccessModifier()
        {
            return "Access is limited to the containing class or types derived from the containing class.";
        }
        [Route("api/v1/access-modifier/internal")]
        public string InternalAccessModifier()
        {
            return "Access is limited to the current assembly.";
        }
        [Route("api/v1/access-modifier/protected-internal")]
        public string ProtectedInternalAccessModifier()
        {
            return "Access is limited to the current assembly or types derived from the containing class.";
        }
        [Route("api/v1/access-modifier/private")]
        public string PrivateAccessModifier()
        {
            return "Access is limited to the containing type.";
        }        
    }
}
