using System.Collections;

namespace JobMatch
{
    public class DataForSelector
    {
        public string AdditionalRequirements { get; set; }
        public string CompanyName { get; set; }
        public string Education { get; set; }
        public string Position { get; set; }
        public string ShortJobDescription { get; set; }
        public IEnumerable Skills
        {
            get;
            set;
        }
    }
}