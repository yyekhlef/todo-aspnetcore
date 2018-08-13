using System;
using System.Linq;
using System.Collections.Generic;
using aspnetapp.Models;

namespace aspnetapp.Services
{

    public static class TodoService
    {
      private static IList<Todo> todos;

      static TodoService() {
        todos = new List<Todo> {
          new Todo{ id = 0, text="Fermer cette tâche", completed= true},
          new Todo{ id = 1, text="Ajouter une action", completed= false},
          new Todo{ id = 2, text="Ajouter un reducer", completed= false},
          new Todo{ id = 3, text="Faire un appel d'API", completed= false},
        };
      }

      public static IList<Todo> FindAll()
      {
        return todos;
      }

      public static Todo Add(string text)
      {
        Todo todo = new Todo { id= newId(), text= text};
        todos.Add(todo);
        return todo;
      }

      public static Todo Update(Todo todoUpdated)
      {
        Todo todo = todos.Where(t => t.id == todoUpdated.id).First();
        todo.text = todoUpdated.text;
        todo.completed = todoUpdated.completed;
        return todo;
      }

      public static IList<Todo> Remove(int id)
      {
        todos = todos.Where(t => t.id != id).ToList();
        return todos;
      }

      private static int newId() 
      {
        return todos.Select(t=> t.id).Max() + 1;
      } 


    }
}