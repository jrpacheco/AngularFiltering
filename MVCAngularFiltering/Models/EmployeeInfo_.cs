namespace MVCAngularFiltering.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmployeeInfo ")]
    public partial class EmployeeInfo_
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderId { get; set; }

        [Required]
        [StringLength(100)]
        public string CustomerName { get; set; }

        [Required]
        [StringLength(12)]
        public string CustomerMobile { get; set; }

        [Required]
        [StringLength(100)]
        public string OrderedItem { get; set; }

        public int OrderedQuantity { get; set; }

        [Required]
        [StringLength(100)]
        public string SalesAgentName { get; set; }
    }
}
