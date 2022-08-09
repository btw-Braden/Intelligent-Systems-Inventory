
public class Product
{
    public List Products;
    public string Identifier{get; set;};
    public string Model{get; set;};
    public string Serial{get; set;};
    public string Manufacturer{get; set;}
    public int Quantity{get; set;}; 

    public Product{string id, string model, string serial, string manu, int quant}
    {
        Identifier = id;
        Model = model;
        Serial = searial;
        Quantity = Quant;
        Manufacturer = manu;
    }
}
class Run
{
    public static void Main()
    {
        Program.Default();
    }

}
public class Program
{
    //CRUD

    //The default hold method where awaits user input
    public void Default()
    {
        //wait for user input 
    }



    //Runs this mehtod when user wants to add a product to the repository
    private Product AddProduct()
    {
        
    }




    //Runs this mehtod when user wants to view a product in the repository by model#
    private Object ViewProductByModel(string model)
    {
        
    }
    //Runs this mehtod when user wants to view a product in the repository by model#
    private Object ViewProductBySerial(string serial)
    {
        
    }
    //Runs this mehtod when user wants to view a product in the repository by model#
    private Object ViewProductByManufacturer(string manu)
    {
        
    }


    //Runs this mehtod when user wants to view all products in the repository
    private List ViewAllProducts()
    {

    }

    private Object ParseProducts(string id, List products)
    {
        foreach (Object item in products)
        {
            if (id == item.model)
            {
                return item;
            }
            if (id == item.serial)
            {
                return item;
            }
            if (id == item.model)
            {
                return item;
            }
        }
    }





    //Runs this mehtod when user wants to edit a product in the repository
    private Product EditProduct(string serial)
    {
        
    }




    //Runs this mehtod when user wants to delete a product from the repository
    private void DeleteProduct()
    {
        
    }
}