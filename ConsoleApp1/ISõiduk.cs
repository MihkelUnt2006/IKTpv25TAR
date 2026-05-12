using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
     // Liides kõikidele sõidukitele
    public interface ISõiduk
    {

        // Arvutab sõiduki kulu
        double ArvutaKulu();
        // Tagastab läbitud vahemaa
        double ArvutaVahemaa();

    }
}
