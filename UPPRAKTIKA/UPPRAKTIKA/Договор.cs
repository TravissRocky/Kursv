//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UPPRAKTIKA
{
    using System;
    using System.Collections.Generic;
    
    public partial class Договор
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Договор()
        {
            this.Сотрудник = new HashSet<Сотрудник>();
            this.Счёт = new HashSet<Счёт>();
        }
    
        public int НомерДоговора { get; set; }
        public Nullable<int> КодКлиента { get; set; }
        public string МестоРаботы { get; set; }
        public Nullable<decimal> Зарплата { get; set; }
        public Nullable<int> НомерСчёта { get; set; }
    
        public virtual Клиенты Клиенты { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Сотрудник> Сотрудник { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Счёт> Счёт { get; set; }
    }
}
