using System.Collections.Generic;
using System.Threading.Tasks;
using KPIsnik.Core.Services.LessonServices;
using KPIsnik.Infrastructure.DTO;
using Microsoft.AspNetCore.Mvc;

namespace KPIsnik.Infrastructure.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LessonController
    {
        private readonly ILessonService _lessonService;

        public LessonController(ILessonService lessonService)
        {
            _lessonService = lessonService;
        }

        [HttpGet("GetLesson")]
        public async Task<LessonDTO> GetLesson(string id) => _lessonService.GetLesson(id);
        
        [HttpGet("GetCurrentLesson")]
        public async Task<LessonDTO> GetCurrentLesson(string groupId) => _lessonService.GetCurrentLesson(groupId);
        
        [HttpGet("GetLessons")]
        public async Task<List<LessonDTO>> GetLessons(string groupId) => _lessonService.GetLessons(groupId);
    }
}