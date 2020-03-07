namespace Logger.Loggers
{
    using Appenders;
    using Enums;
    using System;

    public class Logger : ILogger
    {
        private IAppender[] appenders;

        public Logger(params IAppender[] appenders)
        {            
            this.Appenders = appenders;         
        }

        public IAppender[] Appenders
        {
            get
            {
                return this.appenders;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(Appenders), "value cannot be null");
                }

                this.appenders = value;
            }
        }

        public void Info(string dateTime, string message)
        {
            AppendMessage(dateTime, ReportLevel.Info, message);
        }

        public void Warning(string dateTime, string message)
        {
            AppendMessage(dateTime, ReportLevel.Warning, message);
        }

        public void Error(string dateTime, string message)
        {
            AppendMessage(dateTime, ReportLevel.Error, message);
        }

        public void Critical(string dateTime, string message)
        {
            AppendMessage(dateTime, ReportLevel.Critical, message);
        }        

        public void Fatal(string dateTime, string message)
        {
            AppendMessage(dateTime, ReportLevel.Fatal, message);
        }

        private void AppendMessage(string dateTime, ReportLevel reportLevel, string message)
        {
            for (int i = 0; i < this.Appenders.Length; i++)
            {
                this.Appenders[i].Append(dateTime, reportLevel, message);
            }
        }
    }
}
