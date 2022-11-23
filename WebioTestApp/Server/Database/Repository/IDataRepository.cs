using WebioTestApp.Server.Database.Entities;
using WebioTestApp.Shared.Dtos;

namespace WebioTestApp.Server.Database.Repository;

public interface IDataRepository
{
	Task<IEnumerable<DataDto>> GetDataAsync(int count, int offset);
}