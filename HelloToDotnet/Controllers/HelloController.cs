using HelloToDotnet.DTOs;
using HelloToDotnet.Services;
using Microsoft.AspNetCore.Mvc;

namespace HelloToDotnet.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloController : ControllerBase
    {
        [HttpGet("/get-hello")]
        public string GetHelloWorld()
        {
            HelloService hs = new HelloService();
            return "Hello World " + hs.GetDateTimeString();
        }

        // query string
        // premitive types
        // int, string, boolean, float, objects 🚫
        [HttpGet("/get-hello/{id}/{name}")]
        public string GetHelloWorld(string id, string name)
        {
            HelloService hs = new HelloService();
            return "Hello World " + id + " " + name + hs.GetDateTimeString();
        }

        [HttpPost("/get-hello-post")]
        public string GetHelloWorldPost([FromBody] Person person)
        {
            return "Hello World Post " + person.Name;
        }

        [HttpGet("/get-hello-list")]
        public List<string> GetHelloWorldList()
        {
            return new List<string> {
            "Hello",
            "World"
            };
        }
    }
}
