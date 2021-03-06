﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Task15_BootcampRefactory.Models;
using Newtonsoft.Json;
using Microsoft.AspNetCore.JsonPatch;

namespace Task15_BootcampRefactory.Controllers
{
    [ApiController]
    [Route("post")]
    public class PostController : Controller
    {
        private readonly PostContext _context;

        public PostController(PostContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var po = _context.post;

            return Ok(new
            {
                message = "success retrieve data",
                status = true,
                data = po
            });
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var po = _context.post.First(i => i.Id == id);

            return Ok(new
            {
                message = "success retrieve data",
                status = true,
                data = po
            });
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var po = _context.post.First(i => i.Id == id);

            _context.post.Remove(po);
            _context.SaveChanges();
            return Ok(po);
        }

        [HttpPatch("{id}")]
        public IActionResult Patch([FromBody]JsonPatchDocument<Posts> pat, int id)
        {
            var po = _context.post.First(i => i.Id == id);
            pat.ApplyTo(po);
            _context.SaveChanges();
            return Ok(po);
        }

        [HttpPost]
        public IActionResult Post(Posts po)
        {
            po = new Posts
            {
                Title = po.Title,
                Content = po.Content,
                Tags = po.Tags,
                Status = po.Status,
                Create_time = DateTime.Now,
                Update_time = DateTime.Now
            };
            _context.post.Add(po);
            _context.SaveChanges();
            return Ok(new
            {
                message = "success retrieve data",
                status = true,
                data = po
            });
        }

    }
}
