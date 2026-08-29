public class StudentService : IStudentService
{
    private readonly IStudentRepository _repository;

    public StudentService(IStudentRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<StudentResponseDto>> GetStudentsAsync()
    {
        var students = await _repository.GetStudentsAsync();

        var response = students.Select(student => new StudentResponseDto
        {
            Id = student.Id,
            Name = student.Name,
            Age = student.Age,
            Course = student.Course,
            Email = student.Email
        }).ToList();

        return response;
    }

    public async Task<Student?> GetStudentByIdAsync(int id)
    {
        return await _repository.GetStudentByIdAsync(id);
    }

    public async Task<StudentResponseDto> AddStudentAsync(CreateStudentDto dto)
    {
        var student = new Student
        {
            Name = dto.Name,
            Age = dto.Age,
            Course = dto.Course,
            Email = dto.Email
        };

        await _repository.AddStudentAsync(student);

        var response = new StudentResponseDto
        {
            Id = student.Id,
            Name = student.Name,
            Age = student.Age,
            Course = student.Course,
            Email = student.Email
        };

        return response;
    }
    public async Task UpdateStudentAsync(Student existingStudent, UpdateStudentDto dto)
    {
        existingStudent.Name = dto.Name;
        existingStudent.Age = dto.Age;
        existingStudent.Course = dto.Course;
        existingStudent.Email = dto.Email;

        await _repository.UpdateStudentAsync(existingStudent);
    }

    public async Task DeleteStudentAsync(int id)
    {
        await _repository.DeleteStudentAsync(id);
    }
}
