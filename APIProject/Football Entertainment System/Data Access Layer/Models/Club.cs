namespace Data_Access_Layer.Models
{
    public class Club
    {
        #region Attributes
        public int Id { get; set; }
        public string Name { get; set; }
        public string LogoImageName { get; set; }
        public DateTime DateOfCreation { get; set; }
        #endregion

        #region Navigational Properties
        public IEnumerable<Player> Players { get; set; } = new List<Player>();
        public Country Country { get; set; }
        #endregion

    }
}