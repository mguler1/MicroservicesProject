﻿using FreeCourse.Shared.Dtos;
using FreeCourseServices.Catalog.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeCourseServices.Catalog.Services
{
   public interface ICourseService
    {
        Task<Response<List<CourseDto>>> GetAllAsync();
        Task<Response<CourseDto>> GetByIdAsync(string id);
        Task<Response<CourseDto>> CreateAsync(CourseCreateDto courseCreateDto);
        Task<Response<List<CourseDto>>> GetAllByUserIdAsync(string userId);
        Task<Response<NoContent>> UpdateAsync(CourseUpdateDto courseUpdateDto);
        Task<Response<NoContent>> DeleteAsync(string id);
    }
}
