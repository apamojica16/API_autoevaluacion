using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using API_autoevaluacion.Models;

namespace API_autoevaluacion.Controllers
{
    public class NotasController : ApiController
    {
       

            Autoevaluaciones[] notas = new Autoevaluaciones[]{
 new Autoevaluaciones{name="Lab1", nota=4.5},
 new Autoevaluaciones {name="Lab2", nota=4.0},
 new Autoevaluaciones {name="Lab3", nota=4.0},
 new Autoevaluaciones {name="Blog", nota=4.5}
        };

            public IEnumerable<Autoevaluaciones> GetAllProducts()
            {
                return notas;
            }

            public Autoevaluaciones GetProduct(string id)
            {
                var snota = (notas.FirstOrDefault((p) => p.name == id));
                if (snota == null)
                {
                    throw new HttpResponseException(
                        Request.CreateResponse(HttpStatusCode.NotFound));
                }
                return snota;
            }



        }
    }

