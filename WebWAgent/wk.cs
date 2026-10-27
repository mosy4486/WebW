using WebWC;

namespace WebWAgent
{
    public class wk : BackgroundService
    {
        private WebWatcher watcher = new WebWatcher();
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                var result = await watcher.GetWebDataAsync(stoppingToken);
                if (!result.success)
                {
                    continue;
                }

                WebDataStruct ws = result.data;

            }


        }
    }
}
