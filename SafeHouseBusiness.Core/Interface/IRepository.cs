namespace SafeHouseBusiness.Core
{
    public interface IRepository<TEntity> : ICriar<TEntity>, IDeletar<TEntity>, IAtualizar<TEntity>, IObterPorId<TEntity>, IObterPorGuid<TEntity>
    {

    }

    public interface IObterPorGuid<TEntity>
    {
        TEntity ObterPorGuid(Guid guid);
    }

    public interface IObterPorId<TEntity>
    {
        TEntity ObterPorId(int id);
    }

    public interface IAtualizar<TEntity>
    {
        bool Atualizar(TEntity entity);
    }

    public interface IDeletar<TEntity>
    {
        bool Deletar(int id);
    }

    public interface ICriar<TEntity>
    {
        TEntity Criar(TEntity entity);
    }
}