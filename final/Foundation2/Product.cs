
public class Product
{
    // Product variables
    private string name;
    private string id;
    private double price;
    private int quantity;
    private double total_price;

    // Product class constructor
    public Product(string product_name, string product_id, double product_price, int product_quantity)
    {
        name = product_name;
        id = product_id;
        price = product_price;
        quantity = product_quantity;
        total_price = price * quantity; // Price of the product multiplied by the quantity equals the total price
    }

    // Method to update the total price again if the price or quantity of the product is changed
    private void updateTotalPrice()
    {
        total_price = price * quantity;
    }

    // GETTER AND SETTER METHODS FOR PRIVATE VARIABLES
    public double getTotalPrice()
    {
        updateTotalPrice();
        return total_price;
    }
    public string getName()
    {
        return name;
    }
    public void setName(string new_name)
    {
        name = new_name;
    }
    public string getID()
    {
        return id;
    }
    public void setID(string new_id)
    {
        id = new_id;
    }
    public double getPrice()
    {
        return price;
    }
    public void setPrice(double new_price)
    {
        price = new_price;
        updateTotalPrice();
    }
    public int getQuantity()
    {
        return quantity;
    }
    public void setQuantity(int new_quantity)
    {
        quantity = new_quantity;
        updateTotalPrice();
    }
}