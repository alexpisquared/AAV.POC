using System.Collections.ObjectModel;
using MVVM.Common;

namespace AAV.Animation.POC
{
    public class ViewModel : BindableBase
    {
        ObservableCollection<TaskTodo> _tt = new ObservableCollection<TaskTodo> { new TaskTodo { IsCurrent = true, Priority = 62, TaskName = "Nam vestibulum" }, new TaskTodo { IsCurrent = false, Priority = 64, TaskName = "Class sed curabitur phasellus aenean" }, new TaskTodo { IsCurrent = true, Priority = 69, TaskName = "Mauris adipiscing nullam" }, new TaskTodo { IsCurrent = false, Priority = 88, TaskName = "Aptent cras" }, new TaskTodo { IsCurrent = true, Priority = 42, TaskName = "Maecenas duis consequat convallis parturient" }, new TaskTodo { IsCurrent = false, Priority = 97, TaskName = "Curae vestibulum nunc aliquam amet" }, };


        public ObservableCollection<TaskTodo> TaskTodos { get => _tt; set => _tt = value; }

        bool _isBusy = false; public bool IsBusy { get => _isBusy; set => Set<bool>(ref _isBusy, value); }

    }
}
