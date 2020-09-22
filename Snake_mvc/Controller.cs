using System.Collections.Generic;
using System.Windows.Forms;

namespace Snake_mvc
{
    // classe controller per gli input dati dall'utente
    class Controller
    {

        private static Dictionary<Keys, bool> ChiaviTastiera = new Dictionary<Keys, bool>();

        public static void SetTasto(Keys key, bool TastoPremuto)
        {
            ChiaviTastiera[key] = TastoPremuto;
        }

        public static bool TastoPremuto(Keys tasto)
        {
            bool StatoTasto;
            if (ChiaviTastiera.TryGetValue(tasto, out StatoTasto))
            {
                return StatoTasto;
            }
            return false;
        }    
    }
}
