using CalculadoraCumBLO.Models.AlumnoModel;
using CalculadoraCumBLO.Interfaces;
using CalculadoraCumDAL.Interfaces;
using CalculadoraCumDAL.Repositories;
using System;

namespace CalculadoraCumBLO.Services
{
    public class AlumnoService : IAlumnoServices
    {
        private readonly IAlumnoRepository _alumnoRepository;
        public AlumnoService()
        {
            _alumnoRepository = new AlumnoRepository();
        }
        public void Add(CreateAlumnoRequest model)
        {
            throw new NotImplementedException();
        }
    }
}
