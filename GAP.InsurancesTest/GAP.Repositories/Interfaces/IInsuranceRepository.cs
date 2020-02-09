﻿using GAP.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GAP.Repositories.Interfaces
{
    public interface IInsuranceRepository
    {
        List<Insurance> GetAll();
        Insurance GetById(int id);
        List<Insurance> GetInsuranceByClient(int id);
        bool UpdInsuranceById(Insurance insurance);
        bool DelInsuranceById(int id);
        bool InsertInsurance(Insurance insurance);
    }
}