using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace distancia5834249
{
    public partial class DistanciaModelo : ObservableObject
    {
        [ObservableProperty]
        public string? x1;

        [ObservableProperty]
        public string? x2;

        [ObservableProperty]
        public string? y1;

        [ObservableProperty]
        public string? y2;

        [ObservableProperty]
        public double sumaxy;

        [ObservableProperty]
        public double restax;

        [ObservableProperty]
        public double restay;

        [ObservableProperty]
        public double cuadradox;

        [ObservableProperty]
        public double cuadradoy;

        [ObservableProperty]
        public string? distancia;

        [RelayCommand]
        private void ActualizarDatos()
        {
            if (double.TryParse(X1, out double x1) && double.TryParse(X2, out double x2)
                && double.TryParse(Y1, out double y1) && double.TryParse(Y2, out double y2))
            {
                Restax = x1 - x2;
                Restay = y1 - y2;
                Cuadradox = Math.Pow(Restax, 2);
                Cuadradoy = Math.Pow(Restay, 2);
                Sumaxy = Cuadradox + Cuadradoy;
                Distancia = Math.Sqrt(Sumaxy).ToString();
            }
            else
            {
                Distancia = "Digite valores numericos";
            }
        }
    }
}
