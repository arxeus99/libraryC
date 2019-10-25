using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblotecaUI
{
    public class Book
    {
        public string TITOL { get; set; }
        public int ID_LLIB { get; set; }
        public string DISPONIBLE { get; set; }
        public string DESCRIP_LLIB { get; set; }
        public string FK_DEPARTAMENT { get; set; }
        public string FullInfo
        {
            get
            {
                return ID_LLIB + ":\t" + TITOL+ "\t" + DISPONIBLE;
            }
        }
    }
}
