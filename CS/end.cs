
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



    //Runs this method when user wants to add a product to the repository
    //Defines product here
    private void CreateProduct()
    {
        /*
        string id = user.input;
        string model = user.input;
        string serial = user.input;
        string manu = user.input;
        int quantity = user.input;
        */

        Product newProduct = new Product
        {
            /*
            id,
            model,
            serial,
            manu,
            quantity
            */
        }
        AddProduct(newProduct);
    }

    //Add created product to List
    //from CreateProduct() Method
    private void AddProduct(Object newProduct)
    {
        Products.add(newProduct);
    }




    //Runs this method when user wants to view a product in the repository by model#
    private List ViewProductByModel(string model)
    {
        List modelList = new List();
        foreach (Object item in Products)
        {
            if (model == item.Model)
            {
                modelList.add(item);
            }
        }
        return modelList;
    }
    //Runs this method when user wants to view a product in the repository by serial#
    private Object ViewProductBySerial(string serial)
    {
        foreach (Object item in Products)
        {
            if (serial == item.Model)
            {
                return item;
            }
        }
        else return null;
    }
    //Runs this method when user wants to view a product in the repository by manufacturer
    private List ViewProductByManufacturer(string manu)
    {
       List modelList = new List();
        foreach (Object item in Products)
        {
            if (manu == item.Model)
            {
                modelList.add(item);
            }
        }
        return modelList;
    }


    //Runs this method when user wants to view all products in the repository
    private List ViewAllProducts(List products)
    {
        //View(products);
    }


    //Runs this method when user wants to edit a product in the repository
    private Product EditProduct(string serial)
    {
        Product newProduct = new Product
        {
            /*
            id,
            model,
            serial,
            manu,
            quantity
            */
        }
        Product oldProduct = ViewProductBySerial(string serial)
        Product newProduct = new Product
        {
            /*
            oldProduct.id = newProduct.id,
            oldProduct.model = newProduct.model,
            oldProduct.serial = newProduct.serial,
            oldProduct.manu = newProduct.manu,
            oldProduct.quantity = newProduct.quantity
            */
        }
    }




    //Runs this method when user wants to delete a product from the repository
    private void DeleteProduct(string serial)
    {
        Products.Remove(ViewProductBySerial(string serial));
    }
}