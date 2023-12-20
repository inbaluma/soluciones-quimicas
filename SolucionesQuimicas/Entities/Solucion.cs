namespace SolucionesQuimicas.Entities;

public class Solucion
{
    public virtual int ID { get; protected set; }
    public virtual string? solucion { get; set; }
    public virtual string? uso { get; set; }
    public virtual IList<Muestra> muestras { get; protected set; }

    public Solucion()
    {
        muestras = new List<Muestra>();
    }

    public virtual void AddMuestra(Muestra muestra)
    {
        muestra.Solucion = this;
        muestras.Add(muestra);
    }

    public virtual void RemoveMuestra(Muestra muestra)
    {
        muestras.Remove(muestra);
    }

    public override string ToString()
    {
        string res;
        if (solucion != null)
        {
            res = solucion;
        }
        else
        {
            res = "" + ID;
        }
        return res;
    }
}
