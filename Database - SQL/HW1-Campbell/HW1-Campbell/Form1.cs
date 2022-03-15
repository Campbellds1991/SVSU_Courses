//*************************************************************************
//  Course: CIS-386 18'FA
//  Homework1 : VB Database Programming using Access Database
//  Instructor: Dr. Cho
//  Student: Devin Campbell
//  Due Date: Sept 11, 2018
//  Program Description: Read from a access database file and present
//      the user with information from the database regarding a days sales
//      or tell the user how many items need to ordered to fullfill that days
//      orders
//  Framework / Language: Windows Forms / C#
//
//**************************************************************************

using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace HW1_Campbell
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Form initialization
        /// 
        /// Initialize the form and fill the table adapters for the application
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            ordersTableAdapter.Fill(MicrolandDB.Orders);
            inventoryTableAdapter.Fill(MicrolandDB.Inventory);
            customersTableAdapter.Fill(MicrolandDB.Customers);
        }
        /// <summary>
        /// cmdPurchaseTotal.click event handler
        /// 
        /// Queries the database and aggregates the purchases of 
        ///     each customer and displays it to the user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetPurchaseTotal(object sender, EventArgs e)
        {            
            lstOutputView.Items.Clear();

            // Query database, Create a LEFT OUTER join for customers on orders,
            //      group customer orders togeather, Summate all orders per group, 
            //      Output name and total
            var Query = from cust in MicrolandDB.Customers
                    let inv = MicrolandDB.Inventory
                    join order in MicrolandDB.Orders on 
                    cust.custID equals order.custID into g
                    select new
                    {
                        Name = cust.name,
                        Total = g.Sum(x => 
                        inv.FindByitemID(x.itemID).price * x.quantity)
                    };

            lstOutputView.Items.Add(
                String.Format("{0,-20}{1,10}", "Customer Name", "Purchase Total")
                );
          
            foreach (var Group in Query)
            {  
                lstOutputView.Items.Add(
                    String.Format("{0,-20}{1,10:C}", Group.Name, Group.Total)
                    );
            }
        }

        /// <summary>
        /// cmdBackOrder Event Handler
        /// 
        /// Queries the database for any item that does not have enought 
        ///     stock to meet purchase needs
        ///     then displays items that need extra stock to the user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>        
        private void GetBackorderAmmounts(object sender, EventArgs e)
        { 
            lstOutputView.Items.Clear();
            //  Query database to get all items that do not have enough 
            //      to fulfill orders
            var Query = from inv in MicrolandDB.Inventory
                        join orders in MicrolandDB.Orders on 
                            inv.itemID equals orders.itemID
                        where orders.quantity > inv.quantity
                        let QuantityToOrder = (orders.quantity - inv.quantity)
                        orderby inv.itemID
                        select new {
                            inv.itemID,
                            QuantityToOrder,
                            inv.description
                        };
            //  Listview Header
            lstOutputView.Items.Add(
                String.Format(
                    "{0,-15}{1,-20}{2}",
                    "Item Name",
                    "Quantity To Order", 
                    "Description"
                ));

            foreach (var item in Query)
            {
                //  Listview Line Item
                lstOutputView.Items.Add(
                    String.Format(
                        "{0,-15}{1,-20}{2}",
                        item.itemID,
                        item.QuantityToOrder,
                        item.description
                    ));
            }
            

        }

        
    }
}
