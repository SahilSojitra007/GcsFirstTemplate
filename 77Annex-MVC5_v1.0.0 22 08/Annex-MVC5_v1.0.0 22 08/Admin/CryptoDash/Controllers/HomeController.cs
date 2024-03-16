using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AOP = DataLibrary.SqlClientOperation;
using BusinessLibrary.Transaction;
using BusinessLibrary.Table;
using System.Data.SqlClient;
using System.Data;
using Val = General.ZValidation;
namespace CryptoDash.Controllers
{
    public class HomeController : Controller
    {
        String Conn_String  = System.Configuration.ConfigurationManager.ConnectionStrings["MainConnectionString"].ConnectionString;
        List<cls_x_CustInq_First_Step_Disp> Result_collection = new List<cls_x_CustInq_First_Step_Disp>();

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult exchange()
        {
            return View();
        }
        public ActionResult mywallet()
        {
            BOCertiStructure_Type_STD_Details BOCertiStructure_Type_STD_Details_1 = new BOCertiStructure_Type_STD_Details();
            BOCertiStructure_Type_STD_Details_1.CustInq_First_Step_Disp();

            foreach (System.Data.DataRow DataRow_1 in BOCertiStructure_Type_STD_Details_1.DS.Tables[BusinessLibrary.TPV.TableName.CustInq_First_Step_Disp].Rows)
            {
                cls_x_CustInq_First_Step_Disp cls_x_CustInq_First_Step_Disp_1 = new cls_x_CustInq_First_Step_Disp();

                cls_x_CustInq_First_Step_Disp_1.TrnNo = Val.To_Int(DataRow_1["TrnNo"]);
                cls_x_CustInq_First_Step_Disp_1.TrnDate = Val.To_String(Val.To_DispDate( DataRow_1["TrnDate"]));
                cls_x_CustInq_First_Step_Disp_1.QuoteNo = Val.To_String(DataRow_1["QuoteNo"]);
                cls_x_CustInq_First_Step_Disp_1.ProjectNumber = Val.To_String(DataRow_1["ProjectNumber"]);
                cls_x_CustInq_First_Step_Disp_1.CertiStandards = Val.To_String(DataRow_1["CertiStandards"]);
                cls_x_CustInq_First_Step_Disp_1.P_Name = Val.To_String(DataRow_1["P_Name"]);
                cls_x_CustInq_First_Step_Disp_1.Owner_UserName = Val.To_String(DataRow_1["Owner_UserName"]);
                cls_x_CustInq_First_Step_Disp_1.Remark = Val.To_String(DataRow_1["Remark"]);
                cls_x_CustInq_First_Step_Disp_1.IsOpened = Val.To_String(Val.To_BooleanToInt( DataRow_1["IsOpened"]) == 1 ? "Yes" : "");
                cls_x_CustInq_First_Step_Disp_1.SignBackDate = Val.To_String(Val.To_DispDate(DataRow_1["SignBackDate"]));
                cls_x_CustInq_First_Step_Disp_1.ClosedDate = Val.To_String(Val.To_DispDate(DataRow_1["ClosedDate"]));
                cls_x_CustInq_First_Step_Disp_1.ReasonRem = Val.To_String(DataRow_1["ReasonRem"]);

                Result_collection.Add(cls_x_CustInq_First_Step_Disp_1);
            }
            return View(Result_collection);
        }
        public ActionResult calendar()
        {
            return View();
        }
        public ActionResult news()
        {
            return View();
        }
        public ActionResult ico()
        {
            return View();
        }
        public ActionResult setting()
        {
            return View();
        }
        public ActionResult login()
        {
            return View();
        }
        public ActionResult logout()
        {
            return View();
        }
        [ActionName("pages-blank")]
        public ActionResult pagesblank()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AddOrEdit(int id = 0)
        {
            return View(new cls_x_CustInq_First_Step_Disp());
        }

        [HttpPost]
        public ActionResult AddOrEdit(cls_x_CustInq_First_Step_Disp pc1)
        {
             
            return View();

        }

        public ActionResult Quotationdetail()
        {
            return View();
        }

        public ActionResult Notes()
        {
            return View();
        }
        public ActionResult FollowUp()
        {
            return View();
        }
    }
}