using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2.model
{
    class COURSE
    {
        MY_DB mydb = new MY_DB();
        public bool insertCourse(int cID, string cLabel, int cPeriod, string cDesc)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Course (courseID,courseLabel,coursePeriod,courseDesc)" +
                " VALUES (@cid,@clabel,@cperiod,@cdesc)", mydb.getConnection);
            command.Parameters.Add("@cid", SqlDbType.Int).Value = cID;
            command.Parameters.Add("@clabel", SqlDbType.VarChar).Value = cLabel;
            command.Parameters.Add("@cperiod", SqlDbType.Int).Value = cPeriod;
            command.Parameters.Add("@cdesc", SqlDbType.Text).Value = cDesc;
           
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool deleteCourse(int cID)
        {
            SqlCommand command = new SqlCommand("DELETE from Course WHERE courseID=@cID", mydb.getConnection);
            command.Parameters.Add("@cID", SqlDbType.Int).Value = cID;
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public DataTable getAllCourse()
        {
            DataTable tbStd = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Course", mydb.getConnection);
            SqlDataAdapter dataStd = new SqlDataAdapter(cmd);
            dataStd.Fill(tbStd);
            return tbStd;
        }
        public bool updateCourse(int cID, string clabel, int cped, string cDesc)
        {
            SqlCommand command = new SqlCommand("UPDATE Course set courseLabel=@clabel, coursePeriod=@cped,courseDesc=@cDesc WHERE courseID=@cID", mydb.getConnection);
            command.Parameters.Add("@cID", SqlDbType.Int).Value = cID;
            command.Parameters.Add("@clabel", SqlDbType.VarChar).Value = clabel;
            command.Parameters.Add("@cped", SqlDbType.Int).Value = cped;
            command.Parameters.Add("@cDesc", SqlDbType.VarChar).Value = cDesc;
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public DataTable courseSearchLb(string label)
        {
            DataTable tbCourse = new DataTable();
            SqlCommand cmd = new SqlCommand("Select * from Course WHERE courseID=@cid or courseLabel=@clabel or coursePeriod=@cped ", mydb.getConnection);
            cmd.Parameters.Add("@cid", SqlDbType.VarChar).Value = label;
            cmd.Parameters.Add("@clabel", SqlDbType.VarChar).Value = label;
            cmd.Parameters.Add("@cped", SqlDbType.VarChar).Value = label;
            SqlDataAdapter dataStd = new SqlDataAdapter(cmd);
            dataStd.Fill(tbCourse);
            return tbCourse;
        }
        
    }
}
