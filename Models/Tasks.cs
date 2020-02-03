using System;
using System.Collections.Generic;

namespace lll.Models
{
    public partial class Tasks
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int ProjectNavigationId { get; set; }

      public virtual Project ProjectNavigation { get; set; }
    }
}
