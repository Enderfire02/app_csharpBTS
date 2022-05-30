using app_csharpBTS.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace app_csharpBTS.Manager
{
    class DataManager
    {
        public readonly projetcsharpContext Context;

        public DataManager()
        {
            Context = new projetcsharpContext();
        }
    }
}

