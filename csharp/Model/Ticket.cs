using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IDPRO.csharp.DAO;

namespace IDPRO.csharp.Model
{
  
    public class Ticket
    {
        public string ticketgetid { get; set; }
        Int32 TicketID, AccountID, TicketType;
        String AssignTo ,Status,Priority;
        DateTime OpenDate,CloseDate ,AssignDate;

        Int32 NoteID;
        String Note;
        DateTime NoteDate;

        Int32 TicketTypeId, PriorityInt_TicketType;
        String TicketTypeString, Assignment,AssignBy;


        public Ticket()
        {
            TicketID= AccountID= TicketType =0;
            AssignTo=Status=Priority=AssignBy ="";

            NoteID = 0;
            Note ="";
            AssignDate = DateTime.Now; 

            TicketTypeId = PriorityInt_TicketType = 0;
            TicketTypeString= Assignment="";

        }

        public int tickettypeid
        {
            get { return TicketTypeId; }
            set { TicketTypeId = value; }
        }

        public int priorityint_tickettype
        {
            get { return PriorityInt_TicketType; }
            set { PriorityInt_TicketType = value; }
        }

        public string tickettypestring
        {
            get { return TicketTypeString; }
            set { TicketTypeString = value; }
        }


        public string assignment
        {
            get { return Assignment; }
            set { Assignment = value; }
        }

        public int noteid
        {
            get { return NoteID; }
            set { NoteID = value; }
        }
        public string note
        {
            get { return Note; }
            set { Note = value; }
        }
         public DateTime notedate
        {
            get { return NoteDate; }
            set { NoteDate = value; }
        }
         

        public int ticketid
        {
            get { return TicketID; }
            set { TicketID = value; }
        }
        public int accountid
        {
            get { return AccountID; }
            set { AccountID = value; }
        }
        public int tickettype
        {
            get { return TicketType; }
            set { TicketType = value; }
        }
        public string assignby
        {
            get { return AssignBy; }
            set { AssignBy = value; }
        }
        public string assignto
        {
            get { return AssignTo; }
            set { AssignTo = value;}
        }
        public string status
        {
            get { return Status; }
            set { Status = value; }
        }
        public string priorty
        {
            get { return Priority; }
            set { Priority = value; }
        }
        public DateTime opendate
        {
            get { return OpenDate; }
            set { OpenDate = value; }
        }
        public DateTime closedate
        {
            get { return CloseDate; }
            set { CloseDate = value; }
        }
        public DateTime assigndate
        {
            get { return AssignDate; }
            set { AssignDate = value; }
        }
    }
  
}