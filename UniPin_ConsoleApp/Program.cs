using Application.DTO;
using Domain;
using System;
using UniPin_DataAccess;

namespace UniPin_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new UniPin_Context();

            var user = context.Users.Find(4);

            context.Users.Remove(user);
            context.SaveChanges();
        }
    }
}
