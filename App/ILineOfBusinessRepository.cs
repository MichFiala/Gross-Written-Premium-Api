using Domain;

namespace App
{
	public interface ILineOfBusinessRepository
    {
		Task<List<LineOfBusiness>> Get();

		Task<List<LineOfBusiness>> Get(int[] ids);
    }
}