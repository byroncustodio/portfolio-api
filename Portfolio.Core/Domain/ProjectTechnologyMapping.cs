using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portfolio.Core.Domain
{
    public class ProjectTechnologyMapping
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int ProjectId { get; set; }
        public int TechnologyId { get; set; }

        public virtual Project Project { get; set; }
        public virtual Technology Technology { get; set; }
    }
}