using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Models
{
    public class calenderItem
    {
        public static List<SelectListItem> Years()
        {
            List<string> obj = new List<string>();
            ICollection<KeyValuePair<int, String>> dateList =
            new Dictionary<int, String>();

            DateTime rightNow = DateTime.Now;

            //previous month
            for (int i = -1; i >= -2; i--)
            {
                string previous = rightNow.AddMonths(i).ToString("MMMM yyyy");
                var dict1 = previous.Split(' ');
                string months = dict1[0].ToString();

                int monthno = DateTime.ParseExact(months, "MMMM", CultureInfo.InvariantCulture).Month;
                dateList.Add(new KeyValuePair<int, String>(monthno, previous));
            }

            dateList = dateList.OrderByDescending(keySelector: u => u.Value).ToDictionary(keySelector: z => z.Key, elementSelector: y => y.Value);

            // current month
            string current = rightNow.ToString("MMMM yyyy");
            var dict1x = current.Split(' ');
            string monthss = dict1x[0].ToString();
            int monthnox = DateTime.ParseExact(monthss, "MMMM", CultureInfo.InvariantCulture).Month;
            dateList.Add(new KeyValuePair<int, String>(monthnox, current));

            // upcoming month
            for (int i = 1; i <= 2; i++)
            {
                string mon = rightNow.AddMonths(i).ToString("MMMM yyyy");
                var dict1 = mon.Split(' ');
                string months = dict1[0].ToString();

                int monthno = DateTime.ParseExact(months, "MMMM", CultureInfo.InvariantCulture).Month;
                dateList.Add(new KeyValuePair<int, String>(monthno, mon));
            }


            var myListItems = new List<SelectListItem>();

            myListItems.AddRange(dateList.Select(keyValuePair => new SelectListItem()
            {
                Value = keyValuePair.Key.ToString(),
                Text = keyValuePair.Value
            }));

            return myListItems;
        }

        public static string GetCurrentYearRecords()
        {
            DateTime rightNow = DateTime.Now;
            string currentMonth = rightNow.ToString("MMMM yyyy");
            return currentMonth;
        }

        public static List<SelectListItem> GetDates(int month)
        {
            List<SelectListItem> items = new List<SelectListItem>();
           // var dates = new List<string>();
            int year = DateTime.Now.Year;
            // Loop from the first day of the month until we hit the next month, moving forward a day at a time
            for (var date = new DateTime(year, month, 1); date.Month == month; date = date.AddDays(1))
            {
                items.Add(new SelectListItem
                {
                    Text = date.Day.ToString(),
                    Value = date.Day.ToString()
                });
                
            }

            return items;
        }
    }
}