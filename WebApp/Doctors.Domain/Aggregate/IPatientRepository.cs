using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doctors.Domain.Aggregate
{
    public interface IPatientRepository
    {
        IEnumerable<Patient> GetAll();
        IEnumerable<Patient> GetById(int id);

        void AddPatient(Patient patient);
    }
}
