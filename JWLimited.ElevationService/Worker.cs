using System.Diagnostics;
using System;
using System.IO;
using JWLimited.ElevationService.Service;


namespace JWLimited.ElevationService
{
    public class Worker : BackgroundService
    {

        public Worker()
        {

        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                ElevationServer.Main();
            }
        }
    }

}
