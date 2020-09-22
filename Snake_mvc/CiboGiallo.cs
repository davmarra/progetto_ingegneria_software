using System.Drawing;

namespace Snake_mvc
{
    // classe erede di Cibo
    class CiboGiallo : Cibo
    {
        // costruttore con riferimento alla base
        public CiboGiallo(CampoGioco view) : base(view)
        {
        }
        // metodo sovrascritto presente in Cibo
        public override void DisegnaCibo(Graphics gioco)
        {
            // rettangolo rappresentante il cibo con le varie proprietà
            gioco.FillRectangle(Brushes.Gold,
                       new Rectangle(PezzoDiCibo.X * Impostazioni.Larghezza,
                                     PezzoDiCibo.Y * Impostazioni.Altezza,
                                     Impostazioni.Larghezza, Impostazioni.Altezza));
            // l'oggetto CiboGiallo è associato a 100 punti
            Impostazioni.Punti = 100;
        }
    }
}
