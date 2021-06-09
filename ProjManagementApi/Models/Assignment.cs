using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjManagementApi.Models
{
    public class Assignment
    {
        public int Id { get; set; }

        //foreign keys
        public int DeveloperId { get; set; }
        public virtual Developer Developer { get; set; }
        public int ProjectId { get; set; }
        public virtual Project Project { get; set; }
        //end fk
    }
}
