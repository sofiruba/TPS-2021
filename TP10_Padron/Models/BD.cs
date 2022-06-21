using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using Dapper;

namespace TP10_Padron.Models
{
    public static class BD
    {
       private static string _connectionString = @"Server=A-CBO-03; DataBase=BDPadron;Trusted_Connection=True;";

       public static Persona ConsultaPadron(int DNI)
       {
            Persona _datospersona = null;
            using(SqlConnection db = new SqlConnection(_connectionString)){
               string sql ="SELECT * FROM Personas WHERE DNI = @pDNI";
               _datospersona = db.QueryFirstOrDefault<Persona>(sql, new{@pDNI = DNI});
            }
            return _datospersona;
       }

       public static Establecimiento ConsultaEstablecimiento(int IdEstablecimiento){
           
           Establecimiento _datosEstablecimiento = null;
           using(SqlConnection db = new SqlConnection(_connectionString)){
               string sql ="SELECT * FROM Establecimiento WHERE IdEstablecimiento = @id";
               _datosEstablecimiento = db.QueryFirstOrDefault<Establecimiento>(sql, new{id = IdEstablecimiento});
           }
           return _datosEstablecimiento;
       }
       public static  bool Votar(int Dni, int NroTramite){
           int votacionRealizada;

           string sql ="UPDATE Personas set Voto =0 WHERE DNI = @d AND NumeroTramite= @nrot";
           using(SqlConnection db = new SqlConnection(_connectionString)){
               votacionRealizada = db.Execute(sql, new{ d = Dni, nrot = NroTramite});
           }

           if(votacionRealizada==1){
               return true;
           }
           else{    
               return false;
           }
          
       }
    }
}