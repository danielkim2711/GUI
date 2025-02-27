﻿
namespace Kaioordinate
{
    partial class DataModule
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataModule));
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.ctnKai = new System.Data.OleDb.OleDbConnection();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.daEvent = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand2 = new System.Data.OleDb.OleDbCommand();
            this.daEventRegister = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand3 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand3 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand3 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand3 = new System.Data.OleDb.OleDbCommand();
            this.daKai = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand4 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand4 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand4 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand4 = new System.Data.OleDb.OleDbCommand();
            this.daLocation = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand5 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand5 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand5 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand5 = new System.Data.OleDb.OleDbCommand();
            this.daWhanau = new System.Data.OleDb.OleDbDataAdapter();
            this.dsKaiOordinate = new Kaioordinate.dsKaiOordinate();
            ((System.ComponentModel.ISupportInitialize)(this.dsKaiOordinate)).BeginInit();
            this.SuspendLayout();
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = "SELECT        EventID, EventName, LocationID, EventDate\r\nFROM            EVENT\r\nO" +
    "RDER BY EventID";
            this.oleDbSelectCommand1.Connection = this.ctnKai;
            // 
            // ctnKai
            // 
            this.ctnKai.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Temp\\kai-oordinate.mdb";
            this.ctnKai.InfoMessage += new System.Data.OleDb.OleDbInfoMessageEventHandler(this.daEvent_InfoMessage);
            // 
            // oleDbInsertCommand1
            // 
            this.oleDbInsertCommand1.CommandText = "INSERT INTO `EVENT` (`EventName`, `LocationID`, `EventDate`) VALUES (?, ?, ?)";
            this.oleDbInsertCommand1.Connection = this.ctnKai;
            this.oleDbInsertCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("EventName", System.Data.OleDb.OleDbType.VarWChar, 0, "EventName"),
            new System.Data.OleDb.OleDbParameter("LocationID", System.Data.OleDb.OleDbType.Integer, 0, "LocationID"),
            new System.Data.OleDb.OleDbParameter("EventDate", System.Data.OleDb.OleDbType.Date, 0, "EventDate")});
            // 
            // oleDbUpdateCommand1
            // 
            this.oleDbUpdateCommand1.CommandText = resources.GetString("oleDbUpdateCommand1.CommandText");
            this.oleDbUpdateCommand1.Connection = this.ctnKai;
            this.oleDbUpdateCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("EventName", System.Data.OleDb.OleDbType.VarWChar, 0, "EventName"),
            new System.Data.OleDb.OleDbParameter("LocationID", System.Data.OleDb.OleDbType.Integer, 0, "LocationID"),
            new System.Data.OleDb.OleDbParameter("EventDate", System.Data.OleDb.OleDbType.Date, 0, "EventDate"),
            new System.Data.OleDb.OleDbParameter("Original_EventID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EventID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_EventName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EventName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_EventName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EventName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_LocationID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LocationID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_LocationID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LocationID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_EventDate", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EventDate", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_EventDate", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EventDate", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand1
            // 
            this.oleDbDeleteCommand1.CommandText = resources.GetString("oleDbDeleteCommand1.CommandText");
            this.oleDbDeleteCommand1.Connection = this.ctnKai;
            this.oleDbDeleteCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_EventID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EventID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_EventName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EventName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_EventName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EventName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_LocationID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LocationID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_LocationID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LocationID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_EventDate", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EventDate", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_EventDate", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EventDate", System.Data.DataRowVersion.Original, null)});
            // 
            // daEvent
            // 
            this.daEvent.DeleteCommand = this.oleDbDeleteCommand1;
            this.daEvent.InsertCommand = this.oleDbInsertCommand1;
            this.daEvent.SelectCommand = this.oleDbSelectCommand1;
            this.daEvent.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "EVENT", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("EventID", "EventID"),
                        new System.Data.Common.DataColumnMapping("EventName", "EventName"),
                        new System.Data.Common.DataColumnMapping("LocationID", "LocationID"),
                        new System.Data.Common.DataColumnMapping("EventDate", "EventDate")})});
            this.daEvent.UpdateCommand = this.oleDbUpdateCommand1;
            this.daEvent.RowUpdated += new System.Data.OleDb.OleDbRowUpdatedEventHandler(this.daEvent_RowUpdated);
            // 
            // oleDbSelectCommand2
            // 
            this.oleDbSelectCommand2.CommandText = "SELECT        RegistrationID, WhanauID, EventID, KaiPreparation\r\nFROM            " +
    "EVENTREGISTER\r\nORDER BY EventID, RegistrationID";
            this.oleDbSelectCommand2.Connection = this.ctnKai;
            // 
            // oleDbInsertCommand2
            // 
            this.oleDbInsertCommand2.CommandText = "INSERT INTO `EVENTREGISTER` (`WhanauID`, `EventID`, `KaiPreparation`) VALUES (?, " +
    "?, ?)";
            this.oleDbInsertCommand2.Connection = this.ctnKai;
            this.oleDbInsertCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("WhanauID", System.Data.OleDb.OleDbType.Integer, 0, "WhanauID"),
            new System.Data.OleDb.OleDbParameter("EventID", System.Data.OleDb.OleDbType.Integer, 0, "EventID"),
            new System.Data.OleDb.OleDbParameter("KaiPreparation", System.Data.OleDb.OleDbType.Boolean, 0, "KaiPreparation")});
            // 
            // oleDbUpdateCommand2
            // 
            this.oleDbUpdateCommand2.CommandText = resources.GetString("oleDbUpdateCommand2.CommandText");
            this.oleDbUpdateCommand2.Connection = this.ctnKai;
            this.oleDbUpdateCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("WhanauID", System.Data.OleDb.OleDbType.Integer, 0, "WhanauID"),
            new System.Data.OleDb.OleDbParameter("EventID", System.Data.OleDb.OleDbType.Integer, 0, "EventID"),
            new System.Data.OleDb.OleDbParameter("KaiPreparation", System.Data.OleDb.OleDbType.Boolean, 0, "KaiPreparation"),
            new System.Data.OleDb.OleDbParameter("Original_RegistrationID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RegistrationID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_WhanauID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "WhanauID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_WhanauID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "WhanauID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_EventID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EventID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_EventID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EventID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_KaiPreparation", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "KaiPreparation", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_KaiPreparation", System.Data.OleDb.OleDbType.Boolean, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "KaiPreparation", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand2
            // 
            this.oleDbDeleteCommand2.CommandText = resources.GetString("oleDbDeleteCommand2.CommandText");
            this.oleDbDeleteCommand2.Connection = this.ctnKai;
            this.oleDbDeleteCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_RegistrationID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RegistrationID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_WhanauID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "WhanauID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_WhanauID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "WhanauID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_EventID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EventID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_EventID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EventID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_KaiPreparation", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "KaiPreparation", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_KaiPreparation", System.Data.OleDb.OleDbType.Boolean, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "KaiPreparation", System.Data.DataRowVersion.Original, null)});
            // 
            // daEventRegister
            // 
            this.daEventRegister.DeleteCommand = this.oleDbDeleteCommand2;
            this.daEventRegister.InsertCommand = this.oleDbInsertCommand2;
            this.daEventRegister.SelectCommand = this.oleDbSelectCommand2;
            this.daEventRegister.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "EVENTREGISTER", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("RegistrationID", "RegistrationID"),
                        new System.Data.Common.DataColumnMapping("WhanauID", "WhanauID"),
                        new System.Data.Common.DataColumnMapping("EventID", "EventID"),
                        new System.Data.Common.DataColumnMapping("KaiPreparation", "KaiPreparation")})});
            this.daEventRegister.UpdateCommand = this.oleDbUpdateCommand2;
            this.daEventRegister.RowUpdated += new System.Data.OleDb.OleDbRowUpdatedEventHandler(this.daEventRegister_RowUpdated);
            // 
            // oleDbSelectCommand3
            // 
            this.oleDbSelectCommand3.CommandText = "SELECT        KaiID, EventID, KaiName, PreparationRequired, PreparationMinutes, S" +
    "erveQuantity\r\nFROM            KAI\r\nORDER BY KaiID";
            this.oleDbSelectCommand3.Connection = this.ctnKai;
            // 
            // oleDbInsertCommand3
            // 
            this.oleDbInsertCommand3.CommandText = "INSERT INTO `KAI` (`EventID`, `KaiName`, `PreparationRequired`, `PreparationMinut" +
    "es`, `ServeQuantity`) VALUES (?, ?, ?, ?, ?)";
            this.oleDbInsertCommand3.Connection = this.ctnKai;
            this.oleDbInsertCommand3.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("EventID", System.Data.OleDb.OleDbType.Integer, 0, "EventID"),
            new System.Data.OleDb.OleDbParameter("KaiName", System.Data.OleDb.OleDbType.VarWChar, 0, "KaiName"),
            new System.Data.OleDb.OleDbParameter("PreparationRequired", System.Data.OleDb.OleDbType.Boolean, 0, "PreparationRequired"),
            new System.Data.OleDb.OleDbParameter("PreparationMinutes", System.Data.OleDb.OleDbType.Integer, 0, "PreparationMinutes"),
            new System.Data.OleDb.OleDbParameter("ServeQuantity", System.Data.OleDb.OleDbType.Integer, 0, "ServeQuantity")});
            // 
            // oleDbUpdateCommand3
            // 
            this.oleDbUpdateCommand3.CommandText = resources.GetString("oleDbUpdateCommand3.CommandText");
            this.oleDbUpdateCommand3.Connection = this.ctnKai;
            this.oleDbUpdateCommand3.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("EventID", System.Data.OleDb.OleDbType.Integer, 0, "EventID"),
            new System.Data.OleDb.OleDbParameter("KaiName", System.Data.OleDb.OleDbType.VarWChar, 0, "KaiName"),
            new System.Data.OleDb.OleDbParameter("PreparationRequired", System.Data.OleDb.OleDbType.Boolean, 0, "PreparationRequired"),
            new System.Data.OleDb.OleDbParameter("PreparationMinutes", System.Data.OleDb.OleDbType.Integer, 0, "PreparationMinutes"),
            new System.Data.OleDb.OleDbParameter("ServeQuantity", System.Data.OleDb.OleDbType.Integer, 0, "ServeQuantity"),
            new System.Data.OleDb.OleDbParameter("Original_KaiID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "KaiID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_EventID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EventID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_EventID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EventID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_KaiName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "KaiName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_KaiName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "KaiName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_PreparationRequired", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PreparationRequired", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_PreparationRequired", System.Data.OleDb.OleDbType.Boolean, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PreparationRequired", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_PreparationMinutes", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PreparationMinutes", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_PreparationMinutes", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PreparationMinutes", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_ServeQuantity", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ServeQuantity", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_ServeQuantity", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ServeQuantity", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand3
            // 
            this.oleDbDeleteCommand3.CommandText = resources.GetString("oleDbDeleteCommand3.CommandText");
            this.oleDbDeleteCommand3.Connection = this.ctnKai;
            this.oleDbDeleteCommand3.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_KaiID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "KaiID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_EventID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EventID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_EventID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EventID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_KaiName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "KaiName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_KaiName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "KaiName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_PreparationRequired", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PreparationRequired", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_PreparationRequired", System.Data.OleDb.OleDbType.Boolean, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PreparationRequired", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_PreparationMinutes", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PreparationMinutes", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_PreparationMinutes", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PreparationMinutes", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_ServeQuantity", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ServeQuantity", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_ServeQuantity", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ServeQuantity", System.Data.DataRowVersion.Original, null)});
            // 
            // daKai
            // 
            this.daKai.DeleteCommand = this.oleDbDeleteCommand3;
            this.daKai.InsertCommand = this.oleDbInsertCommand3;
            this.daKai.SelectCommand = this.oleDbSelectCommand3;
            this.daKai.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "KAI", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("KaiID", "KaiID"),
                        new System.Data.Common.DataColumnMapping("EventID", "EventID"),
                        new System.Data.Common.DataColumnMapping("KaiName", "KaiName"),
                        new System.Data.Common.DataColumnMapping("PreparationRequired", "PreparationRequired"),
                        new System.Data.Common.DataColumnMapping("PreparationMinutes", "PreparationMinutes"),
                        new System.Data.Common.DataColumnMapping("ServeQuantity", "ServeQuantity")})});
            this.daKai.UpdateCommand = this.oleDbUpdateCommand3;
            this.daKai.RowUpdated += new System.Data.OleDb.OleDbRowUpdatedEventHandler(this.daKai_RowUpdated);
            // 
            // oleDbSelectCommand4
            // 
            this.oleDbSelectCommand4.CommandText = "SELECT        LocationID, LocationName, Address\r\nFROM            LOCATION\r\nORDER " +
    "BY LocationID";
            this.oleDbSelectCommand4.Connection = this.ctnKai;
            // 
            // oleDbInsertCommand4
            // 
            this.oleDbInsertCommand4.CommandText = "INSERT INTO `LOCATION` (`LocationName`, `Address`) VALUES (?, ?)";
            this.oleDbInsertCommand4.Connection = this.ctnKai;
            this.oleDbInsertCommand4.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("LocationName", System.Data.OleDb.OleDbType.VarWChar, 0, "LocationName"),
            new System.Data.OleDb.OleDbParameter("Address", System.Data.OleDb.OleDbType.VarWChar, 0, "Address")});
            // 
            // oleDbUpdateCommand4
            // 
            this.oleDbUpdateCommand4.CommandText = resources.GetString("oleDbUpdateCommand4.CommandText");
            this.oleDbUpdateCommand4.Connection = this.ctnKai;
            this.oleDbUpdateCommand4.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("LocationName", System.Data.OleDb.OleDbType.VarWChar, 0, "LocationName"),
            new System.Data.OleDb.OleDbParameter("Address", System.Data.OleDb.OleDbType.VarWChar, 0, "Address"),
            new System.Data.OleDb.OleDbParameter("Original_LocationID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LocationID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_LocationName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LocationName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_LocationName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LocationName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Address", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Address", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Address", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Address", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand4
            // 
            this.oleDbDeleteCommand4.CommandText = "DELETE FROM `LOCATION` WHERE ((`LocationID` = ?) AND ((? = 1 AND `LocationName` I" +
    "S NULL) OR (`LocationName` = ?)) AND ((? = 1 AND `Address` IS NULL) OR (`Address" +
    "` = ?)))";
            this.oleDbDeleteCommand4.Connection = this.ctnKai;
            this.oleDbDeleteCommand4.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_LocationID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LocationID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_LocationName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LocationName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_LocationName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LocationName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Address", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Address", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Address", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Address", System.Data.DataRowVersion.Original, null)});
            // 
            // daLocation
            // 
            this.daLocation.DeleteCommand = this.oleDbDeleteCommand4;
            this.daLocation.InsertCommand = this.oleDbInsertCommand4;
            this.daLocation.SelectCommand = this.oleDbSelectCommand4;
            this.daLocation.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "LOCATION", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("LocationID", "LocationID"),
                        new System.Data.Common.DataColumnMapping("LocationName", "LocationName"),
                        new System.Data.Common.DataColumnMapping("Address", "Address")})});
            this.daLocation.UpdateCommand = this.oleDbUpdateCommand4;
            this.daLocation.RowUpdated += new System.Data.OleDb.OleDbRowUpdatedEventHandler(this.daLocation_RowUpdated);
            // 
            // oleDbSelectCommand5
            // 
            this.oleDbSelectCommand5.CommandText = "SELECT        WhanauID, FirstName, LastName, Email, Phone, Address\r\nFROM         " +
    "   WHANAU\r\nORDER BY WhanauID";
            this.oleDbSelectCommand5.Connection = this.ctnKai;
            // 
            // oleDbInsertCommand5
            // 
            this.oleDbInsertCommand5.CommandText = "INSERT INTO `WHANAU` (`FirstName`, `LastName`, `Email`, `Phone`, `Address`) VALUE" +
    "S (?, ?, ?, ?, ?)";
            this.oleDbInsertCommand5.Connection = this.ctnKai;
            this.oleDbInsertCommand5.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 0, "FirstName"),
            new System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.VarWChar, 0, "LastName"),
            new System.Data.OleDb.OleDbParameter("Email", System.Data.OleDb.OleDbType.VarWChar, 0, "Email"),
            new System.Data.OleDb.OleDbParameter("Phone", System.Data.OleDb.OleDbType.VarWChar, 0, "Phone"),
            new System.Data.OleDb.OleDbParameter("Address", System.Data.OleDb.OleDbType.VarWChar, 0, "Address")});
            // 
            // oleDbUpdateCommand5
            // 
            this.oleDbUpdateCommand5.CommandText = resources.GetString("oleDbUpdateCommand5.CommandText");
            this.oleDbUpdateCommand5.Connection = this.ctnKai;
            this.oleDbUpdateCommand5.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 0, "FirstName"),
            new System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.VarWChar, 0, "LastName"),
            new System.Data.OleDb.OleDbParameter("Email", System.Data.OleDb.OleDbType.VarWChar, 0, "Email"),
            new System.Data.OleDb.OleDbParameter("Phone", System.Data.OleDb.OleDbType.VarWChar, 0, "Phone"),
            new System.Data.OleDb.OleDbParameter("Address", System.Data.OleDb.OleDbType.VarWChar, 0, "Address"),
            new System.Data.OleDb.OleDbParameter("Original_WhanauID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "WhanauID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_FirstName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "FirstName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_FirstName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FirstName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_LastName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LastName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_LastName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LastName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Email", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Email", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Email", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Email", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Phone", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Phone", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Phone", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Phone", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Address", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Address", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Address", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Address", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand5
            // 
            this.oleDbDeleteCommand5.CommandText = resources.GetString("oleDbDeleteCommand5.CommandText");
            this.oleDbDeleteCommand5.Connection = this.ctnKai;
            this.oleDbDeleteCommand5.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_WhanauID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "WhanauID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_FirstName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "FirstName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_FirstName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FirstName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_LastName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LastName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_LastName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LastName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Email", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Email", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Email", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Email", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Phone", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Phone", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Phone", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Phone", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Address", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Address", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Address", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Address", System.Data.DataRowVersion.Original, null)});
            // 
            // daWhanau
            // 
            this.daWhanau.DeleteCommand = this.oleDbDeleteCommand5;
            this.daWhanau.InsertCommand = this.oleDbInsertCommand5;
            this.daWhanau.SelectCommand = this.oleDbSelectCommand5;
            this.daWhanau.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "WHANAU", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("WhanauID", "WhanauID"),
                        new System.Data.Common.DataColumnMapping("FirstName", "FirstName"),
                        new System.Data.Common.DataColumnMapping("LastName", "LastName"),
                        new System.Data.Common.DataColumnMapping("Email", "Email"),
                        new System.Data.Common.DataColumnMapping("Phone", "Phone"),
                        new System.Data.Common.DataColumnMapping("Address", "Address")})});
            this.daWhanau.UpdateCommand = this.oleDbUpdateCommand5;
            this.daWhanau.RowUpdated += new System.Data.OleDb.OleDbRowUpdatedEventHandler(this.daWhanau_RowUpdated);
            // 
            // dsKaiOordinate
            // 
            this.dsKaiOordinate.DataSetName = "dsKaiOordinate";
            this.dsKaiOordinate.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "DataModule";
            this.Text = "DataModule";
            ((System.ComponentModel.ISupportInitialize)(this.dsKaiOordinate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        private System.Data.OleDb.OleDbConnection ctnKai;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
        private System.Data.OleDb.OleDbDataAdapter daEvent;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand2;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand2;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand2;
        private System.Data.OleDb.OleDbDataAdapter daEventRegister;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand3;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand3;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand3;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand3;
        private System.Data.OleDb.OleDbDataAdapter daKai;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand4;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand4;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand4;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand4;
        private System.Data.OleDb.OleDbDataAdapter daLocation;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand5;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand5;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand5;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand5;
        private System.Data.OleDb.OleDbDataAdapter daWhanau;
        public dsKaiOordinate dsKaiOordinate;
    }
}