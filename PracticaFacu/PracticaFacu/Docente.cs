using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaFacu
{
    class Docente
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Phone { get; set; }
        //edad
        public int Old { get; set; }
        //direccion
        public string Adress { get; set; }
        public string Ci { get; set; }
        public bool Sex { get; set; }
        //materia que el docente dictara
        public string Materia { get; set; }



        //public Docente(string Name, string LastName, int Phone, int Old, string Adress, string Ci, bool Sex, string Materia)
        //{
        //    this.Name = Name;
        //    this.LastName = LastName;
        //    this.Phone = Phone;
        //    this.Old = Old;
        //    this.Adress = Adress;
        //    this.Ci = Ci;
        //    this.Sex = Sex;
        //    this.Materia = Materia;
        //}
    }
}
