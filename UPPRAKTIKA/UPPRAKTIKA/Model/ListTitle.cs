using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPPRAKTIKA.Model
{
    
        public class ListTitle : ObservableCollection<Должность>
        {
            public static Dohod_Kl_Ist202_VavilonskyEntities1 DataEntitiesTitle { get; set; }
            public ListTitle()
            {
                DataEntitiesTitle = new Dohod_Kl_Ist202_VavilonskyEntities1();
                var titles = DataEntitiesTitle.Должность;
                var queryTitle = from title in titles select title;
                foreach (Должность titl in queryTitle)
                {
                    this.Add(titl);
                }
            }
        }
    
}
