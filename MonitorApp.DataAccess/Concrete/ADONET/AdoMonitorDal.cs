using Microsoft.Data.SqlClient;
using MonitorApp.DataAccess.Abstract;
using MonitorApp.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;
using System.Text;

namespace MonitorApp.DataAccess.Concrete.ADONET
{
    public class AdoMonitorDal : IMonitorDal
    {
        SqlConnection _connection = new SqlConnection(@"server=(localdb)\mssqllocaldb; initial catalog=MonitorDB; integrated security=true");
        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }
        public void Add(Monitor entity)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "Insert into Monitors values (@Model,@Fiyat,@Boyut)", _connection);
            command.Parameters.AddWithValue("@Model", entity.Model);
            command.Parameters.AddWithValue("@Fiyat", entity.Fiyat);
            command.Parameters.AddWithValue("@Boyut", entity.Boyut);
            command.ExecuteNonQuery();

            _connection.Close();
        }
        public void Delete(Monitor entity)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "Delete from Monitors where Id=@id ", _connection);
            command.Parameters.AddWithValue("@id", entity);
            command.ExecuteNonQuery();

            _connection.Close();
        }
        public Monitor Get(Expression<Func<Monitor, bool>> filter = null)
        {
            throw new NotImplementedException();
        }
        public List<Monitor> GetAll(Expression<Func<Monitor, bool>> filter = null)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * from Monitors", _connection);
            SqlDataReader reader = command.ExecuteReader();

            List<Monitor> monitors = new List<Monitor>();

            while (reader.Read())
            {
                Monitor monitor = new Monitor()
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Model = reader["Model"].ToString(),
                    Fiyat = Convert.ToDecimal(reader["Fiyat"]),
                    Boyut = Convert.ToDecimal(reader["Boyut"])
                };

                monitors.Add(monitor);
            }

            reader.Close();
            _connection.Close();
            return monitors;
        }
        public void Update(Monitor entity)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "Update Monitors set Model=@Model, Fiyat=@Fiyat, Boyut=@Boyut where Id=@id ", _connection);
            command.Parameters.AddWithValue("@Model", entity.Model);
            command.Parameters.AddWithValue("@Fiyat", entity.Fiyat);
            command.Parameters.AddWithValue("@Boyut", entity.Boyut);
            command.Parameters.AddWithValue("@id", entity.Id);
            command.ExecuteNonQuery();

            _connection.Close();
        }
    }
}
