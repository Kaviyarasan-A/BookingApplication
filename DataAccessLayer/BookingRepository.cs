using Dapper;
using DataAccessLayer.entity;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLayer
{
    

    public class BookingRepository : IBookingRepository
    {
       
        string connectionString = string.Empty;// "server=DESKTOP-BLBGEHJ\\SQLEXPRESS;database=BusTicket;user Id =sa;password=Anaiyaan@123;";
        SqlConnection con = null;
        public BookingRepository(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("Dbconnection");
            con = new SqlConnection(connectionString);
        }



        public List<BookingTicket> SelectALLUser()
        {

            try
            {
                var selectQuery = $"exec ListBookTicket_sp";
                con.Open();
                List<BookingTicket> result = con.Query<BookingTicket>(selectQuery).ToList();
                con.Close();

                return result;

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public BookingTicket SelectUserByUsername(string Busname)
        {
            try
            {
                var selectQuery = $"exec SelectByName '{Busname}'";
                con.Open();
                BookingTicket result = con.QueryFirstOrDefault<BookingTicket>(selectQuery);
                con.Close();

                return result;

            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public void Registeruser(BookingTicket userRegData)
        {
            try
            {
                var insertQuery = $"exec InsertBookTicket_sp '{userRegData.Busname}','{userRegData.Startingpoint}','{userRegData.Droppingpoint}',{userRegData.Amount},{userRegData.NoOfpeople},'{userRegData.JourneyDate}',{userRegData.ContactNo}";
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                con.Execute(insertQuery);
                con.Close();



            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public void UpdateUser(BookingTicket reg)
        {
            try
            {
                var updateQuery = $"exec UpdateBookTicket_sp  {reg.TicketID},'{reg.Busname}','{reg.Startingpoint}','{reg.Droppingpoint}',{reg.Amount},{reg.NoOfpeople},'{reg.JourneyDate}',{reg.ContactNo}";
                con.Open();
                con.Execute(updateQuery);
                con.Close();

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void DeleteUser(long TicketId)
        {
            try
            {
                var deleteQuery = $"exec DeleteBookTicket_sp {TicketId}";
                con.Open();
                con.Execute(deleteQuery);
                con.Close();

            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}
