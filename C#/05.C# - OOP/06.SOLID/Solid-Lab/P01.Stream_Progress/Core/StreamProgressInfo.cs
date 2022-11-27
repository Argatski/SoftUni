
namespace StreamProgressInfo.Core
{
    using Models.Interfaces;
    public class StreamProgressInfo
    {
        private readonly IStreamable stremable;

        public StreamProgressInfo(IStreamable stremable)
        {
            this.stremable = stremable;
        }

        public int CalculateCurrentPercent()
        {
            return (this.stremable.BytesSent * 100) / this.stremable.Length;
        }

    }
}
