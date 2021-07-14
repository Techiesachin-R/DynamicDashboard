using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DynamicDashboard.Models
{
    public partial class DashboardLinkedElements
    {
        public int Id { get; set; }
        public int DashboardId { get; set; }
        public int ElementId { get; set; }
        public string Placement { get; set; }

        [ForeignKey("ElementId")]
        public virtual Elements Elements { get; set; }

        [ForeignKey("DashboardId")]
        public virtual DashboardsInfo DashboardsInfo { get; set; }
    }
}
