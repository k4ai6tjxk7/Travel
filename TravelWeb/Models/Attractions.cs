//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace TravelWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    public partial class Attractions
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Attractions()
        {
            this.AttractionsImg = new HashSet<AttractionsImg>();
        }
    
        public string id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Particpation { get; set; }
        public string CityName { get; set; }
        public string Location { get; set; }
        public string Add { get; set; }
        public string Tel { get; set; }
        public string Org { get; set; }
        public System.DateTime Startdate { get; set; }
        public System.DateTime Enddate { get; set; }
        public string Charge { get; set; }
        public string Cycle { get; set; }
        public string Noncycle { get; set; }
        public string Website { get; set; }
        public float Px { get; set; }
        public float Py { get; set; }
        public int Class1 { get; set; }
        public int Class2 { get; set; }
        public string Travellinginfo { get; set; }
        public string Parkinginfo { get; set; }
        public System.DateTime Createdate { get; set; }
        public string CreateName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AttractionsImg> AttractionsImg { get; set; }

    }
}
