﻿using System;
using System.Collections.Generic;
using FluentValidation.Results;
using System.Text;

namespace GloboTicket.TicketManagement.Application.Exceptions
{
    class ValidationException: ApplicationException
    {
        public List<string> ValidationErrors { get; set; }
        public ValidationException(ValidationResult validationResult)
        {
            ValidationErrors = new List<string>();

            foreach (var validationError in validationResult.Errors)
            {
                ValidationErrors.Add(validationError.ErrorMessage);
            }
        }
    }
}
