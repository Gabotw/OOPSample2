namespace OOPSample.Sales.Domain.model.Aggregates;

public class SalesOrder(int id, int customerId)
{
    public int Id { get; } = id;
    public int CustomerId { get; } = customerId;
    
}