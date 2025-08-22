using System.ComponentModel.DataAnnotations;

namespace SampleCrudApi.Models
{
    public class TestData
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;
    }
}
