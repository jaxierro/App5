using App5.Droid.Model.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Https.request
{
	public interface IRestService
	{
		Task<List<Doctors>> RefreshDataAsync ();
	}
}
