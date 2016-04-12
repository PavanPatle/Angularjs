using System.ComponentModel.DataAnnotations;

namespace Curd_MVC_AngularJS_Demo.Models
{
    public class Books
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string Isbn { get; set; }
    }
}