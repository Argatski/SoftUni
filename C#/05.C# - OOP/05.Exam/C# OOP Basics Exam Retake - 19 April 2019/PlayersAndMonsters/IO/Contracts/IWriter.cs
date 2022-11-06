namespace PlayersAndMonsters.IO.Contracts
{
    public interface IWriter
    {
        void WriteLine(object message);

        void Write(object message);
    }
}
