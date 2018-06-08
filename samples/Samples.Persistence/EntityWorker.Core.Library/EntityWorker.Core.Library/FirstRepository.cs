namespace EntityWorker.Core.Library
{
    using EntityWorker.Core.Helper;
    using EntityWorker.Core.Interface;
    using EntityWorker.Core.Transaction;

    public class FirstRepository : Transaction
    {
        public FirstRepository(string connectionString, DataBaseTypes dataBaseTypes = DataBaseTypes.Mssql)
            : base(connectionString, dataBaseTypes)
        {
        }

        protected override void OnModuleStart()
        {
            throw new System.NotImplementedException();
        }

        protected override void OnModuleConfiguration(IModuleBuilder moduleBuilder)
        {
            throw new System.NotImplementedException();
        }
    }
}