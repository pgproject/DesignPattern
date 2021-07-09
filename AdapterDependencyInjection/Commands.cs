using System;

namespace AdapterDependencyInjection
{
    public class SaveCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Saving a file");
        }
    }  
    
    public class OpenCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Opening a file");
        }
    }
    
    
}