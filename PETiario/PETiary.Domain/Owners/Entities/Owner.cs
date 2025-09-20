
namespace PETiario.PETiary.Domain.Owners.Entities
{
    public class Owner
    {
        public virtual int Id { get; protected set; }
        public virtual string Name { get; protected set; }
        public virtual string Telephone { get; protected set; }
        public virtual string Email { get; protected set; }
        public virtual string Adress { get; protected set; }

        protected Owner() {}

        public Owner(string name, string telephone, string email, string adress)
        {
            SetName(name);
            SetTelephone(telephone);
            SetEmail(email);
            SetAdress(adress);
        }

        public virtual void SetAdress(string adress)
        {
            Adress = adress;
        }

        public virtual void SetEmail(string email)
        {
            Email = email;
        }

        public virtual void SetTelephone(string telephone)
        {
            Telephone = telephone;
        }

        public virtual void SetName(string name)
        {
            Name = name;
        }
    }
}