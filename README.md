# Writing testable code with EF

# Goal
- Create an easier way to test against our LINQ queries using EF

# Mistakes I've seen
## IEnumerable instead of IQueryable

```c#
public interface IDataAcess
{
    IEnumerable Set<Person>();
}
```

## Unsupported LINQ Queries
https://docs.microsoft.com/en-us/dotnet/framework/data/adonet/ef/language-reference/supported-and-unsupported-linq-methods-linq-to-entities
