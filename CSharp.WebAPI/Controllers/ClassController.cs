using System.Web.Http;

namespace CSharp.WebAPI.Controllers
{
    public class ClassController : ApiController
    {
        [Route("api/v1/class/abstract")]
        public string AbstractClass()
        {
            return "The abstract keyword enables you to create classes and class members that are incomplete and must be implemented in a derived class.";
        }
        [Route("api/v1/class/sealed")]
        public string SealedClass()
        {
            return "The sealed keyword enables you to prevent the inheritance of a class or certain class members that were previously marked virtual.";
        }  
    }
}
