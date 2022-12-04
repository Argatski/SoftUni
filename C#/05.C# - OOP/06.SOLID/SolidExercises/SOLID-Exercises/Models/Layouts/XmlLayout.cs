using SOLID_Exercises.Models.Contracts;
using System;
using System.Text;

namespace SOLID_Exercises.Models.Layouts
{
    public class XmlLayout : ILayout
    {
        public string Format => this.GetFormat();

        private string GetFormat()
        {
            var result = new StringBuilder();
            result.AppendLine("<log>");
            result.AppendLine("\t<date>{0}</date>");
            result.AppendLine("\t<level>{1}</level>");
            result.AppendLine("\t<message>{2}</message>");
            result.AppendLine("<log>");

            return result.ToString().TrimEnd();
        }
    }
}
