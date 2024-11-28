using System.Collections.Generic;

namespace WebApplication3.NewFolder
{
    public class StuduentViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> SelectedCity { get; set; }
        public List<string> SelectedState { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string AboutYourself { get; set; }


    }
}
