public class Product
{
    private string _name;
    private string _productId;
    private double _pricePerUnit;
    private int _quantity;

    // Constructor to initialize the product
    public Product(string name, string productId, double pricePerUnit, int quantity)
    {
        _name = name;
        _productId = productId;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }

    // Method to calculate the total cost of the product
    public double GetTotalCost()
    {
        return _pricePerUnit * _quantity;
    }

    // Method to get the product's name and ID for the packing label
    public string GetPackingLabel()
    {
        return $"{_name} (ID: {_productId})";
    }
}