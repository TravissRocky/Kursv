using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPPRAKTIKA.DB
{
    class DBCon
    {
        public static Dohod_Kl_Ist202_VavilonskyEntities1 db = new Dohod_Kl_Ist202_VavilonskyEntities1();

        public static Log ThisUser { get; set; } = new Log();

        
    }
}
