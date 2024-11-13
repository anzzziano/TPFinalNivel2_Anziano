using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ArticuloData
    {

        public List<Articulo> listar()
        {

            List<Articulo> listaArticulo = new List<Articulo>();

            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT A.Id,Codigo, Nombre,A.Descripcion, ImagenUrl ,Precio, C.Descripcion as Categoria,M.Descripcion AS Marca, A.IdMarca, A.IdCategoria FROM dbo.ARTICULOS A JOIN dbo.CATEGORIAS C ON C.Id = A.IdCategoria  JOIN dbo.MARCAS M  ON M.Id = A.IdMarca");



                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();

                    aux.Id = (int)datos.Lector["Id"];
                    aux.CodigoArt = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    if(!(datos.Lector.IsDBNull(datos.Lector.GetOrdinal("ImagenUrl"))))
                        aux.Imagen = (string)datos.Lector["ImagenUrl"];

                    aux.Precio = (decimal)datos.Lector["Precio"];

                    aux.Categoria = new Categoria
                    {
                        Id = (int)datos.Lector["IdCategoria"],
                        Descripcion = (string)datos.Lector["Categoria"]
                    };

                    aux.Marca = new Marca
                    {
                        Id = (int)datos.Lector["IdMarca"],
                        Descripcion = (string)datos.Lector["Marca"]
                    };

                    listaArticulo.Add(aux);
                }

                return listaArticulo;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

                datos.cerrarConexion();

            }

        }

        public void agregarArticulo(Articulo nuevo)
        {

            AccesoDatos datos = new AccesoDatos();

            try
            {

                datos.setearConsulta("insert into ARTICULOS(Codigo,Nombre,Descripcion,ImagenUrl,Precio,IdMarca,IdCategoria) values(@Codigo,@Nombre,@Descripcion,@ImagenUrl,@Precio,@IdMarca,@IdCategoria)");
                datos.setearParametro("@Codigo", nuevo.CodigoArt);
                datos.setearParametro("@Nombre", nuevo.Nombre);
                datos.setearParametro("@Descripcion", nuevo.Descripcion);
                datos.setearParametro("@ImagenUrl", nuevo.Imagen);
                datos.setearParametro("@Precio", nuevo.Precio);
                datos.setearParametro("@IdMarca", nuevo.Marca.Id);
                datos.setearParametro("@IdCategoria", nuevo.Categoria.Id);

                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

        }

        public void modificar(Articulo art)
        {

            AccesoDatos datos = new AccesoDatos();

            try
            {

                datos.setearConsulta("  update ARTICULOS set Codigo = @Codigo,Nombre = @Nombre,Descripcion = @Descripcion,IdMarca = @IdMarca,IdCategoria = @IdCategoria,ImagenUrl = @ImagenUrl, Precio = @Precio where Id = @Id");
                datos.setearParametro("@Codigo", art.CodigoArt);
                datos.setearParametro("@Nombre", art.Nombre);
                datos.setearParametro("@Descripcion", art.Descripcion);
                datos.setearParametro("@IdMarca", art.Marca.Id);
                datos.setearParametro("@IdCategoria", art.Categoria.Id);
                datos.setearParametro("@ImagenUrl", art.Imagen);
                datos.setearParametro("@Precio", art.Precio);
                datos.setearParametro("@Id", art.Id);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void eliminar(int id)
        {

            try
            {

                AccesoDatos datos = new AccesoDatos();

                datos.setearConsulta("delete from ARTICULOS where Id = @Id ");
                datos.setearParametro("@Id", id);

                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<Articulo> filtrar(string campo, string criterio, string filtro)
        {

            List<Articulo> listaArticulo = new List<Articulo>();
            AccesoDatos accesoDatos = new AccesoDatos();

            try
            {

                string consulta = "SELECT A.Id Id,Codigo,Nombre,A.Descripcion Descripcion,ImagenUrl,Precio,C.Descripcion Categoria,M.Descripcion Marca,A.IdCategoria,A.IdMarca FROM dbo.ARTICULOS A JOIN  dbo.CATEGORIAS C ON C.Id = A.IdCategoria JOIN  dbo.MARCAS M ON M.Id = A.IdMarca where  ";

                if (campo == "Categoria")
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += " C.Descripcion like '" + filtro + "%'";
                            break;
                        case "Termina con":
                            consulta += " C.Descripcion like '%" + filtro + "'";
                            break;
                        default:
                            consulta += " C.Descripcion like '%" + filtro + "%'";
                            break;
                    }
                }
                if (campo == "Precio")
                {
                    switch (criterio)
                    {
                        case "Mayor a":
                            consulta += " Precio > " + filtro;
                            break;
                        case "Menor a":
                            consulta += " Precio  < " + filtro;
                            break;
                        default:
                            consulta += " Precio = " + filtro;
                            break;
                    }
                }
                else if(campo == "Marca")
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += " M.Descripcion like '" + filtro + "%'";
                            break;
                        case "Termina con":
                            consulta += " M.Descripcion like '%" + filtro + "'";
                            break;
                        default:
                            consulta += " M.Descripcion like '%" + filtro + "%'";
                            break;
                    }

                }

                accesoDatos.setearConsulta(consulta);
                accesoDatos.ejecutarLectura();

                while (accesoDatos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)accesoDatos.Lector["Id"];
                    aux.CodigoArt = (string)accesoDatos.Lector["Codigo"];
                    aux.Nombre = (string)accesoDatos.Lector["Nombre"];
                    aux.Descripcion = (string)accesoDatos.Lector["Descripcion"];

                    if (!(accesoDatos.Lector.IsDBNull(accesoDatos.Lector.GetOrdinal("ImagenUrl"))))
                        aux.Imagen = (string)accesoDatos.Lector["ImagenUrl"];

                    aux.Precio = (decimal)accesoDatos.Lector["Precio"];

                    aux.Categoria = new Categoria
                    {
                        Id = (int)accesoDatos.Lector["IdCategoria"],
                        Descripcion = (string)accesoDatos.Lector["Categoria"]
                    };

                    aux.Marca = new Marca
                    {
                        Id = (int)accesoDatos.Lector["IdMarca"],
                        Descripcion = (string)accesoDatos.Lector["Marca"]
                    };

                    listaArticulo.Add(aux);

                }

                return listaArticulo;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
