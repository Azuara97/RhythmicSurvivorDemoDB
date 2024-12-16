﻿namespace GameAPI.Models
{
    public class ServerResponse
    {
        public int statusCode { get; set; }
        public string statusMessage { get; set; }
        public PlayerData dataChanged { get; set; }
        public List<PlayerData> gamesData { get; set; }
    }
}