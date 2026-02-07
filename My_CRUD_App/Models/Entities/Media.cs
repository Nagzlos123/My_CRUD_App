namespace My_CRUD_App.Models.Entities
{
    public class Media //  Class containing base for Movie and TVShow class
    {
        public string Title { get; set; }

        public int Runtime { get; set; }

        public bool Status { get; set; }

        public DateTime Released { get; set; }
    }
}
