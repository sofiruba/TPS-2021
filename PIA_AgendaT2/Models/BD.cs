using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using Dapper;

namespace PIA_AgendaT2.Models
{
    public static class BD
    {
       private static string _connectionString = @"Server=A-CCE-05; DataBase=BDAgenda;Trusted_Connection=True;";
        public static List<Contacto> Listado(){

            List <Contacto> _listado = null;
                using(SqlConnection db = new SqlConnection(_connectionString)){
               string sql ="SELECT * FROM Contactos";
               _listado = db.Query<Contacto>(sql).ToList();
           }
           return _listado;
       }

       public static int AgendarContacto(Contacto unContacto){
            int ContactoAgendado= 0;
           string sql="INSERT INTO Contactos([Apellido], [Nombre], [Telefono], [Email], [URLFoto]) VALUES( @apellido, @nombre, @tel, @email, @urlf);";
           using(SqlConnection db= new SqlConnection(_connectionString)){
               ContactoAgendado = db.Execute(sql, new{ @apellido= unContacto.Apellido, @nombre = unContacto.Nombre, @tel = unContacto.Telefono, @email = unContacto.Email, @urlf= unContacto.URLFoto});
           }

           return ContactoAgendado;
       }

        public static Contacto VerContacto(int IdContacto){
            Contacto _datosContacto = null;
           using(SqlConnection db = new SqlConnection(_connectionString)){
               string sql ="SELECT * FROM Contactos WHERE IdContacto = @pid";
               _datosContacto = db.QueryFirstOrDefault<Contacto>(sql, new{@pid = IdContacto});
            }
            return _datosContacto;
       }
     
    }
}