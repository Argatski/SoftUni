using SOLID_Exercises.Models.Enumerations;

namespace SOLID_Exercises.Models.Contracts
{
    public interface IAppender
    {
        ILayout Layout { get; }

        Level Level { get; }
        void Append(IError error);
    }
}
