using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        //kurallar constructor' a yazılır.
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p => p.ProductName).MinimumLength(2);
            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p => p.UnitPrice).GreaterThan(0);
            //p nin fiyatı p'nin kategorisi 1 olduğu sürece 10 dan büyük olmalı 
            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(10).When(p => p.CategoryID == 1);
            //productname A ile başlamalı
            RuleFor(p => p.ProductName).Must(StarWithA).WithMessage("Ürünler A harfi ile başlamalı");
        }

        private bool StarWithA(string arg)
        {
            return arg.StartsWith("A"); //sağlıyorsa true döner
        }
    }
}
