using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Data.Entity
{
    public class Messages
    {
        public Guid Id { get; set; }  // идентификатор сообщения
        public Guid To_id { get; set; }     // внешний ключ для связи с таблицей user(сообщение адресовано)
        public Guid From_id { get; set; }    // внешний ключ для связи с таблицей user(сообщение отправлено)
        public int Content_id; // внешний ключ для таблицы contents(содержимое сообщения)
        public DateTime Created_at; // время создания сообщения
        
    }
}
