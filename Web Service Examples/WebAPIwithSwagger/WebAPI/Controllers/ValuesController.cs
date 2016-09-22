using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
    
    public class ValuesController : ApiController
    {
        static Dictionary<int, string> m_Values = new Dictionary<int, string>();

        // GET api/values
        public IEnumerable<string> Get()
        {
            List<string> list = new List<string>();
            foreach (var val in m_Values)
            {
                list.Add(val.Value);
            }
            return (list);

            //return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return m_Values[id];
        }

        // POST api/values
        public void Post(string value)
        {
            int iNewKey = m_Values.Count()+100;
            m_Values.Add(iNewKey, value);
        }

        // PUT api/values/5
        public void Put(int id, string value)
        {
            m_Values[id] = value;
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            m_Values.Remove(id);
        }
    }
}
