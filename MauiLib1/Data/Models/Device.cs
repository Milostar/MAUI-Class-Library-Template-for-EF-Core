using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiLib1.Data.Models
{
    public class Device
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string IpAddress { get; set; }
        public string Process { get; set; }
        public string Operator { get; set; }
        public bool Enabled { get; set; }
    }
}
