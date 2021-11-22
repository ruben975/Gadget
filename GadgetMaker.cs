using System;

namespace Gadget
{

    public class GadgetMaker
    {
        private Gadget telefon;
        private Gadget tablet;
        private Gadget computer;

        public GadgetMaker()
        {
            telefon = new Telefon();
            tablet = new Tablet();
            computer = new Computer();
        }

        public void buildTelefon()
        {
            telefon.build();
        }
        public void buildTablet()
        {
            tablet.build();
        }
        public void buildComputer()
        {
            computer.build();
        }
    }
}