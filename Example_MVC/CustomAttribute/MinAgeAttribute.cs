﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Example_MVC.CustomAttribute
{
    public class MinAgeAttribute : ValidationAttribute
    {
        private int _minAge;
        public MinAgeAttribute(int value)
        {
            _minAge = value;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                if (value is int)
                {
                    int minimumage = (int)value;
                    if (minimumage < _minAge)
                    {
                        return new ValidationResult("Minimum age must be " + _minAge);
                    }
                }
            }
            return ValidationResult.Success;
        }
    }
}