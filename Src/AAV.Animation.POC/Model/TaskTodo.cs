using MVVM.Common;
using System.Collections.ObjectModel;

namespace AAV.Animation.POC
{
  public class TaskTodo : BindableBase
  {
    string _description;
    bool _isCurrent;
    int _isOptional;

    public string TaskName { get => _description; set => Set(ref _description, value); }
    public bool IsCurrent { get => _isCurrent; set => Set(ref _isCurrent, value); }
    public int Priority { get => _isOptional; set => Set(ref _isOptional, value); }
  }

  public class TaskTodoCollection : ObservableCollection<TaskTodo> { } //tu: sample data population of a collection
}
