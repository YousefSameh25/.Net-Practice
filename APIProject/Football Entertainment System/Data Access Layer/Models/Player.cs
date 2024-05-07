namespace Data_Access_Layer.Models
{
    public class Player
    {
        #region Attributes
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageName { get; set; }
        public DateTime DOB { get; set; }
        #endregion


        #region Navigational Properties
        public Country Country { get; set; }
        public Club CurrentClub { get; set; }
        #endregion

    }
}