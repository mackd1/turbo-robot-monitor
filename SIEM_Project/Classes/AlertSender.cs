using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIEM_Project.Classes
{
    public delegate void Event_SendMessage(Alert alert);

    static class AlertSender
    {
        public static event Event_SendMessage Call_SendMessage;

        public static void SendMessage(string alertString, string typeString)
        {
            Alert temp = new Alert();

            temp.alertMessage = alertString;
            temp.errorType = typeString;

            Call_SendMessage(temp);
        }
    }

    public class Alert
    {
        public string errorType;
        public string alertMessage;
    }
}
