using FluentValidation;
using Racoon.Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.ValidationRules.FluentValidation
{
    class OccupationValidator : AbstractValidator<Occupation>
    {
        public OccupationValidator()
        {
            RuleFor(p => p.OccupationName).NotEmpty().WithMessage("Meslek adi boş geçilmez");
            RuleFor(p => p.Occupationİmage1).NotEmpty().WithMessage("Meslek fotoğraf boş geçilmez");
            RuleFor(p => p.Occupationİmage2).NotEmpty().WithMessage("Meslek fotoğraf boş geçilmez");

        }
    }
}
