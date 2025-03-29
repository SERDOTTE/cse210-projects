public class Customer
{
    private string _name;
    private Address _address;

    // Constructor to initialize the customer
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Method to check if the customer lives in the USA
    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }

    // Method to get the customer's name
    public string GetName()
    {
        return _name;
    }

    // Method to get the customer's address
    public string GetAddress()
    {
        return _address.GetFullAddress();
    }
}