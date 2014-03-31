namespace FictionBook.Parser
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class Fiction
    {
        static void Open(string path)
        {
            Fiction.Open(File.ReadAllBytes(path));
        }

        static void Open(byte[] bytes)
        {

        }
    }
}
