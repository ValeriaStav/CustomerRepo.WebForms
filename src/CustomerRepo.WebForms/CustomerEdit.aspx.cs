using CustomerManagement.BusinessEntities;
using CustomerManagement.Interfaces;
using CustomerManagement.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CustomerRepo.WebForms
{
    public partial class CustomerEdit : System.Web.UI.Page
    {
        public IRepository<Customer> _customerRepository;

        public CustomerEdit()
        {
            _customerRepository = new CustomerRepository();
        }

        public CustomerEdit(IRepository<Customer> customerRepository)
        {
            _customerRepository = customerRepository;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var customerIdReq = Convert.ToInt32(Request["customerId"]);
                if (customerIdReq != 0)
                {
                    var customer = _customerRepository.Read(customerIdReq);
                    firstName.Text = customer.FirstName;
                    lastName.Text = customer.LastName;
                    customerPhoneNumber.Text = customer.CustomerPhoneNumber;
                    customerEmail.Text = customer.CustomerEmail;
                    totalPurchaseAmount.Text = customer.TotalPurchaseAmount.ToString();
                }
            }
        }

        public void OnClickSave(object sender, EventArgs e)
        {
            var customer = new Customer()
            {
                CustomerId = Convert.ToInt32(Request.QueryString["customerId"]),
                FirstName = firstName.Text,
                LastName = lastName.Text,
                CustomerPhoneNumber = customerPhoneNumber.Text,
                CustomerEmail = customerEmail.Text,
                TotalPurchaseAmount = Convert.ToDecimal(totalPurchaseAmount?.Text)
            };

            if (Convert.ToInt32(Request.QueryString["customerId"]) == 0)
                _customerRepository.Create(customer);
            else 
                _customerRepository.Update(customer);
            
            Response.Redirect("CustomersList.aspx");
        }
    }
}