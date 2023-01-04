using System;
using System.Collections.Generic;
using System.Linq;
using KPIsnik.Domain.Entity;
using KPIsnik.Infrastructure;
using KPIsnik.Infrastructure.DTO;
using Microsoft.AspNetCore.Http;

namespace KPIsnik.Core.Services.LessonServices
{
    public class LessonService : ILessonService
    {
        private readonly KPIshnikDBContext _context;

        public LessonService(KPIshnikDBContext context)
        {
            _context = context;
        }

        public LessonDTO GetLesson(string id)
        {
            var lesson = _context.Lessons.ToList().Find(lesson => lesson.id == Guid.Parse(id));

            if (lesson == null)
            {
                throw new BadHttpRequestException("Incorrect lesson id");
            }

            var lessonDTO = new LessonDTO
            {
                ID = lesson.id,
                GroupID = lesson.groupid,
                Name = lesson.name,
                StartTime = lesson.starttime,
                EndTime = lesson.endtime,
                Teacher = lesson.teacher,
                Link = lesson.link,
                Theme = lesson.theme,
                Homework = lesson.homework
            };

            return lessonDTO;
        }

        public LessonDTO GetCurrentLesson(string groupId)
        {
            var currentTime = DateTime.Now;
            var lesson = _context.Lessons.ToList().Find(lesson => lesson.starttime < currentTime && lesson.endtime > currentTime && lesson.groupid == Guid.Parse(groupId));
            if (lesson == null)
            {
                throw new BadHttpRequestException("Incorrect lesson id");
            }

            var lessonDTO = new LessonDTO
            {
                ID = lesson.id,
                GroupID = lesson.groupid,
                Name = lesson.name,
                StartTime = lesson.starttime,
                EndTime = lesson.endtime,
                Teacher = lesson.teacher,
                Link = lesson.link,
                Theme = lesson.theme,
                Homework = lesson.homework
            };

            return lessonDTO;
        }

        public List<ScheduleDayDTO> GetLessons(string groupId)
        {
            var lessons = _context.Lessons.ToList().FindAll(lesson => lesson.groupid == Guid.Parse(groupId)).ToList();
            var scheduleDaysDTO = new List<ScheduleDayDTO>();
            
            var lessonsDTO = lessons.Select(lesson => new LessonDTO
            {
                ID = lesson.id,
                GroupID = lesson.groupid,
                Name = lesson.name,
                StartTime = lesson.starttime,
                EndTime = lesson.endtime,
                Teacher = lesson.teacher,
                Link = lesson.link,
                Theme = lesson.theme,
                Homework = lesson.homework
            }).ToList();
            
            foreach (LessonDTO lesson in lessonsDTO)
            {
                var scheduleDay = scheduleDaysDTO.Find(scheduleDay =>
                    lesson.StartTime.Day == scheduleDay.Date.Day && lesson.StartTime.Month == scheduleDay.Date.Month &&
                    lesson.StartTime.Year == scheduleDay.Date.Year);
                
                if (scheduleDay == null)
                {
                    var newDay = new ScheduleDayDTO
                    {
                        ID = Guid.NewGuid(),
                        Date = lesson.StartTime,
                        Lessons = new List<LessonDTO> { lesson }
                    };
                    scheduleDaysDTO.Add(newDay);
                }
                else
                {
                    var index = scheduleDaysDTO.IndexOf(scheduleDay);
                    scheduleDaysDTO[index].Lessons.Add(lesson);
                }
            }

            return scheduleDaysDTO;
        }
    }
}