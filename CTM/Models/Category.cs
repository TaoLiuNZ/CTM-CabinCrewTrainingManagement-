﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CTM.Areas.Search.Models;

namespace CTM.Models
{
    public class Category: Model<Category>
    {
        public Category()
        {
            this.EnglishTests = new HashSet<EnglishTest>();
            this.UploadRecords = new HashSet<UploadRecord>();
        }

        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public string ID { get; set; }

        [EnumDataType(typeof(SuperCategory))]
        [Display(Name = "SuperCategory", ResourceType = typeof(Resources.Models.ConstModels))]
        public SuperCategory Type { get; set; }

        [Display(Name = "SubCategory", ResourceType = typeof(Resources.Models.ConstModels))]
        public string Name { get; set; }

        public virtual ICollection<EnglishTest> EnglishTests { get; set; }
        public virtual ICollection<UploadRecord> UploadRecords { get; set; }

        public override string ToString()
        {
            List<string> stringList = new List<string>()
            {
                PropertyToString("ID",ID),
                PropertyToString("Type",Type),
                PropertyToString("Name",Name)
            };

            return string.Join(";", stringList);
        }
    }

    public enum SuperCategory
    {
        英语考核 = 000000000001,
        复训 = 000000000002,
    };
}