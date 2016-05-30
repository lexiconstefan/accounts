using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Accounts.Entities;

namespace Accounts.Web.DataContext
{
    public class AccountsDb : DbContext
    {
        public AccountsDb()
            : base("DefaultcConnection")
        {

        }
        DbSet<Account> Accounts { get; set; }
    }
}