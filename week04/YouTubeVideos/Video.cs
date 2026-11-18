using System;
using System.Collections.Generic;

namespace YouTubeVideos
{
    public class Video
    {
        private string _title;
        private string _author;
        private int _lengthInSeconds;
        private List<Comment> _comments;

        public Video(string title, string author, int lengthInSeconds)
        {
            _title = title;
            _author = author;
            _lengthInSeconds = lengthInSeconds;
            _comments = new List<Comment>();
        }

        public void AddComment(Comment comment)
        {
            _comments.Add(comment);
        }

        public int GetNumberOfComments()
        {
            return _comments.Count;
        }

        // Getters for the video details
        public string GetTitle() => _title;
        public string GetAuthor() => _author;
        public int GetLength() => _lengthInSeconds;
        
        // Returns the list of comments so Program.cs can iterate through them
        public List<Comment> GetComments() => _comments;
    }
}