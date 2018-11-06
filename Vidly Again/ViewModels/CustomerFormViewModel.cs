using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly_Again.Models;

namespace Vidly_Again.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}