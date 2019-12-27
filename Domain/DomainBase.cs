using System;

namespace Domain
{
    public class DomainBase
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; } = new DateTime();
        public bool IsValid { get; set; } = true;
    }
}