using System;
using System.Collections.Generic;
using System.Text;

namespace Employee.Library
{
    public class EmpDetails
    {
        public int Id { get; set; }
        public Guid EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpDeptName { get; set; }
        public string EmpPhoneNo { get; set; }
    }
}
