using NP.DAL.Entityes.Base;
using NP.DAL.Interfaces;

namespace NP.DAL
{
    public class EFRepository<T> : IRepository<T> where T : Entity, new()
    {
        public IQueryable<T> Items => throw new NotImplementedException();

        public bool AutoSaveChanges { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public T Add(T item)
        {
            throw new NotImplementedException();
        }

        public Task<T> AddAsync(T item, CancellationToken Cancel = default)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<T> item)
        {
            throw new NotImplementedException();
        }

        public Task AddRangeAsync(IEnumerable<T> item, CancellationToken Cancel = default)
        {
            throw new NotImplementedException();
        }

        public Task ClearAsync(CancellationToken Cancel = default)
        {
            throw new NotImplementedException();
        }

        public T Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetAsync(int id, CancellationToken Cancel = default)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(int id, CancellationToken Cancel = default)
        {
            throw new NotImplementedException();
        }

        public void SaveAs()
        {
            throw new NotImplementedException();
        }

        public Task SaveAsAsync(CancellationToken Cancel = default)
        {
            throw new NotImplementedException();
        }

        public void Update(T item)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(T item, CancellationToken Cancel = default)
        {
            throw new NotImplementedException();
        }
    }
}
