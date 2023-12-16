namespace SolucionesQuimicas.Entities;
public class Muestra
{
    public virtual int ID { get; protected set; }
    public virtual string NIF_Paciente { get; set; }
    public virtual string Cultivo { get; set; }
    public virtual Solucion Solucion { get; set; }


    public override string ToString()
    {
        return $"{NIF_Paciente}, {Cultivo}, solucion: {Solucion}";
    }
}
