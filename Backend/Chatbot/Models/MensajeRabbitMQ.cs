using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RabbitMQ.Client;
using Newtonsoft.Json;
using Chatbot.Interfaces;

namespace Chatbot.Models
{
    internal class MensajeRabbitMQ : IRabitMQMensajeria
    {
        public void SendProductMessage<T>(T message)
        {

            var factory = new ConnectionFactory
            {
                HostName = "localhost"
            };

            var connection = factory.CreateConnection();

            var channel = connection.CreateModel();
           
            channel.QueueDeclare("Chat", exclusive: false);
            
            var json = JsonConvert.SerializeObject(message);
            var body = Encoding.UTF8.GetBytes(json);
           
            channel.BasicPublish(exchange: "", routingKey: "Chat", body: body);


            

        }

        }
}
