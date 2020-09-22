
namespace Snake_mvc
{
    public class Pezzo
    {
        private int _x;
        private int _y;
        // proprietà di incapsulamento per accedere alle proprietà di lettura e scrittura di _x
        public int X    
        {
            get { return _x; }
            set { _x = value; }
        }
        // proprietà di incapsulamento per accedere alle proprietà di lettura e scrittura di _x
        public int Y 
        {
            get { return _y; }
            set { _y = value; }
        }

        // costruttore
        public Pezzo()
        {
            // inizializzazione attributi
            _x = 0;
            _y = 0;
        }
    }
}
