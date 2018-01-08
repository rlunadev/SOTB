using Server.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Server.App_Start
{
    public class PersonDBInitializer : DropCreateDatabaseAlways<PersonDBContext>
    {
        protected void Seed(PersonDBContext context)

        {

            var persons = new List<Person> {

    new Person { Name = "Julio", LastName = "Avellaneda", Twitter =
    "@julitogtu"},

    new Person { Name = "Juan", LastName = "Ruiz", Twitter =
    "@juankruiz"},

    new Person { Name = "Roberto", LastName = "Alvarado", Twitter =
    "@ralvaradot"},

    new Person { Name = "Nicolas", LastName = "Herrera", Twitter =
    "@nicolocodev"},

    new Person { Name = "Jorge", LastName = "Ramirez", Twitter =
    "@jramirezdev"},

    new Person { Name = "Nelson", LastName = "Venegas", Twitter =
    "@nvenegar"}

    };

            persons.ForEach(c => context.Person.Add(c));

            context.SaveChanges();

        }

    }
}