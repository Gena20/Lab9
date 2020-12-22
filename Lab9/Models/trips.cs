namespace Lab9.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class trips
    {
        public int id { get; set; }

        public int car_id { get; set; }

        public int object_form_id { get; set; }

        public int object_to_id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date_from { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date_to { get; set; }

        public TimeSpan? time { get; set; }

        public virtual cars cars { get; set; }

        public virtual objects objects { get; set; }

        public virtual objects objects1 { get; set; }
    }
}
