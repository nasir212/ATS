﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATS.Model.Models
{
    class AssetManufacturers
    {
        public long Id { get; set; }
        [Display(Name = "Asset Group")]
        [Required]
        public long AssetGroupsId { get; set; }
        public virtual AssetGroups AssetGroups { get; set; }
        [Display(Name ="Name")]
        [Required(ErrorMessage = "Asset name is required")]
        public string Name { get; set; }
        [Display(Name = "Short Name")]
        [Required(ErrorMessage = "Short Name is required")]
        public string ShortName { get; set; }
        [Display(Name = "Code")]
        [Required]
        public string Code { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModefiedBy { get; set; }
        public DateTime ModefiedOn { get; set; }

    }
}
