using System;
using System.Collections.Generic;

namespace lll.Models
{
    public partial class Project
    {
        public Project()
        {
            Tasks = new HashSet<Tasks>();
        }

        public int Id { get; set; }
        public string Title { get; set; }

        public virtual ICollection<Tasks> Tasks { get; set; }
    }
}
