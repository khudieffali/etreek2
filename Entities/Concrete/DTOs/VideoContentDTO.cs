using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.DTOs
{
    public class VideoContentDTO
    {
        public string VideoUrl { get; set; } = null!;
        public string? VideoPhoto { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public int CourseId { get; set; }

    }
}
