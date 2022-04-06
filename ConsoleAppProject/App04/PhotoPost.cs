using System;


namespace ConsoleAppProject.App04
{
    ///<summary>
    /// This class stores information about a post in a social network. 
    /// The main part of the post consists of a photo and a caption. 
    /// Other data, such as author and time, are also stored.
    ///</summary>
    /// <author>
    /// By Amie Shanaya Wijeratne 22012825
    /// @version 0.1
    /// </author>
   
    public class PhotoPost : PhotoPost;
    {
        // username of the post's author
        public String Username { get; set; }

        // the name of the image file
        public String Filename { get; set; }
        
        // a one line image caption
        public String Caption { get; set; }   
        
        public DateTime Timestamp { get; }

        private int likes;
        
        private readonly  List<String> comments;

        ///<summary>
        /// Constructor for objects of class PhotoPost.
        ///</summary>
        /// <param name="author">
        /// The username of the author of this post.
        /// </param>
        /// <param name="caption">
        /// A caption for the image.
        /// </param>
        /// <param name="filename">
        /// The filename of the image in this post.
        /// </param>
        public PhotoPost(String author, String filename, String caption):base(author)
        {
            Username = author;
            this.Filename = filename;
            this.Caption = caption;
            Timestamp = DateTime.Now;

            likes = 0;
            comments = new List<String>();
        }
