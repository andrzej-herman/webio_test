using WebioTestApp.Server.Database.Entities;
using WebioTestApp.Shared.Dtos;

namespace WebioTestApp.Server.DataMapper;

public static class Mapper
{
	public static DataDto Map(TestDatum data)
	{
		return new DataDto
		{
			DataId = data.TestDataId,
			DataName = data.TestDataName,
			DataDate = data.TestDataDate.ToLongDateString()
		};
	}
}