﻿
using Application.Dtos;
using Domain.Entites;

namespace Application.IServices;

public interface IStudentService
{
    IEnumerable<StudentsWithCoursesDto> GetAllWithCourses();
}
