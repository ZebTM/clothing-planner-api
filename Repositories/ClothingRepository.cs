using Microsoft.AspNetCore.Mvc;
using ClothingPlanner.DatabaseContext;
using ClothingPlanner.Models;
using Microsoft.EntityFrameworkCore;

namespace ClothingPlanner.Repository;

public class ClothingRepository : IClothingRepository, IDisposable
{
    private readonly MyDatabaseContext _dbContext;
    private bool disposedValue;

    public ClothingRepository(MyDatabaseContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void DeleteClothing(Clothing clothing)
    {
        
        _dbContext.Clothing.Remove(clothing);
    }

    public async Task<IEnumerable<Clothing>> GetClothingAsync()
    {
        return await _dbContext.Clothing.ToListAsync();
    }

    public async Task<Clothing?> GetClothingByIdAsync(Guid id)
    {
        return await _dbContext.Clothing.FindAsync(id);
    }

    public  void InsertClothing(Clothing clothing)
    {
        _dbContext.Add(clothing);
    }

    public void UpdateClothing(Clothing clothing)
    {
        _dbContext.Clothing.Update(clothing);
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
    // ~ClothingRepository()
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

    public async void SaveAsync()
    {
        await _dbContext.SaveChangesAsync();
    }
}