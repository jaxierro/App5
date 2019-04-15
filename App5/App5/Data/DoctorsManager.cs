using App5.Droid.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Https.request
{
	public class DoctorsManager
	{
		IRestService restService;

		public DoctorsManager (IRestService service)
		{
			restService = service;
		}

		public Task<List<Doctors>> GetTasksAsync ()
		{
			return restService.RefreshDataAsync ();	
		}
	}
}
