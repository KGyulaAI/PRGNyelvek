using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRGNyelvek
{
    public enum Nyelvcsaladok { moduláris, strukturált, funkcionális, objektumorientált };

    public class Nyelv
    {
        string neve;
        bool forditosE;
        int megjelenesEve;
        bool alacsonyszintuE;
        int nepszeruseg2022;  //
        Nyelvcsaladok nyelvcsalad;
        public Nyelv(string neve,
                     bool forditosE,
                     int megjelenesEve,
                     bool alacsonyszintuE,
                     int nepszeruseg2022,
                     Nyelvcsaladok nyelvcsalad)
        {
            this.neve = neve;
            this.forditosE = forditosE;
            this.megjelenesEve = megjelenesEve;
            this.alacsonyszintuE = alacsonyszintuE;
            this.nepszeruseg2022 = nepszeruseg2022;
            this.nyelvcsalad = nyelvcsalad;
        }
        public string Neve { get => neve; }
        public bool ForditosE { get => forditosE; }
        public int MegjelenesEve { get => megjelenesEve; }
        public bool AlacsonyszintuE { get => alacsonyszintuE; }
        public int Nepszeruseg2022 { get => nepszeruseg2022; }
        public Nyelvcsaladok Nyelvcsalad { get => nyelvcsalad; }
        public bool NepszeruE()
        {
            return this.Nepszeruseg2022 < 4;
        }

    }
}
