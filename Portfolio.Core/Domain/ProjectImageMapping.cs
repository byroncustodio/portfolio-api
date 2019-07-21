using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portfolio.Core.Domain
{
    public class ProjectImageMapping
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int ProjectId { get; set; }
        public int ImageId { get; set; }

        public virtual Project Project { get; set; }
        public virtual Image Image { get; set; }
    }
}