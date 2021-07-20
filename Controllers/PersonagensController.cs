using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Collections.Generic;
using RpgMvc.Models;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Http;
using System.Linq;
namespace RpgMvc.Controllers
{
    public class PersonagensController : Controller
    {
        public string uriBase = "http://estevesarthur.somee.com/RpgApi/Personagem/";

        public async Task<ActionResult> IndexAsync()
        {

            string uriComplementar = "GetAll";

            HttpClient httpClient = new HttpClient();

            string token = HttpContext.Session.GetString("SessionTokenUsuario");
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            HttpResponseMessage response = await httpClient.GetAsync(uriBase + uriComplementar);

            string serialized = await response.Content.ReadAsStringAsync();

            List<PersonagemViewModel> listaPersonagens = await Task.Run(() =>
                JsonConvert.DeserializeObject<List<PersonagemViewModel>>(serialized));

            return View(listaPersonagens);

        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> CreateAsync(PersonagemViewModel p)
        {
            HttpClient httpClient = new HttpClient();

            string token = HttpContext.Session.GetString("SessionTokenUsuario");
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var content = new StringContent(JsonConvert.SerializeObject(p));
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            HttpResponseMessage response = await httpClient.PostAsync(uriBase, content);

            string serialized = await response.Content.ReadAsStringAsync();

            await Task.Run(() =>
                JsonConvert.DeserializeObject<List<PersonagemViewModel>>(serialized));

            TempData["Mensagem"] = string.Format("Personagem {0} Salvo com sucesso!", p.Nome);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<ActionResult> DetailsAsync(int id)
        {
            HttpClient httpClient = new HttpClient();

            string token = HttpContext.Session.GetString("SessionTokenUsuario");
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            HttpResponseMessage response = await httpClient.GetAsync(uriBase + id.ToString());
            string serialized = await response.Content.ReadAsStringAsync();

            PersonagemViewModel p = await Task.Run(() =>
                JsonConvert.DeserializeObject<PersonagemViewModel>(serialized));

            return View(p);
        }

        [HttpGet]
        public async Task<ActionResult> EditAsync(int id)
        {
            HttpClient httpClient = new HttpClient();

            string token = HttpContext.Session.GetString("SessionTokenUsuario");
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            HttpResponseMessage response = await httpClient.GetAsync(uriBase + id.ToString());
            string serialized = await response.Content.ReadAsStringAsync();

            PersonagemViewModel p = await Task.Run(() =>
                JsonConvert.DeserializeObject<PersonagemViewModel>(serialized));

            return View(p);
        }

        [HttpPost]
        public async Task<ActionResult> EditAsync(PersonagemViewModel p)
        {
            HttpClient httpClient = new HttpClient();

            string token = HttpContext.Session.GetString("SessionTokenUsuario");
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var content = new StringContent(JsonConvert.SerializeObject(p));
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            HttpResponseMessage response = await httpClient.PutAsync(uriBase, content);
            
            string serialized = await response.Content.ReadAsStringAsync();
            
            await Task.Run(() =>
                JsonConvert.DeserializeObject<PersonagemViewModel>(serialized));

            TempData["Mensagem"] = string.Format("Personagem {0}, classe {1} atualizado com sucesso!", p.Nome, p.Classe);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            HttpClient httpClient = new HttpClient();

            string token = HttpContext.Session.GetString("SessionTokenUsuario");
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            HttpResponseMessage response = await httpClient.DeleteAsync(uriBase + id.ToString());

            TempData["Mensagem"] = string.Format("Personagem {0} removido com sucesso!", id);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<ActionResult> DisputaGeralAsync()
        {
            string uriComplementar = "GetAll";
            HttpClient httpClient = new HttpClient();

            string token = HttpContext.Session.GetString("SessionTokenUsuario");
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            HttpResponseMessage response = await httpClient.GetAsync(uriBase + uriComplementar);
            string serialized = await response.Content.ReadAsStringAsync();

            List<PersonagemViewModel> listaPersonagens = await Task.Run(() =>
                JsonConvert.DeserializeObject<List<PersonagemViewModel>>(serialized));

            string uriDisputa = "http://estevesarthur.somee.com/RpgApi/Disputas/DisputaEmGrupo";
            
            DisputaViewModel disputa = new DisputaViewModel();
            disputa.ListaIdPersonagem = new List<int>();
            disputa.ListaIdPersonagem.AddRange(listaPersonagens.Select(p => p.Id));

            var content = new StringContent(JsonConvert.SerializeObject(disputa));
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            response = await httpClient.PostAsync(uriDisputa, content);

            serialized = await response.Content.ReadAsStringAsync();

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                disputa = await Task.Run(() =>
                    JsonConvert.DeserializeObject<DisputaViewModel>(serialized));

                TempData["Mensagem"] = string.Join(" - ", disputa.Resultados);
            }
            else
                TempData["MensagemErro"] = serialized;

            return RedirectToAction("Index");

        }
    }
}