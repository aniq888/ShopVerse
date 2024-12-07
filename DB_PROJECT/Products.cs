using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_PROJECT
{
    public class Products
    {
        public int product_id;
        public String name;
        public double price;
        public String description;
        public String imageUrl;
        public int quantity = 1;
        public int capacity;

        public int getProduct_id()
        {
            return product_id;
        }

        public void setProduct_id(int product_id)
        {
            this.product_id = product_id;
        }

        public int getCapacity()
        {
            return capacity;
        }

        public void setCapacity(int capacity)
        {
            this.capacity = capacity;
        }

        public String getName()
        {
            return name;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public double getPrice()
        {
            return price;
        }

        public void setPrice(double price)
        {
            this.price = price;
        }

        public String getDescription()
        {
            return description;
        }

        public void setDescription(String description)
        {
            this.description = description;
        }

        public String getImageUrl()
        {
            return imageUrl;
        }

        public void setImageUrl(String imageUrl)
        {
            this.imageUrl = imageUrl;
        }

        public int getQuantity()
        {
            return quantity;
        }

        public void setQuantity(int quantity)
        {
            this.quantity = quantity;
        }

        public Products() { }

        public Products(int product_id, String name, double price, String description, String imageUrl, int capacity)
        {
            this.product_id = product_id;
            this.name = name;
            this.price = price;
            this.description = description;
            this.imageUrl = imageUrl;
            this.capacity = capacity;
            quantity = 1;
        }
    }
}