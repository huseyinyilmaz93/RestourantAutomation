using RA.Kernel.Common;
using RA.Persistence.Interfaces;

namespace RA.Persistence.Mssql.Common
{
    public abstract class AbstractCommandRepository<TTEntity> : IBaseCommandRepository<TTEntity>
        where TTEntity : BaseEntity
    {
        public ICommandUnitOfWorkRepository<TTEntity> _unitofWork { get; set; }

        public TTEntity Add(TTEntity input)
        {
            return _unitofWork.Add(input);
        }

        public TTEntity Update(TTEntity input)
        {
            return _unitofWork.Update(input);
        }

        public void Remove(int id)
        {
            _unitofWork.Remove(id);
        }
    }
}
