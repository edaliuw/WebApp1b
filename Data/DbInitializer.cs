using bracketdocious.Models;
using System;
using System.Linq;

namespace bracketdocious.Data
{
    public static class DbInitializer
    {
        public static void Initialize(TournamentContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Brackets.Any())
            {
                return;   // DB has been seeded
            }

// ID, NAME, ROUNDFORMAT, CREATEDAT, ACTIVE

            var brackets = new Bracket[]
            {
            new Bracket{ID=1,Name="Test Bracket",RoundFormat=1,CreatedAt=DateTime.Now,Active=1},
            new Bracket{ID=2,Name="Test Bracket 2",RoundFormat=1,CreatedAt=DateTime.Now,Active=1}
            };
            foreach (Bracket s in brackets)
            {
                context.Brackets.Add(s);
            }
            context.SaveChanges();
        }
    }
}