using Microsoft.AspNetCore.Mvc;
[ApiController]
[Route("api/[controller]")]
public class StudentController : ControllerBase
{
    private readonly StudentService _studentService;

    public StudentController(StudentService studentService)
    {
        _studentService = studentService;
    }   


    [HttpGet]
    public async Task<IActionResult> GetStudents()
    {
        var students = await _studentService.GetStudentsAsync();
        return Ok(students);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetStudentById(int id)
    {
        var student = await _studentService.GetStudentByIdAsync(id);
        if (student == null)
        {
            return NotFound();
        }
        return Ok(student);
    }

    [HttpPost]
    public async Task<IActionResult> AddStudent(CreateStudentDto dto)
    {
        if (dto == null)
        {
            return BadRequest();
        }

        var response = await _studentService.AddStudentAsync(dto);

        return Ok(response);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateStudent(int id, UpdateStudentDto dto)
    {
        var existingStudent = await _studentService.GetStudentByIdAsync(id);

        if (existingStudent == null)
        {
            return NotFound();
        }

        await _studentService.UpdateStudentAsync(existingStudent, dto);

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteStudent(int id)
    {
        var existingStudent = await _studentService.GetStudentByIdAsync(id);
        if (existingStudent == null)
        {
            return NotFound();
        }

        await _studentService.DeleteStudentAsync(id);

        return NoContent();
    }
}
