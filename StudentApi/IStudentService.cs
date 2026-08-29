public interface IStudentService
{
    Task<List<StudentResponseDto>> GetStudentsAsync();
    Task<Student?> GetStudentByIdAsync(int id);
    Task<StudentResponseDto> AddStudentAsync(CreateStudentDto dto);
    Task UpdateStudentAsync(Student existingStudent, UpdateStudentDto dto);
    Task DeleteStudentAsync(int id);
}