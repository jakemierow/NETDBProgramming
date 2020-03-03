using System;
namespace MediaLibrary.FileManager
{
    // Album class is derived from Media class
    public class Album : Media
    {
        public string artist { get; set; }
        public string recordLabel { get; set; }

        public override string Display()
        {
            return $"Id: {mediaId}\nTitle: {title}\nArtist: {artist}\nLabel: {recordLabel}\nGenres: {string.Join(", ", genres)}\n";
        }
    }