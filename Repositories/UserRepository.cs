using ClothingPlanner.DatabaseContext;
using ClothingPlanner.Models;

namespace ClothingPlanner.Repository;

public class UserRepository : IUserRepository, IDisposable
{
    private readonly MyDatabaseContext _dbContext;
    private bool disposedValue;

    public UserRepository(MyDatabaseContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void AddUserClothing(Guid userId, Clothing clothing)
    {
        throw new NotImplementedException();
    }

    public void DeleteUser(Guid id)
    {
        throw new NotImplementedException();
    }

    public User GetUserById(Guid id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<User> GetUsers()
    {
        throw new NotImplementedException();
    }

    public void InsertUser(User user)
    {
        throw new NotImplementedException();
    }

    public void RemoveUserClothing(Guid userId, Guid clothingId)
    {
        throw new NotImplementedException();
    }

    public void UpdateUser(User user)
    {
        throw new NotImplementedException();
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposedValue)
        {
            if (disposing)
            {
                // TODO: dispose managed state (managed objects)
            }

            // TODO: free unmanaged resources (unmanaged objects) and override finalizer
            // TODO: set large fields to null
            disposedValue = true;
        }
    }

    // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
    // ~UserRepository()
    // {
    //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
    //     Dispose(disposing: false);
    // }

    public void Dispose()
    {
        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
}