using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;

namespace CodeAssignment.Model
{
    public class PostModel
    {
        #region private members
        private static PostList postList = null;
        private static PostModel PostmodelObject;
        #endregion
        private PostModel()
        {

        }
        #region Properties
        /// <summary>
        /// Gets/Sets PostList
        /// </summary>
        public static PostList PostList
        {
            get
            {
                return postList;
            }
            set
            {
                postList = value;
            }
        }
        #endregion

        #region methods
        /// <summary>
        /// Creates instance 
        /// </summary>
        /// <returns></returns>
        public static PostModel InstanceCreation()
        {
            if (PostmodelObject == null)
            {

                PostmodelObject = new PostModel();
            }
            return PostmodelObject;

        }

        /// <summary>
        /// Gets the list of post items
        /// </summary>
        /// <returns></returns>
        public List<Post> GetPostList()
        {
            var client = new WebClient();
            List<Post> postList = new List<Post>();
            try
            {
               string jsonString = client.DownloadString("http://jsonplaceholder.typicode.com/posts"); 
                if (jsonString!=null)
                {
                    postList = JsonConvert.DeserializeObject<List<Post>>(jsonString);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return postList;
        }

        #endregion


    }
    /// <summary>
    /// Post Item Class
    /// </summary>
    public class Post
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string body { get; set; }

    }
    /// <summary>
    /// PostList Class
    /// </summary>
    public class PostList
    {
        public List<Post> postList { get; set; }

    }

}
