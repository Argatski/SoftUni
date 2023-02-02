using P04.Recharge.Models.Interfaces;

namespace P04.Recharge.Models
{
    public class RechargeStation
    {
        public void Recharge(IRechargeable rechargeable)
        {
            rechargeable.Recharge();
        }
    }
}
