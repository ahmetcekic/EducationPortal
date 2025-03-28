﻿using ApplicationCore.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services.Interface
{
    public interface IStudentService : IBaseRepository<Student>
    {
        double? GetTotalEarningByCourseId(Guid courseId);
        Task<int> GetSuccessStudentsPercentage();
        Task<int> GetStudentsCount(); 

    }
}
