﻿using Microsoft.AspNetCore.Http;
using SpeakEasyReal.Models;
using SpeakEasyReal.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace SpeakEasyReal.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUser _userRepo;
        public UserController(IUser userRepository)
        {
            _userRepo = userRepository;
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            var users = _userRepo.GetAllUsers();
            return Ok(users);
        }

        [HttpGet("{firebaseId}")]
        public ActionResult Details(string firebaseId)
        {
            var user = _userRepo.GetUserById(firebaseId);

            if(user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        [HttpPost]
        public ActionResult PostUser(User user)
        {
            var newUser = _userRepo.CreateUser(user);
            return Ok(newUser);
        }

        [HttpPut]
        public void PutUser(User user)
        {
            _userRepo.UpdateUser(user);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _userRepo.DeleteUser(id);
        }
    }
}
