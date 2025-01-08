namespace drtdr
{
    public class Person
    {
        private int personnr;
        private string namn;

        public Person(int p, string n)
        {
            personnr= p;
            namn= n;
        }

        public string Namn
        {
            set{ namn = value; }
            get{ return namn; }
        }
        public int Personnr
        {
            set{ Personnr = value;}
            get{ return Personnr; }
        }
    }
}