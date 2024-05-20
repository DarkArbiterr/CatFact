using System.IO;
using CatFact.Interfaces;

namespace CatFact.Services
{
    public class FileService : IFileService
    {
        /// <summary>
        /// Dodanie tekstu do pliku
        /// </summary>
        /// <param name="filePath">Ścieżka do pliku</param>
        /// <param name="content">Zawartość do dodania</param>
        public void AppendToFile(string filePath, string content)
        {
            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine(content);
            }
        }
    }
}
