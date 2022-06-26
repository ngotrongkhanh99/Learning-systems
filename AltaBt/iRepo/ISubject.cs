using AltaBt.Models;

namespace AltaBt.iRepo
{
    public interface ISubject
    {
        IEnumerable<Monhoc> getAll();
        Monhoc get(int subjectID);
        public void create(Monhoc Sj);
        public void update(Monhoc Sj);
        public void delete(int subjectID);
    }
}
