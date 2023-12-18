using HelloToDotnet.DTOs;
using HelloToDotnet.Services;
using Microsoft.AspNetCore.Mvc;

namespace HelloToDotnet.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloController : ControllerBase
    {
        private HelloService _helloService;
		private readonly ByeService _byeService;

		public HelloController(HelloService helloService, ByeService byeService)
        {
            _helloService = helloService;
			_byeService = byeService;
		}

        
        [HttpGet("/testing-deps")]
        public string TestingDeps()
        {

            _byeService.SayBye();
			return "Hello World " + _helloService.GetDateTimeString();
        }
    }
}
