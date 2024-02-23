﻿using System.ComponentModel.DataAnnotations;

namespace AspNetCore_MVC.Helpers
{
    public class CheckboxRequired : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            return value is bool b && b;
        }
    }
}
