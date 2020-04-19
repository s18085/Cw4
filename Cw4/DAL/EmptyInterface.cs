using System;
using System.Collections.Generic;
using CW4.Models;

namespace CW4.DAL
{
    public interface IDbService
    {
        IEnumerable<Student> GetStudents();
    }
}
