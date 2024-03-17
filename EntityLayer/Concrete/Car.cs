using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Car
    {
        [Key]
        public int Car_ID { get; set; }
        public int Car_Type_ID { get; set; } //suv
        public int Car_Marka_ID { get; set; } //bmw
        public int Car_Class_ID { get; set; } //x1
        public int Car_Model_ID { get; set; }//2020




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
 