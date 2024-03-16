using System;
using System.Data;

using AOP = DataLibrary.SqlClientOperation;
using Val = General.ZValidation;
using BusinessLibrary.Table;

namespace BusinessLibrary.Transaction
{
    public class BOCertiStructure_Type_STD_Details
    {
        String Conn_String = System.Configuration.ConfigurationManager.ConnectionStrings["MainConnectionString"].ConnectionString;


        private DataSet _DS = new DataSet();
    

        public DataSet DS
        {
            get
            {
                return _DS;
            }
        }

        public int CustInq_First_Step_Disp()
        {
            General.ZGeneral.SqlInfo MainDBConnection_SqlInfo_1 = new General.ZGeneral.SqlInfo();
            MainDBConnection_SqlInfo_1.ConnectionString = Conn_String;


            AOP.Params Params_1 = new AOP.Params();
            AOP.FillDataSet_Z FillDataSet_Z_1 = null;
            int ReturnValue_int = -1;


            FillDataSet_Z_1 = AOP.FillDataSet(MainDBConnection_SqlInfo_1, _DS, TPV.TableName.CustInq_First_Step_Disp, TPV.SProc.usp_CustInq_First_Step_Disp, Params_1, String.Empty);
            if (FillDataSet_Z_1.SucceedOrFail == General.ZGeneral.SucceedFail_enum.Succeed)
            {
                if (DS.Tables.Count > 0 && DS.Tables[TPV.TableName.CustInq_First_Step_Disp].Rows.Count > 0)
                {
                    ReturnValue_int = 1;
                }

                ReturnValue_int = 0;
            }
            FillDataSet_Z_1.Dispose();
            FillDataSet_Z_1 = null;
            return ReturnValue_int;
        }

    }
}