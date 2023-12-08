namespace GerenciarContratos.Helpers
{
    public interface IAbstractFactory<T>
    {
        T Create();
    }
}