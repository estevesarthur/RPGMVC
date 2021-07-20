using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RpgMvc.Models;


namespace RpgMvc.Controllers
{
    public class ArmaController : Controller
    {
        
        public string uriBaseArma = "http://estevesarthur.somee.com/RpgApi/Arma/";


        public async Task<IActionResult> IndexAsync()
        {
            string uriComplementar = "GetAll";
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage response = await httpClient.GetAsync(uriBaseArma + uriComplementar);
            
            string serialized = await response.Content.ReadAsStringAsync();

            List<ArmaViewModel> listaArmas = await Task.Run(() => 
                JsonConvert.DeserializeObject<List<ArmaViewModel>>(serialized));

            return View(listaArmas);
        }


        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> CreateAsync(ArmaViewModel a)
        {
            HttpClient httpClient = new HttpClient();

            var content = new StringContent(JsonConvert.SerializeObject(a));
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            HttpResponseMessage response = await httpClient.PostAsync(uriBaseArma, content);

            string serialized = await response.Content.ReadAsStringAsync();

            await Task.Run(() => 
                JsonConvert.DeserializeObject<List<ArmaViewModel>>(serialized));

            TempData["Mensagem"] = string.Format("Arma {0} salva com sucesso!", a.Nome);

            return RedirectToAction("Index");
        }


        [HttpGet]
        public async Task<ActionResult> DetailsAsync(int id)
        {
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage response = await httpClient.GetAsync(uriBaseArma + id.ToString());

            string serialized = await response.Content.ReadAsStringAsync();

            ArmaViewModel a = await Task.Run(() => 
                JsonConvert.DeserializeObject<ArmaViewModel>(serialized));

            return View(a);
        }

        //Carregará a View após pegar todos os dados da Arma
        public async Task<ActionResult> EditAsync(int id)
        {
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage response = await httpClient.GetAsync(uriBaseArma + id.ToString());
            
            string serialized = await response.Content.ReadAsStringAsync();

            ArmaViewModel a = await Task.Run(() => 
                JsonConvert.DeserializeObject<ArmaViewModel>(serialized));
            
            return View(a);
        }
        //Enviará os dados para o Bando de dados
        [HttpPost]
        public async Task<ActionResult> EditAsync(ArmaViewModel a)
        {
            HttpClient httpClient = new HttpClient();

            var content = new StringContent(JsonConvert.SerializeObject(a));
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            HttpResponseMessage response = await httpClient.PutAsync(uriBaseArma, content);

            TempData["Mensagem"] = string.Format("Arma {0} atualizada com sucesso!", a.Nome);

            return RedirectToAction("Index");
        }


        [HttpGet]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            HttpClient httpClient = new HttpClient();
            
            HttpResponseMessage response = await httpClient.DeleteAsync(uriBaseArma + id.ToString());

            TempData["Mensagem"] = string.Format("Arma {0} deletada com sucesso!", id);

            return RedirectToAction("Index");
        }
    }
}