using MilleniumRecruitmentTask.Data;
using System.ComponentModel.DataAnnotations;

namespace MilleniumRecruitmentTask.Model
{
    public class Value : IEntity
    {
        public int Id { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Name { get; set; }
    }
}
