using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP10_Padron.Models
{
    public class Establecimiento
    {
        public int _idestablecimiento;
        public string _nombre;
        public string _direccion;
        public string _localidad;

        public Establecimiento(int IdEstablecimiento, string Nombre, string Direccion, string Localidad){
            _idestablecimiento = IdEstablecimiento;
            _nombre = Nombre;
            _direccion = Direccion;
            _localidad = Localidad;
        }
        public Establecimiento(){
            
        }

        public int IdEstablecimiento{
            get{
                return _idestablecimiento;
            }
            set{
                _idestablecimiento = value;
            }
        }

        public string Nombre{
            get{
                return _nombre;
            }
            set{
                _nombre = value;
            }
        }

        public string Direccion{
            get{
                return _direccion;
            }
            set{
                _direccion = value;
            }
        }
        
        public string Localidad{
            get{
                return _localidad;
            }
            set{
                _localidad = value;
            }
        }

    }
}