public class Participante
{
    public int participante_id { get; set; }
    public string nombre { get; set; }
    public string apellido { get; set; }
    public string email { get; set; }
    public string telefono { get; set; }
    public string institucion { get; set; }
    public DateTime fecha_nacimiento { get; set; }
}

public class Ponente
{
    public int ponente_id { get; set; } 
    public string nombre { get; set; }
    public string apellido { get; set; }
    public string email { get; set; }
    public string institucion { get; set; }
    public string bio { get; set; }
}


public class Espacio
{
    public int espacio_id { get; set; }
    public string nombre { get; set; }
    public string ubicacion { get; set; }
    public int capacidad { get; set; }
}

public class Evento
{
    public int evento_id { get; set; }
    public string nombre { get; set; }
    public string descripcion { get; set; }
    public DateTime fecha_inicio { get; set; }
    public DateTime fecha_fin { get; set; }
    public string tipo_evento { get; set; }
    public string lugar { get; set; }
}