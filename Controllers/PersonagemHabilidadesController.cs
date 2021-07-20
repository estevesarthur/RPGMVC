using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RpgMvc.Models;

namespace RpgMvc.Controllers
{
    public class PersonagemHabilidadesController : Controller
    {
        public string uriBase = "http://estevesarthur.somee.com/RpgApi/PersonagemHabilidades/";

        //Método responsável por listar as habilidades 
        [HttpGet("PersonagemHabilidades/{id}")]
        public async Task<ActionResult> IndexAsync(int id)
        {
            HttpClient httpClient = new HttpClient();

            string token = HttpContext.Session.GetString("SessionTokenUsuario");
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            HttpResponseMessage response = await httpClient.GetAsync(uriBase + id.ToString());

            string serialized = await response.Content.ReadAsStringAsync();

            List<PersonagemHabilidadesViewModel> lista = await Task.Run(() => 
                JsonConvert.DeserializeObject<List<PersonagemHabilidadesViewModel>>(serialized));

            return View(lista);
        }

        [HttpGet]
        public async Task<ActionResult> DeleteAsync(int habilidadeId, int personagemId)
        {
            HttpClient httpClient = new HttpClient();
            //Rota da API sendo guardada para concatenar com o endereço base
            string uriComplementar = "DeletePersonagemHabilidade";

            //Recuperação do token da sessão e armazenamento dela no HttpClient  
            string token = HttpContext.Session.GetString("SessionTokenUsuario");
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer" , token);

            //Objeto sendo preenchido pelo que foi passado no parâmetro do método
            PersonagemHabilidadesViewModel ph = new PersonagemHabilidadesViewModel();
            ph.HabilidadeId = habilidadeId;
            ph.PersonagemId = personagemId;

            //Serialização do objeto e envio para a API de acordo com o endereço completo
            var content = new StringContent(JsonConvert.SerializeObject(ph));
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            HttpResponseMessage response = await httpClient.PostAsync(uriBase + uriComplementar, content);

            //Variável serialized para guardar a mensagem de retornoda API de acordo com sucesso(200) ou erro
            string serialized =  await response.Content.ReadAsStringAsync();
            
            if(response.StatusCode == System.Net.HttpStatusCode.OK)
                TempData["Mensagem"] = serialized;
            else
                TempData["MensagemErro"] = serialized;

            //Redirecionamento para o método Index da controller de Personagens
            return RedirectToAction("Index", "Personagens");
        }


        //Método responsável por atriburi habilidade a um personagem
        [HttpGet]
        public async Task<ActionResult> Create(int id, string nome)
        {
            string uriComplementar = "GetHabilidades";
            HttpClient httpClient = new HttpClient();

            string token = HttpContext.Session.GetString("SessionTokenUsuario");
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            HttpResponseMessage response = await httpClient.GetAsync(uriBase + uriComplementar);
            
            string serialized = await response.Content.ReadAsStringAsync();
            List<HabilidadeViewModel> habilidades = await Task.Run(() => 
                JsonConvert.DeserializeObject<List<HabilidadeViewModel>>(serialized));

            ViewBag.ListaHabilidades = habilidades;

            PersonagemHabilidadesViewModel ph = new PersonagemHabilidadesViewModel();
            ph.Personagem = new PersonagemViewModel();
            ph.Habilidade = new HabilidadeViewModel();
            ph.PersonagemId = id;
            ph.Personagem.Nome = nome;
            
            return View(ph);       
        }

        //Método responsável por
        [HttpPost]
        public async Task<ActionResult> CreateAsync(PersonagemHabilidadesViewModel ph)
        {
            HttpClient httpClient = new HttpClient();

            string token = HttpContext.Session.GetString("SessionTokenUsuario");
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var content = new StringContent(JsonConvert.SerializeObject(ph));
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            HttpResponseMessage response = await httpClient.PostAsync(uriBase, content);

            string serialized = await response.Content.ReadAsStringAsync();

            if(response.StatusCode == System.Net.HttpStatusCode.OK)
                TempData["Mensagem"] = "Habilidade cadastrada com sucesso";
            else

            TempData["MensagemErro"] = serialized;

            return RedirectToAction("Index", "PersonagemHabilidades" , new {id = ph.PersonagemId});
        }
    }
}