using System;

namespace IronNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet buffet = new Buffet();
            SweetTooth st = new SweetTooth();
            SpiceHound sh = new SpiceHound();

            while(!st.IsFull)
            {
                st.Consume(buffet.Serve());
            }
            st.Consume(buffet.Serve());

            while(!sh.IsFull)
            {
                sh.Consume(buffet.Serve());
            }
            sh.Consume(buffet.Serve());

            if(st.ConsumptionHistory.Count > sh.ConsumptionHistory.Count)
            {
                Console.WriteLine($"SweetTooth consumed more with {st.ConsumptionHistory.Count} items");
            }
            else if(st.ConsumptionHistory.Count < sh.ConsumptionHistory.Count)
            {
                Console.WriteLine($"SpiceHound consumed more with {sh.ConsumptionHistory.Count} items");
            }
            else
            {
                Console.WriteLine($"SweetTooth and SpiceHound both consumed {st.ConsumptionHistory.Count} items");
            }
        }
    }
}
