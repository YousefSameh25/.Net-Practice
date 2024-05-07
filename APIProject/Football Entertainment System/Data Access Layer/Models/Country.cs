namespace Data_Access_Layer.Models
{
    public class Country
    {
        #region Attributes
        public int Id { get; set; }
        public string Name { get; set; }
        public string FlagImageName { get; set; }
        #endregion


        #region Navigational Properties
        public IEnumerable<Club> Clubs { get; set; } = new List<Club>();
        public IEnumerable<Player> Players { get; set; } = new List<Player>();
        #endregion

    }
}