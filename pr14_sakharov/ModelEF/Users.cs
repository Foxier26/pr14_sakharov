namespace pr14_sakharov.ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Users
    {
        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public string Login { get; set; }

        [Required]
        [StringLength(20)]
        public string Password { get; set; }

        [StringLength(50)]
        public string First_Name { get; set; }

        [Required]
        [StringLength(20)]
        public string Role_Name { get; set; }
    }
}
