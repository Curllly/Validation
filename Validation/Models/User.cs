using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Validation.Models;

public partial class User : IDataErrorInfo
{
    public string this[string columnName]
    {
        get
        {
            if (columnName == "Name")
            {
                if (Name.Trim() == "")
                {
                    return "Имя не может быть пустым";
                }
            }
            if (columnName == "Username")
            {
                if (Username.Trim().Length < 3)
                {
                    return "Имя пользователя должно содержать хотя бы 3 символа!";
                }
                if (Username.Trim().Any(ch => !char.IsLetter(ch)))
                {
                    return "Имя пользователя должно содержать только буквы!";
                }
            }
            if (columnName == "Age")
            {
                if (Age < 0 || Age > 100)
                {
                    return "Возраст не может быть меньше 0 или больше 100!";
                }
            }
            return "";
        }
    }

    public int UserId { get; set; }

    public string? Username { get; set; }

    public string? Name { get; set; }

    public int? Age { get; set; }

    public string Error => throw new NotImplementedException();
}
