using System;

namespace AdapterDependencyInjection
{
    public class Button
    {
        private ICommand m_command;
        private string m_name;
        public Button(ICommand mCommand, string name)
        {
            m_command = mCommand;
            m_name = name;
        }

        public void Click()
        {
            m_command.Execute();
        }

        public void PrintMe()
        {
            Console.WriteLine($"I am a button called {m_name}");
        }
    }
}