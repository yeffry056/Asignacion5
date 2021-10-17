using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignacion5
{
    public class Cap10
    {
       
    }
    public class Inventario
    {
        private string producto;
        private int cantidadProducto;
        private int PrecioVenta;
        private int PrecioCompra;

        public Inventario(string producto, int cantidadProducto, int PrecioVenta, int PrecioCompra)
        {
            this.cantidadProducto = cantidadProducto;
            this.PrecioCompra = PrecioCompra;
            this.PrecioVenta = PrecioVenta;
            this.producto = producto;
        }
        public string Producto { get; set; }
        public int CantidadProducto { get; set; }
        public int precioVenta { get; set; }
        public int precioCompra { get; set; }
    }
    public class Estudiante
    {
        public int matricula { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string tutor { get; set; }
        public string asignatura { get; set; }
        public int CantidadAsignatura { get; set; }

        public Estudiante(int matricula, string nombre, string apellido, string tutor, string asignatura, int CantidadAsignatura)
        {
            this.matricula = matricula;
            this.nombre = nombre;
            this.apellido = apellido;
            this.tutor = tutor;
            this.asignatura = asignatura;
            this.CantidadAsignatura = CantidadAsignatura;
        }
    }
    public class Poligonos
    {
        
        private int altura;
        private int ancho;
        private int basee;
        private int lado;
        
         
        public Poligonos(int altura)
        {
            this.altura = altura;
        }
        public Poligonos(int altura, int basee)
        {
            this.altura = altura;
            this.basee = basee;
        }
        public Poligonos(int altura, int basee, int lado)
        {
            this.altura = altura;
            this.basee = basee;
            this.lado = lado;
        }
        public void SetAlturo(int altura)
        {
            if (altura > 0)
                this.altura = altura;
        }
        public void SetLado(int lado)
        {
            if (lado > 0)
                this.lado = lado;
        }
        public void SetBase(int basee)
        {
            if (basee > 0)
                this.basee = basee;
        }
        public void SetAncho(int ancho)
        {
            if (ancho > 0)
                this.ancho = ancho;
        }


        public int getAlturo()
        {
            return altura;
        }
        public int getLado()
        {
            return lado;
        }
        public int getBase()
        {
            return basee;
        }
        public int getAncho()
        {
            return ancho;
        }


        public override string ToString()
        {
            String mensaje = "";
            mensaje += "Ancho: " +ancho.ToString() + "Altura: " +
           altura.ToString() + "Base: " +basee.ToString() + "Lado: " + lado.ToString();
            
            return mensaje;
        }
    }

}
