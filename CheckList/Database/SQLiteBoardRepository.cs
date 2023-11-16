using CheckList.Database.Entities;
using CheckList.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CheckList.Database;

internal class SQLiteBoardRepository : IRepository<Board>
{
    private ApplicationContext _db;

    public SQLiteBoardRepository(ApplicationContext context)
    {
        _db = context;
    }

    public async void CreateAsync(Board item)
    {
        await _db.Boards.AddAsync(item);
        SaveAsync();
    }

    public async void CreateAsync(IEnumerable<Board> item)
    {
        await _db.Boards.AddRangeAsync(item);
    }

    public async void Delete(int id)
    {
        Board? board = await _db.Boards.FindAsync(id);
        if (board != null)
        {
            _db.Boards.Remove(board);
        }
    }

    public async Task<Board> GetByIdAsync(int id)
    {
        var a = await _db.Boards.FindAsync(id);
        return a;
    }

    public async Task<IEnumerable<Board>> GetEntityListAsync()
    {
        return _db.Boards;
    }

    public async void SaveAsync()
    {
        await _db.SaveChangesAsync();
    }

    public void UpdateAsync(Board board)
    {
        _db.Entry(board).State = EntityState.Modified;
    }

    public void Dispose()
    {
        DisposeAsync(true);
        GC.SuppressFinalize(this);
    }
        
    private bool _disposed = false;

    public virtual void DisposeAsync(bool disposing)
    {
        if (!this._disposed)
        {
            if (disposing)
            {
                _db.DisposeAsync();
            }
        }
        _disposed = true;
    }

}

