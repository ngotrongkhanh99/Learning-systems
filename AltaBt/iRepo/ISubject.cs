using AltaBt.Models;

namespace AltaBt.iRepo
{
    public interface ISubject
    {
        IEnumerable<Subject> getAll();
        Subject get(int subjectID);
        public void create(Subject Sj);
        public void update(Subject Sj);
        public void delete(int subjectID);
    }
}
