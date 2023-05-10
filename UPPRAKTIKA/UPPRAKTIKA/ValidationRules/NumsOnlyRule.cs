using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace UPPRAKTIKA.ValidationRules
{
    public class NumsOnlyRule : ValidationRule
    {
        public override ValidationResult Validate(object value,
        System.Globalization.CultureInfo cultureInfo)
        {
            string str = string.Empty;
            if (value != null)
            {
                str = value.ToString();
            }
            else
                return new ValidationResult(false, " Числовое поле не задано! ");
            if (str.Contains("0") || str.Contains("1") || str.Contains("2") || str.Contains("3") || str.Contains("4") || str.Contains("5") || 
                str.Contains("6") || str.Contains("7") || str.Contains("8") || str.Contains("9"))
            {
                return new ValidationResult(true, null);
            }
            else
            {

                return new ValidationResult(false,
                 "В данном поле должны быть цифры");
            }
        }
    }
}
