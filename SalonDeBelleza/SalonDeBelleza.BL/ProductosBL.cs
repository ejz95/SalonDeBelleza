﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonDeBelleza.BL
{
    public class ProductosBL
    {
        Contexto _contexto;

        public List<Producto> ListadeProductos { get; set; }

        public ProductosBL()
        {
            _contexto = new Contexto();
            ListadeProductos = new List<Producto>();
        }


        public  List<Producto> ObtenerProductos()
        {
            ListadeProductos = _contexto.Productos
             .Include("Categoria")
             .OrderBy(r => r.Categoria.Descripcion)
             .ThenBy(r => r.Descripcion)
             .ToList();

            return ListadeProductos;
        }

        public List<Producto> ObtenerProductosActivos()
        {
            ListadeProductos = _contexto.Productos
             .Include("Categoria")
             .Where(r => r.Activo == true)
             .OrderBy(r => r.Descripcion)
             .ToList();
            return ListadeProductos;
        }

        public void  GuardarProducto(Producto producto)
        {
            if (producto.Id == 0)
            {
                _contexto.Productos.Add(producto);
            } else
            {
                var productoExistente = _contexto.Productos.Find(producto.Id);

                productoExistente.Descripcion = producto.Descripcion;
                productoExistente.CategoriaId = producto.CategoriaId;
                productoExistente.Precio = producto.Precio;
                productoExistente.UrlImagen = producto.UrlImagen;
                productoExistente.UrlImagen = producto.UrlImagen;
                productoExistente.UrlImagen = producto.UrlImagen;
                productoExistente.UrlImagen = producto.UrlImagen;
                
               
            }

            _contexto.SaveChanges();
        }

        public Producto ObtenerProducto(int id)
        {
            var producto = _contexto.Productos
                .Include("Categoria").FirstOrDefault(p => p.Id == id);

            return producto;
        }

        public void EliminarProducto(int id)
        {

            var producto = _contexto.Productos.Find(id);

            _contexto.Productos.Remove(producto);
            _contexto.SaveChanges();
        }
    }
}
