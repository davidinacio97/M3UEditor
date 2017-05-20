using System;

namespace M3UEditor
{
    /// <summary>
    /// Stream-class saves information about the streams.
    /// </summary>
    public class Stream
    {
        #region Properties

        public string Group { get; set; }

        public string StreamName { get; private set; }

        public string StreamLink { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default-Constructor with parameters.
        /// </summary>
        /// <param name="name">Name of the stream</param>
        /// <param name="link">Link of the stream</param>
        public Stream(string name, string link)
        {
            StreamName = name;
            StreamLink = link;
        }

        #endregion

        public override string ToString()
        {
            if (string.IsNullOrWhiteSpace(Group))
            {
                return $"#EXTINF:-1,{StreamName}{Environment.NewLine}{StreamLink}";
            }
            else
            {
                return $"#EXTINF:-1 group-title=\"{Group}\",{StreamName}{Environment.NewLine}{StreamLink}";
            }
        }
    }
}
