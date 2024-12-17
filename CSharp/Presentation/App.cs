using Microsoft.Extensions.Hosting;
using System.Threading;
using System.Threading.Tasks;

namespace LeetCode.Presentation
{
    public class App : IHostedService
    {
        public Task StartAsync(CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
