using Fashion_Fuction.Models;
using Fashion_Fuction.Services.Interface;
using Fashion_Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion_Fuction.Services
{
    public class CommentService : ICommentService
    {
        private ApplicationDbContext _context;

        public CommentService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<CommentModel> GetCommentByProductId(string productId)
        {

            var commentQuery = from a in _context.commentTable
                               join b in _context.productsTable on a.comment_ProductId equals b.product_Id
                               orderby a.CreateOn descending
                               where a.IsDelete == false && b.product_Id == productId
                               select a;
            List<CommentModel> commentList = new List<CommentModel>();

            foreach (var comment in commentQuery)
            {
                CommentModel commentModel = new CommentModel();

                commentModel.Id = comment.comment_Id;
                commentModel.Comment = comment.comment_Text;
                commentModel.CreateOn = comment.CreateOn;
                commentModel.ProductId = comment.comment_ProductId;
                commentModel.UserId = comment.comment_UserId;

                commentList.Add(commentModel);
            }
            return commentList;

        }


        public async Task<bool> CreateCommentInProduct(string productId, string userId, string commentText)
        {

            CommentModel commentModel = new CommentModel();

            commentModel.Id = Guid.NewGuid().ToString();
            commentModel.Comment = commentText;
            commentModel.CreateOn = DateTime.Now;
            commentModel.ProductId = productId;
            commentModel.UserId = userId;

            await _context.AddAsync(commentModel);
            await _context.SaveChangesAsync();

            return true;

        }

        public async Task<bool> DeleteComment(string commentId)
        {

            var deleteQuery = _context.commentTable.FirstOrDefault(x => x.comment_Id == commentId);

            if (deleteQuery != null)
            {
                _context.commentTable.Remove(deleteQuery);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;

        }

        public string GetProductIdByCommentId(string commentId)
        {
            var productQuery = _context.commentTable.FirstOrDefault(x => x.comment_Id == commentId);

            if (productQuery != null)
            {
                return productQuery.comment_ProductId;
            }
            else
            {
                return "";
            }
            
        }
        public List<CommentModel> GetAllComment()
        {

            var commentQuery = from a in _context.commentTable
                               join b in _context.productsTable on a.comment_ProductId equals b.product_Id
                               orderby a.CreateOn descending
                               where a.IsDelete == false
                               select a;
            List<CommentModel> commentList = new List<CommentModel>();

            foreach (var comment in commentQuery)
            {
                CommentModel commentModel = new CommentModel();

                commentModel.Id = comment.comment_Id;
                commentModel.Comment = comment.comment_Text;
                commentModel.CreateOn = comment.CreateOn;
                commentModel.ProductId = comment.comment_ProductId;
                commentModel.UserId = comment.comment_UserId;
                var userQuery = _context.usersTable.FirstOrDefault(x=> x.Id == comment.comment_UserId);
                if (userQuery != null)
                {
                    commentModel.UserName = userQuery.UserName;
                }
                

                commentList.Add(commentModel);
            }
            return commentList;

        }
    }
}
