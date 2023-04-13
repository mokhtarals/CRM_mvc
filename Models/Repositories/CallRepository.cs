using CRM_mvc.Context;
using CRM_mvc.Models.Entities;
using CRM_mvc.Models.Repositories.Interfaces;
using CRM_mvc.Utilities.Enumerations;

namespace CRM_mvc.Models.Repositories;

public class CallReporsitory : ICallRepository
{
    private readonly ApplicationDbContext _context;

    public CallReporsitory(ApplicationDbContext context)
    {
        _context = context;
    }

    public DbStatus DeleteCall(int callID)
    {
        Call? call = WithoutTrashed().First(v => v.Id == callID);
        if (call != null)
        {
            call.DeletedAt = DateTime.Now;
            return Save();
        }
        return DbStatus.FAILS;
    }

    public DbStatus RestoreCall(int callID)
    {
        Call? call = WithTrashed().FirstOrDefault(v => v.Id == callID);
        if (call != null && call.DeletedAt.Equals(null))
        {
            call.DeletedAt = null;
            return Save();
        }
        return DbStatus.FAILS;
    }

    public Call? GetCallByID(int callID)
    {
        if (WithTrashed().Any(v => v.Id == callID))
        {
            return null;
        }
        return _context.Calls.Find(callID);
    }

    public IEnumerable<Call> GetCalls()
    {
        throw new NotImplementedException();
    }

    public Call InsertCall(Call call)
    {
        throw new NotImplementedException();
    }

    public DbStatus Save()
    {
        int save = _context.SaveChanges();
        if (save == 0)
        {
            return DbStatus.FAILS;
        }
        return DbStatus.SUCCESSED;
    }

    public DbStatus UpdateCall(Call call)
    {
        throw new NotImplementedException();
    }

    public IQueryable<Call> WithTrashed()
    {
        return _context.Calls.Where(v => v.DeletedAt.Equals(null));
    }

    public IQueryable<Call> WithoutTrashed()
    {
        return _context.Calls.Where(v => !v.DeletedAt.Equals(null));
    }


}