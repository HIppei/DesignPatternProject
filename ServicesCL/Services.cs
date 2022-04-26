using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesCL;

namespace ServicesCL
{
    public interface ICourseService
    {
        Course GetCourseByID(long courseID);
    }

    public class CourseService : ICourseService
    {
        public Course GetCourseByID(long courseID)
        {
            return new Course
            {
                CourseID = courseID,
                Description = "Demo course description",
                InstitutionID = 1,
                Title = "Demo Course Title"
            };
        }
    }

    public interface IInstitutionService
    {
        Institution GetInstitutionByID(long institutionID);
    }

    public class InstitutionService : IInstitutionService
    {
        public Institution GetInstitutionByID(long institutionID)
        {
            return new Institution
            {
                InstitutionID = institutionID,
                Name = "Demo Institution",
                Address = "Demo Address",
                Telephone = "0123456789"
            };
        }
    }
}
