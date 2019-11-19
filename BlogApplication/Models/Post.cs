using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlogApplication.Models
{
    public partial class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }

        [Required]
        [Display(Name = "File")]
        public IFormFile FormFile { get; set; }
        public string Result { get; set; }
    }
}
