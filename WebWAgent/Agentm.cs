
namespace WebWAgent
{
    public class Agentm
    {
        public static void Main(string[] args)
        {
            var builder = Host.CreateApplicationBuilder(args);
            builder.Services.AddHostedService<wk>();

            var host = builder.Build();
            host.Run();
        }
    }
}
