using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3UEditor
{
    /// <summary>
    /// Parser-class for a m3u-File.
    /// </summary>
    public class M3UParser
    {
        #region Properties

        /// <summary>
        /// Saves the filename.
        /// </summary>
        public string Filename { get; private set; }
   
        /// <summary>
        /// Saves a list with Streams.
        /// </summary>
        public List<Stream> Streams { get; private set; }

        public List<Stream> StreamsWithoutGroup
        {
            get { return Streams.Where(x => string.IsNullOrWhiteSpace(x.Group)).ToList(); }
        } 
   

        #endregion


        #region Constructors

        /// <summary>
        /// Default-Constructor with parameters.
        /// </summary>
        /// <param name="filename">Filename</param>
        public M3UParser(string filename)
        {
            //if (filename.EndsWith(".m3u"))
            //{
            //    throw new ArgumentException("The file has not the correct format.", nameof(filename));
            //}

            Filename = filename;
            Streams = new List<Stream>();
            Parse();

        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Parses the file.
        /// </summary>
        private void Parse()
        {
            if (!string.IsNullOrWhiteSpace(Filename) && File.Exists(Filename))
            {
                var lines = File.ReadAllLines(Filename);
                int currentIndex = 0;

                foreach (var line in lines)
                {
                    if (line.StartsWith("#EXTM3U"))
                    {
                        currentIndex++;
                        continue;
                    }

                    if (line.StartsWith("http"))
                    {
                        currentIndex++;
                        continue;
                    }

                    if (line.StartsWith("#EXTINF"))
                    {
                        var splittedLine = line.Split(',');

                        if (splittedLine.Length == 2)
                        {
                            var name = splittedLine[1];

                            if (currentIndex < lines.Length)
                            {
                                var link = lines[currentIndex + 1];
                                this.Streams.Add(new Stream(name, link));
                            }
                        }
                        
                    }
                    currentIndex++;
                }
            }
            
        }

        #endregion
    }
}
