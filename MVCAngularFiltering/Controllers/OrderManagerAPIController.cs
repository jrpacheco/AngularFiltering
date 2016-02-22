using MVCAngularFiltering.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVCAngularFiltering.Controllers
{    
    public class OrderManagerAPIController : ApiController
    {
        ContextDB _db;

        public OrderManagerAPIController()
        {
            _db = new ContextDB();
        }

        [Route("OrdersManager")]
        public List<EmployeeInfo_> GetAll()
        {
            return _db.EmployeeInfo_.ToList();            
        }

        [Route("OrdersManager/{filter}/{value}")]
        public List<EmployeeInfo_> GetBy(string filter, string  value)
        {
            List<EmployeeInfo_> listEmployee = new List<EmployeeInfo_>();

            switch (filter)
            {
                case "CustomerName":
                    listEmployee = (from c in _db.EmployeeInfo_ where c.CustomerName.StartsWith(value) select c).ToList();
                    break;
                case "CustomerMobile":
                    listEmployee = (from c in _db.EmployeeInfo_
                                    where c.CustomerMobile.StartsWith(value)
                                    select c).ToList();
                    break;
                case "SalesAgentName":
                    listEmployee = (from c in _db.EmployeeInfo_
                                    where c.SalesAgentName.StartsWith(value)
                                    select c).ToList();
                    break;
                default:
                    break;
            }
            return listEmployee;
        }
    }
}
