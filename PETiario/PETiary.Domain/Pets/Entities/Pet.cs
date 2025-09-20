
using PETiario.PETiary.Domain.Pets.Enumerators;

namespace PETiario.PETiary.Domain.Pets.Entities
{
    public class Pet
    {
        public virtual int Id { get; protected set; }
        public virtual string Name { get; protected set; }
        public virtual SpeciesEnum Species { get; protected set; }
        public virtual string Breed { get; protected set; }
        public virtual double? Age { get; protected set; }
        public virtual GenderEnum Gender { get; protected set; }
        public virtual string Picture { get; protected set; }
        public virtual int Owner { get; protected set; }

        protected Pet() { }

        public Pet(string name, SpeciesEnum species, string breed, double? age, GenderEnum gender, string picture, int owner)
        {
            SetName(name);
            SetSpecies(species);
            SetBreed(breed);
            SetAge(age);
            SetGender(gender);
            SetPicture(picture);
            SetOwner(owner);
        }

        public virtual void SetOwner(int owner)
        {
            Owner = owner;
        }

        public virtual void SetPicture(string picture)
        {
            Picture = picture;
        }

        public virtual void SetGender(GenderEnum gender)
        {
            Gender = gender;
        }

        public virtual void SetAge(double? age)
        {
            Age = age;
        }

        public virtual void SetBreed(string breed)
        {
            Breed = breed;
        }

        public virtual void SetSpecies(SpeciesEnum species)
        {
            Species = species;
        }

        public virtual void SetName(string name)
        {
            Name = name;
        }
    }
}