using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonDeBelleza.BL
{
    public class ProductosBL
    {
        public List<Producto> ObtenerProductos()
        {
            var producto1 = new Producto();
            producto1.Id = 1;
            producto1.Descripcion = "Lavado y Secado";
            producto1.Precio = 150.00;

            var producto2 = new Producto();
            producto2.Id = 2;
            producto2.Descripcion = "Lavado, Tratamiento y planchado";
            producto2.Precio = 250.00;

            var producto3 = new Producto();
            producto3.Id = 3;
            producto3.Descripcion = "Corte";
            producto3.Precio = 150.00;


            var producto4 = new Producto();
            producto4.Id = 4;
            producto4.Descripcion = "Lavado, Corte y Planchado";
            producto4.Precio = 350.00;

            var producto5 = new Producto();
            producto5.Id = 5;
            producto5.Descripcion = "Lavado, Corte, Tratamiento y planchado";
            producto5.Precio = 400.00;


            var producto6 = new Producto();
            producto6.Id = 6;
            producto6.Descripcion = "Tinte Completo";
            producto6.Precio = 850.00;

            var producto7 = new Producto();
            producto7.Id = 7;
            producto7.Descripcion = "Retoque de Tinte";
            producto7.Precio = 500.00;

            var producto8 = new Producto();
            producto8.Id = 8;
            producto8.Descripcion = "Keratina";
            producto8.Precio = 850.00;

            var producto9 = new Producto();
            producto9.Id = 9;
            producto9.Descripcion = "Células Madres";
            producto9.Precio = 1100.00;

            var producto10 = new Producto();
            producto10.Id = 10;
            producto10.Descripcion = "Alisado";
            producto10.Precio = 1200.00;

            var producto11 = new Producto();
            producto11.Id = 11;
            producto11.Descripcion = "Nanoplástia";
            producto11.Precio = 1200.00;

            var producto12 = new Producto();
            producto12.Id = 12;
            producto12.Descripcion = "Botox";
            producto12.Precio = 850.00;

            var producto13 = new Producto();
            producto13.Id = 13;
            producto13.Descripcion = "Senscience CPR";
            producto13.Precio = 350.00;

            var producto14 = new Producto();
            producto14.Id = 14;
            producto14.Descripcion = "Manicure";
            producto14.Precio = 250.00;

            var producto15 = new Producto();
            producto15.Id = 15;
            producto15.Descripcion = "Manicure Spa";
            producto15.Precio = 300.00;

            var producto16 = new Producto();
            producto16.Id = 16;
            producto16.Descripcion = "Pedicura";
            producto16.Precio = 250.00;

            var producto17 = new Producto();
            producto17.Id = 17;
            producto17.Descripcion = "Pedicura Spa";
            producto17.Precio = 300.00;

            var listadeProductos = new List<Producto>();
            listadeProductos.Add(producto1);
            listadeProductos.Add(producto2);
            listadeProductos.Add(producto3);
            listadeProductos.Add(producto4);
            listadeProductos.Add(producto5);
            listadeProductos.Add(producto6);
            listadeProductos.Add(producto7);
            listadeProductos.Add(producto8);
            listadeProductos.Add(producto9);
            listadeProductos.Add(producto10);
            listadeProductos.Add(producto11);
            listadeProductos.Add(producto12);
            listadeProductos.Add(producto13);
            listadeProductos.Add(producto14);
            listadeProductos.Add(producto15);
            listadeProductos.Add(producto16);
            listadeProductos.Add(producto17);

            return listadeProductos;
        }
    }
}