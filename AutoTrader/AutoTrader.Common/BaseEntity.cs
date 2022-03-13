namespace AutoTrader.Common
{
    internal class BaseEntity
    {
        protected BaseEntity()
        {

        }

        protected BaseEntity(
            string createdBy,
            DateTimeOffset created,
            string lastModifiedBy,
            DateTimeOffset? lastModified)
        {
            CreatedBy = createdBy;
            Created = created;
            LastModifiedBy = lastModifiedBy;
            LastModified = lastModified;
        }

        public string CreatedBy { get; protected set; }
        public DateTimeOffset Created { get; protected set; }
        public string LastModifiedBy { get; protected set; }
        public DateTimeOffset? LastModified { get; protected set; }
    }
}
