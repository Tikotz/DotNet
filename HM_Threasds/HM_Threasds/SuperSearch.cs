using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_Threasds5
{
    public class SuperSearch
    {
        public string Drive { get; set; }
        public string SearchTerm { get; set; }

        List<string> Extentions { get; set; } = new List<string>() { ".txt" };

        public SuperSearch(string drive, string searchTerm)
        {
            Drive = drive;
            SearchTerm = searchTerm;
        }
        public static event Action<string> SearchValue;
        public void searchValue()
        {
            var Drive1 = Directory.GetDirectories(@Drive + ":\\");
            foreach (var dir in Drive1)
            {
                SearchInDir(dir);
            }
        }
        public void SearchInDir(string dir)
        {
            var dir1 = new DirectoryInfo(dir);
            try
            {
                var result = dir1.GetFiles();

                string? line = string.Empty;
                foreach (var item in result)
                {
                    if (item.Name.Contains(Extentions[0]))
                    {
                        using (var reader = new StreamReader(item.FullName))
                        {
                            while (line != null)
                            {
                                line = reader.ReadLine();
                                if (line == null)
                                {

                                    var str = $"not found in {item.FullName}";
                                    SearchValue(str);
                                    break;
                                }
                                if (line.Contains(SearchTerm)) { var str = $"found in {item.FullName}"; SearchValue(str); break; }
                            }
                        }
                    }
                    else
                    {
                        var str = $"{item.FullName} is not txt file";
                        SearchValue(str);
                    }
                }
            }
            catch
            {
                return;
            }
        }
    }
}
