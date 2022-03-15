namespace Hw7.Model
{
    using System;
    using System.Data.Entity;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;

    public partial class HW7 : DbContext
    {
        public HW7() : base("name=PVFC")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasKey(e => e.CustomerId);
            modelBuilder.Entity<CustomerShipAddress>().HasKey(e => e.ShipAddressID);
            modelBuilder.Entity<DoesBusinessIn>().HasKey(e => new { e.CustomerID, e.TerritoryID });
            modelBuilder.Entity<Employee>().HasKey(e => e.EmployeeID);
            modelBuilder.Entity<EmployeeSkills>().HasKey(e => new { e.EmployeeID, e.SkillID });
            modelBuilder.Entity<Material>().HasKey(e => e.MaterialID);
            modelBuilder.Entity<Order>().HasKey(e => e.OrderID);
            modelBuilder.Entity<OrderLine>().HasKey(e => e.OrderLineID);
            modelBuilder.Entity<Payment>().HasKey(e => e.PaymentID);
            modelBuilder.Entity<PaymentTypes>().HasKey(e => e.PaymentTypeID);
            modelBuilder.Entity<Producedin>().HasKey(e => new { e.ProductID, e.WorkCenterID });
            modelBuilder.Entity<Product>().HasKey(e => e.ProductID);
            modelBuilder.Entity<ProductLine>().HasKey(e => e.ProductLineID);
            modelBuilder.Entity<RawMaterial>().HasKey(e => e.MaterialID);
            modelBuilder.Entity<Reports>().HasKey(e => e.Report_ID);
            modelBuilder.Entity<Salesperson>().HasKey(e => e.SalespersonID);
            modelBuilder.Entity<Shipped>().HasKey(e => e.OrderLineID);
            modelBuilder.Entity<Skill>().HasKey(e => e.SkillID);
            modelBuilder.Entity<Supplies>().HasKey(e => new { e.VendorID, e.MaterialID });
            modelBuilder.Entity<Territory>().HasKey(e => e.TerritoryID);
            modelBuilder.Entity<Uses>().HasKey(e => new { e.ProductID, e.MaterialID });
            modelBuilder.Entity<Vendor>().HasKey(e => e.VendorID);
            modelBuilder.Entity<WorkCenter>().HasKey(e => e.WorkCenterID);
            modelBuilder.Entity<WorksIn>().HasKey(e => new { e.EmployeeID, e.WorkCenterID });

            modelBuilder.Entity<Customer>().Property(t => t.CustomerId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<CustomerShipAddress> CustomerShipAddressSet { get; set; }
        public virtual DbSet<DoesBusinessIn> DoesBusinessIn { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<EmployeeSkills> EmployeeSkills { get; set; }
        public virtual DbSet<Material> Material { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderLine> OrderLine { get; set; }
        public virtual DbSet<Payment> Payment { get; set; }
        public virtual DbSet<PaymentTypes> PaymentTypes { get; set; }
        public virtual DbSet<Producedin> Producedin { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductLine> ProductLine { get; set; }
        public virtual DbSet<RawMaterial> RawMaterial { get; set; }
        public virtual DbSet<Reports> Reports { get; set; }
        public virtual DbSet<Salesperson> Salesperson { get; set; }
        public virtual DbSet<Shipped> Shipped { get; set; }
        public virtual DbSet<Skill> Skill { get; set; }
        public virtual DbSet<Supplies> Supplies { get; set; }
        public virtual DbSet<Territory> Territory { get; set; }
        public virtual DbSet<Uses> Uses { get; set; }
        public virtual DbSet<Vendor> Vendor { get; set; }
        public virtual DbSet<WorkCenter> WorkCenter { get; set; }
        public virtual DbSet<WorksIn> WorksIn { get; set; }
    }

    [Table(name: "Customer")]
    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            this.CustomerShipAddress = new HashSet<CustomerShipAddress>();
            this.Order = new HashSet<Order>();
            this.DoesBusinessIn = new HashSet<DoesBusinessIn>();
        }

        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerCity { get; set; }
        public string CustomerState { get; set; }
        public string CustomerPostalCode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerShipAddress> CustomerShipAddress { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Order { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DoesBusinessIn> DoesBusinessIn { get; set; }
    }
    [Table(name: "CustomerShipAddress")]
    public partial class CustomerShipAddress
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CustomerShipAddress()
        {
            this.Order = new HashSet<Order>();
        }

        public int ShipAddressID { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public Nullable<int> TerritoryID { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipState { get; set; }
        public string ShipZip { get; set; }
        public string ShipDirections { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Territory Territory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Order { get; set; }
    }
    [Table(name: "DoesBusinessIn")]
    public partial class DoesBusinessIn
    {
        public int CustomerID { get; set; }
        public int TerritoryID { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Territory Territory { get; set; }
    }
    [Table(name: "Employee")]
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            this.EmployeeSkills = new HashSet<EmployeeSkills>();
            this.WorksIn = new HashSet<WorksIn>();
        }
        [MaxLength(10)]
        public string EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeAddress { get; set; }
        public string EmployeeCity { get; set; }
        public string EmployeeState { get; set; }
        public string EmployeeZip { get; set; }
        public Nullable<System.DateTime> EmployeeDateHired { get; set; }
        public Nullable<System.DateTime> EmployeeBirthDate { get; set; }

        [MaxLength(10)]
        public string EmployeeSupervisor { get; set; }

        [ForeignKey("EmployeeSupervisor")]
        public virtual Employee Supervisor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeSkills> EmployeeSkills { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorksIn> WorksIn { get; set; }
    }

    [Table(name: "EmployeeSkills")]
    public partial class EmployeeSkills
    {
        public string EmployeeID { get; set; }
        public string SkillID { get; set; }
        public Nullable<System.DateTime> QualifyDate { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Skill Skill { get; set; }
    }
    [Table(name: "Material")]
    public partial class Material
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Material()
        {
            this.Supplies = new HashSet<Supplies>();
            this.RawMaterial = new HashSet<RawMaterial>();
            this.Uses = new HashSet<Uses>();
        }

        public string MaterialID { get; set; }
        public string MaterialName { get; set; }
        public string Thickness { get; set; }
        public string Width { get; set; }
        public string SIZE { get; set; }
        public string Material1 { get; set; }
        public Nullable<double> MaterialStandardPrice { get; set; }
        public string UnitOfMeasure { get; set; }
        public string Type { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Supplies> Supplies { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RawMaterial> RawMaterial { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Uses> Uses { get; set; }
    }
    [Table(name: "Order")]
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            this.OrderLine = new HashSet<OrderLine>();
        }
        public int OrderID { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public int? CustomerID { get; set; }
        public DateTime? FulfillmentDate { get; set; }
        public int? SalesPersonID { get; set; }
        public int? ShipAdrsID { get; set; }
        public virtual Customer Customer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderLine> OrderLine { get; set; }
        public virtual Salesperson Salesperson { get; set; }
        [ForeignKey("ShipAdrsID")]
        public virtual CustomerShipAddress CustomerShipAddress { get; set; }
    }
    [Table(name: "OrderLine")]
    public partial class OrderLine
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrderLine()
        {
            this.Shipped = new HashSet<Shipped>();
        }

        public int OrderLineID { get; set; }
        public Nullable<int> OrderID { get; set; }
        public Nullable<int> ProductID { get; set; }
        public Nullable<int> OrderedQuantity { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Shipped> Shipped { get; set; }
    }
    [Table(name: "Payment")]
    public partial class Payment
    {
        public int PaymentID { get; set; }
        public Nullable<int> OrderID { get; set; }
        public Nullable<System.DateTime> PaymentDate { get; set; }
        public string PaymentTypeID { get; set; }
        public Nullable<decimal> PaymentAmount { get; set; }
        public string Comment { get; set; }

        public virtual PaymentTypes PaymentTypes { get; set; }
    }
    [Table(name: "PaymentTypes")]
    public partial class PaymentTypes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PaymentTypes()
        {
            this.Payment = new HashSet<Payment>();
        }

        public string PaymentTypeID { get; set; }
        public string TypeDescription { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Payment> Payment { get; set; }
    }
    [Table(name: "Producedin")]
    public partial class Producedin
    {
        public int ProductID { get; set; }
        public string WorkCenterID { get; set; }

        public virtual Product Product { get; set; }
        public virtual WorkCenter WorkCenter { get; set; }
    }
    [Table(name: "Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.Producedin = new HashSet<Producedin>();
            this.OrderLine = new HashSet<OrderLine>();
            this.ProductLine = new HashSet<ProductLine>();
            this.Uses = new HashSet<Uses>();
        }

        public int ProductID { get; set; }
        public string ProductDescription { get; set; }
        public string ProductFinish { get; set; }
        public Nullable<decimal> ProductStandardPrice { get; set; }
        public Nullable<short> ProductOnHand { get; set; }
        public Nullable<int> ProductLineID { get; set; }
        public byte[] Photo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Producedin> Producedin { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderLine> OrderLine { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductLine> ProductLine { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Uses> Uses { get; set; }
    }
    [Table(name: "ProductLine")]
    public partial class ProductLine
    {
        public int ProductLineID { get; set; }
        public string ProductLineName { get; set; }

        public virtual Product Product { get; set; }
    }
    [Table(name: "RawMaterial")]
    public partial class RawMaterial
    {
        public string MaterialID { get; set; }
        public string MaterialName { get; set; }
        public string Thickness { get; set; }
        public string Width { get; set; }
        public string Size { get; set; }
        public string Material { get; set; }
        public Nullable<double> MaterialStandardPrice { get; set; }
        public string UnitOfMeasure { get; set; }
        public string MaterialType { get; set; }

        public virtual Material Material1 { get; set; }
    }
    [Table(name: "Reports")]
    public partial class Reports
    {
        public int Report_ID { get; set; }
        public string Report_name { get; set; }
        public string Report_macro { get; set; }
        public string Report_description { get; set; }
        public bool ByBeginDate { get; set; }
        public bool ByEndDate { get; set; }
        public bool ByCustomer { get; set; }
        public bool BySalesperson { get; set; }
        public bool ByTerritory { get; set; }
        public bool ByEmployee { get; set; }
        public bool ByProduct { get; set; }
        public bool ByProductLine { get; set; }
    }
    [Table(name: "Salesperson")]
    public partial class Salesperson
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Salesperson()
        {
            this.Order = new HashSet<Order>();
        }

        public int SalespersonID { get; set; }
        public string SalespersonName { get; set; }
        public string SalespersonTelephone { get; set; }
        public string SalespersonFax { get; set; }
        public int SalesTerritoryID { get; set; }
        public string SalespersonAddress { get; set; }
        public string SalespersonCity { get; set; }
        public string SalespersonState { get; set; }
        public string SalespersonZip { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Order { get; set; }
        public virtual Territory Territory { get; set; }
    }
    [Table(name: "Shipped")]
    public partial class Shipped
    {
        public int OrderLineID { get; set; }
        public Nullable<short> ShippedQuantity { get; set; }
        public Nullable<System.DateTime> ShippedDate { get; set; }

        public virtual OrderLine OrderLine { get; set; }
    }
    [Table(name: "Skill")]
    public partial class Skill
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Skill()
        {
            this.EmployeeSkills = new HashSet<EmployeeSkills>();
        }

        public string SkillID { get; set; }
        public string SkillDescription { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeSkills> EmployeeSkills { get; set; }
    }
    [Table(name: "Supplies")]
    public partial class Supplies
    {
        public int VendorID { get; set; }
        public string MaterialID { get; set; }
        public Nullable<decimal> SupplyUnitPrice { get; set; }

        public virtual Vendor Vendor { get; set; }
        public virtual Material Material { get; set; }
    }
    [Table(name: "Territory")]
    public partial class Territory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Territory()
        {
            this.DoesBusinessIn = new HashSet<DoesBusinessIn>();
            this.CustomerShipAddress = new HashSet<CustomerShipAddress>();
            this.Salesperson = new HashSet<Salesperson>();
        }

        public int TerritoryID { get; set; }
        public string TerritoryName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DoesBusinessIn> DoesBusinessIn { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerShipAddress> CustomerShipAddress { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Salesperson> Salesperson { get; set; }
    }
    [Table(name: "Uses")]
    public partial class Uses
    {
        public int ProductID { get; set; }
        public string MaterialID { get; set; }
        public Nullable<short> QuantityRequired { get; set; }

        public virtual Product Product { get; set; }
        public virtual Material Material { get; set; }
    }
    [Table(name: "Vendor")]
    public partial class Vendor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vendor()
        {
            this.Supplies = new HashSet<Supplies>();
        }

        public int VendorID { get; set; }
        public string VendorName { get; set; }
        public string VendorAddress { get; set; }
        public string VendorCity { get; set; }
        public string VendorState { get; set; }
        public string VendorZipcode { get; set; }
        public string VendorPhone { get; set; }
        public string VendorFaxNumber { get; set; }
        public string VendorContact { get; set; }
        public string VendorTaxIDNumber { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Supplies> Supplies { get; set; }
    }
    [Table(name: "WorkCenter")]
    public partial class WorkCenter
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WorkCenter()
        {
            this.Producedin = new HashSet<Producedin>();
            this.WorksIn = new HashSet<WorksIn>();
        }

        public string WorkCenterID { get; set; }
        public string WorkCenterLocation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Producedin> Producedin { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorksIn> WorksIn { get; set; }
    }
    [Table(name: "WorksIn")]
    public partial class WorksIn
    {
        public string EmployeeID { get; set; }
        public string WorkCenterID { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual WorkCenter WorkCenter { get; set; }
    }
}