using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Data_Access_Layer.Models
{
    public class TeamPhotoQuestion
    {
        #region Attributes
        public int Id { get; set; }
        public string Title { get; set; }
        public string TeamImageName { get; set; }
        #endregion

        #region Navigational Properties
        public List<Player> Players { get; set; } = new List<Player>();
        #endregion
    }
}
