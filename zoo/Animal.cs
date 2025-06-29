using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoo
{
    [Table("animal", Schema = "pm_11")]
    public class Animal
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("number")]
        public int Number { get; set; }

        [Column("arrival_date")]
        public DateTime ArrivalDate { get; set; }

        [Column("species_id")]
        public int SpeciesId { get; set; }

        [ForeignKey("SpeciesId")]
        public Species Species { get; set; }

        [Column("caretaker_id")]
        public int CaretakerId { get; set; }

        [ForeignKey("CaretakerId")]
        public Employee Caretaker { get; set; }

        [Column("enclosure_id")]
        public int EnclosureId { get; set; }

        [ForeignKey("EnclosureId")]
        public Enclosure Enclosure { get; set; }
    }

    [Table("species", Schema = "pm_11")]
    public class Species
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        public ICollection<Animal> Animals { get; set; }
    }

    [Table("employee", Schema = "pm_11")]
    public class Employee
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("full_name")]
        public string FullName { get; set; }

        public ICollection<Animal> Animals { get; set; }
    }

    [Table("enclosure", Schema = "pm_11")]
    public class Enclosure
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        public ICollection<Animal> Animals { get; set; }
    }
}