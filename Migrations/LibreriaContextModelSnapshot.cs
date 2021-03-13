﻿// <auto-generated />
using System;
using LibreriaAdmin.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LibreriaAdmin.Migrations
{
    [DbContext(typeof(LibreriaContext))]
    partial class LibreriaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LibreriaAdmin.Models.AspNetRole", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("LibreriaAdmin.Models.AspNetUser", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LockoutEndDateUtc")
                        .HasColumnType("datetime");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("LibreriaAdmin.Models.AspNetUserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.HasKey("Id");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("LibreriaAdmin.Models.AspNetUserLogin", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("UserId")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.HasKey("LoginProvider", "ProviderKey", "UserId")
                        .HasName("PK_dbo.AspNetUserLogins");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("LibreriaAdmin.Models.AspNetUserRole", b =>
                {
                    b.Property<string>("UserId")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("RoleId")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.HasKey("UserId", "RoleId")
                        .HasName("PK_dbo.AspNetUserRoles");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("LibreriaAdmin.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime")
                        .HasComment("建立日期");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Sort")
                        .HasColumnType("int")
                        .HasComment("排序");

                    b.Property<DateTime?>("Updatetime")
                        .HasColumnType("datetime")
                        .HasComment("更新日期");

                    b.HasKey("CategoryId");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("LibreriaAdmin.Models.Exhibition", b =>
                {
                    b.Property<int>("ExhibitionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ExhibitionID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EditModifyDate")
                        .HasColumnType("datetime");

                    b.Property<int>("ExCustomerId")
                        .HasColumnType("int");

                    b.Property<string>("ExName")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasDefaultValueSql("('')");

                    b.Property<string>("ExPhoto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ExhibitionEndTime")
                        .HasColumnType("datetime");

                    b.Property<string>("ExhibitionIntro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ExhibitionPrice")
                        .HasColumnType("money");

                    b.Property<DateTime>("ExhibitionStartTime")
                        .HasColumnType("datetime");

                    b.Property<string>("MasterUnit")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("ReviewState")
                        .HasColumnType("bit");

                    b.HasKey("ExhibitionId");

                    b.ToTable("Exhibition");
                });

            modelBuilder.Entity("LibreriaAdmin.Models.ExhibitionCustomer", b =>
                {
                    b.Property<int>("ExCustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ExCustomerEmail")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ExCustomerName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ExCustomerPhone")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ExCustomerId");

                    b.ToTable("ExhibitionCustomer");
                });

            modelBuilder.Entity("LibreriaAdmin.Models.ExhibitionOrder", b =>
                {
                    b.Property<int>("ExOrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime");

                    b.Property<int>("ExCustomerId")
                        .HasColumnType("int");

                    b.Property<string>("PaymentState")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime");

                    b.HasKey("ExOrderId");

                    b.HasIndex("ExCustomerId");

                    b.ToTable("ExhibitionOrder");
                });

            modelBuilder.Entity("LibreriaAdmin.Models.Favorite", b =>
                {
                    b.Property<int>("FavoriteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MemberId")
                        .HasColumnType("int")
                        .HasColumnName("memberId");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("FavoriteId");

                    b.HasIndex("MemberId");

                    b.HasIndex("ProductId");

                    b.ToTable("Favorite");
                });

            modelBuilder.Entity("LibreriaAdmin.Models.Invoice", b =>
                {
                    b.Property<int>("InvoiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TypeInfo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("InvoiceId");

                    b.ToTable("Invoice");
                });

            modelBuilder.Entity("LibreriaAdmin.Models.Manager", b =>
                {
                    b.Property<string>("ManagerId")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("JobTitle")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ManagerName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ManagerPassword")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ManagerPhoto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ManagerUsername")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ManagerId");

                    b.ToTable("Manager");
                });

            modelBuilder.Entity("LibreriaAdmin.Models.Member", b =>
                {
                    b.Property<int>("MemberId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("memberId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("date")
                        .HasColumnName("birthday");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("HomeNumber")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Idnumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("IDnumber");

                    b.Property<string>("MemberName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("memberName");

                    b.Property<string>("MemberPassword")
                        .IsRequired()
                        .HasMaxLength(1024)
                        .HasColumnType("nvarchar(1024)")
                        .HasColumnName("memberPassword")
                        .HasComment("會員密碼");

                    b.Property<string>("MemberUserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("memberUserName")
                        .HasComment("會員帳號");

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Region")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("MemberId");

                    b.HasIndex("RoleId");

                    b.ToTable("member");
                });

            modelBuilder.Entity("LibreriaAdmin.Models.MigrationHistory", b =>
                {
                    b.Property<string>("MigrationId")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("ContextKey")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<byte[]>("Model")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("ProductVersion")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.HasKey("MigrationId", "ContextKey")
                        .HasName("PK_dbo.__MigrationHistory");

                    b.ToTable("__MigrationHistory");
                });

            modelBuilder.Entity("LibreriaAdmin.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime")
                        .HasComment("建立日期");

                    b.Property<string>("InvoiceInfo")
                        .HasMaxLength(50)
                        .HasColumnType("nchar(50)")
                        .IsFixedLength(true)
                        .HasComment("發票號碼");

                    b.Property<int>("InvoiceType")
                        .HasColumnType("int")
                        .HasComment("發票種類 1為手機條碼載具 2為自然人憑載具 3為紙本證明連 4為捐贈發票");

                    b.Property<int>("MemberId")
                        .HasColumnType("int")
                        .HasColumnName("memberId");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime")
                        .HasComment("訂購日期");

                    b.Property<string>("PaymentState")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PaymentType")
                        .HasColumnType("int")
                        .HasComment("付款方式 1為取貨付款 2為ATM 3為信用卡");

                    b.Property<string>("ShipAddress")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("發貨地址");

                    b.Property<string>("ShipCity")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("發貨城市");

                    b.Property<string>("ShipName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ShipPostalCode")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("郵政編碼");

                    b.Property<string>("ShipRegion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("發貨地區");

                    b.Property<DateTime>("ShippingDate")
                        .HasColumnType("datetime")
                        .HasComment("發貨日期");

                    b.Property<DateTime?>("UpdateTime")
                        .HasColumnType("datetime")
                        .HasComment("更新日期");

                    b.HasKey("OrderId");

                    b.HasIndex("MemberId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("LibreriaAdmin.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int")
                        .HasComment("數量");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetail");
                });

            modelBuilder.Entity("LibreriaAdmin.Models.Preview", b =>
                {
                    b.Property<int>("PreviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImgUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("圖片");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Sort")
                        .HasColumnType("int")
                        .HasComment("0為主圖,之後為預覽圖");

                    b.HasKey("PreviewId");

                    b.HasIndex("ProductId");

                    b.ToTable("Preview");
                });

            modelBuilder.Entity("LibreriaAdmin.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("作者");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime")
                        .HasComment("建立日期");

                    b.Property<string>("Introduction")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Inventory")
                        .HasColumnType("int")
                        .HasComment("庫存");

                    b.Property<bool>("IsFav")
                        .HasColumnType("bit")
                        .HasColumnName("isFav");

                    b.Property<bool>("IsSpecial")
                        .HasColumnType("bit")
                        .HasColumnName("isSpecial");

                    b.Property<string>("Isbn")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("ISBN");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("PublishDate")
                        .HasColumnType("date")
                        .HasComment("出版日期");

                    b.Property<int>("Sort")
                        .HasColumnType("int")
                        .HasComment("排序");

                    b.Property<int>("SupplierId")
                        .HasColumnType("int");

                    b.Property<int?>("TotalSales")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("money");

                    b.Property<DateTime?>("UpdateTime")
                        .HasColumnType("datetime")
                        .HasComment("更新日期");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("SupplierId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("LibreriaAdmin.Models.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("RoleID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("RoleId");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("LibreriaAdmin.Models.ShoppingCart", b =>
                {
                    b.Property<int>("ShoppingCartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<int>("MemberId")
                        .HasColumnType("int")
                        .HasColumnName("memberId");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("ShoppingCartId");

                    b.HasIndex("MemberId");

                    b.HasIndex("ProductId");

                    b.ToTable("ShoppingCart");
                });

            modelBuilder.Entity("LibreriaAdmin.Models.Supplier", b =>
                {
                    b.Property<int>("SupplierId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("Sort")
                        .HasColumnType("int")
                        .HasComment("排序");

                    b.HasKey("SupplierId");

                    b.ToTable("Supplier");
                });

            modelBuilder.Entity("LibreriaAdmin.Models.ExhibitionOrder", b =>
                {
                    b.HasOne("LibreriaAdmin.Models.ExhibitionCustomer", "ExCustomer")
                        .WithMany("ExhibitionOrders")
                        .HasForeignKey("ExCustomerId")
                        .HasConstraintName("FK_ExhibitionOrder_ExhibitionCustomer")
                        .IsRequired();

                    b.Navigation("ExCustomer");
                });

            modelBuilder.Entity("LibreriaAdmin.Models.Favorite", b =>
                {
                    b.HasOne("LibreriaAdmin.Models.Member", "Member")
                        .WithMany("Favorites")
                        .HasForeignKey("MemberId")
                        .HasConstraintName("FK_Favorite_member")
                        .IsRequired();

                    b.HasOne("LibreriaAdmin.Models.Product", "Product")
                        .WithMany("Favorites")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("FK_Favorite_Product")
                        .IsRequired();

                    b.Navigation("Member");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("LibreriaAdmin.Models.Member", b =>
                {
                    b.HasOne("LibreriaAdmin.Models.Role", "Role")
                        .WithMany("Members")
                        .HasForeignKey("RoleId")
                        .HasConstraintName("FK_member_Role");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("LibreriaAdmin.Models.Order", b =>
                {
                    b.HasOne("LibreriaAdmin.Models.Member", "Member")
                        .WithMany("Orders")
                        .HasForeignKey("MemberId")
                        .HasConstraintName("FK_Orders_Customer")
                        .IsRequired();

                    b.Navigation("Member");
                });

            modelBuilder.Entity("LibreriaAdmin.Models.OrderDetail", b =>
                {
                    b.HasOne("LibreriaAdmin.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .HasConstraintName("FK_OrderDetailId_Orders")
                        .IsRequired();

                    b.HasOne("LibreriaAdmin.Models.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("FK_OrderDetailId_Product")
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("LibreriaAdmin.Models.Preview", b =>
                {
                    b.HasOne("LibreriaAdmin.Models.Product", "Product")
                        .WithMany("Previews")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("FK_Preview_Product")
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("LibreriaAdmin.Models.Product", b =>
                {
                    b.HasOne("LibreriaAdmin.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("FK_Product_Category")
                        .IsRequired();

                    b.HasOne("LibreriaAdmin.Models.Supplier", "Supplier")
                        .WithMany("Products")
                        .HasForeignKey("SupplierId")
                        .HasConstraintName("FK_Product_Supplier")
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("LibreriaAdmin.Models.ShoppingCart", b =>
                {
                    b.HasOne("LibreriaAdmin.Models.Member", "Member")
                        .WithMany("ShoppingCarts")
                        .HasForeignKey("MemberId")
                        .HasConstraintName("FK_ShoppingCart_member")
                        .IsRequired();

                    b.HasOne("LibreriaAdmin.Models.Product", "Product")
                        .WithMany("ShoppingCarts")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("FK_ShoppingCart_Product")
                        .IsRequired();

                    b.Navigation("Member");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("LibreriaAdmin.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("LibreriaAdmin.Models.ExhibitionCustomer", b =>
                {
                    b.Navigation("ExhibitionOrders");
                });

            modelBuilder.Entity("LibreriaAdmin.Models.Member", b =>
                {
                    b.Navigation("Favorites");

                    b.Navigation("Orders");

                    b.Navigation("ShoppingCarts");
                });

            modelBuilder.Entity("LibreriaAdmin.Models.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("LibreriaAdmin.Models.Product", b =>
                {
                    b.Navigation("Favorites");

                    b.Navigation("OrderDetails");

                    b.Navigation("Previews");

                    b.Navigation("ShoppingCarts");
                });

            modelBuilder.Entity("LibreriaAdmin.Models.Role", b =>
                {
                    b.Navigation("Members");
                });

            modelBuilder.Entity("LibreriaAdmin.Models.Supplier", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}