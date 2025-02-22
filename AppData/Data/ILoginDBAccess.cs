﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Data
{
    public interface ILoginDBAccess
    {
        Task<IEnumerable<T>> GetData<T, P>(string query, P parameters,
            string connectionId = "LoginDBConnectionString"
            );
        Task SaveData<P>
            (string query, P parameters, string connectionId = "LoginDBConnectionString");
    }
}
