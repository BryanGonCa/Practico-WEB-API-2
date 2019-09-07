
namespace Practico.Models
{
    using System.Data.Entity;

    public class DataContext:DBContext
    {
        public DataContext():base("DefaultConnection")
        {

        }
    }
}