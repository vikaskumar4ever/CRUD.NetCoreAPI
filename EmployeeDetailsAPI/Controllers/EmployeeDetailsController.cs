using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Employee.Library;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeeDetailsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeDetailsController : ControllerBase
    {
        // GET: api/<EmployeeDetailsController>
        [HttpGet]
        public IEnumerable<EmpDetails> Get()
        {
            List<EmpDetails> objReturn = new List<EmpDetails>();
            using (Employee_BAL objBAL = new Employee_BAL())
            {
                objReturn = objBAL.GetAllRecorod();
            }
            return objReturn;
        }

        // GET api/<EmployeeDetailsController>/5
        [HttpGet("{id}")]
        public EmpDetails Get(Guid id)
        {
            EmpDetails objReturn = new EmpDetails();
            using (Employee_BAL objBAL = new Employee_BAL())
            {
                objReturn = objBAL.GetRecorodById(id);
            }
            return objReturn;
        }

        // POST api/<EmployeeDetailsController>
        [HttpPost]
        public DefaultResult Post([FromBody] EmpDetails value)
        {
            DefaultResult objReturn = new DefaultResult();
            if (value.Id == 0)
            {
                value.EmpId = Guid.NewGuid();
            }
            using (Employee_BAL objBAL = new Employee_BAL())
            {
                objReturn.Data = objBAL.InsertUpdateRecord(value).ToString();
            }
            return objReturn;
        }

        // PUT api/<EmployeeDetailsController>/5
        [HttpPut("{id}")]
        public DefaultResult Put(int id, [FromBody] EmpDetails value)
        {
            DefaultResult objReturn = new DefaultResult();
            if (value.Id != 0)
            {
                using (Employee_BAL objBAL = new Employee_BAL())
                {
                    objReturn.Data = objBAL.InsertUpdateRecord(value).ToString();
                }
            }
            return objReturn;
        }

        // DELETE api/<EmployeeDetailsController>/5
        [HttpDelete("{id}")]
        public DefaultResult Delete(int id)
        {
            DefaultResult objReturn = new DefaultResult();
            using (Employee_BAL objBAL = new Employee_BAL())
            {
                objReturn.Data = objBAL.DeleteRecord(id).ToString();
            }
            return objReturn;
        }
    }
}
