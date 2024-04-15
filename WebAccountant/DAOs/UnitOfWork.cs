using WebAccountant.ModelsBase;

namespace WebAccountant.DAOs
{
    public class UnitOfWork
    {
        private readonly TIENHIEU2024Context _dbContext;
        public UnitOfWork(TIENHIEU2024Context context)
        {
            _dbContext = context;
        }
        private readonly GenericDAO<Ktdm> ktdmDAO;
        public GenericDAO<Ktdm> KTDMDao
        {
            get
            {
                if(ktdmDAO == null)
                {
                    return new GenericDAO<Ktdm>(_dbContext);
                }
                return ktdmDAO;
            }
        }
    }
}
