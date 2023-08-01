using NP.DAL.Interfaces;

namespace NP.DAL.Entityes.Base
{
    public abstract class Entity : IEntity
    {
        /// <summary>Идентификатор </summary>
        public int Id { get; set; }
    }
}
