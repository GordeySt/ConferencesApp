using System.Collections.Generic;

namespace BackEnd.Model
{
    public class Session : ConferencesDTO.Session
    {
        public virtual ICollection<SessionSpeaker> SessionSpeakers { get; set; }

        public virtual ICollection<SessionAttendee> SessionAttendees { get; set; }

        public Track Track { get; set; }
    }
}
