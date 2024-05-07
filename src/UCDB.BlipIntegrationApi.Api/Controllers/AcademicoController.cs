using Microsoft.AspNetCore.Mvc;

namespace UCDB.BlipIntegrationApi.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class AcademicoController : ControllerBase
{
    [HttpGet(Name = "GetAcademico")]
    public Academico Get()
    {
        return new Academico
        {
            Nome = "Academico",
            Matricula = "123456",
            Curso = "Tads",
            Periodo = "2024A"
        };
    }
}

public class Academico
{
    public string Nome { get; set; }
    public string Matricula { get; set; }
    public string Curso { get; set; }
    public string Periodo { get; set; }
}