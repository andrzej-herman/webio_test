using Microsoft.EntityFrameworkCore;
using WebioTestApp.Server.Database.BaseContext;
using WebioTestApp.Server.DataMapper;
using WebioTestApp.Shared.Dtos;

namespace WebioTestApp.Server.Database.Repository;

public class DataRepository : IDataRepository
{
	private readonly TestContext _context;

	public DataRepository(TestContext context)
	{
		_context = context;
	}
	
	public async Task<IEnumerable<DataDto>> GetDataAsync(int count, int offset)
	{
		var test = await _context.TestData.FromSqlRaw(
				@$"SELECT TestDataId, TestDataName, TestDataDate 
			   FROM aherman_admin_test.TestData 
			   ORDER BY TestDataName 
			   OFFSET {(offset - 1) * count} ROWS FETCH NEXT {count} ROWS ONLY")
			.Select(td => Mapper.Map(td))
			.ToArrayAsync();

		return test;

	}
}