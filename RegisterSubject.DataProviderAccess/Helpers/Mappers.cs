using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterSubject.DataProviderAccess.Helpers
{
    public static class Mappers
    {
        /// <summary>
        /// Realiza la trasformacion de un objeto a otro
        /// </summary>
        /// <typeparam name="Tsource">Entidad de Salida</typeparam>
        /// <typeparam name="Ttarget">Entidad de Salida</typeparam>
        /// <param name="_object">Objeto al cual se trasformara</param>
        /// <returns></returns>
        public static Tsource Mapper<Tsource, Ttarget>(this Ttarget _object)
        {
            var settings = new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                PreserveReferencesHandling = PreserveReferencesHandling.Objects
            };

            return Newtonsoft.Json.JsonConvert.DeserializeObject<Tsource>(Newtonsoft.Json.JsonConvert.SerializeObject(_object, settings));
        }


        /// <summary>
        /// Realiza la trasformacion de una lista de objetos a otro
        /// </summary>
        /// <typeparam name="Tsource">Entidad de Salida</typeparam>
        /// <typeparam name="Ttarget">Entidad de Salida</typeparam>
        /// <param name="_object">Objeto al cual se trasformara</param>
        /// <returns></returns>
        public static List<Tsource> Mapper<Tsource, Ttarget>(this List<Ttarget> _object)
        {
            List<Tsource> list = new List<Tsource>();
            foreach (var item in _object)
            {
                list.Add(Mapper<Tsource, Ttarget>(item));
            }
            return list;
        }
    }
}
