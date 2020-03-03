using System;
namespace MediaLibrary
{
    // Book class is derived from Media class
    public class Book : Media
    {
        public string author { get; set; }
        public UInt16 pageCount { get; set; }
        public string publisher { get; set; }

        public override string Display()
        {
            return $"Id: {mediaId}\nTitle: {title}\nAuthor: {author}\nPages: {pageCount}\nPublisher: {publisher}\nGenres: {string.Join(", ", genres)}\n";
        }