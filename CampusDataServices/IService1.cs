using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using CampusDataServices.DataContract;

namespace CampusDataServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        // TODO: Add your service operations here
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/Getuserinfo/", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        UserInfoDataContract Getuserinfo();
    }
}
