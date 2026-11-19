using System;

namespace YouTubeVideos
{
    public class Comment
    {
        // Private member variables to store the commenter's name and the comment text
        private string _commenterName;
        private string _text;

        public Comment(string commenterName, string text)
        {
            _commenterName = commenterName;
            _text = text;
        }

        public string GetCommenterName()
        {
            return _commenterName;
        }

        public string GetText()
        {
            return _text;
        }
    }
}