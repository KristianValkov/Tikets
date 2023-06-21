using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace User.Model
{
    public class Ticket
    {
        public int Id { get; set; }
        //M:1 към Line
        public int LineId { get; set; }
        // M:1
        public int UserId { get; set; }// Forein key
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public int PhoneNumber { get; set; }
        public User Users { get; set; }
        public Line Lines { get; set; }// Таблица ,с която се осъществява връзката
    }
}
