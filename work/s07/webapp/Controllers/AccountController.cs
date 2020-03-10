using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using webapp.Models;
using webapp.Services;

namespace webapp.Controllers
{
    [ApiController]
    [Route("[controller]/{id}")]
    public class AccountController : ControllerBase
    {
        public AccountController(JsonFileAccountService accountService)
        {
            AccountService = accountService;
        }

        public JsonFileAccountService AccountService { get; }

        [HttpGet]
         public string Get(int id) {
             var accounts = AccountService.GetAccounts().ToList();

             foreach (var a in accounts) {
                 if(id == a.Number) {
                     List<Account> list = new List<Account>();
                     list.Add(a);
                     var json = JsonSerializer.Serialize<IEnumerable<Account>>(list);
                     return json;
                 }
             }
             return "[{\"error\":\"Account does not exist\"}]";
             
         }
    }
}