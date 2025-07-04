﻿using CadParcial2Bss;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnParcial2Bss
{
    public class SerieCln
    {
        public static int Insertar(Serie serie)
        {
            using (var context = new Parcial2BssEntities())
            {
                context.Serie.Add(serie);
                context.SaveChanges();
                return serie.id;
            }
        }

        public static int Actualizar(Serie serie)
        {
            using (var context = new Parcial2BssEntities())
            {
                var existente = context.Serie.Find(serie.id);
                existente.titulo = serie.titulo;
                existente.sinopsis = serie.sinopsis;
                existente.director = serie.director;
                existente.episodios = serie.episodios;
                existente.fechaEstreno = serie.fechaEstreno;
                existente.urlPortada = serie.urlPortada;
                existente.idiomaOriginal = serie.idiomaOriginal;
                return context.SaveChanges();
            }
        }

        public static int Eliminar(int id)
        {
            using (var context = new Parcial2BssEntities())
            {
                var serie = context.Serie.Find(id);
                serie.estado = -1;
                return context.SaveChanges();
            }
        }

        public static Serie ObtenerUno(int id)
        {
            using (var context = new Parcial2BssEntities())
            {
                return context.Serie.Find(id);
            }
        }

        public static List<Serie> Listar()
        {
            using (var context = new Parcial2BssEntities())
            {
                return context.Serie.Where(x => x.estado != -1).ToList();
            }
        }

        public static List<paSerieListar_Result> ListarPa(string parametro)
        {
            using (var context = new Parcial2BssEntities())
            {
                return context.paSerieListar(parametro).ToList();
            }
        }
    }
}
