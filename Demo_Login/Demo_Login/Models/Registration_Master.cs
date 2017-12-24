namespace Demo_Login.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Registration_Master
    {
        public int ID { get; set; }

        [StringLength(50)]
        [Required (ErrorMessage="Enter FirstName")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Invalid FirstName")]
        public string FirstName { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Enter LastName")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Invalid LastName")]
        public string LastName { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Enter Email Address")]
        [RegularExpression(@"^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$", ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Enter Contact Number")]
        public string ContactNo { get; set; }

        [Required(ErrorMessage = "Select Role")]
        public int? Role { get; set; }
    }
}
