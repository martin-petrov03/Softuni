namespace Logger.Core
{
    using System;    

    public class Engine
    {
        private readonly CommandInterpreter commandInterpreter;

        public Engine(CommandInterpreter commandInterpreter)
        {
            this.commandInterpreter = commandInterpreter;
        }

        public void Run()
        {            
            string input = Console.ReadLine();

            while (true)
            {
                try
                {
                    string[] inputLine = input.Split(' ');

                    commandInterpreter.Read(inputLine);

                    if (input == "END")
                    {
                        break;
                    }

                    input = Console.ReadLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);                    
                }
            }
        }
    }
}
