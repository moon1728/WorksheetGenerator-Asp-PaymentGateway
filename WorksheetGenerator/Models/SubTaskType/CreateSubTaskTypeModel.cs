﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace WorksheetGenerator.Models.SubTaskType
{
    public class CreateSubTaskTypeModel
    {
        public int Id { get; set; }
        
        public string Name { get; set; } = null!;
        public string? Description { get; set; }

        #region SelectList Class

        [Display(Name = "TaskTypeId")]
        public IList<SelectListItem>? TaskTypes { get; set; }
        [Required(ErrorMessage = "Bitte wähle eine TaskType aus.")]
        public int? SelectedTaskType { get; set; }

        #endregion


    }
}
