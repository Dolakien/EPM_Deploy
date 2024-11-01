﻿using ExamProctoringManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProctoringManagement.Service.Interfaces
{
    public interface IRegistrationFormService
    {
        Task<RegistrationForm> GetRegistrationFormByIdAsync(string id);
        Task<IEnumerable<RegistrationForm>> GetAllRegistrationFormsAsync();
        Task<RegistrationForm> CreateRegistrationFormAsync(RegistrationForm RegistrationForm);
        Task UpdateRegistrationFormAsync(RegistrationForm RegistrationForm);
        Task DeleteRegistrationFormAsync(string id);
    }
}
