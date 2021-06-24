using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Team27_BookshopWeb.Migrations
{
    public partial class DBInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AuthorTranslator",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 400, nullable: false),
                    Slug = table.Column<string>(nullable: false),
                    Author = table.Column<int>(nullable: false, defaultValue: 0),
                    Translator = table.Column<int>(nullable: false, defaultValue: 0),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorTranslator", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Banner",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Image = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banner", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BannerSettings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(nullable: false),
                    Image = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BannerSettings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 400, nullable: false),
                    Slug = table.Column<string>(nullable: false),
                    VerticalImage = table.Column<string>(nullable: false),
                    HorizontalImage = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Coupon",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(nullable: false),
                    Slug = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Uses = table.Column<int>(nullable: false, defaultValue: 0),
                    MaxUses = table.Column<int>(nullable: false, defaultValue: 0),
                    MaxUsesUser = table.Column<int>(nullable: false, defaultValue: 0),
                    Type = table.Column<string>(nullable: false),
                    DiscountAmount = table.Column<double>(nullable: false),
                    MinPrice = table.Column<double>(nullable: false, defaultValue: 0.0),
                    IsFixed = table.Column<int>(nullable: false, defaultValue: 0),
                    Image = table.Column<string>(nullable: false),
                    StartsAt = table.Column<DateTime>(nullable: false),
                    ExpiresAt = table.Column<DateTime>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coupon", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Gender = table.Column<int>(nullable: false),
                    Phone = table.Column<string>(maxLength: 11, nullable: false),
                    Address = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Gender = table.Column<int>(nullable: false),
                    Birthdate = table.Column<DateTime>(nullable: false),
                    Phone = table.Column<string>(maxLength: 11, nullable: false),
                    Address = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Position = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    Username = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentMethod",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    IsSupported = table.Column<int>(nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethod", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Publisher",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 400, nullable: false),
                    Slug = table.Column<string>(nullable: false),
                    Image = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publisher", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cart",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<string>(nullable: true),
                    IsActive = table.Column<int>(nullable: false, defaultValue: 1),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cart", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cart_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeAuthorization",
                columns: table => new
                {
                    EmployeeId = table.Column<string>(nullable: false),
                    View = table.Column<int>(nullable: false, defaultValue: 0),
                    Insert = table.Column<int>(nullable: false, defaultValue: 0),
                    Update = table.Column<int>(nullable: false, defaultValue: 0),
                    Delete = table.Column<int>(nullable: false, defaultValue: 0),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeAuthorization", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Authorization_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CustomerId = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(maxLength: 11, nullable: false),
                    CouponId = table.Column<int>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    SubTotal = table.Column<double>(nullable: false, defaultValue: 0.0),
                    Total = table.Column<double>(nullable: false, defaultValue: 0.0),
                    StatusId = table.Column<int>(nullable: false, defaultValue: 1),
                    PaymentMethodId = table.Column<int>(nullable: false, defaultValue: 1),
                    PaymentStatus = table.Column<int>(nullable: false, defaultValue: 0),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_Coupon_CouponId",
                        column: x => x.CouponId,
                        principalTable: "Coupon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Order_PaymentMethod_PaymentMethodId",
                        column: x => x.PaymentMethodId,
                        principalTable: "PaymentMethod",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_OrderStatus_StatusId",
                        column: x => x.StatusId,
                        principalTable: "OrderStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 400, nullable: false),
                    Slug = table.Column<string>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    PublicationMonth = table.Column<int>(nullable: true),
                    PublicationYear = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Pages = table.Column<int>(nullable: true),
                    CategoryId = table.Column<string>(nullable: false),
                    PublisherId = table.Column<string>(nullable: false),
                    AuthorId = table.Column<string>(nullable: false),
                    TranslatorId = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Book_AuTrans_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "AuthorTranslator",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Book_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Book_Publisher_PublisherId",
                        column: x => x.PublisherId,
                        principalTable: "Publisher",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Book_AuTrans_TranslatorId",
                        column: x => x.TranslatorId,
                        principalTable: "AuthorTranslator",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BookImage",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<string>(nullable: false),
                    Image = table.Column<string>(nullable: false),
                    Primary = table.Column<int>(nullable: false, defaultValue: 0),
                    CreatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookImage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookImage_Book_BookId",
                        column: x => x.BookId,
                        principalTable: "Book",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookView",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<string>(nullable: false),
                    SessionId = table.Column<string>(nullable: false),
                    CustomerId = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookView", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookView_Book_BookId",
                        column: x => x.BookId,
                        principalTable: "Book",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookView_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    CartId = table.Column<int>(nullable: false),
                    BookId = table.Column<string>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    IsSelected = table.Column<int>(nullable: false, defaultValue: 0),
                    IsDeleted = table.Column<int>(nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => new { x.CartId, x.BookId });
                    table.ForeignKey(
                        name: "FK_CartItems_Book_BookId",
                        column: x => x.BookId,
                        principalTable: "Book",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartItems_Cart_CartId",
                        column: x => x.CartId,
                        principalTable: "Cart",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    BookId = table.Column<string>(nullable: false),
                    Vote = table.Column<int>(nullable: false),
                    Content = table.Column<string>(nullable: false),
                    Bought = table.Column<int>(nullable: false, defaultValue: 0),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comment_Book_BookId",
                        column: x => x.BookId,
                        principalTable: "Book",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comment_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetail",
                columns: table => new
                {
                    OrderDetailId = table.Column<int>(nullable: false),
                    OrderId = table.Column<string>(nullable: false),
                    BookId = table.Column<string>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetail", x => new { x.OrderDetailId, x.OrderId });
                    table.ForeignKey(
                        name: "FK_OrderDetail_Book_BookId",
                        column: x => x.BookId,
                        principalTable: "Book",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetail_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Wishlist",
                columns: table => new
                {
                    CustomerId = table.Column<string>(nullable: false),
                    BookId = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wishlist", x => new { x.CustomerId, x.BookId });
                    table.ForeignKey(
                        name: "FK_Wishlist_Book_BookId",
                        column: x => x.BookId,
                        principalTable: "Book",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Wishlist_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AuthorTranslator",
                columns: new[] { "Id", "Author", "CreatedAt", "DeletedAt", "Name", "Slug", "UpdatedAt" },
                values: new object[,]
                {
                    { "A001", 1, new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Phil Town", "phil-town", new DateTime(2020, 10, 20, 12, 1, 0, 0, DateTimeKind.Unspecified) },
                    { "A028", 1, new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lee Woo Jung", "lee-woo-jung", new DateTime(2020, 10, 20, 21, 24, 0, 0, DateTimeKind.Unspecified) },
                    { "A030", 1, new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jack London", "jack-london", new DateTime(2020, 10, 20, 21, 25, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "AuthorTranslator",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Name", "Slug", "Translator", "UpdatedAt" },
                values: new object[] { "A031", new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Huỳnh Lý", "huynh-ly", 1, new DateTime(2020, 10, 20, 21, 25, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AuthorTranslator",
                columns: new[] { "Id", "Author", "CreatedAt", "DeletedAt", "Name", "Slug", "UpdatedAt" },
                values: new object[,]
                {
                    { "A032", 1, new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "M.L. Stedman", "m-l-stedman", new DateTime(2020, 10, 20, 21, 25, 0, 0, DateTimeKind.Unspecified) },
                    { "A033", 1, new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Đinh Hằng", "dinh-hang", new DateTime(2020, 10, 20, 21, 25, 0, 0, DateTimeKind.Unspecified) },
                    { "A034", 1, new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Donald J. Trump", "donald-j-trump", new DateTime(2020, 10, 20, 21, 25, 0, 0, DateTimeKind.Unspecified) },
                    { "A035", 1, new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chade - Meng Tan", "chade-meng-tan", new DateTime(2020, 10, 20, 21, 25, 0, 0, DateTimeKind.Unspecified) },
                    { "A036", 1, new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kevin Mitnick", "kevin-mitnick", new DateTime(2020, 10, 20, 21, 25, 0, 0, DateTimeKind.Unspecified) },
                    { "A037", 1, new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Clifford Stoll", "clifford-stoll", new DateTime(2020, 10, 20, 21, 26, 0, 0, DateTimeKind.Unspecified) },
                    { "A038", 1, new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "William L. Simon", "william-l-simon", new DateTime(2020, 10, 20, 21, 26, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "AuthorTranslator",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Name", "Slug", "Translator", "UpdatedAt" },
                values: new object[] { "A027", new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Thu Lê", "thu-le", 1, new DateTime(2020, 10, 20, 21, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AuthorTranslator",
                columns: new[] { "Id", "Author", "CreatedAt", "DeletedAt", "Name", "Slug", "UpdatedAt" },
                values: new object[] { "A039", 1, new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lawrence M. Krauss", "lawrence-m-krauss", new DateTime(2020, 10, 20, 21, 26, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AuthorTranslator",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Name", "Slug", "Translator", "UpdatedAt" },
                values: new object[,]
                {
                    { "A041", new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lê Vũ Kỳ Nam", "le-vu-ky-nam", 1, new DateTime(2020, 10, 20, 21, 26, 0, 0, DateTimeKind.Unspecified) },
                    { "A042", new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Thu Giang", "thu-giang", 1, new DateTime(2020, 10, 20, 21, 26, 0, 0, DateTimeKind.Unspecified) },
                    { "A043", new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Mộc Hương", "moc-huong", 1, new DateTime(2020, 10, 20, 21, 27, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "AuthorTranslator",
                columns: new[] { "Id", "Author", "CreatedAt", "DeletedAt", "Name", "Slug", "UpdatedAt" },
                values: new object[,]
                {
                    { "A044", 1, new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Fujiko.F.Fujio", "fujiko-f-fujio", new DateTime(2020, 10, 20, 21, 27, 0, 0, DateTimeKind.Unspecified) },
                    { "A045", 1, new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Rudyard Kipling", "rudyard-kipling", new DateTime(2020, 10, 20, 21, 27, 0, 0, DateTimeKind.Unspecified) },
                    { "A046", 1, new DateTime(2020, 7, 4, 0, 39, 0, 0, DateTimeKind.Unspecified), null, "Luis Sepulveda", "luis-sepulveda", new DateTime(2020, 10, 20, 21, 27, 0, 0, DateTimeKind.Unspecified) },
                    { "A047", 1, new DateTime(2020, 10, 20, 21, 36, 0, 0, DateTimeKind.Unspecified), null, "Michio Kaku", "michio-kaku", new DateTime(2020, 10, 20, 21, 36, 0, 0, DateTimeKind.Unspecified) },
                    { "A048", 1, new DateTime(2020, 10, 20, 21, 39, 0, 0, DateTimeKind.Unspecified), null, "Michael Talbot", "michael-talbot", new DateTime(2020, 10, 20, 21, 39, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "AuthorTranslator",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Name", "Slug", "Translator", "UpdatedAt" },
                values: new object[,]
                {
                    { "A049", new DateTime(2020, 10, 20, 21, 40, 0, 0, DateTimeKind.Unspecified), null, "Phạm Văn Thiều - Nguyễn Đình Điện", "pham-van-thieu-nguyen-dinh-dien", 1, new DateTime(2020, 10, 20, 21, 40, 0, 0, DateTimeKind.Unspecified) },
                    { "A050", new DateTime(2020, 10, 20, 21, 48, 0, 0, DateTimeKind.Unspecified), null, "Vương Ngân Hà", "vuong-ngan-ha", 1, new DateTime(2020, 10, 20, 21, 48, 0, 0, DateTimeKind.Unspecified) },
                    { "A040", new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Trần Thanh Hương và LeVN", "tran-thanh-huong-va-levn", 1, new DateTime(2020, 10, 20, 21, 26, 0, 0, DateTimeKind.Unspecified) },
                    { "A026", new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Hương Ly", "huong-ly", 1, new DateTime(2020, 10, 20, 21, 24, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "AuthorTranslator",
                columns: new[] { "Id", "Author", "CreatedAt", "DeletedAt", "Name", "Slug", "UpdatedAt" },
                values: new object[,]
                {
                    { "A029", 1, new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Hector Malot", "hector-malot", new DateTime(2020, 10, 20, 21, 25, 0, 0, DateTimeKind.Unspecified) },
                    { "A024", 1, new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Thomas Harris", "thomas-harris", new DateTime(2020, 10, 20, 21, 24, 0, 0, DateTimeKind.Unspecified) },
                    { "A002", 1, new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "T.Harv Eker", "t-harv-eker", new DateTime(2020, 10, 20, 21, 1, 0, 0, DateTimeKind.Unspecified) },
                    { "A003", 1, new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "George S. Clason", "george-s-clason", new DateTime(2020, 10, 20, 21, 2, 0, 0, DateTimeKind.Unspecified) },
                    { "A004", 1, new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Laura Lyseight", "laura-lyseight", new DateTime(2020, 10, 20, 21, 3, 0, 0, DateTimeKind.Unspecified) },
                    { "A005", 1, new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Steven J. Spear", "steven-j-spear", new DateTime(2020, 10, 20, 21, 4, 0, 0, DateTimeKind.Unspecified) },
                    { "A006", 1, new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Stephen Hawking", "stephen-hawking", new DateTime(2020, 10, 20, 21, 7, 0, 0, DateTimeKind.Unspecified) },
                    { "A007", 1, new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Tô Hoài", "to-hoai", new DateTime(2020, 10, 20, 21, 8, 0, 0, DateTimeKind.Unspecified) },
                    { "A008", 1, new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "David Walliam", "david-walliam", new DateTime(2020, 10, 20, 21, 9, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "AuthorTranslator",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Name", "Slug", "Translator", "UpdatedAt" },
                values: new object[] { "A009", new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Snorlax", "snorlax", 1, new DateTime(2020, 10, 20, 21, 12, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AuthorTranslator",
                columns: new[] { "Id", "Author", "CreatedAt", "DeletedAt", "Name", "Slug", "UpdatedAt" },
                values: new object[] { "A025", 1, new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lôi Mễ", "loi-me", new DateTime(2020, 10, 20, 21, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AuthorTranslator",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Name", "Slug", "Translator", "UpdatedAt" },
                values: new object[] { "A011", new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Đặng Quân", "dang-quan", 1, new DateTime(2020, 10, 20, 21, 17, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AuthorTranslator",
                columns: new[] { "Id", "Author", "CreatedAt", "DeletedAt", "Name", "Slug", "UpdatedAt" },
                values: new object[,]
                {
                    { "A012", 1, new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Tống Mặc", "tong-mac", new DateTime(2020, 10, 20, 21, 17, 0, 0, DateTimeKind.Unspecified) },
                    { "A010", 1, new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cảnh Thiên", "canh-thien", new DateTime(2020, 10, 20, 21, 16, 0, 0, DateTimeKind.Unspecified) },
                    { "A014", 1, new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Nguyễn Nhật Ánh", "nguyen-nhat-anh", new DateTime(2020, 10, 20, 21, 19, 0, 0, DateTimeKind.Unspecified) },
                    { "A015", 1, new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Nguyễn Ngọc Tư", "nguyen-ngoc-tu", new DateTime(2020, 10, 20, 21, 19, 0, 0, DateTimeKind.Unspecified) },
                    { "A016", 1, new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Nguyễn Tuân", "nguyen-tuan", new DateTime(2020, 10, 20, 21, 20, 0, 0, DateTimeKind.Unspecified) },
                    { "A017", 1, new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jane Austen", "jane-austen", new DateTime(2020, 10, 20, 21, 20, 0, 0, DateTimeKind.Unspecified) },
                    { "A018", 1, new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Colleen Mccullough", "colleen-mccullough", new DateTime(2020, 10, 20, 21, 21, 0, 0, DateTimeKind.Unspecified) },
                    { "A019", 1, new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Victor Hugo", "victor-hugo", new DateTime(2020, 10, 20, 21, 21, 0, 0, DateTimeKind.Unspecified) },
                    { "A020", 1, new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jeffrey Archer", "jeffrey-archer", new DateTime(2020, 10, 20, 21, 21, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "AuthorTranslator",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Name", "Slug", "Translator", "UpdatedAt" },
                values: new object[] { "A021", new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Nguyễn Việt Hải", "nguyen-viet-hai", 1, new DateTime(2020, 10, 20, 21, 21, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AuthorTranslator",
                columns: new[] { "Id", "Author", "CreatedAt", "DeletedAt", "Name", "Slug", "UpdatedAt" },
                values: new object[,]
                {
                    { "A022", 1, new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Yagisawa Satoshi", "yagisawa-satoshi", new DateTime(2020, 10, 20, 21, 22, 0, 0, DateTimeKind.Unspecified) },
                    { "A013", 1, new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Hoàng Hải Nguyễn", "hoang-hai-nguyen", new DateTime(2020, 10, 20, 21, 18, 0, 0, DateTimeKind.Unspecified) },
                    { "A023", 1, new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Arthur Conan Doyle", "arthur-conan-doyle", new DateTime(2020, 10, 20, 21, 24, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Banner",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Image", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "banner1.jpg", "Banner 1", new DateTime(2020, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2020, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "banner2.jpg", "Banner 2", new DateTime(2020, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2020, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "banner3.jpg", "Banner 3", new DateTime(2020, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2020, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "banner4.jpg", "Banner 4", new DateTime(2020, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2020, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "banner5.jpg", "Banner 5", new DateTime(2020, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "HorizontalImage", "Name", "Slug", "UpdatedAt", "VerticalImage" },
                values: new object[,]
                {
                    { "TD-KNS", new DateTime(2020, 5, 12, 9, 23, 0, 0, DateTimeKind.Unspecified), null, "tdkns-hz.jpg", "Sách Tư duy và kỹ năng sống", "sach-tu-duy-va-ky-nang-song", new DateTime(2020, 10, 20, 4, 0, 0, 0, DateTimeKind.Unspecified), "tdkns-vc.jpg" },
                    { "VHVN", new DateTime(2020, 5, 12, 6, 33, 0, 0, DateTimeKind.Unspecified), null, "vhvn-hz.jpg", "Văn học Việt Nam", "van-hoc-viet-nam", new DateTime(2020, 10, 20, 4, 1, 0, 0, DateTimeKind.Unspecified), "vhvn-vc.jpg" },
                    { "STN", new DateTime(2020, 5, 12, 5, 19, 0, 0, DateTimeKind.Unspecified), null, "stn-hz.jpg", "Sách thiếu nhi", "sach-thieu-nhi", new DateTime(2020, 10, 20, 3, 57, 0, 0, DateTimeKind.Unspecified), "stn-vc.jpg" },
                    { "VHNN", new DateTime(2020, 5, 12, 10, 31, 0, 0, DateTimeKind.Unspecified), null, "vhnn-hz.jpg", "Văn học nước ngoài", "van-hoc-nuoc-ngoai", new DateTime(2020, 10, 20, 4, 1, 0, 0, DateTimeKind.Unspecified), "vhnn-vc.jpg" },
                    { "KT", new DateTime(2020, 5, 12, 9, 21, 0, 0, DateTimeKind.Unspecified), null, "kt-hz.jpg", "Kinh tế", "kinh-te", new DateTime(2020, 10, 20, 3, 57, 0, 0, DateTimeKind.Unspecified), "kt-vc.jpg" },
                    { "KHCN", new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "khcn-hz.jpg", "Khoa học và công nghệ", "khoa-hoc-va-cong-nghe", new DateTime(2020, 10, 20, 3, 56, 0, 0, DateTimeKind.Unspecified), "khcn-vc.jpg" },
                    { "SGK-GT", new DateTime(2020, 10, 20, 4, 32, 0, 0, DateTimeKind.Unspecified), null, "gkgt-hz.jpg", "Sách giáo khoa - Giáo trình", "sach-giao-khoa-giao-trinh", new DateTime(2020, 10, 20, 4, 32, 0, 0, DateTimeKind.Unspecified), "gkgt-vc.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Coupon",
                columns: new[] { "Id", "Code", "CreatedAt", "DeletedAt", "Description", "DiscountAmount", "ExpiresAt", "Image", "MaxUses", "MaxUsesUser", "Name", "Slug", "StartsAt", "Type", "UpdatedAt" },
                values: new object[] { 1, "HBNH01", new DateTime(2020, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chúc mừng sinh nhật TwentySven", 50.0, new DateTime(2020, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "birthdaysale.jpg", 100, 1, "HAPPY BIRTHDAY", "hbnh01", new DateTime(2020, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coupon", new DateTime(2020, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "Address", "CreatedAt", "DeletedAt", "Email", "Gender", "Name", "Password", "Phone", "UpdatedAt", "Username" },
                values: new object[,]
                {
                    { "KH021", "351/18A Lê Đại Hành F.11, Q.11", new DateTime(2019, 1, 16, 13, 26, 5, 0, DateTimeKind.Unspecified), null, "vinhfaker@gmail.com", 0, "Đỗ Thành Vĩnh", "123", "0908110026", new DateTime(2020, 6, 30, 13, 26, 5, 0, DateTimeKind.Unspecified), "vinh" },
                    { "KH022", "3B-2-2-5 Chung Cư Mỹ Viên, Nguyễn Lương Bằng, F.TÂn Phú, Q.7", new DateTime(2019, 11, 28, 13, 27, 0, 0, DateTimeKind.Unspecified), null, "trangfaker@gmail.com", 1, "Nguyễn Thị Thùy Trang", "123", "0925553672", new DateTime(2020, 6, 30, 13, 27, 0, 0, DateTimeKind.Unspecified), "trang" },
                    { "KH023", "220 Bis Trần Văn Đang, F.9, Q.3", new DateTime(2019, 9, 9, 13, 28, 5, 0, DateTimeKind.Unspecified), null, "phuongfaker@gmail.com", 0, "Phạm Trường Phương", "123", "0909952567", new DateTime(2020, 6, 30, 13, 28, 5, 0, DateTimeKind.Unspecified), "phuong1" },
                    { "KH024", "42/4/7 đường số 13 F.11, Q.GV", new DateTime(2019, 8, 21, 13, 29, 15, 0, DateTimeKind.Unspecified), null, "vanvanfaker@gmail.com", 1, "Lương Bích Vân", "123", "0955220676", new DateTime(2020, 6, 30, 13, 29, 15, 0, DateTimeKind.Unspecified), "vanbl" },
                    { "KH025", "32/1C Trần Hưng Đạo, Q.5, TPHCM", new DateTime(2019, 12, 10, 13, 32, 0, 0, DateTimeKind.Unspecified), null, "thyfaker@gmail.com", 1, "Thái Lê Ngọc Thy", "123", "0918265699", new DateTime(2020, 6, 30, 13, 32, 0, 0, DateTimeKind.Unspecified), "thythy" },
                    { "KH026", "TK28/14 Nguyễn Cảnh Chân, Q.1", new DateTime(2020, 2, 2, 13, 32, 45, 0, DateTimeKind.Unspecified), null, "saufaker@gmail.com", 1, "Nguyễn Thị Sáu", "123", "0982515267", new DateTime(2020, 6, 30, 13, 32, 45, 0, DateTimeKind.Unspecified), "sau" },
                    { "KH028", "563/13 Nguyễn Đình Chiểu,P.2, Q.3, HCM", new DateTime(2019, 10, 28, 13, 34, 53, 0, DateTimeKind.Unspecified), null, "vanduyfaker@gmail.com", 0, "Đỗ Duy Văn", "123", "0915155495", new DateTime(2020, 6, 30, 13, 34, 53, 0, DateTimeKind.Unspecified), "van" },
                    { "KH029", "120/5A6 Lê Văn Thọ, F.11, Q.GV", new DateTime(2019, 9, 13, 13, 35, 42, 0, DateTimeKind.Unspecified), null, "tamfaker@gmail.com", 0, "Trần Thanh Tâm", "123", "0945792644", new DateTime(2020, 6, 30, 13, 35, 42, 0, DateTimeKind.Unspecified), "tam" },
                    { "KH030", "237/14 Trần Văn Đang, F.11, Q.3", new DateTime(2019, 11, 24, 13, 37, 5, 0, DateTimeKind.Unspecified), null, "kimcuongfaker@gmail.com", 1, "Võ Thị Kim Cương", "123", "0913757058", new DateTime(2020, 6, 30, 13, 37, 5, 0, DateTimeKind.Unspecified), "kimcuong" },
                    { "KH031", "621/19 Tô Ký, P.Trung Mỹ Tây, Q12,TP HCM", new DateTime(2019, 8, 19, 13, 38, 10, 0, DateTimeKind.Unspecified), null, "binhfaker@gmail.com", 0, "Cao Văn Bình", "123", "0985990247", new DateTime(2020, 6, 30, 13, 38, 10, 0, DateTimeKind.Unspecified), "binh" },
                    { "KH032", "20 Nguyễn Cư Trinh, P Phạm Ngũ Lão, Q.1", new DateTime(2019, 7, 3, 13, 39, 38, 0, DateTimeKind.Unspecified), null, "ducfaker@gmail.com", 0, "Trương Minh Đức", "123", "0368588866", new DateTime(2020, 6, 30, 13, 39, 38, 0, DateTimeKind.Unspecified), "duc" },
                    { "KH033", "41/1, Tấn Quới, Tấn Mỹ, Chợ Mới, An Giang", new DateTime(2020, 6, 30, 13, 45, 12, 0, DateTimeKind.Unspecified), null, "duchuufaker@gmail.com", 0, "Nguyễn Hữu Đức", "123", "0902995022", new DateTime(2020, 6, 30, 13, 45, 12, 0, DateTimeKind.Unspecified), "duchn" },
                    { "KH034", "12 Lạc Long Quân, F.11, Q.11 TPHCM", new DateTime(2019, 2, 20, 13, 47, 48, 0, DateTimeKind.Unspecified), null, "mai11faker@gmail.com", 1, "Lê Trúc Mai", "123", "0925532737", new DateTime(2020, 6, 30, 13, 47, 48, 0, DateTimeKind.Unspecified), "maitruc" },
                    { "KH035", "30 Nguyenx Huệ", new DateTime(2020, 7, 3, 11, 16, 1, 0, DateTimeKind.Unspecified), null, "demofaker@gmail.com", 0, "demo", "123", "0922818181", new DateTime(2020, 7, 3, 11, 16, 1, 0, DateTimeKind.Unspecified), "demo" },
                    { "KH036", "280 An Dương Vương", new DateTime(2020, 10, 20, 22, 26, 51, 0, DateTimeKind.Unspecified), null, "leminhfaker@gmail.com", 0, "Lê Minh", "123", "0987896757", new DateTime(2020, 10, 20, 22, 26, 51, 0, DateTimeKind.Unspecified), "minhle" },
                    { "KH020", "43 đường 909 Tạ Quang Biểu, F.5, Q.8", new DateTime(2020, 3, 17, 11, 57, 16, 0, DateTimeKind.Unspecified), null, "longvuvfaker@gmail.com", 0, "Tô Hữu Long Vũ", "123", "0908606399", new DateTime(2020, 6, 29, 11, 57, 16, 0, DateTimeKind.Unspecified), "longvu" },
                    { "KH019", "3B-2-2-5 Chung Cư Mỹ Viên, Nguyễn Lương Bằng, F.TÂn Phú, Q.7", new DateTime(2020, 4, 20, 11, 54, 23, 0, DateTimeKind.Unspecified), null, "thuytrangfaker@gmail.com", 1, "Nguyễn Thị Thùy Trang", "123", "0918265681", new DateTime(2020, 4, 20, 11, 54, 23, 0, DateTimeKind.Unspecified), "trang11" },
                    { "KH027", "62/20B Đinh Bộ Lĩnh, F.26, Q.BT", new DateTime(2019, 9, 11, 13, 33, 54, 0, DateTimeKind.Unspecified), null, "thaominhfaker@gmail.com", 1, "Nguyễn Thị Minh Thảo", "123", "0923312776", new DateTime(2020, 6, 30, 13, 33, 54, 0, DateTimeKind.Unspecified), "thaominh" },
                    { "KH017", "63 Đường A2 Khu dân Cư Nam Hùng Vương, P. An Lạc, Q. Bình tân, TPHCM", new DateTime(2020, 5, 18, 11, 48, 47, 0, DateTimeKind.Unspecified), null, "thaobichfaker@gmail.com", 1, "Lương Thị Bích Thảo", "123", "0888367211", new DateTime(2020, 6, 29, 11, 48, 47, 0, DateTimeKind.Unspecified), "thao" },
                    { "KH001", "35C Tổ 87, KP.12, Phường Hố Nai, TP. Biên Hòa, Tỉnh Đồng Nai", new DateTime(2020, 6, 21, 7, 57, 52, 0, DateTimeKind.Unspecified), null, "chiantddfaker@gmail.com", 1, "Nguyễn Thị Ngọc Diệp", "123", "0918265684", new DateTime(2020, 6, 21, 7, 57, 52, 0, DateTimeKind.Unspecified), "diepn" },
                    { "KH002", "330 Cách Mạng Tháng Tám, Phường 10, Quận 3, TP.HCM", new DateTime(2020, 6, 21, 8, 0, 13, 0, DateTimeKind.Unspecified), null, "cuongphuong78faker@yahoo.com", 0, "ĐOÀN HỮU MINH", "123", "0938189742", new DateTime(2020, 6, 21, 8, 0, 13, 0, DateTimeKind.Unspecified), "minh123" },
                    { "KH003", "109 Tổ 2, Khu Bến Cát, Phường Phước Bình, Quận 9, TP.HCM", new DateTime(2020, 6, 21, 10, 26, 25, 0, DateTimeKind.Unspecified), null, "thao.nguyenfaker@gazefi.com", 1, "Nguyễn Phương Thảo", "123", "0933335666", new DateTime(2020, 6, 21, 10, 26, 25, 0, DateTimeKind.Unspecified), "lucky" },
                    { "KH004", "477/22 Âu Cơ, P. Phú Trung, Q. Tân Phú Âu Cơ, P. Phú Trung, Q. Tân Phú", new DateTime(2020, 6, 29, 11, 19, 37, 0, DateTimeKind.Unspecified), null, "aifaker@gmail.com", 1, "Trần Thị Thúy Ái", "123", "0908767358", new DateTime(2020, 6, 29, 11, 19, 37, 0, DateTimeKind.Unspecified), "aii109" },
                    { "KH005", "1/9 Hồ Thị Kỷ, F1, Q10, TP. HCM Hồ Thị Kỷ, F1, Q10, TP. HCM TP. HCM", new DateTime(2020, 6, 29, 11, 23, 15, 0, DateTimeKind.Unspecified), null, "songfaker@gmail.com", 0, "Nguyễn Văn Song", "123", "0918608578", new DateTime(2020, 6, 29, 11, 23, 15, 0, DateTimeKind.Unspecified), "song" },
                    { "KH006", "2/15B Trần Nhân Tôn, F2, Q.10 Trần Nhân Tôn, F2, Q.10 TP.HCM", new DateTime(2020, 4, 16, 11, 24, 41, 0, DateTimeKind.Unspecified), null, "quynhfaker@gmail.com", 1, "Lê Thị Khánh Quỳnh", "123", "0918637176", new DateTime(2020, 6, 29, 11, 24, 41, 0, DateTimeKind.Unspecified), "quynh" },
                    { "KH007", "315 Khu Phố 2 - Thị trấn Hóc Môn - TPHCM", new DateTime(2020, 3, 9, 11, 25, 39, 0, DateTimeKind.Unspecified), null, "hai2faker@gmail.com", 0, "Trần Việt Hải", "123", "0913652449", new DateTime(2020, 6, 29, 11, 25, 39, 0, DateTimeKind.Unspecified), "hai002" },
                    { "KH008", "39 Bến Phú Định, F16, Q8, HCM", new DateTime(2020, 3, 18, 11, 26, 39, 0, DateTimeKind.Unspecified), null, "sang001faker@gmail.com", 0, "Phan Thanh Sang", "123", "0903120175", new DateTime(2020, 6, 29, 11, 26, 39, 0, DateTimeKind.Unspecified), "sang001" },
                    { "KH010", "146 Lầu 4 Hùng Vương, F.12, Q.5", new DateTime(2020, 5, 8, 11, 29, 10, 0, DateTimeKind.Unspecified), null, "namvinhfaker@gmail.com", 0, "Nguyễn Vĩnh Nam", "123", "0938100552", new DateTime(2020, 6, 29, 11, 29, 10, 0, DateTimeKind.Unspecified), "vinhnam" },
                    { "KH011", "84 Lương Đình Của, P.Thủ Thiêm Q.2 TP.HCM", new DateTime(2020, 5, 17, 11, 32, 27, 0, DateTimeKind.Unspecified), null, "thoafaker@gmail.com", 1, "Ngô Thị Thoa", "123", "0909252661", new DateTime(2020, 6, 29, 11, 32, 27, 0, DateTimeKind.Unspecified), "thoa" },
                    { "KH012", "97/5/18D Phùng Tá Chu, F An Lạc, Q BT", new DateTime(2020, 5, 31, 11, 33, 22, 0, DateTimeKind.Unspecified), null, "chienfaker@gmail.com", 0, "Trần Công Chiến", "123", "0938993711", new DateTime(2020, 6, 29, 11, 33, 22, 0, DateTimeKind.Unspecified), "chieen005" },
                    { "KH013", "21 đường28, KP4, P.Hiệp Bình Chánh, Q.Thủ Đức, TP.HCM", new DateTime(2020, 4, 21, 11, 34, 20, 0, DateTimeKind.Unspecified), null, "nganfaker@gmail.com", 1, "Vũ Thị Ngọc Ngân", "123", "0909987604", new DateTime(2020, 6, 29, 11, 34, 20, 0, DateTimeKind.Unspecified), "nganvtn" },
                    { "KH014", "B27 Cư Xá Lam Sơn, Nguyễn Oanh, F.17, Q.GV", new DateTime(2020, 5, 7, 11, 35, 22, 0, DateTimeKind.Unspecified), null, "thuyanhfaker@gmail.com", 1, "Trần Thị Thùy Anh", "123", "0913778801", new DateTime(2020, 6, 29, 11, 35, 22, 0, DateTimeKind.Unspecified), "thuyanh" },
                    { "KH015", "89/10 Khuông Việt,F.Phú Trung, Q.TP", new DateTime(2020, 5, 13, 11, 36, 34, 0, DateTimeKind.Unspecified), null, "thuyfaker@gmail.com", 1, "Nguyễn Đồng Diễm Thúy", "123", "0908363660", new DateTime(2020, 6, 29, 11, 36, 34, 0, DateTimeKind.Unspecified), "thuy" },
                    { "KH016", "122/1/1 Lê Văn Thọ, F.11, Q.GV", new DateTime(2020, 2, 12, 11, 45, 8, 0, DateTimeKind.Unspecified), null, "tribaofaker@gmail.com", 0, "Nguyễn Hoang Bảo Trị", "123", "0288888866", new DateTime(2020, 6, 29, 11, 45, 8, 0, DateTimeKind.Unspecified), "tri" },
                    { "KH009", "758 Điện Biên Phủ, P10 Q.Bình Thạnh HCM", new DateTime(2020, 5, 3, 11, 28, 8, 0, DateTimeKind.Unspecified), null, "ngocnttfaker@gmail.com", 1, "Nguyễn Thị Hồng Ngọc", "123", "0908543869", new DateTime(2020, 6, 29, 11, 28, 8, 0, DateTimeKind.Unspecified), "ngoc" },
                    { "KH018", "159/19/6 Bạch Đằng, F.2, Q.TB", new DateTime(2020, 4, 28, 11, 53, 40, 0, DateTimeKind.Unspecified), null, "cuongfaker@gmail.com", 0, "Trịnh Quốc Cường", "123", "0909952567", new DateTime(2020, 6, 29, 11, 53, 40, 0, DateTimeKind.Unspecified), "cuong" }
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "Address", "Birthdate", "CreatedAt", "DeletedAt", "Email", "Gender", "Name", "Password", "Phone", "Position", "UpdatedAt", "Username" },
                values: new object[,]
                {
                    { "NV003", "Căn B7 Khu Nhà ở Ngõ 535 Phố Kim Mã, P. Ngọc Khánh, Q. Ba Đình, Hà Nội", new DateTime(1995, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 20, 6, 59, 21, 0, DateTimeKind.Unspecified), null, "tranmanhfakerchung@otoxemay.vn", 0, "Trần Mạnh Chung", "123", "0983603517", "Nhân viên", new DateTime(2020, 5, 20, 6, 59, 21, 0, DateTimeKind.Unspecified), "NV003" },
                    { "NV004", "Tổ 4, Khu 5B, Bãy Cháy, TP. Hạ Long, Tỉnh Quảng Ninh", new DateTime(1998, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 20, 6, 59, 21, 0, DateTimeKind.Unspecified), null, "minhfakerthu9979@gmail.com", 1, "Ngô Thị Minh Thư", "123", "0902797879", "Nhân viên", new DateTime(2020, 5, 20, 6, 59, 21, 0, DateTimeKind.Unspecified), "NV004" },
                    { "NV002", "Khu Phố 4, Phường Tân Tiến, TP. Biên Hòa, Tỉnh Đồng Nai", new DateTime(1995, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 20, 6, 59, 21, 0, DateTimeKind.Unspecified), null, "anhtuanfaker@vanthai.com.vn158", 0, "Đỗ Anh Tuấn", "123", "0918883862", "Nhân viên", new DateTime(2020, 5, 20, 6, 59, 21, 0, DateTimeKind.Unspecified), "NV002" },
                    { "NV001", "109 Tổ 2, Khu Bến Cát, Phường Phước Bình, Quận 9, TP.HCM", new DateTime(1996, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 20, 6, 52, 55, 0, DateTimeKind.Unspecified), null, "thao.nguyenfaker@gazefi.com", 1, "Nguyễn Phương Thảo", "123", "0123456754", "Admin", new DateTime(2020, 7, 2, 23, 55, 1, 0, DateTimeKind.Unspecified), "NV001" }
                });

            migrationBuilder.InsertData(
                table: "OrderStatus",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Đang chờ xử lý" },
                    { 2, "Tiếp nhận đơn hàng" },
                    { 3, "Đóng gói và vận chuyển" },
                    { 4, "Giao hàng thành công" },
                    { 5, "Hủy" }
                });

            migrationBuilder.InsertData(
                table: "PaymentMethod",
                columns: new[] { "Id", "IsSupported", "Name" },
                values: new object[] { 1, 1, "Thanh toán bằng tiền mặt" });

            migrationBuilder.InsertData(
                table: "PaymentMethod",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 2, "Thanh toán bằng Paypal" },
                    { 3, "Thanh toán bằng VNPay" }
                });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Image", "Name", "Slug", "UpdatedAt" },
                values: new object[,]
                {
                    { "VH", new DateTime(2020, 5, 20, 5, 21, 0, 0, DateTimeKind.Unspecified), null, "vh.png", "NXB Văn Học", "nxb-van-hoc", new DateTime(2020, 10, 20, 9, 12, 0, 0, DateTimeKind.Unspecified) },
                    { "TN", new DateTime(2020, 10, 20, 9, 29, 0, 0, DateTimeKind.Unspecified), null, "tn.png", "NXB Thanh Niên", "nxb-thanh-nien", new DateTime(2020, 10, 20, 9, 29, 0, 0, DateTimeKind.Unspecified) },
                    { "TH", new DateTime(2020, 5, 20, 8, 24, 0, 0, DateTimeKind.Unspecified), null, "tonghop.png", "NXB Tổng Hợp", "nxb-tong-hop", new DateTime(2020, 10, 20, 9, 11, 0, 0, DateTimeKind.Unspecified) },
                    { "TG", new DateTime(2020, 5, 20, 8, 18, 0, 0, DateTimeKind.Unspecified), null, "thegioi.png", "NXB Thế Giới", "nxb-the-gioi", new DateTime(2020, 10, 20, 9, 11, 0, 0, DateTimeKind.Unspecified) },
                    { "CT", new DateTime(2020, 5, 20, 7, 17, 0, 0, DateTimeKind.Unspecified), null, "congthuong.png", "NXB Công Thương", "nxb-cong-thuong", new DateTime(2020, 10, 20, 9, 8, 0, 0, DateTimeKind.Unspecified) },
                    { "KD", new DateTime(2020, 5, 20, 7, 25, 0, 0, DateTimeKind.Unspecified), null, "kd.png", "Kim Đồng", "kim-dong", new DateTime(2020, 10, 20, 9, 10, 0, 0, DateTimeKind.Unspecified) },
                    { "HNV", new DateTime(2020, 5, 20, 9, 28, 0, 0, DateTimeKind.Unspecified), null, "hnv.jpg", "NXB Hội Nhà Văn", "nxb-hoi-nha-van", new DateTime(2020, 10, 20, 9, 10, 0, 0, DateTimeKind.Unspecified) },
                    { "HN", new DateTime(2020, 5, 20, 9, 22, 0, 0, DateTimeKind.Unspecified), null, "hanoi.png", "NXB Hà Nội", "nxb-ha-noi", new DateTime(2020, 10, 20, 9, 9, 0, 0, DateTimeKind.Unspecified) },
                    { "NXBT", new DateTime(2020, 5, 20, 9, 26, 0, 0, DateTimeKind.Unspecified), null, "nxbtre.png", "NXB Trẻ", "nxb-tre", new DateTime(2020, 10, 20, 9, 11, 0, 0, DateTimeKind.Unspecified) },
                    { "VH-NT", new DateTime(2020, 5, 20, 6, 17, 0, 0, DateTimeKind.Unspecified), null, "vh-nt.png", "NXB Văn hóa - nghệ thuật", "nxb-van-hoa-nghe-thuat", new DateTime(2020, 10, 20, 9, 14, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorId", "CategoryId", "CreatedAt", "DeletedAt", "Description", "Name", "Pages", "Price", "PublicationMonth", "PublicationYear", "PublisherId", "Slug", "TranslatorId", "UpdatedAt" },
                values: new object[,]
                {
                    { "S029", "A016", "VHVN", new DateTime(2020, 5, 20, 0, 58, 0, 0, DateTimeKind.Unspecified), null, "Văn học Việt Nam thời xưa có nhiều tác phẩm có giá trị to lớn về mặt nhân văn và nghệ thuật, đã được công nhận và chứng thực qua thời gian. Bộ sách Việt Nam danh tác bao gồm loạt tác phẩm đi cùng năm tháng như: Số đỏ (Vũ Trọng Phụng), Việc làng (Ngô Tất Tố), Gió đầu mùa, Hà Nội băm sáu phố phường (Thạch Lam), Miếng ngon Hà Nội (Vũ Bằng), Vang bóng một thời (Nguyễn Tuân). Hy vọng bộ sách sau khi tái bản sẽ giúp đông đảo tầng lớp độc giả thêm hiểu, tự hào và nâng niu kho tàng văn học nước nhà.<br>		    		Trích đoạn<br>		    		“Chùa nhà ta có cái giếng này quý lắm. Nước rất ngọt. Có lẽ tôi nghiện trà tàu vì nước giếng chùa nhà đây. Tôi sở dĩ  không đi đâu xa được là vì không đem theo được nước giếng này đi để pha trà. Bạch sư cụ, sư cụ nhớ hộ tôi câu thế này: Là giếng chùa nhà mà cạn thì tôi sẽ cho không người nào muốn xin bộ đồ trà rất quý của tôi. Chỉ có nước giếng  đây là pha trà không bao giờ lạc mất hương vị...”", "Việt Nam Danh Tác - Vang Bóng Một Thời", 212, 52000.0, 5, 2014, "HNV", "viet-nam-danh-tac-vang-bong-mot-thoi", null, new DateTime(2020, 10, 19, 2, 24, 0, 0, DateTimeKind.Unspecified) },
                    { "S026", "A015", "VHVN", new DateTime(2020, 5, 19, 23, 22, 0, 0, DateTimeKind.Unspecified), null, "Hành lý hư vô.<br>		    	Đó là thứ duy nhất có thể mang theo.<br>		    	Vào đúng khi bạn nhận ra có bao nhiêu đồ đạc cũng chẳng lấp nổi biển trong lòng.<br>		    	Vào đúng khi bạn có quá nhiều thứ để nhìn nhận lại trước và trong những cuộc chia tay.<br>		    	Vào đúng khi bạn hiểu cách những mối quan hệ biến dạng sau mỗi cuộc chuyển dời, nhất là giữa người với người.<br>		    	Vào đúng khi bạn biết là mình có thể buông, nhẹ không.<br>		    	Hành lý hư vô là tập tản văn mới nhất của nhà văn Nguyễn Ngọc Tư. Đọc nó, người ta khó lòng ngăn cản được nỗi buồn, mà cũng không muốn ngăn cản nỗi buồn bởi cuối dòng chảy cảm xúc ấy là sự đồng cảm, hy vọng và cả dỗ dành.<br>		    	Một tập tản văn đẹp, hiền, mộc mạc và sâu lắng chứa đựng tấm lòng của người viết.", "Hành Lý Hư Vô", 164, 38000.0, 5, 2019, "NXBT", "hanh-ly-hu-vo", null, new DateTime(2020, 10, 19, 2, 21, 0, 0, DateTimeKind.Unspecified) },
                    { "S025", "A015", "VHVN", new DateTime(2020, 5, 19, 23, 22, 0, 0, DateTimeKind.Unspecified), null, "Bạn định vị trên điện thoại rằng nhà bạn gần một trung tâm dưỡng lão, cứ tới đó đi, bạn sẽ đứng chờ. Xe ôm thả tôi xuống chỗ buồn hiu đó cả buổi, tôi lựng khựng tìm hoài mà không thấy ông già lòng khòng xương xẩu đâu. Và khi tha thẩn ở cuối đường tôi bỗng nhớ mình đã qua đây, đã đi về phía con hẻm vuông góc với chỗ tôi đang đứng, chui vào căn nhà tuềnh toàng của bạn, mười năm trước.<br>		    		Tôi hôm ấy run rẩy như con mèo ốm o bị ướt, khi tới nhà ông “Đồng gió”, “Nhớ khói” mà tôi đã ngưỡng mộ lâu rồi. Để lần đầu tiên biết nhà văn cũng có hai mắt một mũi như mọi người, cũng hài hước, cũng lơ tơ mơ, cũng nghèo…<br>		    		Cái hồi ức mười năm làm tôi hơi hoảng, mười năm qua tôi đã đi tới đâu, tận những chân trời nào, sao không thăm lại ? Tôi loay hoay với câu hỏi đó khi ngồi chơi với vợ bạn, để đợi bạn đang vẫn còn ngóng đón tôi đâu đó ngoài đầu hẻm. Đến sắp gặp nhau rồi mà lẻ vẫn đuổi theo vẫn so le, trục trặc. Nối lại loay hoay như thể đã bị đứt lìa lâu quá…<br>		    		Trong nhóm bạn già mà tôi hay lân la, bạn trẻ nhất. Mỗi lần gọi điện cho bạn, và nghe bên kia hịch hạc bảo, “ê nói nghe nè…”, như hai đứa trẻ con thầm thì, như bạn không cách tôi hai mươi lăm tuổi đời và hai trăm cây số.<br>		    		“Ê nói nghe nè, mầy viết ác vừa vừa thôi, tao không chịu…”<br>		    		“Ê nói nghe nè, có cái truyện trên Văn nghệ được lắm, sao không đọc ?”<br>		    		Tôi không mảy may nghi ngờ việc bạn sẽ còn rầy rà tôi đến vài ba chục năm nữa, dù nhiều lần bạn nói bâng quơ “ê nói nghe nè dạo này sao tao nghĩ nhiều về cái chết, làm như đã đi gần tới nó nên ngửi được mùi thấy mờ mờ dung nhan nó rồi”. Tôi nghe có chút dửng dưng, chuyện đó thường thôi, thậm chí đôi khi tôi còn rờ đụng nó mà. Bỗng có bữa đầu dây bên kia bỗng rã rời, “ê nói nghe nè, tự dưng tao thấy đời buồn hiu, mậy…”.<br>		    		Tôi ngớ ra trong giây lát, bởi chưa từng nghĩ bạn cũng buồn. Hồi biết bạn tới giờ lúc nào cũng gặp nhau giữa bạn bầy đông đúc, trong tôi mặc định bạn là con người của hội hè, tạo ra hội hè. Cứ cất tiếng “ê nói nghe nè, làm vài ly đi…” thì ai nấy hồ hởi đáp lời ngay. Cái chất hào sảng, chịu chơi của dân miền Tây mà phải chịu nỗi một mình thì vô lý.<br>		    		Nhưng giờ quanh bạn thưa đi những tiếng vọng. Những cuộc rượu nếu có chảy về phía ông, cũng bằng một hình thức khác. Nhiều khi nhậu nhẹt bọn tôi đã lấy bạn ra làm mồi cho đỡ lạt miệng. Bọn tôi nhắc chuyện bạn thấy đồng nghiệp bị vợ bạc đãi nên bất bình nhảy ra bênh, ngoay đầu đánh chị kia cho chừa ai ngờ ông chồng nổ xung thiên cự lại “sao mầy đánh vợ tao ?”. Hay chuyện hết tú tài bạn định đi vào cứ theo cách mạng, ngồi chờ tàu đò lâu quá tự dưng thấy… nản, bạn quay về bị chính quyền Sài Gòn bắt lính, ngót bốn năm làm anh binh sĩ ngồi bàn giấy, một bữa pháo lạc bầy tiễn về nhà với gương mặt có vết sẹo dài. Hay chuyện bạn giấu tiền dưới mấy cục gạch tàu lót nền, định xài riêng mà quên biệt, chừng xây lại nhà người ta thấy tiền rải đầy dưới đó. Hay chuyện bạn buồn ngủ quá mà tiếc cảnh vật đường xa nên bôi dầu gió vào mắt cho chúng đừng ríu lại. Hoặc chuyện bạn bỏ quên cái mắt kính trong phòng vệ sinh nữ, hồi đại hội.<br>		    		Những câu chuyện ngộ nghĩnh ba hư bảy thực về bạn làm bữa rượu bỗng ngon hơn với những tràng cười nghiêng ngã, cười đến chảy nước mắt ra… Ôi ôi ông ơi bọn tôi vui quá. Sau phút giây ràn rụa ấy, bỗng ràn rụa trong tôi cái ý nghĩ ở trong một cái nhà nhỏ bừa bộn chật chội nằm trên hẻm nhỏ giữa lòng thành phố Long Xuyên, biết đâu chủ nhân của những huyền thoại đang uống rượu một mình.<br>		    		Tôi vẫn hay thấy tuổi già của mình khi soi vào bạn. Bỗng trái tính trái nết, bỗng bạn bè đâu hết, thấy lẻ cả ở trong nhà mình. Đau đáu nỗi đời không biết nói với ai nên sà vào cuộc vui nào cũng tuôn cho đã cơn thèm, nào văn chương nào tôn giáo, nào cái ác nhiễu nhương… Xưa góp vui người ta gọi mời, giờ góp ưu phiền người ta ngại rủ lại chơi, thành ra bị bỏ rơi, thành ra bọn tôi cứ luẩn quẩn đi theo cái vòng cô đơn vô tận.<br>		    		Hết duyên rồi. Như chữ bạn vẫn thường dùng khi nói về cô bạn thân hồi trước. Phụ bạc luôn len lỏi trong máu của mỗi người. Và những cuộc bỏ rơi nhau vẫn đang xảy ra ở đâu đó.<br>		    		Từ ngày biết bạn cũng hay buồn, chập chờn mãi trong tôi hình ảnh một ông già mở ti vi cho nó oang oang và ngồi uống rượu một mình. Tới nhà chơi bỗng thấy may là bạn còn có sách ở bên, quơ tay đâu cũng đụng, mắt ngó đâu cũng thấy, chân đi đâu cũng vấp. Bạn vẫn ham, vẫn như đói ngấu mỗi khi gặp bất cứ cuốn sách nào. Tôi không còn thấy xa xót bồn chồn. Mang theo cuốn tản văn của Sandor Marai đọc lúc dọc đường, tôi để lại cho bạn. Cuốn sách này sẽ ở mãi đây, ngay cả khi tôi đã quay lưng đi khỏi.<br>		    		Một cuốn sách thì cả khi chìa gáy ra, người ta cũng nhận được một cái gì đó ấm áp, trao gửi.", "Gáy Người Thì Lạnh", 200, 36000.0, 3, 2017, "NXBT", "gay-nguoi-thi-lanh", null, new DateTime(2020, 10, 19, 2, 20, 0, 0, DateTimeKind.Unspecified) },
                    { "S024", "A014", "VHVN", new DateTime(2020, 5, 19, 22, 14, 0, 0, DateTimeKind.Unspecified), null, "Mắt biếc là một tác phẩm được nhiều người bình chọn là hay nhất của nhà văn Nguyễn Nhật Ánh. Tác phẩm này cũng đã được dịch giả Kato Sakae dịch sang tiếng Nhật để giới thiệu với độc giả Nhật Bản. <br>		    		“Tôi gửi tình yêu cho mùa hè, nhưng mùa hè không giữ nổi. Mùa hè chỉ biết ra hoa, phượng đỏ sân trường và tiếng ve nỉ non trong lá. Mùa hè ngây ngô, giống như tôi vậy. Nó chẳng làm được những điều tôi ký thác. Nó để Hà Lan đốt tôi, đốt rụi. Trái tim tôi cháy thành tro, rơi vãi trên đường về.”<br>		    		… Bởi sự trong sáng của một tình cảm, bởi cái kết thúc buồn, rất buồn khi xuyên suốt câu chuyện vẫn là những điều vui, buồn lẫn lộn …  <br>		    		 ", "Mắt Biếc", 300, 54000.0, 7, 2019, "NXBT", "mat-biec", null, new DateTime(2020, 10, 19, 2, 20, 0, 0, DateTimeKind.Unspecified) },
                    { "S023", "A014", "VHVN", new DateTime(2020, 5, 19, 22, 14, 0, 0, DateTimeKind.Unspecified), null, "Nếu ngày xưa còn bé, Thư luôn tự hào mình là cậu con trai thông minh có quyền bắt nạt và sai khiến các cô bé cùng lứa tuổi thì giờ đây khi lớn lên, anh luôn khổ sở khi thấy mình ngu ngơ và bị con gái “xỏ mũi”. Và điều nghịch lý ấy xem ra càng “trớ trêu’ hơn, khi như một định mệnh, Thư nhận ra Việt An, cô bạn học thông minh thường làm mình bối rối bấy lâu nay chính là Tiểu Li, con bé hàng xóm ngốc nghếch từng hứng chịu những trò nghịch ngợm của mình hồi xưa.", "Cô Gái Đến Từ Hôm Qua", 170, 48000.0, 6, 2017, "NXBT", "co-gai-den-tu-hom-qua", null, new DateTime(2020, 10, 19, 2, 20, 0, 0, DateTimeKind.Unspecified) },
                    { "S022", "A014", "VHVN", new DateTime(2020, 5, 19, 22, 14, 0, 0, DateTimeKind.Unspecified), null, "Truyện Cho tôi xin một vé đi tuổi thơ là sáng tác mới nhất của nhà văn Nguyễn Nhật Ánh. Nhà văn mời người đọc lên chuyến tàu quay ngược trở lại thăm tuổi thơ và tình bạn dễ thương của 4 bạn nhỏ. Những trò chơi dễ thương thời bé, tính cách thật thà, thẳng thắn một cách thông minh và dại dột, những ước mơ tự do trong lòng… khiến cuốn sách có thể làm các bậc phụ huynh lo lắng rồi thở phào. Không chỉ thích hợp với người đọc trẻ, cuốn sách còn có thể hấp dẫn và thực sự có ích cho người lớn trong quan hệ với con mình.", "Cho Tôi Xin Một Vé Đi Tuổi Thơ", null, 53000.0, 11, 2018, "NXBT", "cho-toi-xin-mot-ve-di-tuoi-tho", null, new DateTime(2020, 10, 19, 2, 19, 0, 0, DateTimeKind.Unspecified) },
                    { "S021", "A014", "VHVN", new DateTime(2020, 5, 19, 22, 14, 0, 0, DateTimeKind.Unspecified), null, "Ta bắt gặp trong Tôi Thấy Hoa Vàng Trên Cỏ Xanh một thế giới đấy bất ngờ và thi vị non trẻ với những suy ngẫm giản dị thôi nhưng gần gũi đến lạ. Câu chuyện của Tôi Thấy Hoa Vàng Trên Cỏ Xanh có chút này chút kia, để ai soi vào cũng thấy mình trong đó, kiểu như lá thư tình đầu đời của cu Thiều chẳng hạ ngây ngô và khờ khạo.<br>		    		Nhưng Tôi Thấy Hoa Vàng Trên Cỏ Xanh hình như không còn trong trẻo, thuần khiết trọn vẹn của một thế giới tuổi thơ nữa. Cuốn sách nhỏ nhắn vẫn hồn hậu, dí dỏm, ngọt ngào nhưng lại phảng phất nỗi buồn, về một người cha bệnh tật trốn nhà vì không muốn làm khổ vợ con, về một người cha khác giả làm vua bởi đứa con tâm thầm của ông luôn nghĩ mình là công chúa, Những bài học về luân lý, về tình người trở đi trở lại trong day dứt và tiếc nuối.<br>		    		Tôi Thấy Hoa Vàng Trên Cỏ Xanh lắng đọng nhẹ nhàng trong tâm tưởng để rồi ai đã lỡ đọc rồi mà muốn quên đi thì thật khó.<br>		    		 <br>		    		“Tôi thấy hoa vàng trên cỏ xanh” truyện dài mới nhất của nhà văn vừa nhận giải văn chương ASEAN Nguyễn Nhật Ánh - đã được Nhà xuất bản Trẻ mua tác quyền và giới thiệu đến độc giả cả nước.<br>		    		Cuốn sách viết về tuổi thơ nghèo khó ở một làng quê, bên cạnh đề tài tình yêu quen thuộc, lần đầu tiên Nguyễn Nhật Ánh đưa vào tác phẩm của mình những nhân vật phản diện và đặt ra vấn đề đạo đức như sự vô tâm, cái ác. 81 chương ngắn là 81 câu chuyện nhỏ của những đứa trẻ xảy ra ở một ngôi làng: chuyện về con cóc Cậu trời, chuyện ma, chuyện công chúa và hoàng tử, bên cạnh chuyện đói ăn, cháy nhà, lụt lội, “Tôi thấy hoa vàng trên cỏ xanh”hứa hẹn đem đến những điều thú vị với cả bạn đọc nhỏ tuổi và người lớn bằng giọng văn trong sáng, hồn nhiên, giản dị của trẻ con cùng nhiều tình tiết thú vị, bất ngờ và cảm động trong suốt hơn 300 trang sách. Cuốn sách, vì thế có sức ám ảnh, thu hút, hấp dẫn không thể bỏ qua.", "Tôi Thấy Hoa Vàng Trên Cỏ Xanh", 378, 62000.0, 12, 2018, "NXBT", "toi-thay-hoa-vang-tren-co-xanh", null, new DateTime(2020, 10, 19, 2, 19, 0, 0, DateTimeKind.Unspecified) },
                    { "S020", "A014", "VHVN", new DateTime(2020, 5, 19, 22, 14, 0, 0, DateTimeKind.Unspecified), null, "Mở đầu là kỳ nghỉ hè tại một ngôi làng thơ mộng ven sông với nhân vật là những đứa trẻ mới lớn có vô vàn trò chơi đơn sơ hấp dẫn ghi dấu mãi trong lòng.   Mối tình đầu trong veo của cô bé Rùa và chàng sinh viên quê học ở thành phố có giống tình đầu của bạn thời đi học? Và cái cách họ thương nhau giấu giếm, không dám làm nhau buồn, khát khao hạnh phúc đến nghẹt thở có phải là câu chuyện chính?<br>		    		\"Nồng nàn lên với<br>		    		Cốc rượu trên tay<br>		    		Xanh xanh lên với<br>		    		Trời cao ngàn ngày<br>		    		Dài nhanh lên với<br>		    		Tóc xõa ngang mày<br>		    		Lớn nhanh lên với<br>		    		Bé bỏng chiều nay”<br>		    		Bạn sẽ được tác giả dẫn đi liền một mạch trong một thứ cảm xúc rưng rưng của tình yêu thương. Bạn sẽ thấy may mắn vì đang đuợc sống trong cuộc sống này, thấy yêu thế những tấm tình người… tất cả đều đẹp hồn hậu một cách giản dị.<br>		    		Với cuốn sách này, một lần nữa người đọc lại được Nguyễn Nhật Ánh tặng món quà quý giá: lòng tin vào điều tốt có thật trên đời.", "Ngồi Khóc Trên Cây", 342, 63000.0, 8, 2017, "NXBT", "ngoi-khoc-tren-cay", null, new DateTime(2020, 10, 20, 10, 40, 0, 0, DateTimeKind.Unspecified) },
                    { "S019", "A014", "VHVN", new DateTime(2020, 5, 19, 22, 14, 0, 0, DateTimeKind.Unspecified), null, "Mở cuốn sách mới của tác giả Nguyễn Nhật Ánh, bạn sẽ gặp những cái tên quen thuộc của những người nổi tiếng ngay trang 5 trang trọng đề tặng “các bạn văn hữu”: nhà thơ Bùi Chí Vinh, Phạm Sỹ Sáu, Lê Minh Quốc, nhà văn Nguyễn Đông Thức, nhà phê bình Huỳnh Như Phương, nhà báo Nguyễn Công Khế, Kim Hạnh, … Tuổi niên thiếu của “những thằng quỷ nhỏ” trong truyện có gắn gì với họ không, có phải là họ không, chỉ họ và tác giả mới biết, nhưng bạn đọc thì có thể tưởng tượng ra một nhóm “thằng” thân thiết, bắt đầu lớn, biết thinh thích con gái và ngập mộng văn chương.<br>		    		Chuyện của bút nhóm học trò, truyện nằm trong truyện, những cơn giận dỗi ghen tuông bạn gái bạn trai với nhau, nhiều nhất vẫn là chuyện nhà trường có các cô giáo hơn trò vài tuổi coi trò như bạn, có thầy hiệu trưởng tâm lý và yêu thương học trò coi trò như con…Trở lại với đề tài học trò, hóm hỉnh và gần gũi như chính các em, Nguyễn Nhật Ánh chắc chắn sẽ được các bạn trẻ vui mừng đón nhận. Cứ lật đằng cuối sách, đọc bài thơ tình trong veo là có thể thấy điều đó “…Khi mùa xuân đến / Tình anh lại đầy / Lá nằm trong lá / Tay nằm trong tay”.<br>		    		“Viết cho trẻ con giờ khó hơn xưa. Có hàng bao nhiêu là món giải trí rầm rộ, hoành tráng và lộng lẫy dọn sẵn, muốn thu phục “lũ tiểu yêu” thế kỷ 21 này, nhà văn không chỉ thông thuộc mặt bằng hiểu biết của chúng, mà còn phải tâm tình được với chúng bằng tốc độ của chúng. Có thể nói Nguyễn Nhật Ánh là một người lớn chấp nhận tham dự món du hành tốc độ cao cùng lũ trẻ. Thời thong thả đạp xe, từ tốn khuyên bảo đã qua rồi. Thực ra Nguyễn Nhật Ánh đã biết đi tàu tốc hành từ hai thập niên trước, khi nhữngKính vạn hoa, Thằng quỷ nhỏ, Bàn có năm chỗ ngồi… đem lại cho văn học thiếu nhi một diện mạo mới mẻ, những câu chuyện tưởng như ấm ớ ngày này qua tháng khác nhưng sao hôm nay nhìn lại, những người đã từng là trẻ con thấy nhớ quá..” (VIỆT TRUNG, báo Thanh Niên).<br>		    		“Bước vào khoảng trời của tuổi biết buồn, Nguyễn Nhật Ánh đã ghi lại những bâng khuâng rung cảm đầu đời. Trong tâm tưởng của các em, bây giờ không chỉ nghĩ về cái gì mà còn nghĩ về ai, về một người khác giới cụ thể nào, và về cả bản thân, thế giới ấy tràn ngập những câu hỏi xôn xao về cái-gọi-là-tình-yêu. Truyện của Nguyễn Nhật Ánh đã đưa vào những câu hỏi lớn, muôn thuở, quen thuộc - những câu hỏi mà dường như trong đời ai cũng từng đối diện ít nhất một lần. Vì thế, trong khi độc giả thiếu niên phục lăn vì nhà văn đi guốc vào bụng họ, thì độc giả người lớn mỉm cười mơ màng nhớ lại một thời thơ dại...\" (TS. NGUYỄN THỊ THANH XUÂN, nhà nghiên cứu văn học).", "Lá Nằm Trong Lá", 252, 45000.0, 2, 2017, "NXBT", "la-nam-trong-la", null, new DateTime(2020, 10, 19, 2, 18, 0, 0, DateTimeKind.Unspecified) },
                    { "S009", "A006", "KHCN", new DateTime(2020, 5, 19, 5, 12, 0, 0, DateTimeKind.Unspecified), null, "Lược Sử Thời Gian<br>		    		Cùng với Vũ trụ trong vỏ hạt dẻ, Lược sử thời gian được xem là cuốn sách nổi tiếng và phổ biến nhất về vũ trụ học của Stephen Hawking, liên tục được nằm trong danh mục sách bán chạy nhất của các tạp chí nổi tiếng thế giới.Lược sử thời gian là cuốn sử thi về sự ra đời, sự hình thành và phát triển của vũ trụ. Tác giả đưa vào tác phẩm của mình toàn bộ tiến bộ tiến trình khám phá của trí tuệ loài người trên nhiều lĩnh vực: Triết học, Vật lý, Thiên văn học…<br>		    		Chúng ta sống cuộc sống hàng ngày của chúng ta mà hầu như không hiểu được về thế giới chung quanh. Chúng ta cũng ít khi suy ngẫm về cơ chế đã tạo ra ánh sáng Mặt trời - một yếu tố quan trọng góp phần tạo nên sự sống, về hấp dẫn – cái chất keo đã kết dính chúng ta vào Trái đất mà nếu khác đi chúng ta sẽ xoay tít và trôi dạt vào không gian vũ trụ, về nguyên tử đã cấu tạo nên tất cả chúng ta và chúng ta hoàn toàn lệ thuộc vào sự bền vững của chúng. Chỉ trừ có trẻ em (vì chúng còn biết quá ít để không ngần ngại đặt ra những câu hỏi quan trọng) còn ít ai trong chúng ta tốn thời gian để băn khoăn tại sao tự nhiên lại như thế này mà không như thế khác, vũ trụ ra đời từ đâu, hoặc nó có mãi mãi như thế này không, liệu có một ngày nào đó thời gian sẽ trôi giật lùi, hậu quả có trước nguyên nhân hay không; hoặc có giới hạn cuối cùng cho sự hiểu biết của con người hay không. Thậm chí có những đứa trẻ con, mà tôi có gặp một số, muốn biết lỗ đen là cái gì; cái gì là hạt vật chất nhỏ bé nhất, tại sao chúng ta chỉ nhớ quá khứ mà không nhớ tương lai; và nếu lúc bắt đầu là hỗn loạn thì làm thế nào có sự trật tự như ta thấy hôm nay và tại sao lại có vũ trụ.<br>		    		Trong xã hội chúng ta các bậc phụ huynh cũng như các thầy giáo vẫn còn thói quen trả lời những câu hỏi đó bằng cách nhún vai hoặc viện đến các giáo lý mơ hồ. Một số các giáo lý ấy lại hoàn toàn không thích hợp với những vấn đề vừa nêu ở trên, bởi vì chúng phơi bày quá rõ những hạn chế sự hiểu biết của con người.<br>		    		Hiện nay, Hawking là giáo sư toán học của trường Đại học Cambridge, với cương vị mà trước đây Newton, rồi sau này P.A.M Dirac - hai nhà nghiên cứu nổi tiếng về những cái cực lớn và những cái cực nhỏ - đảm nhiệm. Hawking là người kế tục hết sức xứng đáng của họ. Cuốn sách đầu tiên của Hawking dành cho những người không phải là chuyên gia này có thể xem là một phần thưởng về nhiều mặt cho công chúng không chuyên. Cuốn sách vừa hấp dẫn bởi nội dung phong phú của nó vừa bởi nó cho chúng ta một cái nhìn khái quát qua công trình của chính tác giả cuốn sách này. Cuốn sách chứa đựng những khám phá trên những ranh giới của vật lý học, thiên văn học, vũ trụ học và của cả lòng dũng cảm nữa.<br>		    		Đây cũng là cuốn sách về Thượng đế hay đúng hơn là về sự không có mặt của Thượng đế. Chữ Thượng đế xuất hiện trên nhiều trang của cuốn sách này. Hawking đã dấn thân đi tìm câu trả lời cho câu hỏi nổi tiếng của Einstein: liệu Thượng đế có sự lựa chọn nào trong việc tạo ra vũ trụ này hay không? Hawking đã nhiều lần tuyên bố một cách công khai rằng ông có ý định tìm hiểu ý nghĩa của Thượng đế. Và từ nỗ lực đó, ông đã rút ra một kết luận bất ngờ nhất, ít nhất là cho đến hiện nay, đó là vũ trụ không có biên trong không gian, không có bắt đầu và kết thúc trong thời gian và chẳng có việc gì cho Đấng sáng thế phải làm ở đây cả. - CARL SAGA.", "Lược Sử Thời Gian", 284, 87000.0, 12, 2016, "NXBT", "luoc-su-thoi-gian", null, new DateTime(2020, 10, 19, 23, 20, 0, 0, DateTimeKind.Unspecified) },
                    { "S007", "A006", "KHCN", new DateTime(2020, 5, 19, 5, 12, 0, 0, DateTimeKind.Unspecified), null, "Lòng khát khao khám phá luôn là động lực cho trí sáng tạo của con người trong mọi lĩnh vực không chỉ trong khoa học. Điều đó được kiểm chứng trong quyển Vũ trụ trong vỏ hạt dẻ.", "Vũ Trụ Trong Vỏ Hạt Dẻ", null, 59000.0, 3, 2018, "NXBT", "vu-tru-trong-vo-hat-de", null, new DateTime(2020, 10, 19, 2, 11, 0, 0, DateTimeKind.Unspecified) },
                    { "S006", "A006", "KHCN", new DateTime(2020, 5, 19, 5, 12, 0, 0, DateTimeKind.Unspecified), null, "Lỗ Đen: Các Bài Diễn Thuyết Trên Đài<br>		    		Sách tập hợp hai bài nói chuyện của nhà vật lý vĩ đại Stephen Hawking trên BBC vào đầu năm 2016. Trong loạt bài giảng trên BBC này, tác giả đã dựng lên thách đố phải tóm lược câu chuyện cả một đời bên trong lỗ đen chỉ trong hai cuộc trò chuyện mười lăm phút.<br>		    		Đóng góp độc đáo của Stephen Hawking cho nghiên cứu khoa học là dựng lên những phương thức tiếp cận các vấn đề chuyên môn rất đa dạng: nổi tiếng nhất, ông là người đầu tiên đã khảo sát vũ trụ rộng lớn bằng những kỹ thuật khoa học lập ra để nghiên cứu những hạt nhỏ bé bên trong nguyên tử. Các đồng nghiệp của ông trong lĩnh vực cực kỳ phức tạp này có thể lo lắng rằng công trình của họ sẽ chẳng bao giờ trình bày được để công chúng dễ hiểu. Vậy mà việc hướng đến một công chúng rộng rãi hơn lại là một biệt tài của Hawking. Để thêm phần dễ tiếp cận đối với những ai hiếu kỳ nhưng rối trí, bị mê hoặc bởi ý tưởng nhưng lúng túng về mặt khoa học, sách có phần giới thiệu và ghi chú thêm ở các điểm mấu chốt của David Shukman - biên tập viên khoa học của BBC News.", "Lỗ Đen: Các Bài Diễn Thuyết Trên Đài", 76, 35000.0, 1, 2017, "NXBT", "lo-den-cac-bai-dien-thuyet-tren-dai", null, new DateTime(2020, 10, 20, 0, 5, 0, 0, DateTimeKind.Unspecified) },
                    { "S054", "A045", "STN", new DateTime(2020, 5, 20, 5, 2, 0, 0, DateTimeKind.Unspecified), null, "Sự tích các loài vật - Chuyện như thế đó là tác phẩm viết cho trẻ em của Rudyard Kipling (1865 - 1936), nhà văn Anh đoạt Giải thưởng Nobel Văn học năm 1907.<br>		    		Cuốn sách sẽ dẫn dắt các bạn, dù ở bất cứ tuổi nào, đến với một khung cảnh khác lạ, không xác định thời gian và không gian. Bằng trí tưởng tượng và tài năng xuất chúng, Rudyard Kipling đã mở ra một thế giới nhiệm màu với những chú lạc đà không mang bướu trên lưng, những chú Kăng-gu-ru chạy miệt mài bởi lúc nào cũng bị chó Dingo rượt đuổi…", "Sự Tích Loài Vật - Chuyện Như Thế Đó", 110, 84000.0, 6, 2017, "KD", "su-tich-loai-vat-chuyen-nhu-the-do", null, new DateTime(2020, 10, 19, 2, 40, 0, 0, DateTimeKind.Unspecified) },
                    { "S053", "A044", "STN", new DateTime(2020, 5, 20, 5, 0, 0, 0, DateTimeKind.Unspecified), null, "Với các bậc cha mẹ muốn tự dạy tiếng Anh cho con ở nhà nhưng đang bối rối chưa biết bắt đầu từ đâu, cuốn sách Doraemon - Gia sư tiếng Anh chính là \"bảo bối\" cho cả nhà.<br>		    		Xuyên suốt cuốn sách là hơn 1500 từ vựng và mẫu câu cơ bản được trình bày khoa học, sinh động, với minh hoạ là chính các nhân vật quen thuộc, dễ thương Doraemon, Nobita, Shizuka, Jaian, Suneo...<br>		    		Bố mẹ có thể dễ dàng hướng dẫn các con học hoặc để các em tự tìm hiểu. Chúc cả nhà có những giờ học tiếng Anh thú vị với Doreamon!", "Doraemon - Gia Sư Tiếng Anh", 150, 40000.0, 9, 2015, "KD", "doraemon-gia-su-tieng-anh", null, new DateTime(2020, 10, 19, 2, 40, 0, 0, DateTimeKind.Unspecified) },
                    { "S030", "A016", "VHVN", new DateTime(2020, 5, 20, 0, 58, 0, 0, DateTimeKind.Unspecified), null, "Bên bến nước, dưới mái đình, trong ngôi làng, những người nông dân tài hoa với tình người chân thành, ấm áp. Không chỉ là chuyện kể về cuộc sống tại một ngôi làng nghề truyền thống, về những người thôn quê, về cô Sao có tài vẽ hoa lá lên đồ gốm và anh Tạ, thợ đấu đất chăm chỉ, “Truyện một cái thuyền đất” còn bồi đắp thêm cho bạn đọc tình mến thương làng quê và niềm trân trọng thành quả lao động…<br>		    		Được viết từ năm 1958 - đây là món quà đặc biệt của nhà văn Nguyễn Tuân dành tặng riêng cho bạn đọc thiếu nhi…", "Truyện Một Cái Thuyền Đất", 80, 18000.0, 5, 2017, "KD", "truyen-mot-cai-thuyen-dat", "A011", new DateTime(2020, 10, 19, 2, 24, 0, 0, DateTimeKind.Unspecified) },
                    { "S010", "A007", "STN", new DateTime(2020, 5, 19, 7, 15, 0, 0, DateTimeKind.Unspecified), null, "Ấn bản minh họa màu đặc biệt của Dế Mèn phiêu lưu ký, với phần tranh ruột được in hai màu xanh - đen ấn tượng, gợi không khí đồng thoại.<br>		    		“Một con dế đã từ tay ông thả ra chu du thế giới tìm những điều tốt đẹp cho loài người. Và con dế ấy đã mang tên tuổi ông đi cùng trên những chặng đường phiêu lưu đến với cộng đồng những con vật trong văn học thế giới, đến với những xứ sở thiên nhiên và văn hóa của các quốc gia khác. Dế Mèn Tô Hoài đã lại sinh ra Tô Hoài Dế Mèn, một nhà văn trẻ mãi không già trong văn chươ” - Nhà phê bình Phạm Xuân Nguyên<br>		    		“Ông rất hiểu tư duy trẻ thơ, kể với chúng theo cách nghĩ của chúng, lí giải sự vật theo lô gích của trẻ. Hơn thế, với biệt tài miêu tả loài vật, Tô Hoài dựng lên một thế giới gần gũi với trẻ thơ. Khi cần, ông biết đem vào chất du ký khiến cho độc giả nhỏ tuổi vừa hồi hộp theo dõi, vừa thích thú khám phá.” - TS Nguyễn Đăng Điệp", "Dế Mèn Phiêu Lưu Ký", 144, 35000.0, 1, 2019, "KD", "de-men-phieu-luu-ky", null, new DateTime(2020, 10, 20, 5, 18, 0, 0, DateTimeKind.Unspecified) },
                    { "S008", "A006", "STN", new DateTime(2020, 5, 19, 5, 12, 0, 0, DateTimeKind.Unspecified), null, "Chuyện Kể Về Danh Nhân Thế Giới - Stephen Hawking<br>		    		Khi bác sĩ kết luận rằng Stephen King chỉ có thể sống thêm ba năm nữa do mắc bệnh xơ cứng cột bên teo cơ, tất cả mọi người đều nghĩ rằng ông không thể làm được gì nữa. Thế nhưng trong suốt 30 năm sau đó, Stephen King đã trở thành nhà vật lý hàng đầu thế giới.", "Chuyện Kể Về Danh Nhân Thế Giới - Stephen Hawking", null, 50000.0, 4, 2014, "KD", "chuyen-ke-ve-danh-nhan-the-gioi-stephen-hawking", null, new DateTime(2020, 10, 20, 22, 8, 0, 0, DateTimeKind.Unspecified) },
                    { "S055", "A046", "STN", new DateTime(2020, 7, 4, 0, 41, 0, 0, DateTimeKind.Unspecified), null, "Cô hải âu Kengah bị nhấn chìm trong váng dầu – thứ chất thải nguy hiểm mà những con người xấu xa bí mật đổ ra đại dương. Với nỗ lực đầy tuyệt vọng, cô bay vào bến cảng Hamburg và rơi xuống ban công của con mèo mun, to đùng, mập ú Zorba. Trong phút cuối cuộc đời, cô sinh ra một quả trứng và con mèo mun hứa với cô sẽ thực hiện ba lời hứa chừng như không tưởng với loài mèo:<br>		    	Không ăn quả trứng.<br>		    	Chăm sóc cho tới khi nó nở.<br>		    	Dạy cho con hải âu bay.<br>		    	Lời hứa của một con mèo cũng là trách nhiệm của toàn bộ mèo trên bến cảng, bởi vậy bè bạn của Zorba bao gồm ngài mèo Đại Tá đầy uy tín, mèo Secretario nhanh nhảu, mèo Einstein uyên bác, mèo Bốn Biển đầy kinh nghiệm đã chung sức giúp nó hoàn thành trách nhiệm. Tuy nhiên, việc chăm sóc, dạy dỗ một con hải âu đâu phải chuyện đùa, sẽ có hàng trăm rắc rối nảy sinh và cần có những kế hoạch đầy linh hoạt được bàn bạc kỹ càng…<br>		    	Chuyện con mèo dạy hải âu bay là kiệt tác dành cho thiếu nhi của nhà văn Chi Lê nổi tiếng Luis Sepúlveda – tác giả của cuốn Lão già mê đọc truyện tình đã bán được 18 triệu bản khắp thế giới. Tác phẩm không chỉ là một câu chuyện ấm áp, trong sáng, dễ thương về loài vật mà còn chuyển tải thông điệp về trách nhiệm với môi trường, về sự sẻ chia và yêu thương cũng như ý nghĩa của những nỗ lực – “Chỉ những kẻ dám mới có thể bay”.<br>		    	Cuốn sách mở đầu cho mùa hè với minh họa dễ thương, hài hước là món quà dành cho mọi trẻ em và người lớn.", "Chuyện Con Mèo Dạy Hải Âu Bay", 144, 37000.0, 6, 2019, "HNV", "chuyen-con-meo-day-hai-au-bay", null, new DateTime(2020, 10, 19, 2, 40, 0, 0, DateTimeKind.Unspecified) },
                    { "S045", "A033", "VHVN", new DateTime(2020, 5, 20, 1, 47, 0, 0, DateTimeKind.Unspecified), null, "Quá trẻ để chết: Hành trình nước Mỹ là hành trình đơn độc của tác giả - một cô gái Việt trẻ đi xuyên nước Mỹ từ Bờ Đông sang bờ Tây. Hành trình du lịch bụi của cô trải dài trên 20 bang, kéo dài suốt sáu tháng liên tiếp.<br>		    		Đó là chuyến đi để khám phá thế giới bên trong của những người Mỹ bình thường, dù có thể chỉ là một phần của thế giới ấy. Đó cũng là hành trình khám phá những vẻ đẹp muôn màu muôn vẻ của thế giới - của thiên nhiên nước Mỹ, và của tâm hồn con người trong những hình thức thăng hoa khác nhau của nó.<br>		    		Nhưng hành trình xuyên qua nước Mỹ này không chỉ là để khám phá một phần thế giới bên ngoài mà còn là để tìm trở lại một phần trọng yếu của bản thân cô gái: tình yêu đối với chính mình và cuộc đời mình, cái tình yêu mà cô đã có lúc đánh mất. Xuất phát điểm của “Quá trẻ để chết: Hành trình nước Mỹ” là một tình yêu tan vỡ, một nỗi đau đớn vì tình, lớn đến độ khiến tác giả có lúc đã gần kề cái chỗ đâm đầu vào tàu điện ngầm tự sát, một kết cục khiến ta không khỏi nghĩ tới Anna Karenina.<br>		    		Đinh Hằng, tác giả, xuất hiện trong cuốn sách như một phụ nữ mạnh mẽ, đầy cá tính và sức mạnh bên trong, tự tin ngẩng cao đầu bước giữa thế giới, hoàn toàn không có một mặc cảm nào bất kể căn nguyên của nó là gì.<br>		    		Chuyến đi của Đinh Hằng, rốt cuộc, là một cuộc hành trình đi tìm lại và nhìn nhận lại giá trị của bản thân mình, của sự sống. Nước Mỹ, với tất cả những vẻ đẹp cùng sự đa dạng và phức tạp của nó, ở đây đóng vai trò như một chốn “luyện ngục” để cô vượt qua chính mình và trở nên một người khác. Một cuộc đi lớn chỉ dành cho những người thực sự muốn lớn hơn bản thân mình ngày hôm qua.<br>		    		Cách Đinh Hằng đi và hòa mình vào văn hóa Mỹ không phải là cái nhìn của công dân một nước đang phát triển lần đầu đến với xứ cờ hoa, choáng ngợp với nước Mỹ to lớn hiện đại và thấy mình sao mà nhỏ bé đơn độc. Ngược lại, đó là cái nhìn của một người lữ hành đã dày dạn kinh nghiệm, nhìn một xứ sở mới, những con người mới với cái nhìn bình đẳng, điềm nhiên và không định kiến. Đinh Hằng xem nước Mỹ và người Mỹ với tâm thế tôn trọng và bình đẳng, như một kẻ biết người rất giỏi nhưng cũng hiểu rõ những giá trị của bản thân.<br>		    		Cũng chính vì vậy mà nước Mỹ và người Mỹ hiện ra trong sách rất thực và rất đời, không tô hồng, không phóng đại. Một nước Mỹ không chỉ với các tòa nhà chọc trời, với sự phát triển vượt bậc và các công nghệ hiện đại. Mà là một nước Mỹ chân thực và trần trụi với những vấn đề của nó, nền văn hóa Mỹ, cách sống của người Mỹ, quan niệm của họ về bản thân, về tình yêu, và kể cả những vấn đề khá nhạy cảm với người Việt như tình một đêm, đồng tính, cỏ và ma túy...<br>		    		Quá trẻ để chết: Hành trình nước Mỹ không đơn thuần là một cuốn sách du ký. Bởi trên hành trình đơn độc xuyên qua nước Mỹ, những xung đột tâm lý của cô gái bị bỏ lại trước ngưỡng cửa hôn nhân cũng hiện lên sâu sắc. Đó là câu chuyện của sự đan xen mãnh liệt những cô đơn, đau đớn, niềm tin, khát vọng, đam mê, tuổi trẻ. Cô gái nhân vật chính dám nghỉ việc, trả nhà, bay nửa vòng Trái Đất và quăng mình vào một hành trình không đích đến để đối mặt với người mình đã từng yêu một lần nữa. Hành trình địa lý cũng chính là hành trình tâm lý ấy đánh thức trong mỗi người trẻ tuổi bản năng yêu, đi và sống hết mình.<br>		    		Xem review sách: Quá trẻ để chết – Hành trình nước Mỹ<br>		    		Nhận định<br>		    		\"...Tuổi trẻ luôn là một lợi thế và những lí do để dẫn đến một chuyến đi, nhất là đối với một người phụ nữ đi một mình thì chắc chắn là rất nhiều. Một cuộc tình đổ vỡ, một biến cố khác nào đó trong đời thôi thúc những phụ nữ như thế lên đường và sự đơn độc tạo cho họ sức mạnh để hướng về phía trước, trong một hành trình chất chứa nhiều tâm sự.<br>		    		Nước Mỹ hiện ra một cách dung dị và cả gai góc qua những câu chữ của Đinh Hằng, trong hành trình \"Couch Surfing\". Những hành trình lớn cần những trái tim dũng cảm. Không chỉ dũng cảm đương đầu với những rủi ro có thể ập đến, mà dũng cảm khi biết cách đối diện với chính mình.<br>		    		(Trương Anh Ngọc, tác giả \"Nước Ý, câu chuyện tình của tôi\"  và \"Phút 90++\")<br>		    		\"Khó mà hình dung Đinh Hằng là cô như bây giờ nếu cô đã không đủ can đảm thực hiện chuyến đi ấy và sẵn sàng đối mặt với những gì chưa biết đang chờ đợi phía trước. Một cuộc đi lớn chỉ dành cho những người thực sự muốn lớn hơn bản thân mình ngày hôm qua.\"<br>		    		(Trần Tiễn Cao Đăng, nhà văn, dịch giả)<br>		    		\"Quá trẻ để chết: hành trình nước Mỹ\" là câu chuyện về tuổi trẻ lộng lẫy, đầy đam mê và dám sống. Bởi, khi còn trẻ, người ta có rất nhiều thời gian và cơ hội để sống, thử, sai lầm, học hỏi và lớn lên từ sai lầm đó. Đây là cuốn sách nên đọc nếu bạn còn trẻ, đam mê những con đường và trước bao nhiêu sóng gió cuộc đời bạn vẫn ngẩng cao đầu tiến về phía trước.<br>		    		(Nguyễn Lê My Hoàn, nhà văn, dịch giả, tác giả “Lối đi ngay dưới chân mình\")", "Quá Trẻ Để Chết: Hành Trình Nước Mỹ", null, 62000.0, 4, 2015, "HNV", "qua-tre-de-chet-hanh-trinh-nuoc-my", null, new DateTime(2020, 10, 19, 2, 38, 0, 0, DateTimeKind.Unspecified) },
                    { "S039", "A024", "VHNN", new DateTime(2020, 5, 20, 1, 26, 0, 0, DateTimeKind.Unspecified), null, "Được xem là một trong những sự kiện văn chương được chờ đợi nhất, Hannibal mang người đọc vào cung điện ký ức của một kẻ ăn thịt người, tạo dựng nên một bức chân dung ớn lạnh của tội ác đang âm thầm sinh sôi - một thành công của thể loại kinh dị tâm lý.<br>		    	Với Mason Verger, nạn nhân đã bị Hannibal biến thành kẻ người không ra người, Hannibal là mối hận thù nhức nhối da thịt.<br>		    	Với đặc vụ Clarice Starling của FBI, người từng thẩm vấn Hannibal trong trại tâm thần, giọng kim ken két của hắn vẫn vang vọng trong giấc mơ cô.<br>		    	Với cảnh sát Rinaldo Pazzi đang thất thế, Lecter hứa hẹn mang tới một khoản tiền béo bở để đổi vận.<br>		    	Và những cuộc săn lùng Hannibal Lecter bắt đầu, kéo theo đó là những chuỗi ngày run rẩy hòng chấm dứt bảy năm tự do của hắn. Nhưng trong ba kẻ đi săn, chỉ một kẻ có bản lĩnh sống trụ lại để hưởng thành quả của mình.", "Hannibal", 432, 90000.0, 5, 2018, "HNV", "hannibal", "A027", new DateTime(2020, 10, 21, 8, 20, 0, 0, DateTimeKind.Unspecified) },
                    { "S027", "A015", "TD-KNS", new DateTime(2020, 5, 19, 23, 40, 0, 0, DateTimeKind.Unspecified), null, "Không ai qua sông - Tập truyện ngắn mới nhất của Nguyễn Ngọc Tư gợi bạn đọc nhớ đến đến truyện dài Cánh đồng bất tận đã từng gây xôn xao trên văn đàn một thời gian dài. Cũng lấy cảm hứng từ cuộc sống của người dân nông thôn miền Tây, nhưng giờ đây nhân vật của NNT có cái trăn trở của một vùng đất đã dần bị đô thị hóa, con người phải thích ứng với những thứ nhân danh cuộc sống hiện đại nhưng có thể phá nát những rường mối gia đình.<br>		    		Đặc biệt, truyện vừa Đất dữ dội và khốc liệt, ngồn ngộn hiện thực cuộc sống, có mất mát, có phản bội, có đắng", "Không Ai Qua Sông", 160, 55000.0, 1, 2016, "NXBT", "khong-ai-qua-song", null, new DateTime(2020, 10, 19, 2, 21, 0, 0, DateTimeKind.Unspecified) },
                    { "S028", "A015", "TD-KNS", new DateTime(2020, 5, 19, 23, 40, 0, 0, DateTimeKind.Unspecified), null, "Tập tản văn mới của Nguyễn Ngọc Tư gửi gắm vui buồn, âu lo không chỉ về thân phận người nông dân miền Tây, mà còn về bản sắc văn hóa, lịch sử, cội nguồn một vùng đất<br>		    		Nguyễn Ngọc Tư luôn là một cây bút chắc tay khi viết về con người, đời sống sinh hoạt miệt vườn. Chị tận dụng triệt để tâm hồn nhạy cảm vốn có cùng cơ hội được đắm mình trong không gian miền quê để lẩy ra những câu chuyện kể. Cảnh sinh hoạt ấy trong trang viết Nguyễn Ngọc Tư hiện lên vừa yên tĩnh, thanh bình mà cũng vừa dậy sóng, đầy ắp những đổi thay.<br>		    		Trong bức tranh đồng quê có người già, trẻ nhỏ, có những thanh niên trai tráng, có con xóm nhỏ với rặng hoa dâm bụt, những chiếc ghe vất vả ngược xuôi mùa gió chướng, có mùa lụt nước về hay những câu chuyện ma mị dọc đường gió bụi giang hồ của miền Tây xa thẳm.<br>		    		Nhưng Nguyễn Ngọc Tư không chỉ nói về con người miền Tây sống gần với ruộng vườn, sông nước, với thiên nhiên bằng tâm hồn cởi mở, phóng khoáng, nghĩa khí, hào hiệp. Chị gần gũi với họ đủ để lẩy ra được cả những cái nhìn phản biện về tính cách nông dân. Những đặc tính của thói quen “sống hôm nay chẳng cần biết đến ngày mai”, tính “chịu chơi, xả láng” của người nông dân miệt vườn được chị phác lại với giọng văn tưởng như nhẹ nhàng nhưng ẩn trong đấy là một sự rưng rưng thương cảm. “… Người đàn bà kéo cá dưới ao lên đãi khách cho chồng, rồi bưng tô cơm nguội ăn với muối tiêu” (bài “người nơi biên giới”). Hay câu chuyện người ta bày đặt đổi vợ đổi chồng cho nhau trong “Miền Tây không có gì lạ”, bởi theo chị ở miền Tây, không có chuyện gì là không thể xảy ra.", "Đong Tấm Lòng", 146, 64000.0, 4, 2019, "NXBT", "dong-tam-long", null, new DateTime(2020, 10, 19, 2, 23, 0, 0, DateTimeKind.Unspecified) },
                    { "S040", "A023", "STN", new DateTime(2020, 5, 20, 1, 26, 0, 0, DateTimeKind.Unspecified), null, "Sir Arthur Conan Doyle (1859 – 1930) là một nhà văn người Scotland nổi tiếng với tiểu thuyết trinh thám Sherlock Holmes, các truyện về Giáo sư Challenger và nhiều tác phẩm khác.<br>		    	Thuộc Tủ sách Danh Tác Rút Gọn, Thế giới thất lạc xoay quanh việc giáo sư George Challenger tình cờ phát hiện được dấu tích còn sống sót của loài khủng long trong một khu rừng nguyên sinh chưa được khai phá ở Nam Mỹ. Khi trở về, ông muốn mở một cuộc hành trình vào sâu trong rừng hơn để chứng minh là một số loài khủng long vẫn còn sống. Nhiều người phản đối, nhưng cuối cùng vẫn có những người thích phiêu lưu mạo hiểm ủng hộ ông. Cuộc thám hiểm diễn ra trong khu rừng nguy hiểm chưa hề có tên trên bản đồ thế giới, và cuộc đấu tranh sinh tồn của đoàn thám hiểm bắt đầu. Họ phải chiến đấu để thoát chết và nhất là với hy vọng thoát khỏi thế giới bị lãng quên này để trở về nhà…", "Danh Tác Rút Gọn - Thế Giới Thất Lạc", 124, 38000.0, 1, 2019, "NXBT", "danh-tac-rut-gon-the-gioi-that-lac", null, new DateTime(2020, 10, 19, 2, 37, 0, 0, DateTimeKind.Unspecified) },
                    { "S041", "A032", "VHNN", new DateTime(2020, 5, 20, 1, 47, 0, 0, DateTimeKind.Unspecified), null, "Tập truyện tâm lý xã hội xoay quanh số phận con người khi đứng trước những lựa chọn éo le, nhất là khi ảnh hưởng đến những người thân yêu nhất. Cuộc đời cặp vợ chồng cô đơn canh hải đăng trên hòn đảo trơ trọi đột nhiên biến đổi khi ngày nọ chiếc thuyền dạt vào mang theo đứa bé gái còn sơ sinh.<br>		    		Nhưng liệu có công bằng không khi họ vì niềm vui riêng này mà không nỗ lực tìm kiếm cha mẹ ruột đứa bé. Cha mẹ ruột, cha mẹ nuôi, gia đình của họ, và chính cả đứa bé, mỗi người đều mang một nỗi đau riêng trong khi tưởng chừng có được hạnh phúc.", "Ánh Đèn Giữa Hai Đại Dương", 485, 115000.0, 2, 2016, "NXBT", "anh-den-giua-hai-dai-duong", null, new DateTime(2020, 10, 19, 2, 37, 0, 0, DateTimeKind.Unspecified) },
                    { "S043", "A029", "VHNN", new DateTime(2020, 5, 20, 1, 47, 0, 0, DateTimeKind.Unspecified), null, "Không Gia Đình là cuốn sách được xếp vào danh mục văn học thiếu nhi nhưng rõ ràng, với những gì Không Gia Đình đã kể thì đây là cuốn sách dành cho mọi lứa tuổi ở mọi quốc gia, mọi tầng lớp.<br>		    		Không Gia Đình là một chuyến phiêu lưu mà Rêmi là nhân vật chính. Em nghèo khổ, em cô độc, em không có người thân. Cuộc đời Rêmi gắn liền với gánh xiếc rong, với những thử thách mà em gặp phải trên đường đời trải rộng khắp nước Pháp tươi đẹp. Rêmi lớn lên trong đau khổ, lang thang mọi nơi, bị tù đày... nhưng dù trong hoàn cảnh nào, em vẫn đứng thẳng lưng, ngẩng cao đầu, giữ phẩm chất làm người - điều em đã học từ cụ Vitali trong cuộc đời lang bạt của mình.<br>		    		Không Gia Đình ca ngợi giá trị của lao động, của nhân cách và tình cảm. Cuốn sách mô tả những hình ảnh, những mảnh đời bấp bênh để làm nền cho niềm tin, cho tình người ấm áp.<br>		    		Không Gia Đình thực sự là một cuốn sách hay và giá trị hơn cả một giá sách dạy phương pháp làm người.<br>		    		<br>		    		Không gia đình kể chuyện một em bé không cha mẹ, không họ hàng thân thích, đi theo một đoàn xiếc chó, khỉ, rồi cầm đầu đoàn ấy đi lưu lạc khắp nước Pháp, sau đó bị tù ở Anh, cuối cùng tìm thấy mẹ và em. Em bé Rêmi ấy đã lớn lên trong gian khổ. Em đã chung đụng với mọi hạng người, sống khắp mọi nơi, \"nơi thì lừa đảo, nơi thì xót thương\". Em đã lao động mà sống, lúc đầu dưới quyền điều khiển của một ông già từng trải và đạo đức, cụ Vitali, về sau thì tự lập và không những lo cho mình, còn bảo đảm việc biểu diễn và sinh sống cho cả một gánh hát rong. Đã có khi em và cả đoàn lang thang mấy hôm liền không có chút gì trong bụng. Đã có khi em suýt chết rét. Đã có khi em bị lụt ngầm chôn trong giếng mỏ mười mấy ngày đêm. Đã có khi em mắc oan bị giải ra trước tòa và bị ở tù.<br>		    		Và cũng có khi em được nuôi nấng đàng hoàng, no ấm. Nhưng dù ở đâu, trong cảnh ngộ nào, em vẫn noi theo nếp rèn dạy của ông già Vitali giữ phẩm chất làm người, nghĩa là ngay thẳng, gan dạ, tự trọng, thương người, ham lao động, không ngửa tay xin xỏ, không dối trá, gian giảo, nhớ ơn nghĩa, luôn luôn muốn làm người có ích...", "Không Gia Đình", 574, 77000.0, 4, 2014, "VH", "khong-gia-dinh", "A031", new DateTime(2020, 10, 19, 2, 38, 0, 0, DateTimeKind.Unspecified) },
                    { "S042", "A028", "VHNN", new DateTime(2020, 5, 20, 1, 47, 0, 0, DateTimeKind.Unspecified), null, "Nối tiếp thành công của cuốn tiểu thuyết  “Lời hồi đáp 1997”  vừa ra mắt tháng 5 vừa qua; phần tiếp theo trong series đình đám mang tên  ““Lời hồi đáp 1994”  đã tạo nên làn sóng “ Hồi ức những năm 90” của đài truyền hình tVN chính thức tái ngộ độc giả Việt Nam dưới dạng tiểu thuyết .<br>		    		Lời hồi đáp 1994 - Tiếng gọi của những năm 90 nồng nhiệt mà ngây thơ, và nhớ thương đến nhói lòng.<br>		    		Từng trang sách lấp lánh những sắc màu quá khứ, lung linh những hồi ức về một thời thanh xuân đã qua đầy tươi đẹp của nhóm bạn trẻ những chàng trai, cô gái đến từ các tỉnh thành khác nhau của Hàn Quốc lần đầu tới Seoul để bắt đầu cuộc sống sinh viên dưới một mái nhà có một ông bố đáng yêu và một bà mẹ đáng kính. Cuốn sách sẽ khiến bạn gật gù thừa nhận rằng: từng trang sách đã gợi nhớ lại những kỷ niệm đẹp về tuổi trẻ. Với khung cảnh những năm 1990 mỗi ngày ở nhà trọ Shin Chon luôn đầy ắp những bất ngờ và thú vị, mỗi giây phút mọi người bên nhau cùng tạo nên những khoảnh khắc tươi đẹp vì cuộc sống chúng ta không thể thay đồi quá khứ, không thể biết trước ngày mai sẽ ra sao nhưng có một điều chắc chắn đó là ngay khoảnh khắc này, chúng ta có thể làm cho nó trở nên tốt đẹp hơn.<br>		    		Những tình tiết trong cuốn sách cũng khiến chúng ta thấy tim mình ấm áp nhận ra rằng: Chẳng có ai yêu thương mình bằng bố mẹ, điều khiến trái tim chúng ta rung động đó là hai chữ Gia Đình.<br>		    		<br>		    		Câu chuyện còn xoay quanh các sự kiện văn hóa nổi bật ở Hàn Quốc năm 1994, với sự xuất hiện của nhóm nhạc thần tượng đầu tiên của Kpop “Seo Taiji and Boys” và đội bóng rổ trứ danh của Đại Hàn Dân Quốc.<br>		    		Làn sóng thần tượng thời kì này không quá được chú trọng như đối với “Lời hồi đáp 1997” nhưng bạn lại bắt gặp trong đó những câu chuyện rất đời: Cuộc sống đại học ở Yonsei - một trong những trường danh giá nhất Hàn Quốc với những cô cậu tỉnh lẻ, một gia đình trung lưu bình thường mới chuyển lên Seoul mở nhà trọ, quan hệ ruột thịt, bạn bè, công việc, lý tưởng tuổi trẻ và những người đi lướt qua nhau...<br>		    		“Bầu trời. Trong mắt người này có thể là bầu trời sáng rực đầy hi vọng, nhưng đối với người khác lại chói chang đáng sợ.”<br>		    		Câu chuyện như một cuộc chơi giữa nhà văn và độc giả : Rốt cục ai mới là chồng của nữ chính Sung Na Jung? Là anh trai điển hình của nhân loại với cái tên “mỹ miều” - Rác vì chỉ mặc độc một bộ đồ thể thao trong nhiều ngày liền. Anh thực chất không phải là anh ruột của Na-Jung và tình cảm anh dành cho cô cũng không phải tình cảm anh – em thông thường. Hay người ấy là Chilbong - cầu thủ bóng chày chân thật, ngọt ngào, lặng lẽ khiến trái tim bao cô gái tan chảy nhưng rụt rè.<br>		    		“Bởi vì mình quá tốt nên mình mới thất bại. Bởi vì mình quá tốt, cho dù là người con gái mà mình thích, mình cũng không thể hỏi cô ấy cho rõ ràng.” – Chilbong.<br>		    		Mối tình đầu sẽ chiến thắng hay sẽ như Chilbong nói “ Chưa phải kết thúc cho đến khi kết thúc thực sự” và ai sẽ được cú “ home run”n đây? (Thuật ngữ bóng chày = ghi điểm trực tiếp)?<br>		    		Tất tả những tình tiết thú vị đó sẽ khiến người đọc nín thở bởi: Tình yêu đơn phương tuy thầm kín nhưng lại vô cùng mãnh liệt . Ở lứa tuổi 20,tình yêu là một cái gì đó thuần khiết,mơ hồ.Vậy nên không phải bất cứ một tuổi trẻ nào cũng có thể may mắn có được. Những cô cậu sinh viên chập chững những bước đi đầu tiên liệu có đủ dũng khí để tìm thấy ước mơ của cuộc đời mình, liệu có đủ can đảm để đến bên ai đó nắm tay. Liệu tương lai có tốt đẹp như điều ước mà họ đã cùng nhau nguyện cầu?<br>		    		“Trong tiếng Anh, từ “present” có hai nghĩa: hiện tại và món quà. Món quà quý giá nhất của cuộc sống chính là hiện tại,chính là thời khắc đang trôi qua ngay trước mắt chúng ta.”<br>		    		Nhân dịp Lời hồi đáp 1994 tái ngộ độc giả Việt, Mintbooks hân hạnh dành tặng 1 móc khóa xinh xắn cho những người đặt sách sớm nhất. Nhanh tay lên, số lượng có hạn!", "Lời Hồi Đáp 1994", 128, 79000.0, 7, 2017, "VH", "loi-hoi-dap-1994", null, new DateTime(2020, 10, 19, 2, 38, 0, 0, DateTimeKind.Unspecified) },
                    { "S037", "A023", "VHNN", new DateTime(2020, 5, 20, 1, 26, 0, 0, DateTimeKind.Unspecified), null, "Sherlock Holmes là tiểu thuyết của Sir Arthur Conan Doyle lần đầu xuất hiện vào năm 1887 trong cuốn tiểu thuyết trinh thám “A Study in Scarlet”. Từ đó, nhà văn Anh đã viết 4 tiểu thuyết và 55 truyện ngắn về Holmes. Qua hàng thế kỷ, vị thám tử đã trở thành một biểu tượng văn hóa và là nguồn cảm hứng của rất nhiều cây bút khác. Cuốn “Mary Russell” nổi tiếng của Laurie King từng tái hiện cuộc sống của Holmes sau khi “về hưu”.<br>		    		Những Vụ Kỳ Án Của Sherlock Holmes đưa chúng ta sống cùng những vụ án ly kỳ, hóc búa, biến hoá vô cùng, và cũng lắm dữ dội, hiểm nguy, mà ở đó ông thể hiện tài ba phá án phi phàm của mình. Cuốn sách cuốn hút các bạn trẻ còn bởi lối kể chuyện nhẹ nhàng, nhưng bí hiểm và vô cùng thông minh. Và hơn thế nữa, còn nhiều THÍ DỤ TRẮC NGHIỆM, vừa giúp hiểu rõ hơn, khám phá lý thú hơn các vụ án lừng lẫy của Sherlock Holmes, vừa tăng cường khả năng phán đoán cho độc giả.", "Những Vụ Kỳ Án Của Sherlock Holmes", 526, 77000.0, 6, 2015, "VH", "nhung-vu-ky-an-cua-sherlock-holmes", null, new DateTime(2020, 10, 21, 8, 25, 0, 0, DateTimeKind.Unspecified) },
                    { "S036", "A025", "VHNN", new DateTime(2020, 5, 20, 1, 26, 0, 0, DateTimeKind.Unspecified), null, "Một tên sát thủ có sở thích uống chất hỗn hợp máu nạn nhân với sữa tươi, hắn có căn bệnh gì đặc biệt hay là con quỷ hút máu bất tử nghìn năm trong truyền thuyết?<br>		    		Trong thành phố C liên tiếp xảy ra 4 vụ cưỡng hiếp giết người, nạn nhân đều là những cô gái trí thức từ 25 - 35 tuổi, đây rốt cuộc là giết người trả thù hay đơn giản là cưỡng dâm?<br>		    		Hàng loạt cái chết bí ẩn thảm khốc của những người sống trong trường Đại học J liên tiếp xảy ra. Ở hiện trường vụ án, hung thủ đều để lại gợi ý cho vụ án tiếp theo, nhằm gợi ý gì?<br>		    		Trong hàng loạt các vụ án ly kỳ khiến cảnh sát bàng hoàng bó tay, Phương Mộc trầm mặc kiệm lời đột nhiên bị cảnh sát lôi vào cuộc. Tên ác quỷ giấu mặt lần lượt giết hại những người bạn của cậu, vì sao? Khi câu trả lời được vén màn bí mật, thì đề thi tàn khốc đã bị tích 5 dấu X đẫm máu.<br>		    		Một cuộc đấu trí so tài khốc liệt đầy kịch tính nổ Ai sẽ là người thắng cuộc?<br>		    		Đây là tác phẩm trinh thám được nhiều người biết đến nhất của Lôi Mễ - sĩ quan cảnh sát cấp phòng (sở) giảng dạy bộ môn Hình pháp học tại một trường cảnh sát trực thuộc Bộ Công an Trung Quốc, đồng thời cũng là một tác giả truyện trinh thám nổi tiếng. Truyện của Lôi Mễ luôn có sức hấp dẫn đặc biệt đối với độc giả bởi ngòi bút sắt bén với những tình tiết ly kì, lôi cuốn đến trang cuối cùng.", "Đề Thi Đẫm Máu", 537, 96000.0, 12, 2014, "VH", "de-thi-dam-mau", "A026", new DateTime(2020, 10, 19, 2, 25, 0, 0, DateTimeKind.Unspecified) },
                    { "S034", "A019", "VHNN", new DateTime(2020, 5, 20, 1, 9, 0, 0, DateTimeKind.Unspecified), null, "\"Khi pháp luật và phong hóa còn đày đọa con người, còn dựng nên những địa ngục giữa xã hội văn minh và đem một thứ định mệnh nhân tạo chồng thêm lên thiên mệnh; khi ba vấn đề lớn của thời đại là sự sa đọa của đàn ông vì bán sức lao động, sự trụy lạc của đàn bà vì đói khát, sự cằn cỗi của trẻ nhỏ vì tối tăm, chưa được giải quyết; khi ở một số nơi đời sống còn ngạt thở; nói khác đi, và trên quan điểm rộng hơn, khi trên mặt đất, dốt nát và đói khổ còn tồn tại, thì những cuốn sách như loại này còn có thể có ích.”<br>		    		(Hauteville House, ngày 1-1-1862- Victor Hugo)", "Những Người Khốn Khổ", null, 277000.0, 6, 2016, "VH", "nhung-nguoi-khon-kho", null, new DateTime(2020, 10, 19, 2, 25, 0, 0, DateTimeKind.Unspecified) },
                    { "S032", "A018", "VHNN", new DateTime(2020, 5, 20, 1, 9, 0, 0, DateTimeKind.Unspecified), null, "Tiểu thuyết Tiếng Chim Hót Trong Bụi Mận Gai (Tái Bản) xuất bản vào mùa xuân 1977 cùng một lúc ở New York, San Francisco, London, Sydney - Ít lâu sau đã được dịch ra bảy thứ tiếng, được bạn đọc nhiệt liệt hoan nghênh và giới phê bình đánh giá cao. Suốt mấy năm là tác phẩm ăn khách nhất ở phương Tây. Đây là tác phẩm đặc sắc, có giá trị trong văn học thế giới hiện đại.<br>		    		Colleen McCulough không phải là nhà văn chuyên nghiệp, trước đó hầu như không ai biết tiếng. Khi tiểu thuyết Tiếng chim hót trong bụi mận gai đem lại vinh dự cho tác giả thì McCulough vẫn chỉ là một nhân viên y tế bình thường. Bà sinh ở Úc, bang New South Wales, trong gia đình công nhân xây dựng xuất thân từ Ireland. Thời thanh xuân McCulough ở Sydney, đã từng học trường của nhà thờ công giáo, từ bé – bà mơ ước trở thành bác sĩ, nhưng không có điều kiện để qua đại học y. Bà đã thử làm một số nghề- làm báo, công tác thư viện, dạy học rồi trở lại nghề y, qua lớp đào tạo chuyên môn về sinh lý học thần kinh. Sau đó, bà đã làm việc bà đã làm việc tại các bệnh viện ở Sydney, London, Birmingham, rồi sang Mỹ, làm việc tại một trường y thuộc trường đại học Yale. Năm 1974 bà viết cuốn tiểu thuyết đầu tiên, không có tiếng vang gì. Tiếng chim hót trong bụi mận gai được thai nghén trong ngót bốn năm, rồi đầu mùa hè 1975, bà bắt tay vào viết liền một mạch trong mười tháng. Suốt thời gian ấy, bà vẫn bận túi bụi công việc ở bệnh viện, chỉ viết tác phẩm vào ban đêm và ngày chủ nhật.<br>		    		Tác phẩm này có thể gọi là “Xaga về gia đình Cleary”. Xaga là hình thức văn xuôi cổ có tính anh hùng ca, kể chuyện một cách điềm đạm về những con người hùng dũng. Cuốn tiểu thuyết này viết về lịch sử nửa thế kỷ của ba thế hệ một gia đình lao động - gia đình Cleary. Loại tiểu thuyết lịch sử gia đình từ trước đã có những thành công như thiên sử thi vè dòng họ Foocxaitơ của Gônxuocthy, “Gia đình Tibô” của Rôgiê Mactanh duy Gar. “Gia đình Artamônôp” của M. Gorki. Đặc điểm chung của các tác phẩm đó là số phận gia đình tiêu biểu cho số phận của giaia cấp tư sản, các thế hệ sau đoạn tuyệt với truyền thống của gia đình. So sánh với những tác phẩm kể trên thì tác phẩm của McCulough có sự khác biệt, có cái độc đáo riêng của nó. Trước hết, đây là lịch sử của một gia đình lao động. Sự phát triển, tính kế thừa và đổi mới của ba thế hệ gia đình này là hình mẫu thu nhỏ của lịch sử dân tộc. Các thế hệ sau kế thừa những nét tốt đẹp nhất của gia đình - tính cần cù, tự chủ, tính kiên cường đón nhận những đòn ác liệt của số phận, lòng tự hào gia đình, song đồng thời có những đổi khác nhịp bước với thời đại. Nếu Fiona gan góc chịu đựng mọi tai họa nhưng cam chịu số phận thì con gái bà là Meggie đã tìm cách cướp lấy hạnh phúc của mình từ tay Chúa trời, và Jaxtina, con gái của Meggie là một cô gái hiện đại, có những chuẩn mực đạo đức hoàn toàn khác. Cuốn tiểu thuyết xây dựng như truyện sử biên gia đình, tác giả tập trung vào những xung đột tâm lý - đạo đức nhiều hơn là những vấn đề giai cấp - xã hội. Các nhân vật tuy vẫn chịu ảnh hưởng của hoàn cảnh, nhưng chủ yếu là ứng xử theo tính cách riêng của mình nhiều hơn. Trong số nhiều nhân vật, nổi bật hơn cả là ba nhân vật - Fiona, Meggie - con gái bà và cha đạo Ralph de Bricassart. Meggie có thể coi là nhân vật trung tâm của tác phẩm. Trong tiểu thuyết có nhiều tuyến tình tiết, nhiều môtíp, đề tài, song tất cả đều phục vụ câu chuyện chính: mối tình lớn lao trong sáng của Meggie và cha de Bricassart.<br>		    		Trong tác phẩm quy mô lớn này, những xung đột tâm lý - tinh thần của nhân vật quyện chặt với sự miêu tả tỉ mỉ toàn cảnh lịch sử, địa lý, thiên nhiên. Thiên nhiên bao la, dữ dội nhưng có cái đẹp hoang sơ riêng của nó như hiện ra trước mắt bạn đọc. Giá trị nhận thức của tác phẩm do đó càng thêm đầy đủ. Mối quan hệ giữa thiên nhiên và con người ở đây mang tính chất chung sống hài hòa, thiên nhiên chưa bị uy hiếp đến nguy cơ hủy diệt.<br>		    		Tính hiện thực và lãng mạn trong tác phẩm này hòa lẫn vào nhau tới mức nhuần nhị. Sự miêu tả tỉ mỉ bằng hình thức của bản thân đời sống, cả từ cách ăn mặc, lời ăn tiếng nói của nhân vật, cho đến cách xén lông cừu, nếp sống hàng ngày..., lối kể chuyện thong thả theo trình tự thời gian khiến cho tác phẩm gần với loại tiểu thuyết hiện thực thế kỷ 19. Nhưng những tính cách phi thường rực rỡ biểu hiện trong những biến cố đột ngột, đầy hấp dẫn tạo nên màu sắc lãng mạn rất rõ nét. Môt tác phẩm văn học Mỹ thời nay xa lạ với những cảnh hung bạo, với “sex”, với “phản nhân vật” đưa bạn đọc trở về với những vấn đề “nhà” (theo nghĩa quê hương), “cội nguồn”, “cha và con” mà lại được ham chuộng như thế ở phương Tây thì đó chứng tỏ những vấn đề muôn thuở của nhân loại bao giờ cũng làm rung động lòng người ở bất cứ nơi nào trên hành tinh chúng ta.", "Tiếng Chim Hót Trong Bụi Mận Gai", 704, 90000.0, 7, 2011, "VH", "tieng-chim-hot-trong-bui-man-gai", null, new DateTime(2020, 10, 21, 12, 15, 0, 0, DateTimeKind.Unspecified) },
                    { "S031", "A020", "VHNN", new DateTime(2020, 5, 20, 1, 9, 0, 0, DateTimeKind.Unspecified), null, "“Hai số phận” không chỉ đơn thuần là một cuốn tiểu thuyết, đây có thể xem là \"thánh kinh\" cho những người đọc và suy ngẫm, những ai không dễ dãi, không chấp nhận lối mòn.<br>		    		“Hai số phận” làm rung động mọi trái tim quả cảm, nó có thể làm thay đổi cả cuộc đời bạn. Đọc cuốn sách này, bạn sẽ bị chi phối bởi cá tính của hai nhân vật chính, hoặc bạn là Kane, hoặc sẽ là Abel, không thể nào nhầm lẫn. Và điều đó sẽ khiến bạn thấy được chính mình.<br>		    		Khi bạn yêu thích tác phẩm này, người ta sẽ nhìn ra cá tính và tâm hồn thú vị của bạn!<br>		    		“Nếu có giải thưởng Nobel về khả năng kể chuyện, giải thưởng đó chắc chắn sẽ thuộc về Archer.” - Daily Telegraph<br>		    		“Hai số phận” (Kane & Abel) là câu chuyện về hai người đàn ông đi tìm vinh quang. William Kane là con một triệu phú nổi tiếng trên đất Mỹ, lớn lên trong nhung lụa của thế giới thượng lưu. Wladek Koskiewicz là đứa trẻ không rõ xuất thân, được gia đình người bẫy thú nhặt về nuôi. Một người được ấn định để trở thành chủ ngân hàng khi lớn lên, người kia nhập cư vào Mỹ cùng đoàn người nghèo khổ. <br>		    		Trải qua hơn sáu mươi năm với biết bao biến động, hai con người giàu hoài bão miệt mài xây dựng vận mệnh của mình . “Hai số phận” nói về nỗi khát khao cháy bỏng, những nghĩa cử, những mối thâm thù, từng bước đường phiêu lưu, hiện thực thế giới và những góc khuất... mê hoặc người đọc bằng ngôn từ cô đọng, hai mạch truyện song song được xây dựng tinh tế từ những chi tiết nhỏ nhất.)", "Hai Số Phận", 768, 117000.0, 1, 2018, "VH", "hai-so-phan", "A021", new DateTime(2020, 10, 19, 2, 24, 0, 0, DateTimeKind.Unspecified) },
                    { "S005", "A005", "KT", new DateTime(2020, 5, 19, 5, 3, 0, 0, DateTimeKind.Unspecified), null, "Đuổi Theo Tốp Dẫn Đầu<br>		    		Nhiều tổ chức gặp cạnh tranh mãnh liệt ngoài thị trường. Những tổ chức này dù có cố gắng bứt ra khỏi đoàn nhờ những khác biệt tạm thời, nhưng khoảng cách này rồi cũng chỉ thoáng qua.<br>		    		Nhận diện và đáp ứng một vài nhu cầu khách hàng trong một thị trường sẽ đầy ngập nguồn cung. Tìm được một nhà cung cấp ưng ý thì một thời gian ngắn sau, nhiều nhà mua sẽ đổ xô vào. Dùng một kiến thức khoa học hay một phương sách kỹ thuật tân tiến thì chẳng bao lâu cả thị trường cung sẽ chấp nhận chúng. Hậu quả của thị trường mềm dẻo đó là sự cạnh tranh ráo riết, cắt cổ.<br>		    		Tuy nhiên, đôi nơi ta thấy vài công ty hay tổ chức, trong hay ngoài khu vực tư, quản trị để tiếp tục dẫn đầu, đi trội hơn tốp sau năm này qua năm khác, có khi cả chục năm. Có đủ tốc độ, nhanh nhẹn, sẵn sàng đáp ứng và dư sức chịu đựng, họ thấy và vội nắm lấy cơ hội, rồi khi mà những đối thủ đáp ứng, tốp đi trước đã chạy tới những cơ hội mới và bỏ những đối thủ sau đuôi.<br>		    		Mời bạn đón đọc", "Đuổi Theo Tốp Dẫn Đầu", 216, 60000.0, 2, 2009, "TH", "duoi-theo-top-dan-dau", null, new DateTime(2020, 10, 19, 2, 11, 0, 0, DateTimeKind.Unspecified) },
                    { "S004", "A004", "KT", new DateTime(2020, 5, 19, 5, 1, 0, 0, DateTimeKind.Unspecified), null, "Tuổi Trẻ Với Tư Duy Triệu Phú<br>		    		Phải chăng người giàu sinh ra đã giàu? Người thành công đã có sẵn tố chất thành công? Nếu thế, liệu một người bình thường có thể trở thành triệu phú?<br>		    		Laura Lyseight, tác giả của quyển sách mỏng này sẽ vén mở những chìa khóa làm giàu của những triệu phú trên thế giới để giúp bạn có thể trở thành triệu phú ngay từ thời tuổi trẻ đầy hoài bão.", "Tuổi Trẻ Với Tư Duy Triệu Phú", 179, 34000.0, 6, 2014, "TH", "tuoi-tre-voi-tu-duy-trieu-phu", null, new DateTime(2020, 10, 20, 22, 34, 0, 0, DateTimeKind.Unspecified) },
                    { "S035", "A024", "TD-KNS", new DateTime(2020, 5, 20, 1, 26, 0, 0, DateTimeKind.Unspecified), null, "Nội dung truyện trinh thám sự im lặng của bầy cừu kể về vụ án giết người hàng loạt xảy ra nhưng không để lại dấu vết. Điều kỳ lạ là Lecter - một bác sĩ tâm lý bị tâm thần đang điều trị tại Dưỡng Trí Viện biết rất rõ về hành vi của kẻ sát nhân nhưng chỉ im lặng. Cho đến khi con gái của thượng nghị sĩ bị bắt cóc thì cuộc đối đầu của nữ nhân viên thực tập FBI và vị bác sĩ tâm thần đã đến cực điểm. Cuối cùng tất cả cũng đều lộ diên, thủ phạm là một tên có nhân cách bệnh hoạn, một kẻ tâm thần rối loạn cựu kỳ nguy hiểm…<br>		    		Những cuộc phỏng vấn ở xà lim với kẻ ăn thịt người ham thích trò đùa trí tuệ, những tiết lộ nửa chừng hắn chỉ dành cho kẻ nào thông minh, những cái nhìn xuyên thấu thân phận và suy tư của cô mà đôi khi cô muốn lảng tránh... Clarice Starling đã dấn thân vào cuộc điều tra án giết người lột da hàng loạt như thế, để rồi trong tiếng bức bối của chiếc đồng hồ đếm ngược về cái chết, cô phải vật lộn để chấm dứt tiếng kêu bao lâu nay vẫn đeo đẳng giấc mơ mình: tiếng kêu của bầy cừu sắp bị đem đi giết thịt.<br>		    		Xem review sách: Sách sự im lặng của bầy cừu – cuốn tiểu thuyết trinh thám kinh dị đầy hấp dẫn<br>		    		Cuốn tiểu thuyết trinh thám này từng được chuyển thể thành phim và đoạt 5 giải Oscar. Sự im lặng của bầy cừu hội tụ đầy đủ những yếu tố làm nên một cuốn tiểu thuyết trinh thám kinh dị xuất sắc nhất: không một dấu vết lúng túng trong những chi tiết thuộc lĩnh vực chuyên môn, với các tình tiết giật gân, cái chết luôn lơ lửng, với cuộc so găng của những bộ óc lớn mà không có chỗ cho kẻ ngu ngốc để cuộc chơi trí tuệ trở nên dễ dàng. Bồi đắp vào cốt truyện lôi cuốn đó là cơ hội được trải nghiệm trong trí não của cả kẻ gây tội lẫn kẻ thi hành công lý, khi mỗi bên phải vật vã trong ngục tù của đau đớn để tìm kiếm, khẩn thiết và liên tục, một sự lắng dịu cho tâm hồn.<br>		    		Cuốn sách này của Thomas Harris đạt tốp 1 của 100 truyện trinh thám – kinh dị hay nhất mọi thời do trang điện tử NPR tổ chức, thu hút hơn 17.000 lượt độc giả. Danh sách top 100 được lựa chọn ra từ 600 đề cử của các chuyên gia, cố vấn văn học hàng đầu.<br>		    		Sự im lặng của bầy cừu là cuốn sách có thể khiến độc giả hồi hộp đến nghẹt thở.<br>		    		Nhận định<br>		    		“...xây dựng tình tiết đẹp với lối viết thông tuệ. Không tác phẩm kinh dị nào vượt được cuốn này.”- Clive Barker<br>		    		“Một cuốn sách giáo khoa đúng nghĩa về nghệ thuật viết truyện kinh dị, một kiệt tác chứa xung lực đưa nó lao vụt lên đỉnh cao không một khiếm khuyết... Harris đơn giản chính là tiểu thuyết gia kinh dị xuất sắc nhất thời nay.”- The Washington Post<br>		    		“Tiết điệu dồn dập... đánh thức sự tò mò... lôi cuốn.”- Chicago Tribune", "Sự Im Lặng Của Bầy Cừu", 347, 90000.0, 3, 2014, "HNV", "su-im-lang-cua-bay-cuu", null, new DateTime(2020, 10, 21, 8, 31, 0, 0, DateTimeKind.Unspecified) },
                    { "S003", "A003", "KT", new DateTime(2020, 5, 19, 4, 57, 0, 0, DateTimeKind.Unspecified), null, "Trước mắt bạn, tương lai đang trải rộng con đường dẫn tới những miền đất xa xôi đầy hứa hẹn. Trên con đường đó, bạn háo hức, mong muốn thực hiện nhiều ước mơ, dự định, khát khao… của riêng mình.<br>		    		Để những nguyện vọng của mình được thực hiện, ít nhất bạn phải thành công về mặt tiền bạc. Quyển sách này sẽ giúp bạn biết cách vận dụng những nguyên lý quan trọng để phát triển tài chính. Hãy để cuốn sách dẫn dắt bạn đi từ một hoàn cảnh khó khăn, tiêu biểu là một cái túi lép xẹp, đến một cuộc sống đầy đủ và hạnh phúc, tiêu biểu là một túi tiền căng phồng, sung túc.<br>		    		Khi nói đến tiền bạc, chúng ta thường đề cập đến quy luật trọng trường và nó luôn phổ quát và bất biến trong mọi trường hợp. Trải qua thời gian dài và phát triển, quy luật này đã được trải nghiệm và đúc rút thành những bí quyết không chỉ đảm bảo cho bạn một túi tiền đầy, mà còn giúp cho bạn có một cuộc sống cân bằng để có thể phát triển mỹ mãn hơn những tiềm năng của bản thân trong các lĩnh vực khác của cuộc sống. Bởi trên thực tế, không ai có thể phủ nhận rằng sự dồi dào về vật chất có thể làm cho đời sống con người trở nên tốt đẹp hơn. Riêng trong lĩnh vực kinh doanh, sức mạnh tài chính là phương tiện chủ yếu để đo lường mức độ thành đạt của các doanh nhân.<br>		    		Ngày nay, tiền bạc vẫn có những ảnh hưởng lớn đối với cuộc sống con người, cũng giống như cách đây năm ngàn năm nó đã chi phối mạnh mẽ cuộc sống của cư dân vương quốc Babylon, thúc đẩy họ tìm hiểu và nắm bắt các quy luật tạo ra tiền, nhằm có được một cuộc sống sung túc và sang trọng bậc nhất.<br>		    		Những trang sách này sẽ đưa chúng ta trở lại vương quốc Babylon cổ đại, cái nôi nuôi dưỡng những nguyên lý cơ bản về tài chính mà giờ đây con người hiện đại đã kế thừa và vận dụng trên toàn thế giới.", "Người Giàu Có Nhất Thành Babylon", null, 47000.0, 9, 2019, "TH", "nguoi-giau-co-nhat-thanh-babylon", null, new DateTime(2020, 10, 20, 22, 25, 0, 0, DateTimeKind.Unspecified) },
                    { "S056", "A047", "KHCN", new DateTime(2020, 10, 19, 4, 6, 0, 0, DateTimeKind.Unspecified), null, "Một chuyến du hành đầy trí tuệ qua các vũ trụ, được dẫn dắt tài tình bởi \"thuyền trưởng\" Michio Kaku và độc giả có dịp chiêm ngưỡng vẻ đẹp kỳ vĩ của vũ trụ kể từ vụ nổ lớn, vượt qua những hố đen, lỗ sâu, bước vào các thế giới lượng tử từ muôn màu kỳ lạ nằm ngay trước mũi chúng ta, vốn dĩ tồn tại song song trên một màng bên ngoài không - thời gian bốn chiều, ngắm nhìn thực tại vật chất quen thuộc hoà quyện với thế giới của những điều kỳ diệu như năng lượng và vật chất tối, sự nảy chồi của các vũ trụ, những chiều không gian bí ẩn và sự biến ảo của các dây rung siêu nhỏ...<br>		    		Dẫn chuyện lôi cuốn, kết hợp tường minh, sống động một lượng thông tin đồ sộ để khai mở những giới hạn tột cùng của trí  tưởng tượng, Kaku thực sự xứng đáng là \" nhà truyền giáo\" vĩ đại đã mang thế giới vật lý lý thuyết tới quảng đại quần chúng.", "Các Thế Giới Song Song", 480, 96000.0, 3, 2020, "TG", "cac-the-gioi-song-song", "A050", new DateTime(2020, 10, 20, 22, 4, 0, 0, DateTimeKind.Unspecified) },
                    { "S049", "A039", "KHCN", new DateTime(2020, 5, 20, 2, 31, 0, 0, DateTimeKind.Unspecified), null, "Tại sao tồn tại một cái gì đó thay vì không có gì?<br>		    	Lawrence M. Krauss - tác giả bán chạy nhất và nhà vật lý nổi tiếng đã đưa ra một quan điểm khác biệt về cách mọi thứ tồn tại: \"Vũ trụ đến từ đâu? Cái gì ở đó trước đó? Tương lai sẽ mang đến điều gì? Và cuối cùng, tại sao tồn tại một cái gì đó thay vì không có gì?\"<br>		    	Đặt tên cho phụ đề của cuốn sách bằng một câu hỏi “kinh điển”, “Tại sao tồn tại một cái gì đó thay vì không có gì?”, Krauss có tham vọng kết nối những phát hiện lớn lao của khoa học hiện đại với một câu hỏi đã gây sự tò mò cho các nhà thần học, triết gia, các nhà triết học tự nhiên và cả công chúng trong lịch sử.<br>		    	Cách đặt vấn đề và trình bày của Krauss luôn thể hiện chủ nghĩa mà ông theo đuổi và tôn thờ, chủ nghĩa “nghi ngờ một cách có khoa học”. Nhưng không chỉ dừng lại ở những nghi ngờ “tại sao”, trong lời mở đầu của cuốn sách, tác giả cũng đã lý giải rằng thực ra câu hỏi đơn thuần “tại sao” không hoàn toàn là một câu hỏi hợp lý, vì nó luôn bao hàm cả mục tiêu và luôn khiến người ta không thỏa mãn. Trong khoa học, khi ai đó muốn hỏi “tại sao”, thì thực ra người đó đang muốn trả lời câu hỏi “bằng cách nào” hay “như thế nào”. Đây chính là cách Krauss đã bắt đầu triển khai các ý tưởng của cuốn sách.<br>		    	Vũ trụ từ hư không có một kết cấu uyển chuyển, đủ để dẫn dắt người đọc phổ thông tiệm cận với khoa học về thiên văn. Krauss đã bắt đầu câu chuyện cuốn hút của mình bằng chương giải thích ngắn gọn về sự ra đời của thuyết Big Bang, giải thích cặn kẽ về sự giãn nở của vũ trụ với những mô tả về nghiên cứu của Edwin Hubble và cách xác định tuổi của vũ trụ. Câu chuyện được tiếp tục với những lý giải về việc tìm ra bức xạ nền vi ba – bằng chứng còn sót lại của Big Bang, rồi cùng các nhà vật lý đến với những nghiên cứu “cân vũ trụ” để cố gắng lý giải cho câu hỏi “vũ trụ phẳng”, “vũ trụ đóng”, hay “vũ trụ mở”<br>		    	Qua 11 chương sách, tác giả đã đề cập đến cả một hành trình khám phá vũ trụ đầy ấn tượng mà loài người thực hiện trong lịch sử tiến hóa của mình.<br>		    	Tạp chí khoa học Nature danh tiếng từng ca ngợi cuốn sách, coi Krauss là người kể chuyện vũ trụ duyên dáng nhất. Clinton Richard Dawkins, một cựu giáo sư Đại học Oxford, một nhà sinh học tiến hóa đã so sánh thành công của cuốn sách này ngang với tác phẩm kinh điển Nguồn gốc các loài của Charles Darwin.<br>		    		Tất cả những ai quan tâm đến Vật lý học, Vũ trụ học, những ai tò mò Vũ trụ của chúng ta đã bắt đầu như thế nào, và kết thúc ra sao đều nên đọc cuốn sách này.", "Vũ Trụ Từ Hư Không", 320, 116000.0, 1, 2019, "TG", "vu-tru-tu-hu-khong", "A043", new DateTime(2020, 10, 19, 2, 39, 0, 0, DateTimeKind.Unspecified) },
                    { "S018", "A013", "TD-KNS", new DateTime(2020, 5, 19, 21, 56, 0, 0, DateTimeKind.Unspecified), null, "Nếu bạn đang cảm thấy bế tắc trong cuộc sống, cần một ai đó xốc lại tinh thần để tiếp tục chiến đấu với cuộc đời thì chắc chắn không nên bỏ lỡ cuốn sách này. Cuộc sống rất giống cuộc đời sẽ đem lại cho bạn những tiếng cười sảng khoái và những phút giây thư giãn qua từng trang sách.<br>		    		<br>		    		Không tạo cảm giác ức chế hay nhàm chán với những lối đi cũ mòn của văn chương hoa mĩ. Giọng văn và cách kể của tác giả Hoàng Hải Nguyễn có phần phóng khoáng,  hóm hỉnh, sâu cay và đặc biệt là biệt tài gây cười đặc trưng có một không hai. Từng gây sốt cộng đồng mạng với những bài viết như “Đàn ông tuổi 40, Thư mẫu gửi vợ, Nhật ký của bố, Bây giờ anh định thế nào ?...” ;  anh từng bước xây dựng cho mình một hướng đi độc đáo và tạo được dấu ấn với cá tính riêng biệt,  cuốn sách bạn là tập hợp tất cả những tản văn hay nhất anh góp nhặt trong quãng thời gian “chinh chiến với cuộc đời.”<br>		    		Dưới góc nhìn của một người đàn ông U40, đã có gia đình và hai con, anh nhìn nhận sự xoay vần của cuộc đời theo cách của  người từng trải có nhiều kinh nghiệm.<br>		    		“Có lẽ trên đời này tôi chưa bao giờ được bế trên tay một sinh vật xinh đẹp như vậy, tôi cũng chưa thấy một thứ tình cảm nào gắn kết ngay khi chỉ vừa gặp mặt, một tình yêu kì lạ hình thành từ khi vợ tôi mang thai và kịp hoàn thiện vào giây phút tôi nhìn thấy con gái, đó là tình cha con!<br>		    		(Trích Nhật ký của bố)<br>		    		Những câu chuyện về tổ ấm gia đình, chuyện xã hội, chuyện cuộc sống, chuyện phiếm bên lề được kết hợp khéo léo với chất văn “rất đàn ông” là điểm sáng giúp anh ghi dấu trong lòng bạn đọc. Từ những con chữ thông minh ,sắc lẹm như lưỡi dao ấy, lại khiến người đọc trăn trở, đau đáu, có một khoảng lặng để suy ngẫm và nhận ra nhiều điều có ích.<br>		    		“ Đàn ông tuổi 15 mơ ước thành đàn ông tuổi 20, đàn ông tuổi 20 mơ ước được trở thành đàn ông tuổi 30, đàn ông tuổi 30 mơ ước được trở thành đàn ông tuổi 40 và đàn ông tuổi 40 lại mơ ước được đặt chân lên cỗ máy thời gian để quay lại tuổi 30 với toàn bộ tài sản của mình!”<br>		    		(Trích Đàn ông tuổi 40)<br>		    		Giống như lời tác giả tâm sự “ Tôi hi vọng các bạn sẽ có được tiếng cười và sự vui vẻ khi đọc nó sau một ngày làm việc vất vả. Qua các câu chuyện, tôi mong muốn các bạn hãy luôn lạc quan, yêu đời, mỗi người chỉ sống có một lần vì vậy hãy tận hưởng nó bằng niềm vui.<br>		    		Cuộc sống rất giống cuộc đời !”", "Cuộc Sống Rất Giống Cuộc Đời", 256, 52000.0, 2, 2016, "TG", "cuoc-song-rat-giong-cuoc-doi", null, new DateTime(2020, 10, 21, 8, 25, 0, 0, DateTimeKind.Unspecified) },
                    { "S016", "A012", "TD-KNS", new DateTime(2020, 5, 19, 7, 38, 0, 0, DateTimeKind.Unspecified), null, "Sai lầm lớn nhất của chúng ta là đem những tật xấu, những cảm xúc tiêu cực trút bỏ lên những người xung quanh, càng là người thân càng dễ gây thương tổn.<br>		    		Cái gì cũng nói toạc ra, cái gì cũng bộc lộ hết không phải là thẳng tính, mà là thiếu bản lĩnh. Suy cho cùng, tất cả những cảm xúc tiêu cực của con người đều là sự phẫn nộ dành cho bất lực của bản thân. Nếu bạn đúng, bạn không cần phải nổi giận. Nếu bạn sai, bạn không có tư cách nổi giận.<br>		    		Đem một nắm muối bỏ vào cốc nước, cốc nước trở nên mặn chát. Đem một nắm muối bỏ vào hồ nước, hồ nước vẫn ngọt lành. Lòng người cũng vậy, càng nông cạn càng dễ biến chất, càng sâu sắc càng khó lung lay. Ý nghĩa của đời người không ngoài việc tu tâm dưỡng tính, để mở lòng ra bao la như biển hồ, trước những nắm muối thị phi của cuộc đời vẫn thản nhiên không xao động.<br>		    		“Nóng giận là bản năng, tĩnh lặng là bản lĩnh” là từ bỏ “tam độc”, tu dưỡng một trái tim trong sáng:<br>		    		Từ bỏ “tham” – bớt một phần ham muốn, thêm một phần tự do.<br>		    		Từ bỏ “sân” – bớt một phần tranh chấp, thêm một phần ung dung.<br>		    		Từ bỏ “si” – bớt một phần mê muội, thêm một phần tĩnh tâm.<br>		    		Cuốn sách là tập hợp những bài học, lời tâm sự về nhân sinh, luận về cuộc đời của đại sư Hoằng Nhất – vị tài tử buông mọi trần tục để quy y cửa Phật, người được mệnh danh tinh thông kim cổ và cũng có tầm ảnh hưởng lớn trong Phật giáo.<br>		    		Trưởng thành, hãy để lòng rộng mở, tiến gần đến chữ “Người”, học được cách bao dung, học được cách khống chế cảm xúc. Đừng để những xúc động nhất thời như ngọn lửa, tưởng thiêu rụi được kẻ thù mà thực ra lại làm bỏng tay ta trước.", "Nóng Giận Là Bản Năng , Tĩnh Lặng Là Bản Lĩnh", 264, 67000.0, 1, 2019, "TG", "nong-gian-la-ban-nang-tinh-lang-la-ban-linh", null, new DateTime(2020, 10, 21, 8, 32, 0, 0, DateTimeKind.Unspecified) },
                    { "S015", "A010", "TD-KNS", new DateTime(2020, 5, 19, 7, 38, 0, 0, DateTimeKind.Unspecified), null, "Trong độ xuân xanh phơi phới ngày ấy, bạn không dám mạo hiểm, không dám nỗ lực để kiếm học bổng, không chịu tìm tòi những thử thách trong công việc, không phấn đấu hướng đến ước mơ của mình. Bạn mơ mộng rằng làm việc xong sẽ vào làm ở một công ty nổi tiếng, làm một thời gian sẽ thăng quan tiến chức. Mơ mộng rằng khởi nghiệp xong sẽ lập tức nhận được tiền đầu tư, cầm được tiền đầu tư là sẽ niêm yết trên sàn chứng khoán. Mơ mộng rằng muốn gì sẽ có đó, không thiếu tiền cũng chẳng thiếu tình, an hưởng những năm tháng êm đềm trong cuộc đời mình. Nhưng vì sao bạn lại nghĩ rằng bạn chẳng cần bỏ ra chút công sức nào, cuộc sống sẽ dâng đến tận miệng những thứ bạn muốn? Bạn cần phải hiểu rằng: Hấp tấp muốn mau chóng thành công rất dễ khiến chúng ta đi vào mê lộ. Thanh xuân là khoảng thời gian đẹp đẽ nhất trong đời, cũng là những năm tháng then chốt có thể quyết định tương lai của một người. Nếu bạn lựa chọn an nhàn trong 10 năm, tương lai sẽ buộc bạn phải vất vả trong 50 năm để bù đắp lại. Nếu bạn bươn chải vất vả trong 10 năm, thứ mà bạn chắc chắn có được là 50 năm hạnh phúc. Điều quý giá nhất không phải là tiền mà là tiền bạc. Thế nên, bạn à, đừng lựa chọn an nhàn khi còn trẻ.", "Đừng Lựa Chọn An Nhàn Khi Còn Trẻ", 316, 56000.0, 2, 2019, "TG", "dung-lua-chon-an-nhan-khi-con-tre", "A011", new DateTime(2020, 10, 21, 8, 31, 0, 0, DateTimeKind.Unspecified) },
                    { "S057", "A048", "KHCN", new DateTime(2020, 10, 20, 0, 1, 0, 0, DateTimeKind.Unspecified), null, "Cuốn sách giải thích những điều kỳ lạ, những phép lạ tôn giáo, trải nghiệm cận tử, thoát xác, những khả năng phi thường của con người bằng nguyên lý toàn ảnh dựa trên ý tưởng cho rằng vũ trụ là một ảnh toàn ký khổng lồ.<br>		    		Song song với sự phát triển của khoa học, những điều huyền bí vẫn tồn tại bất chấp các định lý, định luật và điều kiện của tự nhiên mà khoa học hiện đại tuân theo. Đối mặt với vấn đề này, hầu hết các nhà khoa học lựa chọn “từ bỏ”, phủ nhận những điều huyền bí, một số người cực đoan thậm chí quy kết tất cả những gì siêu nhiên là mê tín. Mặc dù vậy, vẫn có những người tiếp tục nghiên cứu mặc sự dèm pha của đồng nghiệp. Michael Talbot là một trong số đó. Trong cuốn sách Vũ trụ toàn ảnh, ông đã đề xuất ý tưởng cho rằng toàn bộ vũ trụ là một cơ thể khổng lồ, không thể chia tách, là một ảnh toàn ký mà dù có chia nhỏ đến đâu vẫn cho ra hình ảnh nguyên vẹn. Theo quan niệm này, ông đã giải thích những điều kỳ lạ, những phép lạ tôn giáo, trải nghiệm cận tử, thoát xác, những khả năng phi thường của con người – tiên tri, thấu thị, cơ thể không bị tổn thương, đi trên dung nham nóng chảy, chữa bệnh bằng sức mạnh tinh thần… – bằng nguyên lý toàn ảnh, dựa trên những chứng cứ mà ông thu thập được và chính từ trải nghiệm của bản thân. Qua đó, ông cũng phần nào giải thích vì sao những hiện tượng siêu nhiên hay khả năng đặc biệt phần lớn được những người theo những nền văn hóa cổ trải nghiệm mà không phải những người thông thái theo trường phái hiện đại. Ý thức và niềm tin chính là chìa khóa cho vấn đề này.", "Vũ Trụ Toàn Ảnh", 516, 123000.0, 1, 2018, "NXBT", "vu-tru-toan-anh", "A049", new DateTime(2020, 10, 20, 21, 41, 0, 0, DateTimeKind.Unspecified) },
                    { "S048", "A035", "KT", new DateTime(2020, 5, 20, 2, 9, 0, 0, DateTimeKind.Unspecified), null, "Tất cả chúng ta đều biết công cụ tìm kiếm Google và công ty Google với văn hóa doanh nghiệp tuyệt vời nổi tiếng khắp thế giới, nhưng liệu có bao nhiêu người trong số chúng ta biết được điều gì đã làm nên nền tảng cho sự nổi tiếng đó? Chade-Meng Tan – tác giả cuốn sách Search Inside Yourself sẽ giải thích cho bạn bí mật đó.<br>		    		Mỗi năm, có đến hàng nghìn kĩ sư Google tham gia một trong 12 khóa đào tạo về thiền để tăng cường khả năng “cân bằng nhận thức” về những gì đang diễn ra xung quanh. Khóa học nổi tiếng nhất – mang tên “Search inside yourself” (Tìm kiếm bên trong bạn) – luôn là khóa học được trông đợi nhất và thu hút nhiều người tham gia nhất với danh sách học viên chờ tham dự dài đến sáu tháng. Khóa học do Chade-Meng Tan khởi sướng, ông là người rất có ảnh hưởng đến văn hóa Google, là người mà bất cứ nhân vật nổi tiếng nào khi đến thăm công ty cũng đều muốn gặp. Tham vọng của Meng chính là: “Soi sáng tâm trí, mở rộng trái tim và tạo ra hòa bình thế giới”.<br>		    		Cuốn sách Search inside yourself đã được ông viết lại dựa trên các kinh nghiệm đúc kết từ khóa học cùng các bài tập thiền để mọi người trong chúng ta đều có thể áp dụng được mà không cần phải tham gia khóa học kia của Google. Bằng ngôn từ đơn giản, dễ hiểu, cùng các bước luyện tập cơ bản nhằm giúp con người kiểm soát trí thông minh cảm xúc – làm chủ được cảm xúc bản thân, từ đó trở thành con người hạnh phúc nhất thế giới và lan tỏa niềm vui đến mọi người. “Tôi không thích mang Phật giáo vào Google”, Meng nói. “Tôi thích giúp đỡ mọi người ở Goolge tìm kiếm chìa khóa hạnh phúc”.<br>		    		Đúng như Eric Schmidt, Giám đốc điều hành của Google đã từng nói: “Cuốn sách này và khóa học mà nó dựa trên đại diện cho một trong những khía cạnh tuyệt vời nhất của văn hóa Google – một cá nhân với một ý tưởng thật sự vĩ đại có thể thay đổi thế giới”.<br>		    		Cuốn sách được chia làm ba phần chính:<br>		    		Rèn luyện khả năng chú ý: Chú ý là nền tảng của mọi năng lực cảm xúc và nhận thức cao hơn. Do đó, bất cứ giáo trình rèn luyện trí thông minh cảm xúc nào cũng đều phải bắt đầu với việc rèn luyện khả năng chú ý. Ý tưởng ở đây là rèn luyện khả năng chú ý để tạo ra một tâm trí vừa an bình vừa sáng sủa. Một tâm trí như vậy sẽ tạo nền tảng cho trí thông minh cảm xúc.<br>		    		Tự phát triển kiến thức và tự làm chủ bản thân: Sử dụng khả năng chú ý đã qua rèn luyện để nâng cao khả năng nhận thức quá trình cảm giác và tư duy của bạn. Từ đó, bạn có thể quan sát ngày càng rõ ràng dòng suy nghĩ và quá trình cảm giác của mình, với sự khách quan như từ góc nhìn của một người thứ ba. Khi làm được như vậy, bạn sẽ tạo ra một loại kiến thức sâu sắc do bạn tự khám phá ra và loại kiến thức này cuối cùng sẽ dẫn đến sự tự làm chủ bản thân.<br>		    		Tạo ra các thói quen hữu ích cho tâm: Hãy tưởng tượng rằng bất cứ khi nào bạn gặp ai đó, ý nghĩ đầu tiên, theo bản năng, theo thói quen của bạn là, tôi muốn người này được hạnh phúc. Có những thói quen như vậy sẽ thay đổi mọi thứ ở nơi làm việc, vì ý tốt chân thành này sẽ được người khác cảm nhận một cách vô thức, và tạo ra loại tin tưởng dẫn đến những sự hợp tác có hiệu quả cao. Những thói quen như vậy có thể được rèn luyện để trở thành tự nhiên.", "Search Inside Yourself", 364, 77000.0, 10, 2019, "NXBT", "search-inside-yourself", null, new DateTime(2020, 10, 19, 2, 39, 0, 0, DateTimeKind.Unspecified) },
                    { "S047", "A034", "KT", new DateTime(2020, 5, 20, 1, 58, 0, 0, DateTimeKind.Unspecified), null, "Tài sản của tổ chức The Trump Organization đã có mặt trên khắp nước Mỹ và nhiều quốc gia trên thế giới. Chủ nhân của những toà cao ốc, biệt thự, khách sạn - sòng bạc lộng lẫy, nguy nga này là nhà tỷ phú Donald J. Trump - người đã viết cuốn The Art of the Deal (Nghệ thuật đàm phán trong kinh doanh), đó là ấn phẩm bán chạy nhất trong ngành kinh doanh sách thập niên 80 của thế kỷ XX...<br>		    		Phương châm của Donald là: “Nếu bạn không nói cho mọi người biết về sự thành công của bạn thì người ta sẽ không hề biết gì về nó đâu”, chính vì vậy cuốn sách Tôi đã làm giàu như thế ra đời, chỉ vì theo chính lời tác giả: “Có ít nhất năm tỉ lý do khiến bạn phải đọc quyển sách này”. Vắn tắt, nhanh gọn và trực tiếp, những câu chuyện và những lời khôn ngoan được chắt lọc trong suốt ba mươi năm của người luôn đứng đầu của sự thành công sẽ cho bạn những lời khuyên sâu sắc.<br>		    		Hãy nghe theo lòng mình nếu bạn muốn có một sự thay đổi kỳ diệu, kinh nghiệm của một tỉ phú sẽ rất có ích cho bạn.<br>		    		Có ít nhất năm tỷ lý do khiến bạn phải đọc quyển sách này.", "Tôi Đã Làm Giàu Như Thế", 280, 65000.0, 1, 2017, "NXBT", "toi-da-lam-giau-nhu-the", null, new DateTime(2020, 10, 19, 2, 39, 0, 0, DateTimeKind.Unspecified) },
                    { "S046", "A034", "KT", new DateTime(2020, 5, 20, 1, 55, 0, 0, DateTimeKind.Unspecified), null, "Sách là tự truyện của một tỷ phú bất động sản Mỹ - Donald J.Trump. Ông còn là ông trùm của một số chương trình truyền hình thu hút và là tác giả của vài quyển sách best-seller.<br>		    		Tác giả cho người đọc thấy được cách nghĩ của một tỷ phú về tiền bạc, cuộc sống, sự nghiệp và cuộc sống. Bạn sẽ tìm thấy lời khuyên giá trị về đầu tư bất động sản, từ đánh giá bất động sản đến việc mua, bán và tái đầu tư. Bên cạnh đó, ông cũng chỉ cho bạn cách gây ấn tượng với mọi người, cách \"chỉnh\" và phê bình người khác, cách để hiểu bạn bè... tất cả mọi thứ bạn cần để tiến về phía trước.<br>		    		Rất có thể những kinh nghiệm ông có được khá xa với bạn nhhưng chắc chắn cuốn sách sẽ là nguồn cảm hứng vô cùng giá trị với bạn, để bạn có thể giàu có và thành công. Hy vọng bạn sẽ đạt được điều tác giả nói:\" Cho dù bạn chỉ hấp thụ được 10% những hướng dẫn trong cuốn sách này, bạn cũng sẽ có cơ hội tốt để trở thành triệu phú.\"", "Nghĩ Như Một Tỷ Phú", 254, 54000.0, 6, 2011, "NXBT", "nghi-nhu-mot-ty-phu", null, new DateTime(2020, 10, 21, 12, 5, 0, 0, DateTimeKind.Unspecified) },
                    { "S002", "A002", "KT", new DateTime(2020, 5, 19, 4, 51, 0, 0, DateTimeKind.Unspecified), null, "\"Ai cũng có một cuộc sống, ai cũng làm việc cần cù, ai cũng ước mơ được thành công, nhưng không mấy ai may mắn học được cách tư duy độc đáo và tầm nhìn của những tỷ phú lừng danh đã tiết lộ trong cuốn sách giá trị này\"<br>		    	(Wall Street Journal)<br>		    	Trong cuốn sách này T. Harv Eker sẽ tiết lộ những bí mật tại sao một số người lại đạt được những thành công vượt bậc, được số phận ban cho cuộc sống sung túc, giàu có, trong khi một số người khác phải chật vật, vất vả mới có một cuộc sống qua ngày. Bạn sẽ hiểu được nguồn gốc sự thật và những yếu tố quyết định thành công, thất bại để rồi áp dụng, thay đổi cách suy nghĩ, lên kế hoạch rồi tìm ra cách làm việc, đầu tư, sử dụng nguồn tài chính của bạn theo hướng hiệu quả nhất.", "Bí Mật Tư Duy Triệu Phú", 100, 54000.0, 6, 2019, "TH", "bi-mat-tu-duy-trieu-phu", null, new DateTime(2020, 10, 21, 8, 15, 0, 0, DateTimeKind.Unspecified) },
                    { "S033", "A017", "VHNN", new DateTime(2020, 5, 20, 1, 9, 0, 0, DateTimeKind.Unspecified), null, "Khắp làng trên xóm dưới Herfordshire xôn xao: Netherfield sắp có người thuê, mà còn là một quý ông chưa vợ với khoản lợi tức lên đến năm nghìn bảng mỗi năm. Chao ôi, quả là tin đáng mừng đối với gia đình ông bà Bennett, vốn có tới năm cô con gái cần phải gả chồng. Giữa những quay cuồng vũ hội cùng âm mưu toan tính của cả một xã hội ganh đua nhau tìm tấm chồng tốt cho các cô gái, nổi lên câu chuyện tình của cô con gái thứ cứng đầu Elizabeth và chàng quý tộc Darcy - nơi lòng Kiêu hãnh phải nhún nhường và Định kiến cần giải tỏa để có thể đi đến kết cục hoàn toàn viên mãn.<br>		    		Suốt hơn 200 năm qua, Kiêu hãnh và Định kiến luôn nằm trong số những tiểu thuyết tiếng Anh được yêu mến nhất. Chính Jane Austen cũng coi tác phẩm xuất sắc này là \"đứa con cưng\" của bà. Tài năng của Austen quả thực đã biến câu chuyện tình sôi nổi nơi miền quê nước Anh thành một bản châm biếm sắc sảo hóm hỉnh và một viên ngọc quý trong kho tàng Anh ngữ.", "Kiêu Hãnh Và Định Kiến", 352, 61000.0, 2, 2017, "HNV", "kieu-hanh-va-dinh-kien", null, new DateTime(2020, 10, 19, 2, 25, 0, 0, DateTimeKind.Unspecified) },
                    { "S001", "A001", "KT", new DateTime(2020, 5, 19, 4, 38, 0, 0, DateTimeKind.Unspecified), null, "Trong chứng khoán và thị trường tài chính, dám tham gia đầu tư cũng là một thành công tâm lý ban đầu. Dù vậy, 95% nhà đầu tư Việt Nam thuộc nhóm nhà đầu tư nhỏ lẻ với vốn kiến thức tài chính vô cùng hạn chế. Họ tham gia vào thị trường chứng khoán với 100% ý chí và sự quyết tâm chiến thắng thị trường, nhưng thật không may mắn kết cục cuối cùng của họ luôn là sự thất bại và mất tiền.<br>		    		Bởi vì, chúng ta thường dễ dàng nghe theo các “lời khuyên miễn phí” đến từ bạn bè, những người môi giới, những người nghe ngóng thông tin từ các “đội lái” làm giá và thao túng chứng khoán. Chúng ta không biết làm thế nào để phân biệt hai khái niệm “giá cả – pricing” và “giá trị – value”. Hay mua mua, bán bán liên tục hàng ngày với việc dán mắt vào bảng điện tử, phân tích biểu đồ, đường trung bình giá… và mong đợi một vận may cổ phiếu cùng giá của nó sẽ đi theo suy đoán của mình?<br>		    		Rất nhiều “nhà đầu tư” không hề có một hệ thống đầu tư chuẩn mực nào cả. Không biết cách và những tiêu chí để tìm kiếm cổ phiếu, theo dõi, quyết định điểm mua và quyết định thời điểm bán ra. Vì không có hệ thống đầu tư chuẩn mực nên kết quả chúng ta chỉ có một sự lựa chọn đó chính là THUA LỖ.<br>		    		Vậy có phải chỉ có những chuyên gia tài chính mới có thể gặt hái thành công trên thị trường chứng khoán? Để kiếm được tiền từ chứng khoán bạn phải sở hữu hàng tá kho tàng kiến thức tài chính vốn không dễ dàng “hấp thụ” trong một sớm một chiều? <br>		    		Không hẳn vậy. Có rất nhiều người dù không được đào tạo bài bản về các kiến thức tài chính, dù vẫn là những người đầu tư nhỏ lẻ họ vẫn chiến thắng thị trường và làm giàu được từ chứng khoán. Đó là bởi vì họ có được một hệ thống đầu tư chuẩn mực, biết vận dụng các công cụ phân tích, biết tuân thủ các nguyên tắc trong đầu tư.<br>		    		Có một hệ thống đầu tư chuẩn mực đã và đang được những nhà đầu tư bậc thầy trên thế giới như Warren Buffett, Charlie Munger… áp dụng. Hệ thống đầu tư và phương pháp đầu tư ưu việt đó đã được gói gọn và thực sự dễ hiểu trong cuốn PayBack Time – Ngày đòi nợ của tác giả Phil Town.<br>		    		NGÀY ĐÒI NỢ – Payback Time là cuốn sách bán chạy nhất New York Time được tác giả Phil Town sử dụng những ngôn ngữ đơn giản, dễ hiểu và lồng ghép những ví dụ thực tế giúp cho người đọc tiếp cận với những kiến thức về đầu tư chứng khoán một cách dễ dàng. Bên cạnh đó với những kiến thức và trải nghiệm của bản thân, chúng tôi đã đưa cuốn sách gần gũi hơn với bạn đọc Việt Nam.<br>		    		Cuốn sách sẽ hướng dẫn bạn từ cách thức lựa chọn, đánh giá cổ phiếu, cho đến xây dựng cho mình một danh mục các cổ phiếu sẽ mua, mức giá mua–bán nào là hợp lý, cùng với những nguyên tắc mà bạn phải tuân theo… và cứ thực hành như vậy cho tới khi bạn trở nên giàu có.<br>		    		“Một cuộc sống hạnh phúc được bắt đầu từ những quyết định đầu tư khôn ngoan”. Ngay ngày hôm nay, hãy bắt đầu quyết định đầu tư khôn ngoan của bạn bằng việc trang bị một hệ thống và phương pháp đầu tư hoàn chỉnh đã được chứng minh hiệu quả tuyệt đối qua thời gian được trình bày trong cuốn sách này. Bởi vì: Kiếm một số tiền lớn từ đầu tư chứng khoán chính là cách “trả thù” tốt nhất cho tương lai tài chính của bạn vốn đã bị cướp đi trước đây.", "Payback Time - Ngày Đòi Nợ", 284, 299000.0, 7, 2017, "VH-NT", "payback-time-ngay-doi-no", null, new DateTime(2020, 10, 21, 12, 17, 0, 0, DateTimeKind.Unspecified) },
                    { "S014", "A008", "STN", new DateTime(2020, 5, 19, 7, 26, 0, 0, DateTimeKind.Unspecified), null, "Bóng tối đã tràn vào thị trấn. Những sự việc kỳ quái liên tiếp xảy ra trong đêm khuya. Thay vì những đồng xu sáng lấp lánh của bà tiên răng, bọn trẻ lại tìm thấy... một con ốc sên chết, một con nhện sống, hàng trăm con bọ sâu tai bò lúc nhúc dưới gối.<br>		    		Ai đang đứng sau những chuyện này?<br>		    		Liệu đó có phải là mụ Nha sĩ yêu quái?<br>		    		Hãy cùng Alfie và bạn bè tìm ra câu trả lời!<br>		    		Nhận định<br>		    		\"Một kết hợp thành công của sự dí dỏm và tình người ấm áp.\" - Telegraph.<br>		    		\"Tôi thực sự yêu thích những cuốn sách của David Walliams. Chỉ một vài năm nữa thôi, chúng sẽ trở thành kinh điển.\" - Sue Townsend, tác giả sáng tạo nên Adrian Mole.", "Nha Sĩ Yêu Quái", 407, 64000.0, 2, 2016, "HNV", "nha-si-yeu-quai", null, new DateTime(2020, 10, 20, 5, 9, 0, 0, DateTimeKind.Unspecified) },
                    { "S013", "A008", "STN", new DateTime(2020, 5, 19, 7, 26, 0, 0, DateTimeKind.Unspecified), null, "Zoe luôn mơ ước được có một sô diễn xiếc chuột của riêng mình, nhưng chú chuột hamster của con bé đã chết một cách đột ngột, còn chuột cưng mới thì đang gặp nguy hiểm chết người.<br>		    		Tương lai thảm khốc nào chờ đang đợi nó?<br>		    		Và ai đang đứng sau tất cả chuyện này?<br>		    		Là bà mẹ kế bị ám ảnh với món bim bim vị tôm cốc tai và cực kỳ ghét chuột...<br>		    		... hay kẻ bán món bánh mì kẹp bí ẩn nhưng vô cùng hút khách?<br>		    		---<br>		    		“Thú vị từ đầu chí cuối... một Roald Dahl thế hệ mới.”<br>		    		- The Times<br>		    		“David Walliams đã trở thành một tác giả có sức ảnh hưởng dữ dội trong giới văn học thiếu nhi.”<br>		    		- The Sun", "Bánh Mì Kẹp Chuột", 248, 51000.0, 10, 2019, "HNV", "banh-mi-kep-chuot", null, new DateTime(2020, 10, 20, 22, 35, 0, 0, DateTimeKind.Unspecified) },
                    { "S012", "A008", "STN", new DateTime(2020, 5, 19, 7, 26, 0, 0, DateTimeKind.Unspecified), null, "Trong quyển sách này, tác giả muốn gửi đến đọc giả chuyến \"vượt ngục\" ly kỳ của hai ông cháu trong câu chuyện. Giọng văn tình cảm, dí dỏm, nét vẽ đáng yêu… nhằm giúp các em tiếp nhận và thẩm thấu nhanh nhất.<br>		    		Câu chuyện đem lại những bài học hay về lối sống trung thực, về tình yêu thương gia đình và nhiều điều cần thiết để phát triển nhân cách cho bạn đọc trẻ tuổi, cũng như những bất ngờ thú vị cho cả người đọc trưởng thành.", "Ông Nội Vượt Ngục", 428, 70000.0, 6, 2018, "HNV", "ong-noi-vuot-nguc", "A009", new DateTime(2020, 10, 20, 21, 11, 0, 0, DateTimeKind.Unspecified) },
                    { "S011", "A008", "STN", new DateTime(2020, 5, 19, 7, 26, 0, 0, DateTimeKind.Unspecified), null, "Trên đời có đủ kiểu bố. Có bố béo và bố gầy, bố cao và bố thấp.<br>		    		Có bố trẻ và bố già, bố thông minh và bố tối dạ. Có bố ngớ ngẩn và bố nghiêm túc, bố ồn ã và bố lặng lẽ. Và dĩ nhiên tất cả đều là những ông bố tốt.<br>		    		Nhưng có thực như vậy?<br>		    		“Một câu chuyện kịch tính và ấm lòng sẽ khiến độc giả hồi hộp nhấp nhổm, có lúc cười thả ga, có lúc lại cảm động rơi nước mắt.”<br>		    		- HarperCollins<br>		    		“Bố xấu, bố tốt là một câu chuyện táo bạo, xuất sắc và tuyệt đẹp. Cuốn sách chắc chắn sẽ chiếm một chỗ đứng vững chãi trong trái tim độc giả của Walliams.”<br>		    		- Ann-Janine Murtagh", "Bố Xấu , Bố Tốt", 444, 83000.0, 1, 2019, "HNV", "bo-xau-bo-tot", null, new DateTime(2020, 10, 19, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "S038", "A022", "VHNN", new DateTime(2020, 5, 20, 1, 26, 0, 0, DateTimeKind.Unspecified), null, "Bị người yêu lừa dối, Takako bỏ việc và rơi vào chuỗi ngày ngủ triền miên để trốn tránh nỗi buồn. Thế rồi, một cuộc điện thoại từ người cậu ruột cả 10 năm trời không gặp đã đánh thức cô khỏi cơn mộng mị. Takako đồng ý đến trông hiệu sách nửa buổi giúp cậu chỉ để làm vừa lòng mẹ. Nhưng thật ngoài tưởng tượng, chờ đợi cô là hiệu sách Morisaki cũ kỹ với thế giới của hàng nghìn cuốn sách chứa trong mình cả thời gian và lịch sử. Sách đã chữa lành vết thương trong lòng cô.<br>		    		Và hơn thế nữa, Takako tìm thấy bao nhiêu điều mới mẻ và thú vị mà trước đây cô chưa từng biết đến.Câu chuyện nhẹ nhàng mà sâu lắng, đặc biệt với những ai có sở thích sưu tầm sách cổ.", "Những Giấc Mơ Ở Hiệu Sách Morisaki", 118, 39000.0, 4, 2017, "HN", "nhung-giac-mo-o-hieu-sach-morisaki", null, new DateTime(2020, 10, 20, 9, 47, 0, 0, DateTimeKind.Unspecified) },
                    { "S017", "A013", "TD-KNS", new DateTime(2020, 5, 19, 21, 56, 0, 0, DateTimeKind.Unspecified), null, "Sau sự thành công ngoài sức tưởng tượng của cuốn sách đầu tay “Cuộc sống rất giống cuộc đời”, sau 4 năm, tác giả Hoàng Hải Nguyễn mới trở lại với độc giả với cuốn sách siêu hài hước “Cuộc sống đếch giống cuộc đời” – dự báo một hiện tượng mạng trong thời gian tới.<br>		    	Ghi dấu ấn mạnh mẽ nhờ giọng văn phóng khoáng, hóm hỉnh, sâu cay và đặc biệt là biệt tài gây cười đặc trưng có một không hai, chắc chắn với cuốn sách tiếp theo này, tác giả Hoàng Hải Nguyễn sẽ tiếp tục chinh phục các độc giả khó tính nhất.<br>		    	Luôn tâm niệm mình là một người viết yêu văn chương, chính vì thế mà các bài viết của anh không tạo cảm giác ức chế hay nhàm chán với những lối đi cũ mòn của văn chương hoa mĩ. Dưới góc nhìn của một người đàn ông U40, đã có gia đình và hai con, anh nhìn nhận sự xoay vần của cuộc đời theo cách của người từng trải có nhiều kinh nghiệm.<br>		    	Những câu chuyện về tổ ấm gia đình, chuyện xã hội, chuyện cuộc sống, chuyện phiếm bên lề được kết hợp khéo léo với chất văn “rất đàn ông” là điểm sáng giúp anh ghi dấu trong lòng bạn đọc. Từ những con chữ thông minh, ,sắc lẹm như lưỡi dao ấy, lại khiến người đọc trăn trở, đau đáu, có một khoảng lặng để suy ngẫm và nhận ra nhiều điều có ích.<br>		    	“Gia đình là thứ bất khả xâm phạm. Cứ tin tôi, mọi sự thành công trong xã hội đều không thể bù đắp được thất bại trong cuộc sống gia đình”.<br>		    	Nếu mong chờ một tác phẩm văn học chính thống với những câu chữ khô khốc, thì hẳn là cuốn sách sẽ khiến bạn thất vọng. Nhưng nếu bạn đang cảm thấy bế tắc trong cuộc sống, cần một ai đó xốc lại tinh thần để tiếp tục chiến đấu với cuộc đời thì chắc chắn không nên bỏ lỡ cuốn sách này. Cuộc sống đếch giống cuộc đời sẽ đem lại cho bạn những tiếng cười sảng khoái, những phút giây thư giãn cùng những bài học sâu sắc, tâm đắc qua từng trang sách.<br>		    	Giống như lời tác giả tâm sự “Cuộc sống rất giống cuộc đời vì cuộc sống là tập hợp của vô số cuộc đời, cuộc sống không giống cuộc đời vì cuộc đời là hữu hạn còn cuộc sống là vô hạn. Cho dù cuộc sống hay cuộc đời của bạn có khó khan vất vả thế nào thì tôi vẫn mong các bạn hãy luôn suy nghĩ một cách tích cực và hài hước nhất.<br>		    	Có người đã nói rằng: Cuối cùng thì mọi thứ đều sẽ ổn, nếu chưa ổn thì tức là chưa phải cuối cùng. Vậy đấy các bạn ạ!", "Cuộc Sống \"Đếch\" Giống Cuộc Đời", 216, 62000.0, 2, 2020, "HN", "cuoc-song-dech-giong-cuoc-doi", null, new DateTime(2020, 10, 20, 9, 41, 0, 0, DateTimeKind.Unspecified) },
                    { "S052", "A037", "KHCN", new DateTime(2020, 5, 20, 2, 31, 0, 0, DateTimeKind.Unspecified), null, "Cuốn sách là câu chuyện người thực việc thực (tác giả cũng là nhân vật chính) kể về cuộc săn đuổi hacker bất đắc dĩ của một nhà khoa học chuyển tay ngang trở thành nhà quản lý hệ thống mạng máy tính ở Phòng Thí nghiệm Lawrence Berkeley, California, Mỹ.<br>		    	Từ một mức chênh lệch 75 xu trong hệ thống kế toán của phòng thí nghiệm, Cliff Stoll nghi ngờ có người đang sử dụng trái phép hệ thống của mình. Với quyết tâm tìm cho ra sự thật, Stoll bắt tay vào chuyến phiêu lưu một mình cùng gã hacker bí ẩn. Với những công cụ theo dõi thô sơ tự chế do không nhận được sự hỗ trợ của bất cứ ai – dẫu đã năm lần bảy lượt gõ cửa FBI, CIA và vô số các cơ quan an ninh, quân sự khác, Stoll đã rong ruổi theo gã hacker qua những mạng lưới quân sự nhạy cảm, các căn cứ quân sự, vệ tinh xuyên Đại Tây Dương, Nhật, và Đức. Cuối cùng, cũng bằng một chiến lược tự chế, anh đã bắt được một hacker quốc tế với động cơ là tiền, cocaine, và những âm mưu tình báo.<br>		    		Câu chuyện ly kỳ đến phút chót này đã trở thành nguồn cảm hứng cho nhiều chương trình truyền hình sau này ở Mỹ, và Stoll còn được nhận bằng khen của CIA, đồng thời trở thành một chuyên gia – có phần bất đắc dĩ – được nhiều người tìm kiếm để xin tư vấn về an ninh mạng", "The Cuckoo's Egg", 516, 176000.0, 1, 2018, "CT", "The Cuckoo's Egg", "A041", new DateTime(2020, 10, 19, 2, 40, 0, 0, DateTimeKind.Unspecified) },
                    { "S051", "A036", "KHCN", new DateTime(2020, 5, 20, 2, 31, 0, 0, DateTimeKind.Unspecified), null, "Trong cuốn sách này, Kevin Mitnick, hacker nổi tiếng nhất thế giới, sẽ hướng dẫn các biện pháp dễ thực hiện (và ít tốn kém) giúp bạn – trên cương vị một cá nhân bình thường và một người tiêu dùng – có thể giấu các thông tin nhận dạng cá nhân của mình trong kỷ nguyên của Dữ liệu Lớn, vốn không thiếu những scandal quy mô quốc tế về những vụ vi phạm dữ liệu người dùng thường xuyên xuất hiện trên các mặt báo. Mitnick bàn đến nhiều phương tiện mà chúng ta sử dụng hằng ngày – từ điện thoại, email, cho đến tin nhắn,… – chỉ ra những lỗ hổng mà người khác có thể lợi dụng để giành quyền kiểm soát các dữ liệu của chúng ta, đồng thời đưa ra những giải pháp phòng chống cụ thể và hữu hiệu mà bất kỳ ai cũng có thể thực hiện để tự bảo vệ mình.<br>		    		Nhưng có lẽ một trong những giá trị quan trọng nhất của cuốn sách là qua đó, tác giả đã giải ảo niềm tin thơ ngây của đại đa số chúng ta rằng những hoạt động của mình trên mạng là đàng hoàng và lành mạnh nên có thể công khai, rằng chỉ những người có ý đồ xấu mới phải tìm cách che giấu các dữ liệu cá nhân. Hay nói như Mikko Hypponen, nhà nghiên cứu trưởng của hãng bảo mật F-Secure, thì: “Có thể bạn không có gì phải giấu diếm. Nhưng bạn có rất nhiều thứ phải bảo vệ đấy.”<br>		    		“Hacker bị săn lùng gắt gao nhất của FBI.” – Wired<br>		    		“Hacker nổi tiếng nhất thế giới kiêm người hùng trong nền văn hóa mạng new Book {…} vừa viết cuốn cẩm nang về an ninh hệ thống dựa trên chính những kinh nghiệm của mình. Đây là tài liệu phải đọc đối với các chuyên gia IT, nhưng đồng thời còn dành cho cả công chúng nói chung, giới hàn lâm, và các doanh nghiệp.” – Library Journal<br>		    		“Còn ai khác xứng đáng hơn Mitnick – hacker bị truy nã quốc tế rồi trở thành cố vấn an ninh cho các doanh nghiệp Fortune 500 – trong vai trò người thầy hướng dẫn bạn cách giữ an toàn cho dữ liệu trước những cuộc tấn công lừa đảo, sâu máy tính, và những tổ chức gián điệp mạng như Fancy Bears?” – Esquire<br>		    		“new Book {Nghệ thuật ẩn mình} là lời cảnh tỉnh, nhắc nhở chúng ta rằng các dữ liệu thô – từ email, ô tô, mạng wifi ở nhà,… – khiến chúng ta dễ dàng trở thành nạn nhân như thế nào.” - New York Times Book Review<br>		    		Về tác giả:<br>		    		Kevin David Mitnick (sinh năm 1963) là một cố vấn an ninh máy tính, tác giả, và trước đó là hacker lão luyện người Mỹ, từng khiến các nhà điều tra phải đau đầu, rốt cuộc ngồi tù 5 năm vì nhiều tội án liên quan đến máy tính như chiếm đoạt quyền truy cập thiết bị trái phép, nghe trộm các hoạt động liên lạc qua điện thoại và máy tính, truy cập trái phép vào hệ thống máy tính liên bang,…<br>		    		Hiện nay, ông quản lý hãng tư vấn an ninh Mitnick Security Consulting chuyên cung cấp dịch vụ kiểm thử mức độ an ninh và xác định các lỗ hổng an ninh tiềm tàng cho các tổ chức. Ngoài ra, ông còn là Hacker trưởng của KnowBe4, hãng đào tạo nâng cao nhận thức về an ninh, và là thành viên hội đồng cố vấn của Zimperium, hãng phát triển hệ thống ngăn chặn xâm nhập trên các thiết bị di động.", "The Art of Invisibility", null, 189000.0, 2, 2017, "CT", "the-art-of-invisibility", "A042", new DateTime(2020, 10, 19, 23, 20, 0, 0, DateTimeKind.Unspecified) },
                    { "S050", "A038", "KHCN", new DateTime(2020, 5, 20, 2, 31, 0, 0, DateTimeKind.Unspecified), null, "Vào thời kỳ mà các thành viên của Anonymous – nhóm hacker đình đám nhất thế giới ngày nay – còn chưa xuất hiện, Kevin Mitnick đã trở thành nỗi kinh hoàng của không biết bao nhiêu điều tra viên FBI, các cơ quan chính phủ, các công ty cung cấp dịch vụ mạng và điện thoại. Với tài năng phi thường và niềm đam mê công nghệ khó ai sánh bằng, chỉ bằng các đòn tấn công bằng kỹ thuật xã hội (mạo danh, nghe lén, lục thùng rác,…), Mitnick đã thuyết phục được các nhân viên tại những công ty và cơ quan này giao nộp những thông tin cơ mật và vượt qua được nhiều lớp bảo mật để tiếp cận những dữ liệu mà ít người được biết. Có lẽ trên đời này sẽ chẳng có hacker nào dám cả gan nghe lén cả FBI, cơ quan điều tra sừng sỏ nhất thế giới, như Kevin Mitnick.<br>		    		Cao trào của cuốn sách là khi Mitnick bắt đầu chuyến phiêu lưu chạy trốn khỏi FBI trong suốt ba năm. Ông đã tạo ra các danh tính giả, tìm việc tại nhiều thành phố mà vẫn kiểm soát được những kẻ đang truy đuổi mình. Dù phải lẩn trốn liên tục, rời xa gia đình và bạn bè nhưng Mitnick chưa khi nào từ bỏ niềm đam mê hacking của mình cho tới tận lúc bị bắt và phải chấp nhận kết cục lãnh án biệt giam, cách ly với mọi loại máy tính.<br>		    		Giờ đây, khi đã hoàn lương và ngẩng cao đầu trên đường đời, tác giả của cuốn sách Bóng ma trên mạng lại trải lòng với đám “hậu sinh” về quá khứ oai hùng nhưng cũng không kém phần ấn tượng của mình, những gì ông rút ra trong thời gian bị xộ khám và cũng để đính chính những tin đồn sai lệch xoay quanh Huyền thoại về Kevin Mitnick.<br>		    		Với cách viết hài hước, dí dỏm, nhưng không kém phần lôi cuốn, Bóng ma trên mạng có thể coi là một bộ phim hành động hoàn hảo, một góc nhìn chân thật về cuộc đời của một trong những tội phạm mạng cấp cao đầu tiên trên toàn cầu, người được mệnh danh là “hacker bị truy nã gắt gao nhất thế giới giới”.<br>		    		Về tác giả:  <br>		    		Kevin Mitnick từng là hacker nổi tiếng nhất thế giới và giờ là một chuyên gia tư vấn về bảo mật. Anh là chủ đề của không biết bao nhiêu tin tức và báo đài tạp chí. Anh đã xuất hiện trên vô số chương trình truyền hình và phát thanh để đưa ra những bình luận chuyên sâu về bảo mật thông tin. Anh đã làm chứng trước Thượng viện Mỹ và viết bài cho tạp chí Harvard Business Review. Mitnick là đồng tác giả, cùng với William B. Simon, của những cuốn sách bán chạy nhất The Art of Deception (tạm dịch: Nghệ thuật lừa dối) và The Art of Intrusion(tạm dịch: Nghệ thuật xâm nhập). Anh hiện sống ở Las Vegas, Nevada.", "Bóng Ma Trên Mạng", 524, 149000.0, 12, 2018, "CT", "bong-ma-tren-mang", "A040", new DateTime(2020, 10, 19, 2, 39, 0, 0, DateTimeKind.Unspecified) },
                    { "S044", "A030", "VHNN", new DateTime(2020, 5, 20, 1, 47, 0, 0, DateTimeKind.Unspecified), null, "Tiếng Gọi Của Hoang Dã là một tiểu thuyết nổi tiếng thế giới của nhà văn Mỹ - Jack London. Cốt truyện kể về một chú chó tên là Buck đã được thuần hóa, cưng chiều. Nhưng do một loạt các sự kiện xảy ra khi Buck bị bắt khỏi trang trại, để trở thành chó kéo xe ở khu vực Alaska lạnh giá; trong giai đoạn mọi người đổ xô đi tìm vàng thế kỷ 19, thiên nhiên nguyên thủy đã đánh thức bản năng của Buck. Buck trở lại cuộc sống hoang dã, Buck trở về rừng và sống chung với lũ sói.<br>		    		Xuất bản lần đầu năm 1903, Tiếng Gọi Của Hoang Dã là một trong những tiểu thuyết Best seller của nhà văn Jack London và được xem là tác phẩm hay nhất của ông.", "Tiếng Gọi Của Hoang Dã", 226, 44000.0, 8, 2016, "VH", "tieng-goi-cua-hoang-da", null, new DateTime(2020, 10, 19, 2, 38, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Cart",
                columns: new[] { "Id", "CreatedAt", "CustomerId", "DeletedAt", "IsActive" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 12, 4, 5, 50, 20, 0, DateTimeKind.Unspecified), "KH003", null, 1 },
                    { 2, new DateTime(2020, 12, 4, 6, 27, 20, 0, DateTimeKind.Unspecified), "KH021", null, 1 },
                    { 3, new DateTime(2020, 12, 4, 7, 7, 20, 0, DateTimeKind.Unspecified), "KH002", null, 1 }
                });

            migrationBuilder.InsertData(
                table: "EmployeeAuthorization",
                columns: new[] { "EmployeeId", "CreatedAt", "Delete", "DeletedAt", "Insert", "Update", "UpdatedAt", "View" },
                values: new object[] { "NV001", new DateTime(2020, 7, 3, 21, 42, 36, 0, DateTimeKind.Unspecified), 1, null, 1, 1, new DateTime(2020, 7, 3, 23, 1, 51, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "EmployeeAuthorization",
                columns: new[] { "EmployeeId", "CreatedAt", "DeletedAt", "UpdatedAt", "View" },
                values: new object[] { "NV002", new DateTime(2020, 7, 3, 21, 42, 44, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 7, 3, 21, 42, 44, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "EmployeeAuthorization",
                columns: new[] { "EmployeeId", "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { "NV003", new DateTime(2020, 7, 3, 21, 49, 24, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 7, 3, 21, 49, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "EmployeeAuthorization",
                columns: new[] { "EmployeeId", "CreatedAt", "DeletedAt", "UpdatedAt", "View" },
                values: new object[] { "NV004", new DateTime(2020, 7, 4, 6, 42, 13, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 7, 4, 6, 46, 13, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "Id", "Address", "CouponId", "CreatedAt", "CustomerId", "Email", "Name", "Note", "PaymentMethodId", "Phone", "StatusId", "SubTotal", "Total", "UpdatedAt" },
                values: new object[,]
                {
                    { "DH026", "351/18A Lê Đại Hành F.11, Q.11", null, new DateTime(2019, 7, 31, 10, 2, 47, 0, DateTimeKind.Unspecified), "KH021", "vinh@gmail.com", "Đỗ Thành Vĩnh", null, 1, "0908110026", 1, 60000.0, 60000.0, new DateTime(2020, 7, 1, 10, 2, 47, 0, DateTimeKind.Unspecified) },
                    { "DH030", "280 An Dương Vương", null, new DateTime(2020, 10, 20, 22, 29, 11, 0, DateTimeKind.Unspecified), "KH036", "leminh@gmail.com", "Lê Minh", "Gọi điện thoại trước khi giao.", 1, "0987896757", 2, 337000.0, 337000.0, new DateTime(2020, 10, 20, 22, 38, 15, 0, DateTimeKind.Unspecified) },
                    { "DH029", "62/20B Đinh Bộ Lĩnh, F.26, Q.BT", null, new DateTime(2019, 11, 24, 12, 33, 40, 0, DateTimeKind.Unspecified), "KH027", "thaominh@gmail.com", "Nguyễn Thị Minh Thảo", null, 1, "0923312776", 1, 119000.0, 119000.0, new DateTime(2019, 11, 24, 12, 33, 40, 0, DateTimeKind.Unspecified) },
                    { "DH001", "Tổ 4, Khu 5B, Bãy Cháy, TP. Hạ Long, Tỉnh Quảng Ninh", null, new DateTime(2020, 6, 25, 5, 47, 7, 0, DateTimeKind.Unspecified), null, "minhthu9979@gmail.com", "NGÔ THỊ MINH THƯ", "Gọi điện thoại trước khi giao hàng", 1, "0913369555", 2, 712000.0, 712000.0, new DateTime(2020, 7, 4, 1, 39, 40, 0, DateTimeKind.Unspecified) },
                    { "DH002", "330 Cách Mạng Tháng Tám, Phường 10, Quận 3, TP.HCM", null, new DateTime(2020, 6, 25, 7, 58, 56, 0, DateTimeKind.Unspecified), "KH002", "cuongphuong78@yahoo.com", "ĐOÀN HỮU MINH", null, 1, "0938189742", 2, 152000.0, 152000.0, new DateTime(2020, 7, 1, 22, 40, 19, 0, DateTimeKind.Unspecified) },
                    { "DH003", "280 An Dương Vương P4 Q5 TPHCM", null, new DateTime(2020, 6, 25, 8, 2, 14, 0, DateTimeKind.Unspecified), "KH002", "cuongphuong78@yahoo.com", "ĐOÀN HỮU MINH", "Giao giờ hành chính", 1, "0938189742", 2, 206000.0, 206000.0, new DateTime(2020, 7, 2, 9, 24, 29, 0, DateTimeKind.Unspecified) },
                    { "DH004", "327 Nguyễn Trọng Tuyển, Phường 10, Quận Phú Nhuận, TP.HCM", null, new DateTime(2020, 6, 26, 10, 1, 49, 0, DateTimeKind.Unspecified), null, "kingdragon_20988@gmail.com", "NGUYỄN VÕ HUY HOÀNG", null, 1, "0902797879", 2, 598000.0, 598000.0, new DateTime(2020, 6, 30, 19, 36, 42, 0, DateTimeKind.Unspecified) },
                    { "DH005", "Phòng 0.36 Tòa Nhà Centec Tower, 72-74 Nguyễn Thị Minh Khai, P.6, Q.3, TP.HCM", null, new DateTime(2020, 6, 26, 12, 48, 4, 0, DateTimeKind.Unspecified), null, "kelvin.nam@bfcot.com", "LÊ HỒNG NAM", null, 1, "0903377548", 1, 607000.0, 607000.0, new DateTime(2020, 6, 30, 18, 5, 52, 0, DateTimeKind.Unspecified) },
                    { "DH006", "Tổ 4, Khu 4, Trần Hưng Đạo, TP. Hạ Long, Tỉnh Quảng Ninh", null, new DateTime(2020, 6, 30, 10, 38, 54, 0, DateTimeKind.Unspecified), null, "2010longthanh@gmail.com", "PHẠM ANH THẮNG", null, 1, "0986908666", 1, 821000.0, 821000.0, new DateTime(2020, 6, 30, 10, 38, 54, 0, DateTimeKind.Unspecified) },
                    { "DH007", "109 Tổ 2, Khu Bến Cát, Phường Phước Bình, Quận 9, TP.HCM", null, new DateTime(2020, 6, 30, 20, 13, 12, 0, DateTimeKind.Unspecified), "KH003", "thao.nguyen@gazefi.com", "Nguyễn Phương Thảo", "Người nhận: Lê Văn Nam", 1, "0933335666", 1, 127000.0, 127000.0, new DateTime(2020, 6, 30, 20, 13, 12, 0, DateTimeKind.Unspecified) },
                    { "DH008", "40 Xuân Thủy, Phường Thảo Điền, Quận 2, TP.HCM", null, new DateTime(2020, 6, 30, 20, 15, 12, 0, DateTimeKind.Unspecified), null, "vanlangbds@vnn.vn", "NGUYỄN THÚY LAN", null, 1, "0909212222", 1, 111000.0, 111000.0, new DateTime(2020, 6, 30, 20, 15, 12, 0, DateTimeKind.Unspecified) },
                    { "DH009", "184/27 Đặng Văn Ngữ, Phường 14, Quận Phú Nhuận, TP.HCM", null, new DateTime(2020, 6, 30, 20, 16, 9, 0, DateTimeKind.Unspecified), null, "anvictory23881@yahoo.com.vn", "LÊ VĨNH AN", null, 1, "0906267888", 1, 268000.0, 268000.0, new DateTime(2020, 6, 30, 20, 16, 9, 0, DateTimeKind.Unspecified) },
                    { "DH010", "Số nhà 18 Ngõ 3, Tổ 8, Phường Giảng Võ, Quận Ba Đình, Hà Nội", null, new DateTime(2020, 6, 30, 20, 18, 46, 0, DateTimeKind.Unspecified), null, "tuananh@yahoo.com.vn", "HÀ TUẤN ANH", null, 1, "0903202808", 1, 90000.0, 90000.0, new DateTime(2020, 6, 30, 20, 18, 46, 0, DateTimeKind.Unspecified) },
                    { "DH011", "A1T8 Chung Cư 335 Cầu Giấy, Phường Dịch Vọng, Q. Cầu Giấy, Hà Nội", null, new DateTime(2020, 6, 30, 21, 0, 38, 0, DateTimeKind.Unspecified), null, "dung@lecoviet.com", "DƯƠNG THỊ THÙY DUNG", null, 1, "0915087777", 1, 90000.0, 90000.0, new DateTime(2020, 6, 30, 21, 0, 38, 0, DateTimeKind.Unspecified) },
                    { "DH025", "351/18A Lê Đại Hành F.11, Q.11", null, new DateTime(2020, 7, 1, 9, 51, 39, 0, DateTimeKind.Unspecified), "KH021", "vinh@gmail.com", "Đỗ Thành Vĩnh", null, 1, "0908110026", 1, 115000.0, 115000.0, new DateTime(2020, 7, 1, 9, 51, 39, 0, DateTimeKind.Unspecified) },
                    { "DH024", "42/4/7 đường số 13 F.11, Q.GV", null, new DateTime(2020, 7, 1, 9, 49, 55, 0, DateTimeKind.Unspecified), "KH024", "vanvan@gmail.com", "Lương Bích Vân", null, 1, "0955220676", 1, 94000.0, 94000.0, new DateTime(2020, 7, 1, 9, 49, 55, 0, DateTimeKind.Unspecified) },
                    { "DH023", "42/4/7 đường số 13 F.11, Q.GV", null, new DateTime(2020, 7, 1, 9, 48, 24, 0, DateTimeKind.Unspecified), "KH024", "vanvan@gmail.com", "Lương Bích Vân", null, 1, "0955220676", 1, 219000.0, 219000.0, new DateTime(2020, 7, 1, 9, 48, 24, 0, DateTimeKind.Unspecified) },
                    { "DH022", "42/4/7 đường số 13 F.11, Q.GV", null, new DateTime(2020, 7, 1, 9, 47, 2, 0, DateTimeKind.Unspecified), "KH024", "vanvan@gmail.com", "Lương Bích Vân", null, 1, "0955220676", 1, 216000.0, 216000.0, new DateTime(2020, 7, 1, 9, 47, 2, 0, DateTimeKind.Unspecified) },
                    { "DH021", "32/1C Trần Hưng Đạo, Q.5, TPHCM", null, new DateTime(2019, 7, 1, 9, 45, 3, 0, DateTimeKind.Unspecified), "KH025", "thy@gmail.com", "Thái Lê Ngọc Thy", null, 1, "0918265699", 1, 242000.0, 242000.0, new DateTime(2020, 7, 1, 9, 45, 3, 0, DateTimeKind.Unspecified) },
                    { "DH020", "32/1C Trần Hưng Đạo, Q.5, TPHCM", null, new DateTime(2019, 7, 1, 9, 41, 31, 0, DateTimeKind.Unspecified), "KH025", "thy@gmail.com", "Thái Lê Ngọc Thy", null, 1, "0918265699", 2, 150000.0, 150000.0, new DateTime(2020, 7, 2, 9, 24, 45, 0, DateTimeKind.Unspecified) },
                    { "DH027", "Tổ 4, Khu 5B, Bãy Cháy, TP. Hạ Long, Tỉnh Quảng Ninh", null, new DateTime(2020, 7, 2, 8, 53, 0, 0, DateTimeKind.Unspecified), null, "minhthu9979@gmail.com", "NGÔ THỊ MINH THƯ", null, 1, "0913369555", 1, 124000.0, 124000.0, new DateTime(2020, 7, 2, 8, 53, 0, 0, DateTimeKind.Unspecified) },
                    { "DH019", "43 đường 909 Tạ Quang Biểu, F.5, Q.8", null, new DateTime(2020, 7, 1, 9, 27, 54, 0, DateTimeKind.Unspecified), "KH020", "longvuv@gmail.com", "Tô Hữu Long Vũ", null, 1, "0908606399", 1, 134000.0, 134000.0, new DateTime(2020, 7, 1, 9, 27, 54, 0, DateTimeKind.Unspecified) },
                    { "DH017", "3B-2-2-5 Chung Cư Mỹ Viên, Nguyễn Lương Bằng, F.TÂn Phú, Q.7", null, new DateTime(2020, 7, 1, 9, 25, 28, 0, DateTimeKind.Unspecified), "KH019", "thuytrang@gmail.com", "Nguyễn Thị Thùy Trang", null, 1, "0918265681", 1, 59000.0, 59000.0, new DateTime(2020, 7, 1, 9, 25, 28, 0, DateTimeKind.Unspecified) },
                    { "DH028", "62/20B Đinh Bộ Lĩnh, F.26, Q.BT", null, new DateTime(2019, 11, 23, 12, 33, 10, 0, DateTimeKind.Unspecified), "KH027", "thaominh@gmail.com", "Nguyễn Thị Minh Thảo", null, 1, "0923312776", 1, 200000.0, 200000.0, new DateTime(2019, 11, 23, 12, 33, 10, 0, DateTimeKind.Unspecified) },
                    { "DH015", "2/15B Trần Nhân Tôn, F2, Q.10 Trần Nhân Tôn, F2, Q.10 TP.HCM", null, new DateTime(2020, 6, 30, 22, 26, 29, 0, DateTimeKind.Unspecified), "KH006", "quynh@gmail.com", "Lê Thị Khánh Quỳnh", null, 1, "0918637176", 1, 265000.0, 265000.0, new DateTime(2020, 6, 30, 22, 26, 29, 0, DateTimeKind.Unspecified) },
                    { "DH014", "39 Bến Phú Định, F16, Q8, HCM", null, new DateTime(2020, 6, 30, 22, 24, 38, 0, DateTimeKind.Unspecified), "KH008", "sang001@gmail.com", "Phan Thanh Sang", null, 1, "0903120175", 1, 354000.0, 354000.0, new DateTime(2020, 6, 30, 22, 24, 38, 0, DateTimeKind.Unspecified) },
                    { "DH013", "39 Bến Phú Định, F16, Q8, HCM", null, new DateTime(2020, 6, 30, 22, 23, 53, 0, DateTimeKind.Unspecified), "KH008", "sang001@gmail.com", "Phan Thanh Sang", null, 1, "0903120175", 2, 186000.0, 186000.0, new DateTime(2020, 7, 1, 9, 20, 28, 0, DateTimeKind.Unspecified) },
                    { "DH012", "315 Khu Phố 2 - Thị trấn Hóc Môn - TPHCM", null, new DateTime(2020, 6, 30, 22, 22, 20, 0, DateTimeKind.Unspecified), "KH007", "hai2@gmail.com", "Trần Việt Hải", null, 1, "0913652449", 1, 136000.0, 136000.0, new DateTime(2020, 6, 30, 22, 22, 20, 0, DateTimeKind.Unspecified) },
                    { "DH018", "43 đường 909 Tạ Quang Biểu, F.5, Q.8", null, new DateTime(2020, 7, 1, 9, 27, 28, 0, DateTimeKind.Unspecified), "KH020", "longvuv@gmail.com", "Tô Hữu Long Vũ", null, 1, "0908606399", 1, 338000.0, 338000.0, new DateTime(2020, 7, 1, 9, 27, 28, 0, DateTimeKind.Unspecified) },
                    { "DH016", "3B-2-2-5 Chung Cư Mỹ Viên, Nguyễn Lương Bằng, F.TÂn Phú, Q.7", null, new DateTime(2020, 7, 1, 9, 25, 6, 0, DateTimeKind.Unspecified), "KH019", "thuytrang@gmail.com", "Nguyễn Thị Thùy Trang", null, 1, "0918265681", 1, 138000.0, 138000.0, new DateTime(2020, 7, 1, 9, 25, 6, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "BookImage",
                columns: new[] { "Id", "BookId", "CreatedAt", "Image", "Primary" },
                values: new object[,]
                {
                    { 50, "S050", new DateTime(2020, 5, 20, 2, 31, 20, 0, DateTimeKind.Unspecified), "bongmatrenmang.jpg", 1 },
                    { 31, "S031", new DateTime(2020, 5, 20, 1, 9, 57, 0, DateTimeKind.Unspecified), "haisophan.jpg", 1 },
                    { 30, "S030", new DateTime(2020, 5, 20, 0, 58, 28, 0, DateTimeKind.Unspecified), "truyenmotcaithuyendat.jpg", 1 },
                    { 53, "S053", new DateTime(2020, 5, 20, 5, 0, 1, 0, DateTimeKind.Unspecified), "doraemongiasutienganh.jpg", 1 },
                    { 57, "S057", new DateTime(2020, 10, 20, 0, 1, 29, 0, DateTimeKind.Unspecified), "vutrutoananh.jpg", 1 },
                    { 6, "S006", new DateTime(2020, 5, 19, 5, 12, 59, 0, DateTimeKind.Unspecified), "blackholes.png", 1 },
                    { 7, "S007", new DateTime(2020, 5, 19, 5, 12, 59, 0, DateTimeKind.Unspecified), "theuniverseinthenutshell.jpg", 1 },
                    { 9, "S009", new DateTime(2020, 5, 19, 5, 12, 59, 0, DateTimeKind.Unspecified), "abriefhistoryoftime.jpg", 1 },
                    { 19, "S019", new DateTime(2020, 5, 19, 22, 14, 39, 0, DateTimeKind.Unspecified), "lanamtrongla.jpg", 1 },
                    { 5, "S005", new DateTime(2020, 5, 19, 5, 3, 31, 0, DateTimeKind.Unspecified), "chasingtherabbit.jpg", 1 },
                    { 20, "S020", new DateTime(2020, 5, 19, 22, 14, 39, 0, DateTimeKind.Unspecified), "ngoikhoctrencay.jpg", 1 },
                    { 21, "S021", new DateTime(2020, 5, 19, 22, 14, 39, 0, DateTimeKind.Unspecified), "toithayhoavangtrencoxanh.jpeg", 1 },
                    { 22, "S022", new DateTime(2020, 5, 19, 22, 14, 39, 0, DateTimeKind.Unspecified), "chotoixinmotvedituoitho.jpg", 1 },
                    { 4, "S004", new DateTime(2020, 5, 19, 5, 1, 11, 0, DateTimeKind.Unspecified), "theteenwithamillionairemindser.jpg", 1 },
                    { 23, "S023", new DateTime(2020, 5, 19, 22, 14, 39, 0, DateTimeKind.Unspecified), "cogaidentuhomqua.jpeg", 1 },
                    { 10, "S010", new DateTime(2020, 5, 19, 7, 15, 34, 0, DateTimeKind.Unspecified), "demenphieuluuky.jpg", 1 },
                    { 3, "S003", new DateTime(2020, 5, 19, 4, 57, 42, 0, DateTimeKind.Unspecified), "therichestmaninbabylon.jpg", 1 },
                    { 25, "S025", new DateTime(2020, 5, 19, 23, 22, 56, 0, DateTimeKind.Unspecified), "gaynguoithilanh.jpg", 1 },
                    { 26, "S026", new DateTime(2020, 5, 19, 23, 22, 56, 0, DateTimeKind.Unspecified), "hanhlyhuvo.jpg", 1 },
                    { 27, "S027", new DateTime(2020, 5, 19, 23, 40, 20, 0, DateTimeKind.Unspecified), "khongaiquasong.jpg", 1 },
                    { 2, "S002", new DateTime(2020, 5, 19, 4, 51, 44, 0, DateTimeKind.Unspecified), "bimattuduytrieuphu.jpg", 1 },
                    { 28, "S028", new DateTime(2020, 5, 19, 23, 40, 20, 0, DateTimeKind.Unspecified), "dongtamlong.jpg", 1 },
                    { 40, "S040", new DateTime(2020, 5, 20, 1, 26, 10, 0, DateTimeKind.Unspecified), "thegioithatlac.jpg", 1 },
                    { 56, "S056", new DateTime(2020, 10, 19, 4, 6, 39, 0, DateTimeKind.Unspecified), "cac_the_gioi_song_song.jpg", 1 },
                    { 49, "S049", new DateTime(2020, 5, 20, 2, 31, 20, 0, DateTimeKind.Unspecified), "vutrutuhukhong.jpg", 1 },
                    { 41, "S041", new DateTime(2020, 5, 20, 1, 47, 35, 0, DateTimeKind.Unspecified), "anhdengiuahaidaiduong.jpg", 1 },
                    { 46, "S046", new DateTime(2020, 5, 20, 1, 55, 43, 0, DateTimeKind.Unspecified), "nghinhumottyphu.jpg", 1 },
                    { 47, "S047", new DateTime(2020, 5, 20, 1, 58, 12, 0, DateTimeKind.Unspecified), "toidalamgiaunhuthe.jpg", 1 },
                    { 18, "S018", new DateTime(2020, 5, 19, 21, 56, 14, 0, DateTimeKind.Unspecified), "cuocsongratgiongcuocdoi.jpg", 1 },
                    { 48, "S048", new DateTime(2020, 5, 20, 2, 9, 35, 0, DateTimeKind.Unspecified), "searchinsideyourself.jpg", 1 },
                    { 16, "S016", new DateTime(2020, 5, 19, 7, 38, 4, 0, DateTimeKind.Unspecified), "nonggianlabannangtinhlanglabanlinh.png", 1 },
                    { 24, "S024", new DateTime(2020, 5, 19, 22, 14, 39, 0, DateTimeKind.Unspecified), "matbiec.jpg", 1 },
                    { 32, "S032", new DateTime(2020, 5, 20, 1, 9, 57, 0, DateTimeKind.Unspecified), "thethornbirds.gif", 1 },
                    { 54, "S054", new DateTime(2020, 5, 20, 5, 2, 1, 0, DateTimeKind.Unspecified), "sutichloaivatchuyennhuthedo.jpg", 1 },
                    { 15, "S015", new DateTime(2020, 5, 19, 7, 38, 4, 0, DateTimeKind.Unspecified), "dungluachonannhankhicontre.jpg", 1 },
                    { 43, "S043", new DateTime(2020, 5, 20, 1, 47, 35, 0, DateTimeKind.Unspecified), "khonggiadinh.jpg", 1 },
                    { 44, "S044", new DateTime(2020, 5, 20, 1, 47, 35, 0, DateTimeKind.Unspecified), "tienggoicuahoangda.jpg", 1 },
                    { 12, "S012", new DateTime(2020, 5, 19, 7, 26, 47, 0, DateTimeKind.Unspecified), "ongnoivuotnguc.jpg", 1 },
                    { 11, "S011", new DateTime(2020, 5, 19, 7, 26, 47, 0, DateTimeKind.Unspecified), "baddadgooddad.jpg", 1 },
                    { 37, "S037", new DateTime(2020, 5, 20, 1, 26, 10, 0, DateTimeKind.Unspecified), "nhungvukyancuasherlockholmes.jpg", 1 },
                    { 14, "S014", new DateTime(2020, 5, 19, 7, 26, 47, 0, DateTimeKind.Unspecified), "nhasiyeuquai.jpg", 1 },
                    { 36, "S036", new DateTime(2020, 5, 20, 1, 26, 10, 0, DateTimeKind.Unspecified), "dethidammau.jpg", 1 },
                    { 29, "S029", new DateTime(2020, 5, 20, 0, 58, 28, 0, DateTimeKind.Unspecified), "vangbongmotthoi.jpeg", 1 },
                    { 1, "S001", new DateTime(2020, 5, 19, 4, 38, 41, 0, DateTimeKind.Unspecified), "paybacktime.jpg", 1 },
                    { 42, "S042", new DateTime(2020, 5, 20, 1, 47, 35, 0, DateTimeKind.Unspecified), "loihoidap1994.jpg", 1 },
                    { 33, "S033", new DateTime(2020, 5, 20, 1, 9, 57, 0, DateTimeKind.Unspecified), "kieuhanhvadinhkien.jpg", 1 },
                    { 38, "S038", new DateTime(2020, 5, 20, 1, 26, 10, 0, DateTimeKind.Unspecified), "nhunggiacmoohieusachmorisaki.jpg", 1 },
                    { 17, "S017", new DateTime(2020, 5, 19, 21, 56, 14, 0, DateTimeKind.Unspecified), "cuocsongdechgiongcuocdoi.png", 1 },
                    { 52, "S052", new DateTime(2020, 5, 20, 2, 31, 20, 0, DateTimeKind.Unspecified), "giandiepmangcuocruotduoingoanmuctrongmelomaytinhcliffordstoll.jpg", 1 },
                    { 39, "S039", new DateTime(2020, 5, 20, 1, 26, 10, 0, DateTimeKind.Unspecified), "hannibal.jpg", 1 },
                    { 34, "S034", new DateTime(2020, 5, 20, 1, 9, 57, 0, DateTimeKind.Unspecified), "nhungnguoikhonkho.jpg", 1 },
                    { 45, "S045", new DateTime(2020, 5, 20, 1, 47, 35, 0, DateTimeKind.Unspecified), "quatredechet.jpg", 1 },
                    { 51, "S051", new DateTime(2020, 5, 20, 2, 31, 20, 0, DateTimeKind.Unspecified), "nghethuatanminh.jpg", 1 },
                    { 55, "S055", new DateTime(2020, 7, 4, 0, 41, 15, 0, DateTimeKind.Unspecified), "chuyenconmeodayhaiaubay.jpg", 1 },
                    { 8, "S008", new DateTime(2020, 5, 19, 5, 12, 59, 0, DateTimeKind.Unspecified), "whostephenhawking.jpg", 1 },
                    { 35, "S035", new DateTime(2020, 5, 20, 1, 26, 10, 0, DateTimeKind.Unspecified), "suimlangcuabaycuu.jpg", 1 },
                    { 13, "S013", new DateTime(2020, 5, 19, 7, 26, 47, 0, DateTimeKind.Unspecified), "banhmikepchuot.jpg", 1 }
                });

            migrationBuilder.InsertData(
                table: "CartItems",
                columns: new[] { "CartId", "BookId", "CreatedAt", "Quantity", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "S001", new DateTime(2020, 12, 4, 7, 7, 20, 0, DateTimeKind.Unspecified), 1, new DateTime(2020, 12, 4, 7, 7, 20, 0, DateTimeKind.Unspecified) },
                    { 2, "S011", new DateTime(2020, 12, 4, 7, 7, 20, 0, DateTimeKind.Unspecified), 1, new DateTime(2020, 12, 4, 7, 7, 20, 0, DateTimeKind.Unspecified) },
                    { 3, "S003", new DateTime(2020, 12, 4, 7, 7, 20, 0, DateTimeKind.Unspecified), 1, new DateTime(2020, 12, 4, 7, 7, 20, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "Id", "BookId", "Content", "CreatedAt", "CustomerId", "Email", "Name", "UpdatedAt", "Vote" },
                values: new object[] { 1, "S012", "Cảm thấy thú vị", new DateTime(2020, 6, 19, 17, 35, 57, 0, DateTimeKind.Unspecified), null, "thienan@gmail.com", "Thiên An", new DateTime(2020, 6, 19, 17, 35, 57, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "OrderDetail",
                columns: new[] { "OrderDetailId", "OrderId", "BookId", "CreatedAt", "Price", "Quantity" },
                values: new object[,]
                {
                    { 5, "DH006", "S032", new DateTime(2020, 6, 30, 10, 38, 54, 0, DateTimeKind.Unspecified), 90000.0, 1 },
                    { 1, "DH004", "S001", new DateTime(2020, 6, 26, 10, 1, 49, 0, DateTimeKind.Unspecified), 299000.0, 2 },
                    { 1, "DH019", "S016", new DateTime(2020, 7, 1, 9, 27, 54, 0, DateTimeKind.Unspecified), 67000.0, 2 },
                    { 1, "DH001", "S001", new DateTime(2020, 6, 25, 5, 47, 7, 0, DateTimeKind.Unspecified), 299000.0, 2 },
                    { 2, "DH028", "S031", new DateTime(2019, 11, 23, 12, 33, 10, 0, DateTimeKind.Unspecified), 117000.0, 1 },
                    { 4, "DH006", "S005", new DateTime(2020, 6, 30, 10, 38, 54, 0, DateTimeKind.Unspecified), 60000.0, 1 },
                    { 2, "DH002", "S018", new DateTime(2020, 6, 25, 7, 58, 56, 0, DateTimeKind.Unspecified), 52000.0, 1 },
                    { 3, "DH005", "S018", new DateTime(2020, 6, 26, 12, 48, 4, 0, DateTimeKind.Unspecified), 52000.0, 4 },
                    { 3, "DH001", "S005", new DateTime(2020, 6, 25, 5, 47, 7, 0, DateTimeKind.Unspecified), 60000.0, 1 },
                    { 1, "DH014", "S034", new DateTime(2020, 6, 30, 22, 24, 38, 0, DateTimeKind.Unspecified), 277000.0, 1 },
                    { 2, "DH024", "S005", new DateTime(2020, 7, 1, 9, 49, 55, 0, DateTimeKind.Unspecified), 60000.0, 1 },
                    { 1, "DH026", "S005", new DateTime(2019, 7, 31, 10, 2, 47, 0, DateTimeKind.Unspecified), 60000.0, 1 },
                    { 2, "DH014", "S037", new DateTime(2020, 6, 30, 22, 24, 38, 0, DateTimeKind.Unspecified), 77000.0, 1 },
                    { 1, "DH030", "S004", new DateTime(2020, 10, 20, 22, 29, 11, 0, DateTimeKind.Unspecified), 34000.0, 1 },
                    { 7, "DH006", "S044", new DateTime(2020, 6, 30, 10, 38, 54, 0, DateTimeKind.Unspecified), 44000.0, 1 },
                    { 2, "DH007", "S044", new DateTime(2020, 6, 30, 20, 13, 12, 0, DateTimeKind.Unspecified), 44000.0, 2 },
                    { 1, "DH029", "S004", new DateTime(2019, 11, 24, 12, 33, 40, 0, DateTimeKind.Unspecified), 34000.0, 2 },
                    { 1, "DH003", "S002", new DateTime(2020, 6, 25, 8, 2, 14, 0, DateTimeKind.Unspecified), 54000.0, 1 },
                    { 1, "DH027", "S002", new DateTime(2020, 7, 2, 8, 53, 0, 0, DateTimeKind.Unspecified), 54000.0, 1 },
                    { 2, "DH030", "S002", new DateTime(2020, 10, 20, 22, 29, 11, 0, DateTimeKind.Unspecified), 51000.0, 2 },
                    { 1, "DH024", "S004", new DateTime(2020, 7, 1, 9, 49, 55, 0, DateTimeKind.Unspecified), 34000.0, 1 },
                    { 9, "DH006", "S002", new DateTime(2020, 6, 30, 10, 38, 54, 0, DateTimeKind.Unspecified), 54000.0, 1 },
                    { 1, "DH016", "S004", new DateTime(2020, 7, 1, 9, 25, 6, 0, DateTimeKind.Unspecified), 34000.0, 2 },
                    { 8, "DH006", "S042", new DateTime(2020, 6, 30, 10, 38, 54, 0, DateTimeKind.Unspecified), 79000.0, 1 },
                    { 1, "DH013", "S004", new DateTime(2020, 6, 30, 22, 23, 53, 0, DateTimeKind.Unspecified), 34000.0, 1 },
                    { 1, "DH011", "S032", new DateTime(2020, 6, 30, 21, 0, 38, 0, DateTimeKind.Unspecified), 90000.0, 1 },
                    { 3, "DH013", "S025", new DateTime(2020, 6, 30, 22, 23, 53, 0, DateTimeKind.Unspecified), 36000.0, 1 },
                    { 4, "DH030", "S048", new DateTime(2020, 10, 20, 22, 29, 11, 0, DateTimeKind.Unspecified), 77000.0, 1 },
                    { 2, "DH006", "S010", new DateTime(2020, 6, 30, 10, 38, 54, 0, DateTimeKind.Unspecified), 35000.0, 1 },
                    { 1, "DH012", "S010", new DateTime(2020, 6, 30, 22, 22, 20, 0, DateTimeKind.Unspecified), 35000.0, 1 },
                    { 2, "DH005", "S008", new DateTime(2020, 6, 26, 12, 48, 4, 0, DateTimeKind.Unspecified), 50000.0, 2 },
                    { 1, "DH020", "S008", new DateTime(2019, 7, 1, 9, 41, 31, 0, DateTimeKind.Unspecified), 50000.0, 3 },
                    { 1, "DH002", "S008", new DateTime(2020, 6, 25, 7, 58, 56, 0, DateTimeKind.Unspecified), 50000.0, 2 },
                    { 6, "DH006", "S039", new DateTime(2020, 6, 30, 10, 38, 54, 0, DateTimeKind.Unspecified), 90000.0, 1 },
                    { 3, "DH003", "S035", new DateTime(2020, 6, 25, 8, 2, 14, 0, DateTimeKind.Unspecified), 90000.0, 1 },
                    { 2, "DH009", "S014", new DateTime(2020, 6, 30, 20, 16, 9, 0, DateTimeKind.Unspecified), 64000.0, 1 },
                    { 2, "DH029", "S013", new DateTime(2019, 11, 24, 12, 33, 40, 0, DateTimeKind.Unspecified), 51000.0, 1 },
                    { 3, "DH015", "S053", new DateTime(2020, 6, 30, 22, 26, 29, 0, DateTimeKind.Unspecified), 40000.0, 1 },
                    { 1, "DH009", "S013", new DateTime(2020, 6, 30, 20, 16, 9, 0, DateTimeKind.Unspecified), 51000.0, 1 },
                    { 3, "DH006", "S012", new DateTime(2020, 6, 30, 10, 38, 54, 0, DateTimeKind.Unspecified), 70000.0, 1 },
                    { 2, "DH027", "S012", new DateTime(2020, 7, 2, 8, 53, 0, 0, DateTimeKind.Unspecified), 70000.0, 1 },
                    { 2, "DH016", "S012", new DateTime(2020, 7, 1, 9, 25, 6, 0, DateTimeKind.Unspecified), 70000.0, 1 },
                    { 4, "DH009", "S011", new DateTime(2020, 6, 30, 20, 16, 9, 0, DateTimeKind.Unspecified), 83000.0, 1 },
                    { 1, "DH028", "S011", new DateTime(2019, 11, 23, 12, 33, 10, 0, DateTimeKind.Unspecified), 83000.0, 1 },
                    { 1, "DH007", "S038", new DateTime(2020, 6, 30, 20, 13, 12, 0, DateTimeKind.Unspecified), 39000.0, 1 },
                    { 2, "DH018", "S051", new DateTime(2020, 7, 1, 9, 27, 28, 0, DateTimeKind.Unspecified), 189000.0, 1 },
                    { 2, "DH015", "S050", new DateTime(2020, 6, 30, 22, 26, 29, 0, DateTimeKind.Unspecified), 149000.0, 1 },
                    { 1, "DH018", "S050", new DateTime(2020, 7, 1, 9, 27, 28, 0, DateTimeKind.Unspecified), 149000.0, 1 },
                    { 3, "DH009", "S012", new DateTime(2020, 6, 30, 20, 16, 9, 0, DateTimeKind.Unspecified), 70000.0, 1 },
                    { 1, "DH008", "S015", new DateTime(2020, 6, 30, 20, 15, 12, 0, DateTimeKind.Unspecified), 56000.0, 1 },
                    { 3, "DH022", "S053", new DateTime(2020, 7, 1, 9, 47, 2, 0, DateTimeKind.Unspecified), 40000.0, 1 },
                    { 1, "DH017", "S007", new DateTime(2020, 7, 1, 9, 25, 28, 0, DateTimeKind.Unspecified), 59000.0, 1 },
                    { 2, "DH023", "S048", new DateTime(2020, 7, 1, 9, 48, 24, 0, DateTimeKind.Unspecified), 77000.0, 2 },
                    { 1, "DH023", "S047", new DateTime(2020, 7, 1, 9, 48, 24, 0, DateTimeKind.Unspecified), 65000.0, 1 },
                    { 4, "DH013", "S046", new DateTime(2020, 6, 30, 22, 23, 53, 0, DateTimeKind.Unspecified), 54000.0, 1 },
                    { 2, "DH001", "S046", new DateTime(2020, 6, 25, 5, 47, 7, 0, DateTimeKind.Unspecified), 54000.0, 1 },
                    { 2, "DH022", "S040", new DateTime(2020, 7, 1, 9, 47, 2, 0, DateTimeKind.Unspecified), 38000.0, 1 },
                    { 1, "DH015", "S040", new DateTime(2020, 6, 30, 22, 26, 29, 0, DateTimeKind.Unspecified), 38000.0, 2 },
                    { 2, "DH008", "S027", new DateTime(2020, 6, 30, 20, 15, 12, 0, DateTimeKind.Unspecified), 55000.0, 1 },
                    { 3, "DH021", "S025", new DateTime(2019, 7, 1, 9, 45, 3, 0, DateTimeKind.Unspecified), 36000.0, 1 },
                    { 1, "DH005", "S001", new DateTime(2020, 6, 26, 12, 48, 4, 0, DateTimeKind.Unspecified), 299000.0, 1 },
                    { 4, "DH022", "S054", new DateTime(2020, 7, 1, 9, 47, 2, 0, DateTimeKind.Unspecified), 84000.0, 1 },
                    { 1, "DH022", "S024", new DateTime(2020, 7, 1, 9, 47, 2, 0, DateTimeKind.Unspecified), 54000.0, 1 },
                    { 2, "DH021", "S023", new DateTime(2019, 7, 1, 9, 45, 3, 0, DateTimeKind.Unspecified), 48000.0, 3 },
                    { 2, "DH025", "S022", new DateTime(2020, 7, 1, 9, 51, 39, 0, DateTimeKind.Unspecified), 53000.0, 1 },
                    { 2, "DH012", "S022", new DateTime(2020, 6, 30, 22, 22, 20, 0, DateTimeKind.Unspecified), 53000.0, 1 },
                    { 3, "DH030", "S021", new DateTime(2020, 10, 20, 22, 29, 11, 0, DateTimeKind.Unspecified), 62000.0, 2 },
                    { 2, "DH013", "S021", new DateTime(2020, 6, 30, 22, 23, 53, 0, DateTimeKind.Unspecified), 62000.0, 1 },
                    { 2, "DH003", "S021", new DateTime(2020, 6, 25, 8, 2, 14, 0, DateTimeKind.Unspecified), 62000.0, 1 },
                    { 1, "DH025", "S021", new DateTime(2020, 7, 1, 9, 51, 39, 0, DateTimeKind.Unspecified), 62000.0, 1 },
                    { 1, "DH021", "S021", new DateTime(2019, 7, 1, 9, 45, 3, 0, DateTimeKind.Unspecified), 62000.0, 1 },
                    { 1, "DH010", "S019", new DateTime(2020, 6, 30, 20, 18, 46, 0, DateTimeKind.Unspecified), 45000.0, 2 },
                    { 3, "DH012", "S023", new DateTime(2020, 6, 30, 22, 22, 20, 0, DateTimeKind.Unspecified), 48000.0, 1 },
                    { 1, "DH006", "S001", new DateTime(2020, 6, 30, 10, 38, 54, 0, DateTimeKind.Unspecified), 299000.0, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuthorTranslator_Slug",
                table: "AuthorTranslator",
                column: "Slug",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Book_AuthorId",
                table: "Book",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Book_CategoryId",
                table: "Book",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Book_PublisherId",
                table: "Book",
                column: "PublisherId");

            migrationBuilder.CreateIndex(
                name: "IX_Book_Slug",
                table: "Book",
                column: "Slug",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Book_TranslatorId",
                table: "Book",
                column: "TranslatorId");

            migrationBuilder.CreateIndex(
                name: "IX_BookImage_BookId",
                table: "BookImage",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookView_BookId",
                table: "BookView",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookView_CustomerId",
                table: "BookView",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Cart_CustomerId",
                table: "Cart",
                column: "CustomerId",
                unique: true,
                filter: "[CustomerId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_BookId",
                table: "CartItems",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Category_Slug",
                table: "Category",
                column: "Slug",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comment_BookId",
                table: "Comment",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_CustomerId",
                table: "Comment",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Coupon_Code_Slug",
                table: "Coupon",
                columns: new[] { "Code", "Slug" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customer_Email_Username",
                table: "Customer",
                columns: new[] { "Email", "Username" },
                unique: true,
                filter: "[Email] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_Email_Username",
                table: "Employee",
                columns: new[] { "Email", "Username" },
                unique: true,
                filter: "[Email] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Order_CouponId",
                table: "Order",
                column: "CouponId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_CustomerId",
                table: "Order",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_PaymentMethodId",
                table: "Order",
                column: "PaymentMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_StatusId",
                table: "Order",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_BookId",
                table: "OrderDetail",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_OrderId",
                table: "OrderDetail",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Publisher_Slug",
                table: "Publisher",
                column: "Slug",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Wishlist_BookId",
                table: "Wishlist",
                column: "BookId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Banner");

            migrationBuilder.DropTable(
                name: "BannerSettings");

            migrationBuilder.DropTable(
                name: "BookImage");

            migrationBuilder.DropTable(
                name: "BookView");

            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropTable(
                name: "EmployeeAuthorization");

            migrationBuilder.DropTable(
                name: "OrderDetail");

            migrationBuilder.DropTable(
                name: "Wishlist");

            migrationBuilder.DropTable(
                name: "Cart");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Book");

            migrationBuilder.DropTable(
                name: "Coupon");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "PaymentMethod");

            migrationBuilder.DropTable(
                name: "OrderStatus");

            migrationBuilder.DropTable(
                name: "AuthorTranslator");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Publisher");
        }
    }
}
