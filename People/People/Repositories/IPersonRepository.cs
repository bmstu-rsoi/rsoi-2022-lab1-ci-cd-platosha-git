using People.ModelsBL;

namespace People.Repositories
{
    public interface IPersonRepository : CrudRepository<PersonBL, int>
    {
        
    }
}