using WebAccountant.DAOs;
using WebAccountant.ModelsBase;

namespace WebAccountant.Repository.Implement
{
    public class KtdmRepo : IKtdmRepo
    {
        private readonly UnitOfWork _unitOfWork;
        public KtdmRepo(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<Ktdm>> GetAllKtdmsAsync()
        {
            return await _unitOfWork.KTDMDao.GetAll();
        }
    }
}
