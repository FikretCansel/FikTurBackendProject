﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IPlanService
    {
        IDataResult<List<Plan>> GetAll();
        IResult Add(Plan plan);
        IResult Delete(Plan plan);
        IResult Update(Plan plan);
        IDataResult<Plan> GetById(int id);
        DataResult<List<PlanAndTourOrderDetailsDto>> GetAllPlanAndTourOrderDetailsByTourId(int tourId);
        DataResult<List<PlanAndTourOrderDetailsDto>> GetAllPlanAndTourOrderDetails();

    }
}
