using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagement.Web.Data
{
    public class LeaveAllocation : BaseEntity
    {
        public int NumberOfDays { get; set; }

        [ForeignKey("LeaveTypeId")] //Data annotation that helps to point out a relationship.
        public LeaveType LeaveType { get; set; } //Foreign key - reference to a primary key in another table.
        public int LeaveTypeId { get; set; } //Actual column that represents the foreign key. Follow proper naming convention

        public string EmployeeId { get; set; } //Foreign key to the employee table.
    }
}
