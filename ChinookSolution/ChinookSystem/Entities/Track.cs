using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespace
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
#endregion

namespace ChinookSystem.Entities
{
    [Table("Tracks")]
    class Track
    {
        private string _Name;
        private string _Composer;
        [Key]
        public int TrackId { get; set; }
        [StringLength(200, ErrorMessage ="Name is 200 characters max", MinimumLength = 1)]
        [Required(ErrorMessage ="Track name is required")]
        public string Name { get; set; }
        public int? AlbumId { get; set; }
        public int MediaTypeId { get; set; }
        public int? GenreId { get; set; }
        [StringLength(220, ErrorMessage ="Composer is 220 characters max")]
        public string Composer
        {
            get { return _Composer; }
            set { _Composer = string.IsNullOrEmpty(value) ? null : value; }
        }
        public int Milliseconds { get; set; }
        public int? Bytes { get; set; }
        public decimal UnitPrice { get; set; }

        public virtual Album Album { get; set; }
        public virtual Genre Genre { get; set; }
        public virtual MediaType MediaType { get; set; }
    }
}
