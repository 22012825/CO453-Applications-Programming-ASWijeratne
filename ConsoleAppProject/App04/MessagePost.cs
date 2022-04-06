using System;

namespace ConsoleAppProject.App04
{
    ///<summary>
    /// This class stores information about a post in a social network. 
    /// The main part of the post consists of a (possibly multi-line)
    /// text message. Other data, such as author and time, are also stored.
    /// </summary>
    /// <author>
    /// Amie Shanaya Wijeratne 22012825
    /// </author>
    /// 

    public class MessagePost : MessagePost
    {
        private int likes;

        private readonly List<String> comments;


        // username of the post's author
        public String Username { get; }

        // an arbitrarily long, multi-line message
        public String Message { get; }

        public DateTime Timestamp { get; }

        }
        
        /// Constructor for objects of class MessagePost.
        /// </summary>
        /// <param name="author">
        /// The username of the author of this post.
        /// </param>
        /// <param name ="text">
        /// The text of this post
        /// </param>
       
        public MessagePost(String author,  String text) : base(author)

            Message = text;
        
        }     
}
