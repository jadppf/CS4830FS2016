using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfREST
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        [WebGet(UriTemplate="Products", ResponseFormat=WebMessageFormat.Json)]
        IEnumerable<Product> GetAllProducts();

        [OperationContract]
        [WebInvoke(
            Method ="GET", 
            UriTemplate="Products/{id}", 
            ResponseFormat=WebMessageFormat.Json)]
        Product GetProduct(string id);

        [OperationContract]
        [WebInvoke(
            Method = "POST",
            UriTemplate = "Products",
            BodyStyle = WebMessageBodyStyle.Wrapped,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        void AddProduct(string Name, string Category, decimal Price);
    }



    [DataContract]
    public class Product
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Category { get; set; }

        [DataMember]
        public decimal Price { get; set; }
    }
}
