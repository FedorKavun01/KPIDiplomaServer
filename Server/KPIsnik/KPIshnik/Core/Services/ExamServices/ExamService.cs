using System;
using System.Collections.Generic;
using System.Linq;
using KPIsnik.Infrastructure;
using KPIsnik.Infrastructure.DTO;

namespace KPIsnik.Core.Services.ExamServices
{
    public class ExamService : IExamService
    {
        private readonly KPIshnikDBContext _context;

        public ExamService(KPIshnikDBContext context)
        {
            _context = context;
        }

        public List<ExamDTO> GetExams(string id)
        {
            var exams = _context.Exams.ToList().FindAll(exam => exam.groupid == Guid.Parse(id)).ToList();

            var examsDTO = exams.Select(exam =>
                new ExamDTO()
                {
                    ID = exam.id,
                    GroupID = exam.groupid,
                    Name = exam.name,
                    StartTime = exam.starttime,
                    EndTime = exam.endtime,
                    Teacher = exam.teacher,
                    Link = exam.link
                }).ToList();
            
            return examsDTO;
        }
    }
}