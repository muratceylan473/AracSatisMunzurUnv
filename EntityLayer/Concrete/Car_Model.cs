using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Car_Model
    {
        [Key]
        public int Car_Model_ID { get; set; }
        public string? Car_Model_Name { get; set; }


        public int? Create_ID { get; set; }
        public DateTime Create_Date { get; set; }
        public int? Update_ID { get; set; }
        public DateTime Update_Date { get; set; } 
        public bool IsDelete { get; set; }
        public int? IsDelete_ID { get; set; }
        public DateTime IsDelete_Date { get; set; } 
        public bool IsActive { get; set; }
    }
}
