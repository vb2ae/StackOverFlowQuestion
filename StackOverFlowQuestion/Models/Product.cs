using System;
using System.Collections.Generic;
using System.Text;

namespace StackOverFlowQuestion.Models
{
    public class ProductModel 
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public ProductTypeModel ProductType { get; set; }
        public string ProductLotNumber { get; set; }
        public int CropYear { get; set; }
        public string ProductNote { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }

    }

    public class ProductTypeModel
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string ProductName { get; set; }
        public bool IsAseptic { get; set; }
        public bool IsPuree { get; set; }
        public bool IsPureeConcentrate { get; set; }
        public bool IsClearJuice { get; set; }
        public bool IsCloudyJuice { get; set; }
        public bool IsClearConcentrate { get; set; }
        public bool IsCloudyConcentrate { get; set; }
        public bool IsOrganic { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.UtcNow;
        public DateTime UpdateDate { get; set; } = DateTime.UtcNow;
        public bool IsActive { get; set; }
    }
}
