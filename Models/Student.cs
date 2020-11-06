namespace StudentPortal.Models
{
    public class Student
    {
        public string MatricNumber { get; set; }  
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Fullname 
        { 
            get 
            {
                return this.FirstName + " " + this.LastName;
            }
        }


        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}