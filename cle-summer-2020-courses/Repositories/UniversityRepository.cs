using cle_summer_2020_courses.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cle_summer_2020_courses.Repositories
{
    public class UniversityRepository<T> where T : class
    {
        private UniversityContext db;

        public UniversityRepository(UniversityContext db)
        {
            this.db = db;
        }

        public void Create(T entity)
        {
            db.Set<T>().Add(entity);
            db.SaveChanges();
        }

        public T GetById(int id)
        {
            return db.Set<T>().Find(id);
        }

        public void Delete(T entity)
        {
            db.Set<T>().Remove(entity);
            db.SaveChanges();
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return db.Set<T>().ToList();
        }

        public List<Instructor> PopulateInstructorList()
        {
            return db.Instructors.ToList();
        }
    }
}
