using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text.RegularExpressions;

namespace ParsePhoneNumbers
{
    public class Program
    {
        // initially included to allow you to eliminate certain file extensions, but decided to skip
        // public static readonly List<string> IgnoreExtensions = new List<string> { ".EXE", ".DLL", ".PDF", ".JPG", ".JPE", ".BMP", ".GIF", ".PNG" };

        
        public static int Main(string[] args)
        {
            try {

                if (args.Length == 0)
                {
                    Console.WriteLine("ParsePhoneNumbers requires a command-line argument representing the path for searching.  Please try again.");
                    return -1;
                }

                if (args.Length > 1)
                {
                    Console.WriteLine("ParsePhoneNumbers expects a single command-line argument representing path.  If your pathname includes a space, please surround the argument with quotes.");
                    return -2;
                }

                string folderName = args[0];

                if (!Directory.Exists(folderName))
                {
                    Console.WriteLine("Root Directory for search {0} is not a valid directory", folderName);
                    return -3;
                }

                // assumed execution directory is destination of output file, not specified
                System.IO.StreamWriter fout = new System.IO.StreamWriter("ParsePhoneNumbers.txt", false);

                IEnumerable<string> myfiles = GetFilesInFolder(folderName);
                int totalfilecount = 0;
                int matchfilecount = 0;

                foreach (var mfile in myfiles)
                {
                    totalfilecount++;
                    string filetext = System.IO.File.ReadAllText(mfile);

                    // if you wanted to eliminate some known types from inclusion, you could do this
                    //string ext = Path.GetExtension(mfile).ToUpperInvariant();

                    //if (IgnoreExtensions.Contains(ext) == false)
                    //{

                    if (containsPhoneNumber(filetext) == true)
                    {
                        fout.WriteLine(mfile);
                        matchfilecount++;

                    }
                    //}
                }

                Console.WriteLine("ParsePhoneNumbers for directory {0} returns:", folderName);
                Console.WriteLine("{0} files with phone numbers out of {1} total files", matchfilecount, totalfilecount);

                fout.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in execution " + ex.Message);
                return -5;
            }

            return 0;
        }

        public static IEnumerable<string> GetFilesInFolder(string rootname)
        {

            try
            {

               IEnumerable<string> myfiles = from f in Directory.EnumerateFiles(rootname, 
                                                            "*.*", 
                                                            SearchOption.AllDirectories)
                                              select f;

               return myfiles;

            }

            catch (Exception ex)
            {
                Console.WriteLine("Retrieving file list error " + ex.Message);
                return null;
            }

 
        }

        public static bool containsPhoneNumber(string filecontents)
        {
            // looking to match only ###-###-#### or (###)###-####
            // (###) or ###- plus required ###-####

            return (Regex.IsMatch(filecontents, @"(\([0-9]{3}\)?)[0-9]{3}-[0-9]{4}") ||
                Regex.IsMatch(filecontents, @"[0-9]{3}-[0-9]{3}-[0-9]{4}"));

        }
    }
}
