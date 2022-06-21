using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP10_Padron.Models
{
    public class Persona
    {
        public int _DNI;
        public string _nombre;
        public string _apellido;
        public int _numeroTramite;
        public int _idestablecimiento;
        public bool _voto;

        public int DNI{
            get{
                return _DNI;
            }
            set{
                _DNI = value;
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

        public string Apellido{
            get{
                return _apellido;
            }
            set{
                _apellido = value;
            }
        }

        public int NumeroTramite{
            get{
                return _numeroTramite;
            }
            set{
                _numeroTramite = value;
            }
        }
        
        public int IdEstablecimiento{
            get{
                return _idestablecimiento;
            }
            set{
                _idestablecimiento = value;
            }
        }

        public bool Voto{
            get{
                return _voto;
            }
            set{
                _voto = value;
            }
        }
        

        public Persona(int DNI, string Nombre, string Apellido, int NumeroTramite, int IdEstablecimiento, bool Voto){
            _DNI = DNI;
            _nombre = Nombre;
            _apellido = Apellido;
            _numeroTramite = NumeroTramite;
            _idestablecimiento = IdEstablecimiento;
            _voto = Voto;
        }

        public Persona(){

        }
    }
}
