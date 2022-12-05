using System.ComponentModel.DataAnnotations;

namespace PeopleTest.Models
{
    public class Country
    {
        [Key]
        public int Id { get; set; }// Needs to be set in Cityclass 
        public List<City>? Cities { get; set; }//Navigation Property
        [Required]
        [MaxLength(80)]
        public string? CountryName { get; set; }
    }
}
