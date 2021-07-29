using System;
using log4net;
using System.Collections.Generic;

namespace Employee.Library
{
    public class Employee_BAL : IEmployeeRepository
    {
        ILog log = log4net.LogManager.GetLogger(typeof(Employee_BAL));
        public List<EmpDetails> GetAllRecorod()
        {
            List<EmpDetails> objReturn = null;
            try
            {
                using (Employee_DAL objDAL = new Employee_DAL())
                {
                    objReturn = objDAL.GetAllRecorod();
                }
            }
            catch (Exception ex)
            { log.Error("GetAllRecorod Error: ", ex); }
            return objReturn;
        }
        public EmpDetails GetRecorodById(Guid iId)
        {
            EmpDetails objReturn = null;
            try
            {

                {
                    using (Employee_DAL objDAL = new Employee_DAL())
                    {
                        objReturn = objDAL.GetRecorodById(iId);
                    }
                }
            }
            catch (Exception ex)
            { log.Error("GetRecorodById Error: ", ex); }
            return objReturn;
        }

        public Guid? InsertUpdateRecord(EmpDetails objEmployee)
        {
            Guid? objReturn = null;
            try
            {
                using (Employee_DAL objDAL = new Employee_DAL())
                {
                    objReturn = objDAL.InsertUpdateRecord(objEmployee);
                }
            }
            catch (Exception ex)
            { log.Error("InsertUpdateRecord Error: ", ex); }
            return objReturn;
        }
        public bool DeleteRecord(int iId)
        {
            bool objReturn = false;
            try
            {
                if (iId > 0)
                {
                    using (Employee_DAL objDAL = new Employee_DAL())
                    {
                        objReturn = objDAL.DeleteRecord(iId);
                    }
                }
            }
            catch (Exception ex)
            { log.Error("DeleteRecord Error: ", ex); }
            return objReturn;
        }

        #region IDisposable Support
        private bool disposedValue = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion

    }
}
