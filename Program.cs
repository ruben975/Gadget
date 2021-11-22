using System;

namespace Gadget
{
    class Program
    {
        static void Main(string[] args)
        {
            GadgetMaker gadgetMaker = new GadgetMaker();

            gadgetMaker.buildComputer();
            gadgetMaker.buildTablet();
            gadgetMaker.buildTelefon();
        }
    }
}
