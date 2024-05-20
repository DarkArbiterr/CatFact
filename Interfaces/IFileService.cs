namespace CatFact.Interfaces
{
    /// <summary>
    /// Interfejs usługi zapisu do pliku
    /// </summary>
    public interface IFileService
    {
        /// <summary>
        /// Dodanie tekstu do pliku
        /// </summary>
        /// <param name="filePath">Ścieżka do pliku</param>
        /// <param name="content">Zawartość do dodania</param>
        void AppendToFile(string filePath, string content);
    }
}
