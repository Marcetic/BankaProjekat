﻿namespace BankaProjekat.Models.ViewModels
{
    public class UpdateKorisnik
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public string MaticniBroj { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }
    }
}
