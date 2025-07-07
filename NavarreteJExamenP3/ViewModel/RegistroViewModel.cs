using NavarreteJExamenP3.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NavarreteJExamenP3.ViewModel
{
    class RegistroViewModel : INotifyPropertyChanged
    {
        public Proyecto Proyecto { get; set; }= new Proyecto();
        public ICommand GuardarCommand { get; }
        public RegistroViewModel()
        {
            GuardarCommand = new Command(async () => await Guardar());    
        }
        private async Task Guardar()
        {
            if (Proyecto.Progreso > 50 && Proyecto.DuracionDias < 365)
            {
                await Shell.Current.DisplayAlert("Error", "El progreso no puede ser mayor al 50% si la duración es menor a 365 días.", "OK");
                return;
            }
            await ProyectoService.Instance.AgregarProyecto(Proyecto);
            await LogService.Instance.AppendLog(Proyecto.NombreProyecto);
            await Shell.Current.DisplayAlert("Exito","Proyecto Guardado");

            Proyecto = new Proyecto(); 
            OnPropetyChanged(nameof(Proyecto));
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropetyChanged(string name) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));


    }
}
