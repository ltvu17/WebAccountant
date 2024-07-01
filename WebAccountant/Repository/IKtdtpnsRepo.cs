using WebAccountant.ModelsBase;

namespace WebAccountant.Repository
{
    public interface IKtdtpnsRepo : IBaseRepo<Ktdtpn>
    {
        public Task<bool> UpdateKTDTPN(Ktdtpn ktdtpn);
    }
}
