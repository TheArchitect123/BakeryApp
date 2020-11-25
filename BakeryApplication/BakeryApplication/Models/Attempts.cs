using System;
using System.ComponentModel.DataAnnotations;
using SQLite;
namespace BakeryApplication.Models
{
    //Stores the number of attempts that the user has launched the application
    //And the data that they have entered into it
    public class Attempts
    {
        [PrimaryKey, AutoIncrement]
        public long id { get; set; }

        [Required]
        public int AttemptNumber { get; set; }
        [Required]
        public string DataEntry { get; set; }
        [Required]
        public DateTime RecordCreation { get; set; }
    }
}
