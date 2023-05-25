// See https://aka.ms/new-console-template for more information
using Chatbot.Interfaces;
using Chatbot.Models;


        ChatFileBot bot = new ChatFileBot();


        string cadenaarchivo = "Test_Chat\\Backend\\Chatbot\\files";
        var result = bot.AnalizarArchivo(cadenaarchivo);
