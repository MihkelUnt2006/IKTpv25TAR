using System;
using System.Collections.Generic;
using System.Text;

namespace OOPMihkel
{
    public enum TööTüüp
    {   palk,
        Toetus
    }
    public interface ITööline
    {
        TööTüüp VäljamakseTüüp { get; set; }// töö tüübi omadus
        double ArvutaPalk(); // Ainult meetodi allkiri
    }

}
