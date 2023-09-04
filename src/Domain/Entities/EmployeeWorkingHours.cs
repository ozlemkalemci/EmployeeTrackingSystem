using Domain.Common;
using System;

namespace Domain.Entities
{
    public class EmployeeWorkingHours : EntityBase<Guid>
    {
        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public DateTimeOffset? EntryTime { get; set; }
        public DateTimeOffset? ExitTime { get; set; }
        public bool IsAbsent { get; set; }
    }
}
