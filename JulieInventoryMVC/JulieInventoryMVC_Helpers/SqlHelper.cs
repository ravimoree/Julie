using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace JulieInventoryMVC_Helpers
{
    public static class SqlHelper
    {
        public static String ConnectionString()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
        }

        public static T GetRecord<T>(string spName, List<ParameterInfo> parameters)
        {
            T objRecord = default(T);
            using (SqlConnection objConnection = new SqlConnection(ConnectionString()))
            {
                objConnection.Open();
                DynamicParameters p = new DynamicParameters();
                foreach (var param in parameters)
                {
                    p.Add("@" + param.ParameterName, param.ParameterValue);
                }

                objRecord = SqlMapper.Query<T>(objConnection, spName, p, commandType: CommandType.StoredProcedure).FirstOrDefault();
                objConnection.Close();
            }
            return objRecord;
        }
        public static List<T> GetRecordList<T>(string spName)
        {
            List<T> recordList = new List<T>();
            using (SqlConnection objConnection = new SqlConnection(ConnectionString()))
            {
                objConnection.Open();
                recordList = SqlMapper.Query<T>(objConnection, spName, commandType: CommandType.StoredProcedure).ToList();
                objConnection.Close();
            }
            return recordList;
        }
        public static List<T> GetRecords<T>(string spName, List<ParameterInfo> parameters)
        {
            List<T> recordList = new List<T>();
            using (SqlConnection objConnection = new SqlConnection(ConnectionString()))
            {
                objConnection.Open();
                DynamicParameters p = new DynamicParameters();
                foreach (var param in parameters)
                {
                    p.Add("@" + param.ParameterName, param.ParameterValue);
                }

                recordList = SqlMapper.Query<T>(objConnection, spName, p, commandType: CommandType.StoredProcedure).ToList();
                objConnection.Close();
            }
            return recordList;
        }
        public static int GetIntRecord<T>(string spName, List<ParameterInfo> parameters)
        {
            int intRecord = 0;
            using (SqlConnection objConnection = new SqlConnection(ConnectionString()))
            {
                objConnection.Open();
                DynamicParameters p = new DynamicParameters();
                foreach (var param in parameters)
                {
                    p.Add("@" + param.ParameterName, param.ParameterValue);
                }

                using (var reader = SqlMapper.ExecuteReader(objConnection, spName, p, commandType: CommandType.StoredProcedure))
                {
                    if (reader != null && reader.Read())
                    {
                        intRecord = Convert.ToInt32(reader[0].ToString());
                    }
                }
                objConnection.Close();
            }
            return intRecord;
        }
        public static int ExecuteQuery(string spName, List<ParameterInfo> parameters)
        {
            int success = 0;
            using (SqlConnection objConnection = new SqlConnection(ConnectionString()))
            {
                objConnection.Open();
                DynamicParameters p = new DynamicParameters();
                foreach (var param in parameters)
                {
                    p.Add("@" + param.ParameterName, param.ParameterValue);
                }
                success = SqlMapper.Execute(objConnection, spName, p, commandType: CommandType.StoredProcedure);
                objConnection.Close();
            }
            return success;
        }

        public static int GetIntRecord<T>(string v, List<System.Reflection.ParameterInfo> param)
        {
            throw new NotImplementedException();
        }

        public static IEnumerable<T> ReturnList<T>(string procedureName, DynamicParameters param = null)
        {
            using (SqlConnection sqlcon = new SqlConnection(ConnectionString()))
            {
                sqlcon.Open();
                return sqlcon.Query<T>(procedureName, param, commandType: CommandType.StoredProcedure);

            }
        }
        public static int ExcutethoutReturn(string procedureName, DynamicParameters param = null)
        {
            int success = 0;
            using (SqlConnection sqlcon = new SqlConnection(ConnectionString()))
            {
                sqlcon.Open();
                success = sqlcon.Execute(procedureName, param, commandType: CommandType.StoredProcedure);
                sqlcon.Close();
            }
            return success;
        }
        public static int ExcuteReturn(string procedureName, DynamicParameters param = null)
        {
            int success = 0;
            using (SqlConnection sqlcon = new SqlConnection(ConnectionString()))
            {
                sqlcon.Open();
                success = sqlcon.ExecuteScalar<int>(procedureName, param, commandType: CommandType.StoredProcedure);
                sqlcon.Close();
            }
            return success;
        }

        public static T ExcuteScalar<T>(string procedureName, DynamicParameters param = null)
        {
            using (SqlConnection sqlcon = new SqlConnection(ConnectionString()))
            {
                sqlcon.Open();
                return (T)Convert.ChangeType(sqlcon.Execute(procedureName, param, commandType: CommandType.StoredProcedure), typeof(T));

            }
        }
        
        public static (List<T>, List<T1>) GetRecordsMultiList<T,T1>(string spName, List<ParameterInfo> parameters)
        {
            List<T> recordList_1 = new List<T>();
            List<T1> recordList_2 = new List<T1>();
            using (SqlConnection objConnection = new SqlConnection(ConnectionString()))
            {
                objConnection.Open();
                DynamicParameters p = new DynamicParameters();
                foreach (var param in parameters)
                {
                    p.Add("@" + param.ParameterName, param.ParameterValue);
                }

                var data= SqlMapper.QueryMultiple(objConnection, spName, p, commandType: CommandType.StoredProcedure);
                recordList_1 = data.Read<T>().ToList();
                recordList_2 = data.Read<T1>().ToList();
                objConnection.Close();
            }
            return (recordList_1, recordList_2);
        }

    }
}


