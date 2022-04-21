using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrecastConcretePlantContracts.BindingModels
{
    public class CreateOrderBindingModel
    {
        public int ProductId { get; set; }
        public int Count { get; set; }
        public decimal Sum { get; set; }
        public int DocumentId { get; set; }
    }
}
