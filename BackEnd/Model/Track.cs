using System.Collections.Generic;

namespace BackEnd.Model
{
    public class Track : ConferencesDTO.Track
    {
        public virtual ICollection<Session> Sessions { get; set; }
    }
}
