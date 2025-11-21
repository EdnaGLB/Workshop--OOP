namespace Data
{
    public class FileBackEnd : IFileBackend
    {
        private string fileName;

        public FileBackEnd(string filename)
        {
            fileName = filename;
        }


        public bool Store(List<string> entries)
        {
            try
            {
                StreamWriter writer = new(fileName, true);

                foreach (string entry in entries)
                {
                    writer.WriteLine(entry);
                }

                writer.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            return true;
        }

        public List<string> Load()
        {
            List<string> entries = new List<string>();

            try
            {
                string? line;

                StreamReader reader = new(fileName);

                while ((line = reader.ReadLine()) != null)
                {
                    entries.Add(line);   
                }
                reader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new List<string>();
            }

            return entries;
        }
    }
}