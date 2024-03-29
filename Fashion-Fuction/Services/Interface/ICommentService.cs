﻿using Fashion_Fuction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion_Fuction.Services.Interface
{
    public interface ICommentService
    {
        public List<CommentModel> GetCommentByProductId(string productId);
        public Task<bool> CreateCommentInProduct(string productId, string userId, string commentText, int commentRating);
        public Task<bool> DeleteComment(string commentId);
        public string GetProductIdByCommentId(string commentId);
        public List<CommentModel> GetAllComment();
        public int CountAllComment();
    }
}
