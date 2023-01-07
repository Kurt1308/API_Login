using System.Net;
using System.Text.Json.Serialization;

namespace ApplicationDTO.ResponseDTO
{
    /// <summary>
    /// DTO de Resposta base a ser herdados pelos demais
    /// </summary>
    public class ResponseDTO
    {
        /// <summary>
        /// Código da resposta HTTP a ser definida
        /// </summary>
        [JsonIgnore]
        public HttpStatusCode codRetorno { get; set; }
        /// <summary>
        /// Mensagem de retorno do sistema
        /// </summary>
        public string mensagem { get; set; }
    }
}