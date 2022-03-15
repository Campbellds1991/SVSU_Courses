using Hw7.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Hw7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            

            InitializeComponent();
            CmdProb1.Click += Problem1;
            CmdProb2.Click += Problem2;
            CmdProb3.Click += Problem3;
            CmdProb4.Click += Problem4;
            CmdProb5.Click += Problem5;
            CmdProb6.Click += Problem6;

        }

        public void Problem1(object sender, EventArgs e)
        {
            using (var ctx = new HW7())
            {
                DgOutput.ItemsSource = ctx.Customer.Where(c => c.Order.Count() > 1).Select(c => new { Name = c.CustomerName, count = c.Order.Count() }).ToList();
                this.UpdateLayout();
            }
        }

        public void Problem2(object sender, EventArgs e)
        {
            using (var ctx = new HW7())
            {
                DgOutput.ItemsSource = ctx.Employee.Select(c =>
                new
                {
                    Name = c.EmployeeName,
                    HireDate = c.EmployeeDateHired.ToString(),
                    Manager = c.Supervisor.EmployeeName,
                    ManagersHireDate = c.EmployeeDateHired > c.Supervisor.EmployeeDateHired ? c.Supervisor.EmployeeDateHired.ToString() : ""
                }).ToList();
                this.UpdateLayout();
            }
        }

        public void Problem3(object sender, EventArgs e)
        {
            using (var ctx = new HW7())
            {
                DgOutput.ItemsSource = ctx.Order
                    .Where(o => o.Customer.CustomerId == 6)
                    .SelectMany(c => c.OrderLine)
                    .Select(c =>
                    new
                    {
                        c.OrderID,
                        c.Order.CustomerID,
                        c.Order.OrderDate,
                        ProductName = c.Product.ProductDescription,
                        c.OrderedQuantity
                    }).ToList();
                this.UpdateLayout();
            }
        }

        public void Problem4(object sender, EventArgs e)
        {
            using (var ctx = new HW7())
            {
                DgOutput.ItemsSource = ctx.Product.Select(p =>
                new
                {
                    p.ProductID,
                    p.ProductDescription,
                    p.ProductStandardPrice,
                    TotCost = p.Uses.Sum(
                        usedMaterial =>
                        usedMaterial.Material.MaterialStandardPrice * 
                        usedMaterial.QuantityRequired)
                }).ToList();
                this.UpdateLayout();
            }
        }

        public void Problem5(object sender, EventArgs e)
        {
            using (var ctx = new HW7())
            {
                DgOutput.ItemsSource = ctx.Customer
                    .Select(cust =>
                    new
                    {
                        cust.CustomerName,
                        UnitsSold = cust.Order
                            .SelectMany(order =>
                                order.OrderLine
                                .Where(orderline => orderline.Product.ProductID == 3))
                                .Sum(order => order.OrderedQuantity)
                    })
                    .Where(a => a.UnitsSold > 0)
                    .ToList();

                this.UpdateLayout();
            }
        }

        public void Problem6(object sender, EventArgs e)
        {
            using (var ctx = new HW7())
            {               

                DgOutput.ItemsSource = ctx.Order
                    .Where(b =>
                        b.OrderDate.Value.Month == 3
                        && b.OrderDate.Value.Year == 2015
                        && b.OrderLine
                        .Where(c => c.Product.ProductLineID == 1)
                        .Count() != 0)
                    .Select(b => new { b.Customer.CustomerName })
                    .Distinct()
                    .ToList();
                this.UpdateLayout();
            }
        }
    }
}
