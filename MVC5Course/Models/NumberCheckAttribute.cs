using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC5Course.Models
{
    //欄位驗證，新加入一個類別，繼承DataTypeAttribute
    //複寫isValid方法，進行判斷處理

    public class NumberCheckAttribute : DataTypeAttribute
    {
        public NumberCheckAttribute() : base("NumberCheck")
        {

        }
        public override bool IsValid(object value)
        {
            //若為NULL，則返回、不需再進行驗證。返回值T or F皆可，因NULL值判斷由Required處理
            if (value == null) { return true; };

            int num;
            if (int.TryParse(value.ToString(), out num))
            {
                return (num % 2 == 0) ? true : false;
            }
            else
            {
                return false;
            }
        }
    }
}