using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            VendingMachine m_vendingMachine = new VendingMachine(5);

            Console.WriteLine(m_vendingMachine);
            m_vendingMachine.PutCoin();
            m_vendingMachine.TwistKnob();
            Console.WriteLine(m_vendingMachine);
            m_vendingMachine.PutCoin();
            m_vendingMachine.TwistKnob();
            m_vendingMachine.PutCoin();
            m_vendingMachine.TwistKnob();
            
            Console.ReadKey();
        }
    }
}
