using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NewsApp.Models
{
    public class Post
    {
        /// <summary>
        /// 2 cách thiết lập quan hệ
        /// 1 là sử dụng Annotation
        /// 2 là config ở trong Dbcontext
        /// </summary>
        
        [Key]
        public int ID { get; set; }
        [Required]
        [StringLength(200)]
        public string PostTitle { get; set; }
        [Column(TypeName ="ntext")]
        [Required]
        public string PostContent { get; set; }
        [StringLength(400)]
        public string PostTeaser { get; set; }
        [Required]
        public string AvatarImage { get; set; } = "https://znews-photo.zadn.vn/w1024/Uploaded/tmuitg/2019_07_25/16_1.jpg";
        
        public int ViewCount { get; set; }
        [Required]
        public int CateID { get; set; }
        [ForeignKey("CateID")]
        public virtual Category Category { get; set; }
    }
}
