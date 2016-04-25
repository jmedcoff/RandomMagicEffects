using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomMagicEffects.Business_Logic
{
    class ListReader :IListReader
    {
        // fixed file path for text document containing effects
        private static string filename = @"wildmagictext.txt";
        private readonly string filepath = Path.Combine(Environment.CurrentDirectory, filename);

        private readonly FileStream stream;

        private IMagicList magicList;

        public ListReader()
        {
            stream = new FileStream(filepath, FileMode.Open);
            readFile();
            stream.Close();
        }

        private void readFile()
        {

            StreamReader streamreader = new StreamReader(stream);

            List<string> ls = new List<string>();

            while (streamreader.Peek() > -1) // until the file ends
            {
                ls.Add(streamreader.ReadLine()); // read the next line into the list
            }

            streamreader.Close();

            magicList = new MagicList(ls);

        }

        // returns a reference to magicList
        public IMagicList getMagicList()
        {
            return magicList;
        }


    }
}
