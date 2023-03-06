using Bogus;
using Netflix.Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix.Infrastructure.Persistance.Contexts
{
    public class DataSeeding
    {
    public static List<User> GetUsers()
        {
            var result = new Faker<User>("tr")
                .RuleFor(x => x.Id, x => x.IndexFaker+1)
                .RuleFor(i => i.CreatedDate, i => i.Date.Between(DateTime.Now.AddDays(-100), DateTime.Now))
                .RuleFor(i => i.FirstName, i => i.Person.FirstName)
                .RuleFor(i => i.LastName, i => i.Person.LastName)
                .RuleFor(i => i.Email, i => i.Internet.Email())
                .RuleFor(i => i.ContactNumber, i => i.Phone.PhoneNumber())
                .Generate(10);

            return result;
        }

        public static List<Movie> GetMovies()
        {
            var movies = new string[] { "iron man", "cpatain america", "superman", "batman", "joker" };
            var result = new Faker<Movie>("tr")
                .RuleFor(x => x.Id, x => x.IndexFaker + 1)
                .RuleFor(x => x.Description, x => x.Lorem.Text())
                .RuleFor(x => x.CreatedDate, x => x.Date.Between(DateTime.Now.AddDays(-100), DateTime.Now))
                .RuleFor(x => x.Duration, x => x.Date.ToString())
                .RuleFor(x => x.Name, x => x.Commerce.ProductName())
                .Generate(10);
            return result;
        }

    }
}
