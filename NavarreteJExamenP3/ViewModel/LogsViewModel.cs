using NavarreteJExamenP3.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AndroidX.ConstraintLayout.Core.Motion.Utils.HyperSpline;

namespace NavarreteJExamenP3.ViewModel
{
    class LogsViewModel: INotifyPropertyChanged
    {
        public ObservableCollection<string> RegistroLogs { get; set; } = new ObservableCollection<string>();
        public LogsViewModel()
        {
            _ = CargarLogs();
        }
        private async Task CargarLogs()
        {
            var lineas = await LogService.Instance.LeerLogs();
            RegistroLogs.Clear();
            foreach (var log in lineas)
                RegistroLogs.Add(lineas);
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
