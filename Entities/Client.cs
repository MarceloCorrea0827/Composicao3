﻿using System;

namespace ExercComposição3.Entities
{
    class Client
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client() { }
        public Client(string nome, string email, DateTime birthDate)
        {
            Nome = nome;
            Email = email;
            BirthDate = birthDate;
        }
    }
}
