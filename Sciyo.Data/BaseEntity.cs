using System;

namespace Sciyo.Data
{
    public class BaseEntity
    {
        public Int64 Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public string CreatedBy { get; set; }

        public DateTime UpdatedAt { get; set; }

        public string UpdatedBy { get; set; }

        public bool Status { get; set; } = true;
    }
}
