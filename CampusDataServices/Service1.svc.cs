using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using CampusDataServices.DataContract;
using CrystalDatabase;

namespace CampusDataServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public UserInfoDataContract Getuserinfo()
        {
            UserInfoDataContract userInfoDataContract = new UserInfoDataContract();
            userinfo userinfo;
            userInfoDataContract.Message = "Service Call !!!";
            userInfoDataContract.Status = true;
            for (int counter = 0; counter < 10; counter++)
            {
                userinfo = new userinfo();
                userinfo.UserId = counter + 1;
                userinfo.fname = "Gaurav";
                userinfo.mname = "";
                userinfo.lname = "Kaushik";
                userinfo.age = 24;
                userinfo.DOB = "02/04/1990";
                userInfoDataContract.Data.Add(userinfo);
            }

            return userInfoDataContract;
        }
    }
}
