using System.ComponentModel.DataAnnotations;

namespace MVCApp.Models
{
    public class Villa
    {
        [Key] // data annotation key
        public int Id { get; set; }
        public string? Name { get; set; } // what ? means?
        public double Price { get; set; }

        public ICollection<VillaAmenity> VillaAmenity { get; set; } // one to many relation

    }

}
