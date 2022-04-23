using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class userController : ControllerBase
    {
        private readonly DataContext dataContext;

        public userController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        // GET: user


        // GET: u
        [HttpGet] 
        public async Task < ActionResult <IEnumerable<AppUser>>> allusers()
        {
            return await dataContext.users.ToListAsync();  
        }

        // POST: user/Create
        [HttpGet("{id}")]
        public async Task< ActionResult<AppUser>> user(int id)
        {
            return await dataContext.users.FindAsync(id);
        }
     //   [HttpPost]
       // public ActionResult<AppUser> addUser(AppUser user)
        //{
          //  var users = dataContext.users.Add(user);
          //  return users;
        //}

//        [HttpPut]
  //      public ActionResult<AppUser> updateUser(AppUser user)
    //    {
      //      var users = dataContext.users.Update(user);
        //    return users;
        //}





    }
}