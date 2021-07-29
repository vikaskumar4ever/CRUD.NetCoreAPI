using System;
using System.Collections.Generic;

namespace Employee.Library
{
    public interface IEmployeeRepository : IDisposable
    {
        List<EmpDetails> GetAllRecorod();
        EmpDetails GetRecorodById(Guid iId);
        Guid? InsertUpdateRecord(EmpDetails objEmployee);
        bool DeleteRecord(int iId);
    }
}
