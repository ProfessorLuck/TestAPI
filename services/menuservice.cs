using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace testAPI.services
{
   
    public class MenuService{
        private const string menuApiUrl = "URL";
        public async Task<IEnumerable<model.MenuItem>> Update() {
            proxy.MenuProxy proxy = new proxy.MenuProxy();
            var updateGM = await proxy.GetMenu(menuApiUrl);

            repositories.MenuRepository repo = new repositories.MenuRepository(new System.Data.SqlClient.SqlConnection());
            repo.UpdateMenu();
            return updateGM;
        }
    }
}