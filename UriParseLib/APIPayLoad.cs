using System;
using System.Collections.Generic;

namespace UriParseLib.APIPaySystem
{
    public class APIPayLoad
    {
        private Uri Url;

        public APIPayLoad(Uri Url)
        // Example: http://www.jukka.com
        {
            this.Url = Url;
        }

        // Returns the Absolute path minus the BaseUrl.
        public string GetEndPointPath()
        {
            return Url.AbsolutePath;
        }

        // Returns the '/' separated Segments array as List<string> with the 
        // '/' separator trimmed.  List[0] would be '/' and is not and to the SegmentList.
        public List<string> GetPathSegments()
        {
            List<string> SegmentList = new List<string>();
            foreach (var s in Url.Segments)
            {
                var seg = s.Trim('/');
                if (seg.Length != 0)
                {
                    SegmentList.Add(s.Trim('/'));
                }
            }

            return SegmentList;
        }

        // For "http://www.jukka.com/api/", "/api/payment" is returned
        public string GetLocalPath()
        {
            return Url.LocalPath;
        }

        public string GetPathSegment(int segmentNumber)
        {
            string[] segments = Url.Segments;

            if ((segmentNumber >= segments.Length) || (segmentNumber < 0))
            {
                return "";
            }
            return segments[segmentNumber];
        }
    }
}
