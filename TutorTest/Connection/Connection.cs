using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorTest.Connection
{
    internal class Connection
    {
        public static TutorLanguageEntities db = new TutorLanguageEntities();
    }
    public partial class Service
    {
        /// <summary>
        /// Форматированное время длительности (например, "2 ч 30 мин" или "45 мин")
        /// </summary>
        public string DurationText
        {

            get
            {
                TimeSpan time = TimeSpan.FromSeconds(DurationInSeconds);
                if (time.TotalHours >= 1)
                    return $"{(int)time.TotalHours} ч {time.Minutes} мин";
                else
                    return $"{time.Minutes} мин";
            }
        }
    }
}
