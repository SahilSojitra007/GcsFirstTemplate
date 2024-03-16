
namespace BusinessLibrary.TPV
{
    /// <summary>
    /// Contains All Database Stored Procedure Information
    /// </summary>
    public static class SProc
    {
        public const string usp_LangMast_Disp = "usp_LangMast_Disp";

        public const string usp_LedgerViewCurrDet = "usp_LedgerViewCurrDet";
        public const string usp_EngineerL_Delete = "usp_EngineerL_Delete";
        public const string usp_get_EngineerL_Max_EngID = "usp_get_EngineerL_Max_EngID";

        public const string usp_Util_Report_Display = "usp_Util_Report_Display";
        public const string usp_Util_Report_Save = "usp_Util_Report_Save";
        public const string usp_Check_ProjStatusSummaryMast_For_Delete = "usp_Check_ProjStatusSummaryMast_For_Delete";

        public const string RP_CustList = "RP_CustList";
        public const string RP_BalanceSheet = "RP_BalanceSheet";
        public const string RP_PAndLNet = "RP_PAndLNet";
        public const string RP_PAndLGross = "RP_PAndLGross";
        public const string RP_AccLedger = "RP_AccLedger";
        public const string RP_PAndLGross_Out = "RP_PAndLGross_Out";
        public const string RP_ExpensesRpt = "RP_ExpensesRpt";
        public const string RP_OpnClsStock = "RP_OpnClsStock";
        public const string RP_CreditorsDebtors = "RP_CreditorsDebtors";
        public const string RP_FinanceProfit2 = "RP_FinanceProfit2";
        public const string usp_Util_Report_Permission_Check = "usp_Util_Report_Permission_Check";
        public const string usp_AGrpMastSearch = "usp_AGrpMastSearch";
        public const string usp_UtilPerAccMast = "usp_UtilPerAccMast";
        public const string usp_ZLog_PayRecDisp = "usp_ZLog_PayRecDisp";
        public const string usp_ZLog_TrnMastSave = "usp_ZLog_TrnMastSave";
        public const string usp_ZLog_ContraDisp = "usp_ZLog_ContraDisp";
        public const string usp_TrnMast_Single_Delete = "usp_TrnMast_Single_Delete";
        public const string usp_SampleProcessingImages_Save = "usp_SampleProcessingImages_Save";
        public const string usp_SampleProcessingImages_Delete = "usp_SampleProcessingImages_Delete";
        public const string usp_Check_MileStoneMast_For_Delete = "usp_Check_MileStoneMast_For_Delete";
        public const string usp_EngineerImages_Desc1_Update = "usp_EngineerImages_Desc1_Update";

        public const string usp_PettyCashImages_Has_Image_Disp = "usp_PettyCashImages_Has_Image_Disp";
        public const string usp_PettyCashImages_Image_Found_Single = "usp_PettyCashImages_Image_Found_Single";
        public const string usp_PettyCashImages_Save = "usp_PettyCashImages_Save";
        public const string usp_PettyCashImages_OrigImage_Disp = "usp_PettyCashImages_OrigImage_Disp";
        public const string usp_PettyCashImages_Disp = "usp_PettyCashImages_Disp";

        public const string usp_EngineerImages_Save = "usp_EngineerImages_Save";
        public const string usp_EngineerImages_Delete = "usp_EngineerImages_Delete";
        public const string usp_EngineerImages_Disp = "usp_EngineerImages_Disp";
        public const string usp_EngineerAttachOthers_Disp = "usp_EngineerAttachOthers_Disp";

        public const string usp_EngineerAttachOthers_Save = "usp_EngineerAttachOthers_Save";

        public const string usp_SampleProcessingImages_Disp = "usp_SampleProcessingImages_Disp";

        public const string usp_SampleProcessingImages_Desc1_Update = "usp_SampleProcessingImages_Desc1_Update";
        public const string usp_EngineerAttachOthers_Icons_Disp = "usp_EngineerAttachOthers_Icons_Disp";
        public const string RP_IncodeExpenseStatement = "RP_IncodeExpenseStatement";

        public const string RP_FinanceProfit1 = "RP_FinanceProfit1";
        public const string usp_AgrpMast_View = "usp_AgrpMast_View";
        public const string RP_Ratio = "RP_Ratio";
        public const string RP_CashFlow = "RP_CashFlow";
        public const string RP_DayBook = "RP_DayBook";
        public const string RP_PayRecReg = "RP_PayRecReg";
        public const string RP_CashBankBook = "RP_CashBankBook";
        public const string RP_BalanceSheet_77 = "RP_BalanceSheet_77";
        public const string RP_PAndLNet_77 = "RP_PAndLNet_77";
        public const string usp_RP_PAndL_Net_And_Gross_Group_Template = "usp_RP_PAndL_Net_And_Gross_Group_Template";
        public const string RP_TrialBal = "RP_TrialBal";
        public const string usp_ZLog_JouRefNoSave = "usp_ZLog_JouRefNoSave";

        public const string usp_TrnMastSave = "usp_TrnMastSave";
        public const string usp_ZLog_ZLogJouRefNoDisp = "usp_ZLog_ZLogJouRefNoDisp";
        public const string usp_ZLog_JournalEntDisp = "usp_ZLog_JournalEntDisp";

        public const string usp_get_AccMatchPairNum_AccMatchedPair = "usp_get_AccMatchPairNum_AccMatchedPair";
        public const string usp_MatchPairDisp = "usp_MatchPairDisp";
        public const string usp_MatchPair_Save = "usp_MatchPair_Save";
        public const string usp_AccMatchedPair_Before_Apply = "usp_AccMatchedPair_Before_Apply";
        public const string usp_AccMatchedPair_Apply_Update = "usp_AccMatchedPair_Apply_Update";
        public const string usp_AccMatchedPair_Matched_AccMatchPairNum_Final_Reset = "usp_AccMatchedPair_Matched_AccMatchPairNum_Final_Reset";
        public const string usp_AccMatchedPair_Delete = "usp_AccMatchedPair_Delete";
        public const string usp_AccMatchedPair_Matched_AccMatchPairNum_Final_Update = "usp_AccMatchedPair_Matched_AccMatchPairNum_Final_Update";
        public const string usp_LedgerRemarkUpdate = "usp_LedgerRemarkUpdate";
        public const string usp_rep_BalanceSheet_del = "usp_rep_BalanceSheet_del";

        public const string usp_InvClosingStock = "usp_InvClosingStock";

        public const string usp_IPettyCashTrnDet = "usp_IPettyCashTrnDet";
        public const string usp_IPettyCashGetTrnDetNo = "usp_IPettyCashGetTrnDetNo";
        public const string usp_IPettyCashTrnDelete = "usp_IPettyCashTrnDelete";
        public const string usp_IPettyCashTrnSave = "usp_IPettyCashTrnSave";
        public const string usp_IPettyCashGetPar = "usp_IPettyCashGetPar";
        public const string usp_Fill_Months = "usp_Fill_Months";


        public const string usp_JouEntDblDetNoDel = "usp_JouEntDblDetNoDel";
        public const string usp_JouEntDblDel = "usp_JouEntDblDel";
        public const string usp_JouEntDblRecNav = "usp_JouEntDblRecNav";
        public const string usp_JouEntDblSearch = "usp_JouEntDblSearch";
        public const string usp_JouEntDblDisp = "usp_JouEntDblDisp";
        public const string usp_JouEntDblDetNoDisp = "usp_JouEntDblDetNoDisp";
        public const string usp_JouEntDblDetNo_All_Loop_Delete = "usp_JouEntDblDetNo_All_Loop_Delete";
        public const string usp_JouEntDblDetNoSave = "usp_JouEntDblDetNoSave";
        public const string usp_JouEntDbl_All_Loop_Delete = "usp_JouEntDbl_All_Loop_Delete";
        public const string usp_LedgerView_AccMatch = "usp_LedgerView_AccMatch";
        public const string usp_LedgerView = "usp_LedgerView";

        public const string usp_ReportHeaderDisp = "usp_ReportHeaderDisp";
        public const string RP_AccLedgerPartyTrnNoWise = "RP_AccLedgerPartyTrnNoWise";
        public const string usp_ReportHeaderSave = "usp_ReportHeaderSave";

        public const string usp_SampleIn_MainQuan_Pend_Fill = "usp_SampleIn_MainQuan_Pend_Fill";

        public const string usp_SampleInH_Save = "usp_SampleInH_Save";
        public const string usp_SampleInL_Save = "usp_SampleInL_Save";
        public const string usp_SampleIn_Delete = "usp_SampleIn_Delete";
        public const string usp_SampleIn_Disp = "usp_SampleIn_Disp";
        public const string usp_SampleInH_RecNav = "usp_SampleInH_RecNav";
        public const string usp_SampleInH_Search = "usp_SampleInH_Search";
        public const string usp_get_Par_Bal = "usp_get_Par_Bal";
        public const string usp_JouEntDblSave = "usp_JouEntDblSave";

        public const string usp_SampleInL_Disp = "usp_SampleInL_Disp";
        public const string usp_NewId_SampleInH = "usp_NewId_SampleInH";

        public const string usp_AccCompanyDynMast_Fill = "usp_AccCompanyDynMast_Fill";
        public const string usp_Get_ParMast_CnCy_From_db = "usp_Get_ParMast_CnCy_From_db";

        public const string usp_SampleIn_SamID_Det = "usp_SampleIn_SamID_Det";
        public const string usp_RemParDetail_Type_Fill = "usp_RemParDetail_Type_Fill";
        public const string usp_SampOperationMast_Disp = "usp_SampOperationMast_Disp";
        public const string usp_After_Test_Process_Fill = "usp_After_Test_Process_Fill";

        public const string usp_RemMast_Disp = "usp_RemMast_Disp";
        public const string usp_RemMast_Save = "usp_RemMast_Save";
        public const string usp_CheckRemarkTranForDelete = "usp_CheckRemarkTranForDelete";
        public const string usp_CheckRemMastForDelete = "usp_CheckRemMastForDelete";
        public const string usp_RemarkTran_Combo_Fill = "usp_RemarkTran_Combo_Fill";
        public const string usp_RemarkTran_Disp = "usp_RemarkTran_Disp";
        public const string usp_RemarkTran_Fill = "usp_RemarkTran_Fill";
        public const string usp_RemarkTran_Save = "usp_RemarkTran_Save";


        public const string usp_PCompImages_Bank_Save = "usp_PCompImages_Bank_Save";
        public const string usp_PCompImages_Bank_OrigImage_Disp = "usp_PCompImages_Bank_OrigImage_Disp";
        public const string usp_PCompImages_Bank_Disp = "usp_PCompImages_Bank_Disp";
        public const string usp_PCompImages_Bank_DeleteAll = "usp_PCompImages_Bank_DeleteAll";

        public const string usp_Util_TilePer_Fill = "usp_Util_TilePer_Fill";
        public const string usp_Fill_TilesPermission = "usp_Fill_TilesPermission";
        public const string usp_Util_TilePer_Save = "usp_Util_TilePer_Save";

        public const string usp_PCompImages_Comp_DeleteAll = "usp_PCompImages_Comp_DeleteAll";
        public const string usp_PCompImages_Comp_Disp = "usp_PCompImages_Comp_Disp";
        public const string usp_PCompImages_Comp_OrigImage_Disp = "usp_PCompImages_Comp_OrigImage_Disp";
        public const string usp_PCompImages_Comp_Save = "usp_PCompImages_Comp_Save";
        public const string usp_UserWiseColWidth_Save = "usp_UserWiseColWidth_Save";

        public const string usp_SampleImages_New_SrNo = "usp_SampleImages_New_SrNo";
        public const string usp_AccBankUIDMast_IsBuffer_Update = "usp_AccBankUIDMast_IsBuffer_Update";

        public const string usp_UserWiseColWidth_Delete = "usp_UserWiseColWidth_Delete";

        public const string usp_AccBankUIDMast_Disp = "usp_AccBankUIDMast_Disp";
        public const string usp_Check_AccBankMast_For_Delete = "usp_Check_AccBankMast_For_Delete";
        public const string usp_Check_AccCompanyMast_For_Delete = "usp_Check_AccCompanyMast_For_Delete";
        public const string usp_AccBankDetail_Disp = "usp_AccBankDetail_Disp";
        public const string usp_AccBankDetail_Delete = "usp_AccBankDetail_Delete";
        public const string usp_AccCompUIDMast_Save = "usp_AccCompUIDMast_Save";
        public const string usp_AccCompanyDetail_Delete = "usp_AccCompanyDetail_Delete";
        public const string usp_Check_AccCompanyDynMast_For_Delete = "usp_Check_AccCompanyDynMast_For_Delete";
        public const string usp_Check_AccBankDynMast_For_Delete = "usp_Check_AccBankDynMast_For_Delete";

        public const string usp_AccCompanyDynMast_Det_CO_Name_Exists = "usp_AccCompanyDynMast_Det_CO_Name_Exists";
        public const string usp_PCompImages_Comp_Desc1_Update = "usp_PCompImages_Comp_Desc1_Update";
        public const string usp_PCompImages_Bank_Desc1_Update = "usp_PCompImages_Bank_Desc1_Update";

        public const string usp_AccCompanyDetail_Update = "usp_AccCompanyDetail_Update";

        public const string usp_InvImgDisp = "usp_InvImgDisp";
        public const string usp_InvImgSave = "usp_InvImgSave";
        public const string usp_CheckTrnNoExist_ForInvImg = "usp_CheckTrnNoExist_ForInvImg";
        public const string usp_InvImg_OrigImage_Disp = "usp_InvImg_OrigImage_Disp";
        public const string usp_ChopImageSave = "usp_ChopImageSave";

        public const string usp_AccParGroupDetail_Disp = "usp_AccParGroupDetail_Disp";
        public const string usp_AccAliasNameDetail_Get_Last_ALS_Name = "usp_AccAliasNameDetail_Get_Last_ALS_Name";
        public const string usp_AccCompanyDynMast_Save = "usp_AccCompanyDynMast_Save";
        public const string usp_ChopImage_OrigImage_Disp = "usp_ChopImage_OrigImage_Disp";

        public const string usp_AccAliasNameDetail_Disp = "usp_AccAliasNameDetail_Disp";
        public const string usp_AccCompanyMast_Dynamic_Add = "usp_AccCompanyMast_Dynamic_Add";
        public const string usp_AccCompanyDetail_Save = "usp_AccCompanyDetail_Save";

        public const string usp_AccBankMast_Disp = "usp_AccBankMast_Disp";

        public const string usp_AccParGroupDetail_Delete = "usp_AccParGroupDetail_Delete";
        public const string usp_AccAliasNameDetail_Delete = "usp_AccAliasNameDetail_Delete";
        public const string usp_AccBankMast_Dynamic_Add = "usp_AccBankMast_Dynamic_Add";

        public const string usp_AccBankDynMast_Save = "usp_AccBankDynMast_Save";
        public const string usp_AccBankDynMast_Fill = "usp_AccBankDynMast_Fill";

        public const string usp_AccBankDetail_Save = "usp_AccBankDetail_Save";


        public const string usp_QuoteLinkL_Disp_DESK = "usp_QuoteLinkL_Disp_DESK";


        public const string usp_QuoteLinkL_Save_DESK = "usp_QuoteLinkL_Save_DESK";
        public const string usp_QuoteLinkL_Delete_DESK = "usp_QuoteLinkL_Delete_DESK";
        public const string usp_QuoteLinkL_Gen_Description = "usp_QuoteLinkL_Gen_Description";
        public const string usp_AccParGroupDetail_Get_IsMain_ACP_GRP_Name = "usp_AccParGroupDetail_Get_IsMain_ACP_GRP_Name";

        public const string usp_Check_AccParGroupMast_For_Delete = "usp_Check_AccParGroupMast_For_Delete";

        public const string usp_CertiStructureL_DYN_Combo_Fill = "usp_CertiStructureL_DYN_Combo_Fill";
        public const string usp_CertiTypeMast_Image_Disp = "usp_CertiTypeMast_Image_Disp";
        public const string usp_CertiTypeMast_Image_Using_Name_Disp = "usp_CertiTypeMast_Image_Using_Name_Disp";

        public const string usp_CertiStructureL_Image_Disp = "usp_CertiStructureL_Image_Disp";
        public const string usp_CertiTypeMast_Image_Using_CTYPE_Code = "usp_CertiTypeMast_Image_Using_CTYPE_Code";

        public const string usp_NotesMast_Detail_Disp_DESK = "usp_NotesMast_Detail_Disp_DESK";
        public const string usp_NotesMast_Detail_Delete = "usp_NotesMast_Detail_Delete";

        public const string usp_FollowUpMast_Detail_Disp = "usp_FollowUpMast_Detail_Disp";
        public const string usp_FollowUpMast_Detail_Delete = "usp_FollowUpMast_Detail_Delete";

        public const string usp_FollowUpMast_Third_Part_Detail_Disp = "usp_FollowUpMast_Third_Part_Detail_Disp";
        public const string usp_FollowUpMast_Second_Part_Detail_Disp = "usp_FollowUpMast_Second_Part_Detail_Disp";


        public const string usp_NotesH_Gen_Description = "usp_NotesH_Gen_Description";
        public const string usp_NotesL_Disp_DESK = "usp_NotesL_Disp_DESK";
        public const string usp_NotesL_Save_DESK = "usp_NotesL_Save_DESK";
        public const string usp_NotesH_Delete_DESK = "usp_NotesH_Delete_DESK";
        public const string usp_NotesH_Combo_Fill = "usp_NotesH_Combo_Fill";
        public const string usp_NotesH_Buffer_Save = "usp_NotesH_Buffer_Save";
        public const string usp_NotesH_Disp = "usp_NotesH_Disp";
        public const string usp_NotesH_Save_DESK = "usp_NotesH_Save_DESK";
        public const string usp_CustInq_for_QuoteLinkL_Single_Disp = "usp_CustInq_for_QuoteLinkL_Single_Disp";
        public const string usp_CheckCurrencyForDelete = "usp_CheckCurrencyForDelete";
        public const string usp_CurrMast_Save = "usp_CurrMast_Save";
        public const string usp_FollowUpMast_Buffer_Save = "usp_FollowUpMast_Buffer_Save";
        public const string usp_NotesMast_Buffer_Save = "usp_NotesMast_Buffer_Save";
        public const string usp_QuotationPrint_Certi_Disp = "usp_QuotationPrint_Certi_Disp";
        public const string usp_CertiTypeMast_Image_Save = "usp_CertiTypeMast_Image_Save";
        public const string usp_QuotationPrint_Header_Save = "usp_QuotationPrint_Header_Save";
        public const string usp_InvImg_Disp = "usp_InvImg_Disp";
        public const string usp_InvImages_Delete = "usp_InvImages_Delete";

        public const string usp_QuotationPrint_Header_Delete = "usp_QuotationPrint_Header_Delete";
        public const string usp_FollowUpMast_Detail_Unsaved_Buffer_Delete = "usp_FollowUpMast_Detail_Unsaved_Buffer_Delete";
        public const string usp_QuotationPrint_Header_Disp = "usp_QuotationPrint_Header_Disp";


        public const string usp_QuotationPrint_Notes_Disp = "usp_QuotationPrint_Notes_Disp";
        public const string usp_QuotationPrint_FollowUp_Disp = "usp_QuotationPrint_FollowUp_Disp";

        public const string usp_QuotationPrint_Header_All_Lang_Disp = "usp_QuotationPrint_Header_All_Lang_Disp";

        public const string usp_TypeOfPayment_Fill = "usp_TypeOfPayment_Fill";


        public const string usp_NotesMast_Fill = "usp_NotesMast_Fill";

        public const string usp_CurrComMast_Fill = "usp_CurrComMast_Fill";


        public const string usp_SalesPerson_ML_Mast_All_Lang_Disp = "usp_SalesPerson_ML_Mast_All_Lang_Disp";
        public const string usp_SalesPerson_ML_Mast_Save = "usp_SalesPerson_ML_Mast_Save";


        public const string usp_CertiStructureL_Disp_DESK = "usp_CertiStructureL_Disp_DESK";

        public const string usp_MastParMastFill = "usp_MastParMastFill";

        public const string usp_ParTagImg_Delete = "usp_ParTagImg_Delete";
        public const string usp_PCompMastDel = "usp_PCompMastDel";
        public const string usp_PCompMastCompSave = "usp_PCompMastCompSave";
        public const string usp_PCompMast_SEARCH = "usp_PCompMast_SEARCH";
        public const string usp_PCompMastCompDisp = "usp_PCompMastCompDisp";
        public const string usp_ParTagImg_Disp = "usp_ParTagImg_Disp";
        public const string usp_AGrpMastDisp = "usp_AGrpMastDisp";
        public const string usp_Ready_to_change_P_Name = "usp_Ready_to_change_P_Name";
        public const string usp_ParMastNextCode = "usp_ParMastNextCode";
        public const string usp_ParMast_Code_Updation = "usp_ParMast_Code_Updation";
        public const string usp_ParMast_Code_Updation_In_Grid = "usp_ParMast_Code_Updation_In_Grid";

        public const string usp_ParTagImg_MORE_Disp = "usp_ParTagImg_MORE_Disp";
        public const string usp_CheckParMastForDelete = "usp_CheckParMastForDelete";
        public const string usp_ParTagImg_Updation = "usp_ParTagImg_Updation";
        public const string usp_Check_SalesPersonMast_For_Delete = "usp_Check_SalesPersonMast_For_Delete";
        public const string usp_SalesPersonMast_Buffer_Save = "usp_SalesPersonMast_Buffer_Save";
        public const string usp_Check_SalesPersonTitleMast_For_Delete = "usp_Check_SalesPersonTitleMast_For_Delete";
        public const string usp_SalesPersonTitleMast_Buffer_Save = "usp_SalesPersonTitleMast_Buffer_Save";

        public const string usp_AccCompanyDetail_Disp = "usp_AccCompanyDetail_Disp";
        public const string usp_AccCompUIDMast_Disp = "usp_AccCompUIDMast_Disp";
        public const string usp_AccBankUIDMast_Get_P_Code_BKUID = "usp_AccBankUIDMast_Get_P_Code_BKUID";
        public const string usp_AccCompUIDMast_Get_P_Code_CompUID = "usp_AccCompUIDMast_Get_P_Code_CompUID";

        public const string usp_AccCompUIDMast_IsBuffer_Unsaved_Delete = "usp_AccCompUIDMast_IsBuffer_Unsaved_Delete";
        public const string usp_AccCompanyDetail_Default_Disp = "usp_AccCompanyDetail_Default_Disp";


        public const string usp_AccCompUIDMast_IsBuffer_Update = "usp_AccCompUIDMast_IsBuffer_Update";

        public const string usp_AccBankUIDMast_IsBuffer_Unsaved_Delete = "usp_AccBankUIDMast_IsBuffer_Unsaved_Delete";


        public const string usp_CertiStructureH_Buffer_Save = "usp_CertiStructureH_Buffer_Save";

        public const string usp_FollowUpH_Buffer_Save = "usp_FollowUpH_Buffer_Save";

        public const string usp_ProductTypeMast_Buffer_Save = "usp_ProductTypeMast_Buffer_Save";
        public const string usp_CustMast_Buffer_Save = "usp_CustMast_Buffer_Save";
        public const string usp_CertiTypeMast_Buffer_Save = "usp_CertiTypeMast_Buffer_Save";
        public const string usp_CertiStandMast_Buffer_Save = "usp_CertiStandMast_Buffer_Save";
        public const string usp_AttentionMast_Buffer_Save = "usp_AttentionMast_Buffer_Save";
        public const string usp_MastAccYearFill = "usp_MastAccYearFill";
        public const string usp_UnitMast_Buffer_Save = "usp_UnitMast_Buffer_Save";

        public const string usp_Check_CustMast_For_Delete = "usp_Check_CustMast_For_Delete";
        public const string usp_Check_CertiStandMast_For_Delete = "usp_Check_CertiStandMast_For_Delete";
        public const string usp_Check_CertiTypeMast_For_Delete = "usp_Check_CertiTypeMast_For_Delete";
        public const string usp_Check_AttentionMast_For_Delete = "usp_Check_AttentionMast_For_Delete";
        public const string usp_Check_ProductTypeMast_For_Delete = "usp_Check_ProductTypeMast_For_Delete";
        public const string usp_Check_ParMast_For_Delete = "usp_Check_ParMast_For_Delete";
        public const string usp_Check_FollowUpMast_For_Delete = "usp_Check_FollowUpMast_For_Delete";
        public const string usp_Check_NotesMast_For_Delete = "usp_Check_NotesMast_For_Delete";
        public const string usp_Check_UnitMast_For_Delete = "usp_Check_UnitMast_For_Delete";

        public const string usp_Check_ProjStatusMast_For_Delete = "usp_Check_ProjStatusMast_For_Delete";

        public const string usp_Check_SPRS_All_Master_For_Delete = "usp_Check_SPRS_All_Master_For_Delete";


        public const string usp_CertiStructureL_Delete_DESK = "usp_CertiStructureL_Delete_DESK";

        public const string usp_FollowUpH_Delete_DESK = "usp_FollowUpH_Delete_DESK";

        public const string usp_CustInq_NewID = "usp_CustInq_NewID";
        public const string usp_CustInq_Buffer_TranNos_NewID = "usp_CustInq_Buffer_TranNos_NewID";
        public const string usp_BufferTrnNo_Min_Minus_TrnNo_Buffer = "usp_BufferTrnNo_Min_Minus_TrnNo_Buffer";
        public const string usp_Buffer_FollowUpMast_Detail_LTZ = "usp_Buffer_FollowUpMast_Detail_LTZ";


        public const string usp_CustInqH_Delete_Prev_Manual_Cancel = "usp_CustInqH_Delete_Prev_Manual_Cancel";
        public const string usp_BufferTrnNoSample_Min_Minus_TrnNo_Buffer = "usp_BufferTrnNoSample_Min_Minus_TrnNo_Buffer";

        public const string usp_CustInqH_All_Buffer_minus_Clear_After_New = "usp_CustInqH_All_Buffer_minus_Clear_After_New";
        public const string usp_SampleProcessing_L_Save = "usp_SampleProcessing_L_Save";

        public const string usp_CustInqH_All_Buffer_minus_Tran_Save = "usp_CustInqH_All_Buffer_minus_Tran_Save";
        public const string usp_CertiStructureH_NewID = "usp_CertiStructureH_NewID";
        public const string usp_CustInqH_NewProjectNumber = "usp_CustInqH_NewProjectNumber";
        public const string usp_get_Max_CertiStructureL = "usp_get_Max_CertiStructureL";
        public const string usp_SampleProcessing_Delete = "usp_SampleProcessing_Delete";
        public const string usp_EngineerL_Save = "usp_EngineerL_Save";

        public const string usp_get_Max_CTYPE_Code_CertiTypeMast = "usp_get_Max_CTYPE_Code_CertiTypeMast";

        public const string usp_Sample_All_Buffer_minus_Clear_After_New = "usp_Sample_All_Buffer_minus_Clear_After_New";

        public const string usp_CustInq_Delete_DESK = "usp_CustInq_Delete_DESK";
        public const string usp_CustInq_Navigation_DESK = "usp_CustInq_Navigation_DESK";
        public const string usp_CustInqL_Save_DESK = "usp_CustInqL_Save_DESK";
        public const string usp_CustInqH_Save_DESK = "usp_CustInqH_Save_DESK";
        public const string usp_CustInqL_Disp_DESK = "usp_CustInqL_Disp_DESK";
        public const string usp_CustInqH_Disp_DESK = "usp_CustInqH_Disp_DESK";
        public const string usp_FollowUpH_Save_DESK = "usp_FollowUpH_Save_DESK";
        public const string usp_CustInqL_Update_Others_FollowUP_Details = "usp_CustInqL_Update_Others_FollowUP_Details";
        public const string usp_CustInqL_Others_Disp = "usp_CustInqL_Others_Disp";
        public const string usp_Quotation_Account_Entry_Check = "usp_Quotation_Account_Entry_Check";
        public const string usp_Engineer_Detail_Pop_Quotation_Det_Disp = "usp_Engineer_Detail_Pop_Quotation_Det_Disp";
        public const string usp_QuotationDetRowPop_Delete = "usp_QuotationDetRowPop_Delete";

        public const string usp_CertiStructureL_Standard_Delete = "usp_CertiStructureL_Standard_Delete";
        public const string usp_CertiStructureL_Standard_Save = "usp_CertiStructureL_Standard_Save";
        public const string usp_CertiStructureL_Standard_Disp = "usp_CertiStructureL_Standard_Disp";

        public const string usp_QuotationDetRowPop_Disp = "usp_QuotationDetRowPop_Disp";

        public const string usp_CustInqL_Update_Others_Notes_Details = "usp_CustInqL_Update_Others_Notes_Details";
        public const string usp_CustInqL_Update_Others_CertiStructure_Type_STD_Details = "usp_CustInqL_Update_Others_CertiStructure_Type_STD_Details";
        public const string usp_CertiStructureL_Standard_Buffer_Delete = "usp_CertiStructureL_Standard_Buffer_Delete";

        public const string usp_CustInq_Buffer_TranNos_Save = "usp_CustInq_Buffer_TranNos_Save";
        public const string usp_CustInqH_Copy_Prev = "usp_CustInqH_Copy_Prev";
        public const string usp_CertiStructureH_Save_DESK = "usp_CertiStructureH_Save_DESK";
        public const string usp_BufferTrnNo_Save = "usp_BufferTrnNo_Save";
        public const string usp_BufferTrnNo_done_Delete = "usp_BufferTrnNo_done_Delete";
        public const string usp_QuotationDetRowPop_Buffer_Delete = "usp_QuotationDetRowPop_Buffer_Delete";

        public const string usp_BufferTrnNoSample_Save = "usp_BufferTrnNoSample_Save";
        public const string usp_Show_ProjectNumber_Read = "usp_Show_ProjectNumber_Read";

        public const string usp_NotesH_get_NOTE_Name = "usp_NotesH_get_NOTE_Name";
        public const string usp_Print_Format_Fill = "usp_Print_Format_Fill";


        public const string usp_FollowUpH_get_FU_Name = "usp_FollowUpH_get_FU_Name";
        public const string usp_BufferTrnNoSample_done_Delete = "usp_BufferTrnNoSample_done_Delete";

        public const string usp_YesNo_Fill = "usp_YesNo_Fill";

        public const string usp_FollowUpL_Disp_DESK = "usp_FollowUpL_Disp_DESK";

        public const string usp_FollowUpH_Disp = "usp_FollowUpH_Disp";
        public const string usp_FollowUpH_Combo_Fill = "usp_FollowUpH_Combo_Fill";
        public const string usp_CertiStructureH_Combo_Fill = "usp_CertiStructureH_Combo_Fill";
        public const string usp_CertiStructureH_Disp = "usp_CertiStructureH_Disp";
        public const string usp_FollowUpH_Combo_Global_Fill = "usp_FollowUpH_Combo_Global_Fill";
        public const string usp_FollowUpMast_Fill = "usp_FollowUpMast_Fill";
        public const string usp_CertiType_DYN_Combo_Fill = "usp_CertiType_DYN_Combo_Fill";

        public const string usp_FollowUp_Second_Part_L_Disp_DESK = "usp_FollowUp_Second_Part_L_Disp_DESK";

        public const string usp_FollowUp_Third_Part_L_Disp_DESK = "usp_FollowUp_Third_Part_L_Disp_DESK";


        public const string usp_vw_CurrMast_Fill = "usp_vw_CurrMast_Fill";
        public const string usp_FollowUpL_Save_DESK = "usp_FollowUpL_Save_DESK";
        public const string usp_FollowUpH_Gen_Description = "usp_FollowUpH_Gen_Description";
        public const string usp_CustInq_for_QuoteLinkL_Combo = "usp_CustInq_for_QuoteLinkL_Combo";


        public const string usp_FollowUpMast_Detail_Save_DESK = "usp_FollowUpMast_Detail_Save_DESK";

        public const string usp_CurrMast_Disp = "usp_CurrMast_Disp";
        public const string usp_ParMast_Disp = "usp_ParMast_Disp";
        public const string usp_ParMast_Disp_ALL = "usp_ParMast_Disp_ALL";
        public const string usp_SalesPersonMast_Disp = "usp_SalesPersonMast_Disp";
        public const string usp_CertiStructureL_Save_DESK = "usp_CertiStructureL_Save_DESK";
        public const string usp_CertiStructureL_Gen_Description = "usp_CertiStructureL_Gen_Description";
        public const string usp_ParMast_Or_Alias_Check = "usp_ParMast_Or_Alias_Check";
        public const string usp_NotesMast_Detail_Save_DESK = "usp_NotesMast_Detail_Save_DESK";

        public const string usp_SalesPerson_ML_Mast_for_quotation_Fill = "usp_SalesPerson_ML_Mast_for_quotation_Fill";

        public const string usp_ProductTypeMast_Disp = "usp_ProductTypeMast_Disp";
        public const string usp_QuotationDetRowPop_Save = "usp_QuotationDetRowPop_Save";


        #region Sys Utility

        public const string usp_UserFactDepLineRem_Save = "usp_UserFactDepLineRem_Save";
        public const string usp_LineLock_CloseLIne = "usp_LineLock_CloseLIne";
        public const string usp_LineLock_Save = "usp_LineLock_Save";
        public const string usp_LineLock_Locked_ByOthers_Disp = "usp_LineLock_Locked_ByOthers_Disp";

        public const string usp_getSDate = "usp_getSDate";
        public const string usp_getSTime = "usp_getSTime";

        public const string USP_NewIdForMastTable = "USP_NewIdForMastTable";
        public const string usp_PerUserFactFreeze = "usp_PerUserFactFreeze";
        public const string usp_AccBankUIDMast_Save = "usp_AccBankUIDMast_Save";



        public const string usp_LExeVersion_mix_marDisp = "usp_LExeVersion_mix_marDisp";
        public const string usp_LExeVersion_mix_marSave = "usp_LExeVersion_mix_marSave";
        public const string usp_LineLock_FreezeTime_Lock_All_Lines = "usp_LineLock_FreezeTime_Lock_All_Lines";



        #endregion Sys Utility

        /* --------------------------------------------- */

        #region Master


        public const string usp_CustMast_Fill = "usp_CustMast_Fill";
        public const string usp_CustMast_Save = "usp_CustMast_Save";
        public const string usp_CustMast_DelCheck = "usp_CustMast_DelCheck";

        public const string usp_DeptMast_Fill = "usp_DeptMast_Fill";
        public const string usp_DeptMast_UserWise_Fill = "usp_DeptMast_UserWise_Fill";
        public const string usp_DeptMast_DelCheck = "usp_DeptMast_DelCheck";
        public const string usp_DeptMast_Get_Default = "usp_DeptMast_Get_Default";

        public const string usp_FactMast_UserWise_Fill = "usp_FactMast_UserWise_Fill";
        public const string usp_FactMast_DelCheck = "usp_FactMast_DelCheck";

        public const string usp_HDayMast_Fill = "usp_HDayMast_Fill";
        public const string usp_HDayMast_DelCheck = "usp_HDayMast_DelCheck";
        public const string usp_HDayMast_Get_Latest = "usp_HDayMast_Get_Latest";

        public const string usp_LineMast_Fill = "usp_LineMast_Fill";
        public const string usp_LineMast_DelCheck = "usp_LineMast_DelCheck";
        public const string usp_LineMast_Print_Fill = "usp_LineMast_Print_Fill";

        public const string usp_ProdMast_Fill = "usp_ProdMast_Fill";
        public const string usp_ProdMast_DelCheck = "usp_ProdMast_DelCheck";

        public const string usp_SizeMast_Fill = "usp_SizeMast_Fill";
        public const string usp_SizeMast_DelCheck = "usp_SizeMast_DelCheck";

        public const string usp_UnitMast_Fill = "usp_UnitMast_Fill";
        public const string usp_UnitMast_DelCheck = "usp_UnitMast_DelCheck";

        public const string usp_OHDayMast_Disp = "usp_OHDayMast_Disp";
        public const string usp_OHDayMast_Fill_Popup = "usp_OHDayMast_Fill_Popup";
        public const string usp_OHDayMast_Save = "usp_OHDayMast_Save";
        public const string usp_OHDayMast_Del = "usp_OHDayMast_Del";

        public const string usp_OWDayMast_Disp = "usp_OWDayMast_Disp";
        public const string usp_OWDayMast_Fill_Popup = "usp_OWDayMast_Fill_Popup";
        public const string usp_OWDayMast_Save = "usp_OWDayMast_Save";
        public const string usp_OWDayMast_Del = "usp_OWDayMast_Del";

        #endregion Master

        #region Transaction

        public const string usp_LineEnt_Search = "usp_LineEnt_Search";
        public const string usp_LineEnt_FinishDate = "usp_LineEnt_FinishDate";
        public const string usp_LineEnt_UpdNext = "usp_LineEnt_UpdNext";
        public const string usp_LineEnt_UpdNext_For_OnlDate = "usp_LineEnt_UpdNext_For_OnlDate";
        public const string usp_LineEnt_UpdOrd = "usp_LineEnt_UpdOrd";
        public const string usp_HDay_LineEnt_UpdAll = "usp_HDay_LineEnt_UpdAll";
        public const string usp_WDay_LineEnt_UpdAll = "usp_WDay_LineEnt_UpdAll";
        public const string usp_StartDate_LineEnt_UpdAll = "usp_StartDate_LineEnt_UpdAll";

        public const string usp_LineEnt_CopyLine = "usp_LineEnt_CopyLine";
        public const string usp_LineEnt_MoveLine = "usp_LineEnt_MoveLine";


        public const string usp_Get_WorkEnt_MaxTrnNo = "usp_Get_WorkEnt_MaxTrnNo";
        public const string usp_WorkEntH_Disp = "usp_WorkEntH_Disp";
        public const string usp_WorkEntL_Disp = "usp_WorkEntL_Disp";
        public const string usp_WorkEntH_Save = "usp_WorkEntH_Save";
        public const string usp_WorkEntL_Save = "usp_WorkEntL_Save";
        public const string usp_WorkEnt_Del = "usp_WorkEnt_Del";
        public const string usp_WorkEnt_RecNav = "usp_WorkEnt_RecNav";

        public const string usp_LineEnt_det_disp = "usp_LineEnt_det_disp";
        public const string usp_LineEnt_Disp = "usp_LineEnt_Disp";
        public const string usp_LineEnt_Save = "usp_LineEnt_Save";
        public const string usp_LineEnt_Save_Frozen = "usp_LineEnt_Save_Frozen";
        public const string usp_LineEnt_Del_Frozen = "usp_LineEnt_Del_Frozen";
        public const string usp_LineEnt_Reject_Frozen = "usp_LineEnt_Reject_Frozen";
        public const string usp_LineEnt_Del = "usp_LineEnt_Del";
        public const string usp_LineEnt_Get_Last_Changes = "usp_LineEnt_Get_Last_Changes";

        public const string usp_LineEntUserCols_Get_Cols = "usp_LineEntUserCols_Get_Cols";
        public const string usp_LineEntUserCols_Save = "usp_LineEntUserCols_Save";
        public const string usp_LineEntOrd_Save = "usp_LineEntOrd_Save";
        public const string usp_LineEntOrd_Del = "usp_LineEntOrd_Del";

        public const string usp_LineLock_IsLocked = "usp_LineLock_IsLocked";
        public const string usp_LineLock_AnyChange_Reset = "usp_LineLock_AnyChange_Reset";
        public const string usp_LineLock_LastChange_Diff_Check = "usp_LineLock_LastChange_Diff_Check";
        public const string usp_LineLock_FreezeTime_Check_Any_Lock = "usp_LineLock_FreezeTime_Check_Any_Lock";

        public const string usp_Get_LineFile_MaxFId = "usp_Get_LineFile_MaxFId";
        public const string usp_LineFile_Disp = "usp_LineFile_Disp";
        public const string usp_LineFile_Save = "usp_LineFile_Save";
        public const string usp_LineFile_Del = "usp_LineFile_Del";
        public const string usp_Is_LineFile_Exists = "usp_Is_LineFile_Exists";

        public const string usp_LineFile_Frozen_List = "usp_LineFile_Frozen_List";
        public const string usp_LineFile_Upd_From_Details = "usp_LineFile_Upd_From_Details";
        public const string usp_LineFile_Del_For_LineEnt = "usp_LineFile_Del_For_LineEnt";
        public const string usp_LineFile_Disp_For_LineEnt = "usp_LineFile_Disp_For_LineEnt";
        public const string usp_LineFile_Disp_For_LineEnt_Del = "usp_LineFile_Disp_For_LineEnt_Del";

        #endregion Transaction

        #region View

        public const string usp_WorkView_Disp = "usp_WorkView_Disp";

        #endregion View

        #region Report

        public const string RP_WorkRpt = "RP_WorkRpt";


        public const string RP_PurRegRpt = "RP_PurRegRpt";
        public const string RP_PurOutRpt = "RP_PurOutRpt";

        public const string RP_SalRegRpt = "RP_SalRegRpt";
        public const string RP_SalOutRpt = "RP_SalOutRpt";

        public const string RP_LineEntRpt = "RP_LineEntRpt";

        #endregion Report

        #region Utility

        public const string usp_PerUserCopyMove_Disp = "usp_PerUserCopyMove_Disp";
        public const string usp_PerUserCopyMove_Save = "usp_PerUserCopyMove_Save";

        public const string usp_LoginDet_Save = "usp_LoginDet_Save";

        public const string usp_UserActivity = "usp_UserActivity";
        public const string usp_UserActivitySave = "usp_UserActivitySave";
        public const string usp_UserActivityDelete = "usp_UserActivityDelete";

        public const string usp_CheckUserLogin = "usp_CheckUserLogin";
        public const string usp_UtilCheckUserLogin = "usp_UtilCheckUserLogin";
        public const string usp_UtilCheckUserLoginName = "usp_UtilCheckUserLoginName";
        public const string usp_UserLoginAuthentication = "usp_UserLoginAuthentication";
        public const string usp_Util_get_UserId_By_UserName = "usp_Util_get_UserId_By_UserName";
        public const string usp_Util_PassMast_Disp = "usp_Util_PassMast_Disp";
        public const string usp_CheckPassMastForDelete = "usp_CheckPassMastForDelete";

        public const string usp_LExeVersionDisp = "usp_LExeVersionDisp";

        public const string usp_X_UserCategory = "usp_X_UserCategory";
        public const string usp_FillUser = "usp_FillUser";
        public const string usp_UtilUserMastDisp = "usp_UtilUserMastDisp";
        public const string usp_UtilSaveAllUser = "usp_UtilSaveAllUser";
        public const string usp_UtilUserMastCreateUser = "usp_UtilUserMastCreateUser";
        public const string usp_UtilUserMastUserDel = "usp_UtilUserMastUserDel";
        public const string usp_UtilUserMastUserNameDel = "usp_UtilUserMastUserNameDel";
        public const string usp_UtilUserMastChangePass = "usp_UtilUserMastChangePass";

        public const string usp_UtilFormMast = "usp_UtilFormMast";
        public const string usp_UtilNewFormId = "usp_UtilNewFormId";
        public const string usp_UtilFormMastProgramWiseFill = "usp_UtilFormMastProgramWiseFill";
        public const string usp_FrmMast_Ready_For_Deletion = "usp_FrmMast_Ready_For_Deletion";

        public const string usp_MenuMastDisp = "usp_MenuMastDisp";
        public const string usp_UtilNewMenuId = "usp_UtilNewMenuId";
        public const string usp_MastDynMenuMastFill = "usp_MastDynMenuMastFill";
        public const string usp_UtilityMenuMastSave = "usp_UtilityMenuMastSave";
        public const string usp_UtilityMenuMastDelete = "usp_UtilityMenuMastDelete";
        public const string usp_MenuMast_Ready_For_Deletion = "usp_MenuMast_Ready_For_Deletion";
        public const string usp_QuoteNumTemplate_Disp = "usp_QuoteNumTemplate_Disp";

        public const string usp_Fill_User_CategoryWise = "usp_Fill_User_CategoryWise";
        public const string usp_Fill_User_ProgramWise = "usp_Fill_User_ProgramWise";
        public const string usp_Fill_User_MainProgramWise = "usp_Fill_User_MainProgramWise";
        public const string usp_Fill_All_User = "usp_Fill_All_User";
        public const string usp_UtilFrmPerMast = "usp_UtilFrmPerMast";
        public const string usp_MenuPerDisp = "usp_MenuPerDisp";
        public const string usp_UtilityPerMastSave = "usp_UtilityPerMastSave";
        public const string usp_UtilityPerMastDelete = "usp_UtilityPerMastDelete";
        public const string usp_UtilCheckUserWiseFormPer = "usp_UtilCheckUserWiseFormPer";

        public const string usp_Utility_Basic_Permission = "usp_Utility_Basic_Permission";
        public const string usp_UtilPermissionCopy = "usp_UtilPermissionCopy";


        #endregion Utility

        #region ZLog

        public const string usp_ZLogWorkEnt_Save = "usp_ZLogWorkEnt_Save";
        public const string usp_ZLogWorkEnt_Disp = "usp_ZLogWorkEnt_Disp";

        #endregion ZLog

        /* --------------------------------------------- */

        public const string usp_ZLogLineEnt_Save = "usp_ZLogLineEnt_Save";
        public const string usp_ZLogLineEnt_Disp = "usp_ZLogLineEnt_Disp";



        public const string usp_LineEnt_LastChange_Save = "usp_LineEnt_LastChange_Save";
        public const string usp_LineEnt_LastChange_Disp = "usp_LineEnt_LastChange_Disp";


        public const string usp_AccCompanyMast_Manual_Add_Disp = "usp_AccCompanyMast_Manual_Add_Disp";

        public const string usp_AccCompanyMast_Manual_Add_Remaining_Disp = "usp_AccCompanyMast_Manual_Add_Remaining_Disp";
        public const string usp_AccCompanyDetail_Images_Single_First_Disp = "usp_AccCompanyDetail_Images_Single_First_Disp";

        public const string usp_AccCompanyDetail_Images_OrigImage_Disp = "usp_AccCompanyDetail_Images_OrigImage_Disp";
        public const string usp_AccCompanyDetail_Images_DeleteAll = "usp_AccCompanyDetail_Images_DeleteAll";
        public const string usp_AccCompanyDetail_Images_Disp = "usp_AccCompanyDetail_Images_Disp";
        public const string usp_AccCompanyDetail_Images_Save = "usp_AccCompanyDetail_Images_Save";
        public const string usp_AccCompanyDetail_Images_Desc1_Update = "usp_AccCompanyDetail_Images_Desc1_Update";
        public const string usp_CertiStructureL_Image_Save = "usp_CertiStructureL_Image_Save";


        public const string usp_AccBankDetail_Images_Save = "usp_AccBankDetail_Images_Save";
        public const string usp_AccBankDetail_Images_DeleteAll = "usp_AccBankDetail_Images_DeleteAll";
        public const string usp_AccBankDetail_Images_OrigImage_Disp = "usp_AccBankDetail_Images_OrigImage_Disp";
        public const string usp_AccBankDetail_Images_Desc1_Update = "usp_AccBankDetail_Images_Desc1_Update";
        public const string usp_AccBankDetail_Images_Disp = "usp_AccBankDetail_Images_Disp";
        public const string usp_AccBankDetail_Images_Single_First_Disp = "usp_AccBankDetail_Images_Single_First_Disp";
        public const string usp_AccBankMast_Manual_Add_Disp = "usp_AccBankMast_Manual_Add_Disp";
        public const string usp_AccBankMast_Manual_Add_Remaining_Disp = "usp_AccBankMast_Manual_Add_Remaining_Disp";

        public const string usp_AccCompanyMast_Order_Update = "usp_AccCompanyMast_Order_Update";
        public const string usp_AccBankMast_Save = "usp_AccBankMast_Save";


        public const string usp_SampleImages_Desc1_Update = "usp_SampleImages_Desc1_Update";
        public const string usp_SampleImages_Save = "usp_SampleImages_Save";
        public const string usp_SampleImages_OrigImage_Disp = "usp_SampleImages_OrigImage_Disp";
        public const string usp_SampleImages_Disp = "usp_SampleImages_Disp";

        public const string usp_SampleImages_DeleteAll = "usp_SampleImages_DeleteAll";
        public const string usp_SampleImages_OrigImage_Default_Disp = "usp_SampleImages_OrigImage_Default_Disp";
        public const string usp_SampleImages_Delete_Row_Images = "usp_SampleImages_Delete_Row_Images";

        public const string usp_Sample_All_Buffer_minus_Tran_Save = "usp_Sample_All_Buffer_minus_Tran_Save";


        public const string usp_SampleInRetH_Search = "usp_SampleInRetH_Search";
        public const string usp_NewId_SampleInRetH = "usp_NewId_SampleInRetH";
        public const string usp_SampleInRetH_RecNav = "usp_SampleInRetH_RecNav";
        public const string usp_SampleInRetL_Disp = "usp_SampleInRetL_Disp";
        public const string usp_SampleIn_Return_Disp = "usp_SampleIn_Return_Disp";
        public const string usp_SampleIn_Return_Delete = "usp_SampleIn_Return_Delete";
        public const string usp_SampleInRetL_Save = "usp_SampleInRetL_Save";
        public const string usp_SampleInRetH_Save = "usp_SampleInRetH_Save";


        public const string usp_SampleOutRetL_Save = "usp_SampleOutRetL_Save";
        public const string usp_SampleOutRetL_Disp = "usp_SampleOutRetL_Disp";
        public const string usp_SampleOut_Return_Delete = "usp_SampleOut_Return_Delete";
        public const string usp_SampleOut_Return_Disp = "usp_SampleOut_Return_Disp";
        public const string usp_SampleOutRetH_RecNav = "usp_SampleOutRetH_RecNav";
        public const string usp_NewId_SampleOutRetH = "usp_NewId_SampleOutRetH";
        public const string usp_SampleOutRetH_Search = "usp_SampleOutRetH_Search";
        public const string usp_SampleOutRetH_Save = "usp_SampleOutRetH_Save";
        public const string usp_SampleOutL_Save = "usp_SampleOutL_Save";
        public const string usp_SampleOut_Delete = "usp_SampleOut_Delete";
        public const string usp_SampleOut_SamID_Det = "usp_SampleOut_SamID_Det";
        public const string usp_SampleOut_Disp = "usp_SampleOut_Disp";
        public const string usp_SampleOutH_RecNav = "usp_SampleOutH_RecNav";
        public const string usp_NewId_SampleOutH = "usp_NewId_SampleOutH";
        public const string usp_SampleOutH_Search = "usp_SampleOutH_Search";
        public const string usp_SampleOutL_Disp = "usp_SampleOutL_Disp";
        public const string usp_SampleOutH_Save = "usp_SampleOutH_Save";
        public const string usp_SampleOut_MainQuan_Pend_Fill = "usp_SampleOut_MainQuan_Pend_Fill";

        public const string usp_PerPermiGroupUser_Disp = "usp_PerPermiGroupUser_Disp";
        public const string usp_PerPermiGroupUser_Save = "usp_PerPermiGroupUser_Save";
        public const string usp_PerPermiGroupUser_Delete = "usp_PerPermiGroupUser_Delete";
        public const string usp_Check_PermiGroupMast_For_Delete = "usp_Check_PermiGroupMast_For_Delete";

        public const string usp_PermiGroupMast_Dynamic_Add = "usp_PermiGroupMast_Dynamic_Add";
        public const string usp_Check_CatMast_For_Delete = "usp_Check_CatMast_For_Delete";
        public const string usp_CatMast_Disp = "usp_CatMast_Disp";
        public const string usp_UtilCheckUserWiseFormPer_Indi_Group = "usp_UtilCheckUserWiseFormPer_Indi_Group";
        public const string usp_UtilFrm_PerMastUGUG = "usp_UtilFrm_PerMastUGUG";
        public const string usp_Fill_User_And_Group = "usp_Fill_User_And_Group";
        public const string usp_Fill_User_GroupWise = "usp_Fill_User_GroupWise";
        public const string usp_LanguageMast_Disp = "usp_LanguageMast_Disp";

        public const string usp_Utility_PerMastUG_Delete = "usp_Utility_PerMastUG_Delete";

        public const string usp_Utility_PerMastUGUG_Save = "usp_Utility_PerMastUGUG_Save";
        public const string usp_PermIndiTran_Disp = "usp_PermIndiTran_Disp";
        public const string usp_PermUserToUoG_Disp = "usp_PermUserToUoG_Disp";

        public const string usp_PermUserToUserTranPer_Disp = "usp_PermUserToUserTranPer_Disp";

        public const string usp_FrmMast_Disp = "usp_FrmMast_Disp";
        public const string usp_PermIndiTran_Save = "usp_PermIndiTran_Save";
        public const string usp_PermUserToUoG_Save = "usp_PermUserToUoG_Save";
        public const string usp_PermUserToUserTranPer_Save = "usp_PermUserToUserTranPer_Save";
        public const string usp_LangMast_Save = "usp_LangMast_Save";

        public const string usp_AccCompanyDetail_Single_Delete = "usp_AccCompanyDetail_Single_Delete";

        public const string usp_AccBankDetail_Single_Delete = "usp_AccBankDetail_Single_Delete";
        public const string usp_AccCompUIDMast_Fill = "usp_AccCompUIDMast_Fill";
        public const string usp_CustInq_First_Step_Disp = "usp_CustInq_First_Step_Disp";

        public const string usp_ProductTypeMast_Save = "usp_ProductTypeMast_Save";
        public const string usp_LangMast_Delete = "usp_LangMast_Delete";


        public const string usp_CertiStandMast_Save = "usp_CertiStandMast_Save";
        public const string usp_CertiStandMast_Disp = "usp_CertiStandMast_Disp";

        public const string usp_AccParGroupMast_Save = "usp_AccParGroupMast_Save";
        public const string usp_AccParGroupMast_Disp = "usp_AccParGroupMast_Disp";
        public const string usp_ParMast_StartPoint_Disp = "usp_ParMast_StartPoint_Disp";


        public const string usp_CertiTypeMast_Save = "usp_CertiTypeMast_Save";
        public const string usp_CertiTypeMast_Disp = "usp_CertiTypeMast_Disp";
        public const string usp_CertiTypeMast_Combo_Fill = "usp_CertiTypeMast_Combo_Fill";


        public const string usp_AccCompanyMast_Save = "usp_AccCompanyMast_Save";
        public const string usp_AccCompanyMast_Disp = "usp_AccCompanyMast_Disp";

        public const string usp_AccBankMast_Order_Update = "usp_AccBankMast_Order_Update";


        public const string usp_FollowUpMast_Save = "usp_FollowUpMast_Save";
        public const string usp_FollowUpMast_Disp = "usp_FollowUpMast_Disp";
        public const string usp_FollowUpMast_Order_Update = "usp_FollowUpMast_Order_Update";


        public const string usp_Buffer_NotesMast_Detail_LTZ = "usp_Buffer_NotesMast_Detail_LTZ";
        public const string usp_NotesMast_Detail_Unsaved_Buffer_Delete = "usp_NotesMast_Detail_Unsaved_Buffer_Delete";
        public const string usp_NotesMast_Order_Update = "usp_NotesMast_Order_Update";
        public const string usp_NotesMast_Disp = "usp_NotesMast_Disp";
        public const string usp_NotesMast_Save = "usp_NotesMast_Save";


        public const string usp_Check_NotesTitleMast_For_Delete = "usp_Check_NotesTitleMast_For_Delete";
        public const string usp_NotesTitleMast_Buffer_Save = "usp_NotesTitleMast_Buffer_Save";
        public const string usp_NotesTitleMast_Disp = "usp_NotesTitleMast_Disp";
        public const string usp_NotesTitleMast_Save = "usp_NotesTitleMast_Save";

        public const string usp_Check_NotesRemarkMast_For_Delete = "usp_Check_NotesRemarkMast_For_Delete";
        public const string usp_NotesRemarkMast_Buffer_Save = "usp_NotesRemarkMast_Buffer_Save";
        public const string usp_NotesRemarkMast_Disp = "usp_NotesRemarkMast_Disp";
        public const string usp_NotesRemarkMast_Save = "usp_NotesRemarkMast_Save";
        public const string usp_NotesMast_Detail_Order_Update = "usp_NotesMast_Detail_Order_Update";


        public const string usp_CertiStructureL_ProductType_Buffer_Delete = "usp_CertiStructureL_ProductType_Buffer_Delete";
        public const string usp_CertiStructureL_ProductType_Delete = "usp_CertiStructureL_ProductType_Delete";
        public const string usp_CertiStructureL_ProductType_Save = "usp_CertiStructureL_ProductType_Save";
        public const string usp_CertiStructureL_ProductType_Disp = "usp_CertiStructureL_ProductType_Disp";

        public const string usp_UserWiseColWidth_Disp = "usp_UserWiseColWidth_Disp";


        public const string usp_TypeOfPayment_Disp = "usp_TypeOfPayment_Disp";
        public const string usp_TypeOfPayment_All_Lang_Disp = "usp_TypeOfPayment_All_Lang_Disp";
        public const string usp_TypeOfPayment_Save = "usp_TypeOfPayment_Save";


        public const string usp_PerAcc_NewId = "usp_PerAcc_NewId";
        public const string usp_SaveAll_PerContUser = "usp_SaveAll_PerContUser";
        public const string usp_Save_PerContUser = "usp_Save_PerContUser";
        public const string usp_Fill_PerContUser = "usp_Fill_PerContUser";

        public const string usp_QuoteNumTemplate_Gen = "usp_QuoteNumTemplate_Gen";
        public const string usp_QuoteNumTemplate_YMD_Combo_Disp = "usp_QuoteNumTemplate_YMD_Combo_Disp";
        public const string usp_QuoteNumTemplate_Save = "usp_QuoteNumTemplate_Save";

        public const string usp_TrnMastDblSave = "usp_TrnMastDblSave";
        public const string usp_TrnMastDblRecNav = "usp_TrnMastDblRecNav";
        public const string usp_TrnMast_Remark_Fill = "usp_TrnMast_Remark_Fill";
        public const string usp_TrnMast_ImportNo_Disp = "usp_TrnMast_ImportNo_Disp";
        public const string usp_TrnMast_ImportNo_Del = "usp_TrnMast_ImportNo_Del";
        public const string usp_PayRecSearch = "usp_PayRecSearch";
        public const string usp_PayRecDisp = "usp_PayRecDisp";
        public const string usp_PayRecDet_Combo_or_Single = "usp_PayRecDet_Combo_or_Single";
        public const string usp_PayRecDbl_All_Loop_Delete = "usp_PayRecDbl_All_Loop_Delete";
        public const string usp_NewIdTrnMast = "usp_NewIdTrnMast";
        public const string usp_get_TrnMast_Max_ImportNo = "usp_get_TrnMast_Max_ImportNo";
        public const string usp_PayRecDblDel = "usp_PayRecDblDel";
        public const string usp_PayRec_Import_Excel_DTP_check = "usp_PayRec_Import_Excel_DTP_check";

        public const string usp_ContraEntDblRecNav = "usp_ContraEntDblRecNav";
        public const string usp_ContraEntDblSearch = "usp_ContraEntDblSearch";
        public const string usp_ContraEntDblDisp = "usp_ContraEntDblDisp";
        public const string usp_ContraEntDblDel = "usp_ContraEntDblDel";
        public const string usp_ContraEntDblSave = "usp_ContraEntDblSave";

        public const string usp_CustInqL_QuotationNumber_Fill = "usp_CustInqL_QuotationNumber_Fill";
        public const string usp_EngineerL_Disp = "usp_EngineerL_Disp";

        public const string usp_SampleProcessing_L_Disp = "usp_SampleProcessing_L_Disp";

        public const string usp_LangMast_User_Entry_Disp = "usp_LangMast_User_Entry_Disp";

        public const string usp_SPRS_All_Master_Disp = "usp_SPRS_All_Master_Disp";

        public const string usp_CustInqH_ProjectNumber_Fill = "usp_CustInqH_ProjectNumber_Fill";
        public const string usp_CustInqL_QuotationNumber_ProjectNumber_Wise_Fill = "usp_CustInqL_QuotationNumber_ProjectNumber_Wise_Fill";

        public const string usp_CompanyCodes_With_year_Disp = "usp_CompanyCodes_With_year_Disp";

        public const string usp_Disp_MaxAcYear_as_CurrAccYear = "usp_Disp_MaxAcYear_as_CurrAccYear";

        public const string RP_PettyCash = "RP_PettyCash";

        public const string usp_FollowUpMast_Third_Part_Detail_Save_DESK = "usp_FollowUpMast_Third_Part_Detail_Save_DESK";
        public const string usp_FollowUpMast_Second_Part_Detail_Save_DESK = "usp_FollowUpMast_Second_Part_Detail_Save_DESK";


        public const string usp_FollowUp_Third_Part_L_Save_DESK = "usp_FollowUp_Third_Part_L_Save_DESK";
        public const string usp_FollowUp_Third_Part_H_Save_DESK = "usp_FollowUp_Third_Part_H_Save_DESK";
        public const string usp_FollowUp_Second_Part_L_Save_DESK = "usp_FollowUp_Second_Part_L_Save_DESK";
        public const string usp_FollowUp_Second_Part_H_Save_DESK = "usp_FollowUp_Second_Part_H_Save_DESK";


        public const string usp_FollowUp_Third_Part_H_Disp = "usp_FollowUp_Third_Part_H_Disp";
        public const string usp_FollowUp_Second_Part_H_Disp = "usp_FollowUp_Second_Part_H_Disp";

        public const string usp_QuotationPrint_FollowUp_Third_Part_LDisp = "usp_QuotationPrint_FollowUp_Third_Part_LDisp";
        public const string usp_QuotationPrint_FollowUp_Second_Part_LDisp = "usp_QuotationPrint_FollowUp_Second_Part_LDisp";

        public const string usp_ChopImage_disp = "usp_ChopImage_disp";

        public const string usp_RowWiseImages_RowWise_Thumb_Disp = "usp_RowWiseImages_RowWise_Thumb_Disp";
        public const string usp_RowWiseImages_UnSaved_Navigate_Image_Buffer_Clear = "usp_RowWiseImages_UnSaved_Navigate_Image_Buffer_Clear";
        public const string usp_RowWiseImages_Generate_Buffer_TranNo = "usp_RowWiseImages_Generate_Buffer_TranNo";
        public const string usp_RowWiseImages_Save = "usp_RowWiseImages_Save";
        public const string usp_RowWiseImages_Desc1_Update = "usp_RowWiseImages_Desc1_Update";
        public const string usp_RowWiseImages_Delete = "usp_RowWiseImages_Delete";
        public const string usp_RowWiseImages_Disp = "usp_RowWiseImages_Disp";

    }
}