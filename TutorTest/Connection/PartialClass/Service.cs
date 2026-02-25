using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorTest.Connection
{
   internal partial class Service
    {
        public string CostStr()
        {
            if (Discount == null)
            {
                return $"{Cost} рублей за {DurationInSeconds / 60} минут";
            }
            else
            {
                return $"{(double)Cost * (1 - Discount)} рублей за {DurationInSeconds / 60} минут";
            }
        }
        public string DiscountStr() 
        {
            if (Discount != null)
            {
                return $"*скидка {Discount * 100}%";
            }
            return null;
        }
            
    }
}
