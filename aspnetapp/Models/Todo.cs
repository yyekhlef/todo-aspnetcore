using System;

namespace aspnetapp.Models
{
  public class Todo : IEquatable<Todo>
  {
    public string text { get; set; }
    public bool completed { get; set; } = false;
    public int id { get; set; }

    public bool Equals(Todo other)
    {
      if(other == null)
        return false;

      return text.Equals(other.text) && completed == other.completed && id == other.id;
    }

    public override int GetHashCode()
    {
      int hashText = text == null ? 0 : text.GetHashCode();
      int hashCompleted = completed.GetHashCode();
      int hashId = id.GetHashCode();

      return hashText ^ hashCompleted ^ hashId;
    }

  }
}