using Flunt.Notifications;

namespace App.Shared.Entity
{
    public abstract class Entity : Notifiable
    {

        protected Entity()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
    }
}