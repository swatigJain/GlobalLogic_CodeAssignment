using CodeAssignment.Model;
using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CodeAssignment.ViewModel
{
    public class PostListVM:ViewModelBase
    {
        #region private members
        private PostModel postModelObj = null;
        private Post postItem = null;
        private List<Post> postList = null;
        private RelayCommand sortByPostId = null;
        private RelayCommand sortByUserId = null;
        private RelayCommand sortBytitle = null;
        private RelayCommand exportJson = null;
        private RelayCommand exportHtml = null;
        private RelayCommand exportText = null;
        private bool isPostInfoVisible = false;
        #endregion

        #region Public Constructor
        /// <summary>
        /// Public Constructor
        /// </summary>
        public PostListVM()
        {
            PostModelObj = PostModel.InstanceCreation();           
            postList= postModelObj.GetPostList();
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets/Sets PostModelObj
        /// </summary>
        public PostModel PostModelObj
        {
            get
            {
                return postModelObj;
            }

            set
            {
                postModelObj = value;
                RaisePropertyChanged("PostModelObj");
            }
        }
        /// <summary>
        /// Gets/Sets PostList
        /// </summary>
        public List<Post> PostList
        {
            get
            {
                if(postList==null)
                { postList = new List<Post>(); }
                return postList;
            }

            set
            {
                postList = value;
                RaisePropertyChanged("PostList");
            }
        }

        /// <summary>
        /// Gets/Sets PostItem
        /// </summary>
        public Post PostItem
        {
            get
            {
                return postItem;
            }

            set
            {
                postItem = value;
                IsPostInfoVisible = true;         
                RaisePropertyChanged("PostItem");
                RaisePropertyChanged("IsPostInfoVisible");
            }
        }
        /// <summary>
        /// Gets/Sets IsPostInfoVisible
        /// </summary>
        public bool IsPostInfoVisible
        {
            get
            {
                return isPostInfoVisible;
            }

            set
            {
                isPostInfoVisible = value;
                RaisePropertyChanged("IsPostInfoVisible");
            }
        }
        #endregion

        #region RelayCommands
        /// <summary>
        ///Command that Sorts list by post id
        /// </summary>
        public RelayCommand SortByPostId
        {
            get
            {
                if (sortByPostId == null)
                    sortByPostId = new RelayCommand(o => SortByPostIdMethod(o), o => CanSortByPostId());
                return sortByPostId;
            }
        }
        /// <summary>
        /// Command that Sorts list by user id
        /// </summary>
        public RelayCommand SortByUserId
        {
            get
            {
                if (sortByUserId == null)
                    sortByUserId = new RelayCommand(o => SortByUserIdMethod(o), o => CanSortByUserId());
                return sortByUserId;
            }
        }
        /// <summary>
        /// Command that sorts by title
        /// </summary>
        public RelayCommand SortByTitle
        {
            get
            {
                if (sortBytitle == null)
                    sortBytitle = new RelayCommand(o => SortByTitleMethod(o), o => CanSortByTitle());
                return sortBytitle;
            }
        }

        /// <summary>
        /// Command to export the post item in json
        /// </summary>
        public RelayCommand ExportJson
        {
            get
            {
                if (exportJson == null)
                    exportJson = new RelayCommand(o => ExportJsonMethod(o), o => CanExportJson());
                return exportJson;
            }
        }
        /// <summary>
        /// Command to export the post item data in html
        /// </summary>
        public RelayCommand ExportHtml
        {
            get
            {
                if (exportHtml == null)
                    exportHtml = new RelayCommand(o => ExportHtmlMethod(o), o => CanExportHtml());
                return exportHtml;
            }
        }
        /// <summary>
        /// Command to export post item data in text file
        /// </summary>
        public RelayCommand ExportText
        {
            get
            {
                if (exportText == null)
                    exportText = new RelayCommand(o => ExportTextMethod(o), o => CanExportText());
                return exportText;
            }
        }

        #endregion

        #region Methods
        /// <summary>
        /// Method to return if export to text file is active
        /// </summary>
        /// <returns></returns>
        private bool CanExportText()
        {
            return IsPostInfoVisible;
        }
        /// <summary>
        /// Method to export text file
        /// </summary>
        /// <param name="o"></param>
        private void ExportTextMethod(object o)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.FileName = "PostDocument"; // Default file name
            dlg.DefaultExt = ".txt"; // Default file extension
            dlg.Filter = "Text documents (.txt)|*.txt"; // Filter files by extension

            // Show save file dialog box
            Nullable<bool> result = dlg.ShowDialog();

            // Process save file dialog box results
            if (result == true)
            {
                // Save document
                string fileText = "Post " + PostItem.id + System.Environment.NewLine + "User Id: " + PostItem.userId +
                    System.Environment.NewLine + "Title: " + PostItem.title + System.Environment.NewLine + "Body: " + PostItem.body;
                string filename = dlg.FileName;
                File.WriteAllText(dlg.FileName, fileText);
            }
        }
        /// <summary>
        /// Method to return if export to html is active
        /// </summary>
        /// <returns></returns>
        private bool CanExportHtml()
        {
            return IsPostInfoVisible;
        }

        /// <summary>
        /// Method to export html file
        /// </summary>
        /// <param name="o"></param>
        private void ExportHtmlMethod(object o)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.FileName = "PostDocument"; // Default file name
            dlg.DefaultExt = ".html"; // Default file extension
            dlg.Filter = "(.html)|*.html"; // Filter files by extension

            // Show save file dialog box
            Nullable<bool> result = dlg.ShowDialog();

            // Process save file dialog box results
            if (result == true)
            {
                // Save document
                string fileText ="<html><body><p>Post " + PostItem.id +"</p>" + "<p>User Id: " + PostItem.userId +"</p>" + "<p>Title: " + PostItem.title +"</p>"+ "<p>Body: " + PostItem.body+"</p></body></html>";
                string filename = dlg.FileName;
                File.WriteAllText(dlg.FileName, fileText);

            }
        }

        /// <summary>
        /// Method to return if export to json is active
        /// </summary>
        /// <returns></returns>
        private bool CanExportJson()
        {
            
            return IsPostInfoVisible;
        }
        /// <summary>
        /// Method to export to json
        /// </summary>
        /// <param name="o"></param>
        private void ExportJsonMethod(object o)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.FileName = "PostDocument"; // Default file name
            dlg.DefaultExt = ".json"; // Default file extension
            dlg.Filter = "(.json)|*.json"; // Filter files by extension

            // Show save file dialog box
            Nullable<bool> result = dlg.ShowDialog();

            // Process save file dialog box results
            if (result == true)
            {
                // Save document
                string fileText = JsonConvert.SerializeObject(PostItem).ToString();
                File.WriteAllText(dlg.FileName, fileText);

            }
        }
        /// <summary>
        /// Method to return if Sort by titile is active
        /// </summary>
        /// <returns></returns>
        private bool CanSortByTitle()
        {
            return true;
        }
        /// <summary>
        /// Method to return if Sort by user id is active
        /// </summary>
        /// <returns></returns>
        private bool CanSortByUserId()
        {
            return true;
        }
        /// <summary>
        /// Method to return if Sort by post id is active
        /// </summary>
        /// <returns></returns>
        private bool CanSortByPostId()
        {
            return true;
        }
        /// <summary>
        /// Method to sort by post id
        /// </summary>
        /// <param name="parameter"></param>
        public void SortByPostIdMethod(object parameter)
        {
            List<Post> list = PostList.OrderBy(s => s.id).ToList();
            if (!list.SequenceEqual(PostList))
            {
                
                PostList.Clear();
                PostList = list;
            }  
            else
            {
                PostList.Clear();
                PostList=list.OrderByDescending(s => s.id).ToList(); ;
            }
            RaisePropertyChanged("PostList");
        }
        /// <summary>
        /// Method to sort by user id
        /// </summary>
        /// <param name="parameter"></param>
        public void SortByUserIdMethod(object parameter)
        {
            List<Post> list = PostList.OrderBy(s => s.userId).ToList();
            if (!list.SequenceEqual(PostList))
            {

                PostList.Clear();
                PostList = list;
            }
            else
            {
                PostList.Clear();
                PostList = list.OrderByDescending(s => s.userId).ToList(); ;
            }
            RaisePropertyChanged("PostList");
        }
        /// <summary>
        /// Method to sort by title
        /// </summary>
        /// <param name="parameter"></param>
        public void SortByTitleMethod(object parameter)
        {
            List<Post> list = PostList.OrderBy(s => s.title).ToList();
            if (!list.SequenceEqual(PostList))
            {

                PostList.Clear();
                PostList = list;
            }
            else
            {
                PostList.Clear();
                PostList = list.OrderByDescending(s => s.title).ToList(); ;
            }
            RaisePropertyChanged("PostList");
        }
        #endregion
    }


}
