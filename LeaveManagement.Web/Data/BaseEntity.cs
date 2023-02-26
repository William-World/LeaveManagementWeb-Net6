namespace LeaveManagement.Web.Data
{
    public abstract class BaseEntity
    {
        //Rule #1: Always have a primary key
        public int Id { get; set; } //Key

        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
}
}
