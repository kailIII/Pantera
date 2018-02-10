﻿using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public abstract class maestrodetalleDL
    {
        public static List<maestrodetalle> buscarPorCodigoMaestro(int codigomaestro)
        {
            using (IDataReader datareader = conexion.executeOperation("fn_maestrodetalle_buscar_por_codigomaestro", CommandType.StoredProcedure, new parametro("in_codigomaestro", codigomaestro)))
            {
                List<maestrodetalle> listado = new List<maestrodetalle>();
                while (datareader.Read())
                {
                    maestrodetalle registro = new maestrodetalle();
                    registro.idmaestrodetalle = Convert.ToInt32(datareader["idmaestrodetalle"]);
                    registro.idmaestro = Convert.ToInt32(datareader["idmaestro"]);
                    registro.codigoitem = Convert.ToString(datareader["codigoitem"]).Trim();
                    registro.nombreitem = Convert.ToString(datareader["nombreitem"]).Trim();
                    registro.libre = Convert.ToString(datareader["libre"]).Trim();
                    listado.Add(registro);
                }
                return listado;
            }
        }
        public static List<categoria> ListarCategorias()
        {
            using (IDataReader datareader = conexion.executeOperation("fn_categorias_listar", CommandType.StoredProcedure))
            {
                List<categoria> listado = new List<categoria>();
                while (datareader.Read())
                {
                    categoria catelist = new categoria();
                    catelist.p_inidcategoria = Convert.ToInt32(datareader["p_inidcategoria"]);
                    catelist.chcategoria = Convert.ToString(datareader["chcategoria"]).Trim();
                    listado.Add(catelist);
                }
                return listado;
            }
        }
        public static List<tipo> buscarTipoPorCategoria(string codigomaestro)
        {
            using (IDataReader datareader = conexion.executeOperation("fn_TipoListarPorCategoriaN", CommandType.StoredProcedure, new parametro("in_p_inidcategoria", codigomaestro)))
            {
                List<tipo> listado = new List<tipo>();
                while (datareader.Read())
                {
                    tipo registro = new tipo();
                    registro.p_inidtipo = Convert.ToInt32(datareader["p_inidtipo"]);
                    registro.chtipo = Convert.ToString(datareader["chtipo"]).Trim();
                    listado.Add(registro);
                }
                return listado;
            }
        }
        

    }
}