using System.Collections.Generic;
using System.Web.Mvc;

namespace JuveApp.Models
{
    public class CultureModel
    {
        public string Culture { get; set; }
        public IEnumerable<SelectListItem> Cultures
        {
            get
            {
                var sli1 = new SelectListItem { Text = "English", Value = "en-US" };
                var sli2 = new SelectListItem { Text = "Russian", Value = "ru-RU" };

                var sl = new SelectList(new[] { sli1, sli2 }, "Value", "Text");

                return sl;
            }
        }



    }
}