using System;
using System.ComponentModel.DataAnnotations;
using SQLite;

namespace BakeryApplication.Models
{
    public class Produce
    {
        [PrimaryKey, AutoIncrement]
        public long id { get; set; }

        [Required]
        public string NameOfProduct { get; set; }
        [Required]
        public string CostOfEach { get; set; }

        [Required]
        public DateTime RecordCreation { get; set; }
    }
}
