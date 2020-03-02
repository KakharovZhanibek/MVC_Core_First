using MVC_Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Core.Entities
{
    public class Email : IMessage
    {
        public string Send()
        {
            return "Message sended by Email";
        }
    }
}
