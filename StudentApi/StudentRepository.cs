using Microsoft.EntityFrameworkCore;
public class StudentRepository : IStudentRepository
{
    private readonly AppDbContext _dbContext;
    public StudentRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<List<Student>> GetStudentsAsync()
    {
        return await _dbContext.Students.ToListAsync();
    }
    public async Task<Student?> GetStudentByIdAsync(int id)
    {
        return await _dbContext.Students.FindAsync(id);
    }
    public async Task AddStudentAsync(Student student)
    {
        _dbContext.Students.Add(student);
        await _dbContext.SaveChangesAsync();
    }
    public async Task UpdateStudentAsync(Student student)
    {
        _dbContext.Students.Update(student);
        await _dbContext.SaveChangesAsync();
    }
    public async Task DeleteStudentAsync(int id)
    {
        var student = await _dbContext.Students.FindAsync(id);
        if (student != null)
        {
            _dbContext.Students.Remove(student);
        }
        await _dbContext.SaveChangesAsync();
    }
}