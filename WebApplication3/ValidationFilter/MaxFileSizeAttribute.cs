namespace WebApplication3.ValidationFilter
{
    using Microsoft.AspNetCore.Http;
    using System;
    using System.ComponentModel.DataAnnotations;

    public class MaxFileSizeAttribute : ValidationAttribute
    {
        public int MaxSize { get; set; }

        public MaxFileSizeAttribute(int maxSize)
        {
            MaxSize = maxSize;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var file = value as IFormFile;
            if (file != null)
            {
                if (file.Length > MaxSize)
                {
                    return new ValidationResult(ErrorMessage ?? $"File size cannot exceed {MaxSize / 1024}KB.");
                }
            }

            return ValidationResult.Success;
        }
    }

}
