using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZsutPwPatterns.WindowsApplication.Logic.Model.Data
{
    public class ExaminationRoomDto
    {
        public ExaminationRoomDto() { }

        public ExaminationRoomDto(string number, IEnumerable<string> certifications)
        {
            this.Number = number;
            this.Certifications = certifications;

        }
        public string Number { get; set; }
        public IEnumerable<string> Certifications { get; set; }
    }
}
