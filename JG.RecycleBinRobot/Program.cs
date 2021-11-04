using JG.RecycleBinRobot.Core;
using System;
using Topshelf;

namespace JG.RecycleBinRobot
{
    class Program
    {
        static void Main(string[] args)
        {
            var exitCode = HostFactory.Run(x =>
            {
                x.Service<Helper>(s =>
                {
                    s.ConstructUsing(c => new Helper());
                    s.WhenStarted(c => c.Start());
                    s.WhenStopped(c => c.Stop());
                });

                x.RunAsLocalSystem();
                x.SetServiceName(Constants.SERVICE_NAME);
                x.SetDisplayName(Constants.SERVICE_DISPLAY_NAME);
                x.SetDescription(Constants.SERVICE_DESCRIPTION);
            });

            int exitCodeValue = (int)Convert.ChangeType(exitCode, exitCode.GetTypeCode());
            Environment.ExitCode = exitCodeValue;
        }
    }
}