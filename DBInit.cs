using System;
using System.Linq;

namespace cashmachine
{
    public static class DbInitializer
    {
        public static void Initialize(EfContext context)
        {
            context.Database.EnsureCreated();

            
            if (context.Cards.Any())
            {
                return;   // DB has been inited
            }

            var cards = new Card[]
            {
            new Card{ID="1234567890123456",pin="1234"},
            new Card{ID="1234567890123457",pin="1234"},
            new Card{ID="1234567890123458",pin="1234"},
            };
            foreach (Card s in cards)
            {
                context.Cards.Add(s);
            }
            context.SaveChanges();

            var operations = new Operation[]
            {
            new Operation{OutCard="1234567890123456",InCard="1234567890123457",amount=1,Time=DateTime.Now},
            new Operation{OutCard="1234567890123457",InCard="1234567890123458",amount=2,Time=DateTime.Now},
            new Operation{OutCard="1234567890123458",InCard="1234567890123456",amount=3,Time=DateTime.Now},
            };
            foreach (Operation c in operations)
            {
                context.Operations.Add(c);
            }
            context.SaveChanges();
        }
    }
}