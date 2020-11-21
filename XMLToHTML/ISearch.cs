using System;
using System.Collections.Generic;
using System.Text;

namespace XMLToHTML
{
    interface ISearch
    {
        List<Tank> Search(Tank tank, string filePath);
    }
}
