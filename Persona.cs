using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestion_ProgramasExtension
{
    class Persona
    {
        private string id;
        private string nombres;
        private string apellidos;
        private string telefono;
        private string email;

        public Persona()
        {
            this.id = "";
            this.nombres = "";
            this.apellidos = "";
            this.telefono = "";
            this.email = "";
        }

        public Persona(string id, string nombres, string apellidos, string telefono, string email)
        {
            this.id = id;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.telefono = telefono;
            this.email = email;
        }

        public string getId() { return this.id; }
        public void setId(string id) { this.id = id; }
        public string getNombres() { return this.nombres;  }
        public void setNombres(string n) { this.nombres = n; }
        public string getApellidos() { return this.apellidos; }
        public void setApellidos (string a) { this.apellidos = a;  }
        public string getTelefono() { return this.telefono; }
        public void setTelefono(string t) { this.telefono = t; }
        public string getEmail() { return this.email; }
        public void setEmail (string e) { this.email = e; }

    }
}
