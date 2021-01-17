using System.Collections.Generic;

namespace BackEnd.Model
{
    public class Attendee : ConferencesDTO.Attendee
    {
        public virtual ICollection<SessionAttendee> SessionsAttendees { get; set; }
    }
}
