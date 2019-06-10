namespace RA.Persistence.Interfaces
{
    public interface IBaseCommandRepository<TDto>
    {
        TDto Add(TDto input);

        TDto Update(TDto input);

        void Remove(int id);
    }
}
