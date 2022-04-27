
namespace Excercise.Lists.Models
{
    internal class People
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

        public static People FromCSV(string str)
        {
            string[] values = str.Split(',');
            People people = new People();
            people.Id = int.Parse(values[0]);
            people.Name = values[1];
            people.IsActive = bool.Parse(values[2]);
            return people;
        }
    }
}
