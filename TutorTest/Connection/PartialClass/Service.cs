using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TutorTest.Connection
{
    public partial class Service
    {
        public string CostStr
        {

            get
            {
                if (Discount == null)
                {
                    return $"{Cost:N0} рублей за {DurationInSeconds / 60} минут";
                }
                else
                {
                    return $"{(double)Cost * (1 - Discount)} рублей за {DurationInSeconds / 60} минут";
                }
            }

        }
        public string DiscountStr
        {
            get
            {
                if (Discount != null)
                {
                    return $"*скидка {Discount * 100}%";
                }
                return null;
            }
        }

        public Visibility CostVisibl
        {
            get
            {
                if (Discount == null)
                {
                    return Visibility.Collapsed;
                }
                else
                {
                    return Visibility.Visible;
                }

            }
        }
    }
}
