namespace User;

using DTO.User;
using Models;


public class UserService
{
    private readonly AppDbContext _db;

    public UserService(AppDbContext db)
    {
        _db = db;
    }

    public List<UserModel> GetAll()
    {
        return _db.Users.ToList();
    }

    public UserModel Create(CreateUserDto dto)
    {
        var user = new UserModel { Name = dto.Name, Email = dto.Email, Password = dto.Password, Role = dto.Role };

        try
        {
            _db.Users.Add(user);
            _db.SaveChanges();
        }
        catch (System.Exception)
        {

            throw;
        }

        return user;
    }
}