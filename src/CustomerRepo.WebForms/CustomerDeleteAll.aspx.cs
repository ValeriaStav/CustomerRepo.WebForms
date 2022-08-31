using CustomerManagement.BusinessEntities;
using CustomerManagement.Interfaces;
using CustomerManagement.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CustomerRepo.WebForms
{
    public partial class CustomerDeleteAll : System.Web.UI.Page
    {
        public IRepository<Customer> _customerRepository;
        public CustomerDeleteAll()
        {
            _customerRepository = new CustomerRepository();
        }
        public CustomerDeleteAll(IRepository<Customer> customerRepository)
        {
            _customerRepository = customerRepository;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            _customerRepository.DeleteAll();
            Response.Redirect("CustomersList.aspx");
        }
    }
}