using CalculadoraCumBLO.DTOS;

namespace CalculadoraCumBLO.Models
{
    public class Result
    {
        public StatusCode Status { get; set; } = StatusCode.Ok;//Por defecto toda solicitud es correcta
        public string Message { get; set; }
    }
}
