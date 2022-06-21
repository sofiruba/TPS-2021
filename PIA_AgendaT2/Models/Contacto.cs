using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PIA_AgendaT2.Models
{
    public class Contacto
    {
        public int _idcontacto;
        public string _apellido;
        public string _nombre;
        public string _telefono;
        public string _email;
        public string _URLfoto;


        
        public Contacto(int IdContacto, String Apellido, string Nombre, String Telefono, string Email, string URLFoto)
        {
            _idcontacto = IdContacto;
            _apellido = Apellido;
            _nombre = Nombre;
            _telefono = Telefono;
            _email = Email;
            _URLfoto = URLFoto;
        }

        public Contacto(){

        }
        public int IdContacto{
            get{
                return _idcontacto;
            }
            set{
                _idcontacto = value;
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

        public string Nombre{
            get{
                return _nombre;
            }
            set{
                _nombre = value;
            }
        }
        
        public string Telefono{
            get{
                return _telefono;
            }
            set{
                _telefono = value;
            }
        }

        public string Email{
            get{
                return _email;
            }
            set{
                _email = value;
            }
        }
        
        public string URLFoto{
            get{
                return _URLfoto;
            }
            set{
                _URLfoto = value;
            }
        }

    }
}