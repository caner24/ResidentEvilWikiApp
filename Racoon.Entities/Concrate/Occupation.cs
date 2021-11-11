using Racoon.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racoon.Entities.Concrate
{
    public class Occupation:IEntity
    {
        [Key]
        public int OccupationId { get; set; }

        public string OccupationName { get; set; }

        public byte[] Occupationİmage1 { get; set; }
        public byte[] Occupationİmage2 { get; set; }
    }
}
