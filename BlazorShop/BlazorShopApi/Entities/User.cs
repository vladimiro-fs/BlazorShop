﻿namespace BlazorShopApi.Entities
{
    public class User
    {
        public int Id { get; set; }

        public string? UserName { get; set; }

        public Cart? Cart { get; set; }
    }
}
