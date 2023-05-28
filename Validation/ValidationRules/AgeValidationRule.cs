using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Validation.ValidationRules
{
    public class AgeValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            int age = 0;
            try
            {
                if (((string)value).Length > 0)
                {
                    age = Int32.Parse((string)value);
                }
            }
            catch 
            {
                return new ValidationResult(false, "Значение не может быть пустым или состоять из пробелов!");
            }
            if (age < 0 || age > 100)
            {
                return new ValidationResult(false, "Возраст должен быть от 0 до 100!");
            }
            return ValidationResult.ValidResult;
        }
    }
}
