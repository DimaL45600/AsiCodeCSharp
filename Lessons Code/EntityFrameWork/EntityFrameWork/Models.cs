using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWork
{
    public class Brand
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Model> Models { get; set; }
    }
    public class Model
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int BasePrice { get; set; }
        public int BrandId { get; set; }

        public Brand Brand { get; set; }
        public List <Spec> Specs { get; set; }
    }
    public class Spec
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Engine { get; set; }
        public string Transmission { get; set; }
        public string DriveType { get; set; }
        public int AdditionalPrice { get; set; }

        public int ModelId { get; set; }
        public Model Model { get; set; }
    }
}
