namespace GiveCash
{
    public class Guy
    {
        #region Fields

        private string _name;
        private int _cash;

        #endregion

        #region Atributes

        public string Name { get => _name; set => _name = value; }
        public int Cash { get => _cash; set => _cash = value; }

        #endregion

        #region Constructor

        public Guy() { }

        public Guy(string name, int cash) { _name = name; _cash = cash; }

        #endregion

        #region Methods

        public void WriteInfo()
        {
            Console.WriteLine(Name + " ma " + Cash + " zł.");
        }


        //Do przeniesienia 
        public int GiveCash(int amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("Kwota " + amount + " nie jest poprawną kwotą!");
                return 0;
            }
            if (amount > Cash)
            {
                Console.WriteLine("Nie ma wystarczających środków aby dać ci " + amount);
                return 0;
            }
            Cash = Cash - amount;
            return amount;
        }

        public void ReceiveCash(int amount)
        {
            if (amount < 0)
                Console.WriteLine("Nie przyjmę od Ciebie długu  wysokości " + amount);
            else Cash = Cash + amount;
        }

        #endregion
    }
}
