using System;
using System.Collections.Generic;

namespace MediaLibrary.FileManager
{
    public abstract class FileManager
    {

        public string FilePath { get; set; }

        public List<Media> MediaList { get; set; }

        public abstract bool isUniqueTilte { get; set;}






    }
}
