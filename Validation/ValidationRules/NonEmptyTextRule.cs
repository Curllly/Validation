using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Validation.ValidationRules
{
    public class NonEmptyTextRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string text = value as string;
            if (text != null)
            {
                if (text.Trim() != "")
                {
                    return ValidationResult.ValidResult;
                }
            }
            return new ValidationResult(false, "Значение не может быть пустым или состоять из пробелов!");
        }
    }
}
