using Racoon.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racoon.Entities.Concrate
{
    public class Person:IEntity
    {
        [Key]
        public int PersonId { get; set; }

        public string PersonName { get; set; }

        public string Personİnfo { get; set; }

        public int OccupationId { get; set; }

        public DateTime DateOfBirth { get; set; }

        public DateTime DateOfDeath { get; set; }

        public string Sex { get; set; }
        public string Status { get; set; }

        public byte[] Personİmage { get; set; }

        public byte[] Ocuppationİmage1 { get; set; }

        public byte[] Ocuppationİmage2{ get; set; }

    }
}
