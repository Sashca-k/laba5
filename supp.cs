namespace suspliers
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("supp")]
    public partial class supp
    {
        [StringLength(200)]
        public string ID { get; set; }

        [StringLength(200)]
        public string Adress { get; set; }

        [StringLength(200)]
        public string City { get; set; }

        [StringLength(200)]
        public string Company_Name { get; set; }

        [StringLength(200)]
        public string Contact_Name { get; set; }

        [StringLength(200)]
        public string Contact_Title { get; set; }

        [StringLength(200)]
        public string County { get; set; }

        [StringLength(200)]
        public string Fax { get; set; }

        [StringLength(200)]
        public string Home_Page { get; set; }

        [StringLength(200)]
        public string Phone { get; set; }

        [StringLength(200)]
        public string Postal_Code { get; set; }

        [StringLength(200)]
        public string Region { get; set; }
    }
}
