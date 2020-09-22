
namespace Snake_mvc
{
    // enumerazione della Direzione
    public enum Direzione
    {
        Sopra,
        Sotto,
        Destra,
        Sinistra
    }

    public class Impostazioni
    {
        // attributi
        public static int Larghezza;    // grandezza x
        public static int Altezza;      // grandezza y 
        public static int Velocità;     // velocità di spostamento
        public static int Punti;        // intero che sarà sommato al punteggio
        public static int Punteggio;    // punteggio del giocatore
        public static bool Morte;       // variabile booleana per controllare l'evento muori
        public static Direzione direzione;  // enumerazione

        // costruttore
        public Impostazioni()
        {
            // inizializzazione attributi
            Larghezza = 15;
            Altezza = 15;
            Velocità = 15;
            Punteggio = 0;
            Morte = false;
            direzione = Direzione.Sotto;    // snake inizierà a muoversi verso il basso
        }
    }
}
