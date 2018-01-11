using Sotb.UI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Sotb.UI.App_Start
{
    public class PersonDBInitializer : DropCreateDatabaseAlways<PersonDBContext>
    {
        protected override void Seed(PersonDBContext context)
        {
            var persons = new List<Person> {
                new Person { Name = "Julio", LastName = "Avellaneda", Email = "@julitogtu",Address="vinto",Phone="123"},
                new Person { Name = "Juan", LastName = "Ruiz", Email = "@juankruiz",Address="vinto",Phone="123"},
                new Person { Name = "Roberto", LastName = "Alvarado", Email = "@ralvaradot",Address="vinto",Phone="123"},
                new Person { Name = "Nicolas", LastName = "Herrera", Email = "@nicolocodev",Address="vinto",Phone="123"}
            };

            persons.ForEach(c => context.Person.Add(c));
            context.SaveChanges();
        }
    }
}