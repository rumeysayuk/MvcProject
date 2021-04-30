﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using EntityLayer.Concrete;

namespace BusinessLayer.ValidationRules.FluentValidation
{
    class AboutValidator:AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(a => a.AboutDetails1).NotEmpty().Length(10,1000);
            RuleFor(a => a.AboutDetails2).NotEmpty().Length(10, 1000);
            RuleFor(a => a.AboutImage1).NotEmpty().Length(10, 100);
            RuleFor(a => a.AboutImage2).NotEmpty().Length(10, 100);
        }
    }
}
