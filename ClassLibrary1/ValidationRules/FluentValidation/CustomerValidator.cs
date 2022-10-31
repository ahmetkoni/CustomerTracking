using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c => c.LicenseTime).NotEmpty();
            RuleFor(c => c.CompanyAddress).NotEmpty();
            RuleFor(c => c.CompanyWebAddress).NotEmpty();
            RuleFor(c => c.ManagerPhone).NotEmpty();
            RuleFor(c => c.Price).NotEmpty();
            RuleFor(c => c.Price).NotEmpty();
            RuleFor(c => c.ManagerName).NotEmpty();
            RuleFor(c => c.Version).NotEmpty();
            RuleFor(c => c.Note).NotEmpty();
            RuleFor(c => c.ManagerEMail).NotEmpty();

        }
    }
}
