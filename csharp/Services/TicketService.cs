using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IDPRO.csharp.Model;
using System.Data.SqlClient;
using IDPRO.csharp.Constants;
using IDPRO.csharp.DAO;

namespace IDPRO.csharp.Services
{
    public class TicketService
    {
        public string TicketAdd(Ticket ticket)
        {
           
            SqlConnection conn = null;
            SqlTransaction trans = null;

            string returnString = IdProConstants.SUCCESS;

          
            TicketDao ticketdao = new TicketDao();
            ConnectionDao ConnectionDao = new ConnectionDao();
            
            try
            {
                conn = ConnectionDao.getConnection();

                trans = conn.BeginTransaction();

                //ticket.tickettypeid = ticketdao.addticketsTypedetail(conn, trans, ticket);
                //if (!ticket.tickettypeid.Equals(0))
                //{
                  ticket.ticketid = ticketdao.addticketsdetail(conn, trans, ticket);
                    if (!ticket.ticketid.Equals(0))
                    {
                        ticket.noteid = ticketdao.addticketsNotedetail(conn, trans, ticket);

                        if (!ticket.noteid.Equals(0))
                        {
                            returnString = ticketdao.addticketsAssignment(conn, trans, ticket);
                        }
                        else
                        {
                            trans.Commit();
                        }
                    }
                    else
                    {
                        trans.Rollback();
                    }

                    trans.Commit();
                }
                //else
                //{
                //    trans.Rollback();
                //}
 

            //}
              
            
            catch (Exception exception)
            {
                trans.Rollback();
                System.Diagnostics.Trace.WriteLine("[EmployeeServices:addEmployee] Exception " + exception.StackTrace);

            }
            finally
            {
                ConnectionDao.closeConnection(conn);


            }

            return returnString;
            
          

        }

    }
}