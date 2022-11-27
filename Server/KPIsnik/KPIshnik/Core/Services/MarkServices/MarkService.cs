using System;
using System.Collections.Generic;
using System.Linq;
using KPIsnik.Infrastructure;
using KPIsnik.Infrastructure.DTO;

namespace KPIsnik.Core.Services.MarkServices
{
    public class MarkService : IMarkService
    {
        private readonly KPIshnikDBContext _context;

        public MarkService(KPIshnikDBContext context)
        {
            _context = context;
        }

        public List<MarkDTO> GetMarks(string studentId)
        {
            var marks = _context.Marks.ToList().FindAll(mark => mark.studentid == Guid.Parse(studentId)).ToList();

            var marksDTO = marks.Select(mark =>
                new MarkDTO
                {
                    ID = mark.id,
                    StudentId = mark.studentid,
                    Name = mark.name,
                    Mark = mark.mark,
                    Teacher = mark.teacher
                }).ToList();

            return marksDTO;
        }
    }
}