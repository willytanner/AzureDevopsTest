﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AzureDevopsTest.Models
{
   public class Todo
   {
      [Display(Name = "Todo ID")]
      public int Id { get; set; }
      [Display(Name = "Description")]
      public string Description { get; set; }

   }
}
