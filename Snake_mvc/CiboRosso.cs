using System.Drawing;

namespace Snake_mvc
{
    // classe erede di Cibo
    class CiboRosso : Cibo
    {
        // costruttore di CiboRosso con riferimento alla base
        public CiboRosso(CampoGioco view) : base(view)
        {
        }
        // metodo sovrascritto presente in Cibo
        public override void DisegnaCibo(Graphics gioco)
        {
            // rettangolo rappresentante il cibo con le varie proprietà
            gioco.FillRectangle(Brushes.Red,
                       new Rectangle(PezzoDiCibo.X * Impostazioni.Larghezza,
                                     PezzoDiCibo.Y * Impostazioni.Altezza,
                                     Impostazioni.Larghezza, Impostazioni.Altezza));
            // l'oggetto CiboRosso è associato a 200 punti
            Impostazioni.Punti = 200;

        }
    }
}
