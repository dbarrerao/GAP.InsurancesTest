using System;
using System.Collections.Generic;
using System.Text;

namespace GAP.Models
{
    public class Insurance
    {
        public int InsuranceId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public int Period { get; set; }
        public long Price { get; set; }
        public int CoveringTypeId { get; set; }
        public CoveringType CoveringType { get; set; }
        public int RyskTypeId { get; set; }
        public RyskType RyskType { get; set; }

    }
}
