namespace HelloToDotnet.Services
{
	public class ByeService
	{
		private readonly HelloService _helloService;

		public ByeService(HelloService helloService)
		{
			_helloService = helloService;
		}

		public string SayBye()
		{
			return "Bye " + _helloService.GetDateTimeString();
		}

	}
}
