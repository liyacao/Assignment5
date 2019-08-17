namespace Assignment5
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class orders
    {
        public long id { get; set; }

        public short? productId { get; set; }

        public virtual products products { get; set; }
    }
}
