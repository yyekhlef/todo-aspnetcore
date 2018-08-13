using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using aspnetapp.Models;
using aspnetapp.Services;

namespace aspnetapp.Controllers
{
    [Route("api/todos")]
    [ApiExplorerSettings(GroupName = "v1")]
    public class TodoController : Controller
    {
        /// <summary>
        /// Liste les tâches à réaliser
        /// </summary>
        /// <remarks>
        /// Se base sur une liste prédéfinie
        /// </remarks>
        /// <param name="offre">L'offre à valoriser</param>
        /// <returns>Une liste de <see cref="Todo">tâches</see></returns>
        /// <response code="200">Liste des tâches à réaliser</response>
        [HttpGet]
        [ProducesResponseType(typeof(IList<Todo>), 200)]
        public IActionResult Todos()
        {
            return Json(TodoService.FindAll());
        }

        [HttpPost]
        [ProducesResponseType(typeof(Todo), 200)]
        public IActionResult Add([FromBody] Todo todo)
        {
            return Json(TodoService.Add(todo.text));
        }

        [Route("{id}")]
        [HttpPut]
        [ProducesResponseType(typeof(Todo), 200)]
        public IActionResult Update([FromQuery] int id, [FromBody] Todo todo)
        {
            return Json(TodoService.Update(todo));
        }

        [Route("{id}")]
        [HttpDelete]
        [ProducesResponseType(typeof(IList<Todo>), 200)]
        [ProducesResponseType(typeof(void), 404)]
        public IActionResult Remove([FromRoute] int id)
        {
            return Json(TodoService.Remove(id));
        }

    }
}
