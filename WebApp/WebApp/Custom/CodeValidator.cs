using System.ComponentModel.DataAnnotations;

namespace WebApp.Custom
{
    public class CodeValidator:ValidationAttribute
    {
        public string Character { get; set; }
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
