using ApplicationCore.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEB.Areas.Education.Models.ViewModels.Courses
{
    public class GetCourseVM
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? TotalHour { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedDate { get; set; }
        public string Status { get; set; }
    }
}
