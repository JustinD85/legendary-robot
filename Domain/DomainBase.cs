using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class DomainBase
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; } = new DateTime();
        public bool IsDeleted { get; set; } = false;


        public bool IsValid()
        {
            //will house logic that determines validity
            return IsDeleted;
        }
    }
}