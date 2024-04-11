﻿// <auto-generated />
using System;
using DoAnWeb.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DoAnWeb.Migrations
{
    [DbContext(typeof(CsdlwebContext))]
    [Migration("20240410071449_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DoAnWeb.Model.Banner", b =>
                {
                    b.Property<int>("IdBanner")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdBanner"));

                    b.Property<double>("Horizontal")
                        .HasColumnType("float");

                    b.Property<int>("Idimages")
                        .HasColumnType("int")
                        .HasColumnName("IDImages");

                    b.Property<double>("Vertical")
                        .HasColumnType("float");

                    b.HasKey("IdBanner");

                    b.HasIndex("Idimages");

                    b.ToTable("Banner", (string)null);
                });

            modelBuilder.Entity("DoAnWeb.Model.Customer", b =>
                {
                    b.Property<int>("Idcustomer")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDCustomer");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Idcustomer"));

                    b.Property<string>("CitizenIdentificationCode")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nchar(12)")
                        .IsFixedLength();

                    b.Property<string>("CustomerAddress")
                        .IsRequired()
                        .HasColumnType("ntext");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<DateOnly>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<int?>("IdImages")
                        .HasColumnType("int");

                    b.Property<string>("PhoneCustomer")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .IsFixedLength();

                    b.Property<int>("Sex")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nchar(20)")
                        .IsFixedLength();

                    b.HasKey("Idcustomer");

                    b.HasIndex("IdImages");

                    b.HasIndex("Username");

                    b.ToTable("Customer", (string)null);
                });

            modelBuilder.Entity("DoAnWeb.Model.DeliveryNote", b =>
                {
                    b.Property<int>("IdDeliveryNotes")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdDeliveryNotes"));

                    b.Property<DateOnly>("DateCreated")
                        .HasColumnType("date");

                    b.Property<string>("DeliveryAddress")
                        .IsRequired()
                        .HasColumnType("ntext");

                    b.Property<int>("Idinvoice")
                        .HasColumnType("int")
                        .HasColumnName("IDInvoice");

                    b.Property<int>("Idstaff")
                        .HasColumnType("int")
                        .HasColumnName("IDStaff");

                    b.Property<string>("RecipientPhone")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .IsFixedLength();

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("IdDeliveryNotes");

                    b.HasIndex("Idinvoice");

                    b.HasIndex("Idstaff");

                    b.ToTable("DeliveryNotes");
                });

            modelBuilder.Entity("DoAnWeb.Model.Footer", b =>
                {
                    b.Property<int>("Idfooter")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDfooter");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Idfooter"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("ntext");

                    b.HasKey("Idfooter");

                    b.ToTable("Footer", (string)null);
                });

            modelBuilder.Entity("DoAnWeb.Model.Image", b =>
                {
                    b.Property<int>("Idimages")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDImages");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Idimages"));

                    b.Property<string>("NameImages")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UrlImages")
                        .HasMaxLength(120)
                        .HasColumnType("nchar(120)")
                        .IsFixedLength();

                    b.HasKey("Idimages")
                        .HasName("PK_Produc1Images");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("DoAnWeb.Model.ImportedProduct", b =>
                {
                    b.Property<int>("IdimportedProducts")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDImportedProducts");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdimportedProducts"));

                    b.Property<DateOnly>("DateCreated")
                        .HasColumnType("date");

                    b.Property<int>("Idstaff")
                        .HasColumnType("int")
                        .HasColumnName("IDStaff");

                    b.Property<int>("Idwarehouse")
                        .HasColumnType("int")
                        .HasColumnName("IDWarehouse");

                    b.HasKey("IdimportedProducts")
                        .HasName("PK_Imported Products Detail");

                    b.HasIndex("Idstaff");

                    b.HasIndex("Idwarehouse");

                    b.ToTable("Imported Products", (string)null);
                });

            modelBuilder.Entity("DoAnWeb.Model.ImportedProductsDetail", b =>
                {
                    b.Property<int>("IdimportedProducts")
                        .HasColumnType("int")
                        .HasColumnName("IDImportedProducts");

                    b.Property<int>("Idproduct")
                        .HasColumnType("int")
                        .HasColumnName("IDProduct");

                    b.Property<double>("InputPrice")
                        .HasColumnType("float");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("IdimportedProducts", "Idproduct");

                    b.HasIndex("Idproduct");

                    b.ToTable("ImportedProductsDetail", (string)null);
                });

            modelBuilder.Entity("DoAnWeb.Model.Invoice", b =>
                {
                    b.Property<int>("Idinvoice")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDInvoice");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Idinvoice"));

                    b.Property<DateOnly>("DateCreated")
                        .HasColumnType("date");

                    b.Property<int>("Idcustomer")
                        .HasColumnType("int")
                        .HasColumnName("IDCustomer");

                    b.Property<int>("Idstaff")
                        .HasColumnType("int")
                        .HasColumnName("IDStaff");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Idinvoice")
                        .HasName("PK_Bill");

                    b.HasIndex("Idcustomer");

                    b.HasIndex("Idstaff");

                    b.ToTable("Invoice", (string)null);
                });

            modelBuilder.Entity("DoAnWeb.Model.Invoicedetail", b =>
                {
                    b.Property<int>("Idinvoice")
                        .HasColumnType("int")
                        .HasColumnName("IDInvoice");

                    b.Property<int>("Idproduct")
                        .HasColumnType("int")
                        .HasColumnName("IDProduct");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 0)");

                    b.Property<int>("TotalQuantity")
                        .HasColumnType("int");

                    b.HasKey("Idinvoice", "Idproduct");

                    b.HasIndex("Idproduct");

                    b.ToTable("Invoicedetails");
                });

            modelBuilder.Entity("DoAnWeb.Model.Product", b =>
                {
                    b.Property<int>("Idproduct")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDProduct");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Idproduct"));

                    b.Property<int>("IdproductType")
                        .HasColumnType("int")
                        .HasColumnName("IDProductType");

                    b.Property<int>("Idsupplier")
                        .HasColumnType("int")
                        .HasColumnName("IDSupplier");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 0)");

                    b.Property<string>("ProductDescription")
                        .HasColumnType("ntext");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("ProductTypeIdproductType")
                        .HasColumnType("int");

                    b.Property<double?>("Sale")
                        .HasColumnType("float");

                    b.Property<int?>("SupplierIdsupplier")
                        .HasColumnType("int");

                    b.HasKey("Idproduct");

                    b.HasIndex("IdproductType");

                    b.HasIndex("Idsupplier");

                    b.HasIndex("ProductTypeIdproductType");

                    b.HasIndex("SupplierIdsupplier");

                    b.ToTable("Product", (string)null);
                });

            modelBuilder.Entity("DoAnWeb.Model.ProductType", b =>
                {
                    b.Property<int>("IdproductType")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDProductType");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdproductType"));

                    b.Property<string>("ProductTypeName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdproductType");

                    b.ToTable("ProductType", (string)null);
                });

            modelBuilder.Entity("DoAnWeb.Model.ShoppingCart", b =>
                {
                    b.Property<int>("IdshoppingCart")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDshoppingCart");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdshoppingCart"));

                    b.Property<int>("Idcustomer")
                        .HasColumnType("int")
                        .HasColumnName("IDCustomer");

                    b.HasKey("IdshoppingCart");

                    b.HasIndex("Idcustomer");

                    b.ToTable("Shopping cart", (string)null);
                });

            modelBuilder.Entity("DoAnWeb.Model.ShoppingCartDeltail", b =>
                {
                    b.Property<int>("IdshoppingCart")
                        .HasColumnType("int")
                        .HasColumnName("IDshoppingCart");

                    b.Property<int>("Idproduct")
                        .HasColumnType("int")
                        .HasColumnName("IDProduct");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("IdshoppingCart", "Idproduct")
                        .HasName("PK_IDshoppingCartDeltails");

                    b.HasIndex("Idproduct");

                    b.ToTable("shoppingCartDeltails", (string)null);
                });

            modelBuilder.Entity("DoAnWeb.Model.Skill", b =>
                {
                    b.Property<int>("IdSkill")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdSkill"));

                    b.Property<string>("NameSkill")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdSkill");

                    b.ToTable("Skill", (string)null);
                });

            modelBuilder.Entity("DoAnWeb.Model.SkillDetail", b =>
                {
                    b.Property<int>("IdSkill")
                        .HasColumnType("int");

                    b.Property<int>("Idstaff")
                        .HasColumnType("int")
                        .HasColumnName("IDStaff");

                    b.Property<DateTime>("UpdateDay")
                        .HasColumnType("datetime")
                        .HasColumnName("updateDay");

                    b.HasKey("IdSkill", "Idstaff");

                    b.HasIndex("Idstaff");

                    b.ToTable("SkillDetails");
                });

            modelBuilder.Entity("DoAnWeb.Model.Staff", b =>
                {
                    b.Property<int>("Idstaff")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDStaff");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Idstaff"));

                    b.Property<string>("CitizenIdentificationCode")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nchar(12)")
                        .IsFixedLength();

                    b.Property<DateOnly>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<int?>("IdImages")
                        .HasColumnType("int");

                    b.Property<int>("IdstaffType")
                        .HasColumnType("int")
                        .HasColumnName("IDStaffType");

                    b.Property<string>("PhoneStaff")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .IsFixedLength();

                    b.Property<int>("Sex")
                        .HasColumnType("int");

                    b.Property<string>("StaffAddress")
                        .IsRequired()
                        .HasColumnType("ntext");

                    b.Property<string>("StaffName")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nchar(20)")
                        .IsFixedLength();

                    b.HasKey("Idstaff");

                    b.HasIndex("IdImages");

                    b.HasIndex("IdstaffType");

                    b.HasIndex("Username");

                    b.ToTable("Staff");
                });

            modelBuilder.Entity("DoAnWeb.Model.StaffType", b =>
                {
                    b.Property<int>("IdstaffType")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDStaffType");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdstaffType"));

                    b.Property<string>("StaffTypeName")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.HasKey("IdstaffType");

                    b.ToTable("StaffType", (string)null);
                });

            modelBuilder.Entity("DoAnWeb.Model.Supplier", b =>
                {
                    b.Property<int>("Idsupplier")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDSupplier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Idsupplier"));

                    b.Property<string>("EmailSupplier")
                        .HasMaxLength(50)
                        .HasColumnType("nchar(50)")
                        .IsFixedLength();

                    b.Property<string>("PhoneSupplier")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nchar(12)")
                        .IsFixedLength();

                    b.Property<string>("SupplierAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SupplierName")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.HasKey("Idsupplier");

                    b.ToTable("Supplier", (string)null);
                });

            modelBuilder.Entity("DoAnWeb.Model.User", b =>
                {
                    b.Property<string>("Username")
                        .HasMaxLength(20)
                        .HasColumnType("nchar(20)")
                        .IsFixedLength();

                    b.Property<int>("Check")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nchar(50)")
                        .IsFixedLength();

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(18)
                        .HasColumnType("nchar(18)")
                        .IsFixedLength();

                    b.HasKey("Username")
                        .HasName("PK_User_1");

                    b.ToTable("User", (string)null);
                });

            modelBuilder.Entity("DoAnWeb.Model.Warehouse", b =>
                {
                    b.Property<int>("Idwarehouse")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDWarehouse");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Idwarehouse"));

                    b.Property<DateOnly>("DateCreated")
                        .HasColumnType("date");

                    b.Property<string>("WarehouseAddress")
                        .IsRequired()
                        .HasColumnType("ntext");

                    b.Property<string>("WarehouseName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Idwarehouse");

                    b.ToTable("Warehouse", (string)null);
                });

            modelBuilder.Entity("DoAnWeb.Model.Warehousedetail", b =>
                {
                    b.Property<int>("Idwarehouse")
                        .HasColumnType("int")
                        .HasColumnName("IDWarehouse");

                    b.Property<int>("Idproduct")
                        .HasColumnType("int")
                        .HasColumnName("IDProduct");

                    b.Property<int>("QuantityInStock")
                        .HasColumnType("int");

                    b.HasKey("Idwarehouse", "Idproduct");

                    b.HasIndex("Idproduct");

                    b.ToTable("Warehousedetails");
                });

            modelBuilder.Entity("ProductImagesDetail", b =>
                {
                    b.Property<int>("Idimages")
                        .HasColumnType("int")
                        .HasColumnName("IDImages");

                    b.Property<int>("Idproduct")
                        .HasColumnType("int")
                        .HasColumnName("IDProduct");

                    b.HasKey("Idimages", "Idproduct");

                    b.HasIndex("Idproduct");

                    b.ToTable("ProductImagesDetails", (string)null);
                });

            modelBuilder.Entity("DoAnWeb.Model.Banner", b =>
                {
                    b.HasOne("DoAnWeb.Model.Image", "IdimagesNavigation")
                        .WithMany("Banners")
                        .HasForeignKey("Idimages")
                        .IsRequired()
                        .HasConstraintName("FK_Banner_Images");

                    b.Navigation("IdimagesNavigation");
                });

            modelBuilder.Entity("DoAnWeb.Model.Customer", b =>
                {
                    b.HasOne("DoAnWeb.Model.Image", "IdImagesNavigation")
                        .WithMany("Customers")
                        .HasForeignKey("IdImages")
                        .HasConstraintName("FK_Customer_Images");

                    b.HasOne("DoAnWeb.Model.User", "UsernameNavigation")
                        .WithMany("Customers")
                        .HasForeignKey("Username")
                        .IsRequired()
                        .HasConstraintName("FK_Customer_User");

                    b.Navigation("IdImagesNavigation");

                    b.Navigation("UsernameNavigation");
                });

            modelBuilder.Entity("DoAnWeb.Model.DeliveryNote", b =>
                {
                    b.HasOne("DoAnWeb.Model.Invoice", "IdinvoiceNavigation")
                        .WithMany("DeliveryNotes")
                        .HasForeignKey("Idinvoice")
                        .IsRequired()
                        .HasConstraintName("FK_DeliveryNotes_Invoice");

                    b.HasOne("DoAnWeb.Model.Staff", "IdstaffNavigation")
                        .WithMany("DeliveryNotes")
                        .HasForeignKey("Idstaff")
                        .IsRequired()
                        .HasConstraintName("FK_DeliveryNotes_Staff");

                    b.Navigation("IdinvoiceNavigation");

                    b.Navigation("IdstaffNavigation");
                });

            modelBuilder.Entity("DoAnWeb.Model.ImportedProduct", b =>
                {
                    b.HasOne("DoAnWeb.Model.Staff", "IdstaffNavigation")
                        .WithMany("ImportedProducts")
                        .HasForeignKey("Idstaff")
                        .IsRequired()
                        .HasConstraintName("FK_Imported Products Detail_Staff");

                    b.HasOne("DoAnWeb.Model.Warehouse", "IdwarehouseNavigation")
                        .WithMany("ImportedProducts")
                        .HasForeignKey("Idwarehouse")
                        .IsRequired()
                        .HasConstraintName("FK_Imported Products Detail_Warehouse");

                    b.Navigation("IdstaffNavigation");

                    b.Navigation("IdwarehouseNavigation");
                });

            modelBuilder.Entity("DoAnWeb.Model.ImportedProductsDetail", b =>
                {
                    b.HasOne("DoAnWeb.Model.ImportedProduct", "IdimportedProductsNavigation")
                        .WithMany("ImportedProductsDetails")
                        .HasForeignKey("IdimportedProducts")
                        .IsRequired()
                        .HasConstraintName("FK_ImportedProductsDetail_Imported Products");

                    b.HasOne("DoAnWeb.Model.Product", "IdproductNavigation")
                        .WithMany("ImportedProductsDetails")
                        .HasForeignKey("Idproduct")
                        .IsRequired()
                        .HasConstraintName("FK_ImportedProductsDetail_Product");

                    b.Navigation("IdimportedProductsNavigation");

                    b.Navigation("IdproductNavigation");
                });

            modelBuilder.Entity("DoAnWeb.Model.Invoice", b =>
                {
                    b.HasOne("DoAnWeb.Model.Customer", "IdcustomerNavigation")
                        .WithMany("Invoices")
                        .HasForeignKey("Idcustomer")
                        .IsRequired()
                        .HasConstraintName("FK_Invoice_Customer");

                    b.HasOne("DoAnWeb.Model.Staff", "IdstaffNavigation")
                        .WithMany("Invoices")
                        .HasForeignKey("Idstaff")
                        .IsRequired()
                        .HasConstraintName("FK_Invoice_Staff");

                    b.Navigation("IdcustomerNavigation");

                    b.Navigation("IdstaffNavigation");
                });

            modelBuilder.Entity("DoAnWeb.Model.Invoicedetail", b =>
                {
                    b.HasOne("DoAnWeb.Model.Invoice", "IdinvoiceNavigation")
                        .WithMany("Invoicedetails")
                        .HasForeignKey("Idinvoice")
                        .IsRequired()
                        .HasConstraintName("FK_Invoicedetails_Invoice");

                    b.HasOne("DoAnWeb.Model.Product", "IdproductNavigation")
                        .WithMany("Invoicedetails")
                        .HasForeignKey("Idproduct")
                        .IsRequired()
                        .HasConstraintName("FK_Invoicedetails_Product");

                    b.Navigation("IdinvoiceNavigation");

                    b.Navigation("IdproductNavigation");
                });

            modelBuilder.Entity("DoAnWeb.Model.Product", b =>
                {
                    b.HasOne("DoAnWeb.Model.ProductType", "IdproductTypeNavigation")
                        .WithMany("Products")
                        .HasForeignKey("IdproductType")
                        .IsRequired()
                        .HasConstraintName("FK_Product_ProductType");

                    b.HasOne("DoAnWeb.Model.Supplier", "IdsupplierNavigation")
                        .WithMany("Products")
                        .HasForeignKey("Idsupplier")
                        .IsRequired()
                        .HasConstraintName("FK_Product_Supplier");

                    b.HasOne("DoAnWeb.Model.ProductType", "ProductType")
                        .WithMany()
                        .HasForeignKey("ProductTypeIdproductType");

                    b.HasOne("DoAnWeb.Model.Supplier", "Supplier")
                        .WithMany()
                        .HasForeignKey("SupplierIdsupplier");

                    b.Navigation("IdproductTypeNavigation");

                    b.Navigation("IdsupplierNavigation");

                    b.Navigation("ProductType");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("DoAnWeb.Model.ShoppingCart", b =>
                {
                    b.HasOne("DoAnWeb.Model.Customer", "IdcustomerNavigation")
                        .WithMany("ShoppingCarts")
                        .HasForeignKey("Idcustomer")
                        .IsRequired()
                        .HasConstraintName("FK_Shopping cart_Customer");

                    b.Navigation("IdcustomerNavigation");
                });

            modelBuilder.Entity("DoAnWeb.Model.ShoppingCartDeltail", b =>
                {
                    b.HasOne("DoAnWeb.Model.Product", "IdproductNavigation")
                        .WithMany("ShoppingCartDeltails")
                        .HasForeignKey("Idproduct")
                        .IsRequired()
                        .HasConstraintName("FK_shoppingCartDeltails_Product");

                    b.HasOne("DoAnWeb.Model.ShoppingCart", "IdshoppingCartNavigation")
                        .WithMany("ShoppingCartDeltails")
                        .HasForeignKey("IdshoppingCart")
                        .IsRequired()
                        .HasConstraintName("FK_shoppingCartDeltails_Shopping cart");

                    b.Navigation("IdproductNavigation");

                    b.Navigation("IdshoppingCartNavigation");
                });

            modelBuilder.Entity("DoAnWeb.Model.SkillDetail", b =>
                {
                    b.HasOne("DoAnWeb.Model.Skill", "IdSkillNavigation")
                        .WithMany("SkillDetails")
                        .HasForeignKey("IdSkill")
                        .IsRequired()
                        .HasConstraintName("FK_SkillDetails_Skill");

                    b.HasOne("DoAnWeb.Model.Staff", "IdstaffNavigation")
                        .WithMany("SkillDetails")
                        .HasForeignKey("Idstaff")
                        .IsRequired()
                        .HasConstraintName("FK_SkillDetails_Staff");

                    b.Navigation("IdSkillNavigation");

                    b.Navigation("IdstaffNavigation");
                });

            modelBuilder.Entity("DoAnWeb.Model.Staff", b =>
                {
                    b.HasOne("DoAnWeb.Model.Image", "IdImagesNavigation")
                        .WithMany("Staff")
                        .HasForeignKey("IdImages")
                        .HasConstraintName("FK_Staff_Images");

                    b.HasOne("DoAnWeb.Model.StaffType", "IdstaffTypeNavigation")
                        .WithMany("Staff")
                        .HasForeignKey("IdstaffType")
                        .IsRequired()
                        .HasConstraintName("FK_Staff_StaffType");

                    b.HasOne("DoAnWeb.Model.User", "UsernameNavigation")
                        .WithMany("Staff")
                        .HasForeignKey("Username")
                        .IsRequired()
                        .HasConstraintName("FK_Staff_User");

                    b.Navigation("IdImagesNavigation");

                    b.Navigation("IdstaffTypeNavigation");

                    b.Navigation("UsernameNavigation");
                });

            modelBuilder.Entity("DoAnWeb.Model.Warehousedetail", b =>
                {
                    b.HasOne("DoAnWeb.Model.Product", "IdproductNavigation")
                        .WithMany("Warehousedetails")
                        .HasForeignKey("Idproduct")
                        .IsRequired()
                        .HasConstraintName("FK_Warehousedetails_Product");

                    b.HasOne("DoAnWeb.Model.Warehouse", "IdwarehouseNavigation")
                        .WithMany("Warehousedetails")
                        .HasForeignKey("Idwarehouse")
                        .IsRequired()
                        .HasConstraintName("FK_Warehousedetails_Warehouse");

                    b.Navigation("IdproductNavigation");

                    b.Navigation("IdwarehouseNavigation");
                });

            modelBuilder.Entity("ProductImagesDetail", b =>
                {
                    b.HasOne("DoAnWeb.Model.Image", null)
                        .WithMany()
                        .HasForeignKey("Idimages")
                        .IsRequired()
                        .HasConstraintName("FK_ProductImagesDetails_Images");

                    b.HasOne("DoAnWeb.Model.Product", null)
                        .WithMany()
                        .HasForeignKey("Idproduct")
                        .IsRequired()
                        .HasConstraintName("FK_ProductImagesDetails_Product");
                });

            modelBuilder.Entity("DoAnWeb.Model.Customer", b =>
                {
                    b.Navigation("Invoices");

                    b.Navigation("ShoppingCarts");
                });

            modelBuilder.Entity("DoAnWeb.Model.Image", b =>
                {
                    b.Navigation("Banners");

                    b.Navigation("Customers");

                    b.Navigation("Staff");
                });

            modelBuilder.Entity("DoAnWeb.Model.ImportedProduct", b =>
                {
                    b.Navigation("ImportedProductsDetails");
                });

            modelBuilder.Entity("DoAnWeb.Model.Invoice", b =>
                {
                    b.Navigation("DeliveryNotes");

                    b.Navigation("Invoicedetails");
                });

            modelBuilder.Entity("DoAnWeb.Model.Product", b =>
                {
                    b.Navigation("ImportedProductsDetails");

                    b.Navigation("Invoicedetails");

                    b.Navigation("ShoppingCartDeltails");

                    b.Navigation("Warehousedetails");
                });

            modelBuilder.Entity("DoAnWeb.Model.ProductType", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("DoAnWeb.Model.ShoppingCart", b =>
                {
                    b.Navigation("ShoppingCartDeltails");
                });

            modelBuilder.Entity("DoAnWeb.Model.Skill", b =>
                {
                    b.Navigation("SkillDetails");
                });

            modelBuilder.Entity("DoAnWeb.Model.Staff", b =>
                {
                    b.Navigation("DeliveryNotes");

                    b.Navigation("ImportedProducts");

                    b.Navigation("Invoices");

                    b.Navigation("SkillDetails");
                });

            modelBuilder.Entity("DoAnWeb.Model.StaffType", b =>
                {
                    b.Navigation("Staff");
                });

            modelBuilder.Entity("DoAnWeb.Model.Supplier", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("DoAnWeb.Model.User", b =>
                {
                    b.Navigation("Customers");

                    b.Navigation("Staff");
                });

            modelBuilder.Entity("DoAnWeb.Model.Warehouse", b =>
                {
                    b.Navigation("ImportedProducts");

                    b.Navigation("Warehousedetails");
                });
#pragma warning restore 612, 618
        }
    }
}