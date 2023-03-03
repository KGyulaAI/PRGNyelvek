using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PRGNyelvek
{
    public enum Nyelvcsaladok { moduláris, strukturált, funkcionális, objektumorientált };
    public class Nyelv
    {
        string neve;
        bool forditosE;
        Nyelvcsaladok nyelvcsalad;
        int megjelenesEve;
        bool alacsonyszintuE;
        int nepszeruseg2022;

        public Nyelv(bool forditosE, Nyelvcsaladok nyelvcsalad)
        {
            this.forditosE = forditosE;
            this.nyelvcsalad = nyelvcsalad;
        }

        public bool ForditosE { get => forditosE; }
        public Nyelvcsaladok Nyelvcsalad { get => nyelvcsalad; set => nyelvcsalad = value; }


        /// <summary>
        ///
        /// </summary>
        /// <returns>Ha a legnépszerűbb 3-ba tartozik</returns>
        public bool NepszeruE()
        {
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>Az elmúlt 5 évben megjelent nyelvek</returns>
        public List<Nyelv> UjNyelvek()
        {
            return new List<Nyelv> { };
        }
    }
}
