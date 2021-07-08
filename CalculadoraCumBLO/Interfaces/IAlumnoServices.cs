using CalculadoraCumBLO.Models.AlumnoModel;
using CalculadoraCumEntities;

namespace CalculadoraCumBLO.Interfaces
{
    public interface IAlumnoServices
    {
        void Add(CreateAlumnoRequest alumno);
    }
}
