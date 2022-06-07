namespace TSP
{
    /// <summary>
    /// Interface for File access
    /// </summary>
    public interface IFileAccess
    {
        /// <summary>
        /// Reads the file.
        /// </summary>
        /// <returns>IEnumerable of strings</returns>
        IEnumerable<string> ReadFile();
    }
}