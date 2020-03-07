namespace Logger.Core
{
    using System;
    using System.Collections.Generic;
    using Enums;
    using Layouts;
    using Factories;
    using Appenders;
    using Loggers;

    public class CommandInterpreter
    {
        private readonly List<IAppender> appenders;
        private ILogger logger;

        public CommandInterpreter()
        {
            this.appenders = new List<IAppender>();            
        }

        public void Read(string[] args)
        {
            string command = args[0];

            if (command == "Create")
            {
                CreatAppender(args);
            }
            else if (command == "Append")
            {
                this.logger = new Logger(appenders.ToArray());
                AppendMessage(args);
            }
            else if (command == "END")
            {
                PrintInfo();
            }
        }

        private void PrintInfo()
        {
            Console.WriteLine("Logger info");

            foreach (IAppender appender in appenders)
            {
                Console.WriteLine(appender);
            }
        }

        private void CreatAppender(string[] inputLine)
        {
            string appenderType = inputLine[1];
            string layoutType = inputLine[2];
            ReportLevel reportLevel = ReportLevel.Info;

            if (inputLine.Length > 3)
            {
                reportLevel = Enum.Parse<ReportLevel>(inputLine[3], true);
            }

            ILayout layout = LayoutFactory.CreateLayout(layoutType);
            IAppender appender = AppenderFactory.CreateAppender(appenderType, layout, reportLevel);

            appenders.Add(appender);
        }

        private void AppendMessage(string[] inputLine)
        {
            string loggerMethodType = inputLine[1];
            string date = inputLine[2];
            string message = inputLine[3];

            if (loggerMethodType == "INFO")
            {
                logger.Info(date, message);
            }
            else if (loggerMethodType == "WARNING")
            {
                logger.Warning(date, message);
            }
            else if (loggerMethodType == "ERROR")
            {
                logger.Error(date, message);
            }
            else if (loggerMethodType == "CRITICAL")
            {
                logger.Critical(date, message);
            }
            else if (loggerMethodType == "FATAL")
            {
                logger.Fatal(date, message);
            }
        }
    }
}
