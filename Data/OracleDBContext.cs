using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using ProWeb2MVP.Shared.Models;
using Oracle.ManagedDataAccess.Client;
using System.Data.Common;
using DocumentFormat.OpenXml.Wordprocessing;
using ProWeb2MVP.Models;

namespace ProWeb2MVP.Data.DataAccess
{
    public class OracleDBContext : IdentityDbContext
    {
        public string ConnectionString { get; set; }

        public OracleDBContext(string connectionString)
        {
            ConnectionString = connectionString;
        }

        private OracleConnection GetConnection()
        {
            return new OracleConnection(ConnectionString);
        }

        public async Task<DataTable> GetAllAsyncVP()
        {
            using (OracleConnection conn = GetConnection())
            {
                //command.CommandText = "sp_AverageTemperaturesReport";
                //command.CommandType = CommandType.StoredProcedure;

                conn.Open();
                var commandText = @"SELECT * FROM TB_VPM_PO_ITEM_VP";
                OracleCommand cmd = new OracleCommand(commandText, conn);

                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    var table = new DataTable();
                    table.Load(reader);

                    return table;
                }

            }
        }


        public async Task<DataTable> GetAsyncVPList(POMainEntity entity)
        {
            using (OracleConnection conn = GetConnection())
            {   
                DataSet ds = new DataSet();

                conn.Open();

                OracleCommand cmd = conn.CreateCommand();

                cmd.CommandText = "VPMPO_PKG.Select_VPIndexList";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("P_PJT_ID", OracleDbType.Varchar2, entity.P_PJT_ID, ParameterDirection.Input);
                cmd.Parameters.Add("P_DISC_ID", OracleDbType.Varchar2, entity.P_DISC_ID, ParameterDirection.Input);
                cmd.Parameters.Add("P_PO_NO", OracleDbType.Varchar2, entity.P_PO_NO, ParameterDirection.Input);
                cmd.Parameters.Add("P_PO_DESC", OracleDbType.Varchar2, entity.P_PO_DESC, ParameterDirection.Input);
                cmd.Parameters.Add("P_COMP_NO", OracleDbType.Varchar2, entity.P_COMP_NO, ParameterDirection.Input);
                cmd.Parameters.Add("P_ITEM_NO", OracleDbType.Varchar2, entity.P_ITEM_NO, ParameterDirection.Input);
                cmd.Parameters.Add("P_ITEM_DESC", OracleDbType.Varchar2, entity.P_ITEM_DESC, ParameterDirection.Input);
                cmd.Parameters.Add("P_VP_NO", OracleDbType.Varchar2, entity.P_VP_NO, ParameterDirection.Input);
                cmd.Parameters.Add("P_VP_DESC", OracleDbType.Varchar2, entity.P_VP_DESC, ParameterDirection.Input);
                cmd.Parameters.Add("P_TR_NO", OracleDbType.Varchar2, entity.P_TR_NO, ParameterDirection.Input);// tr 조건 추가 2018-12-26
                cmd.Parameters.Add("P_CHECK_SQD", OracleDbType.Varchar2, entity.P_CHECK_SQD, ParameterDirection.Input);// CHECK_SQD 조건 추가 2019-01-11
                cmd.Parameters.Add("P_NEW_VER_YN", OracleDbType.Varchar2, entity.P_NEW_VER_YN, ParameterDirection.Input);
                cmd.Parameters.Add("P_LIKE_SEARCH_YN", OracleDbType.Varchar2, entity.P_LIKE_SEARCH_YN, ParameterDirection.Input);
                cmd.Parameters.Add("P_SORT_COL", OracleDbType.Varchar2, entity.P_SORT_COL, ParameterDirection.Input);
                cmd.Parameters.Add("P_SORT_DIRECTION", OracleDbType.Varchar2, entity.P_SORT_DIRECTION, ParameterDirection.Input);
                cmd.Parameters.Add("P_START_IDX", OracleDbType.Decimal, Convert.ToDecimal(entity.P_START_IDX), ParameterDirection.Input);
                cmd.Parameters.Add("P_PAGE_SIZE", OracleDbType.Decimal, Convert.ToDecimal(entity.P_PAGE_SIZE), ParameterDirection.Input);

                cmd.Parameters.Add("P_CURSOR", OracleDbType.RefCursor, ParameterDirection.Output);

                //var adapter = new DbDataAdapter(cmd);

                //adapter.Fill(ds);
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    var table = new DataTable();
                    table.Load(reader);

                    return table;
                }
            }

        }
    }
}