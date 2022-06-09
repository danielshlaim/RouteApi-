using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RouteApi_HomeWork.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        [Route ("{id:int:MinLength(5)}")]
        public string GetId(int id)
        {
            return "My Id Need Minimum 5 Numbers " + id;
        }
        
        [Route("{book:regex(boom|zoom)}")]
        public string Regex(string book)
        {
            return " Regex First Word " + book;
        }
    }
}
