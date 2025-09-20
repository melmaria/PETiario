using System.ComponentModel;

namespace PETiario.PETiary.Domain.GroomingBaths.Enumerators
{
    public enum KindEnum
    {
        [Description("Bath")]
        Bath = 1,
        [Description("Grooming")]
        Grooming = 2,
        [Description("Grooming and Bath")]
        GroomingBath = 3
    }
}