using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DynamicDashboard.Models
{
    public partial class DashboardsInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int TemplateId { get; set; }

        [ForeignKey("TemplateId")]
        public virtual Templates Templates { get; set; }
    }
}
