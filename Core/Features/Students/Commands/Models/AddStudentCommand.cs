﻿namespace Core.Features.Students.Commands.Models;

public class AddStudentCommand : IRequest<GenericBaseResponse<int>>
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public string DepartmentId { get; set; }
}
