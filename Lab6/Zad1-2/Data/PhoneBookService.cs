using Microsoft.EntityFrameworkCore;

namespace Zad1_2.Data;

public class PhoneBookService
{
    public async Task<Person[]> GetAllPersons()
    {
        await using var context = new PersonContext();

        return (from p in context.Persons select p).ToArray();
    }

    public async Task CreatePerson(Person person)
    {
        await using var context = new PersonContext();

        await context.AddAsync(person);
        await context.SaveChangesAsync();
    }

    public async Task<Person[]> FindPersonByAddress(string? address)
    {
        await using var context = new PersonContext();
        var persons = from p in context.Persons
            where EF.Functions.ILike(p.Address, $"%{address}%")
            select p;

        return persons.ToArray();
    }
}