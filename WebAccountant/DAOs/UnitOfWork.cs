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
        private readonly GenericDAO<Ktcn> ktcnDAO;
        public GenericDAO<Ktcn> KTCNDAO
        {
            get
            {
                if (ktcnDAO == null)
                {
                    return new GenericDAO<Ktcn>(_dbContext);
                }
                return ktcnDAO;
            }
        }
        private readonly GenericDAO<Ktdtpn> ktdtpnDAO;
        public GenericDAO<Ktdtpn> KTDTPNDAO
        {
            get
            {
                if (ktdtpnDAO == null)
                {
                    return new GenericDAO<Ktdtpn>(_dbContext);
                }
                return ktdtpnDAO;
            }
        }
        private readonly GenericDAO<Ktlctg> KtlctgDAO;
        public GenericDAO<Ktlctg> KTLCTGDAO
        {
            get
            {
                if (KtlctgDAO == null)
                {
                    return new GenericDAO<Ktlctg>(_dbContext);
                }
                return KtlctgDAO;
            }
        }
        private readonly GenericDAO<Ktsc> KtscDAO;
        public GenericDAO<Ktsc> KTSCDAO
        {
            get
            {
                if (KtscDAO == null)
                {
                    return new GenericDAO<Ktsc>(_dbContext);
                }
                return KtscDAO;
            }
        }
        private readonly GenericDAO<Kttk> KttkDAO;
        public GenericDAO<Kttk> KTTKDAO
        {
            get
            {
                if (KttkDAO == null)
                {
                    return new GenericDAO<Kttk>(_dbContext);
                }
                return KttkDAO;
            }
        }

        public Task SaveChangesAsync()
        {
             return _dbContext.SaveChangesAsync();
        }
    }
}
