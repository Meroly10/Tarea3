using System.Runtime.CompilerServices;

public class Recomendado{
    public string Cedula {get; set;} = string.Empty;
    public string Nombre {get; set;} = string.Empty;
    public string Apellido {get; set;} = string.Empty;
    public string Telefono {get; set;} = string.Empty;
    public string Estadocivil {get; set;} = string.Empty;
    public string FechaNacimiento { get; set; } = string.Empty;
    public string IdSexo { get; set; } = string.Empty;
}


public class Aplicacion {
    public string Id {get; set;} = string.Empty;
    public Recomendado Recomendado{get; set;} = new Recomendado();
    public string Cedula {get; set;} = string.Empty;
    public string Nombre {get; set;} = string.Empty;
    public string Apellido {get; set;} = string.Empty;
    public string Correo {get; set;} = string.Empty;
    public string Direccion {get; set;} = string.Empty;
    public string Estadocivil {get; set;} = string.Empty;
    public string FechaNacimiento { get; set; } = string.Empty;
    public string IdSexo { get; set; } = string.Empty;
    public string Profesion {get; set;} = string.Empty;
    public string Motivo {get; set;} = string.Empty;
    public string Telefono {get; set;} = string.Empty;

    public DateTime fecha {get; set;} = DateTime.Now;

    public List<Recomendado> Referencia {get; set; } = new List<Recomendado>();
}
 public class RecomendadoJce
    {
        public string Cedula { get; set; } = string.Empty;
        public string Nombres { get; set; } = string.Empty;
        public string Apellido1 { get; set; } = string.Empty;
        public string Apellido2 { get; set; } = string.Empty;
        public string FechaNacimiento { get; set; } = string.Empty;
        public string LugarNacimiento { get; set; } = string.Empty;
        public string IdSexo { get; set; } = string.Empty;
        public string IdEstadoCivil { get; set; } = string.Empty;
        public string IDEstatus { get; set; } = string.Empty;
        public object EstatusCedulaAzul { get; set; } = string.Empty;
        public string CedulaAnterior { get; set; } = string.Empty;
        public bool ok { get; set; } 
        public string foto { get; set; } = string.Empty;
    }

    