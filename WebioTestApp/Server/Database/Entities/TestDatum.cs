using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebioTestApp.Server.Database.Entities
{
    public partial class TestDatum
    {
        [Key]
        public int TestDataId { get; set; }
        [StringLength(500)]
        public string TestDataName { get; set; } = null!;
        public DateTime TestDataDate { get; set; }
    }
}
