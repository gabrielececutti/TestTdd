using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RollUp.Chain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.IOC
{
    public static class StartUp
    {
        public static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, service) =>
                {
                    service.AddSingleton<IRollUpHandler>(_ =>
                    {
                        var baseRollUpHandler = new BaseRollUpHandler();
                        return baseRollUpHandler;
                    }
                 );
                });
        }
    }
}

