﻿namespace N01_NUnit_ShopQuanAo.Utils
{
    using System.Text;

    public class MyRandom
    {
        private static readonly Random random = new Random();
        private static readonly string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

        public static string Get(int size = 6)
        {
            StringBuilder builder = new StringBuilder(size);
            for (int i = 0; i < size; i++)
            {
                int randomIndex = random.Next(characters.Length);
                char randomChar = characters[randomIndex];
                builder.Append(randomChar);
            }

            return builder.ToString();
        }
    }
}
