using FluentValidation;
using Racoon.Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.ValidationRules.FluentValidation
{
    class PersonValidator:AbstractValidator<Person>
    {
        public PersonValidator()
        {
            RuleFor(p => p.PersonName).NotEmpty().WithMessage("Ürün ismi boş geçilmez");
            RuleFor(p => p.OccupationId).NotEmpty().WithMessage("Ürün meslek boş geçilmez");
            RuleFor(p => p.DateOfBirth).NotEmpty().WithMessage("Karakter Doğum Tarihi Boş Geçilmez");
            RuleFor(p => p.Sex).NotEmpty().WithMessage("Karakter cinsiyet boş geçilmez");
            RuleFor(p => p.Status).NotEmpty().WithMessage("Karakter statü durum boş geçilmez");
            RuleFor(p => p.Personİmage).NotEmpty().WithMessage("Karakter fotoğraf Boş Geçilmez");
            RuleFor(p => p.Personİmage).NotEmpty().WithMessage("Karakter meslek fotoğraf boş geçilmez");
            RuleFor(p => p.Personİmage).NotEmpty().WithMessage("Karakter meslek boş geçilmez");
        }
    }
}
