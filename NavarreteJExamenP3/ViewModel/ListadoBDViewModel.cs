using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavarreteJExamenP3.ViewModel
{
    class ListadoBDViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Proyecto> Proyectos { get; set; } = new ObservableCollection<Proyecto>();
            public ListadoBDViewModel()
        {
           _ = CargarProyectos();
        }
        private async Task CargarProyectos()
        {
            var proyectos = await ProyectoService.Instance.ObtenerProyectos();
            Proyectos.Clear();
            foreach (var proyecto in lista)
                Proyectos.Add(proyecto);
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
