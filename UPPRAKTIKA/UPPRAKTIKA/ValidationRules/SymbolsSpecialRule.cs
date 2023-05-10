using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace UPPRAKTIKA.ValidationRules
{
    public class SymbolsSpecialRule : ValidationRule
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
                return new ValidationResult(false, " Поле не задано! ");
            if (str.Contains("@") || str.Contains("!") || str.Contains("&") || str.Contains("*") || str.Contains("%") ||
                str.Contains("?") || str.Contains("/") || str.Contains(".") || str.Contains(",") || str.Contains(":"))
            {
                return new ValidationResult(false, "В поле существуют специальные символы! ");
            }
            else
            {

                return new ValidationResult(true, null);
            }
        }
    }
}
