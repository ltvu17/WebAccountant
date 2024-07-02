using WebAccountant.ModelsBase;
using WebAccountant.ModelsLogin;

namespace WebAccountant.DAOs
{
    public class UnitOfWork
    {
        private readonly TIENHIEU2024Context _dbContext;
        private readonly LoginContext _loginContext;
        public UnitOfWork(TIENHIEU2024Context context, LoginContext loginContext)
        {
            _dbContext = context;
            _loginContext = loginContext;
        }
        private readonly GenericDAO<Ktdm, TIENHIEU2024Context> ktdmDAO;
        public GenericDAO<Ktdm, TIENHIEU2024Context> KTDMDao
        {
            get
            {
                if(ktdmDAO == null)
                {
                    return new GenericDAO<Ktdm, TIENHIEU2024Context>(_dbContext);
                }
                return ktdmDAO;
            }
        }
        private readonly GenericDAO<Ktcn, TIENHIEU2024Context> ktcnDAO;
        public GenericDAO<Ktcn, TIENHIEU2024Context> KTCNDAO
        {
            get
            {
                if (ktcnDAO == null)
                {
                    return new GenericDAO<Ktcn, TIENHIEU2024Context>(_dbContext);
                }
                return ktcnDAO;
            }
        }
        private readonly GenericDAO<Ktdtpn, TIENHIEU2024Context> ktdtpnDAO;
        public GenericDAO<Ktdtpn, TIENHIEU2024Context> KTDTPNDAO
        {
            get
            {
                if (ktdtpnDAO == null)
                {
                    return new GenericDAO<Ktdtpn, TIENHIEU2024Context>(_dbContext);
                }
                return ktdtpnDAO;
            }
        }
        private readonly GenericDAO<Ktlctg, TIENHIEU2024Context> KtlctgDAO;
        public GenericDAO<Ktlctg, TIENHIEU2024Context> KTLCTGDAO
        {
            get
            {
                if (KtlctgDAO == null)
                {
                    return new GenericDAO<Ktlctg, TIENHIEU2024Context>(_dbContext);
                }
                return KtlctgDAO;
            }
        }
        private readonly GenericDAO<Ktsc, TIENHIEU2024Context> KtscDAO;
        public GenericDAO<Ktsc, TIENHIEU2024Context> KTSCDAO
        {
            get
            {
                if (KtscDAO == null)
                {
                    return new GenericDAO<Ktsc, TIENHIEU2024Context>(_dbContext);
                }
                return KtscDAO;
            }
        }
        private readonly GenericDAO<Kttk, TIENHIEU2024Context> KttkDAO;
        public GenericDAO<Kttk, TIENHIEU2024Context> KTTKDAO
        {
            get
            {
                if (KttkDAO == null)
                {
                    return new GenericDAO<Kttk, TIENHIEU2024Context>(_dbContext);
                }
                return KttkDAO;
            }
        }
        private readonly GenericDAO<KtUserTable, TIENHIEU2024Context> ktUserTableDAO;
        public GenericDAO<KtUserTable, TIENHIEU2024Context> KtUserTableDAO
        {
            get
            {
                if (ktUserTableDAO == null)
                {
                    return new GenericDAO<KtUserTable, TIENHIEU2024Context>(_dbContext);
                }
                return ktUserTableDAO;
            }
        }
        /// <summary>
        /// login
        /// </summary>
        private readonly GenericDAO<User, LoginContext> userDAO;
        public GenericDAO<User, LoginContext> UserDao
        {
            get
            {
                if (userDAO == null)
                {
                    return new GenericDAO<User, LoginContext>(_loginContext);
                }
                return userDAO;
            }
        }
		private readonly GenericDAO<DatabaseInfor, LoginContext> databaseInforDAO;
		public GenericDAO<DatabaseInfor, LoginContext> DatabaseInforDAO
		{
			get
			{
				if (databaseInforDAO == null)
				{
					return new GenericDAO<DatabaseInfor, LoginContext>(_loginContext);
				}
				return databaseInforDAO;
			}
		}
        private readonly GenericDAO<UserKTSCColumn, LoginContext> userKTSCColumnsDAO;
        public GenericDAO<UserKTSCColumn, LoginContext> UserKTSCColumnsDAO
        {
            get
            {
                if (userKTSCColumnsDAO == null)
                {
                    return new GenericDAO<UserKTSCColumn, LoginContext>(_loginContext);
                }
                return userKTSCColumnsDAO;
            }
        }
        private readonly GenericDAO<UserKTDMColumn, LoginContext> userKTDMColumnDAO;
        public GenericDAO<UserKTDMColumn, LoginContext> UserKTDMColumnDAO
        {
            get
            {
                if (userKTDMColumnDAO == null)
                {
                    return new GenericDAO<UserKTDMColumn, LoginContext>(_loginContext);
                }
                return userKTDMColumnDAO;
            }
        }
        private readonly GenericDAO<KTSCColumn, LoginContext> kTSCColumnsDAO;
        public GenericDAO<KTSCColumn, LoginContext> KTSCColumnsDAO
        {
            get
            {
                if (kTSCColumnsDAO == null)
                {
                    return new GenericDAO<KTSCColumn, LoginContext>(_loginContext);
                }
                return kTSCColumnsDAO;
            }
        }
        private readonly GenericDAO<KTDMColumn, LoginContext> kTDMColumnsDAO;
        public GenericDAO<KTDMColumn, LoginContext> KTDMColumnsDAO
        {
            get
            {
                if (kTDMColumnsDAO == null)
                {
                    return new GenericDAO<KTDMColumn, LoginContext>(_loginContext);
                }
                return kTDMColumnsDAO;
            }
        }
        public Task SaveChangesAsync()
        {
             return _dbContext.SaveChangesAsync();
        }
        public Task SaveChangesLoginContextAsync()
        {
            return _loginContext.SaveChangesAsync();
        }
    }
}
