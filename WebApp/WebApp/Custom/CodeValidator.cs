using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Custom
{
    public class CodeValidator:ValidationAttribute,IClientModelValidator
    {
        public string Character { get; set; }

        public void AddValidation(ClientModelValidationContext context)
        {
            context.Attributes.Add("data-val-codevalidator", ErrorMessage);
            context.Attributes.Add("data-val-codevalidator-char", Character);
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {

            string code = value as string;
            if(code!=null && !code.StartsWith(Character,StringComparison.OrdinalIgnoreCase))
            {

                return new ValidationResult(ErrorMessage);
            }
            return ValidationResult.Success;
        }
    }
}
