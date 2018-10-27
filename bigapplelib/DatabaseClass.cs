using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using Dapper;

namespace bigapplelib
{
    public class DatabaseClass
    {
        public static List<ClientRecordModel> LoadClientRecord(string fromdate, string todate)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var output = connection.Query<ClientRecordModel>("SELECT * FROM ClientTable WHERE DATE BETWEEN '" + fromdate + "' AND '" + todate + "'", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<DailySalesClientModel> LoadDailySalesClientRecord(string fromdate, string todate)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var output = connection.Query<DailySalesClientModel>("SELECT MEQty1,MEAmount1,MEQty2,MEAmount2,MEQty3,MEAmount3," +
                    "UNMWQty1,UNMWAmount1,UNMWQty2,UNMWAmount2," +
                    "NYFPQty1,NYFPAmount1,NYFPQty2,NYFPAmount2,NYFPQty3,NYFPAmount3,NYFPQty4,NYFPAmount4," +
                    "DRTNQty1,DRTNAmount1,DRTNQty2,DRTNAmount2,DRTNQty3,DRTNAmount3,DRTNQty4,DRTNAmount4," +
                    "MDQty1,MDAmount1,MDQty2,MDAmount2,MDQty3,MDAmount3,MDQty4,MDAmount4,MDQty5,MDAmount5,MDQty6,MDAmount6," +
                    "PRQty1,PRAmount1,PRQty2,PRAmount2,PRQty3,PRAmount3," +
                    "ATQty1,ATAmount1,ATQty2,ATAmount2 FROM ClientTable WHERE DATE BETWEEN '" + fromdate + "' AND '" + todate + "'", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<DailySalesClientModel> LoadTherapistRecord(string fromdate, string todate, string therapist)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var output = connection.Query<DailySalesClientModel>("SELECT MEQty1,MEAmount1,MEQty2,MEAmount2,MEQty3,MEAmount3," +
                    "UNMWQty1,UNMWAmount1,UNMWQty2,UNMWAmount2," +
                    "NYFPQty1,NYFPAmount1,NYFPQty2,NYFPAmount2,NYFPQty3,NYFPAmount3,NYFPQty4,NYFPAmount4," +
                    "DRTNQty1,DRTNAmount1,DRTNQty2,DRTNAmount2,DRTNQty3,DRTNAmount3,DRTNQty4,DRTNAmount4," +
                    "MDQty1,MDAmount1,MDQty2,MDAmount2,MDQty3,MDAmount3,MDQty4,MDAmount4,MDQty5,MDAmount5,MDQty6,MDAmount6," +
                    "PRQty1,PRAmount1,PRQty2,PRAmount2,PRQty3,PRAmount3," +
                    "ATQty1,ATAmount1,ATQty2,ATAmount2 FROM ClientTable WHERE DATE BETWEEN '" + fromdate + "' AND '" + todate + "' AND TherapistAssigned = '" + therapist + "'", new DynamicParameters());
                return output.ToList();
            }
        }

        public static string ClientEntryPlusOne()
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var output = connection.Query("SELECT * FROM ClientTable").ToList();
                var x = output.Count() + 1;
                return x.ToString();
            }
        }

        public static string NumberSeries(string fromtime, string totime, string fromdate, string todate)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var output = connection.Query("SELECT * FROM ClientTable " +
                    "WHERE (Time BETWEEN '" + fromtime + "' AND '" + totime + "') AND (Date BETWEEN '" + fromdate + "' AND '" + todate + "')").ToList();
                var x = output.Count();
                return x.ToString();
            }
        }

        public static List<TotalSalesClientModel> TotalSalesClientModel(string fromdate, string todate)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var output = connection.Query<TotalSalesClientModel>("SELECT Total FROM ClientTable " +
                    "WHERE (Date BETWEEN '" + fromdate + "' AND '" + todate + "')").ToList();
                return output.ToList();
            }
        }

        public static List<TotalSalesClientModel> TotalSalesClientModels(string fromtime, string totime, string fromdate, string todate)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var output = connection.Query<TotalSalesClientModel>("SELECT Total FROM ClientTable " +
                    "WHERE (Time BETWEEN '" + fromtime + "' AND '" + totime + "') AND (Date BETWEEN '" + fromdate + "' AND '" + todate + "')").ToList();
                return output.ToList();
            }
        }


        public static string NumberSeriesWithTherapist(string fromtime, string totime, string fromdate, string todate, string therapist)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var output = connection.Query("SELECT * FROM ClientTable " +
                    "WHERE (Time BETWEEN '" + fromtime + "' AND '" + totime + "') " +
                    "AND (Date BETWEEN '" + fromdate + "' AND '" + todate + "') " +
                    "AND (TherapistAssigned = '" + therapist + "')").ToList();
                var x = output.Count();
                return x.ToString();
            }
        }

        public static List<TotalSalesClientModel> TotalSalesClientModelsWithTherapist(string fromtime, string totime, string fromdate, string todate, string therapist)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var output = connection.Query<TotalSalesClientModel>("SELECT * FROM ClientTable " +
                    "WHERE (Time BETWEEN '" + fromtime + "' AND '" + totime + "') " +
                    "AND (Date BETWEEN '" + fromdate + "' AND '" + todate + "') " +
                    "AND (TherapistAssigned = '" + therapist + "')").ToList();
                return output.ToList();
            }
        }

        public static List<TotalSalesClientModel> TotalSalesClientModelWithTherapist(string fromdate, string todate, string therapist)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var output = connection.Query<TotalSalesClientModel>("SELECT Total FROM ClientTable " +
                    "WHERE (Date BETWEEN '" + fromdate + "' AND '" + todate + "') " +
                    "AND (TherapistAssigned = '" + therapist + "')").ToList();
                return output.ToList();
            }
        }

        public static void SaveClientRecord(ClientRecordModel clientRecordModel)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Execute("INSERT INTO ClientTable(SeriesNumber,NameOfClient,SeniorCitizen,TherapistAssigned,Date,Time," +
                    "MEQty1,MEAmount1,MEQty2,MEAmount2,MEQty3,MEAmount3," +
                    "UNMWQty1,UNMWAmount1,UNMWQty2,UNMWAmount2," +
                    "NYFPQty1,NYFPAmount1,NYFPQty2,NYFPAmount2,NYFPQty3,NYFPAmount3,NYFPQty4,NYFPAmount4," +
                    "DRTNQty1,DRTNAmount1,DRTNQty2,DRTNAmount2,DRTNQty3,DRTNAmount3,DRTNQty4,DRTNAmount4," +
                    "MDQty1,MDAmount1,MDQty2,MDAmount2,MDQty3,MDAmount3,MDQty4,MDAmount4,MDQty5,MDAmount5,MDQty6,MDAmount6," +
                    "PRQty1,PRAmount1,PRQty2,PRAmount2,PRQty3,PRAmount3," +
                    "ATQty1,ATAmount1,ATQty2,ATAmount2," +
                    "Total,NetOfVAT,VAT,SeniorCitizenDiscount,TotalAmountDue) " +

                    "VALUES (@SeriesNumber,@NameOfClient,@SeniorCitizen,@TherapistAssigned,@Date,@Time," +
                    "@MEQty1,@MEAmount1,@MEQty2,@MEAmount2,@MEQty3,@MEAmount3," +
                    "@UNMWQty1,@UNMWAmount1,@UNMWQty2,@UNMWAmount2," +
                    "@NYFPQty1,@NYFPAmount1,@NYFPQty2,@NYFPAmount2,@NYFPQty3,@NYFPAmount3,@NYFPQty4,@NYFPAmount4," +
                    "@DRTNQty1,@DRTNAmount1,@DRTNQty2,@DRTNAmount2,@DRTNQty3,@DRTNAmount3,@DRTNQty4,@DRTNAmount4," +
                    "@MDQty1,@MDAmount1,@MDQty2,@MDAmount2,@MDQty3,@MDAmount3,@MDQty4,@MDAmount4,@MDQty5,@MDAmount5,@MDQty6,@MDAmount6," +
                    "@PRQty1,@PRAmount1,@PRQty2,@PRAmount2,@PRQty3,@PRAmount3," +
                    "@ATQty1,@ATAmount1,@ATQty2,@ATAmount2," +
                    "@Total,@NetOfVAT,@VAT,@SeniorCitizenDiscount,@TotalAmountDue)", clientRecordModel);
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;   
        }
    }
}
