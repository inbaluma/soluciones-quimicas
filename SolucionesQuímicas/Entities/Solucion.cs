namespace SolucionesQuímicas.Entities;

public class Solucion
{
    public virtual int ID { get; protected set; }
    public virtual string solucion { get; set; }
    public virtual string uso { get; set; }
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

    public override string ToString()
    {
        return solucion + "; " + uso;
    }
}
