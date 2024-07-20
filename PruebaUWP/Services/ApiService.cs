using Newtonsoft.Json;
using Plugin.Connectivity;
using PruebaUWP.Models;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PruebaUWP.Services
{
    public class ApiService
    {
        public async Task<DBResponse<bool>> CheckConnection()
        {
            if (!CrossConnectivity.Current.IsConnected)
            {
                return new DBResponse<bool>
                {
                    ExecutionOK = false,
                    Message = "Favor de verificar que su conexión a internet este encendida."
                };
            }

            var isReachable = await CrossConnectivity.Current.IsRemoteReachable("google.com");
            if (!isReachable)
            {
                return new DBResponse<bool>
                {
                    ExecutionOK = false,
                    Message = "Verifique su conexión a internet."
                };
            }

            return new DBResponse<bool>
            {
                ExecutionOK = true
            };
        }

        public async Task<DBResponse<T>> PostObj<T>(string urlBase, string prefix, string controller, object model)
        {
            try
            {
                var request = JsonConvert.SerializeObject(model);
                var content = new StringContent(request, Encoding.UTF8, "application/json");
                var client = new HttpClient();
                var url = $"{urlBase}{prefix}{controller}";
                var response = await client.PostAsync(url, content);
                var answer = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    return new DBResponse<T>
                    {
                        ExecutionOK = false,
                        Message = answer
                    };
                }

                var obj = JsonConvert.DeserializeObject<DBResponse<T>>(answer);
                return obj;
            }
            catch (Exception ex)
            {
                return new DBResponse<T>
                {
                    ExecutionOK = false,
                    Message = ex.Message
                };
            }
        }

        public async Task<DBResponse<T>> Get<T>(string urlBase, string prefix, string controller, int id)
        {
            try
            {
                var client = new HttpClient();
                var url = $"{urlBase}{prefix}{controller}/{id}";
                var response = await client.GetAsync(url);
                var answer = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    return new DBResponse<T>
                    {
                        ExecutionOK = false,
                        Message = answer
                    };
                }

                var obj = JsonConvert.DeserializeObject<DBResponse<T>>(answer);
                return obj;
            }
            catch (Exception ex)
            {
                return new DBResponse<T>
                {
                    ExecutionOK = false,
                    Message = ex.Message
                };
            }
        }

        public async Task<DBResponse<T>> GetData<T>(string urlBase, string prefix, string controller)
        {
            try
            {
                var client = new HttpClient();
                var url = $"{urlBase}{prefix}{controller}";
                var response = await client.GetAsync(url);
                var answer = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    return new DBResponse<T>
                    {
                        ExecutionOK = false,
                        Message = answer
                    };
                }

                var obj = JsonConvert.DeserializeObject<DBResponse<T>>(answer);
                return obj;
            }
            catch (Exception ex)
            {
                return new DBResponse<T>
                {
                    ExecutionOK = false,
                    Message = ex.Message
                };
            }
        }

        public async Task<JsonModel> GetData(string urlBase)
        {
            try
            {
                var client = new HttpClient();
                var url = $"{urlBase}";
                var response = await client.GetAsync(url);
                var answer = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    return new JsonModel
                    {
                        Record = null,
                        Metadata = null
                    };
                }

                var obj = JsonConvert.DeserializeObject<JsonModel>(answer);
                return obj;
            }
            catch (Exception)
            {
                return new JsonModel
                {
                    Record = null,
                    Metadata = null
                };
            }
        }

        public async Task<PeliculaModel> GetMovieData(string urlBase)
        {
            try
            {
                var client = new HttpClient();
                var url = $"{urlBase}";
                var response = await client.GetAsync(url);
                var answer = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    return new PeliculaModel
                    {
                        Record = null,
                        Metadata = null
                    };
                }

                var obj = JsonConvert.DeserializeObject<PeliculaModel>(answer);
                return obj;
            }
            catch (Exception)
            {
                return new PeliculaModel
                {
                    Record = null,
                    Metadata = null
                };
            }
        }
    }
}