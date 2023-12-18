namespace HelloToDotnet.Services
{
    public class HelloService
    {
        public string GetDateTimeString()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("hello date time");
            }
            int j = 10;
            int k = 0;
            return DateTime.Now.ToLocalTime().ToString();
        }
    }
}

namespace HelloToDotnetSOmethingElseNewNS.Services
{
	public class HelloService
    {
        public string GetDateTimeString()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("hello date time");
            }
            int j = 10;
            int k = 0;
            return DateTime.Now.ToLocalTime().ToString();
        }
    }
}
