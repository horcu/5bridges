using System.ComponentModel.DataAnnotations.Schema;
using WebApplication.Interfaces;

namespace WebApplication.Models
{
    public class MarylandCounties: ICounty
    {
        public MarylandCounties()
        {

        }
        public MarylandCounties(int id, string name, string information, long population)
        {
            Id = id;
            Name = name;
            Information = information;
            Population = population;
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Name { get; set; }
        public long Population { get; set; }
        public string Information { get; set; }

        public int GetLength()
        {
            return 0;
        }

        public string GetCountyInfo()
        {
            return this.Information;
        }
    }
}