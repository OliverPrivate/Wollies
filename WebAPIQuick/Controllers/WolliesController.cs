
using Microsoft.AspNetCore.Mvc;
using WebAPIQuick.CalcParams;
using WebAPIQuick.Interfaces;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace WebAPIQuick.Controllers
{

    

    [Route("api/[controller]")]
    [ApiController]
    public class WolliesController : ControllerBase
    {
        protected readonly IWolliesManager _wolliesManager;

        public WolliesController(IWolliesManager wolliesManager)
        {
            _wolliesManager = wolliesManager;
        }

        // GET: api/Todo
        /* [HttpGet]
         public async Task<ActionResult<IEnumerable<TodoItem>>> GetTodoItems()
         {
             return await _context.TodoItems.ToListAsync();
         }*/

         // GET: api/Todo/5
        /* [HttpGet("{id}")]
         public async Task<ActionResult<TodoItem>> GetTodoItem(long id)
         {
             var todoItem = await _context.TodoItems.FindAsync(id);

             if (todoItem == null)
             {
                 return NotFound();
             }

             return todoItem;
         }*/

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }


        [HttpGet("[action]")]
         public async Task<int> quickMethod([FromQuery] CalcParams.CalcParams wolliesListFilter)
         {
             return await _wolliesManager.QuickMethod(wolliesListFilter);
         }

        //todo: avoid multiple logins. Better with attribute
         [HttpGet("stuff")]
         public async Task<ActionResult<int>> Stuff([FromQuery]int testint)
         {
             return (testint + 10);
         }


    }






}