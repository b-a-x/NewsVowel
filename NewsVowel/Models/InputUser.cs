using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsVowel.Models
{
    public class InputUser
    {
        private string _topic;
        public string Topic { get => string.IsNullOrWhiteSpace(_topic) ? "космос" : _topic; set => _topic = value; }
        public string KeyApi { get; set; }
    }
}
