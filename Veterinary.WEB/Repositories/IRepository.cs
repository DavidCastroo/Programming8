namespace Veterinary.WEB.Repositories
{
    public interface IRepository
    {
        /*TENDRA LOS METODOS PARA INVOCAR LAS ACCIONES DE WRAPPER*/

        Task<HttpResponseWrapper<T>> GetAsync<T>(string url);
        Task<HttpResponseWrapper<object>> Post<T>(string url, T model);
        Task<HttpResponseWrapper<TResponse>> Post<T, TResponse>(string url, T model);
    }
}
