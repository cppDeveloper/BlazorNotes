using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using BlazorNotes.Shared;

namespace BlazorNotes.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NoteController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Note> Get()
        {
            return Enumerable.Range(0, 5).Select(i => new Note
            {
                Date = DateTime.Now.Date,
                Author = "Borowy",
                Content = "Fooo"
            }).ToList();
        }
    }
}
