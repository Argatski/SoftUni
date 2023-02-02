using SOLID_Exercises.Models.Contracts;

namespace SOLID_Exercises.Models.Layouts
{
    public class SimpleLayout : ILayout
    {
        public string Format => $"{0} - {1} - {2}";
    }
}
