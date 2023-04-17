using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veter
{
    internal class mascota
    {
        private string _nombre;
        private DateTime? _fechaNacimiento;
        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = value;
            }
        }
        public DateTime? FechaNacimiento
        {
            get
            {
                return _fechaNacimiento;
            }
            set
            {
                _fechaNacimiento = value;
            }
        }
        public int edad
        {
            get
            {
                return edad;
            }
            set
            {
                edad = (DateTime.Now.Year - FechaNacimiento.Value.Year);
            }
        }
        public mascota()
        {
            _nombre = string.Empty;
        }
        public mascota(string _nombre)
        {
            this._nombre = _nombre;
        }
        public override string ToString()
        {
            return Nombre.ToUpper();
        }
    }
}
