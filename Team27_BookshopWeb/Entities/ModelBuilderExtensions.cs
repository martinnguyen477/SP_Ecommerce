using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team27_BookshopWeb.Entities
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            #region Employee
            modelBuilder.Entity<Employee>()
                .HasData(
                    new Employee
                    {
                        Id = "NV001",
                        Name = "Nguyễn Phương Thảo",
                        Gender = 1,
                        Birthdate = DateTime.Parse("1996-10-21 00:00:00"),
                        Phone = "0123456754",
                        Address = "109 Tổ 2, Khu Bến Cát, Phường Phước Bình, Quận 9, TP.HCM",
                        Email = "thao.nguyenfaker@gazefi.com",
                        Position = "Admin",
                        CreatedAt = DateTime.Parse("2020-05-20 06:52:55"),
                        UpdatedAt = DateTime.Parse("2020-07-02 23:55:01"),
                        Username = "NV001",
                        Password = "$2a$11$PCobYotKpaey2Oqbwy9aEeUZ4iJzlfcR9005qeTyTNMJmVRS.BR0e"
                    },
                    new Employee
                    {
                        Id = "NV002",
                        Name = "Đỗ Anh Tuấn",
                        Gender = 0,
                        Birthdate = DateTime.Parse("1995-12-21 00:00:00"),
                        Phone = "0918883862",
                        Address = "Khu Phố 4, Phường Tân Tiến, TP. Biên Hòa, Tỉnh Đồng Nai",
                        Email = "anhtuanfaker@vanthai.com.vn158",
                        Position = "Nhân viên",
                        CreatedAt = DateTime.Parse("2020-05-20 06:59:21"),
                        UpdatedAt = DateTime.Parse("2020-05-20 06:59:21"),
                        Username = "NV002",
                        Password = "$2a$11$PCobYotKpaey2Oqbwy9aEeUZ4iJzlfcR9005qeTyTNMJmVRS.BR0e"
                    },
                    new Employee
                    {
                        Id = "NV003",
                        Name = "Trần Mạnh Chung",
                        Gender = 0,
                        Birthdate = DateTime.Parse("1995-12-21 00:00:00"),
                        Phone = "0983603517",
                        Address = "Căn B7 Khu Nhà ở Ngõ 535 Phố Kim Mã, P. Ngọc Khánh, Q. Ba Đình, Hà Nội",
                        Email = "tranmanhfakerchung@otoxemay.vn",
                        Position = "Nhân viên",
                        CreatedAt = DateTime.Parse("2020-05-20 06:59:21"),
                        UpdatedAt = DateTime.Parse("2020-05-20 06:59:21"),
                        Username = "NV003",
                        Password = "$2a$11$PCobYotKpaey2Oqbwy9aEeUZ4iJzlfcR9005qeTyTNMJmVRS.BR0e"
                    },
                    new Employee
                    {
                        Id = "NV004",
                        Name = "Ngô Thị Minh Thư",
                        Gender = 1,
                        Birthdate = DateTime.Parse("1998-03-06 00:00:00"),
                        Phone = "0902797879",
                        Address = "Tổ 4, Khu 5B, Bãy Cháy, TP. Hạ Long, Tỉnh Quảng Ninh",
                        Email = "minhfakerthu9979@gmail.com",
                        Position = "Nhân viên",
                        CreatedAt = DateTime.Parse("2020-05-20 06:59:21"),
                        UpdatedAt = DateTime.Parse("2020-05-20 06:59:21"),
                        Username = "NV004",
                        Password = "$2a$11$PCobYotKpaey2Oqbwy9aEeUZ4iJzlfcR9005qeTyTNMJmVRS.BR0e"
                    }
            );
            #endregion

            #region Customer
            modelBuilder.Entity<Customer>()
                .HasData(
                    new Customer
                    {
                        Id = "KH001",
                        Name = "Nguyễn Thị Ngọc Diệp",
                        Gender = 1,
                        Phone = "0918265684",
                        Address = "35C Tổ 87, KP.12, Phường Hố Nai, TP. Biên Hòa, Tỉnh Đồng Nai",
                        Email = "chiantddfaker@gmail.com",
                        CreatedAt = DateTime.Parse("2020-06-21 07:57:52"),
                        UpdatedAt = DateTime.Parse("2020-06-21 07:57:52"),
                        Username = "diepn",
                        Password = "123"
                    },
                    new Customer
                    {
                        Id = "KH002",
                        Name = "ĐOÀN HỮU MINH",
                        Gender = 0,
                        Phone = "0938189742",
                        Address = "330 Cách Mạng Tháng Tám, Phường 10, Quận 3, TP.HCM",
                        Email = "cuongphuong78faker@yahoo.com",
                        CreatedAt = DateTime.Parse("2020-06-21 08:00:13"),
                        UpdatedAt = DateTime.Parse("2020-06-21 08:00:13"),
                        Username = "minh123",
                        Password = "$2a$11$PCobYotKpaey2Oqbwy9aEeUZ4iJzlfcR9005qeTyTNMJmVRS.BR0e"
                    },
                    new Customer
                    {
                        Id = "KH003",
                        Name = "Nguyễn Phương Thảo",
                        Gender = 1,
                        Phone = "0933335666",
                        Address = "109 Tổ 2, Khu Bến Cát, Phường Phước Bình, Quận 9, TP.HCM",
                        Email = "thao.nguyenfaker@gazefi.com",
                        CreatedAt = DateTime.Parse("2020-06-21 10:26:25"),
                        UpdatedAt = DateTime.Parse("2020-06-21 10:26:25"),
                        Username = "lucky",
                        Password = "$2a$11$PCobYotKpaey2Oqbwy9aEeUZ4iJzlfcR9005qeTyTNMJmVRS.BR0e"
                    },
                    new Customer
                    {
                        Id = "KH004",
                        Name = "Trần Thị Thúy Ái",
                        Gender = 1,
                        Phone = "0908767358",
                        Address = "477/22 Âu Cơ, P. Phú Trung, Q. Tân Phú Âu Cơ, P. Phú Trung, Q. Tân Phú",
                        Email = "aifaker@gmail.com",
                        CreatedAt = DateTime.Parse("2020-06-29 11:19:37"),
                        UpdatedAt = DateTime.Parse("2020-06-29 11:19:37"),
                        Username = "aii109",
                        Password = "$2a$11$PCobYotKpaey2Oqbwy9aEeUZ4iJzlfcR9005qeTyTNMJmVRS.BR0e"
                    },
                    new Customer
                    {
                        Id = "KH005",
                        Name = "Nguyễn Văn Song",
                        Gender = 0,
                        Phone = "0918608578",
                        Address = "1/9 Hồ Thị Kỷ, F1, Q10, TP. HCM Hồ Thị Kỷ, F1, Q10, TP. HCM TP. HCM",
                        Email = "songfaker@gmail.com",
                        CreatedAt = DateTime.Parse("2020-06-29 11:23:15"),
                        UpdatedAt = DateTime.Parse("2020-06-29 11:23:15"),
                        Username = "song",
                        Password = "$2a$11$PCobYotKpaey2Oqbwy9aEeUZ4iJzlfcR9005qeTyTNMJmVRS.BR0e"
                    },
                    new Customer
                    {
                        Id = "KH006",
                        Name = "Lê Thị Khánh Quỳnh",
                        Gender = 1,
                        Phone = "0918637176",
                        Address = "2/15B Trần Nhân Tôn, F2, Q.10 Trần Nhân Tôn, F2, Q.10 TP.HCM",
                        Email = "quynhfaker@gmail.com",
                        CreatedAt = DateTime.Parse("2020-04-16 11:24:41"),
                        UpdatedAt = DateTime.Parse("2020-06-29 11:24:41"),
                        Username = "quynh",
                        Password = "$2a$11$PCobYotKpaey2Oqbwy9aEeUZ4iJzlfcR9005qeTyTNMJmVRS.BR0e"
                    },
                    new Customer
                    {
                        Id = "KH007",
                        Name = "Trần Việt Hải",
                        Gender = 0,
                        Phone = "0913652449",
                        Address = "315 Khu Phố 2 - Thị trấn Hóc Môn - TPHCM",
                        Email = "hai2faker@gmail.com",
                        CreatedAt = DateTime.Parse("2020-03-09 11:25:39"),
                        UpdatedAt = DateTime.Parse("2020-06-29 11:25:39"),
                        Username = "hai002",
                        Password = "$2a$11$PCobYotKpaey2Oqbwy9aEeUZ4iJzlfcR9005qeTyTNMJmVRS.BR0e"
                    },
                    new Customer
                    {
                        Id = "KH008",
                        Name = "Phan Thanh Sang",
                        Gender = 0,
                        Phone = "0903120175",
                        Address = "39 Bến Phú Định, F16, Q8, HCM",
                        Email = "sang001faker@gmail.com",
                        CreatedAt = DateTime.Parse("2020-03-18 11:26:39"),
                        UpdatedAt = DateTime.Parse("2020-06-29 11:26:39"),
                        Username = "sang001",
                        Password = "$2a$11$PCobYotKpaey2Oqbwy9aEeUZ4iJzlfcR9005qeTyTNMJmVRS.BR0e"
                    },
                    new Customer
                    {
                        Id = "KH009",
                        Name = "Nguyễn Thị Hồng Ngọc",
                        Gender = 1,
                        Phone = "0908543869",
                        Address = "758 Điện Biên Phủ, P10 Q.Bình Thạnh HCM",
                        Email = "ngocnttfaker@gmail.com",
                        CreatedAt = DateTime.Parse("2020-05-03 11:28:08"),
                        UpdatedAt = DateTime.Parse("2020-06-29 11:28:08"),
                        Username = "ngoc",
                        Password = "$2a$11$PCobYotKpaey2Oqbwy9aEeUZ4iJzlfcR9005qeTyTNMJmVRS.BR0e"
                    },
                    new Customer
                    {
                        Id = "KH010",
                        Name = "Nguyễn Vĩnh Nam",
                        Gender = 0,
                        Phone = "0938100552",
                        Address = "146 Lầu 4 Hùng Vương, F.12, Q.5",
                        Email = "namvinhfaker@gmail.com",
                        CreatedAt = DateTime.Parse("2020-05-08 11:29:10"),
                        UpdatedAt = DateTime.Parse("2020-06-29 11:29:10"),
                        Username = "vinhnam",
                        Password = "$2a$11$PCobYotKpaey2Oqbwy9aEeUZ4iJzlfcR9005qeTyTNMJmVRS.BR0e"
                    },
                    new Customer
                    {
                        Id = "KH011",
                        Name = "Ngô Thị Thoa",
                        Gender = 1,
                        Phone = "0909252661",
                        Address = "84 Lương Đình Của, P.Thủ Thiêm Q.2 TP.HCM",
                        Email = "thoafaker@gmail.com",
                        CreatedAt = DateTime.Parse("2020-05-17 11:32:27"),
                        UpdatedAt = DateTime.Parse("2020-06-29 11:32:27"),
                        Username = "thoa",
                        Password = "$2a$11$PCobYotKpaey2Oqbwy9aEeUZ4iJzlfcR9005qeTyTNMJmVRS.BR0e"
                    },
                    new Customer
                    {
                        Id = "KH012",
                        Name = "Trần Công Chiến",
                        Gender = 0,
                        Phone = "0938993711",
                        Address = "97/5/18D Phùng Tá Chu, F An Lạc, Q BT",
                        Email = "chienfaker@gmail.com",
                        CreatedAt = DateTime.Parse("2020-05-31 11:33:22"),
                        UpdatedAt = DateTime.Parse("2020-06-29 11:33:22"),
                        Username = "chieen005",
                        Password = "$2a$11$PCobYotKpaey2Oqbwy9aEeUZ4iJzlfcR9005qeTyTNMJmVRS.BR0e"
                    },
                    new Customer
                    {
                        Id = "KH013",
                        Name = "Vũ Thị Ngọc Ngân",
                        Gender = 1,
                        Phone = "0909987604",
                        Address = "21 đường28, KP4, P.Hiệp Bình Chánh, Q.Thủ Đức, TP.HCM",
                        Email = "nganfaker@gmail.com",
                        CreatedAt = DateTime.Parse("2020-04-21 11:34:20"),
                        UpdatedAt = DateTime.Parse("2020-06-29 11:34:20"),
                        Username = "nganvtn",
                        Password = "$2a$11$PCobYotKpaey2Oqbwy9aEeUZ4iJzlfcR9005qeTyTNMJmVRS.BR0e"
                    },
                    new Customer
                    {
                        Id = "KH014",
                        Name = "Trần Thị Thùy Anh",
                        Gender = 1,
                        Phone = "0913778801",
                        Address = "B27 Cư Xá Lam Sơn, Nguyễn Oanh, F.17, Q.GV",
                        Email = "thuyanhfaker@gmail.com",
                        CreatedAt = DateTime.Parse("2020-05-07 11:35:22"),
                        UpdatedAt = DateTime.Parse("2020-06-29 11:35:22"),
                        Username = "thuyanh",
                        Password = "$2a$11$PCobYotKpaey2Oqbwy9aEeUZ4iJzlfcR9005qeTyTNMJmVRS.BR0e"
                    },
                    new Customer
                    {
                        Id = "KH015",
                        Name = "Nguyễn Đồng Diễm Thúy",
                        Gender = 1,
                        Phone = "0908363660",
                        Address = "89/10 Khuông Việt,F.Phú Trung, Q.TP",
                        Email = "thuyfaker@gmail.com",
                        CreatedAt = DateTime.Parse("2020-05-13 11:36:34"),
                        UpdatedAt = DateTime.Parse("2020-06-29 11:36:34"),
                        Username = "thuy",
                        Password = "$2a$11$PCobYotKpaey2Oqbwy9aEeUZ4iJzlfcR9005qeTyTNMJmVRS.BR0e"
                    },
                    new Customer
                    {
                        Id = "KH016",
                        Name = "Nguyễn Hoang Bảo Trị",
                        Gender = 0,
                        Phone = "0288888866",
                        Address = "122/1/1 Lê Văn Thọ, F.11, Q.GV",
                        Email = "tribaofaker@gmail.com",
                        CreatedAt = DateTime.Parse("2020-02-12 11:45:08"),
                        UpdatedAt = DateTime.Parse("2020-06-29 11:45:08"),
                        Username = "tri",
                        Password = "$2a$11$PCobYotKpaey2Oqbwy9aEeUZ4iJzlfcR9005qeTyTNMJmVRS.BR0e"
                    },
                    new Customer
                    {
                        Id = "KH017",
                        Name = "Lương Thị Bích Thảo",
                        Gender = 1,
                        Phone = "0888367211",
                        Address = "63 Đường A2 Khu dân Cư Nam Hùng Vương, P. An Lạc, Q. Bình tân, TPHCM",
                        Email = "thaobichfaker@gmail.com",
                        CreatedAt = DateTime.Parse("2020-05-18 11:48:47"),
                        UpdatedAt = DateTime.Parse("2020-06-29 11:48:47"),
                        Username = "thao",
                        Password = "$2a$11$PCobYotKpaey2Oqbwy9aEeUZ4iJzlfcR9005qeTyTNMJmVRS.BR0e"
                    },
                    new Customer
                    {
                        Id = "KH018",
                        Name = "Trịnh Quốc Cường",
                        Gender = 0,
                        Phone = "0909952567",
                        Address = "159/19/6 Bạch Đằng, F.2, Q.TB",
                        Email = "cuongfaker@gmail.com",
                        CreatedAt = DateTime.Parse("2020-04-28 11:53:40"),
                        UpdatedAt = DateTime.Parse("2020-06-29 11:53:40"),
                        Username = "cuong",
                        Password = "$2a$11$PCobYotKpaey2Oqbwy9aEeUZ4iJzlfcR9005qeTyTNMJmVRS.BR0e"
                    },
                    new Customer
                    {
                        Id = "KH019",
                        Name = "Nguyễn Thị Thùy Trang",
                        Gender = 1,
                        Phone = "0918265681",
                        Address = "3B-2-2-5 Chung Cư Mỹ Viên, Nguyễn Lương Bằng, F.TÂn Phú, Q.7",
                        Email = "thuytrangfaker@gmail.com",
                        CreatedAt = DateTime.Parse("2020-04-20 11:54:23"),
                        UpdatedAt = DateTime.Parse("2020-04-20 11:54:23"),
                        Username = "trang11",
                        Password = "$2a$11$PCobYotKpaey2Oqbwy9aEeUZ4iJzlfcR9005qeTyTNMJmVRS.BR0e"
                    },
                    new Customer
                    {
                        Id = "KH020",
                        Name = "Tô Hữu Long Vũ",
                        Gender = 0,
                        Phone = "0908606399",
                        Address = "43 đường 909 Tạ Quang Biểu, F.5, Q.8",
                        Email = "longvuvfaker@gmail.com",
                        CreatedAt = DateTime.Parse("2020-03-17 11:57:16"),
                        UpdatedAt = DateTime.Parse("2020-06-29 11:57:16"),
                        Username = "longvu",
                        Password = "$2a$11$PCobYotKpaey2Oqbwy9aEeUZ4iJzlfcR9005qeTyTNMJmVRS.BR0e"
                    },
                    new Customer
                    {
                        Id = "KH021",
                        Name = "Đỗ Thành Vĩnh",
                        Gender = 0,
                        Phone = "0908110026",
                        Address = "351/18A Lê Đại Hành F.11, Q.11",
                        Email = "vinhfaker@gmail.com",
                        CreatedAt = DateTime.Parse("2019-01-16 13:26:05"),
                        UpdatedAt = DateTime.Parse("2020-06-30 13:26:05"),
                        Username = "vinh",
                        Password = "$2a$11$PCobYotKpaey2Oqbwy9aEeUZ4iJzlfcR9005qeTyTNMJmVRS.BR0e"
                    },
                    new Customer
                    {
                        Id = "KH022",
                        Name = "Nguyễn Thị Thùy Trang",
                        Gender = 1,
                        Phone = "0925553672",
                        Address = "3B-2-2-5 Chung Cư Mỹ Viên, Nguyễn Lương Bằng, F.TÂn Phú, Q.7",
                        Email = "trangfaker@gmail.com",
                        CreatedAt = DateTime.Parse("2019-11-28 13:27:00"),
                        UpdatedAt = DateTime.Parse("2020-06-30 13:27:00"),
                        Username = "trang",
                        Password = "$2a$11$PCobYotKpaey2Oqbwy9aEeUZ4iJzlfcR9005qeTyTNMJmVRS.BR0e"
                    },
                    new Customer
                    {
                        Id = "KH023",
                        Name = "Phạm Trường Phương",
                        Gender = 0,
                        Phone = "0909952567",
                        Address = "220 Bis Trần Văn Đang, F.9, Q.3",
                        Email = "phuongfaker@gmail.com",
                        CreatedAt = DateTime.Parse("2019-09-09 13:28:05"),
                        UpdatedAt = DateTime.Parse("2020-06-30 13:28:05"),
                        Username = "phuong1",
                        Password = "$2a$11$PCobYotKpaey2Oqbwy9aEeUZ4iJzlfcR9005qeTyTNMJmVRS.BR0e"
                    },
                    new Customer
                    {
                        Id = "KH024",
                        Name = "Lương Bích Vân",
                        Gender = 1,
                        Phone = "0955220676",
                        Address = "42/4/7 đường số 13 F.11, Q.GV",
                        Email = "vanvanfaker@gmail.com",
                        CreatedAt = DateTime.Parse("2019-08-21 13:29:15"),
                        UpdatedAt = DateTime.Parse("2020-06-30 13:29:15"),
                        Username = "vanbl",
                        Password = "$2a$11$PCobYotKpaey2Oqbwy9aEeUZ4iJzlfcR9005qeTyTNMJmVRS.BR0e"
                    },
                    new Customer
                    {
                        Id = "KH025",
                        Name = "Thái Lê Ngọc Thy",
                        Gender = 1,
                        Phone = "0918265699",
                        Address = "32/1C Trần Hưng Đạo, Q.5, TPHCM",
                        Email = "thyfaker@gmail.com",
                        CreatedAt = DateTime.Parse("2019-12-10 13:32:00"),
                        UpdatedAt = DateTime.Parse("2020-06-30 13:32:00"),
                        Username = "thythy",
                        Password = "$2a$11$PCobYotKpaey2Oqbwy9aEeUZ4iJzlfcR9005qeTyTNMJmVRS.BR0e"
                    },
                    new Customer
                    {
                        Id = "KH026",
                        Name = "Nguyễn Thị Sáu",
                        Gender = 1,
                        Phone = "0982515267",
                        Address = "TK28/14 Nguyễn Cảnh Chân, Q.1",
                        Email = "saufaker@gmail.com",
                        CreatedAt = DateTime.Parse("2020-02-02 13:32:45"),
                        UpdatedAt = DateTime.Parse("2020-06-30 13:32:45"),
                        Username = "sau",
                        Password = "$2a$11$PCobYotKpaey2Oqbwy9aEeUZ4iJzlfcR9005qeTyTNMJmVRS.BR0e"
                    },
                    new Customer
                    {
                        Id = "KH027",
                        Name = "Nguyễn Thị Minh Thảo",
                        Gender = 1,
                        Phone = "0923312776",
                        Address = "62/20B Đinh Bộ Lĩnh, F.26, Q.BT",
                        Email = "thaominhfaker@gmail.com",
                        CreatedAt = DateTime.Parse("2019-09-11 13:33:54"),
                        UpdatedAt = DateTime.Parse("2020-06-30 13:33:54"),
                        Username = "thaominh",
                        Password = "$2a$11$PCobYotKpaey2Oqbwy9aEeUZ4iJzlfcR9005qeTyTNMJmVRS.BR0e"
                    },
                    new Customer
                    {
                        Id = "KH028",
                        Name = "Đỗ Duy Văn",
                        Gender = 0,
                        Phone = "0915155495",
                        Address = "563/13 Nguyễn Đình Chiểu,P.2, Q.3, HCM",
                        Email = "vanduyfaker@gmail.com",
                        CreatedAt = DateTime.Parse("2019-10-28 13:34:53"),
                        UpdatedAt = DateTime.Parse("2020-06-30 13:34:53"),
                        Username = "van",
                        Password = "$2a$11$PCobYotKpaey2Oqbwy9aEeUZ4iJzlfcR9005qeTyTNMJmVRS.BR0e"
                    },
                    new Customer
                    {
                        Id = "KH029",
                        Name = "Trần Thanh Tâm",
                        Gender = 0,
                        Phone = "0945792644",
                        Address = "120/5A6 Lê Văn Thọ, F.11, Q.GV",
                        Email = "tamfaker@gmail.com",
                        CreatedAt = DateTime.Parse("2019-09-13 13:35:42"),
                        UpdatedAt = DateTime.Parse("2020-06-30 13:35:42"),
                        Username = "tam",
                        Password = "$2a$11$PCobYotKpaey2Oqbwy9aEeUZ4iJzlfcR9005qeTyTNMJmVRS.BR0e"
                    },
                    new Customer
                    {
                        Id = "KH030",
                        Name = "Võ Thị Kim Cương",
                        Gender = 1,
                        Phone = "0913757058",
                        Address = "237/14 Trần Văn Đang, F.11, Q.3",
                        Email = "kimcuongfaker@gmail.com",
                        CreatedAt = DateTime.Parse("2019-11-24 13:37:05"),
                        UpdatedAt = DateTime.Parse("2020-06-30 13:37:05"),
                        Username = "kimcuong",
                        Password = "$2a$11$PCobYotKpaey2Oqbwy9aEeUZ4iJzlfcR9005qeTyTNMJmVRS.BR0e"
                    },
                    new Customer
                    {
                        Id = "KH031",
                        Name = "Cao Văn Bình",
                        Gender = 0,
                        Phone = "0985990247",
                        Address = "621/19 Tô Ký, P.Trung Mỹ Tây, Q12,TP HCM",
                        Email = "binhfaker@gmail.com",
                        CreatedAt = DateTime.Parse("2019-08-19 13:38:10"),
                        UpdatedAt = DateTime.Parse("2020-06-30 13:38:10"),
                        Username = "binh",
                        Password = "$2a$11$PCobYotKpaey2Oqbwy9aEeUZ4iJzlfcR9005qeTyTNMJmVRS.BR0e"
                    },
                    new Customer
                    {
                        Id = "KH032",
                        Name = "Trương Minh Đức",
                        Gender = 0,
                        Phone = "0368588866",
                        Address = "20 Nguyễn Cư Trinh, P Phạm Ngũ Lão, Q.1",
                        Email = "ducfaker@gmail.com",
                        CreatedAt = DateTime.Parse("2019-07-03 13:39:38"),
                        UpdatedAt = DateTime.Parse("2020-06-30 13:39:38"),
                        Username = "duc",
                        Password = "$2a$11$PCobYotKpaey2Oqbwy9aEeUZ4iJzlfcR9005qeTyTNMJmVRS.BR0e"
                    },
                    new Customer
                    {
                        Id = "KH033",
                        Name = "Nguyễn Hữu Đức",
                        Gender = 0,
                        Phone = "0902995022",
                        Address = "41/1, Tấn Quới, Tấn Mỹ, Chợ Mới, An Giang",
                        Email = "duchuufaker@gmail.com",
                        CreatedAt = DateTime.Parse("2020-06-30 13:45:12"),
                        UpdatedAt = DateTime.Parse("2020-06-30 13:45:12"),
                        Username = "duchn",
                        Password = "$2a$11$PCobYotKpaey2Oqbwy9aEeUZ4iJzlfcR9005qeTyTNMJmVRS.BR0e"
                    },
                    new Customer
                    {
                        Id = "KH034",
                        Name = "Lê Trúc Mai",
                        Gender = 1,
                        Phone = "0925532737",
                        Address = "12 Lạc Long Quân, F.11, Q.11 TPHCM",
                        Email = "mai11faker@gmail.com",
                        CreatedAt = DateTime.Parse("2019-02-20 13:47:48"),
                        UpdatedAt = DateTime.Parse("2020-06-30 13:47:48"),
                        Username = "maitruc",
                        Password = "$2a$11$PCobYotKpaey2Oqbwy9aEeUZ4iJzlfcR9005qeTyTNMJmVRS.BR0e"
                    },
                    new Customer
                    {
                        Id = "KH035",
                        Name = "demo",
                        Gender = 0,
                        Phone = "0922818181",
                        Address = "30 Nguyenx Huệ",
                        Email = "demofaker@gmail.com",
                        CreatedAt = DateTime.Parse("2020-07-03 11:16:01"),
                        UpdatedAt = DateTime.Parse("2020-07-03 11:16:01"),
                        Username = "demo",
                        Password = "123"
                    },
                    new Customer
                    {
                        Id = "KH036",
                        Name = "Lê Minh",
                        Gender = 0,
                        Phone = "0987896757",
                        Address = "280 An Dương Vương",
                        Email = "leminhfaker@gmail.com",
                        CreatedAt = DateTime.Parse("2020-10-20 22:26:51"),
                        UpdatedAt = DateTime.Parse("2020-10-20 22:26:51"),
                        Username = "minhle",
                        Password = "$2a$11$PCobYotKpaey2Oqbwy9aEeUZ4iJzlfcR9005qeTyTNMJmVRS.BR0e"
                    }
                );
            #endregion

            #region Banner
            modelBuilder.Entity<Banner>()
                .HasData(
                    new Banner
                    {
                        Id = 1,
                        Name = "Banner 1",
                        Image = "banner1.jpg",
                        CreatedAt = DateTime.Parse("2020-12-04 00:00:00"),
                        UpdatedAt = DateTime.Parse("2020-12-04 00:00:00")
                    },
                    new Banner
                    {
                        Id = 2,
                        Name = "Banner 2",
                        Image = "banner2.jpg",
                        CreatedAt = DateTime.Parse("2020-12-04 00:00:00"),
                        UpdatedAt = DateTime.Parse("2020-12-04 00:00:00")
                    },
                    new Banner
                    {
                        Id = 3,
                        Name = "Banner 3",
                        Image = "banner3.jpg",
                        CreatedAt = DateTime.Parse("2020-12-04 00:00:00"),
                        UpdatedAt = DateTime.Parse("2020-12-04 00:00:00")
                    },
                    new Banner
                    {
                        Id = 4,
                        Name = "Banner 4",
                        Image = "banner4.jpg",
                        CreatedAt = DateTime.Parse("2020-12-04 00:00:00"),
                        UpdatedAt = DateTime.Parse("2020-12-04 00:00:00")
                    },
                    new Banner
                    {
                        Id = 5,
                        Name = "Banner 5",
                        Image = "banner5.jpg",
                        CreatedAt = DateTime.Parse("2020-12-04 00:00:00"),
                        UpdatedAt = DateTime.Parse("2020-12-04 00:00:00")
                    }
                );
            #endregion

            #region EmployeeAuthorization
            modelBuilder.Entity<EmployeeAuthorization>()
                .HasData(
                    new EmployeeAuthorization
                    {
                        EmployeeId = "NV001",
                        View = 1,
                        Insert = 1,
                        Update = 1,
                        Delete = 1,
                        CreatedAt = DateTime.Parse("2020-07-03 21:42:36"),
                        UpdatedAt = DateTime.Parse("2020-07-03 23:01:51")
                    },
                    new EmployeeAuthorization
                    {
                        EmployeeId = "NV002",
                        View = 1,
                        Insert = 0,
                        Update = 0,
                        Delete = 0,
                        CreatedAt = DateTime.Parse("2020-07-03 21:42:44"),
                        UpdatedAt = DateTime.Parse("2020-07-03 21:42:44")
                    },
                    new EmployeeAuthorization
                    {
                        EmployeeId = "NV003",
                        View = 0,
                        Insert = 0,
                        Update = 0,
                        Delete = 0,
                        CreatedAt = DateTime.Parse("2020-07-03 21:49:24"),
                        UpdatedAt = DateTime.Parse("2020-07-03 21:49:24")
                    },
                    new EmployeeAuthorization
                    {
                        EmployeeId = "NV004",
                        View = 1,
                        Insert = 0,
                        Update = 0,
                        Delete = 0,
                        CreatedAt = DateTime.Parse("2020-07-04 06:42:13"),
                        UpdatedAt = DateTime.Parse("2020-07-04 06:46:13")
                    }
                );
            #endregion

            #region AuthorTranslator
            modelBuilder.Entity<AuthorTranslator>()
                .HasData(
                    new AuthorTranslator
                    {
                        Id = "A001",
                        Name = "Phil Town",
                        Slug = "phil-town",
                        Author = 1,
                        Translator = 0,
                        CreatedAt = DateTime.Parse("2020-05-20 00:00:00"),
                        UpdatedAt = DateTime.Parse("2020-10-20 12:01:00")
                    },
                    new AuthorTranslator
                    {
                        Id = "A002",
                        Name = "T.Harv Eker",
                        Slug = "t-harv-eker",
                        Author = 1,
                        Translator = 0,
                        CreatedAt = DateTime.Parse("2020-05-20 00:00:00"),
                        UpdatedAt = DateTime.Parse("2020-10-20 21:01:00")
                    },
                    new AuthorTranslator
                    {
                        Id = "A003",
                        Name = "George S. Clason",
                        Slug = "george-s-clason",
                        Author = 1,
                        Translator = 0,
                        CreatedAt = DateTime.Parse("2020-05-20 00:00:00"),
                        UpdatedAt = DateTime.Parse("2020-10-20 21:02:00")
                    },
                    new AuthorTranslator
                    {
                        Id = "A004",
                        Name = "Laura Lyseight",
                        Slug = "laura-lyseight",
                        Author = 1,
                        Translator = 0,
                        CreatedAt = DateTime.Parse("2020-05-20 00:00:00"),
                        UpdatedAt = DateTime.Parse("2020-10-20 21:03:00")
                    },
                    new AuthorTranslator
                    {
                        Id = "A005",
                        Name = "Steven J. Spear",
                        Slug = "steven-j-spear",
                        Author = 1,
                        Translator = 0,
                        CreatedAt = DateTime.Parse("2020-05-20 00:00:00"),
                        UpdatedAt = DateTime.Parse("2020-10-20 21:04:00")
                    },
                    new AuthorTranslator
                    {
                        Id = "A006",
                        Name = "Stephen Hawking",
                        Slug = "stephen-hawking",
                        Author = 1,
                        Translator = 0,
                        CreatedAt = DateTime.Parse("2020-05-20 00:00:00"),
                        UpdatedAt = DateTime.Parse("2020-10-20 21:07:00")
                    },
                    new AuthorTranslator
                    {
                        Id = "A007",
                        Name = "Tô Hoài",
                        Slug = "to-hoai",
                        Author = 1,
                        Translator = 0,
                        CreatedAt = DateTime.Parse("2020-05-20 00:00:00"),
                        UpdatedAt = DateTime.Parse("2020-10-20 21:08:00")
                    },
                    new AuthorTranslator
                    {
                        Id = "A008",
                        Name = "David Walliam",
                        Slug = "david-walliam",
                        Author = 1,
                        Translator = 0,
                        CreatedAt = DateTime.Parse("2020-05-20 00:00:00"),
                        UpdatedAt = DateTime.Parse("2020-10-20 21:09:00")
                    },
                    new AuthorTranslator
                    {
                        Id = "A009",
                        Name = "Snorlax",
                        Slug = "snorlax",
                        Author = 0,
                        Translator = 1,
                        CreatedAt = DateTime.Parse("2020-05-20 00:00:00"),
                        UpdatedAt = DateTime.Parse("2020-10-20 21:12:00")
                    },
                    new AuthorTranslator
                    {
                        Id = "A010",
                        Name = "Cảnh Thiên",
                        Slug = "canh-thien",
                        Author = 1,
                        Translator = 0,
                        CreatedAt = DateTime.Parse("2020-05-20 00:00:00"),
                        UpdatedAt = DateTime.Parse("2020-10-20 21:16:00")
                    },
                    new AuthorTranslator
                    {
                        Id = "A011",
                        Name = "Đặng Quân",
                        Slug = "dang-quan",
                        Author = 0,
                        Translator = 1,
                        CreatedAt = DateTime.Parse("2020-05-20 00:00:00"),
                        UpdatedAt = DateTime.Parse("2020-10-20 21:17:00")
                    },
                    new AuthorTranslator
                    {
                        Id = "A012",
                        Name = "Tống Mặc",
                        Slug = "tong-mac",
                        Author = 1,
                        Translator = 0,
                        CreatedAt = DateTime.Parse("2020-05-20 00:00:00"),
                        UpdatedAt = DateTime.Parse("2020-10-20 21:17:00")
                    },
                    new AuthorTranslator
                    {
                        Id = "A013",
                        Name = "Hoàng Hải Nguyễn",
                        Slug = "hoang-hai-nguyen",
                        Author = 1,
                        Translator = 0,
                        CreatedAt = DateTime.Parse("2020-05-20 00:00:00"),
                        UpdatedAt = DateTime.Parse("2020-10-20 21:18:00")
                    },
                    new AuthorTranslator
                    {
                        Id = "A014",
                        Name = "Nguyễn Nhật Ánh",
                        Slug = "nguyen-nhat-anh",
                        Author = 1,
                        Translator = 0,
                        CreatedAt = DateTime.Parse("2020-05-20 00:00:00"),
                        UpdatedAt = DateTime.Parse("2020-10-20 21:19:00")
                    },
                    new AuthorTranslator
                    {
                        Id = "A015",
                        Name = "Nguyễn Ngọc Tư",
                        Slug = "nguyen-ngoc-tu",
                        Author = 1,
                        Translator = 0,
                        CreatedAt = DateTime.Parse("2020-05-20 00:00:00"),
                        UpdatedAt = DateTime.Parse("2020-10-20 21:19:00")
                    },
                    new AuthorTranslator
                    {
                        Id = "A016",
                        Name = "Nguyễn Tuân",
                        Slug = "nguyen-tuan",
                        Author = 1,
                        Translator = 0,
                        CreatedAt = DateTime.Parse("2020-05-20 00:00:00"),
                        UpdatedAt = DateTime.Parse("2020-10-20 21:20:00")
                    },
                    new AuthorTranslator
                    {
                        Id = "A017",
                        Name = "Jane Austen",
                        Slug = "jane-austen",
                        Author = 1,
                        Translator = 0,
                        CreatedAt = DateTime.Parse("2020-05-20 00:00:00"),
                        UpdatedAt = DateTime.Parse("2020-10-20 21:20:00")
                    },
                    new AuthorTranslator
                    {
                        Id = "A018",
                        Name = "Colleen Mccullough",
                        Slug = "colleen-mccullough",
                        Author = 1,
                        Translator = 0,
                        CreatedAt = DateTime.Parse("2020-05-20 00:00:00"),
                        UpdatedAt = DateTime.Parse("2020-10-20 21:21:00")
                    },
                    new AuthorTranslator
                    {
                        Id = "A019",
                        Name = "Victor Hugo",
                        Slug = "victor-hugo",
                        Author = 1,
                        Translator = 0,
                        CreatedAt = DateTime.Parse("2020-05-20 00:00:00"),
                        UpdatedAt = DateTime.Parse("2020-10-20 21:21:00")
                    },
                    new AuthorTranslator
                    {
                        Id = "A020",
                        Name = "Jeffrey Archer",
                        Slug = "jeffrey-archer",
                        Author = 1,
                        Translator = 0,
                        CreatedAt = DateTime.Parse("2020-05-20 00:00:00"),
                        UpdatedAt = DateTime.Parse("2020-10-20 21:21:00")
                    },
                    new AuthorTranslator
                    {
                        Id = "A021",
                        Name = "Nguyễn Việt Hải",
                        Slug = "nguyen-viet-hai",
                        Author = 0,
                        Translator = 1,
                        CreatedAt = DateTime.Parse("2020-05-20 00:00:00"),
                        UpdatedAt = DateTime.Parse("2020-10-20 21:21:00")
                    },
                    new AuthorTranslator
                    {
                        Id = "A022",
                        Name = "Yagisawa Satoshi",
                        Slug = "yagisawa-satoshi",
                        Author = 1,
                        Translator = 0,
                        CreatedAt = DateTime.Parse("2020-05-20 00:00:00"),
                        UpdatedAt = DateTime.Parse("2020-10-20 21:22:00")
                    },
                    new AuthorTranslator
                    {
                        Id = "A023",
                        Name = "Arthur Conan Doyle",
                        Slug = "arthur-conan-doyle",
                        Author = 1,
                        Translator = 0,
                        CreatedAt = DateTime.Parse("2020-05-20 00:00:00"),
                        UpdatedAt = DateTime.Parse("2020-10-20 21:24:00")
                    },
                    new AuthorTranslator
                    {
                        Id = "A024",
                        Name = "Thomas Harris",
                        Slug = "thomas-harris",
                        Author = 1,
                        Translator = 0,
                        CreatedAt = DateTime.Parse("2020-05-20 00:00:00"),
                        UpdatedAt = DateTime.Parse("2020-10-20 21:24:00")
                    },
                    new AuthorTranslator
                    {
                        Id = "A025",
                        Name = "Lôi Mễ",
                        Slug = "loi-me",
                        Author = 1,
                        Translator = 0,
                        CreatedAt = DateTime.Parse("2020-05-20 00:00:00"),
                        UpdatedAt = DateTime.Parse("2020-10-20 21:24:00")
                    },
                    new AuthorTranslator
                    {
                        Id = "A026",
                        Name = "Hương Ly",
                        Slug = "huong-ly",
                        Author = 0,
                        Translator = 1,
                        CreatedAt = DateTime.Parse("2020-05-20 00:00:00"),
                        UpdatedAt = DateTime.Parse("2020-10-20 21:24:00")
                    },
                    new AuthorTranslator
                    {
                        Id = "A027",
                        Name = "Thu Lê",
                        Slug = "thu-le",
                        Author = 0,
                        Translator = 1,
                        CreatedAt = DateTime.Parse("2020-05-20 00:00:00"),
                        UpdatedAt = DateTime.Parse("2020-10-20 21:24:00")
                    },
                    new AuthorTranslator
                    {
                        Id = "A028",
                        Name = "Lee Woo Jung",
                        Slug = "lee-woo-jung",
                        Author = 1,
                        Translator = 0,
                        CreatedAt = DateTime.Parse("2020-05-20 00:00:00"),
                        UpdatedAt = DateTime.Parse("2020-10-20 21:24:00")
                    },
                    new AuthorTranslator
                    {
                        Id = "A029",
                        Name = "Hector Malot",
                        Slug = "hector-malot",
                        Author = 1,
                        Translator = 0,
                        CreatedAt = DateTime.Parse("2020-05-20 00:00:00"),
                        UpdatedAt = DateTime.Parse("2020-10-20 21:25:00")
                    },
                    new AuthorTranslator
                    {
                        Id = "A030",
                        Name = "Jack London",
                        Slug = "jack-london",
                        Author = 1,
                        Translator = 0,
                        CreatedAt = DateTime.Parse("2020-05-20 00:00:00"),
                        UpdatedAt = DateTime.Parse("2020-10-20 21:25:00")
                    },
                    new AuthorTranslator
                    {
                        Id = "A031",
                        Name = "Huỳnh Lý",
                        Slug = "huynh-ly",
                        Author = 0,
                        Translator = 1,
                        CreatedAt = DateTime.Parse("2020-05-20 00:00:00"),
                        UpdatedAt = DateTime.Parse("2020-10-20 21:25:00")
                    },
                    new AuthorTranslator
                    {
                        Id = "A032",
                        Name = "M.L. Stedman",
                        Slug = "m-l-stedman",
                        Author = 1,
                        Translator = 0,
                        CreatedAt = DateTime.Parse("2020-05-20 00:00:00"),
                        UpdatedAt = DateTime.Parse("2020-10-20 21:25:00")
                    },
                    new AuthorTranslator
                    {
                        Id = "A033",
                        Name = "Đinh Hằng",
                        Slug = "dinh-hang",
                        Author = 1,
                        Translator = 0,
                        CreatedAt = DateTime.Parse("2020-05-20 00:00:00"),
                        UpdatedAt = DateTime.Parse("2020-10-20 21:25:00")
                    },
                    new AuthorTranslator
                    {
                        Id = "A034",
                        Name = "Donald J. Trump",
                        Slug = "donald-j-trump",
                        Author = 1,
                        Translator = 0,
                        CreatedAt = DateTime.Parse("2020-05-20 00:00:00"),
                        UpdatedAt = DateTime.Parse("2020-10-20 21:25:00")
                    },
                    new AuthorTranslator
                    {
                        Id = "A035",
                        Name = "Chade - Meng Tan",
                        Slug = "chade-meng-tan",
                        Author = 1,
                        Translator = 0,
                        CreatedAt = DateTime.Parse("2020-05-20 00:00:00"),
                        UpdatedAt = DateTime.Parse("2020-10-20 21:25:00")
                    },
                    new AuthorTranslator
                    {
                        Id = "A036",
                        Name = "Kevin Mitnick",
                        Slug = "kevin-mitnick",
                        Author = 1,
                        Translator = 0,
                        CreatedAt = DateTime.Parse("2020-05-20 00:00:00"),
                        UpdatedAt = DateTime.Parse("2020-10-20 21:25:00")
                    },
                    new AuthorTranslator
                    {
                        Id = "A037",
                        Name = "Clifford Stoll",
                        Slug = "clifford-stoll",
                        Author = 1,
                        Translator = 0,
                        CreatedAt = DateTime.Parse("2020-05-20 00:00:00"),
                        UpdatedAt = DateTime.Parse("2020-10-20 21:26:00")
                    },
                    new AuthorTranslator
                    {
                        Id = "A038",
                        Name = "William L. Simon",
                        Slug = "william-l-simon",
                        Author = 1,
                        Translator = 0,
                        CreatedAt = DateTime.Parse("2020-05-20 00:00:00"),
                        UpdatedAt = DateTime.Parse("2020-10-20 21:26:00")
                    },
                    new AuthorTranslator
                    {
                        Id = "A039",
                        Name = "Lawrence M. Krauss",
                        Slug = "lawrence-m-krauss",
                        Author = 1,
                        Translator = 0,
                        CreatedAt = DateTime.Parse("2020-05-20 00:00:00"),
                        UpdatedAt = DateTime.Parse("2020-10-20 21:26:00")
                    },
                    new AuthorTranslator
                    {
                        Id = "A040",
                        Name = "Trần Thanh Hương và LeVN",
                        Slug = "tran-thanh-huong-va-levn",
                        Author = 0,
                        Translator = 1,
                        CreatedAt = DateTime.Parse("2020-05-20 00:00:00"),
                        UpdatedAt = DateTime.Parse("2020-10-20 21:26:00")
                    },
                    new AuthorTranslator
                    {
                        Id = "A041",
                        Name = "Lê Vũ Kỳ Nam",
                        Slug = "le-vu-ky-nam",
                        Author = 0,
                        Translator = 1,
                        CreatedAt = DateTime.Parse("2020-05-20 00:00:00"),
                        UpdatedAt = DateTime.Parse("2020-10-20 21:26:00")
                    },
                    new AuthorTranslator
                    {
                        Id = "A042",
                        Name = "Thu Giang",
                        Slug = "thu-giang",
                        Author = 0,
                        Translator = 1,
                        CreatedAt = DateTime.Parse("2020-05-20 00:00:00"),
                        UpdatedAt = DateTime.Parse("2020-10-20 21:26:00")
                    },
                    new AuthorTranslator
                    {
                        Id = "A043",
                        Name = "Mộc Hương",
                        Slug = "moc-huong",
                        Author = 0,
                        Translator = 1,
                        CreatedAt = DateTime.Parse("2020-05-20 00:00:00"),
                        UpdatedAt = DateTime.Parse("2020-10-20 21:27:00")
                    },
                    new AuthorTranslator
                    {
                        Id = "A044",
                        Name = "Fujiko.F.Fujio",
                        Slug = "fujiko-f-fujio",
                        Author = 1,
                        Translator = 0,
                        CreatedAt = DateTime.Parse("2020-05-20 00:00:00"),
                        UpdatedAt = DateTime.Parse("2020-10-20 21:27:00")
                    },
                    new AuthorTranslator
                    {
                        Id = "A045",
                        Name = "Rudyard Kipling",
                        Slug = "rudyard-kipling",
                        Author = 1,
                        Translator = 0,
                        CreatedAt = DateTime.Parse("2020-05-20 00:00:00"),
                        UpdatedAt = DateTime.Parse("2020-10-20 21:27:00")
                    },
                    new AuthorTranslator
                    {
                        Id = "A046",
                        Name = "Luis Sepulveda",
                        Slug = "luis-sepulveda",
                        Author = 1,
                        Translator = 0,
                        CreatedAt = DateTime.Parse("2020-07-04 00:39:00"),
                        UpdatedAt = DateTime.Parse("2020-10-20 21:27:00")
                    },
                    new AuthorTranslator
                    {
                        Id = "A047",
                        Name = "Michio Kaku",
                        Slug = "michio-kaku",
                        Author = 1,
                        Translator = 0,
                        CreatedAt = DateTime.Parse("2020-10-20 21:36:00"),
                        UpdatedAt = DateTime.Parse("2020-10-20 21:36:00")
                    },
                    new AuthorTranslator
                    {
                        Id = "A048",
                        Name = "Michael Talbot",
                        Slug = "michael-talbot",
                        Author = 1,
                        Translator = 0,
                        CreatedAt = DateTime.Parse("2020-10-20 21:39:00"),
                        UpdatedAt = DateTime.Parse("2020-10-20 21:39:00")
                    },
                    new AuthorTranslator
                    {
                        Id = "A049",
                        Name = "Phạm Văn Thiều - Nguyễn Đình Điện",
                        Slug = "pham-van-thieu-nguyen-dinh-dien",
                        Author = 0,
                        Translator = 1,
                        CreatedAt = DateTime.Parse("2020-10-20 21:40:00"),
                        UpdatedAt = DateTime.Parse("2020-10-20 21:40:00")
                    },
                    new AuthorTranslator
                    {
                        Id = "A050",
                        Name = "Vương Ngân Hà",
                        Slug = "vuong-ngan-ha",
                        Author = 0,
                        Translator = 1,
                        CreatedAt = DateTime.Parse("2020-10-20 21:48:00"),
                        UpdatedAt = DateTime.Parse("2020-10-20 21:48:00")
                    }
                );
            #endregion

            #region Category
            modelBuilder.Entity<Category>()
                .HasData(
                            new Category
                            {
                                Id = "KHCN",
                                Name = "Khoa học và công nghệ",
                                Slug = "khoa-hoc-va-cong-nghe",
                                VerticalImage = "khcn-vc.jpg",
                                HorizontalImage = "khcn-hz.jpg",
                                CreatedAt = DateTime.Parse("2020-05-12 00:00:00"),
                                UpdatedAt = DateTime.Parse("2020-10-20 03:56:00")
                            },

                            new Category
                            {
                                Id = "KT",
                                Name = "Kinh tế",
                                Slug = "kinh-te",
                                VerticalImage = "kt-vc.jpg",
                                HorizontalImage = "kt-hz.jpg",
                                CreatedAt = DateTime.Parse("2020-05-12 09:21:00"),
                                UpdatedAt = DateTime.Parse("2020-10-20 03:57:00")
                            },

                            new Category
                            {
                                Id = "SGK-GT",
                                Name = "Sách giáo khoa - Giáo trình",
                                Slug = "sach-giao-khoa-giao-trinh",
                                VerticalImage = "gkgt-vc.jpg",
                                HorizontalImage = "gkgt-hz.jpg",
                                CreatedAt = DateTime.Parse("2020-10-20 04:32:00"),
                                UpdatedAt = DateTime.Parse("2020-10-20 04:32:00"),
                                DeletedAt = DateTime.Parse("2020-12-02 00:00:00")
                            },

                            new Category
                            {
                                Id = "STN",
                                Name = "Sách thiếu nhi",
                                Slug = "sach-thieu-nhi",
                                VerticalImage = "stn-vc.jpg",
                                HorizontalImage = "stn-hz.jpg",
                                CreatedAt = DateTime.Parse("2020-05-12 05:19:00"),
                                UpdatedAt = DateTime.Parse("2020-10-20 03:57:00")
                            },

                            new Category
                            {
                                Id = "TD-KNS",
                                Name = "Sách Tư duy và kỹ năng sống",
                                Slug = "sach-tu-duy-va-ky-nang-song",
                                VerticalImage = "tdkns-vc.jpg",
                                HorizontalImage = "tdkns-hz.jpg",
                                CreatedAt = DateTime.Parse("2020-05-12 09:23:00"),
                                UpdatedAt = DateTime.Parse("2020-10-20 04:00:00")
                            },

                            new Category
                            {
                                Id = "VHNN",
                                Name = "Văn học nước ngoài",
                                Slug = "van-hoc-nuoc-ngoai",
                                VerticalImage = "vhnn-vc.jpg",
                                HorizontalImage = "vhnn-hz.jpg",
                                CreatedAt = DateTime.Parse("2020-05-12 10:31:00"),
                                UpdatedAt = DateTime.Parse("2020-10-20 04:01:00"),
                                DeletedAt = DateTime.Parse("2020-12-02 00:00:00")
                            },

                            new Category
                            {
                                Id = "VHVN",
                                Name = "Văn học Việt Nam",
                                Slug = "van-hoc-viet-nam",
                                VerticalImage = "vhvn-vc.jpg",
                                HorizontalImage = "vhvn-hz.jpg",
                                CreatedAt = DateTime.Parse("2020-05-12 06:33:00"),
                                UpdatedAt = DateTime.Parse("2020-10-20 04:01:00")
                            }
                );
            #endregion

            #region Publisher
            modelBuilder.Entity<Publisher>()
                .HasData(
                        new Publisher
                        {
                            Id = "CT",
                            Name = "NXB Công Thương",
                            Slug = "nxb-cong-thuong",
                            Image = "congthuong.png",
                            CreatedAt = DateTime.Parse("2020-05-20 07:17:00"),
                            UpdatedAt = DateTime.Parse("2020-10-20 09:08:00")
                        },
                        new Publisher
                        {
                            Id = "HN",
                            Name = "NXB Hà Nội",
                            Slug = "nxb-ha-noi",
                            Image = "hanoi.png",
                            CreatedAt = DateTime.Parse("2020-05-20 09:22:00"),
                            UpdatedAt = DateTime.Parse("2020-10-20 09:09:00")
                        },
                        new Publisher
                        {
                            Id = "HNV",
                            Name = "NXB Hội Nhà Văn",
                            Slug = "nxb-hoi-nha-van",
                            Image = "hnv.jpg",
                            CreatedAt = DateTime.Parse("2020-05-20 09:28:00"),
                            UpdatedAt = DateTime.Parse("2020-10-20 09:10:00")
                        },
                        new Publisher
                        {
                            Id = "KD",
                            Name = "Kim Đồng",
                            Slug = "kim-dong",
                            Image = "kd.png",
                            CreatedAt = DateTime.Parse("2020-05-20 07:25:00"),
                            UpdatedAt = DateTime.Parse("2020-10-20 09:10:00")
                        },
                        new Publisher
                        {
                            Id = "NXBT",
                            Name = "NXB Trẻ",
                            Slug = "nxb-tre",
                            Image = "nxbtre.png",
                            CreatedAt = DateTime.Parse("2020-05-20 09:26:00"),
                            UpdatedAt = DateTime.Parse("2020-10-20 09:11:00")
                        },
                        new Publisher
                        {
                            Id = "TG",
                            Name = "NXB Thế Giới",
                            Slug = "nxb-the-gioi",
                            Image = "thegioi.png",
                            CreatedAt = DateTime.Parse("2020-05-20 08:18:00"),
                            UpdatedAt = DateTime.Parse("2020-10-20 09:11:00")
                        },
                        new Publisher
                        {
                            Id = "TH",
                            Name = "NXB Tổng Hợp",
                            Slug = "nxb-tong-hop",
                            Image = "tonghop.png",
                            CreatedAt = DateTime.Parse("2020-05-20 08:24:00"),
                            UpdatedAt = DateTime.Parse("2020-10-20 09:11:00")
                        },
                        new Publisher
                        {
                            Id = "TN",
                            Name = "NXB Thanh Niên",
                            Slug = "nxb-thanh-nien",
                            Image = "tn.png",
                            CreatedAt = DateTime.Parse("2020-10-20 09:29:00"),
                            UpdatedAt = DateTime.Parse("2020-10-20 09:29:00")
                        },
                        new Publisher
                        {
                            Id = "VH",
                            Name = "NXB Văn Học",
                            Slug = "nxb-van-hoc",
                            Image = "vh.png",
                            CreatedAt = DateTime.Parse("2020-05-20 05:21:00"),
                            UpdatedAt = DateTime.Parse("2020-10-20 09:12:00")
                        },
                        new Publisher
                        {
                            Id = "VH-NT",
                            Name = "NXB Văn hóa - nghệ thuật",
                            Slug = "nxb-van-hoa-nghe-thuat",
                            Image = "vh-nt.png",
                            CreatedAt = DateTime.Parse("2020-05-20 06:17:00"),
                            UpdatedAt = DateTime.Parse("2020-10-20 09:14:00")
                        }
                );
            #endregion

            #region OrderStatus
            modelBuilder.Entity<OrderStatus>()
                .HasData(
                    new OrderStatus
                    {
                        Id = 1,
                        Name = "Đang chờ xử lý"
                    },
                    new OrderStatus
                    {
                        Id = 2,
                        Name = "Tiếp nhận đơn hàng"
                    },
                    new OrderStatus
                    {
                        Id = 3,
                        Name = "Đóng gói và vận chuyển"
                    },
                    new OrderStatus
                    {
                        Id = 4,
                        Name = "Giao hàng thành công"
                    },
                    new OrderStatus
                    {
                        Id = 5,
                        Name = "Hủy"
                    }
                );
            #endregion

            #region PaymentMethod
            modelBuilder.Entity<PaymentMethod>()
                .HasData(
                    new PaymentMethod
                    {
                        Id = 1,
                        Name = "Thanh toán bằng tiền mặt",
                        IsSupported = 1
                    },
                    new PaymentMethod
                    {
                        Id = 2,
                        Name = "Thanh toán bằng Paypal",
                        IsSupported = 0
                    },
                    new PaymentMethod
                    {
                        Id = 3,
                        Name = "Thanh toán bằng VNPay",
                        IsSupported = 0
                    }
                );
            #endregion

            #region Book
            modelBuilder.Entity<Book>()
                .HasData(
                    new Book
                    {
                        Id = "S001",
                        Name = "Payback Time - Ngày Đòi Nợ",
                        Slug = "payback-time-ngay-doi-no",
                        Price = 299000,
                        PublicationMonth = 7,
                        PublicationYear = 2017,
                        Description = "Trong chứng khoán và thị trường tài chính, dám tham gia đầu tư cũng là một thành công tâm lý ban đầu. Dù vậy, 95% nhà đầu tư Việt Nam thuộc nhóm nhà đầu tư nhỏ lẻ với vốn kiến thức tài chính vô cùng hạn chế. Họ tham gia vào thị trường chứng khoán với 100% ý chí và sự quyết tâm chiến thắng thị trường, nhưng thật không may mắn kết cục cuối cùng của họ luôn là sự thất bại và mất tiền.<br>		    		Bởi vì, chúng ta thường dễ dàng nghe theo các “lời khuyên miễn phí” đến từ bạn bè, những người môi giới, những người nghe ngóng thông tin từ các “đội lái” làm giá và thao túng chứng khoán. Chúng ta không biết làm thế nào để phân biệt hai khái niệm “giá cả – pricing” và “giá trị – value”. Hay mua mua, bán bán liên tục hàng ngày với việc dán mắt vào bảng điện tử, phân tích biểu đồ, đường trung bình giá… và mong đợi một vận may cổ phiếu cùng giá của nó sẽ đi theo suy đoán của mình?<br>		    		Rất nhiều “nhà đầu tư” không hề có một hệ thống đầu tư chuẩn mực nào cả. Không biết cách và những tiêu chí để tìm kiếm cổ phiếu, theo dõi, quyết định điểm mua và quyết định thời điểm bán ra. Vì không có hệ thống đầu tư chuẩn mực nên kết quả chúng ta chỉ có một sự lựa chọn đó chính là THUA LỖ.<br>		    		Vậy có phải chỉ có những chuyên gia tài chính mới có thể gặt hái thành công trên thị trường chứng khoán? Để kiếm được tiền từ chứng khoán bạn phải sở hữu hàng tá kho tàng kiến thức tài chính vốn không dễ dàng “hấp thụ” trong một sớm một chiều? <br>		    		Không hẳn vậy. Có rất nhiều người dù không được đào tạo bài bản về các kiến thức tài chính, dù vẫn là những người đầu tư nhỏ lẻ họ vẫn chiến thắng thị trường và làm giàu được từ chứng khoán. Đó là bởi vì họ có được một hệ thống đầu tư chuẩn mực, biết vận dụng các công cụ phân tích, biết tuân thủ các nguyên tắc trong đầu tư.<br>		    		Có một hệ thống đầu tư chuẩn mực đã và đang được những nhà đầu tư bậc thầy trên thế giới như Warren Buffett, Charlie Munger… áp dụng. Hệ thống đầu tư và phương pháp đầu tư ưu việt đó đã được gói gọn và thực sự dễ hiểu trong cuốn PayBack Time – Ngày đòi nợ của tác giả Phil Town.<br>		    		NGÀY ĐÒI NỢ – Payback Time là cuốn sách bán chạy nhất New York Time được tác giả Phil Town sử dụng những ngôn ngữ đơn giản, dễ hiểu và lồng ghép những ví dụ thực tế giúp cho người đọc tiếp cận với những kiến thức về đầu tư chứng khoán một cách dễ dàng. Bên cạnh đó với những kiến thức và trải nghiệm của bản thân, chúng tôi đã đưa cuốn sách gần gũi hơn với bạn đọc Việt Nam.<br>		    		Cuốn sách sẽ hướng dẫn bạn từ cách thức lựa chọn, đánh giá cổ phiếu, cho đến xây dựng cho mình một danh mục các cổ phiếu sẽ mua, mức giá mua–bán nào là hợp lý, cùng với những nguyên tắc mà bạn phải tuân theo… và cứ thực hành như vậy cho tới khi bạn trở nên giàu có.<br>		    		“Một cuộc sống hạnh phúc được bắt đầu từ những quyết định đầu tư khôn ngoan”. Ngay ngày hôm nay, hãy bắt đầu quyết định đầu tư khôn ngoan của bạn bằng việc trang bị một hệ thống và phương pháp đầu tư hoàn chỉnh đã được chứng minh hiệu quả tuyệt đối qua thời gian được trình bày trong cuốn sách này. Bởi vì: Kiếm một số tiền lớn từ đầu tư chứng khoán chính là cách “trả thù” tốt nhất cho tương lai tài chính của bạn vốn đã bị cướp đi trước đây.",
                        Pages = 284,
                        CategoryId = "KT",
                        PublisherId = "VH-NT",
                        AuthorId = "A001",
                        CreatedAt = DateTime.Parse("2020-05-19 04:38:00"),
                        UpdatedAt = DateTime.Parse("2020-10-21 12:17:00"),
                        DeletedAt = DateTime.Parse("2020-12-02 00:00:00")
                    },
                    new Book
                    {
                        Id = "S002",
                        Name = "Bí Mật Tư Duy Triệu Phú",
                        Slug = "bi-mat-tu-duy-trieu-phu",
                        Price = 54000,
                        PublicationMonth = 6,
                        PublicationYear = 2019,
                        Description = "\"Ai cũng có một cuộc sống, ai cũng làm việc cần cù, ai cũng ước mơ được thành công, nhưng không mấy ai may mắn học được cách tư duy độc đáo và tầm nhìn của những tỷ phú lừng danh đã tiết lộ trong cuốn sách giá trị này\"<br>		    	(Wall Street Journal)<br>		    	Trong cuốn sách này T. Harv Eker sẽ tiết lộ những bí mật tại sao một số người lại đạt được những thành công vượt bậc, được số phận ban cho cuộc sống sung túc, giàu có, trong khi một số người khác phải chật vật, vất vả mới có một cuộc sống qua ngày. Bạn sẽ hiểu được nguồn gốc sự thật và những yếu tố quyết định thành công, thất bại để rồi áp dụng, thay đổi cách suy nghĩ, lên kế hoạch rồi tìm ra cách làm việc, đầu tư, sử dụng nguồn tài chính của bạn theo hướng hiệu quả nhất.",
                        Pages = 100,
                        CategoryId = "KT",
                        PublisherId = "TH",
                        AuthorId = "A002",
                        CreatedAt = DateTime.Parse("2020-05-19 04:51:00"),
                        UpdatedAt = DateTime.Parse("2020-10-21 08:15:00")
                    },
                    new Book
                    {
                        Id = "S003",
                        Name = "Người Giàu Có Nhất Thành Babylon",
                        Slug = "nguoi-giau-co-nhat-thanh-babylon",
                        Price = 47000,
                        PublicationMonth = 9,
                        PublicationYear = 2019,
                        Description = "Trước mắt bạn, tương lai đang trải rộng con đường dẫn tới những miền đất xa xôi đầy hứa hẹn. Trên con đường đó, bạn háo hức, mong muốn thực hiện nhiều ước mơ, dự định, khát khao… của riêng mình.<br>		    		Để những nguyện vọng của mình được thực hiện, ít nhất bạn phải thành công về mặt tiền bạc. Quyển sách này sẽ giúp bạn biết cách vận dụng những nguyên lý quan trọng để phát triển tài chính. Hãy để cuốn sách dẫn dắt bạn đi từ một hoàn cảnh khó khăn, tiêu biểu là một cái túi lép xẹp, đến một cuộc sống đầy đủ và hạnh phúc, tiêu biểu là một túi tiền căng phồng, sung túc.<br>		    		Khi nói đến tiền bạc, chúng ta thường đề cập đến quy luật trọng trường và nó luôn phổ quát và bất biến trong mọi trường hợp. Trải qua thời gian dài và phát triển, quy luật này đã được trải nghiệm và đúc rút thành những bí quyết không chỉ đảm bảo cho bạn một túi tiền đầy, mà còn giúp cho bạn có một cuộc sống cân bằng để có thể phát triển mỹ mãn hơn những tiềm năng của bản thân trong các lĩnh vực khác của cuộc sống. Bởi trên thực tế, không ai có thể phủ nhận rằng sự dồi dào về vật chất có thể làm cho đời sống con người trở nên tốt đẹp hơn. Riêng trong lĩnh vực kinh doanh, sức mạnh tài chính là phương tiện chủ yếu để đo lường mức độ thành đạt của các doanh nhân.<br>		    		Ngày nay, tiền bạc vẫn có những ảnh hưởng lớn đối với cuộc sống con người, cũng giống như cách đây năm ngàn năm nó đã chi phối mạnh mẽ cuộc sống của cư dân vương quốc Babylon, thúc đẩy họ tìm hiểu và nắm bắt các quy luật tạo ra tiền, nhằm có được một cuộc sống sung túc và sang trọng bậc nhất.<br>		    		Những trang sách này sẽ đưa chúng ta trở lại vương quốc Babylon cổ đại, cái nôi nuôi dưỡng những nguyên lý cơ bản về tài chính mà giờ đây con người hiện đại đã kế thừa và vận dụng trên toàn thế giới.",
                        CategoryId = "KT",
                        PublisherId = "TH",
                        AuthorId = "A003",
                        CreatedAt = DateTime.Parse("2020-05-19 04:57:00"),
                        UpdatedAt = DateTime.Parse("2020-10-20 22:25:00")
                    },
                    new Book
                    {
                        Id = "S004",
                        Name = "Tuổi Trẻ Với Tư Duy Triệu Phú",
                        Slug = "tuoi-tre-voi-tu-duy-trieu-phu",
                        Price = 34000,
                        PublicationMonth = 6,
                        PublicationYear = 2014,
                        Description = "Tuổi Trẻ Với Tư Duy Triệu Phú<br>		    		Phải chăng người giàu sinh ra đã giàu? Người thành công đã có sẵn tố chất thành công? Nếu thế, liệu một người bình thường có thể trở thành triệu phú?<br>		    		Laura Lyseight, tác giả của quyển sách mỏng này sẽ vén mở những chìa khóa làm giàu của những triệu phú trên thế giới để giúp bạn có thể trở thành triệu phú ngay từ thời tuổi trẻ đầy hoài bão.",
                        Pages = 179,
                        CategoryId = "KT",
                        PublisherId = "TH",
                        AuthorId = "A004",
                        CreatedAt = DateTime.Parse("2020-05-19 05:01:00"),
                        UpdatedAt = DateTime.Parse("2020-10-20 22:34:00"),
                        DeletedAt = DateTime.Parse("2020-12-02 00:00:00")
                    },
                    new Book
                    {
                        Id = "S005",
                        Name = "Đuổi Theo Tốp Dẫn Đầu",
                        Slug = "duoi-theo-top-dan-dau",
                        Price = 60000,
                        PublicationMonth = 2,
                        PublicationYear = 2009,
                        Description = "Đuổi Theo Tốp Dẫn Đầu<br>		    		Nhiều tổ chức gặp cạnh tranh mãnh liệt ngoài thị trường. Những tổ chức này dù có cố gắng bứt ra khỏi đoàn nhờ những khác biệt tạm thời, nhưng khoảng cách này rồi cũng chỉ thoáng qua.<br>		    		Nhận diện và đáp ứng một vài nhu cầu khách hàng trong một thị trường sẽ đầy ngập nguồn cung. Tìm được một nhà cung cấp ưng ý thì một thời gian ngắn sau, nhiều nhà mua sẽ đổ xô vào. Dùng một kiến thức khoa học hay một phương sách kỹ thuật tân tiến thì chẳng bao lâu cả thị trường cung sẽ chấp nhận chúng. Hậu quả của thị trường mềm dẻo đó là sự cạnh tranh ráo riết, cắt cổ.<br>		    		Tuy nhiên, đôi nơi ta thấy vài công ty hay tổ chức, trong hay ngoài khu vực tư, quản trị để tiếp tục dẫn đầu, đi trội hơn tốp sau năm này qua năm khác, có khi cả chục năm. Có đủ tốc độ, nhanh nhẹn, sẵn sàng đáp ứng và dư sức chịu đựng, họ thấy và vội nắm lấy cơ hội, rồi khi mà những đối thủ đáp ứng, tốp đi trước đã chạy tới những cơ hội mới và bỏ những đối thủ sau đuôi.<br>		    		Mời bạn đón đọc",
                        Pages = 216,
                        CategoryId = "KT",
                        PublisherId = "TH",
                        AuthorId = "A005",
                        CreatedAt = DateTime.Parse("2020-05-19 05:03:00"),
                        UpdatedAt = DateTime.Parse("2020-10-19 02:11:00")
                    },
                    new Book
                    {
                        Id = "S006",
                        Name = "Lỗ Đen: Các Bài Diễn Thuyết Trên Đài",
                        Slug = "lo-den-cac-bai-dien-thuyet-tren-dai",
                        Price = 35000,
                        PublicationMonth = 1,
                        PublicationYear = 2017,
                        Description = "Lỗ Đen: Các Bài Diễn Thuyết Trên Đài<br>		    		Sách tập hợp hai bài nói chuyện của nhà vật lý vĩ đại Stephen Hawking trên BBC vào đầu năm 2016. Trong loạt bài giảng trên BBC này, tác giả đã dựng lên thách đố phải tóm lược câu chuyện cả một đời bên trong lỗ đen chỉ trong hai cuộc trò chuyện mười lăm phút.<br>		    		Đóng góp độc đáo của Stephen Hawking cho nghiên cứu khoa học là dựng lên những phương thức tiếp cận các vấn đề chuyên môn rất đa dạng: nổi tiếng nhất, ông là người đầu tiên đã khảo sát vũ trụ rộng lớn bằng những kỹ thuật khoa học lập ra để nghiên cứu những hạt nhỏ bé bên trong nguyên tử. Các đồng nghiệp của ông trong lĩnh vực cực kỳ phức tạp này có thể lo lắng rằng công trình của họ sẽ chẳng bao giờ trình bày được để công chúng dễ hiểu. Vậy mà việc hướng đến một công chúng rộng rãi hơn lại là một biệt tài của Hawking. Để thêm phần dễ tiếp cận đối với những ai hiếu kỳ nhưng rối trí, bị mê hoặc bởi ý tưởng nhưng lúng túng về mặt khoa học, sách có phần giới thiệu và ghi chú thêm ở các điểm mấu chốt của David Shukman - biên tập viên khoa học của BBC News.",
                        Pages = 76,
                        CategoryId = "KHCN",
                        PublisherId = "NXBT",
                        AuthorId = "A006",
                        CreatedAt = DateTime.Parse("2020-05-19 05:12:00"),
                        UpdatedAt = DateTime.Parse("2020-10-20 00:05:00"),
                        DeletedAt = DateTime.Parse("2020-12-02 00:00:00")
                    },
                    new Book
                    {
                        Id = "S007",
                        Name = "Vũ Trụ Trong Vỏ Hạt Dẻ",
                        Slug = "vu-tru-trong-vo-hat-de",
                        Price = 59000,
                        PublicationMonth = 3,
                        PublicationYear = 2018,
                        Description = "Lòng khát khao khám phá luôn là động lực cho trí sáng tạo của con người trong mọi lĩnh vực không chỉ trong khoa học. Điều đó được kiểm chứng trong quyển Vũ trụ trong vỏ hạt dẻ.",
                        CategoryId = "KHCN",
                        PublisherId = "NXBT",
                        AuthorId = "A006",
                        CreatedAt = DateTime.Parse("2020-05-19 05:12:00"),
                        UpdatedAt = DateTime.Parse("2020-10-19 02:11:00")
                    },
                    new Book
                    {
                        Id = "S008",
                        Name = "Chuyện Kể Về Danh Nhân Thế Giới - Stephen Hawking",
                        Slug = "chuyen-ke-ve-danh-nhan-the-gioi-stephen-hawking",
                        Price = 50000,
                        PublicationMonth = 4,
                        PublicationYear = 2014,
                        Description = "Chuyện Kể Về Danh Nhân Thế Giới - Stephen Hawking<br>		    		Khi bác sĩ kết luận rằng Stephen King chỉ có thể sống thêm ba năm nữa do mắc bệnh xơ cứng cột bên teo cơ, tất cả mọi người đều nghĩ rằng ông không thể làm được gì nữa. Thế nhưng trong suốt 30 năm sau đó, Stephen King đã trở thành nhà vật lý hàng đầu thế giới.",
                        CategoryId = "STN",
                        PublisherId = "KD",
                        AuthorId = "A006",
                        CreatedAt = DateTime.Parse("2020-05-19 05:12:00"),
                        UpdatedAt = DateTime.Parse("2020-10-20 22:08:00")
                    },
                    new Book
                    {
                        Id = "S009",
                        Name = "Lược Sử Thời Gian",
                        Slug = "luoc-su-thoi-gian",
                        Price = 87000,
                        PublicationMonth = 12,
                        PublicationYear = 2016,
                        Description = "Lược Sử Thời Gian<br>		    		Cùng với Vũ trụ trong vỏ hạt dẻ, Lược sử thời gian được xem là cuốn sách nổi tiếng và phổ biến nhất về vũ trụ học của Stephen Hawking, liên tục được nằm trong danh mục sách bán chạy nhất của các tạp chí nổi tiếng thế giới.Lược sử thời gian là cuốn sử thi về sự ra đời, sự hình thành và phát triển của vũ trụ. Tác giả đưa vào tác phẩm của mình toàn bộ tiến bộ tiến trình khám phá của trí tuệ loài người trên nhiều lĩnh vực: Triết học, Vật lý, Thiên văn học…<br>		    		Chúng ta sống cuộc sống hàng ngày của chúng ta mà hầu như không hiểu được về thế giới chung quanh. Chúng ta cũng ít khi suy ngẫm về cơ chế đã tạo ra ánh sáng Mặt trời - một yếu tố quan trọng góp phần tạo nên sự sống, về hấp dẫn – cái chất keo đã kết dính chúng ta vào Trái đất mà nếu khác đi chúng ta sẽ xoay tít và trôi dạt vào không gian vũ trụ, về nguyên tử đã cấu tạo nên tất cả chúng ta và chúng ta hoàn toàn lệ thuộc vào sự bền vững của chúng. Chỉ trừ có trẻ em (vì chúng còn biết quá ít để không ngần ngại đặt ra những câu hỏi quan trọng) còn ít ai trong chúng ta tốn thời gian để băn khoăn tại sao tự nhiên lại như thế này mà không như thế khác, vũ trụ ra đời từ đâu, hoặc nó có mãi mãi như thế này không, liệu có một ngày nào đó thời gian sẽ trôi giật lùi, hậu quả có trước nguyên nhân hay không; hoặc có giới hạn cuối cùng cho sự hiểu biết của con người hay không. Thậm chí có những đứa trẻ con, mà tôi có gặp một số, muốn biết lỗ đen là cái gì; cái gì là hạt vật chất nhỏ bé nhất, tại sao chúng ta chỉ nhớ quá khứ mà không nhớ tương lai; và nếu lúc bắt đầu là hỗn loạn thì làm thế nào có sự trật tự như ta thấy hôm nay và tại sao lại có vũ trụ.<br>		    		Trong xã hội chúng ta các bậc phụ huynh cũng như các thầy giáo vẫn còn thói quen trả lời những câu hỏi đó bằng cách nhún vai hoặc viện đến các giáo lý mơ hồ. Một số các giáo lý ấy lại hoàn toàn không thích hợp với những vấn đề vừa nêu ở trên, bởi vì chúng phơi bày quá rõ những hạn chế sự hiểu biết của con người.<br>		    		Hiện nay, Hawking là giáo sư toán học của trường Đại học Cambridge, với cương vị mà trước đây Newton, rồi sau này P.A.M Dirac - hai nhà nghiên cứu nổi tiếng về những cái cực lớn và những cái cực nhỏ - đảm nhiệm. Hawking là người kế tục hết sức xứng đáng của họ. Cuốn sách đầu tiên của Hawking dành cho những người không phải là chuyên gia này có thể xem là một phần thưởng về nhiều mặt cho công chúng không chuyên. Cuốn sách vừa hấp dẫn bởi nội dung phong phú của nó vừa bởi nó cho chúng ta một cái nhìn khái quát qua công trình của chính tác giả cuốn sách này. Cuốn sách chứa đựng những khám phá trên những ranh giới của vật lý học, thiên văn học, vũ trụ học và của cả lòng dũng cảm nữa.<br>		    		Đây cũng là cuốn sách về Thượng đế hay đúng hơn là về sự không có mặt của Thượng đế. Chữ Thượng đế xuất hiện trên nhiều trang của cuốn sách này. Hawking đã dấn thân đi tìm câu trả lời cho câu hỏi nổi tiếng của Einstein: liệu Thượng đế có sự lựa chọn nào trong việc tạo ra vũ trụ này hay không? Hawking đã nhiều lần tuyên bố một cách công khai rằng ông có ý định tìm hiểu ý nghĩa của Thượng đế. Và từ nỗ lực đó, ông đã rút ra một kết luận bất ngờ nhất, ít nhất là cho đến hiện nay, đó là vũ trụ không có biên trong không gian, không có bắt đầu và kết thúc trong thời gian và chẳng có việc gì cho Đấng sáng thế phải làm ở đây cả. - CARL SAGA.",
                        Pages = 284,
                        CategoryId = "KHCN",
                        PublisherId = "NXBT",
                        AuthorId = "A006",
                        CreatedAt = DateTime.Parse("2020-05-19 05:12:00"),
                        UpdatedAt = DateTime.Parse("2020-10-19 23:20:00")
                    },
                    new Book
                    {
                        Id = "S010",
                        Name = "Dế Mèn Phiêu Lưu Ký",
                        Slug = "de-men-phieu-luu-ky",
                        Price = 35000,
                        PublicationMonth = 1,
                        PublicationYear = 2019,
                        Description = "Ấn bản minh họa màu đặc biệt của Dế Mèn phiêu lưu ký, với phần tranh ruột được in hai màu xanh - đen ấn tượng, gợi không khí đồng thoại.<br>		    		“Một con dế đã từ tay ông thả ra chu du thế giới tìm những điều tốt đẹp cho loài người. Và con dế ấy đã mang tên tuổi ông đi cùng trên những chặng đường phiêu lưu đến với cộng đồng những con vật trong văn học thế giới, đến với những xứ sở thiên nhiên và văn hóa của các quốc gia khác. Dế Mèn Tô Hoài đã lại sinh ra Tô Hoài Dế Mèn, một nhà văn trẻ mãi không già trong văn chươ” - Nhà phê bình Phạm Xuân Nguyên<br>		    		“Ông rất hiểu tư duy trẻ thơ, kể với chúng theo cách nghĩ của chúng, lí giải sự vật theo lô gích của trẻ. Hơn thế, với biệt tài miêu tả loài vật, Tô Hoài dựng lên một thế giới gần gũi với trẻ thơ. Khi cần, ông biết đem vào chất du ký khiến cho độc giả nhỏ tuổi vừa hồi hộp theo dõi, vừa thích thú khám phá.” - TS Nguyễn Đăng Điệp",
                        Pages = 144,
                        CategoryId = "STN",
                        PublisherId = "KD",
                        AuthorId = "A007",
                        CreatedAt = DateTime.Parse("2020-05-19 07:15:00"),
                        UpdatedAt = DateTime.Parse("2020-10-20 05:18:00"),
                        DeletedAt = DateTime.Parse("2020-12-02 00:00:00")
                    },
                    new Book
                    {
                        Id = "S011",
                        Name = "Bố Xấu , Bố Tốt",
                        Slug = "bo-xau-bo-tot",
                        Price = 83000,
                        PublicationMonth = 1,
                        PublicationYear = 2019,
                        Description = "Trên đời có đủ kiểu bố. Có bố béo và bố gầy, bố cao và bố thấp.<br>		    		Có bố trẻ và bố già, bố thông minh và bố tối dạ. Có bố ngớ ngẩn và bố nghiêm túc, bố ồn ã và bố lặng lẽ. Và dĩ nhiên tất cả đều là những ông bố tốt.<br>		    		Nhưng có thực như vậy?<br>		    		“Một câu chuyện kịch tính và ấm lòng sẽ khiến độc giả hồi hộp nhấp nhổm, có lúc cười thả ga, có lúc lại cảm động rơi nước mắt.”<br>		    		- HarperCollins<br>		    		“Bố xấu, bố tốt là một câu chuyện táo bạo, xuất sắc và tuyệt đẹp. Cuốn sách chắc chắn sẽ chiếm một chỗ đứng vững chãi trong trái tim độc giả của Walliams.”<br>		    		- Ann-Janine Murtagh",
                        Pages = 444,
                        CategoryId = "STN",
                        PublisherId = "HNV",
                        AuthorId = "A008",
                        CreatedAt = DateTime.Parse("2020-05-19 07:26:00"),
                        UpdatedAt = DateTime.Parse("2020-10-19 11:00:00")
                    },
                    new Book
                    {
                        Id = "S012",
                        Name = "Ông Nội Vượt Ngục",
                        Slug = "ong-noi-vuot-nguc",
                        Price = 70000,
                        PublicationMonth = 6,
                        PublicationYear = 2018,
                        Description = "Trong quyển sách này, tác giả muốn gửi đến đọc giả chuyến \"vượt ngục\" ly kỳ của hai ông cháu trong câu chuyện. Giọng văn tình cảm, dí dỏm, nét vẽ đáng yêu… nhằm giúp các em tiếp nhận và thẩm thấu nhanh nhất.<br>		    		Câu chuyện đem lại những bài học hay về lối sống trung thực, về tình yêu thương gia đình và nhiều điều cần thiết để phát triển nhân cách cho bạn đọc trẻ tuổi, cũng như những bất ngờ thú vị cho cả người đọc trưởng thành.",
                        Pages = 428,
                        CategoryId = "STN",
                        PublisherId = "HNV",
                        AuthorId = "A008",
                        TranslatorId = "A009",
                        CreatedAt = DateTime.Parse("2020-05-19 07:26:00"),
                        UpdatedAt = DateTime.Parse("2020-10-20 21:11:00")
                    },
                    new Book
                    {
                        Id = "S013",
                        Name = "Bánh Mì Kẹp Chuột",
                        Slug = "banh-mi-kep-chuot",
                        Price = 51000,
                        PublicationMonth = 10,
                        PublicationYear = 2019,
                        Description = "Zoe luôn mơ ước được có một sô diễn xiếc chuột của riêng mình, nhưng chú chuột hamster của con bé đã chết một cách đột ngột, còn chuột cưng mới thì đang gặp nguy hiểm chết người.<br>		    		Tương lai thảm khốc nào chờ đang đợi nó?<br>		    		Và ai đang đứng sau tất cả chuyện này?<br>		    		Là bà mẹ kế bị ám ảnh với món bim bim vị tôm cốc tai và cực kỳ ghét chuột...<br>		    		... hay kẻ bán món bánh mì kẹp bí ẩn nhưng vô cùng hút khách?<br>		    		---<br>		    		“Thú vị từ đầu chí cuối... một Roald Dahl thế hệ mới.”<br>		    		- The Times<br>		    		“David Walliams đã trở thành một tác giả có sức ảnh hưởng dữ dội trong giới văn học thiếu nhi.”<br>		    		- The Sun",
                        Pages = 248,
                        CategoryId = "STN",
                        PublisherId = "HNV",
                        AuthorId = "A008",
                        CreatedAt = DateTime.Parse("2020-05-19 07:26:00"),
                        UpdatedAt = DateTime.Parse("2020-10-20 22:35:00")
                    },
                    new Book
                    {
                        Id = "S014",
                        Name = "Nha Sĩ Yêu Quái",
                        Slug = "nha-si-yeu-quai",
                        Price = 64000,
                        PublicationMonth = 2,
                        PublicationYear = 2016,
                        Description = "Bóng tối đã tràn vào thị trấn. Những sự việc kỳ quái liên tiếp xảy ra trong đêm khuya. Thay vì những đồng xu sáng lấp lánh của bà tiên răng, bọn trẻ lại tìm thấy... một con ốc sên chết, một con nhện sống, hàng trăm con bọ sâu tai bò lúc nhúc dưới gối.<br>		    		Ai đang đứng sau những chuyện này?<br>		    		Liệu đó có phải là mụ Nha sĩ yêu quái?<br>		    		Hãy cùng Alfie và bạn bè tìm ra câu trả lời!<br>		    		Nhận định<br>		    		\"Một kết hợp thành công của sự dí dỏm và tình người ấm áp.\" - Telegraph.<br>		    		\"Tôi thực sự yêu thích những cuốn sách của David Walliams. Chỉ một vài năm nữa thôi, chúng sẽ trở thành kinh điển.\" - Sue Townsend, tác giả sáng tạo nên Adrian Mole.",
                        Pages = 407,
                        CategoryId = "STN",
                        PublisherId = "HNV",
                        AuthorId = "A008",
                        CreatedAt = DateTime.Parse("2020-05-19 07:26:00"),
                        UpdatedAt = DateTime.Parse("2020-10-20 05:09:00")
                    },
                    new Book
                    {
                        Id = "S015",
                        Name = "Đừng Lựa Chọn An Nhàn Khi Còn Trẻ",
                        Slug = "dung-lua-chon-an-nhan-khi-con-tre",
                        Price = 56000,
                        PublicationMonth = 2,
                        PublicationYear = 2019,
                        Description = "Trong độ xuân xanh phơi phới ngày ấy, bạn không dám mạo hiểm, không dám nỗ lực để kiếm học bổng, không chịu tìm tòi những thử thách trong công việc, không phấn đấu hướng đến ước mơ của mình. Bạn mơ mộng rằng làm việc xong sẽ vào làm ở một công ty nổi tiếng, làm một thời gian sẽ thăng quan tiến chức. Mơ mộng rằng khởi nghiệp xong sẽ lập tức nhận được tiền đầu tư, cầm được tiền đầu tư là sẽ niêm yết trên sàn chứng khoán. Mơ mộng rằng muốn gì sẽ có đó, không thiếu tiền cũng chẳng thiếu tình, an hưởng những năm tháng êm đềm trong cuộc đời mình. Nhưng vì sao bạn lại nghĩ rằng bạn chẳng cần bỏ ra chút công sức nào, cuộc sống sẽ dâng đến tận miệng những thứ bạn muốn? Bạn cần phải hiểu rằng: Hấp tấp muốn mau chóng thành công rất dễ khiến chúng ta đi vào mê lộ. Thanh xuân là khoảng thời gian đẹp đẽ nhất trong đời, cũng là những năm tháng then chốt có thể quyết định tương lai của một người. Nếu bạn lựa chọn an nhàn trong 10 năm, tương lai sẽ buộc bạn phải vất vả trong 50 năm để bù đắp lại. Nếu bạn bươn chải vất vả trong 10 năm, thứ mà bạn chắc chắn có được là 50 năm hạnh phúc. Điều quý giá nhất không phải là tiền mà là tiền bạc. Thế nên, bạn à, đừng lựa chọn an nhàn khi còn trẻ.",
                        Pages = 316,
                        CategoryId = "TD-KNS",
                        PublisherId = "TG",
                        AuthorId = "A010",
                        TranslatorId = "A011",
                        CreatedAt = DateTime.Parse("2020-05-19 07:38:00"),
                        UpdatedAt = DateTime.Parse("2020-10-21 08:31:00")
                    },
                    new Book
                    {
                        Id = "S016",
                        Name = "Nóng Giận Là Bản Năng , Tĩnh Lặng Là Bản Lĩnh",
                        Slug = "nong-gian-la-ban-nang-tinh-lang-la-ban-linh",
                        Price = 67000,
                        PublicationMonth = 1,
                        PublicationYear = 2019,
                        Description = "Sai lầm lớn nhất của chúng ta là đem những tật xấu, những cảm xúc tiêu cực trút bỏ lên những người xung quanh, càng là người thân càng dễ gây thương tổn.<br>		    		Cái gì cũng nói toạc ra, cái gì cũng bộc lộ hết không phải là thẳng tính, mà là thiếu bản lĩnh. Suy cho cùng, tất cả những cảm xúc tiêu cực của con người đều là sự phẫn nộ dành cho bất lực của bản thân. Nếu bạn đúng, bạn không cần phải nổi giận. Nếu bạn sai, bạn không có tư cách nổi giận.<br>		    		Đem một nắm muối bỏ vào cốc nước, cốc nước trở nên mặn chát. Đem một nắm muối bỏ vào hồ nước, hồ nước vẫn ngọt lành. Lòng người cũng vậy, càng nông cạn càng dễ biến chất, càng sâu sắc càng khó lung lay. Ý nghĩa của đời người không ngoài việc tu tâm dưỡng tính, để mở lòng ra bao la như biển hồ, trước những nắm muối thị phi của cuộc đời vẫn thản nhiên không xao động.<br>		    		“Nóng giận là bản năng, tĩnh lặng là bản lĩnh” là từ bỏ “tam độc”, tu dưỡng một trái tim trong sáng:<br>		    		Từ bỏ “tham” – bớt một phần ham muốn, thêm một phần tự do.<br>		    		Từ bỏ “sân” – bớt một phần tranh chấp, thêm một phần ung dung.<br>		    		Từ bỏ “si” – bớt một phần mê muội, thêm một phần tĩnh tâm.<br>		    		Cuốn sách là tập hợp những bài học, lời tâm sự về nhân sinh, luận về cuộc đời của đại sư Hoằng Nhất – vị tài tử buông mọi trần tục để quy y cửa Phật, người được mệnh danh tinh thông kim cổ và cũng có tầm ảnh hưởng lớn trong Phật giáo.<br>		    		Trưởng thành, hãy để lòng rộng mở, tiến gần đến chữ “Người”, học được cách bao dung, học được cách khống chế cảm xúc. Đừng để những xúc động nhất thời như ngọn lửa, tưởng thiêu rụi được kẻ thù mà thực ra lại làm bỏng tay ta trước.",
                        Pages = 264,
                        CategoryId = "TD-KNS",
                        PublisherId = "TG",
                        AuthorId = "A012",
                        CreatedAt = DateTime.Parse("2020-05-19 07:38:00"),
                        UpdatedAt = DateTime.Parse("2020-10-21 08:32:00"),
                        DeletedAt = DateTime.Parse("2020-12-02 00:00:00")
                    },
                    new Book
                    {
                        Id = "S017",
                        Name = "Cuộc Sống \"Đếch\" Giống Cuộc Đời",
                        Slug = "cuoc-song-dech-giong-cuoc-doi",
                        Price = 62000,
                        PublicationMonth = 2,
                        PublicationYear = 2020,
                        Description = "Sau sự thành công ngoài sức tưởng tượng của cuốn sách đầu tay “Cuộc sống rất giống cuộc đời”, sau 4 năm, tác giả Hoàng Hải Nguyễn mới trở lại với độc giả với cuốn sách siêu hài hước “Cuộc sống đếch giống cuộc đời” – dự báo một hiện tượng mạng trong thời gian tới.<br>		    	Ghi dấu ấn mạnh mẽ nhờ giọng văn phóng khoáng, hóm hỉnh, sâu cay và đặc biệt là biệt tài gây cười đặc trưng có một không hai, chắc chắn với cuốn sách tiếp theo này, tác giả Hoàng Hải Nguyễn sẽ tiếp tục chinh phục các độc giả khó tính nhất.<br>		    	Luôn tâm niệm mình là một người viết yêu văn chương, chính vì thế mà các bài viết của anh không tạo cảm giác ức chế hay nhàm chán với những lối đi cũ mòn của văn chương hoa mĩ. Dưới góc nhìn của một người đàn ông U40, đã có gia đình và hai con, anh nhìn nhận sự xoay vần của cuộc đời theo cách của người từng trải có nhiều kinh nghiệm.<br>		    	Những câu chuyện về tổ ấm gia đình, chuyện xã hội, chuyện cuộc sống, chuyện phiếm bên lề được kết hợp khéo léo với chất văn “rất đàn ông” là điểm sáng giúp anh ghi dấu trong lòng bạn đọc. Từ những con chữ thông minh, ,sắc lẹm như lưỡi dao ấy, lại khiến người đọc trăn trở, đau đáu, có một khoảng lặng để suy ngẫm và nhận ra nhiều điều có ích.<br>		    	“Gia đình là thứ bất khả xâm phạm. Cứ tin tôi, mọi sự thành công trong xã hội đều không thể bù đắp được thất bại trong cuộc sống gia đình”.<br>		    	Nếu mong chờ một tác phẩm văn học chính thống với những câu chữ khô khốc, thì hẳn là cuốn sách sẽ khiến bạn thất vọng. Nhưng nếu bạn đang cảm thấy bế tắc trong cuộc sống, cần một ai đó xốc lại tinh thần để tiếp tục chiến đấu với cuộc đời thì chắc chắn không nên bỏ lỡ cuốn sách này. Cuộc sống đếch giống cuộc đời sẽ đem lại cho bạn những tiếng cười sảng khoái, những phút giây thư giãn cùng những bài học sâu sắc, tâm đắc qua từng trang sách.<br>		    	Giống như lời tác giả tâm sự “Cuộc sống rất giống cuộc đời vì cuộc sống là tập hợp của vô số cuộc đời, cuộc sống không giống cuộc đời vì cuộc đời là hữu hạn còn cuộc sống là vô hạn. Cho dù cuộc sống hay cuộc đời của bạn có khó khan vất vả thế nào thì tôi vẫn mong các bạn hãy luôn suy nghĩ một cách tích cực và hài hước nhất.<br>		    	Có người đã nói rằng: Cuối cùng thì mọi thứ đều sẽ ổn, nếu chưa ổn thì tức là chưa phải cuối cùng. Vậy đấy các bạn ạ!",
                        Pages = 216,
                        CategoryId = "TD-KNS",
                        PublisherId = "HN",
                        AuthorId = "A013",
                        CreatedAt = DateTime.Parse("2020-05-19 21:56:00"),
                        UpdatedAt = DateTime.Parse("2020-10-20 09:41:00")
                    },
                    new Book
                    {
                        Id = "S018",
                        Name = "Cuộc Sống Rất Giống Cuộc Đời",
                        Slug = "cuoc-song-rat-giong-cuoc-doi",
                        Price = 52000,
                        PublicationMonth = 2,
                        PublicationYear = 2016,
                        Description = "Nếu bạn đang cảm thấy bế tắc trong cuộc sống, cần một ai đó xốc lại tinh thần để tiếp tục chiến đấu với cuộc đời thì chắc chắn không nên bỏ lỡ cuốn sách này. Cuộc sống rất giống cuộc đời sẽ đem lại cho bạn những tiếng cười sảng khoái và những phút giây thư giãn qua từng trang sách.<br>		    		<br>		    		Không tạo cảm giác ức chế hay nhàm chán với những lối đi cũ mòn của văn chương hoa mĩ. Giọng văn và cách kể của tác giả Hoàng Hải Nguyễn có phần phóng khoáng,  hóm hỉnh, sâu cay và đặc biệt là biệt tài gây cười đặc trưng có một không hai. Từng gây sốt cộng đồng mạng với những bài viết như “Đàn ông tuổi 40, Thư mẫu gửi vợ, Nhật ký của bố, Bây giờ anh định thế nào ?...” ;  anh từng bước xây dựng cho mình một hướng đi độc đáo và tạo được dấu ấn với cá tính riêng biệt,  cuốn sách bạn là tập hợp tất cả những tản văn hay nhất anh góp nhặt trong quãng thời gian “chinh chiến với cuộc đời.”<br>		    		Dưới góc nhìn của một người đàn ông U40, đã có gia đình và hai con, anh nhìn nhận sự xoay vần của cuộc đời theo cách của  người từng trải có nhiều kinh nghiệm.<br>		    		“Có lẽ trên đời này tôi chưa bao giờ được bế trên tay một sinh vật xinh đẹp như vậy, tôi cũng chưa thấy một thứ tình cảm nào gắn kết ngay khi chỉ vừa gặp mặt, một tình yêu kì lạ hình thành từ khi vợ tôi mang thai và kịp hoàn thiện vào giây phút tôi nhìn thấy con gái, đó là tình cha con!<br>		    		(Trích Nhật ký của bố)<br>		    		Những câu chuyện về tổ ấm gia đình, chuyện xã hội, chuyện cuộc sống, chuyện phiếm bên lề được kết hợp khéo léo với chất văn “rất đàn ông” là điểm sáng giúp anh ghi dấu trong lòng bạn đọc. Từ những con chữ thông minh ,sắc lẹm như lưỡi dao ấy, lại khiến người đọc trăn trở, đau đáu, có một khoảng lặng để suy ngẫm và nhận ra nhiều điều có ích.<br>		    		“ Đàn ông tuổi 15 mơ ước thành đàn ông tuổi 20, đàn ông tuổi 20 mơ ước được trở thành đàn ông tuổi 30, đàn ông tuổi 30 mơ ước được trở thành đàn ông tuổi 40 và đàn ông tuổi 40 lại mơ ước được đặt chân lên cỗ máy thời gian để quay lại tuổi 30 với toàn bộ tài sản của mình!”<br>		    		(Trích Đàn ông tuổi 40)<br>		    		Giống như lời tác giả tâm sự “ Tôi hi vọng các bạn sẽ có được tiếng cười và sự vui vẻ khi đọc nó sau một ngày làm việc vất vả. Qua các câu chuyện, tôi mong muốn các bạn hãy luôn lạc quan, yêu đời, mỗi người chỉ sống có một lần vì vậy hãy tận hưởng nó bằng niềm vui.<br>		    		Cuộc sống rất giống cuộc đời !”",
                        Pages = 256,
                        CategoryId = "TD-KNS",
                        PublisherId = "TG",
                        AuthorId = "A013",
                        CreatedAt = DateTime.Parse("2020-05-19 21:56:00"),
                        UpdatedAt = DateTime.Parse("2020-10-21 08:25:00")
                    },
                    new Book
                    {
                        Id = "S019",
                        Name = "Lá Nằm Trong Lá",
                        Slug = "la-nam-trong-la",
                        Price = 45000,
                        PublicationMonth = 2,
                        PublicationYear = 2017,
                        Description = "Mở cuốn sách mới của tác giả Nguyễn Nhật Ánh, bạn sẽ gặp những cái tên quen thuộc của những người nổi tiếng ngay trang 5 trang trọng đề tặng “các bạn văn hữu”: nhà thơ Bùi Chí Vinh, Phạm Sỹ Sáu, Lê Minh Quốc, nhà văn Nguyễn Đông Thức, nhà phê bình Huỳnh Như Phương, nhà báo Nguyễn Công Khế, Kim Hạnh, … Tuổi niên thiếu của “những thằng quỷ nhỏ” trong truyện có gắn gì với họ không, có phải là họ không, chỉ họ và tác giả mới biết, nhưng bạn đọc thì có thể tưởng tượng ra một nhóm “thằng” thân thiết, bắt đầu lớn, biết thinh thích con gái và ngập mộng văn chương.<br>		    		Chuyện của bút nhóm học trò, truyện nằm trong truyện, những cơn giận dỗi ghen tuông bạn gái bạn trai với nhau, nhiều nhất vẫn là chuyện nhà trường có các cô giáo hơn trò vài tuổi coi trò như bạn, có thầy hiệu trưởng tâm lý và yêu thương học trò coi trò như con…Trở lại với đề tài học trò, hóm hỉnh và gần gũi như chính các em, Nguyễn Nhật Ánh chắc chắn sẽ được các bạn trẻ vui mừng đón nhận. Cứ lật đằng cuối sách, đọc bài thơ tình trong veo là có thể thấy điều đó “…Khi mùa xuân đến / Tình anh lại đầy / Lá nằm trong lá / Tay nằm trong tay”.<br>		    		“Viết cho trẻ con giờ khó hơn xưa. Có hàng bao nhiêu là món giải trí rầm rộ, hoành tráng và lộng lẫy dọn sẵn, muốn thu phục “lũ tiểu yêu” thế kỷ 21 này, nhà văn không chỉ thông thuộc mặt bằng hiểu biết của chúng, mà còn phải tâm tình được với chúng bằng tốc độ của chúng. Có thể nói Nguyễn Nhật Ánh là một người lớn chấp nhận tham dự món du hành tốc độ cao cùng lũ trẻ. Thời thong thả đạp xe, từ tốn khuyên bảo đã qua rồi. Thực ra Nguyễn Nhật Ánh đã biết đi tàu tốc hành từ hai thập niên trước, khi nhữngKính vạn hoa, Thằng quỷ nhỏ, Bàn có năm chỗ ngồi… đem lại cho văn học thiếu nhi một diện mạo mới mẻ, những câu chuyện tưởng như ấm ớ ngày này qua tháng khác nhưng sao hôm nay nhìn lại, những người đã từng là trẻ con thấy nhớ quá..” (VIỆT TRUNG, báo Thanh Niên).<br>		    		“Bước vào khoảng trời của tuổi biết buồn, Nguyễn Nhật Ánh đã ghi lại những bâng khuâng rung cảm đầu đời. Trong tâm tưởng của các em, bây giờ không chỉ nghĩ về cái gì mà còn nghĩ về ai, về một người khác giới cụ thể nào, và về cả bản thân, thế giới ấy tràn ngập những câu hỏi xôn xao về cái-gọi-là-tình-yêu. Truyện của Nguyễn Nhật Ánh đã đưa vào những câu hỏi lớn, muôn thuở, quen thuộc - những câu hỏi mà dường như trong đời ai cũng từng đối diện ít nhất một lần. Vì thế, trong khi độc giả thiếu niên phục lăn vì nhà văn đi guốc vào bụng họ, thì độc giả người lớn mỉm cười mơ màng nhớ lại một thời thơ dại...\" (TS. NGUYỄN THỊ THANH XUÂN, nhà nghiên cứu văn học).",
                        Pages = 252,
                        CategoryId = "VHVN",
                        PublisherId = "NXBT",
                        AuthorId = "A014",
                        CreatedAt = DateTime.Parse("2020-05-19 22:14:00"),
                        UpdatedAt = DateTime.Parse("2020-10-19 02:18:00")
                    },
                    new Book
                    {
                        Id = "S020",
                        Name = "Ngồi Khóc Trên Cây",
                        Slug = "ngoi-khoc-tren-cay",
                        Price = 63000,
                        PublicationMonth = 8,
                        PublicationYear = 2017,
                        Description = "Mở đầu là kỳ nghỉ hè tại một ngôi làng thơ mộng ven sông với nhân vật là những đứa trẻ mới lớn có vô vàn trò chơi đơn sơ hấp dẫn ghi dấu mãi trong lòng.   Mối tình đầu trong veo của cô bé Rùa và chàng sinh viên quê học ở thành phố có giống tình đầu của bạn thời đi học? Và cái cách họ thương nhau giấu giếm, không dám làm nhau buồn, khát khao hạnh phúc đến nghẹt thở có phải là câu chuyện chính?<br>		    		\"Nồng nàn lên với<br>		    		Cốc rượu trên tay<br>		    		Xanh xanh lên với<br>		    		Trời cao ngàn ngày<br>		    		Dài nhanh lên với<br>		    		Tóc xõa ngang mày<br>		    		Lớn nhanh lên với<br>		    		Bé bỏng chiều nay”<br>		    		Bạn sẽ được tác giả dẫn đi liền một mạch trong một thứ cảm xúc rưng rưng của tình yêu thương. Bạn sẽ thấy may mắn vì đang đuợc sống trong cuộc sống này, thấy yêu thế những tấm tình người… tất cả đều đẹp hồn hậu một cách giản dị.<br>		    		Với cuốn sách này, một lần nữa người đọc lại được Nguyễn Nhật Ánh tặng món quà quý giá: lòng tin vào điều tốt có thật trên đời.",
                        Pages = 342,
                        CategoryId = "VHVN",
                        PublisherId = "NXBT",
                        AuthorId = "A014",
                        CreatedAt = DateTime.Parse("2020-05-19 22:14:00"),
                        UpdatedAt = DateTime.Parse("2020-10-20 10:40:00")
                    },
                    new Book
                    {
                        Id = "S021",
                        Name = "Tôi Thấy Hoa Vàng Trên Cỏ Xanh",
                        Slug = "toi-thay-hoa-vang-tren-co-xanh",
                        Price = 62000,
                        PublicationMonth = 12,
                        PublicationYear = 2018,
                        Description = "Ta bắt gặp trong Tôi Thấy Hoa Vàng Trên Cỏ Xanh một thế giới đấy bất ngờ và thi vị non trẻ với những suy ngẫm giản dị thôi nhưng gần gũi đến lạ. Câu chuyện của Tôi Thấy Hoa Vàng Trên Cỏ Xanh có chút này chút kia, để ai soi vào cũng thấy mình trong đó, kiểu như lá thư tình đầu đời của cu Thiều chẳng hạ ngây ngô và khờ khạo.<br>		    		Nhưng Tôi Thấy Hoa Vàng Trên Cỏ Xanh hình như không còn trong trẻo, thuần khiết trọn vẹn của một thế giới tuổi thơ nữa. Cuốn sách nhỏ nhắn vẫn hồn hậu, dí dỏm, ngọt ngào nhưng lại phảng phất nỗi buồn, về một người cha bệnh tật trốn nhà vì không muốn làm khổ vợ con, về một người cha khác giả làm vua bởi đứa con tâm thầm của ông luôn nghĩ mình là công chúa, Những bài học về luân lý, về tình người trở đi trở lại trong day dứt và tiếc nuối.<br>		    		Tôi Thấy Hoa Vàng Trên Cỏ Xanh lắng đọng nhẹ nhàng trong tâm tưởng để rồi ai đã lỡ đọc rồi mà muốn quên đi thì thật khó.<br>		    		 <br>		    		“Tôi thấy hoa vàng trên cỏ xanh” truyện dài mới nhất của nhà văn vừa nhận giải văn chương ASEAN Nguyễn Nhật Ánh - đã được Nhà xuất bản Trẻ mua tác quyền và giới thiệu đến độc giả cả nước.<br>		    		Cuốn sách viết về tuổi thơ nghèo khó ở một làng quê, bên cạnh đề tài tình yêu quen thuộc, lần đầu tiên Nguyễn Nhật Ánh đưa vào tác phẩm của mình những nhân vật phản diện và đặt ra vấn đề đạo đức như sự vô tâm, cái ác. 81 chương ngắn là 81 câu chuyện nhỏ của những đứa trẻ xảy ra ở một ngôi làng: chuyện về con cóc Cậu trời, chuyện ma, chuyện công chúa và hoàng tử, bên cạnh chuyện đói ăn, cháy nhà, lụt lội, “Tôi thấy hoa vàng trên cỏ xanh”hứa hẹn đem đến những điều thú vị với cả bạn đọc nhỏ tuổi và người lớn bằng giọng văn trong sáng, hồn nhiên, giản dị của trẻ con cùng nhiều tình tiết thú vị, bất ngờ và cảm động trong suốt hơn 300 trang sách. Cuốn sách, vì thế có sức ám ảnh, thu hút, hấp dẫn không thể bỏ qua.",
                        Pages = 378,
                        CategoryId = "VHVN",
                        PublisherId = "NXBT",
                        AuthorId = "A014",
                        CreatedAt = DateTime.Parse("2020-05-19 22:14:00"),
                        UpdatedAt = DateTime.Parse("2020-10-19 02:19:00")
                    },
                    new Book
                    {
                        Id = "S022",
                        Name = "Cho Tôi Xin Một Vé Đi Tuổi Thơ",
                        Slug = "cho-toi-xin-mot-ve-di-tuoi-tho",
                        Price = 53000,
                        PublicationMonth = 11,
                        PublicationYear = 2018,
                        Description = "Truyện Cho tôi xin một vé đi tuổi thơ là sáng tác mới nhất của nhà văn Nguyễn Nhật Ánh. Nhà văn mời người đọc lên chuyến tàu quay ngược trở lại thăm tuổi thơ và tình bạn dễ thương của 4 bạn nhỏ. Những trò chơi dễ thương thời bé, tính cách thật thà, thẳng thắn một cách thông minh và dại dột, những ước mơ tự do trong lòng… khiến cuốn sách có thể làm các bậc phụ huynh lo lắng rồi thở phào. Không chỉ thích hợp với người đọc trẻ, cuốn sách còn có thể hấp dẫn và thực sự có ích cho người lớn trong quan hệ với con mình.",
                        CategoryId = "VHVN",
                        PublisherId = "NXBT",
                        AuthorId = "A014",
                        CreatedAt = DateTime.Parse("2020-05-19 22:14:00"),
                        UpdatedAt = DateTime.Parse("2020-10-19 02:19:00"),
                        DeletedAt = DateTime.Parse("2020-12-02 00:00:00")
                    },
                    new Book
                    {
                        Id = "S023",
                        Name = "Cô Gái Đến Từ Hôm Qua",
                        Slug = "co-gai-den-tu-hom-qua",
                        Price = 48000,
                        PublicationMonth = 6,
                        PublicationYear = 2017,
                        Description = "Nếu ngày xưa còn bé, Thư luôn tự hào mình là cậu con trai thông minh có quyền bắt nạt và sai khiến các cô bé cùng lứa tuổi thì giờ đây khi lớn lên, anh luôn khổ sở khi thấy mình ngu ngơ và bị con gái “xỏ mũi”. Và điều nghịch lý ấy xem ra càng “trớ trêu’ hơn, khi như một định mệnh, Thư nhận ra Việt An, cô bạn học thông minh thường làm mình bối rối bấy lâu nay chính là Tiểu Li, con bé hàng xóm ngốc nghếch từng hứng chịu những trò nghịch ngợm của mình hồi xưa.",
                        Pages = 170,
                        CategoryId = "VHVN",
                        PublisherId = "NXBT",
                        AuthorId = "A014",
                        CreatedAt = DateTime.Parse("2020-05-19 22:14:00"),
                        UpdatedAt = DateTime.Parse("2020-10-19 02:20:00")
                    },
                    new Book
                    {
                        Id = "S024",
                        Name = "Mắt Biếc",
                        Slug = "mat-biec",
                        Price = 54000,
                        PublicationMonth = 7,
                        PublicationYear = 2019,
                        Description = "Mắt biếc là một tác phẩm được nhiều người bình chọn là hay nhất của nhà văn Nguyễn Nhật Ánh. Tác phẩm này cũng đã được dịch giả Kato Sakae dịch sang tiếng Nhật để giới thiệu với độc giả Nhật Bản. <br>		    		“Tôi gửi tình yêu cho mùa hè, nhưng mùa hè không giữ nổi. Mùa hè chỉ biết ra hoa, phượng đỏ sân trường và tiếng ve nỉ non trong lá. Mùa hè ngây ngô, giống như tôi vậy. Nó chẳng làm được những điều tôi ký thác. Nó để Hà Lan đốt tôi, đốt rụi. Trái tim tôi cháy thành tro, rơi vãi trên đường về.”<br>		    		… Bởi sự trong sáng của một tình cảm, bởi cái kết thúc buồn, rất buồn khi xuyên suốt câu chuyện vẫn là những điều vui, buồn lẫn lộn …  <br>		    		 ",
                        Pages = 300,
                        CategoryId = "VHVN",
                        PublisherId = "NXBT",
                        AuthorId = "A014",
                        CreatedAt = DateTime.Parse("2020-05-19 22:14:00"),
                        UpdatedAt = DateTime.Parse("2020-10-19 02:20:00")
                    },
                    new Book
                    {
                        Id = "S025",
                        Name = "Gáy Người Thì Lạnh",
                        Slug = "gay-nguoi-thi-lanh",
                        Price = 36000,
                        PublicationMonth = 3,
                        PublicationYear = 2017,
                        Description = "Bạn định vị trên điện thoại rằng nhà bạn gần một trung tâm dưỡng lão, cứ tới đó đi, bạn sẽ đứng chờ. Xe ôm thả tôi xuống chỗ buồn hiu đó cả buổi, tôi lựng khựng tìm hoài mà không thấy ông già lòng khòng xương xẩu đâu. Và khi tha thẩn ở cuối đường tôi bỗng nhớ mình đã qua đây, đã đi về phía con hẻm vuông góc với chỗ tôi đang đứng, chui vào căn nhà tuềnh toàng của bạn, mười năm trước.<br>		    		Tôi hôm ấy run rẩy như con mèo ốm o bị ướt, khi tới nhà ông “Đồng gió”, “Nhớ khói” mà tôi đã ngưỡng mộ lâu rồi. Để lần đầu tiên biết nhà văn cũng có hai mắt một mũi như mọi người, cũng hài hước, cũng lơ tơ mơ, cũng nghèo…<br>		    		Cái hồi ức mười năm làm tôi hơi hoảng, mười năm qua tôi đã đi tới đâu, tận những chân trời nào, sao không thăm lại ? Tôi loay hoay với câu hỏi đó khi ngồi chơi với vợ bạn, để đợi bạn đang vẫn còn ngóng đón tôi đâu đó ngoài đầu hẻm. Đến sắp gặp nhau rồi mà lẻ vẫn đuổi theo vẫn so le, trục trặc. Nối lại loay hoay như thể đã bị đứt lìa lâu quá…<br>		    		Trong nhóm bạn già mà tôi hay lân la, bạn trẻ nhất. Mỗi lần gọi điện cho bạn, và nghe bên kia hịch hạc bảo, “ê nói nghe nè…”, như hai đứa trẻ con thầm thì, như bạn không cách tôi hai mươi lăm tuổi đời và hai trăm cây số.<br>		    		“Ê nói nghe nè, mầy viết ác vừa vừa thôi, tao không chịu…”<br>		    		“Ê nói nghe nè, có cái truyện trên Văn nghệ được lắm, sao không đọc ?”<br>		    		Tôi không mảy may nghi ngờ việc bạn sẽ còn rầy rà tôi đến vài ba chục năm nữa, dù nhiều lần bạn nói bâng quơ “ê nói nghe nè dạo này sao tao nghĩ nhiều về cái chết, làm như đã đi gần tới nó nên ngửi được mùi thấy mờ mờ dung nhan nó rồi”. Tôi nghe có chút dửng dưng, chuyện đó thường thôi, thậm chí đôi khi tôi còn rờ đụng nó mà. Bỗng có bữa đầu dây bên kia bỗng rã rời, “ê nói nghe nè, tự dưng tao thấy đời buồn hiu, mậy…”.<br>		    		Tôi ngớ ra trong giây lát, bởi chưa từng nghĩ bạn cũng buồn. Hồi biết bạn tới giờ lúc nào cũng gặp nhau giữa bạn bầy đông đúc, trong tôi mặc định bạn là con người của hội hè, tạo ra hội hè. Cứ cất tiếng “ê nói nghe nè, làm vài ly đi…” thì ai nấy hồ hởi đáp lời ngay. Cái chất hào sảng, chịu chơi của dân miền Tây mà phải chịu nỗi một mình thì vô lý.<br>		    		Nhưng giờ quanh bạn thưa đi những tiếng vọng. Những cuộc rượu nếu có chảy về phía ông, cũng bằng một hình thức khác. Nhiều khi nhậu nhẹt bọn tôi đã lấy bạn ra làm mồi cho đỡ lạt miệng. Bọn tôi nhắc chuyện bạn thấy đồng nghiệp bị vợ bạc đãi nên bất bình nhảy ra bênh, ngoay đầu đánh chị kia cho chừa ai ngờ ông chồng nổ xung thiên cự lại “sao mầy đánh vợ tao ?”. Hay chuyện hết tú tài bạn định đi vào cứ theo cách mạng, ngồi chờ tàu đò lâu quá tự dưng thấy… nản, bạn quay về bị chính quyền Sài Gòn bắt lính, ngót bốn năm làm anh binh sĩ ngồi bàn giấy, một bữa pháo lạc bầy tiễn về nhà với gương mặt có vết sẹo dài. Hay chuyện bạn giấu tiền dưới mấy cục gạch tàu lót nền, định xài riêng mà quên biệt, chừng xây lại nhà người ta thấy tiền rải đầy dưới đó. Hay chuyện bạn buồn ngủ quá mà tiếc cảnh vật đường xa nên bôi dầu gió vào mắt cho chúng đừng ríu lại. Hoặc chuyện bạn bỏ quên cái mắt kính trong phòng vệ sinh nữ, hồi đại hội.<br>		    		Những câu chuyện ngộ nghĩnh ba hư bảy thực về bạn làm bữa rượu bỗng ngon hơn với những tràng cười nghiêng ngã, cười đến chảy nước mắt ra… Ôi ôi ông ơi bọn tôi vui quá. Sau phút giây ràn rụa ấy, bỗng ràn rụa trong tôi cái ý nghĩ ở trong một cái nhà nhỏ bừa bộn chật chội nằm trên hẻm nhỏ giữa lòng thành phố Long Xuyên, biết đâu chủ nhân của những huyền thoại đang uống rượu một mình.<br>		    		Tôi vẫn hay thấy tuổi già của mình khi soi vào bạn. Bỗng trái tính trái nết, bỗng bạn bè đâu hết, thấy lẻ cả ở trong nhà mình. Đau đáu nỗi đời không biết nói với ai nên sà vào cuộc vui nào cũng tuôn cho đã cơn thèm, nào văn chương nào tôn giáo, nào cái ác nhiễu nhương… Xưa góp vui người ta gọi mời, giờ góp ưu phiền người ta ngại rủ lại chơi, thành ra bị bỏ rơi, thành ra bọn tôi cứ luẩn quẩn đi theo cái vòng cô đơn vô tận.<br>		    		Hết duyên rồi. Như chữ bạn vẫn thường dùng khi nói về cô bạn thân hồi trước. Phụ bạc luôn len lỏi trong máu của mỗi người. Và những cuộc bỏ rơi nhau vẫn đang xảy ra ở đâu đó.<br>		    		Từ ngày biết bạn cũng hay buồn, chập chờn mãi trong tôi hình ảnh một ông già mở ti vi cho nó oang oang và ngồi uống rượu một mình. Tới nhà chơi bỗng thấy may là bạn còn có sách ở bên, quơ tay đâu cũng đụng, mắt ngó đâu cũng thấy, chân đi đâu cũng vấp. Bạn vẫn ham, vẫn như đói ngấu mỗi khi gặp bất cứ cuốn sách nào. Tôi không còn thấy xa xót bồn chồn. Mang theo cuốn tản văn của Sandor Marai đọc lúc dọc đường, tôi để lại cho bạn. Cuốn sách này sẽ ở mãi đây, ngay cả khi tôi đã quay lưng đi khỏi.<br>		    		Một cuốn sách thì cả khi chìa gáy ra, người ta cũng nhận được một cái gì đó ấm áp, trao gửi.",
                        Pages = 200,
                        CategoryId = "VHVN",
                        PublisherId = "NXBT",
                        AuthorId = "A015",
                        CreatedAt = DateTime.Parse("2020-05-19 23:22:00"),
                        UpdatedAt = DateTime.Parse("2020-10-19 02:20:00")
                    },
                    new Book
                    {
                        Id = "S026",
                        Name = "Hành Lý Hư Vô",
                        Slug = "hanh-ly-hu-vo",
                        Price = 38000,
                        PublicationMonth = 5,
                        PublicationYear = 2019,
                        Description = "Hành lý hư vô.<br>		    	Đó là thứ duy nhất có thể mang theo.<br>		    	Vào đúng khi bạn nhận ra có bao nhiêu đồ đạc cũng chẳng lấp nổi biển trong lòng.<br>		    	Vào đúng khi bạn có quá nhiều thứ để nhìn nhận lại trước và trong những cuộc chia tay.<br>		    	Vào đúng khi bạn hiểu cách những mối quan hệ biến dạng sau mỗi cuộc chuyển dời, nhất là giữa người với người.<br>		    	Vào đúng khi bạn biết là mình có thể buông, nhẹ không.<br>		    	Hành lý hư vô là tập tản văn mới nhất của nhà văn Nguyễn Ngọc Tư. Đọc nó, người ta khó lòng ngăn cản được nỗi buồn, mà cũng không muốn ngăn cản nỗi buồn bởi cuối dòng chảy cảm xúc ấy là sự đồng cảm, hy vọng và cả dỗ dành.<br>		    	Một tập tản văn đẹp, hiền, mộc mạc và sâu lắng chứa đựng tấm lòng của người viết.",
                        Pages = 164,
                        CategoryId = "VHVN",
                        PublisherId = "NXBT",
                        AuthorId = "A015",
                        CreatedAt = DateTime.Parse("2020-05-19 23:22:00"),
                        UpdatedAt = DateTime.Parse("2020-10-19 02:21:00")
                    },
                    new Book
                    {
                        Id = "S027",
                        Name = "Không Ai Qua Sông",
                        Slug = "khong-ai-qua-song",
                        Price = 55000,
                        PublicationMonth = 1,
                        PublicationYear = 2016,
                        Description = "Không ai qua sông - Tập truyện ngắn mới nhất của Nguyễn Ngọc Tư gợi bạn đọc nhớ đến đến truyện dài Cánh đồng bất tận đã từng gây xôn xao trên văn đàn một thời gian dài. Cũng lấy cảm hứng từ cuộc sống của người dân nông thôn miền Tây, nhưng giờ đây nhân vật của NNT có cái trăn trở của một vùng đất đã dần bị đô thị hóa, con người phải thích ứng với những thứ nhân danh cuộc sống hiện đại nhưng có thể phá nát những rường mối gia đình.<br>		    		Đặc biệt, truyện vừa Đất dữ dội và khốc liệt, ngồn ngộn hiện thực cuộc sống, có mất mát, có phản bội, có đắng",
                        Pages = 160,
                        CategoryId = "TD-KNS",
                        PublisherId = "NXBT",
                        AuthorId = "A015",
                        CreatedAt = DateTime.Parse("2020-05-19 23:40:00"),
                        UpdatedAt = DateTime.Parse("2020-10-19 02:21:00")
                    },
                    new Book
                    {
                        Id = "S028",
                        Name = "Đong Tấm Lòng",
                        Slug = "dong-tam-long",
                        Price = 64000,
                        PublicationMonth = 4,
                        PublicationYear = 2019,
                        Description = "Tập tản văn mới của Nguyễn Ngọc Tư gửi gắm vui buồn, âu lo không chỉ về thân phận người nông dân miền Tây, mà còn về bản sắc văn hóa, lịch sử, cội nguồn một vùng đất<br>		    		Nguyễn Ngọc Tư luôn là một cây bút chắc tay khi viết về con người, đời sống sinh hoạt miệt vườn. Chị tận dụng triệt để tâm hồn nhạy cảm vốn có cùng cơ hội được đắm mình trong không gian miền quê để lẩy ra những câu chuyện kể. Cảnh sinh hoạt ấy trong trang viết Nguyễn Ngọc Tư hiện lên vừa yên tĩnh, thanh bình mà cũng vừa dậy sóng, đầy ắp những đổi thay.<br>		    		Trong bức tranh đồng quê có người già, trẻ nhỏ, có những thanh niên trai tráng, có con xóm nhỏ với rặng hoa dâm bụt, những chiếc ghe vất vả ngược xuôi mùa gió chướng, có mùa lụt nước về hay những câu chuyện ma mị dọc đường gió bụi giang hồ của miền Tây xa thẳm.<br>		    		Nhưng Nguyễn Ngọc Tư không chỉ nói về con người miền Tây sống gần với ruộng vườn, sông nước, với thiên nhiên bằng tâm hồn cởi mở, phóng khoáng, nghĩa khí, hào hiệp. Chị gần gũi với họ đủ để lẩy ra được cả những cái nhìn phản biện về tính cách nông dân. Những đặc tính của thói quen “sống hôm nay chẳng cần biết đến ngày mai”, tính “chịu chơi, xả láng” của người nông dân miệt vườn được chị phác lại với giọng văn tưởng như nhẹ nhàng nhưng ẩn trong đấy là một sự rưng rưng thương cảm. “… Người đàn bà kéo cá dưới ao lên đãi khách cho chồng, rồi bưng tô cơm nguội ăn với muối tiêu” (bài “người nơi biên giới”). Hay câu chuyện người ta bày đặt đổi vợ đổi chồng cho nhau trong “Miền Tây không có gì lạ”, bởi theo chị ở miền Tây, không có chuyện gì là không thể xảy ra.",
                        Pages = 146,
                        CategoryId = "TD-KNS",
                        PublisherId = "NXBT",
                        AuthorId = "A015",
                        CreatedAt = DateTime.Parse("2020-05-19 23:40:00"),
                        UpdatedAt = DateTime.Parse("2020-10-19 02:23:00"),
                        DeletedAt = DateTime.Parse("2020-12-02 00:00:00")
                    },
                    new Book
                    {
                        Id = "S029",
                        Name = "Việt Nam Danh Tác - Vang Bóng Một Thời",
                        Slug = "viet-nam-danh-tac-vang-bong-mot-thoi",
                        Price = 52000,
                        PublicationMonth = 5,
                        PublicationYear = 2014,
                        Description = "Văn học Việt Nam thời xưa có nhiều tác phẩm có giá trị to lớn về mặt nhân văn và nghệ thuật, đã được công nhận và chứng thực qua thời gian. Bộ sách Việt Nam danh tác bao gồm loạt tác phẩm đi cùng năm tháng như: Số đỏ (Vũ Trọng Phụng), Việc làng (Ngô Tất Tố), Gió đầu mùa, Hà Nội băm sáu phố phường (Thạch Lam), Miếng ngon Hà Nội (Vũ Bằng), Vang bóng một thời (Nguyễn Tuân). Hy vọng bộ sách sau khi tái bản sẽ giúp đông đảo tầng lớp độc giả thêm hiểu, tự hào và nâng niu kho tàng văn học nước nhà.<br>		    		Trích đoạn<br>		    		“Chùa nhà ta có cái giếng này quý lắm. Nước rất ngọt. Có lẽ tôi nghiện trà tàu vì nước giếng chùa nhà đây. Tôi sở dĩ  không đi đâu xa được là vì không đem theo được nước giếng này đi để pha trà. Bạch sư cụ, sư cụ nhớ hộ tôi câu thế này: Là giếng chùa nhà mà cạn thì tôi sẽ cho không người nào muốn xin bộ đồ trà rất quý của tôi. Chỉ có nước giếng  đây là pha trà không bao giờ lạc mất hương vị...”",
                        Pages = 212,
                        CategoryId = "VHVN",
                        PublisherId = "HNV",
                        AuthorId = "A016",
                        CreatedAt = DateTime.Parse("2020-05-20 00:58:00"),
                        UpdatedAt = DateTime.Parse("2020-10-19 02:24:00")
                    },
                    new Book
                    {
                        Id = "S030",
                        Name = "Truyện Một Cái Thuyền Đất",
                        Slug = "truyen-mot-cai-thuyen-dat",
                        Price = 18000,
                        PublicationMonth = 5,
                        PublicationYear = 2017,
                        Description = "Bên bến nước, dưới mái đình, trong ngôi làng, những người nông dân tài hoa với tình người chân thành, ấm áp. Không chỉ là chuyện kể về cuộc sống tại một ngôi làng nghề truyền thống, về những người thôn quê, về cô Sao có tài vẽ hoa lá lên đồ gốm và anh Tạ, thợ đấu đất chăm chỉ, “Truyện một cái thuyền đất” còn bồi đắp thêm cho bạn đọc tình mến thương làng quê và niềm trân trọng thành quả lao động…<br>		    		Được viết từ năm 1958 - đây là món quà đặc biệt của nhà văn Nguyễn Tuân dành tặng riêng cho bạn đọc thiếu nhi…",
                        Pages = 80,
                        CategoryId = "VHVN",
                        PublisherId = "KD",
                        AuthorId = "A016",
                        TranslatorId = "A011",
                        CreatedAt = DateTime.Parse("2020-05-20 00:58:00"),
                        UpdatedAt = DateTime.Parse("2020-10-19 02:24:00")
                    },
                    new Book
                    {
                        Id = "S031",
                        Name = "Hai Số Phận",
                        Slug = "hai-so-phan",
                        Price = 117000,
                        PublicationMonth = 1,
                        PublicationYear = 2018,
                        Description = "“Hai số phận” không chỉ đơn thuần là một cuốn tiểu thuyết, đây có thể xem là \"thánh kinh\" cho những người đọc và suy ngẫm, những ai không dễ dãi, không chấp nhận lối mòn.<br>		    		“Hai số phận” làm rung động mọi trái tim quả cảm, nó có thể làm thay đổi cả cuộc đời bạn. Đọc cuốn sách này, bạn sẽ bị chi phối bởi cá tính của hai nhân vật chính, hoặc bạn là Kane, hoặc sẽ là Abel, không thể nào nhầm lẫn. Và điều đó sẽ khiến bạn thấy được chính mình.<br>		    		Khi bạn yêu thích tác phẩm này, người ta sẽ nhìn ra cá tính và tâm hồn thú vị của bạn!<br>		    		“Nếu có giải thưởng Nobel về khả năng kể chuyện, giải thưởng đó chắc chắn sẽ thuộc về Archer.” - Daily Telegraph<br>		    		“Hai số phận” (Kane & Abel) là câu chuyện về hai người đàn ông đi tìm vinh quang. William Kane là con một triệu phú nổi tiếng trên đất Mỹ, lớn lên trong nhung lụa của thế giới thượng lưu. Wladek Koskiewicz là đứa trẻ không rõ xuất thân, được gia đình người bẫy thú nhặt về nuôi. Một người được ấn định để trở thành chủ ngân hàng khi lớn lên, người kia nhập cư vào Mỹ cùng đoàn người nghèo khổ. <br>		    		Trải qua hơn sáu mươi năm với biết bao biến động, hai con người giàu hoài bão miệt mài xây dựng vận mệnh của mình . “Hai số phận” nói về nỗi khát khao cháy bỏng, những nghĩa cử, những mối thâm thù, từng bước đường phiêu lưu, hiện thực thế giới và những góc khuất... mê hoặc người đọc bằng ngôn từ cô đọng, hai mạch truyện song song được xây dựng tinh tế từ những chi tiết nhỏ nhất.)",
                        Pages = 768,
                        CategoryId = "VHNN",
                        PublisherId = "VH",
                        AuthorId = "A020",
                        TranslatorId = "A021",
                        CreatedAt = DateTime.Parse("2020-05-20 01:09:00"),
                        UpdatedAt = DateTime.Parse("2020-10-19 02:24:00")
                    },
                    new Book
                    {
                        Id = "S032",
                        Name = "Tiếng Chim Hót Trong Bụi Mận Gai",
                        Slug = "tieng-chim-hot-trong-bui-man-gai",
                        Price = 90000,
                        PublicationMonth = 7,
                        PublicationYear = 2011,
                        Description = "Tiểu thuyết Tiếng Chim Hót Trong Bụi Mận Gai (Tái Bản) xuất bản vào mùa xuân 1977 cùng một lúc ở New York, San Francisco, London, Sydney - Ít lâu sau đã được dịch ra bảy thứ tiếng, được bạn đọc nhiệt liệt hoan nghênh và giới phê bình đánh giá cao. Suốt mấy năm là tác phẩm ăn khách nhất ở phương Tây. Đây là tác phẩm đặc sắc, có giá trị trong văn học thế giới hiện đại.<br>		    		Colleen McCulough không phải là nhà văn chuyên nghiệp, trước đó hầu như không ai biết tiếng. Khi tiểu thuyết Tiếng chim hót trong bụi mận gai đem lại vinh dự cho tác giả thì McCulough vẫn chỉ là một nhân viên y tế bình thường. Bà sinh ở Úc, bang New South Wales, trong gia đình công nhân xây dựng xuất thân từ Ireland. Thời thanh xuân McCulough ở Sydney, đã từng học trường của nhà thờ công giáo, từ bé – bà mơ ước trở thành bác sĩ, nhưng không có điều kiện để qua đại học y. Bà đã thử làm một số nghề- làm báo, công tác thư viện, dạy học rồi trở lại nghề y, qua lớp đào tạo chuyên môn về sinh lý học thần kinh. Sau đó, bà đã làm việc bà đã làm việc tại các bệnh viện ở Sydney, London, Birmingham, rồi sang Mỹ, làm việc tại một trường y thuộc trường đại học Yale. Năm 1974 bà viết cuốn tiểu thuyết đầu tiên, không có tiếng vang gì. Tiếng chim hót trong bụi mận gai được thai nghén trong ngót bốn năm, rồi đầu mùa hè 1975, bà bắt tay vào viết liền một mạch trong mười tháng. Suốt thời gian ấy, bà vẫn bận túi bụi công việc ở bệnh viện, chỉ viết tác phẩm vào ban đêm và ngày chủ nhật.<br>		    		Tác phẩm này có thể gọi là “Xaga về gia đình Cleary”. Xaga là hình thức văn xuôi cổ có tính anh hùng ca, kể chuyện một cách điềm đạm về những con người hùng dũng. Cuốn tiểu thuyết này viết về lịch sử nửa thế kỷ của ba thế hệ một gia đình lao động - gia đình Cleary. Loại tiểu thuyết lịch sử gia đình từ trước đã có những thành công như thiên sử thi vè dòng họ Foocxaitơ của Gônxuocthy, “Gia đình Tibô” của Rôgiê Mactanh duy Gar. “Gia đình Artamônôp” của M. Gorki. Đặc điểm chung của các tác phẩm đó là số phận gia đình tiêu biểu cho số phận của giaia cấp tư sản, các thế hệ sau đoạn tuyệt với truyền thống của gia đình. So sánh với những tác phẩm kể trên thì tác phẩm của McCulough có sự khác biệt, có cái độc đáo riêng của nó. Trước hết, đây là lịch sử của một gia đình lao động. Sự phát triển, tính kế thừa và đổi mới của ba thế hệ gia đình này là hình mẫu thu nhỏ của lịch sử dân tộc. Các thế hệ sau kế thừa những nét tốt đẹp nhất của gia đình - tính cần cù, tự chủ, tính kiên cường đón nhận những đòn ác liệt của số phận, lòng tự hào gia đình, song đồng thời có những đổi khác nhịp bước với thời đại. Nếu Fiona gan góc chịu đựng mọi tai họa nhưng cam chịu số phận thì con gái bà là Meggie đã tìm cách cướp lấy hạnh phúc của mình từ tay Chúa trời, và Jaxtina, con gái của Meggie là một cô gái hiện đại, có những chuẩn mực đạo đức hoàn toàn khác. Cuốn tiểu thuyết xây dựng như truyện sử biên gia đình, tác giả tập trung vào những xung đột tâm lý - đạo đức nhiều hơn là những vấn đề giai cấp - xã hội. Các nhân vật tuy vẫn chịu ảnh hưởng của hoàn cảnh, nhưng chủ yếu là ứng xử theo tính cách riêng của mình nhiều hơn. Trong số nhiều nhân vật, nổi bật hơn cả là ba nhân vật - Fiona, Meggie - con gái bà và cha đạo Ralph de Bricassart. Meggie có thể coi là nhân vật trung tâm của tác phẩm. Trong tiểu thuyết có nhiều tuyến tình tiết, nhiều môtíp, đề tài, song tất cả đều phục vụ câu chuyện chính: mối tình lớn lao trong sáng của Meggie và cha de Bricassart.<br>		    		Trong tác phẩm quy mô lớn này, những xung đột tâm lý - tinh thần của nhân vật quyện chặt với sự miêu tả tỉ mỉ toàn cảnh lịch sử, địa lý, thiên nhiên. Thiên nhiên bao la, dữ dội nhưng có cái đẹp hoang sơ riêng của nó như hiện ra trước mắt bạn đọc. Giá trị nhận thức của tác phẩm do đó càng thêm đầy đủ. Mối quan hệ giữa thiên nhiên và con người ở đây mang tính chất chung sống hài hòa, thiên nhiên chưa bị uy hiếp đến nguy cơ hủy diệt.<br>		    		Tính hiện thực và lãng mạn trong tác phẩm này hòa lẫn vào nhau tới mức nhuần nhị. Sự miêu tả tỉ mỉ bằng hình thức của bản thân đời sống, cả từ cách ăn mặc, lời ăn tiếng nói của nhân vật, cho đến cách xén lông cừu, nếp sống hàng ngày..., lối kể chuyện thong thả theo trình tự thời gian khiến cho tác phẩm gần với loại tiểu thuyết hiện thực thế kỷ 19. Nhưng những tính cách phi thường rực rỡ biểu hiện trong những biến cố đột ngột, đầy hấp dẫn tạo nên màu sắc lãng mạn rất rõ nét. Môt tác phẩm văn học Mỹ thời nay xa lạ với những cảnh hung bạo, với “sex”, với “phản nhân vật” đưa bạn đọc trở về với những vấn đề “nhà” (theo nghĩa quê hương), “cội nguồn”, “cha và con” mà lại được ham chuộng như thế ở phương Tây thì đó chứng tỏ những vấn đề muôn thuở của nhân loại bao giờ cũng làm rung động lòng người ở bất cứ nơi nào trên hành tinh chúng ta.",
                        Pages = 704,
                        CategoryId = "VHNN",
                        PublisherId = "VH",
                        AuthorId = "A018",
                        CreatedAt = DateTime.Parse("2020-05-20 01:09:00"),
                        UpdatedAt = DateTime.Parse("2020-10-21 12:15:00")
                    },
                    new Book
                    {
                        Id = "S033",
                        Name = "Kiêu Hãnh Và Định Kiến",
                        Slug = "kieu-hanh-va-dinh-kien",
                        Price = 61000,
                        PublicationMonth = 2,
                        PublicationYear = 2017,
                        Description = "Khắp làng trên xóm dưới Herfordshire xôn xao: Netherfield sắp có người thuê, mà còn là một quý ông chưa vợ với khoản lợi tức lên đến năm nghìn bảng mỗi năm. Chao ôi, quả là tin đáng mừng đối với gia đình ông bà Bennett, vốn có tới năm cô con gái cần phải gả chồng. Giữa những quay cuồng vũ hội cùng âm mưu toan tính của cả một xã hội ganh đua nhau tìm tấm chồng tốt cho các cô gái, nổi lên câu chuyện tình của cô con gái thứ cứng đầu Elizabeth và chàng quý tộc Darcy - nơi lòng Kiêu hãnh phải nhún nhường và Định kiến cần giải tỏa để có thể đi đến kết cục hoàn toàn viên mãn.<br>		    		Suốt hơn 200 năm qua, Kiêu hãnh và Định kiến luôn nằm trong số những tiểu thuyết tiếng Anh được yêu mến nhất. Chính Jane Austen cũng coi tác phẩm xuất sắc này là \"đứa con cưng\" của bà. Tài năng của Austen quả thực đã biến câu chuyện tình sôi nổi nơi miền quê nước Anh thành một bản châm biếm sắc sảo hóm hỉnh và một viên ngọc quý trong kho tàng Anh ngữ.",
                        Pages = 352,
                        CategoryId = "VHNN",
                        PublisherId = "HNV",
                        AuthorId = "A017",
                        CreatedAt = DateTime.Parse("2020-05-20 01:09:00"),
                        UpdatedAt = DateTime.Parse("2020-10-19 02:25:00")
                    },
                    new Book
                    {
                        Id = "S034",
                        Name = "Những Người Khốn Khổ",
                        Slug = "nhung-nguoi-khon-kho",
                        Price = 277000,
                        PublicationMonth = 6,
                        PublicationYear = 2016,
                        Description = "\"Khi pháp luật và phong hóa còn đày đọa con người, còn dựng nên những địa ngục giữa xã hội văn minh và đem một thứ định mệnh nhân tạo chồng thêm lên thiên mệnh; khi ba vấn đề lớn của thời đại là sự sa đọa của đàn ông vì bán sức lao động, sự trụy lạc của đàn bà vì đói khát, sự cằn cỗi của trẻ nhỏ vì tối tăm, chưa được giải quyết; khi ở một số nơi đời sống còn ngạt thở; nói khác đi, và trên quan điểm rộng hơn, khi trên mặt đất, dốt nát và đói khổ còn tồn tại, thì những cuốn sách như loại này còn có thể có ích.”<br>		    		(Hauteville House, ngày 1-1-1862- Victor Hugo)",
                        CategoryId = "VHNN",
                        PublisherId = "VH",
                        AuthorId = "A019",
                        CreatedAt = DateTime.Parse("2020-05-20 01:09:00"),
                        UpdatedAt = DateTime.Parse("2020-10-19 02:25:00")
                    },
                    new Book
                    {
                        Id = "S035",
                        Name = "Sự Im Lặng Của Bầy Cừu",
                        Slug = "su-im-lang-cua-bay-cuu",
                        Price = 90000,
                        PublicationMonth = 3,
                        PublicationYear = 2014,
                        Description = "Nội dung truyện trinh thám sự im lặng của bầy cừu kể về vụ án giết người hàng loạt xảy ra nhưng không để lại dấu vết. Điều kỳ lạ là Lecter - một bác sĩ tâm lý bị tâm thần đang điều trị tại Dưỡng Trí Viện biết rất rõ về hành vi của kẻ sát nhân nhưng chỉ im lặng. Cho đến khi con gái của thượng nghị sĩ bị bắt cóc thì cuộc đối đầu của nữ nhân viên thực tập FBI và vị bác sĩ tâm thần đã đến cực điểm. Cuối cùng tất cả cũng đều lộ diên, thủ phạm là một tên có nhân cách bệnh hoạn, một kẻ tâm thần rối loạn cựu kỳ nguy hiểm…<br>		    		Những cuộc phỏng vấn ở xà lim với kẻ ăn thịt người ham thích trò đùa trí tuệ, những tiết lộ nửa chừng hắn chỉ dành cho kẻ nào thông minh, những cái nhìn xuyên thấu thân phận và suy tư của cô mà đôi khi cô muốn lảng tránh... Clarice Starling đã dấn thân vào cuộc điều tra án giết người lột da hàng loạt như thế, để rồi trong tiếng bức bối của chiếc đồng hồ đếm ngược về cái chết, cô phải vật lộn để chấm dứt tiếng kêu bao lâu nay vẫn đeo đẳng giấc mơ mình: tiếng kêu của bầy cừu sắp bị đem đi giết thịt.<br>		    		Xem review sách: Sách sự im lặng của bầy cừu – cuốn tiểu thuyết trinh thám kinh dị đầy hấp dẫn<br>		    		Cuốn tiểu thuyết trinh thám này từng được chuyển thể thành phim và đoạt 5 giải Oscar. Sự im lặng của bầy cừu hội tụ đầy đủ những yếu tố làm nên một cuốn tiểu thuyết trinh thám kinh dị xuất sắc nhất: không một dấu vết lúng túng trong những chi tiết thuộc lĩnh vực chuyên môn, với các tình tiết giật gân, cái chết luôn lơ lửng, với cuộc so găng của những bộ óc lớn mà không có chỗ cho kẻ ngu ngốc để cuộc chơi trí tuệ trở nên dễ dàng. Bồi đắp vào cốt truyện lôi cuốn đó là cơ hội được trải nghiệm trong trí não của cả kẻ gây tội lẫn kẻ thi hành công lý, khi mỗi bên phải vật vã trong ngục tù của đau đớn để tìm kiếm, khẩn thiết và liên tục, một sự lắng dịu cho tâm hồn.<br>		    		Cuốn sách này của Thomas Harris đạt tốp 1 của 100 truyện trinh thám – kinh dị hay nhất mọi thời do trang điện tử NPR tổ chức, thu hút hơn 17.000 lượt độc giả. Danh sách top 100 được lựa chọn ra từ 600 đề cử của các chuyên gia, cố vấn văn học hàng đầu.<br>		    		Sự im lặng của bầy cừu là cuốn sách có thể khiến độc giả hồi hộp đến nghẹt thở.<br>		    		Nhận định<br>		    		“...xây dựng tình tiết đẹp với lối viết thông tuệ. Không tác phẩm kinh dị nào vượt được cuốn này.”- Clive Barker<br>		    		“Một cuốn sách giáo khoa đúng nghĩa về nghệ thuật viết truyện kinh dị, một kiệt tác chứa xung lực đưa nó lao vụt lên đỉnh cao không một khiếm khuyết... Harris đơn giản chính là tiểu thuyết gia kinh dị xuất sắc nhất thời nay.”- The Washington Post<br>		    		“Tiết điệu dồn dập... đánh thức sự tò mò... lôi cuốn.”- Chicago Tribune",
                        Pages = 347,
                        CategoryId = "TD-KNS",
                        PublisherId = "HNV",
                        AuthorId = "A024",
                        CreatedAt = DateTime.Parse("2020-05-20 01:26:00"),
                        UpdatedAt = DateTime.Parse("2020-10-21 08:31:00")
                    },
                    new Book
                    {
                        Id = "S036",
                        Name = "Đề Thi Đẫm Máu",
                        Slug = "de-thi-dam-mau",
                        Price = 96000,
                        PublicationMonth = 12,
                        PublicationYear = 2014,
                        Description = "Một tên sát thủ có sở thích uống chất hỗn hợp máu nạn nhân với sữa tươi, hắn có căn bệnh gì đặc biệt hay là con quỷ hút máu bất tử nghìn năm trong truyền thuyết?<br>		    		Trong thành phố C liên tiếp xảy ra 4 vụ cưỡng hiếp giết người, nạn nhân đều là những cô gái trí thức từ 25 - 35 tuổi, đây rốt cuộc là giết người trả thù hay đơn giản là cưỡng dâm?<br>		    		Hàng loạt cái chết bí ẩn thảm khốc của những người sống trong trường Đại học J liên tiếp xảy ra. Ở hiện trường vụ án, hung thủ đều để lại gợi ý cho vụ án tiếp theo, nhằm gợi ý gì?<br>		    		Trong hàng loạt các vụ án ly kỳ khiến cảnh sát bàng hoàng bó tay, Phương Mộc trầm mặc kiệm lời đột nhiên bị cảnh sát lôi vào cuộc. Tên ác quỷ giấu mặt lần lượt giết hại những người bạn của cậu, vì sao? Khi câu trả lời được vén màn bí mật, thì đề thi tàn khốc đã bị tích 5 dấu X đẫm máu.<br>		    		Một cuộc đấu trí so tài khốc liệt đầy kịch tính nổ Ai sẽ là người thắng cuộc?<br>		    		Đây là tác phẩm trinh thám được nhiều người biết đến nhất của Lôi Mễ - sĩ quan cảnh sát cấp phòng (sở) giảng dạy bộ môn Hình pháp học tại một trường cảnh sát trực thuộc Bộ Công an Trung Quốc, đồng thời cũng là một tác giả truyện trinh thám nổi tiếng. Truyện của Lôi Mễ luôn có sức hấp dẫn đặc biệt đối với độc giả bởi ngòi bút sắt bén với những tình tiết ly kì, lôi cuốn đến trang cuối cùng.",
                        Pages = 537,
                        CategoryId = "VHNN",
                        PublisherId = "VH",
                        AuthorId = "A025",
                        TranslatorId = "A026",
                        CreatedAt = DateTime.Parse("2020-05-20 01:26:00"),
                        UpdatedAt = DateTime.Parse("2020-10-19 02:25:00")
                    },
                    new Book
                    {
                        Id = "S037",
                        Name = "Những Vụ Kỳ Án Của Sherlock Holmes",
                        Slug = "nhung-vu-ky-an-cua-sherlock-holmes",
                        Price = 77000,
                        PublicationMonth = 6,
                        PublicationYear = 2015,
                        Description = "Sherlock Holmes là tiểu thuyết của Sir Arthur Conan Doyle lần đầu xuất hiện vào năm 1887 trong cuốn tiểu thuyết trinh thám “A Study in Scarlet”. Từ đó, nhà văn Anh đã viết 4 tiểu thuyết và 55 truyện ngắn về Holmes. Qua hàng thế kỷ, vị thám tử đã trở thành một biểu tượng văn hóa và là nguồn cảm hứng của rất nhiều cây bút khác. Cuốn “Mary Russell” nổi tiếng của Laurie King từng tái hiện cuộc sống của Holmes sau khi “về hưu”.<br>		    		Những Vụ Kỳ Án Của Sherlock Holmes đưa chúng ta sống cùng những vụ án ly kỳ, hóc búa, biến hoá vô cùng, và cũng lắm dữ dội, hiểm nguy, mà ở đó ông thể hiện tài ba phá án phi phàm của mình. Cuốn sách cuốn hút các bạn trẻ còn bởi lối kể chuyện nhẹ nhàng, nhưng bí hiểm và vô cùng thông minh. Và hơn thế nữa, còn nhiều THÍ DỤ TRẮC NGHIỆM, vừa giúp hiểu rõ hơn, khám phá lý thú hơn các vụ án lừng lẫy của Sherlock Holmes, vừa tăng cường khả năng phán đoán cho độc giả.",
                        Pages = 526,
                        CategoryId = "VHNN",
                        PublisherId = "VH",
                        AuthorId = "A023",
                        CreatedAt = DateTime.Parse("2020-05-20 01:26:00"),
                        UpdatedAt = DateTime.Parse("2020-10-21 08:25:00")
                    },
                    new Book
                    {
                        Id = "S038",
                        Name = "Những Giấc Mơ Ở Hiệu Sách Morisaki",
                        Slug = "nhung-giac-mo-o-hieu-sach-morisaki",
                        Price = 39000,
                        PublicationMonth = 4,
                        PublicationYear = 2017,
                        Description = "Bị người yêu lừa dối, Takako bỏ việc và rơi vào chuỗi ngày ngủ triền miên để trốn tránh nỗi buồn. Thế rồi, một cuộc điện thoại từ người cậu ruột cả 10 năm trời không gặp đã đánh thức cô khỏi cơn mộng mị. Takako đồng ý đến trông hiệu sách nửa buổi giúp cậu chỉ để làm vừa lòng mẹ. Nhưng thật ngoài tưởng tượng, chờ đợi cô là hiệu sách Morisaki cũ kỹ với thế giới của hàng nghìn cuốn sách chứa trong mình cả thời gian và lịch sử. Sách đã chữa lành vết thương trong lòng cô.<br>		    		Và hơn thế nữa, Takako tìm thấy bao nhiêu điều mới mẻ và thú vị mà trước đây cô chưa từng biết đến.Câu chuyện nhẹ nhàng mà sâu lắng, đặc biệt với những ai có sở thích sưu tầm sách cổ.",
                        Pages = 118,
                        CategoryId = "VHNN",
                        PublisherId = "HN",
                        AuthorId = "A022",
                        CreatedAt = DateTime.Parse("2020-05-20 01:26:00"),
                        UpdatedAt = DateTime.Parse("2020-10-20 09:47:00"),
                        DeletedAt = DateTime.Parse("2020-12-02 00:00:00")
                    },
                    new Book
                    {
                        Id = "S039",
                        Name = "Hannibal",
                        Slug = "hannibal",
                        Price = 90000,
                        PublicationMonth = 5,
                        PublicationYear = 2018,
                        Description = "Được xem là một trong những sự kiện văn chương được chờ đợi nhất, Hannibal mang người đọc vào cung điện ký ức của một kẻ ăn thịt người, tạo dựng nên một bức chân dung ớn lạnh của tội ác đang âm thầm sinh sôi - một thành công của thể loại kinh dị tâm lý.<br>		    	Với Mason Verger, nạn nhân đã bị Hannibal biến thành kẻ người không ra người, Hannibal là mối hận thù nhức nhối da thịt.<br>		    	Với đặc vụ Clarice Starling của FBI, người từng thẩm vấn Hannibal trong trại tâm thần, giọng kim ken két của hắn vẫn vang vọng trong giấc mơ cô.<br>		    	Với cảnh sát Rinaldo Pazzi đang thất thế, Lecter hứa hẹn mang tới một khoản tiền béo bở để đổi vận.<br>		    	Và những cuộc săn lùng Hannibal Lecter bắt đầu, kéo theo đó là những chuỗi ngày run rẩy hòng chấm dứt bảy năm tự do của hắn. Nhưng trong ba kẻ đi săn, chỉ một kẻ có bản lĩnh sống trụ lại để hưởng thành quả của mình.",
                        Pages = 432,
                        CategoryId = "VHNN",
                        PublisherId = "HNV",
                        AuthorId = "A024",
                        TranslatorId = "A027",
                        CreatedAt = DateTime.Parse("2020-05-20 01:26:00"),
                        UpdatedAt = DateTime.Parse("2020-10-21 08:20:00")
                    },
                    new Book
                    {
                        Id = "S040",
                        Name = "Danh Tác Rút Gọn - Thế Giới Thất Lạc",
                        Slug = "danh-tac-rut-gon-the-gioi-that-lac",
                        Price = 38000,
                        PublicationMonth = 1,
                        PublicationYear = 2019,
                        Description = "Sir Arthur Conan Doyle (1859 – 1930) là một nhà văn người Scotland nổi tiếng với tiểu thuyết trinh thám Sherlock Holmes, các truyện về Giáo sư Challenger và nhiều tác phẩm khác.<br>		    	Thuộc Tủ sách Danh Tác Rút Gọn, Thế giới thất lạc xoay quanh việc giáo sư George Challenger tình cờ phát hiện được dấu tích còn sống sót của loài khủng long trong một khu rừng nguyên sinh chưa được khai phá ở Nam Mỹ. Khi trở về, ông muốn mở một cuộc hành trình vào sâu trong rừng hơn để chứng minh là một số loài khủng long vẫn còn sống. Nhiều người phản đối, nhưng cuối cùng vẫn có những người thích phiêu lưu mạo hiểm ủng hộ ông. Cuộc thám hiểm diễn ra trong khu rừng nguy hiểm chưa hề có tên trên bản đồ thế giới, và cuộc đấu tranh sinh tồn của đoàn thám hiểm bắt đầu. Họ phải chiến đấu để thoát chết và nhất là với hy vọng thoát khỏi thế giới bị lãng quên này để trở về nhà…",
                        Pages = 124,
                        CategoryId = "STN",
                        PublisherId = "NXBT",
                        AuthorId = "A023",
                        CreatedAt = DateTime.Parse("2020-05-20 01:26:00"),
                        UpdatedAt = DateTime.Parse("2020-10-19 02:37:00"),
                        DeletedAt = DateTime.Parse("2020-12-02 00:00:00")
                    },
                    new Book
                    {
                        Id = "S041",
                        Name = "Ánh Đèn Giữa Hai Đại Dương",
                        Slug = "anh-den-giua-hai-dai-duong",
                        Price = 115000,
                        PublicationMonth = 2,
                        PublicationYear = 2016,
                        Description = "Tập truyện tâm lý xã hội xoay quanh số phận con người khi đứng trước những lựa chọn éo le, nhất là khi ảnh hưởng đến những người thân yêu nhất. Cuộc đời cặp vợ chồng cô đơn canh hải đăng trên hòn đảo trơ trọi đột nhiên biến đổi khi ngày nọ chiếc thuyền dạt vào mang theo đứa bé gái còn sơ sinh.<br>		    		Nhưng liệu có công bằng không khi họ vì niềm vui riêng này mà không nỗ lực tìm kiếm cha mẹ ruột đứa bé. Cha mẹ ruột, cha mẹ nuôi, gia đình của họ, và chính cả đứa bé, mỗi người đều mang một nỗi đau riêng trong khi tưởng chừng có được hạnh phúc.",
                        Pages = 485,
                        CategoryId = "VHNN",
                        PublisherId = "NXBT",
                        AuthorId = "A032",
                        CreatedAt = DateTime.Parse("2020-05-20 01:47:00"),
                        UpdatedAt = DateTime.Parse("2020-10-19 02:37:00")
                    },
                    new Book
                    {
                        Id = "S042",
                        Name = "Lời Hồi Đáp 1994",
                        Slug = "loi-hoi-dap-1994",
                        Price = 79000,
                        PublicationMonth = 7,
                        PublicationYear = 2017,
                        Description = "Nối tiếp thành công của cuốn tiểu thuyết  “Lời hồi đáp 1997”  vừa ra mắt tháng 5 vừa qua; phần tiếp theo trong series đình đám mang tên  ““Lời hồi đáp 1994”  đã tạo nên làn sóng “ Hồi ức những năm 90” của đài truyền hình tVN chính thức tái ngộ độc giả Việt Nam dưới dạng tiểu thuyết .<br>		    		Lời hồi đáp 1994 - Tiếng gọi của những năm 90 nồng nhiệt mà ngây thơ, và nhớ thương đến nhói lòng.<br>		    		Từng trang sách lấp lánh những sắc màu quá khứ, lung linh những hồi ức về một thời thanh xuân đã qua đầy tươi đẹp của nhóm bạn trẻ những chàng trai, cô gái đến từ các tỉnh thành khác nhau của Hàn Quốc lần đầu tới Seoul để bắt đầu cuộc sống sinh viên dưới một mái nhà có một ông bố đáng yêu và một bà mẹ đáng kính. Cuốn sách sẽ khiến bạn gật gù thừa nhận rằng: từng trang sách đã gợi nhớ lại những kỷ niệm đẹp về tuổi trẻ. Với khung cảnh những năm 1990 mỗi ngày ở nhà trọ Shin Chon luôn đầy ắp những bất ngờ và thú vị, mỗi giây phút mọi người bên nhau cùng tạo nên những khoảnh khắc tươi đẹp vì cuộc sống chúng ta không thể thay đồi quá khứ, không thể biết trước ngày mai sẽ ra sao nhưng có một điều chắc chắn đó là ngay khoảnh khắc này, chúng ta có thể làm cho nó trở nên tốt đẹp hơn.<br>		    		Những tình tiết trong cuốn sách cũng khiến chúng ta thấy tim mình ấm áp nhận ra rằng: Chẳng có ai yêu thương mình bằng bố mẹ, điều khiến trái tim chúng ta rung động đó là hai chữ Gia Đình.<br>		    		<br>		    		Câu chuyện còn xoay quanh các sự kiện văn hóa nổi bật ở Hàn Quốc năm 1994, với sự xuất hiện của nhóm nhạc thần tượng đầu tiên của Kpop “Seo Taiji and Boys” và đội bóng rổ trứ danh của Đại Hàn Dân Quốc.<br>		    		Làn sóng thần tượng thời kì này không quá được chú trọng như đối với “Lời hồi đáp 1997” nhưng bạn lại bắt gặp trong đó những câu chuyện rất đời: Cuộc sống đại học ở Yonsei - một trong những trường danh giá nhất Hàn Quốc với những cô cậu tỉnh lẻ, một gia đình trung lưu bình thường mới chuyển lên Seoul mở nhà trọ, quan hệ ruột thịt, bạn bè, công việc, lý tưởng tuổi trẻ và những người đi lướt qua nhau...<br>		    		“Bầu trời. Trong mắt người này có thể là bầu trời sáng rực đầy hi vọng, nhưng đối với người khác lại chói chang đáng sợ.”<br>		    		Câu chuyện như một cuộc chơi giữa nhà văn và độc giả : Rốt cục ai mới là chồng của nữ chính Sung Na Jung? Là anh trai điển hình của nhân loại với cái tên “mỹ miều” - Rác vì chỉ mặc độc một bộ đồ thể thao trong nhiều ngày liền. Anh thực chất không phải là anh ruột của Na-Jung và tình cảm anh dành cho cô cũng không phải tình cảm anh – em thông thường. Hay người ấy là Chilbong - cầu thủ bóng chày chân thật, ngọt ngào, lặng lẽ khiến trái tim bao cô gái tan chảy nhưng rụt rè.<br>		    		“Bởi vì mình quá tốt nên mình mới thất bại. Bởi vì mình quá tốt, cho dù là người con gái mà mình thích, mình cũng không thể hỏi cô ấy cho rõ ràng.” – Chilbong.<br>		    		Mối tình đầu sẽ chiến thắng hay sẽ như Chilbong nói “ Chưa phải kết thúc cho đến khi kết thúc thực sự” và ai sẽ được cú “ home run”n đây? (Thuật ngữ bóng chày = ghi điểm trực tiếp)?<br>		    		Tất tả những tình tiết thú vị đó sẽ khiến người đọc nín thở bởi: Tình yêu đơn phương tuy thầm kín nhưng lại vô cùng mãnh liệt . Ở lứa tuổi 20,tình yêu là một cái gì đó thuần khiết,mơ hồ.Vậy nên không phải bất cứ một tuổi trẻ nào cũng có thể may mắn có được. Những cô cậu sinh viên chập chững những bước đi đầu tiên liệu có đủ dũng khí để tìm thấy ước mơ của cuộc đời mình, liệu có đủ can đảm để đến bên ai đó nắm tay. Liệu tương lai có tốt đẹp như điều ước mà họ đã cùng nhau nguyện cầu?<br>		    		“Trong tiếng Anh, từ “present” có hai nghĩa: hiện tại và món quà. Món quà quý giá nhất của cuộc sống chính là hiện tại,chính là thời khắc đang trôi qua ngay trước mắt chúng ta.”<br>		    		Nhân dịp Lời hồi đáp 1994 tái ngộ độc giả Việt, Mintbooks hân hạnh dành tặng 1 móc khóa xinh xắn cho những người đặt sách sớm nhất. Nhanh tay lên, số lượng có hạn!",
                        Pages = 128,
                        CategoryId = "VHNN",
                        PublisherId = "VH",
                        AuthorId = "A028",
                        CreatedAt = DateTime.Parse("2020-05-20 01:47:00"),
                        UpdatedAt = DateTime.Parse("2020-10-19 02:38:00")
                    },
                    new Book
                    {
                        Id = "S043",
                        Name = "Không Gia Đình",
                        Slug = "khong-gia-dinh",
                        Price = 77000,
                        PublicationMonth = 4,
                        PublicationYear = 2014,
                        Description = "Không Gia Đình là cuốn sách được xếp vào danh mục văn học thiếu nhi nhưng rõ ràng, với những gì Không Gia Đình đã kể thì đây là cuốn sách dành cho mọi lứa tuổi ở mọi quốc gia, mọi tầng lớp.<br>		    		Không Gia Đình là một chuyến phiêu lưu mà Rêmi là nhân vật chính. Em nghèo khổ, em cô độc, em không có người thân. Cuộc đời Rêmi gắn liền với gánh xiếc rong, với những thử thách mà em gặp phải trên đường đời trải rộng khắp nước Pháp tươi đẹp. Rêmi lớn lên trong đau khổ, lang thang mọi nơi, bị tù đày... nhưng dù trong hoàn cảnh nào, em vẫn đứng thẳng lưng, ngẩng cao đầu, giữ phẩm chất làm người - điều em đã học từ cụ Vitali trong cuộc đời lang bạt của mình.<br>		    		Không Gia Đình ca ngợi giá trị của lao động, của nhân cách và tình cảm. Cuốn sách mô tả những hình ảnh, những mảnh đời bấp bênh để làm nền cho niềm tin, cho tình người ấm áp.<br>		    		Không Gia Đình thực sự là một cuốn sách hay và giá trị hơn cả một giá sách dạy phương pháp làm người.<br>		    		<br>		    		Không gia đình kể chuyện một em bé không cha mẹ, không họ hàng thân thích, đi theo một đoàn xiếc chó, khỉ, rồi cầm đầu đoàn ấy đi lưu lạc khắp nước Pháp, sau đó bị tù ở Anh, cuối cùng tìm thấy mẹ và em. Em bé Rêmi ấy đã lớn lên trong gian khổ. Em đã chung đụng với mọi hạng người, sống khắp mọi nơi, \"nơi thì lừa đảo, nơi thì xót thương\". Em đã lao động mà sống, lúc đầu dưới quyền điều khiển của một ông già từng trải và đạo đức, cụ Vitali, về sau thì tự lập và không những lo cho mình, còn bảo đảm việc biểu diễn và sinh sống cho cả một gánh hát rong. Đã có khi em và cả đoàn lang thang mấy hôm liền không có chút gì trong bụng. Đã có khi em suýt chết rét. Đã có khi em bị lụt ngầm chôn trong giếng mỏ mười mấy ngày đêm. Đã có khi em mắc oan bị giải ra trước tòa và bị ở tù.<br>		    		Và cũng có khi em được nuôi nấng đàng hoàng, no ấm. Nhưng dù ở đâu, trong cảnh ngộ nào, em vẫn noi theo nếp rèn dạy của ông già Vitali giữ phẩm chất làm người, nghĩa là ngay thẳng, gan dạ, tự trọng, thương người, ham lao động, không ngửa tay xin xỏ, không dối trá, gian giảo, nhớ ơn nghĩa, luôn luôn muốn làm người có ích...",
                        Pages = 574,
                        CategoryId = "VHNN",
                        PublisherId = "VH",
                        AuthorId = "A029",
                        TranslatorId = "A031",
                        CreatedAt = DateTime.Parse("2020-05-20 01:47:00"),
                        UpdatedAt = DateTime.Parse("2020-10-19 02:38:00"),
                        DeletedAt = DateTime.Parse("2020-12-02 00:00:00")
                    },
                    new Book
                    {
                        Id = "S044",
                        Name = "Tiếng Gọi Của Hoang Dã",
                        Slug = "tieng-goi-cua-hoang-da",
                        Price = 44000,
                        PublicationMonth = 8,
                        PublicationYear = 2016,
                        Description = "Tiếng Gọi Của Hoang Dã là một tiểu thuyết nổi tiếng thế giới của nhà văn Mỹ - Jack London. Cốt truyện kể về một chú chó tên là Buck đã được thuần hóa, cưng chiều. Nhưng do một loạt các sự kiện xảy ra khi Buck bị bắt khỏi trang trại, để trở thành chó kéo xe ở khu vực Alaska lạnh giá; trong giai đoạn mọi người đổ xô đi tìm vàng thế kỷ 19, thiên nhiên nguyên thủy đã đánh thức bản năng của Buck. Buck trở lại cuộc sống hoang dã, Buck trở về rừng và sống chung với lũ sói.<br>		    		Xuất bản lần đầu năm 1903, Tiếng Gọi Của Hoang Dã là một trong những tiểu thuyết Best seller của nhà văn Jack London và được xem là tác phẩm hay nhất của ông.",
                        Pages = 226,
                        CategoryId = "VHNN",
                        PublisherId = "VH",
                        AuthorId = "A030",
                        CreatedAt = DateTime.Parse("2020-05-20 01:47:00"),
                        UpdatedAt = DateTime.Parse("2020-10-19 02:38:00")
                    },
                    new Book
                    {
                        Id = "S045",
                        Name = "Quá Trẻ Để Chết: Hành Trình Nước Mỹ",
                        Slug = "qua-tre-de-chet-hanh-trinh-nuoc-my",
                        Price = 62000,
                        PublicationMonth = 4,
                        PublicationYear = 2015,
                        Description = "Quá trẻ để chết: Hành trình nước Mỹ là hành trình đơn độc của tác giả - một cô gái Việt trẻ đi xuyên nước Mỹ từ Bờ Đông sang bờ Tây. Hành trình du lịch bụi của cô trải dài trên 20 bang, kéo dài suốt sáu tháng liên tiếp.<br>		    		Đó là chuyến đi để khám phá thế giới bên trong của những người Mỹ bình thường, dù có thể chỉ là một phần của thế giới ấy. Đó cũng là hành trình khám phá những vẻ đẹp muôn màu muôn vẻ của thế giới - của thiên nhiên nước Mỹ, và của tâm hồn con người trong những hình thức thăng hoa khác nhau của nó.<br>		    		Nhưng hành trình xuyên qua nước Mỹ này không chỉ là để khám phá một phần thế giới bên ngoài mà còn là để tìm trở lại một phần trọng yếu của bản thân cô gái: tình yêu đối với chính mình và cuộc đời mình, cái tình yêu mà cô đã có lúc đánh mất. Xuất phát điểm của “Quá trẻ để chết: Hành trình nước Mỹ” là một tình yêu tan vỡ, một nỗi đau đớn vì tình, lớn đến độ khiến tác giả có lúc đã gần kề cái chỗ đâm đầu vào tàu điện ngầm tự sát, một kết cục khiến ta không khỏi nghĩ tới Anna Karenina.<br>		    		Đinh Hằng, tác giả, xuất hiện trong cuốn sách như một phụ nữ mạnh mẽ, đầy cá tính và sức mạnh bên trong, tự tin ngẩng cao đầu bước giữa thế giới, hoàn toàn không có một mặc cảm nào bất kể căn nguyên của nó là gì.<br>		    		Chuyến đi của Đinh Hằng, rốt cuộc, là một cuộc hành trình đi tìm lại và nhìn nhận lại giá trị của bản thân mình, của sự sống. Nước Mỹ, với tất cả những vẻ đẹp cùng sự đa dạng và phức tạp của nó, ở đây đóng vai trò như một chốn “luyện ngục” để cô vượt qua chính mình và trở nên một người khác. Một cuộc đi lớn chỉ dành cho những người thực sự muốn lớn hơn bản thân mình ngày hôm qua.<br>		    		Cách Đinh Hằng đi và hòa mình vào văn hóa Mỹ không phải là cái nhìn của công dân một nước đang phát triển lần đầu đến với xứ cờ hoa, choáng ngợp với nước Mỹ to lớn hiện đại và thấy mình sao mà nhỏ bé đơn độc. Ngược lại, đó là cái nhìn của một người lữ hành đã dày dạn kinh nghiệm, nhìn một xứ sở mới, những con người mới với cái nhìn bình đẳng, điềm nhiên và không định kiến. Đinh Hằng xem nước Mỹ và người Mỹ với tâm thế tôn trọng và bình đẳng, như một kẻ biết người rất giỏi nhưng cũng hiểu rõ những giá trị của bản thân.<br>		    		Cũng chính vì vậy mà nước Mỹ và người Mỹ hiện ra trong sách rất thực và rất đời, không tô hồng, không phóng đại. Một nước Mỹ không chỉ với các tòa nhà chọc trời, với sự phát triển vượt bậc và các công nghệ hiện đại. Mà là một nước Mỹ chân thực và trần trụi với những vấn đề của nó, nền văn hóa Mỹ, cách sống của người Mỹ, quan niệm của họ về bản thân, về tình yêu, và kể cả những vấn đề khá nhạy cảm với người Việt như tình một đêm, đồng tính, cỏ và ma túy...<br>		    		Quá trẻ để chết: Hành trình nước Mỹ không đơn thuần là một cuốn sách du ký. Bởi trên hành trình đơn độc xuyên qua nước Mỹ, những xung đột tâm lý của cô gái bị bỏ lại trước ngưỡng cửa hôn nhân cũng hiện lên sâu sắc. Đó là câu chuyện của sự đan xen mãnh liệt những cô đơn, đau đớn, niềm tin, khát vọng, đam mê, tuổi trẻ. Cô gái nhân vật chính dám nghỉ việc, trả nhà, bay nửa vòng Trái Đất và quăng mình vào một hành trình không đích đến để đối mặt với người mình đã từng yêu một lần nữa. Hành trình địa lý cũng chính là hành trình tâm lý ấy đánh thức trong mỗi người trẻ tuổi bản năng yêu, đi và sống hết mình.<br>		    		Xem review sách: Quá trẻ để chết – Hành trình nước Mỹ<br>		    		Nhận định<br>		    		\"...Tuổi trẻ luôn là một lợi thế và những lí do để dẫn đến một chuyến đi, nhất là đối với một người phụ nữ đi một mình thì chắc chắn là rất nhiều. Một cuộc tình đổ vỡ, một biến cố khác nào đó trong đời thôi thúc những phụ nữ như thế lên đường và sự đơn độc tạo cho họ sức mạnh để hướng về phía trước, trong một hành trình chất chứa nhiều tâm sự.<br>		    		Nước Mỹ hiện ra một cách dung dị và cả gai góc qua những câu chữ của Đinh Hằng, trong hành trình \"Couch Surfing\". Những hành trình lớn cần những trái tim dũng cảm. Không chỉ dũng cảm đương đầu với những rủi ro có thể ập đến, mà dũng cảm khi biết cách đối diện với chính mình.<br>		    		(Trương Anh Ngọc, tác giả \"Nước Ý, câu chuyện tình của tôi\"  và \"Phút 90++\")<br>		    		\"Khó mà hình dung Đinh Hằng là cô như bây giờ nếu cô đã không đủ can đảm thực hiện chuyến đi ấy và sẵn sàng đối mặt với những gì chưa biết đang chờ đợi phía trước. Một cuộc đi lớn chỉ dành cho những người thực sự muốn lớn hơn bản thân mình ngày hôm qua.\"<br>		    		(Trần Tiễn Cao Đăng, nhà văn, dịch giả)<br>		    		\"Quá trẻ để chết: hành trình nước Mỹ\" là câu chuyện về tuổi trẻ lộng lẫy, đầy đam mê và dám sống. Bởi, khi còn trẻ, người ta có rất nhiều thời gian và cơ hội để sống, thử, sai lầm, học hỏi và lớn lên từ sai lầm đó. Đây là cuốn sách nên đọc nếu bạn còn trẻ, đam mê những con đường và trước bao nhiêu sóng gió cuộc đời bạn vẫn ngẩng cao đầu tiến về phía trước.<br>		    		(Nguyễn Lê My Hoàn, nhà văn, dịch giả, tác giả “Lối đi ngay dưới chân mình\")",
                        CategoryId = "VHVN",
                        PublisherId = "HNV",
                        AuthorId = "A033",
                        CreatedAt = DateTime.Parse("2020-05-20 01:47:00"),
                        UpdatedAt = DateTime.Parse("2020-10-19 02:38:00")
                    },
                    new Book
                    {
                        Id = "S046",
                        Name = "Nghĩ Như Một Tỷ Phú",
                        Slug = "nghi-nhu-mot-ty-phu",
                        Price = 54000,
                        PublicationMonth = 6,
                        PublicationYear = 2011,
                        Description = "Sách là tự truyện của một tỷ phú bất động sản Mỹ - Donald J.Trump. Ông còn là ông trùm của một số chương trình truyền hình thu hút và là tác giả của vài quyển sách best-seller.<br>		    		Tác giả cho người đọc thấy được cách nghĩ của một tỷ phú về tiền bạc, cuộc sống, sự nghiệp và cuộc sống. Bạn sẽ tìm thấy lời khuyên giá trị về đầu tư bất động sản, từ đánh giá bất động sản đến việc mua, bán và tái đầu tư. Bên cạnh đó, ông cũng chỉ cho bạn cách gây ấn tượng với mọi người, cách \"chỉnh\" và phê bình người khác, cách để hiểu bạn bè... tất cả mọi thứ bạn cần để tiến về phía trước.<br>		    		Rất có thể những kinh nghiệm ông có được khá xa với bạn nhhưng chắc chắn cuốn sách sẽ là nguồn cảm hứng vô cùng giá trị với bạn, để bạn có thể giàu có và thành công. Hy vọng bạn sẽ đạt được điều tác giả nói:\" Cho dù bạn chỉ hấp thụ được 10% những hướng dẫn trong cuốn sách này, bạn cũng sẽ có cơ hội tốt để trở thành triệu phú.\"",
                        Pages = 254,
                        CategoryId = "KT",
                        PublisherId = "NXBT",
                        AuthorId = "A034",
                        CreatedAt = DateTime.Parse("2020-05-20 01:55:00"),
                        UpdatedAt = DateTime.Parse("2020-10-21 12:05:00")
                    },
                    new Book
                    {
                        Id = "S047",
                        Name = "Tôi Đã Làm Giàu Như Thế",
                        Slug = "toi-da-lam-giau-nhu-the",
                        Price = 65000,
                        PublicationMonth = 1,
                        PublicationYear = 2017,
                        Description = "Tài sản của tổ chức The Trump Organization đã có mặt trên khắp nước Mỹ và nhiều quốc gia trên thế giới. Chủ nhân của những toà cao ốc, biệt thự, khách sạn - sòng bạc lộng lẫy, nguy nga này là nhà tỷ phú Donald J. Trump - người đã viết cuốn The Art of the Deal (Nghệ thuật đàm phán trong kinh doanh), đó là ấn phẩm bán chạy nhất trong ngành kinh doanh sách thập niên 80 của thế kỷ XX...<br>		    		Phương châm của Donald là: “Nếu bạn không nói cho mọi người biết về sự thành công của bạn thì người ta sẽ không hề biết gì về nó đâu”, chính vì vậy cuốn sách Tôi đã làm giàu như thế ra đời, chỉ vì theo chính lời tác giả: “Có ít nhất năm tỉ lý do khiến bạn phải đọc quyển sách này”. Vắn tắt, nhanh gọn và trực tiếp, những câu chuyện và những lời khôn ngoan được chắt lọc trong suốt ba mươi năm của người luôn đứng đầu của sự thành công sẽ cho bạn những lời khuyên sâu sắc.<br>		    		Hãy nghe theo lòng mình nếu bạn muốn có một sự thay đổi kỳ diệu, kinh nghiệm của một tỉ phú sẽ rất có ích cho bạn.<br>		    		Có ít nhất năm tỷ lý do khiến bạn phải đọc quyển sách này.",
                        Pages = 280,
                        CategoryId = "KT",
                        PublisherId = "NXBT",
                        AuthorId = "A034",
                        CreatedAt = DateTime.Parse("2020-05-20 01:58:00"),
                        UpdatedAt = DateTime.Parse("2020-10-19 02:39:00")
                    },
                    new Book
                    {
                        Id = "S048",
                        Name = "Search Inside Yourself",
                        Slug = "search-inside-yourself",
                        Price = 77000,
                        PublicationMonth = 10,
                        PublicationYear = 2019,
                        Description = "Tất cả chúng ta đều biết công cụ tìm kiếm Google và công ty Google với văn hóa doanh nghiệp tuyệt vời nổi tiếng khắp thế giới, nhưng liệu có bao nhiêu người trong số chúng ta biết được điều gì đã làm nên nền tảng cho sự nổi tiếng đó? Chade-Meng Tan – tác giả cuốn sách Search Inside Yourself sẽ giải thích cho bạn bí mật đó.<br>		    		Mỗi năm, có đến hàng nghìn kĩ sư Google tham gia một trong 12 khóa đào tạo về thiền để tăng cường khả năng “cân bằng nhận thức” về những gì đang diễn ra xung quanh. Khóa học nổi tiếng nhất – mang tên “Search inside yourself” (Tìm kiếm bên trong bạn) – luôn là khóa học được trông đợi nhất và thu hút nhiều người tham gia nhất với danh sách học viên chờ tham dự dài đến sáu tháng. Khóa học do Chade-Meng Tan khởi sướng, ông là người rất có ảnh hưởng đến văn hóa Google, là người mà bất cứ nhân vật nổi tiếng nào khi đến thăm công ty cũng đều muốn gặp. Tham vọng của Meng chính là: “Soi sáng tâm trí, mở rộng trái tim và tạo ra hòa bình thế giới”.<br>		    		Cuốn sách Search inside yourself đã được ông viết lại dựa trên các kinh nghiệm đúc kết từ khóa học cùng các bài tập thiền để mọi người trong chúng ta đều có thể áp dụng được mà không cần phải tham gia khóa học kia của Google. Bằng ngôn từ đơn giản, dễ hiểu, cùng các bước luyện tập cơ bản nhằm giúp con người kiểm soát trí thông minh cảm xúc – làm chủ được cảm xúc bản thân, từ đó trở thành con người hạnh phúc nhất thế giới và lan tỏa niềm vui đến mọi người. “Tôi không thích mang Phật giáo vào Google”, Meng nói. “Tôi thích giúp đỡ mọi người ở Goolge tìm kiếm chìa khóa hạnh phúc”.<br>		    		Đúng như Eric Schmidt, Giám đốc điều hành của Google đã từng nói: “Cuốn sách này và khóa học mà nó dựa trên đại diện cho một trong những khía cạnh tuyệt vời nhất của văn hóa Google – một cá nhân với một ý tưởng thật sự vĩ đại có thể thay đổi thế giới”.<br>		    		Cuốn sách được chia làm ba phần chính:<br>		    		Rèn luyện khả năng chú ý: Chú ý là nền tảng của mọi năng lực cảm xúc và nhận thức cao hơn. Do đó, bất cứ giáo trình rèn luyện trí thông minh cảm xúc nào cũng đều phải bắt đầu với việc rèn luyện khả năng chú ý. Ý tưởng ở đây là rèn luyện khả năng chú ý để tạo ra một tâm trí vừa an bình vừa sáng sủa. Một tâm trí như vậy sẽ tạo nền tảng cho trí thông minh cảm xúc.<br>		    		Tự phát triển kiến thức và tự làm chủ bản thân: Sử dụng khả năng chú ý đã qua rèn luyện để nâng cao khả năng nhận thức quá trình cảm giác và tư duy của bạn. Từ đó, bạn có thể quan sát ngày càng rõ ràng dòng suy nghĩ và quá trình cảm giác của mình, với sự khách quan như từ góc nhìn của một người thứ ba. Khi làm được như vậy, bạn sẽ tạo ra một loại kiến thức sâu sắc do bạn tự khám phá ra và loại kiến thức này cuối cùng sẽ dẫn đến sự tự làm chủ bản thân.<br>		    		Tạo ra các thói quen hữu ích cho tâm: Hãy tưởng tượng rằng bất cứ khi nào bạn gặp ai đó, ý nghĩ đầu tiên, theo bản năng, theo thói quen của bạn là, tôi muốn người này được hạnh phúc. Có những thói quen như vậy sẽ thay đổi mọi thứ ở nơi làm việc, vì ý tốt chân thành này sẽ được người khác cảm nhận một cách vô thức, và tạo ra loại tin tưởng dẫn đến những sự hợp tác có hiệu quả cao. Những thói quen như vậy có thể được rèn luyện để trở thành tự nhiên.",
                        Pages = 364,
                        CategoryId = "KT",
                        PublisherId = "NXBT",
                        AuthorId = "A035",
                        CreatedAt = DateTime.Parse("2020-05-20 02:09:00"),
                        UpdatedAt = DateTime.Parse("2020-10-19 02:39:00")
                    },
                    new Book
                    {
                        Id = "S049",
                        Name = "Vũ Trụ Từ Hư Không",
                        Slug = "vu-tru-tu-hu-khong",
                        Price = 116000,
                        PublicationMonth = 1,
                        PublicationYear = 2019,
                        Description = "Tại sao tồn tại một cái gì đó thay vì không có gì?<br>		    	Lawrence M. Krauss - tác giả bán chạy nhất và nhà vật lý nổi tiếng đã đưa ra một quan điểm khác biệt về cách mọi thứ tồn tại: \"Vũ trụ đến từ đâu? Cái gì ở đó trước đó? Tương lai sẽ mang đến điều gì? Và cuối cùng, tại sao tồn tại một cái gì đó thay vì không có gì?\"<br>		    	Đặt tên cho phụ đề của cuốn sách bằng một câu hỏi “kinh điển”, “Tại sao tồn tại một cái gì đó thay vì không có gì?”, Krauss có tham vọng kết nối những phát hiện lớn lao của khoa học hiện đại với một câu hỏi đã gây sự tò mò cho các nhà thần học, triết gia, các nhà triết học tự nhiên và cả công chúng trong lịch sử.<br>		    	Cách đặt vấn đề và trình bày của Krauss luôn thể hiện chủ nghĩa mà ông theo đuổi và tôn thờ, chủ nghĩa “nghi ngờ một cách có khoa học”. Nhưng không chỉ dừng lại ở những nghi ngờ “tại sao”, trong lời mở đầu của cuốn sách, tác giả cũng đã lý giải rằng thực ra câu hỏi đơn thuần “tại sao” không hoàn toàn là một câu hỏi hợp lý, vì nó luôn bao hàm cả mục tiêu và luôn khiến người ta không thỏa mãn. Trong khoa học, khi ai đó muốn hỏi “tại sao”, thì thực ra người đó đang muốn trả lời câu hỏi “bằng cách nào” hay “như thế nào”. Đây chính là cách Krauss đã bắt đầu triển khai các ý tưởng của cuốn sách.<br>		    	Vũ trụ từ hư không có một kết cấu uyển chuyển, đủ để dẫn dắt người đọc phổ thông tiệm cận với khoa học về thiên văn. Krauss đã bắt đầu câu chuyện cuốn hút của mình bằng chương giải thích ngắn gọn về sự ra đời của thuyết Big Bang, giải thích cặn kẽ về sự giãn nở của vũ trụ với những mô tả về nghiên cứu của Edwin Hubble và cách xác định tuổi của vũ trụ. Câu chuyện được tiếp tục với những lý giải về việc tìm ra bức xạ nền vi ba – bằng chứng còn sót lại của Big Bang, rồi cùng các nhà vật lý đến với những nghiên cứu “cân vũ trụ” để cố gắng lý giải cho câu hỏi “vũ trụ phẳng”, “vũ trụ đóng”, hay “vũ trụ mở”<br>		    	Qua 11 chương sách, tác giả đã đề cập đến cả một hành trình khám phá vũ trụ đầy ấn tượng mà loài người thực hiện trong lịch sử tiến hóa của mình.<br>		    	Tạp chí khoa học Nature danh tiếng từng ca ngợi cuốn sách, coi Krauss là người kể chuyện vũ trụ duyên dáng nhất. Clinton Richard Dawkins, một cựu giáo sư Đại học Oxford, một nhà sinh học tiến hóa đã so sánh thành công của cuốn sách này ngang với tác phẩm kinh điển Nguồn gốc các loài của Charles Darwin.<br>		    		Tất cả những ai quan tâm đến Vật lý học, Vũ trụ học, những ai tò mò Vũ trụ của chúng ta đã bắt đầu như thế nào, và kết thúc ra sao đều nên đọc cuốn sách này.",
                        Pages = 320,
                        CategoryId = "KHCN",
                        PublisherId = "TG",
                        AuthorId = "A039",
                        TranslatorId = "A043",
                        CreatedAt = DateTime.Parse("2020-05-20 02:31:00"),
                        UpdatedAt = DateTime.Parse("2020-10-19 02:39:00")
                    },
                    new Book
                    {
                        Id = "S050",
                        Name = "Bóng Ma Trên Mạng",
                        Slug = "bong-ma-tren-mang",
                        Price = 149000,
                        PublicationMonth = 12,
                        PublicationYear = 2018,
                        Description = "Vào thời kỳ mà các thành viên của Anonymous – nhóm hacker đình đám nhất thế giới ngày nay – còn chưa xuất hiện, Kevin Mitnick đã trở thành nỗi kinh hoàng của không biết bao nhiêu điều tra viên FBI, các cơ quan chính phủ, các công ty cung cấp dịch vụ mạng và điện thoại. Với tài năng phi thường và niềm đam mê công nghệ khó ai sánh bằng, chỉ bằng các đòn tấn công bằng kỹ thuật xã hội (mạo danh, nghe lén, lục thùng rác,…), Mitnick đã thuyết phục được các nhân viên tại những công ty và cơ quan này giao nộp những thông tin cơ mật và vượt qua được nhiều lớp bảo mật để tiếp cận những dữ liệu mà ít người được biết. Có lẽ trên đời này sẽ chẳng có hacker nào dám cả gan nghe lén cả FBI, cơ quan điều tra sừng sỏ nhất thế giới, như Kevin Mitnick.<br>		    		Cao trào của cuốn sách là khi Mitnick bắt đầu chuyến phiêu lưu chạy trốn khỏi FBI trong suốt ba năm. Ông đã tạo ra các danh tính giả, tìm việc tại nhiều thành phố mà vẫn kiểm soát được những kẻ đang truy đuổi mình. Dù phải lẩn trốn liên tục, rời xa gia đình và bạn bè nhưng Mitnick chưa khi nào từ bỏ niềm đam mê hacking của mình cho tới tận lúc bị bắt và phải chấp nhận kết cục lãnh án biệt giam, cách ly với mọi loại máy tính.<br>		    		Giờ đây, khi đã hoàn lương và ngẩng cao đầu trên đường đời, tác giả của cuốn sách Bóng ma trên mạng lại trải lòng với đám “hậu sinh” về quá khứ oai hùng nhưng cũng không kém phần ấn tượng của mình, những gì ông rút ra trong thời gian bị xộ khám và cũng để đính chính những tin đồn sai lệch xoay quanh Huyền thoại về Kevin Mitnick.<br>		    		Với cách viết hài hước, dí dỏm, nhưng không kém phần lôi cuốn, Bóng ma trên mạng có thể coi là một bộ phim hành động hoàn hảo, một góc nhìn chân thật về cuộc đời của một trong những tội phạm mạng cấp cao đầu tiên trên toàn cầu, người được mệnh danh là “hacker bị truy nã gắt gao nhất thế giới giới”.<br>		    		Về tác giả:  <br>		    		Kevin Mitnick từng là hacker nổi tiếng nhất thế giới và giờ là một chuyên gia tư vấn về bảo mật. Anh là chủ đề của không biết bao nhiêu tin tức và báo đài tạp chí. Anh đã xuất hiện trên vô số chương trình truyền hình và phát thanh để đưa ra những bình luận chuyên sâu về bảo mật thông tin. Anh đã làm chứng trước Thượng viện Mỹ và viết bài cho tạp chí Harvard Business Review. Mitnick là đồng tác giả, cùng với William B. Simon, của những cuốn sách bán chạy nhất The Art of Deception (tạm dịch: Nghệ thuật lừa dối) và The Art of Intrusion(tạm dịch: Nghệ thuật xâm nhập). Anh hiện sống ở Las Vegas, Nevada.",
                        Pages = 524,
                        CategoryId = "KHCN",
                        PublisherId = "CT",
                        AuthorId = "A038",
                        TranslatorId = "A040",
                        CreatedAt = DateTime.Parse("2020-05-20 02:31:00"),
                        UpdatedAt = DateTime.Parse("2020-10-19 02:39:00")
                    },
                    new Book
                    {
                        Id = "S051",
                        Name = "The Art of Invisibility",
                        Slug = "the-art-of-invisibility",
                        Price = 189000,
                        PublicationMonth = 2,
                        PublicationYear = 2017,
                        Description = "Trong cuốn sách này, Kevin Mitnick, hacker nổi tiếng nhất thế giới, sẽ hướng dẫn các biện pháp dễ thực hiện (và ít tốn kém) giúp bạn – trên cương vị một cá nhân bình thường và một người tiêu dùng – có thể giấu các thông tin nhận dạng cá nhân của mình trong kỷ nguyên của Dữ liệu Lớn, vốn không thiếu những scandal quy mô quốc tế về những vụ vi phạm dữ liệu người dùng thường xuyên xuất hiện trên các mặt báo. Mitnick bàn đến nhiều phương tiện mà chúng ta sử dụng hằng ngày – từ điện thoại, email, cho đến tin nhắn,… – chỉ ra những lỗ hổng mà người khác có thể lợi dụng để giành quyền kiểm soát các dữ liệu của chúng ta, đồng thời đưa ra những giải pháp phòng chống cụ thể và hữu hiệu mà bất kỳ ai cũng có thể thực hiện để tự bảo vệ mình.<br>		    		Nhưng có lẽ một trong những giá trị quan trọng nhất của cuốn sách là qua đó, tác giả đã giải ảo niềm tin thơ ngây của đại đa số chúng ta rằng những hoạt động của mình trên mạng là đàng hoàng và lành mạnh nên có thể công khai, rằng chỉ những người có ý đồ xấu mới phải tìm cách che giấu các dữ liệu cá nhân. Hay nói như Mikko Hypponen, nhà nghiên cứu trưởng của hãng bảo mật F-Secure, thì: “Có thể bạn không có gì phải giấu diếm. Nhưng bạn có rất nhiều thứ phải bảo vệ đấy.”<br>		    		“Hacker bị săn lùng gắt gao nhất của FBI.” – Wired<br>		    		“Hacker nổi tiếng nhất thế giới kiêm người hùng trong nền văn hóa mạng new Book {…} vừa viết cuốn cẩm nang về an ninh hệ thống dựa trên chính những kinh nghiệm của mình. Đây là tài liệu phải đọc đối với các chuyên gia IT, nhưng đồng thời còn dành cho cả công chúng nói chung, giới hàn lâm, và các doanh nghiệp.” – Library Journal<br>		    		“Còn ai khác xứng đáng hơn Mitnick – hacker bị truy nã quốc tế rồi trở thành cố vấn an ninh cho các doanh nghiệp Fortune 500 – trong vai trò người thầy hướng dẫn bạn cách giữ an toàn cho dữ liệu trước những cuộc tấn công lừa đảo, sâu máy tính, và những tổ chức gián điệp mạng như Fancy Bears?” – Esquire<br>		    		“new Book {Nghệ thuật ẩn mình} là lời cảnh tỉnh, nhắc nhở chúng ta rằng các dữ liệu thô – từ email, ô tô, mạng wifi ở nhà,… – khiến chúng ta dễ dàng trở thành nạn nhân như thế nào.” - New York Times Book Review<br>		    		Về tác giả:<br>		    		Kevin David Mitnick (sinh năm 1963) là một cố vấn an ninh máy tính, tác giả, và trước đó là hacker lão luyện người Mỹ, từng khiến các nhà điều tra phải đau đầu, rốt cuộc ngồi tù 5 năm vì nhiều tội án liên quan đến máy tính như chiếm đoạt quyền truy cập thiết bị trái phép, nghe trộm các hoạt động liên lạc qua điện thoại và máy tính, truy cập trái phép vào hệ thống máy tính liên bang,…<br>		    		Hiện nay, ông quản lý hãng tư vấn an ninh Mitnick Security Consulting chuyên cung cấp dịch vụ kiểm thử mức độ an ninh và xác định các lỗ hổng an ninh tiềm tàng cho các tổ chức. Ngoài ra, ông còn là Hacker trưởng của KnowBe4, hãng đào tạo nâng cao nhận thức về an ninh, và là thành viên hội đồng cố vấn của Zimperium, hãng phát triển hệ thống ngăn chặn xâm nhập trên các thiết bị di động.",
                        CategoryId = "KHCN",
                        PublisherId = "CT",
                        AuthorId = "A036",
                        TranslatorId = "A042",
                        CreatedAt = DateTime.Parse("2020-05-20 02:31:00"),
                        UpdatedAt = DateTime.Parse("2020-10-19 23:20:00")
                    },
                    new Book
                    {
                        Id = "S052",
                        Name = "The Cuckoo\'s Egg",
                        Slug = "The Cuckoo\'s Egg",
                        Price = 176000,
                        PublicationMonth = 1,
                        PublicationYear = 2018,
                        Description = "Cuốn sách là câu chuyện người thực việc thực (tác giả cũng là nhân vật chính) kể về cuộc săn đuổi hacker bất đắc dĩ của một nhà khoa học chuyển tay ngang trở thành nhà quản lý hệ thống mạng máy tính ở Phòng Thí nghiệm Lawrence Berkeley, California, Mỹ.<br>		    	Từ một mức chênh lệch 75 xu trong hệ thống kế toán của phòng thí nghiệm, Cliff Stoll nghi ngờ có người đang sử dụng trái phép hệ thống của mình. Với quyết tâm tìm cho ra sự thật, Stoll bắt tay vào chuyến phiêu lưu một mình cùng gã hacker bí ẩn. Với những công cụ theo dõi thô sơ tự chế do không nhận được sự hỗ trợ của bất cứ ai – dẫu đã năm lần bảy lượt gõ cửa FBI, CIA và vô số các cơ quan an ninh, quân sự khác, Stoll đã rong ruổi theo gã hacker qua những mạng lưới quân sự nhạy cảm, các căn cứ quân sự, vệ tinh xuyên Đại Tây Dương, Nhật, và Đức. Cuối cùng, cũng bằng một chiến lược tự chế, anh đã bắt được một hacker quốc tế với động cơ là tiền, cocaine, và những âm mưu tình báo.<br>		    		Câu chuyện ly kỳ đến phút chót này đã trở thành nguồn cảm hứng cho nhiều chương trình truyền hình sau này ở Mỹ, và Stoll còn được nhận bằng khen của CIA, đồng thời trở thành một chuyên gia – có phần bất đắc dĩ – được nhiều người tìm kiếm để xin tư vấn về an ninh mạng",
                        Pages = 516,
                        CategoryId = "KHCN",
                        PublisherId = "CT",
                        AuthorId = "A037",
                        TranslatorId = "A041",
                        CreatedAt = DateTime.Parse("2020-05-20 02:31:00"),
                        UpdatedAt = DateTime.Parse("2020-10-19 02:40:00")
                    },
                    new Book
                    {
                        Id = "S053",
                        Name = "Doraemon - Gia Sư Tiếng Anh",
                        Slug = "doraemon-gia-su-tieng-anh",
                        Price = 40000,
                        PublicationMonth = 9,
                        PublicationYear = 2015,
                        Description = "Với các bậc cha mẹ muốn tự dạy tiếng Anh cho con ở nhà nhưng đang bối rối chưa biết bắt đầu từ đâu, cuốn sách Doraemon - Gia sư tiếng Anh chính là \"bảo bối\" cho cả nhà.<br>		    		Xuyên suốt cuốn sách là hơn 1500 từ vựng và mẫu câu cơ bản được trình bày khoa học, sinh động, với minh hoạ là chính các nhân vật quen thuộc, dễ thương Doraemon, Nobita, Shizuka, Jaian, Suneo...<br>		    		Bố mẹ có thể dễ dàng hướng dẫn các con học hoặc để các em tự tìm hiểu. Chúc cả nhà có những giờ học tiếng Anh thú vị với Doreamon!",
                        Pages = 150,
                        CategoryId = "STN",
                        PublisherId = "KD",
                        AuthorId = "A044",
                        CreatedAt = DateTime.Parse("2020-05-20 05:00:00"),
                        UpdatedAt = DateTime.Parse("2020-10-19 02:40:00")
                    },
                    new Book
                    {
                        Id = "S054",
                        Name = "Sự Tích Loài Vật - Chuyện Như Thế Đó",
                        Slug = "su-tich-loai-vat-chuyen-nhu-the-do",
                        Price = 84000,
                        PublicationMonth = 6,
                        PublicationYear = 2017,
                        Description = "Sự tích các loài vật - Chuyện như thế đó là tác phẩm viết cho trẻ em của Rudyard Kipling (1865 - 1936), nhà văn Anh đoạt Giải thưởng Nobel Văn học năm 1907.<br>		    		Cuốn sách sẽ dẫn dắt các bạn, dù ở bất cứ tuổi nào, đến với một khung cảnh khác lạ, không xác định thời gian và không gian. Bằng trí tưởng tượng và tài năng xuất chúng, Rudyard Kipling đã mở ra một thế giới nhiệm màu với những chú lạc đà không mang bướu trên lưng, những chú Kăng-gu-ru chạy miệt mài bởi lúc nào cũng bị chó Dingo rượt đuổi…",
                        Pages = 110,
                        CategoryId = "STN",
                        PublisherId = "KD",
                        AuthorId = "A045",
                        CreatedAt = DateTime.Parse("2020-05-20 05:02:00"),
                        UpdatedAt = DateTime.Parse("2020-10-19 02:40:00"),
                        DeletedAt = DateTime.Parse("2020-12-02 00:00:00")
                    },
                    new Book
                    {
                        Id = "S055",
                        Name = "Chuyện Con Mèo Dạy Hải Âu Bay",
                        Slug = "chuyen-con-meo-day-hai-au-bay",
                        Price = 37000,
                        PublicationMonth = 6,
                        PublicationYear = 2019,
                        Description = "Cô hải âu Kengah bị nhấn chìm trong váng dầu – thứ chất thải nguy hiểm mà những con người xấu xa bí mật đổ ra đại dương. Với nỗ lực đầy tuyệt vọng, cô bay vào bến cảng Hamburg và rơi xuống ban công của con mèo mun, to đùng, mập ú Zorba. Trong phút cuối cuộc đời, cô sinh ra một quả trứng và con mèo mun hứa với cô sẽ thực hiện ba lời hứa chừng như không tưởng với loài mèo:<br>		    	Không ăn quả trứng.<br>		    	Chăm sóc cho tới khi nó nở.<br>		    	Dạy cho con hải âu bay.<br>		    	Lời hứa của một con mèo cũng là trách nhiệm của toàn bộ mèo trên bến cảng, bởi vậy bè bạn của Zorba bao gồm ngài mèo Đại Tá đầy uy tín, mèo Secretario nhanh nhảu, mèo Einstein uyên bác, mèo Bốn Biển đầy kinh nghiệm đã chung sức giúp nó hoàn thành trách nhiệm. Tuy nhiên, việc chăm sóc, dạy dỗ một con hải âu đâu phải chuyện đùa, sẽ có hàng trăm rắc rối nảy sinh và cần có những kế hoạch đầy linh hoạt được bàn bạc kỹ càng…<br>		    	Chuyện con mèo dạy hải âu bay là kiệt tác dành cho thiếu nhi của nhà văn Chi Lê nổi tiếng Luis Sepúlveda – tác giả của cuốn Lão già mê đọc truyện tình đã bán được 18 triệu bản khắp thế giới. Tác phẩm không chỉ là một câu chuyện ấm áp, trong sáng, dễ thương về loài vật mà còn chuyển tải thông điệp về trách nhiệm với môi trường, về sự sẻ chia và yêu thương cũng như ý nghĩa của những nỗ lực – “Chỉ những kẻ dám mới có thể bay”.<br>		    	Cuốn sách mở đầu cho mùa hè với minh họa dễ thương, hài hước là món quà dành cho mọi trẻ em và người lớn.",
                        Pages = 144,
                        CategoryId = "STN",
                        PublisherId = "HNV",
                        AuthorId = "A046",
                        CreatedAt = DateTime.Parse("2020-07-04 00:41:00"),
                        UpdatedAt = DateTime.Parse("2020-10-19 02:40:00")
                    },
                    new Book
                    {
                        Id = "S056",
                        Name = "Các Thế Giới Song Song",
                        Slug = "cac-the-gioi-song-song",
                        Price = 96000,
                        PublicationMonth = 3,
                        PublicationYear = 2020,
                        Description = "Một chuyến du hành đầy trí tuệ qua các vũ trụ, được dẫn dắt tài tình bởi \"thuyền trưởng\" Michio Kaku và độc giả có dịp chiêm ngưỡng vẻ đẹp kỳ vĩ của vũ trụ kể từ vụ nổ lớn, vượt qua những hố đen, lỗ sâu, bước vào các thế giới lượng tử từ muôn màu kỳ lạ nằm ngay trước mũi chúng ta, vốn dĩ tồn tại song song trên một màng bên ngoài không - thời gian bốn chiều, ngắm nhìn thực tại vật chất quen thuộc hoà quyện với thế giới của những điều kỳ diệu như năng lượng và vật chất tối, sự nảy chồi của các vũ trụ, những chiều không gian bí ẩn và sự biến ảo của các dây rung siêu nhỏ...<br>		    		Dẫn chuyện lôi cuốn, kết hợp tường minh, sống động một lượng thông tin đồ sộ để khai mở những giới hạn tột cùng của trí  tưởng tượng, Kaku thực sự xứng đáng là \" nhà truyền giáo\" vĩ đại đã mang thế giới vật lý lý thuyết tới quảng đại quần chúng.",
                        Pages = 480,
                        CategoryId = "KHCN",
                        PublisherId = "TG",
                        AuthorId = "A047",
                        TranslatorId = "A050",
                        CreatedAt = DateTime.Parse("2020-10-19 04:06:00"),
                        UpdatedAt = DateTime.Parse("2020-10-20 22:04:00")
                    },
                    new Book
                    {
                        Id = "S057",
                        Name = "Vũ Trụ Toàn Ảnh",
                        Slug = "vu-tru-toan-anh",
                        Price = 123000,
                        PublicationMonth = 1,
                        PublicationYear = 2018,
                        Description = "Cuốn sách giải thích những điều kỳ lạ, những phép lạ tôn giáo, trải nghiệm cận tử, thoát xác, những khả năng phi thường của con người bằng nguyên lý toàn ảnh dựa trên ý tưởng cho rằng vũ trụ là một ảnh toàn ký khổng lồ.<br>		    		Song song với sự phát triển của khoa học, những điều huyền bí vẫn tồn tại bất chấp các định lý, định luật và điều kiện của tự nhiên mà khoa học hiện đại tuân theo. Đối mặt với vấn đề này, hầu hết các nhà khoa học lựa chọn “từ bỏ”, phủ nhận những điều huyền bí, một số người cực đoan thậm chí quy kết tất cả những gì siêu nhiên là mê tín. Mặc dù vậy, vẫn có những người tiếp tục nghiên cứu mặc sự dèm pha của đồng nghiệp. Michael Talbot là một trong số đó. Trong cuốn sách Vũ trụ toàn ảnh, ông đã đề xuất ý tưởng cho rằng toàn bộ vũ trụ là một cơ thể khổng lồ, không thể chia tách, là một ảnh toàn ký mà dù có chia nhỏ đến đâu vẫn cho ra hình ảnh nguyên vẹn. Theo quan niệm này, ông đã giải thích những điều kỳ lạ, những phép lạ tôn giáo, trải nghiệm cận tử, thoát xác, những khả năng phi thường của con người – tiên tri, thấu thị, cơ thể không bị tổn thương, đi trên dung nham nóng chảy, chữa bệnh bằng sức mạnh tinh thần… – bằng nguyên lý toàn ảnh, dựa trên những chứng cứ mà ông thu thập được và chính từ trải nghiệm của bản thân. Qua đó, ông cũng phần nào giải thích vì sao những hiện tượng siêu nhiên hay khả năng đặc biệt phần lớn được những người theo những nền văn hóa cổ trải nghiệm mà không phải những người thông thái theo trường phái hiện đại. Ý thức và niềm tin chính là chìa khóa cho vấn đề này.",
                        Pages = 516,
                        CategoryId = "KHCN",
                        PublisherId = "NXBT",
                        AuthorId = "A048",
                        TranslatorId = "A049",
                        CreatedAt = DateTime.Parse("2020-10-20 00:01:00"),
                        UpdatedAt = DateTime.Parse("2020-10-20 21:41:00")
                    }
                );
            #endregion

            #region BookImage
            modelBuilder.Entity<BookImage>()
                .HasData(
                    new BookImage
                    {
                        Id = 1,
                        BookId = "S001",
                        Image = "paybacktime.jpg",
                        Primary = 1,
                        CreatedAt = DateTime.Parse("2020-05-19 04:38:41")
                    },
                    new BookImage
                    {
                        Id = 2,
                        BookId = "S002",
                        Image = "bimattuduytrieuphu.jpg",
                        Primary = 1,
                        CreatedAt = DateTime.Parse("2020-05-19 04:51:44")
                    },
                    new BookImage
                    {
                        Id = 3,
                        BookId = "S003",
                        Image = "therichestmaninbabylon.jpg",
                        Primary = 1,
                        CreatedAt = DateTime.Parse("2020-05-19 04:57:42")
                    },
                    new BookImage
                    {
                        Id = 4,
                        BookId = "S004",
                        Image = "theteenwithamillionairemindser.jpg",
                        Primary = 1,
                        CreatedAt = DateTime.Parse("2020-05-19 05:01:11")
                    },
                    new BookImage
                    {
                        Id = 5,
                        BookId = "S005",
                        Image = "chasingtherabbit.jpg",
                        Primary = 1,
                        CreatedAt = DateTime.Parse("2020-05-19 05:03:31")
                    },
                    new BookImage
                    {
                        Id = 6,
                        BookId = "S006",
                        Image = "blackholes.png",
                        Primary = 1,
                        CreatedAt = DateTime.Parse("2020-05-19 05:12:59")
                    },
                    new BookImage
                    {
                        Id = 7,
                        BookId = "S007",
                        Image = "theuniverseinthenutshell.jpg",
                        Primary = 1,
                        CreatedAt = DateTime.Parse("2020-05-19 05:12:59")
                    },
                    new BookImage
                    {
                        Id = 8,
                        BookId = "S008",
                        Image = "whostephenhawking.jpg",
                        Primary = 1,
                        CreatedAt = DateTime.Parse("2020-05-19 05:12:59")
                    },
                    new BookImage
                    {
                        Id = 9,
                        BookId = "S009",
                        Image = "abriefhistoryoftime.jpg",
                        Primary = 1,
                        CreatedAt = DateTime.Parse("2020-05-19 05:12:59")
                    },
                    new BookImage
                    {
                        Id = 10,
                        BookId = "S010",
                        Image = "demenphieuluuky.jpg",
                        Primary = 1,
                        CreatedAt = DateTime.Parse("2020-05-19 07:15:34")
                    },
                    new BookImage
                    {
                        Id = 11,
                        BookId = "S011",
                        Image = "baddadgooddad.jpg",
                        Primary = 1,
                        CreatedAt = DateTime.Parse("2020-05-19 07:26:47")
                    },
                    new BookImage
                    {
                        Id = 12,
                        BookId = "S012",
                        Image = "ongnoivuotnguc.jpg",
                        Primary = 1,
                        CreatedAt = DateTime.Parse("2020-05-19 07:26:47")
                    },
                    new BookImage
                    {
                        Id = 13,
                        BookId = "S013",
                        Image = "banhmikepchuot.jpg",
                        Primary = 1,
                        CreatedAt = DateTime.Parse("2020-05-19 07:26:47")
                    },
                    new BookImage
                    {
                        Id = 14,
                        BookId = "S014",
                        Image = "nhasiyeuquai.jpg",
                        Primary = 1,
                        CreatedAt = DateTime.Parse("2020-05-19 07:26:47")
                    },
                    new BookImage
                    {
                        Id = 15,
                        BookId = "S015",
                        Image = "dungluachonannhankhicontre.jpg",
                        Primary = 1,
                        CreatedAt = DateTime.Parse("2020-05-19 07:38:04")
                    },
                    new BookImage
                    {
                        Id = 16,
                        BookId = "S016",
                        Image = "nonggianlabannangtinhlanglabanlinh.png",
                        Primary = 1,
                        CreatedAt = DateTime.Parse("2020-05-19 07:38:04")
                    },
                    new BookImage
                    {
                        Id = 17,
                        BookId = "S017",
                        Image = "cuocsongdechgiongcuocdoi.png",
                        Primary = 1,
                        CreatedAt = DateTime.Parse("2020-05-19 21:56:14")
                    },
                    new BookImage
                    {
                        Id = 18,
                        BookId = "S018",
                        Image = "cuocsongratgiongcuocdoi.jpg",
                        Primary = 1,
                        CreatedAt = DateTime.Parse("2020-05-19 21:56:14")
                    },
                    new BookImage
                    {
                        Id = 19,
                        BookId = "S019",
                        Image = "lanamtrongla.jpg",
                        Primary = 1,
                        CreatedAt = DateTime.Parse("2020-05-19 22:14:39")
                    },
                    new BookImage
                    {
                        Id = 20,
                        BookId = "S020",
                        Image = "ngoikhoctrencay.jpg",
                        Primary = 1,
                        CreatedAt = DateTime.Parse("2020-05-19 22:14:39")
                    },
                    new BookImage
                    {
                        Id = 21,
                        BookId = "S021",
                        Image = "toithayhoavangtrencoxanh.jpeg",
                        Primary = 1,
                        CreatedAt = DateTime.Parse("2020-05-19 22:14:39")
                    },
                    new BookImage
                    {
                        Id = 22,
                        BookId = "S022",
                        Image = "chotoixinmotvedituoitho.jpg",
                        Primary = 1,
                        CreatedAt = DateTime.Parse("2020-05-19 22:14:39")
                    },
                    new BookImage
                    {
                        Id = 23,
                        BookId = "S023",
                        Image = "cogaidentuhomqua.jpeg",
                        Primary = 1,
                        CreatedAt = DateTime.Parse("2020-05-19 22:14:39")
                    },
                    new BookImage
                    {
                        Id = 24,
                        BookId = "S024",
                        Image = "matbiec.jpg",
                        Primary = 1,
                        CreatedAt = DateTime.Parse("2020-05-19 22:14:39")
                    },
                    new BookImage
                    {
                        Id = 25,
                        BookId = "S025",
                        Image = "gaynguoithilanh.jpg",
                        Primary = 1,
                        CreatedAt = DateTime.Parse("2020-05-19 23:22:56")
                    },
                    new BookImage
                    {
                        Id = 26,
                        BookId = "S026",
                        Image = "hanhlyhuvo.jpg",
                        Primary = 1,
                        CreatedAt = DateTime.Parse("2020-05-19 23:22:56")
                    },
                    new BookImage
                    {
                        Id = 27,
                        BookId = "S027",
                        Image = "khongaiquasong.jpg",
                        Primary = 1,
                        CreatedAt = DateTime.Parse("2020-05-19 23:40:20")
                    },
                    new BookImage
                    {
                        Id = 28,
                        BookId = "S028",
                        Image = "dongtamlong.jpg",
                        Primary = 1,
                        CreatedAt = DateTime.Parse("2020-05-19 23:40:20")
                    },
                    new BookImage
                    {
                        Id = 29,
                        BookId = "S029",
                        Image = "vangbongmotthoi.jpeg",
                        Primary = 1,
                        CreatedAt = DateTime.Parse("2020-05-20 00:58:28")
                    },
                    new BookImage
                    {
                        Id = 30,
                        BookId = "S030",
                        Image = "truyenmotcaithuyendat.jpg",
                        Primary = 1,
                        CreatedAt = DateTime.Parse("2020-05-20 00:58:28")
                    },
                    new BookImage
                    {
                        Id = 31,
                        BookId = "S031",
                        Image = "haisophan.jpg",
                        Primary = 1,
                        CreatedAt = DateTime.Parse("2020-05-20 01:09:57")
                    },
                    new BookImage
                    {
                        Id = 32,
                        BookId = "S032",
                        Image = "thethornbirds.gif",
                        Primary = 1,
                        CreatedAt = DateTime.Parse("2020-05-20 01:09:57")
                    },
                    new BookImage
                    {
                        Id = 33,
                        BookId = "S033",
                        Image = "kieuhanhvadinhkien.jpg",
                        Primary = 1,
                        CreatedAt = DateTime.Parse("2020-05-20 01:09:57")
                    },
                    new BookImage
                    {
                        Id = 34,
                        BookId = "S034",
                        Image = "nhungnguoikhonkho.jpg",
                        Primary = 1,
                        CreatedAt = DateTime.Parse("2020-05-20 01:09:57")
                    },
                    new BookImage
                    {
                        Id = 35,
                        BookId = "S035",
                        Image = "suimlangcuabaycuu.jpg",
                        Primary = 1,
                        CreatedAt = DateTime.Parse("2020-05-20 01:26:10")
                    },
                    new BookImage
                    {
                        Id = 36,
                        BookId = "S036",
                        Image = "dethidammau.jpg",
                        Primary = 1,
                        CreatedAt = DateTime.Parse("2020-05-20 01:26:10")
                    },
                    new BookImage
                    {
                        Id = 37,
                        BookId = "S037",
                        Image = "nhungvukyancuasherlockholmes.jpg",
                        Primary = 1,
                        CreatedAt = DateTime.Parse("2020-05-20 01:26:10")
                    },
                    new BookImage
                    {
                        Id = 38,
                        BookId = "S038",
                        Image = "nhunggiacmoohieusachmorisaki.jpg",
                        Primary = 1,
                        CreatedAt = DateTime.Parse("2020-05-20 01:26:10")
                    },
                    new BookImage
                    {
                        Id = 39,
                        BookId = "S039",
                        Image = "hannibal.jpg",
                        Primary = 1,
                        CreatedAt = DateTime.Parse("2020-05-20 01:26:10")
                    },
                    new BookImage
                    {
                        Id = 40,
                        BookId = "S040",
                        Image = "thegioithatlac.jpg",
                        Primary = 1,
                        CreatedAt = DateTime.Parse("2020-05-20 01:26:10")
                    },
                    new BookImage
                    {
                        Id = 41,
                        BookId = "S041",
                        Image = "anhdengiuahaidaiduong.jpg",
                        Primary = 1,
                        CreatedAt = DateTime.Parse("2020-05-20 01:47:35")
                    },
                    new BookImage
                    {
                        Id = 42,
                        BookId = "S042",
                        Image = "loihoidap1994.jpg",
                        Primary = 1,
                        CreatedAt = DateTime.Parse("2020-05-20 01:47:35")
                    },
                    new BookImage
                    {
                        Id = 43,
                        BookId = "S043",
                        Image = "khonggiadinh.jpg",
                        Primary = 1,
                        CreatedAt = DateTime.Parse("2020-05-20 01:47:35")
                    },
                    new BookImage
                    {
                        Id = 44,
                        BookId = "S044",
                        Image = "tienggoicuahoangda.jpg",
                        Primary = 1,
                        CreatedAt = DateTime.Parse("2020-05-20 01:47:35")
                    },
                    new BookImage
                    {
                        Id = 45,
                        BookId = "S045",
                        Image = "quatredechet.jpg",
                        Primary = 1,
                        CreatedAt = DateTime.Parse("2020-05-20 01:47:35")
                    },
                    new BookImage
                    {
                        Id = 46,
                        BookId = "S046",
                        Image = "nghinhumottyphu.jpg",
                        Primary = 1,
                        CreatedAt = DateTime.Parse("2020-05-20 01:55:43")
                    },
                    new BookImage
                    {
                        Id = 47,
                        BookId = "S047",
                        Image = "toidalamgiaunhuthe.jpg",
                        Primary = 1,
                        CreatedAt = DateTime.Parse("2020-05-20 01:58:12")
                    },
                    new BookImage
                    {
                        Id = 48,
                        BookId = "S048",
                        Image = "searchinsideyourself.jpg",
                        Primary = 1,
                        CreatedAt = DateTime.Parse("2020-05-20 02:09:35")
                    },
                    new BookImage
                    {
                        Id = 49,
                        BookId = "S049",
                        Image = "vutrutuhukhong.jpg",
                        Primary = 1,
                        CreatedAt = DateTime.Parse("2020-05-20 02:31:20")
                    },
                    new BookImage
                    {
                        Id = 50,
                        BookId = "S050",
                        Image = "bongmatrenmang.jpg",
                        Primary = 1,
                        CreatedAt = DateTime.Parse("2020-05-20 02:31:20")
                    },
                    new BookImage
                    {
                        Id = 51,
                        BookId = "S051",
                        Image = "nghethuatanminh.jpg",
                        Primary = 1,
                        CreatedAt = DateTime.Parse("2020-05-20 02:31:20")
                    },
                    new BookImage
                    {
                        Id = 52,
                        BookId = "S052",
                        Image = "giandiepmangcuocruotduoingoanmuctrongmelomaytinhcliffordstoll.jpg",
                        Primary = 1,
                        CreatedAt = DateTime.Parse("2020-05-20 02:31:20")
                    },
                    new BookImage
                    {
                        Id = 53,
                        BookId = "S053",
                        Image = "doraemongiasutienganh.jpg",
                        Primary = 1,
                        CreatedAt = DateTime.Parse("2020-05-20 05:00:01")
                    },
                    new BookImage
                    {
                        Id = 54,
                        BookId = "S054",
                        Image = "sutichloaivatchuyennhuthedo.jpg",
                        Primary = 1,
                        CreatedAt = DateTime.Parse("2020-05-20 05:02:01")
                    },
                    new BookImage
                    {
                        Id = 55,
                        BookId = "S055",
                        Image = "chuyenconmeodayhaiaubay.jpg",
                        Primary = 1,
                        CreatedAt = DateTime.Parse("2020-07-04 00:41:15")
                    },
                    new BookImage
                    {
                        Id = 56,
                        BookId = "S056",
                        Image = "cac_the_gioi_song_song.jpg",
                        Primary = 1,
                        CreatedAt = DateTime.Parse("2020-10-19 04:06:39")
                    },
                    new BookImage
                    {
                        Id = 57,
                        BookId = "S057",
                        Image = "vutrutoananh.jpg",
                        Primary = 1,
                        CreatedAt = DateTime.Parse("2020-10-20 00:01:29")
                    }
                );
            #endregion

            #region Comment
            modelBuilder.Entity<Comment>()
                .HasData(
                    new Comment
                    {
                        Id = 1,
                        Name = "Thiên An",
                        Email = "thienan@gmail.com",
                        BookId = "S012",
                        Vote = 3,
                        Content = "Cảm thấy thú vị",
                        Bought = 0,
                        CreatedAt = DateTime.Parse("2020-06-19 17:35:57"),
                        UpdatedAt = DateTime.Parse("2020-06-19 17:35:57")
                    },
                    new Comment
                    {
                        Id = 2,
                        Name = "Lê Anh Tthư",
                        Email = "thuleanh@gmail.com",
                        BookId = "S040",
                        Vote = 4,
                        Content = "Sách có nội dung gây cảm hứng.",
                        Bought = 0,
                        CreatedAt = DateTime.Parse("2020-06-19 17:35:57"),
                        UpdatedAt = DateTime.Parse("2020-06-19 17:35:57")
                    }
                );
            #endregion

            #region Coupon
            modelBuilder.Entity<Coupon>()
                .HasData(
                    new Coupon
                    {
                        Id = 1,
                        Code = "HBNH01",
                        Slug = "hbnh01",
                        Name = "HAPPY BIRTHDAY",
                        Description = "Chúc mừng sinh nhật TwentySven",
                        Uses = 0,
                        MaxUses = 100,
                        MaxUsesUser = 1,
                        Type = "Coupon",
                        DiscountAmount = 50,
                        MinPrice = 0,
                        IsFixed = 0,
                        Image = "birthdaysale.jpg",
                        StartsAt = DateTime.Parse("2020-12-04 00:00:00"),
                        ExpiresAt = DateTime.Parse("2020-12-31 00:00:00"),
                        CreatedAt = DateTime.Parse("2020-12-04 00:00:00"),
                        UpdatedAt = DateTime.Parse("2020-12-04 00:00:00")
                    }
                );
            #endregion

            #region Order
            modelBuilder.Entity<Order>()
                .HasData(
                    new Order
                    {
                        Id = "DH001",
                        Name = "NGÔ THỊ MINH THƯ",
                        Email = "minhthu9979@gmail.com",
                        Address = "Tổ 4, Khu 5B, Bãy Cháy, TP. Hạ Long, Tỉnh Quảng Ninh",
                        Phone = "0913369555",
                        Note = "Gọi điện thoại trước khi giao hàng",
                        SubTotal = 712000,
                        Total = 712000,
                        StatusId = 2,
                        PaymentMethodId = 1,
                        PaymentStatus = 0,
                        CreatedAt = DateTime.Parse("2020-06-25 05:47:07"),
                        UpdatedAt = DateTime.Parse("2020-07-04 01:39:40")
                    },
                    new Order
                    {
                        Id = "DH002",
                        CustomerId = "KH002",
                        Name = "ĐOÀN HỮU MINH",
                        Email = "cuongphuong78@yahoo.com",
                        Phone = "0938189742",
                        Address = "330 Cách Mạng Tháng Tám, Phường 10, Quận 3, TP.HCM",
                        SubTotal = 152000,
                        Total = 152000,
                        StatusId = 2,
                        PaymentMethodId = 1,
                        PaymentStatus = 0,
                        CreatedAt = DateTime.Parse("2020-06-25 07:58:56"),
                        UpdatedAt = DateTime.Parse("2020-07-01 22:40:19")
                    },
                    new Order
                    {
                        Id = "DH003",
                        CustomerId = "KH002",
                        Name = "ĐOÀN HỮU MINH",
                        Email = "cuongphuong78@yahoo.com",
                        Phone = "0938189742",
                        Address = "280 An Dương Vương P4 Q5 TPHCM",
                        Note = "Giao giờ hành chính",
                        SubTotal = 206000,
                        Total = 206000,
                        StatusId = 2,
                        PaymentMethodId = 1,
                        PaymentStatus = 0,
                        CreatedAt = DateTime.Parse("2020-06-25 08:02:14"),
                        UpdatedAt = DateTime.Parse("2020-07-02 09:24:29")
                    },
                    new Order
                    {
                        Id = "DH004",
                        Name = "NGUYỄN VÕ HUY HOÀNG",
                        Email = "kingdragon_20988@gmail.com",
                        Phone = "0902797879",
                        Address = "327 Nguyễn Trọng Tuyển, Phường 10, Quận Phú Nhuận, TP.HCM",
                        SubTotal = 598000,
                        Total = 598000,
                        StatusId = 2,
                        PaymentMethodId = 1,
                        PaymentStatus = 0,
                        CreatedAt = DateTime.Parse("2020-06-26 10:01:49"),
                        UpdatedAt = DateTime.Parse("2020-06-30 19:36:42")
                    },
                    new Order
                    {
                        Id = "DH005",
                        Name = "LÊ HỒNG NAM",
                        Email = "kelvin.nam@bfcot.com",
                        Phone = "0903377548",
                        Address = "Phòng 0.36 Tòa Nhà Centec Tower, 72-74 Nguyễn Thị Minh Khai, P.6, Q.3, TP.HCM",
                        SubTotal = 607000,
                        Total = 607000,
                        StatusId = 1,
                        PaymentMethodId = 1,
                        PaymentStatus = 0,
                        CreatedAt = DateTime.Parse("2020-06-26 12:48:04"),
                        UpdatedAt = DateTime.Parse("2020-06-30 18:05:52")
                    },
                    new Order
                    {
                        Id = "DH006",
                        Name = "PHẠM ANH THẮNG",
                        Email = "2010longthanh@gmail.com",
                        Phone = "0986908666",
                        Address = "Tổ 4, Khu 4, Trần Hưng Đạo, TP. Hạ Long, Tỉnh Quảng Ninh",
                        SubTotal = 821000,
                        Total = 821000,
                        StatusId = 1,
                        PaymentMethodId = 1,
                        PaymentStatus = 0,
                        CreatedAt = DateTime.Parse("2020-06-30 10:38:54"),
                        UpdatedAt = DateTime.Parse("2020-06-30 10:38:54")
                    },
                    new Order
                    {
                        Id = "DH007",
                        CustomerId = "KH003",
                        Name = "Nguyễn Phương Thảo",
                        Email = "thao.nguyen@gazefi.com",
                        Phone = "0933335666",
                        Address = "109 Tổ 2, Khu Bến Cát, Phường Phước Bình, Quận 9, TP.HCM",
                        Note = "Người nhận: Lê Văn Nam",
                        SubTotal = 127000,
                        Total = 127000,
                        StatusId = 1,
                        PaymentMethodId = 1,
                        PaymentStatus = 0,
                        CreatedAt = DateTime.Parse("2020-06-30 20:13:12"),
                        UpdatedAt = DateTime.Parse("2020-06-30 20:13:12")
                    },
                    new Order
                    {
                        Id = "DH008",
                        Name = "NGUYỄN THÚY LAN",
                        Email = "vanlangbds@vnn.vn",
                        Phone = "0909212222",
                        Address = "40 Xuân Thủy, Phường Thảo Điền, Quận 2, TP.HCM",
                        SubTotal = 111000,
                        Total = 111000,
                        StatusId = 1,
                        PaymentMethodId = 1,
                        PaymentStatus = 0,
                        CreatedAt = DateTime.Parse("2020-06-30 20:15:12"),
                        UpdatedAt = DateTime.Parse("2020-06-30 20:15:12")
                    },
                    new Order
                    {
                        Id = "DH009",
                        Name = "LÊ VĨNH AN",
                        Email = "anvictory23881@yahoo.com.vn",
                        Phone = "0906267888",
                        Address = "184/27 Đặng Văn Ngữ, Phường 14, Quận Phú Nhuận, TP.HCM",
                        SubTotal = 268000,
                        Total = 268000,
                        StatusId = 1,
                        PaymentMethodId = 1,
                        PaymentStatus = 0,
                        CreatedAt = DateTime.Parse("2020-06-30 20:16:09"),
                        UpdatedAt = DateTime.Parse("2020-06-30 20:16:09")
                    },
                    new Order
                    {
                        Id = "DH010",
                        Name = "HÀ TUẤN ANH",
                        Email = "tuananh@yahoo.com.vn",
                        Phone = "0903202808",
                        Address = "Số nhà 18 Ngõ 3, Tổ 8, Phường Giảng Võ, Quận Ba Đình, Hà Nội",
                        SubTotal = 90000,
                        Total = 90000,
                        StatusId = 1,
                        PaymentMethodId = 1,
                        PaymentStatus = 0,
                        CreatedAt = DateTime.Parse("2020-06-30 20:18:46"),
                        UpdatedAt = DateTime.Parse("2020-06-30 20:18:46")
                    },
                    new Order
                    {
                        Id = "DH011",
                        Name = "DƯƠNG THỊ THÙY DUNG",
                        Email = "dung@lecoviet.com",
                        Phone = "0915087777",
                        Address = "A1T8 Chung Cư 335 Cầu Giấy, Phường Dịch Vọng, Q. Cầu Giấy, Hà Nội",
                        SubTotal = 90000,
                        Total = 90000,
                        StatusId = 1,
                        PaymentMethodId = 1,
                        PaymentStatus = 0,
                        CreatedAt = DateTime.Parse("2020-06-30 21:00:38"),
                        UpdatedAt = DateTime.Parse("2020-06-30 21:00:38")
                    },
                    new Order
                    {
                        Id = "DH012",
                        CustomerId = "KH007",
                        Name = "Trần Việt Hải",
                        Email = "hai2@gmail.com",
                        Phone = "0913652449",
                        Address = "315 Khu Phố 2 - Thị trấn Hóc Môn - TPHCM",
                        SubTotal = 136000,
                        Total = 136000,
                        StatusId = 1,
                        PaymentMethodId = 1,
                        PaymentStatus = 0,
                        CreatedAt = DateTime.Parse("2020-06-30 22:22:20"),
                        UpdatedAt = DateTime.Parse("2020-06-30 22:22:20")
                    },
                    new Order
                    {
                        Id = "DH013",
                        CustomerId = "KH008",
                        Name = "Phan Thanh Sang",
                        Email = "sang001@gmail.com",
                        Phone = "0903120175",
                        Address = "39 Bến Phú Định, F16, Q8, HCM",
                        SubTotal = 186000,
                        Total = 186000,
                        StatusId = 2,
                        PaymentMethodId = 1,
                        PaymentStatus = 0,
                        CreatedAt = DateTime.Parse("2020-06-30 22:23:53"),
                        UpdatedAt = DateTime.Parse("2020-07-01 09:20:28")
                    },
                    new Order
                    {
                        Id = "DH014",
                        CustomerId = "KH008",
                        Name = "Phan Thanh Sang",
                        Email = "sang001@gmail.com",
                        Phone = "0903120175",
                        Address = "39 Bến Phú Định, F16, Q8, HCM",
                        SubTotal = 354000,
                        Total = 354000,
                        StatusId = 1,
                        PaymentMethodId = 1,
                        PaymentStatus = 0,
                        CreatedAt = DateTime.Parse("2020-06-30 22:24:38"),
                        UpdatedAt = DateTime.Parse("2020-06-30 22:24:38")
                    },
                    new Order
                    {
                        Id = "DH015",
                        CustomerId = "KH006",
                        Name = "Lê Thị Khánh Quỳnh",
                        Email = "quynh@gmail.com",
                        Phone = "0918637176",
                        Address = "2/15B Trần Nhân Tôn, F2, Q.10 Trần Nhân Tôn, F2, Q.10 TP.HCM",
                        SubTotal = 265000,
                        Total = 265000,
                        StatusId = 1,
                        PaymentMethodId = 1,
                        PaymentStatus = 0,
                        CreatedAt = DateTime.Parse("2020-06-30 22:26:29"),
                        UpdatedAt = DateTime.Parse("2020-06-30 22:26:29")
                    },
                    new Order
                    {
                        Id = "DH016",
                        CustomerId = "KH019",
                        Name = "Nguyễn Thị Thùy Trang",
                        Email = "thuytrang@gmail.com",
                        Phone = "0918265681",
                        Address = "3B-2-2-5 Chung Cư Mỹ Viên, Nguyễn Lương Bằng, F.TÂn Phú, Q.7",
                        SubTotal = 138000,
                        Total = 138000,
                        StatusId = 1,
                        PaymentMethodId = 1,
                        PaymentStatus = 0,
                        CreatedAt = DateTime.Parse("2020-07-01 09:25:06"),
                        UpdatedAt = DateTime.Parse("2020-07-01 09:25:06")
                    },
                    new Order
                    {
                        Id = "DH017",
                        CustomerId = "KH019",
                        Name = "Nguyễn Thị Thùy Trang",
                        Email = "thuytrang@gmail.com",
                        Phone = "0918265681",
                        Address = "3B-2-2-5 Chung Cư Mỹ Viên, Nguyễn Lương Bằng, F.TÂn Phú, Q.7",
                        SubTotal = 59000,
                        Total = 59000,
                        StatusId = 1,
                        PaymentMethodId = 1,
                        PaymentStatus = 0,
                        CreatedAt = DateTime.Parse("2020-07-01 09:25:28"),
                        UpdatedAt = DateTime.Parse("2020-07-01 09:25:28")
                    },
                    new Order
                    {
                        Id = "DH018",
                        CustomerId = "KH020",
                        Name = "Tô Hữu Long Vũ",
                        Email = "longvuv@gmail.com",
                        Phone = "0908606399",
                        Address = "43 đường 909 Tạ Quang Biểu, F.5, Q.8",
                        SubTotal = 338000,
                        Total = 338000,
                        StatusId = 1,
                        PaymentMethodId = 1,
                        PaymentStatus = 0,
                        CreatedAt = DateTime.Parse("2020-07-01 09:27:28"),
                        UpdatedAt = DateTime.Parse("2020-07-01 09:27:28")
                    },
                    new Order
                    {
                        Id = "DH019",
                        CustomerId = "KH020",
                        Name = "Tô Hữu Long Vũ",
                        Email = "longvuv@gmail.com",
                        Phone = "0908606399",
                        Address = "43 đường 909 Tạ Quang Biểu, F.5, Q.8",
                        SubTotal = 134000,
                        Total = 134000,
                        StatusId = 1,
                        PaymentMethodId = 1,
                        PaymentStatus = 0,
                        CreatedAt = DateTime.Parse("2020-07-01 09:27:54"),
                        UpdatedAt = DateTime.Parse("2020-07-01 09:27:54")
                    },
                    new Order
                    {
                        Id = "DH020",
                        CustomerId = "KH025",
                        Name = "Thái Lê Ngọc Thy",
                        Email = "thy@gmail.com",
                        Phone = "0918265699",
                        Address = "32/1C Trần Hưng Đạo, Q.5, TPHCM",
                        SubTotal = 150000,
                        Total = 150000,
                        StatusId = 2,
                        PaymentMethodId = 1,
                        PaymentStatus = 0,
                        CreatedAt = DateTime.Parse("2019-07-01 09:41:31"),
                        UpdatedAt = DateTime.Parse("2020-07-02 09:24:45")
                    },
                    new Order
                    {
                        Id = "DH021",
                        CustomerId = "KH025",
                        Name = "Thái Lê Ngọc Thy",
                        Email = "thy@gmail.com",
                        Phone = "0918265699",
                        Address = "32/1C Trần Hưng Đạo, Q.5, TPHCM",
                        SubTotal = 242000,
                        Total = 242000,
                        StatusId = 1,
                        PaymentMethodId = 1,
                        PaymentStatus = 0,
                        CreatedAt = DateTime.Parse("2019-07-01 09:45:03"),
                        UpdatedAt = DateTime.Parse("2020-07-01 09:45:03")
                    },
                    new Order
                    {
                        Id = "DH022",
                        CustomerId = "KH024",
                        Name = "Lương Bích Vân",
                        Email = "vanvan@gmail.com",
                        Phone = "0955220676",
                        Address = "42/4/7 đường số 13 F.11, Q.GV",
                        SubTotal = 216000,
                        Total = 216000,
                        StatusId = 1,
                        PaymentMethodId = 1,
                        PaymentStatus = 0,
                        CreatedAt = DateTime.Parse("2020-07-01 09:47:02"),
                        UpdatedAt = DateTime.Parse("2020-07-01 09:47:02")
                    },
                    new Order
                    {
                        Id = "DH023",
                        CustomerId = "KH024",
                        Name = "Lương Bích Vân",
                        Email = "vanvan@gmail.com",
                        Phone = "0955220676",
                        Address = "42/4/7 đường số 13 F.11, Q.GV",
                        SubTotal = 219000,
                        Total = 219000,
                        StatusId = 1,
                        PaymentMethodId = 1,
                        PaymentStatus = 0,
                        CreatedAt = DateTime.Parse("2020-07-01 09:48:24"),
                        UpdatedAt = DateTime.Parse("2020-07-01 09:48:24")
                    },
                    new Order
                    {
                        Id = "DH024",
                        CustomerId = "KH024",
                        Name = "Lương Bích Vân",
                        Email = "vanvan@gmail.com",
                        Phone = "0955220676",
                        Address = "42/4/7 đường số 13 F.11, Q.GV",
                        SubTotal = 94000,
                        Total = 94000,
                        StatusId = 1,
                        PaymentMethodId = 1,
                        PaymentStatus = 0,
                        CreatedAt = DateTime.Parse("2020-07-01 09:49:55"),
                        UpdatedAt = DateTime.Parse("2020-07-01 09:49:55")
                    },
                    new Order
                    {
                        Id = "DH025",
                        CustomerId = "KH021",
                        Name = "Đỗ Thành Vĩnh",
                        Email = "vinh@gmail.com",
                        Phone = "0908110026",
                        Address = "351/18A Lê Đại Hành F.11, Q.11",
                        SubTotal = 115000,
                        Total = 115000,
                        StatusId = 1,
                        PaymentMethodId = 1,
                        PaymentStatus = 0,
                        CreatedAt = DateTime.Parse("2020-07-01 09:51:39"),
                        UpdatedAt = DateTime.Parse("2020-07-01 09:51:39")
                    },
                    new Order
                    {
                        Id = "DH026",
                        CustomerId = "KH021",
                        Name = "Đỗ Thành Vĩnh",
                        Email = "vinh@gmail.com",
                        Phone = "0908110026",
                        Address = "351/18A Lê Đại Hành F.11, Q.11",
                        SubTotal = 60000,
                        Total = 60000,
                        StatusId = 1,
                        PaymentMethodId = 1,
                        PaymentStatus = 0,
                        CreatedAt = DateTime.Parse("2019-07-31 10:02:47"),
                        UpdatedAt = DateTime.Parse("2020-07-01 10:02:47")
                    },
                    new Order
                    {
                        Id = "DH027",
                        Name = "NGÔ THỊ MINH THƯ",
                        Email = "minhthu9979@gmail.com",
                        Phone = "0913369555",
                        Address = "Tổ 4, Khu 5B, Bãy Cháy, TP. Hạ Long, Tỉnh Quảng Ninh",
                        SubTotal = 124000,
                        Total = 124000,
                        StatusId = 1,
                        PaymentMethodId = 1,
                        PaymentStatus = 0,
                        CreatedAt = DateTime.Parse("2020-07-02 08:53:00"),
                        UpdatedAt = DateTime.Parse("2020-07-02 08:53:00")
                    },
                    new Order
                    {
                        Id = "DH028",
                        CustomerId = "KH027",
                        Name = "Nguyễn Thị Minh Thảo",
                        Email = "thaominh@gmail.com",
                        Phone = "0923312776",
                        Address = "62/20B Đinh Bộ Lĩnh, F.26, Q.BT",
                        SubTotal = 200000,
                        Total = 200000,
                        StatusId = 1,
                        PaymentMethodId = 1,
                        PaymentStatus = 0,
                        CreatedAt = DateTime.Parse("2019-11-23 12:33:10"),
                        UpdatedAt = DateTime.Parse("2019-11-23 12:33:10")
                    },
                    new Order
                    {
                        Id = "DH029",
                        CustomerId = "KH027",
                        Name = "Nguyễn Thị Minh Thảo",
                        Email = "thaominh@gmail.com",
                        Phone = "0923312776",
                        Address = "62/20B Đinh Bộ Lĩnh, F.26, Q.BT",
                        SubTotal = 119000,
                        Total = 119000,
                        StatusId = 1,
                        PaymentMethodId = 1,
                        PaymentStatus = 0,
                        CreatedAt = DateTime.Parse("2019-11-24 12:33:40"),
                        UpdatedAt = DateTime.Parse("2019-11-24 12:33:40")
                    },
                    new Order
                    {
                        Id = "DH030",
                        CustomerId = "KH036",
                        Name = "Lê Minh",
                        Email = "leminh@gmail.com",
                        Phone = "0987896757",
                        Address = "280 An Dương Vương",
                        Note = "Gọi điện thoại trước khi giao.",
                        SubTotal = 337000,
                        Total = 337000,
                        StatusId = 2,
                        PaymentMethodId = 1,
                        PaymentStatus = 0,
                        CreatedAt = DateTime.Parse("2020-10-20 22:29:11"),
                        UpdatedAt = DateTime.Parse("2020-10-20 22:38:15")
                    }
                );
            #endregion

            #region OrderDetail
            modelBuilder.Entity<OrderDetail>()
                .HasData(
                    new OrderDetail
                    {
                        OrderDetailId = 1,
                        OrderId = "DH001",
                        BookId = "S001",
                        Quantity = 2,
                        Price = 299000,
                        CreatedAt = DateTime.Parse("2020-06-25 05:47:07")
                    },
                    new OrderDetail
                    {
                        OrderDetailId = 1,
                        OrderId = "DH002",
                        BookId = "S008",
                        Quantity = 2,
                        Price = 50000,
                        CreatedAt = DateTime.Parse("2020-06-25 07:58:56")
                    },
                    new OrderDetail
                    {
                        OrderDetailId = 1,
                        OrderId = "DH003",
                        BookId = "S002",
                        Quantity = 1,
                        Price = 54000,
                        CreatedAt = DateTime.Parse("2020-06-25 08:02:14")
                    },
                    new OrderDetail
                    {
                        OrderDetailId = 1,
                        OrderId = "DH004",
                        BookId = "S001",
                        Quantity = 2,
                        Price = 299000,
                        CreatedAt = DateTime.Parse("2020-06-26 10:01:49")
                    },
                    new OrderDetail
                    {
                        OrderDetailId = 1,
                        OrderId = "DH005",
                        BookId = "S001",
                        Quantity = 1,
                        Price = 299000,
                        CreatedAt = DateTime.Parse("2020-06-26 12:48:04")
                    },
                    new OrderDetail
                    {
                        OrderDetailId = 1,
                        OrderId = "DH006",
                        BookId = "S001",
                        Quantity = 1,
                        Price = 299000,
                        CreatedAt = DateTime.Parse("2020-06-30 10:38:54")
                    },
                    new OrderDetail
                    {
                        OrderDetailId = 1,
                        OrderId = "DH007",
                        BookId = "S038",
                        Quantity = 1,
                        Price = 39000,
                        CreatedAt = DateTime.Parse("2020-06-30 20:13:12")
                    },
                    new OrderDetail
                    {
                        OrderDetailId = 1,
                        OrderId = "DH008",
                        BookId = "S015",
                        Quantity = 1,
                        Price = 56000,
                        CreatedAt = DateTime.Parse("2020-06-30 20:15:12")
                    },
                    new OrderDetail
                    {
                        OrderDetailId = 1,
                        OrderId = "DH009",
                        BookId = "S013",
                        Quantity = 1,
                        Price = 51000,
                        CreatedAt = DateTime.Parse("2020-06-30 20:16:09")
                    },
                    new OrderDetail
                    {
                        OrderDetailId = 1,
                        OrderId = "DH010",
                        BookId = "S019",
                        Quantity = 2,
                        Price = 45000,
                        CreatedAt = DateTime.Parse("2020-06-30 20:18:46")
                    },
                    new OrderDetail
                    {
                        OrderDetailId = 1,
                        OrderId = "DH011",
                        BookId = "S032",
                        Quantity = 1,
                        Price = 90000,
                        CreatedAt = DateTime.Parse("2020-06-30 21:00:38")
                    },
                    new OrderDetail
                    {
                        OrderDetailId = 1,
                        OrderId = "DH012",
                        BookId = "S010",
                        Quantity = 1,
                        Price = 35000,
                        CreatedAt = DateTime.Parse("2020-06-30 22:22:20")
                    },
                    new OrderDetail
                    {
                        OrderDetailId = 1,
                        OrderId = "DH013",
                        BookId = "S004",
                        Quantity = 1,
                        Price = 34000,
                        CreatedAt = DateTime.Parse("2020-06-30 22:23:53")
                    },
                    new OrderDetail
                    {
                        OrderDetailId = 1,
                        OrderId = "DH014",
                        BookId = "S034",
                        Quantity = 1,
                        Price = 277000,
                        CreatedAt = DateTime.Parse("2020-06-30 22:24:38")
                    },
                    new OrderDetail
                    {
                        OrderDetailId = 1,
                        OrderId = "DH015",
                        BookId = "S040",
                        Quantity = 2,
                        Price = 38000,
                        CreatedAt = DateTime.Parse("2020-06-30 22:26:29")
                    },
                    new OrderDetail
                    {
                        OrderDetailId = 1,
                        OrderId = "DH016",
                        BookId = "S004",
                        Quantity = 2,
                        Price = 34000,
                        CreatedAt = DateTime.Parse("2020-07-01 09:25:06")
                    },
                    new OrderDetail
                    {
                        OrderDetailId = 1,
                        OrderId = "DH017",
                        BookId = "S007",
                        Quantity = 1,
                        Price = 59000,
                        CreatedAt = DateTime.Parse("2020-07-01 09:25:28")
                    },
                    new OrderDetail
                    {
                        OrderDetailId = 1,
                        OrderId = "DH018",
                        BookId = "S050",
                        Quantity = 1,
                        Price = 149000,
                        CreatedAt = DateTime.Parse("2020-07-01 09:27:28")
                    },
                    new OrderDetail
                    {
                        OrderDetailId = 1,
                        OrderId = "DH019",
                        BookId = "S016",
                        Quantity = 2,
                        Price = 67000,
                        CreatedAt = DateTime.Parse("2020-07-01 09:27:54")
                    },
                    new OrderDetail
                    {
                        OrderDetailId = 1,
                        OrderId = "DH020",
                        BookId = "S008",
                        Quantity = 3,
                        Price = 50000,
                        CreatedAt = DateTime.Parse("2019-07-01 09:41:31")
                    },
                    new OrderDetail
                    {
                        OrderDetailId = 1,
                        OrderId = "DH021",
                        BookId = "S021",
                        Quantity = 1,
                        Price = 62000,
                        CreatedAt = DateTime.Parse("2019-07-01 09:45:03")
                    },
                    new OrderDetail
                    {
                        OrderDetailId = 1,
                        OrderId = "DH022",
                        BookId = "S024",
                        Quantity = 1,
                        Price = 54000,
                        CreatedAt = DateTime.Parse("2020-07-01 09:47:02")
                    },
                    new OrderDetail
                    {
                        OrderDetailId = 1,
                        OrderId = "DH023",
                        BookId = "S047",
                        Quantity = 1,
                        Price = 65000,
                        CreatedAt = DateTime.Parse("2020-07-01 09:48:24")
                    },
                    new OrderDetail
                    {
                        OrderDetailId = 1,
                        OrderId = "DH024",
                        BookId = "S004",
                        Quantity = 1,
                        Price = 34000,
                        CreatedAt = DateTime.Parse("2020-07-01 09:49:55")
                    },
                    new OrderDetail
                    {
                        OrderDetailId = 1,
                        OrderId = "DH025",
                        BookId = "S021",
                        Quantity = 1,
                        Price = 62000,
                        CreatedAt = DateTime.Parse("2020-07-01 09:51:39")
                    },
                    new OrderDetail
                    {
                        OrderDetailId = 1,
                        OrderId = "DH026",
                        BookId = "S005",
                        Quantity = 1,
                        Price = 60000,
                        CreatedAt = DateTime.Parse("2019-07-31 10:02:47")
                    },
                    new OrderDetail
                    {
                        OrderDetailId = 1,
                        OrderId = "DH027",
                        BookId = "S002",
                        Quantity = 1,
                        Price = 54000,
                        CreatedAt = DateTime.Parse("2020-07-02 08:53:00")
                    },
                    new OrderDetail
                    {
                        OrderDetailId = 1,
                        OrderId = "DH028",
                        BookId = "S011",
                        Quantity = 1,
                        Price = 83000,
                        CreatedAt = DateTime.Parse("2019-11-23 12:33:10")
                    },
                    new OrderDetail
                    {
                        OrderDetailId = 1,
                        OrderId = "DH029",
                        BookId = "S004",
                        Quantity = 2,
                        Price = 34000,
                        CreatedAt = DateTime.Parse("2019-11-24 12:33:40")
                    },
                    new OrderDetail
                    {
                        OrderDetailId = 1,
                        OrderId = "DH030",
                        BookId = "S004",
                        Quantity = 1,
                        Price = 34000,
                        CreatedAt = DateTime.Parse("2020-10-20 22:29:11")
                    },
                    new OrderDetail
                    {
                        OrderDetailId = 2,
                        OrderId = "DH001",
                        BookId = "S046",
                        Quantity = 1,
                        Price = 54000,
                        CreatedAt = DateTime.Parse("2020-06-25 05:47:07")
                    },
                    new OrderDetail
                    {
                        OrderDetailId = 2,
                        OrderId = "DH002",
                        BookId = "S018",
                        Quantity = 1,
                        Price = 52000,
                        CreatedAt = DateTime.Parse("2020-06-25 07:58:56")
                    },
                    new OrderDetail
                    {
                        OrderDetailId = 2,
                        OrderId = "DH003",
                        BookId = "S021",
                        Quantity = 1,
                        Price = 62000,
                        CreatedAt = DateTime.Parse("2020-06-25 08:02:14")
                    },
                    new OrderDetail
                    {
                        OrderDetailId = 2,
                        OrderId = "DH005",
                        BookId = "S008",
                        Quantity = 2,
                        Price = 50000,
                        CreatedAt = DateTime.Parse("2020-06-26 12:48:04")
                    },
                    new OrderDetail
                    {
                        OrderDetailId = 2,
                        OrderId = "DH006",
                        BookId = "S010",
                        Quantity = 1,
                        Price = 35000,
                        CreatedAt = DateTime.Parse("2020-06-30 10:38:54")
                    },
                    new OrderDetail
                    {
                        OrderDetailId = 2,
                        OrderId = "DH007",
                        BookId = "S044",
                        Quantity = 2,
                        Price = 44000,
                        CreatedAt = DateTime.Parse("2020-06-30 20:13:12")
                    },
                    new OrderDetail
                    {
                        OrderDetailId = 2,
                        OrderId = "DH008",
                        BookId = "S027",
                        Quantity = 1,
                        Price = 55000,
                        CreatedAt = DateTime.Parse("2020-06-30 20:15:12")
                    },
                    new OrderDetail
                    {
                        OrderDetailId = 2,
                        OrderId = "DH009",
                        BookId = "S014",
                        Quantity = 1,
                        Price = 64000,
                        CreatedAt = DateTime.Parse("2020-06-30 20:16:09")
                    },
                    new OrderDetail
                    {
                        OrderDetailId = 2,
                        OrderId = "DH012",
                        BookId = "S022",
                        Quantity = 1,
                        Price = 53000,
                        CreatedAt = DateTime.Parse("2020-06-30 22:22:20")
                    },
                    new OrderDetail
                    {
                        OrderDetailId = 2,
                        OrderId = "DH013",
                        BookId = "S021",
                        Quantity = 1,
                        Price = 62000,
                        CreatedAt = DateTime.Parse("2020-06-30 22:23:53")
                    },
                    new OrderDetail
                    {
                        OrderDetailId = 2,
                        OrderId = "DH014",
                        BookId = "S037",
                        Quantity = 1,
                        Price = 77000,
                        CreatedAt = DateTime.Parse("2020-06-30 22:24:38")
                    },
                    new OrderDetail
                    {
                        OrderDetailId = 2,
                        OrderId = "DH015",
                        BookId = "S050",
                        Quantity = 1,
                        Price = 149000,
                        CreatedAt = DateTime.Parse("2020-06-30 22:26:29")
                    },
                    new OrderDetail
                    {
                        OrderDetailId = 2,
                        OrderId = "DH016",
                        BookId = "S012",
                        Quantity = 1,
                        Price = 70000,
                        CreatedAt = DateTime.Parse("2020-07-01 09:25:06")
                    },
                    new OrderDetail
                    {
                        OrderDetailId = 2,
                        OrderId = "DH018",
                        BookId = "S051",
                        Quantity = 1,
                        Price = 189000,
                        CreatedAt = DateTime.Parse("2020-07-01 09:27:28")
                    },
                    new OrderDetail
                    {
                        OrderDetailId = 2,
                        OrderId = "DH021",
                        BookId = "S023",
                        Quantity = 3,
                        Price = 48000,
                        CreatedAt = DateTime.Parse("2019-07-01 09:45:03")
                    },
                    new OrderDetail
                    {
                        OrderDetailId = 2,
                        OrderId = "DH022",
                        BookId = "S040",
                        Quantity = 1,
                        Price = 38000,
                        CreatedAt = DateTime.Parse("2020-07-01 09:47:02")
                    },
                    new OrderDetail
                    {
                        OrderDetailId = 2,
                        OrderId = "DH023",
                        BookId = "S048",
                        Quantity = 2,
                        Price = 77000,
                        CreatedAt = DateTime.Parse("2020-07-01 09:48:24")
                    },
                    new OrderDetail
                    {
                        OrderDetailId = 2,
                        OrderId = "DH024",
                        BookId = "S005",
                        Quantity = 1,
                        Price = 60000,
                        CreatedAt = DateTime.Parse("2020-07-01 09:49:55")
                    },
                    new OrderDetail
                    {
                        OrderDetailId = 2,
                        OrderId = "DH025",
                        BookId = "S022",
                        Quantity = 1,
                        Price = 53000,
                        CreatedAt = DateTime.Parse("2020-07-01 09:51:39")
                    },
                    new OrderDetail
                    {
                        OrderDetailId = 2,
                        OrderId = "DH027",
                        BookId = "S012",
                        Quantity = 1,
                        Price = 70000,
                        CreatedAt = DateTime.Parse("2020-07-02 08:53:00")
                    },
                    new OrderDetail
                    {
                        OrderDetailId = 2,
                        OrderId = "DH028",
                        BookId = "S031",
                        Quantity = 1,
                        Price = 117000,
                        CreatedAt = DateTime.Parse("2019-11-23 12:33:10")
                    },
                    new OrderDetail
                    {
                        OrderDetailId = 2,
                        OrderId = "DH029",
                        BookId = "S013",
                        Quantity = 1,
                        Price = 51000,
                        CreatedAt = DateTime.Parse("2019-11-24 12:33:40")
                    },
                    new OrderDetail
                    {
                        OrderDetailId = 2,
                        OrderId = "DH030",
                        BookId = "S002",
                        Quantity = 2,
                        Price = 51000,
                        CreatedAt = DateTime.Parse("2020-10-20 22:29:11")
                    },
                    new OrderDetail
                    {
                        OrderDetailId = 3,
                        OrderId = "DH001",
                        BookId = "S005",
                        Quantity = 1,
                        Price = 60000,
                        CreatedAt = DateTime.Parse("2020-06-25 05:47:07")
                    },
                    new OrderDetail
                    {
                        OrderDetailId = 3,
                        OrderId = "DH003",
                        BookId = "S035",
                        Quantity = 1,
                        Price = 90000,
                        CreatedAt = DateTime.Parse("2020-06-25 08:02:14")
                    },
                    new OrderDetail
                    {
                        OrderDetailId = 3,
                        OrderId = "DH005",
                        BookId = "S018",
                        Quantity = 4,
                        Price = 52000,
                        CreatedAt = DateTime.Parse("2020-06-26 12:48:04")
                    },
                    new OrderDetail
                    {
                        OrderDetailId = 3,
                        OrderId = "DH006",
                        BookId = "S012",
                        Quantity = 1,
                        Price = 70000,
                        CreatedAt = DateTime.Parse("2020-06-30 10:38:54")
                    },
                    new OrderDetail
                    {
                        OrderDetailId = 3,
                        OrderId = "DH009",
                        BookId = "S012",
                        Quantity = 1,
                        Price = 70000,
                        CreatedAt = DateTime.Parse("2020-06-30 20:16:09")
                    },
                    new OrderDetail
                    {
                        OrderDetailId = 3,
                        OrderId = "DH012",
                        BookId = "S023",
                        Quantity = 1,
                        Price = 48000,
                        CreatedAt = DateTime.Parse("2020-06-30 22:22:20")
                    },
                    new OrderDetail
                    {
                        OrderDetailId = 3,
                        OrderId = "DH013",
                        BookId = "S025",
                        Quantity = 1,
                        Price = 36000,
                        CreatedAt = DateTime.Parse("2020-06-30 22:23:53")
                    },
                    new OrderDetail
                    {
                        OrderDetailId = 3,
                        OrderId = "DH015",
                        BookId = "S053",
                        Quantity = 1,
                        Price = 40000,
                        CreatedAt = DateTime.Parse("2020-06-30 22:26:29")
                    },
                    new OrderDetail
                    {
                        OrderDetailId = 3,
                        OrderId = "DH021",
                        BookId = "S025",
                        Quantity = 1,
                        Price = 36000,
                        CreatedAt = DateTime.Parse("2019-07-01 09:45:03")
                    },
                    new OrderDetail
                    {
                        OrderDetailId = 3,
                        OrderId = "DH022",
                        BookId = "S053",
                        Quantity = 1,
                        Price = 40000,
                        CreatedAt = DateTime.Parse("2020-07-01 09:47:02")
                    },
                    new OrderDetail
                    {
                        OrderDetailId = 3,
                        OrderId = "DH030",
                        BookId = "S021",
                        Quantity = 2,
                        Price = 62000,
                        CreatedAt = DateTime.Parse("2020-10-20 22:29:11")
                    },
                    new OrderDetail
                    {
                        OrderDetailId = 4,
                        OrderId = "DH006",
                        BookId = "S005",
                        Quantity = 1,
                        Price = 60000,
                        CreatedAt = DateTime.Parse("2020-06-30 10:38:54")
                    },
                    new OrderDetail
                    {
                        OrderDetailId = 4,
                        OrderId = "DH009",
                        BookId = "S011",
                        Quantity = 1,
                        Price = 83000,
                        CreatedAt = DateTime.Parse("2020-06-30 20:16:09")
                    },
                    new OrderDetail
                    {
                        OrderDetailId = 4,
                        OrderId = "DH013",
                        BookId = "S046",
                        Quantity = 1,
                        Price = 54000,
                        CreatedAt = DateTime.Parse("2020-06-30 22:23:53")
                    },
                    new OrderDetail
                    {
                        OrderDetailId = 4,
                        OrderId = "DH022",
                        BookId = "S054",
                        Quantity = 1,
                        Price = 84000,
                        CreatedAt = DateTime.Parse("2020-07-01 09:47:02")
                    },
                    new OrderDetail
                    {
                        OrderDetailId = 4,
                        OrderId = "DH030",
                        BookId = "S048",
                        Quantity = 1,
                        Price = 77000,
                        CreatedAt = DateTime.Parse("2020-10-20 22:29:11")
                    },
                    new OrderDetail
                    {
                        OrderDetailId = 5,
                        OrderId = "DH006",
                        BookId = "S032",
                        Quantity = 1,
                        Price = 90000,
                        CreatedAt = DateTime.Parse("2020-06-30 10:38:54")
                    },
                    new OrderDetail
                    {
                        OrderDetailId = 6,
                        OrderId = "DH006",
                        BookId = "S039",
                        Quantity = 1,
                        Price = 90000,
                        CreatedAt = DateTime.Parse("2020-06-30 10:38:54")
                    },
                    new OrderDetail
                    {
                        OrderDetailId = 7,
                        OrderId = "DH006",
                        BookId = "S044",
                        Quantity = 1,
                        Price = 44000,
                        CreatedAt = DateTime.Parse("2020-06-30 10:38:54")
                    },
                    new OrderDetail
                    {
                        OrderDetailId = 8,
                        OrderId = "DH006",
                        BookId = "S042",
                        Quantity = 1,
                        Price = 79000,
                        CreatedAt = DateTime.Parse("2020-06-30 10:38:54")
                    },
                    new OrderDetail
                    {
                        OrderDetailId = 9,
                        OrderId = "DH006",
                        BookId = "S002",
                        Quantity = 1,
                        Price = 54000,
                        CreatedAt = DateTime.Parse("2020-06-30 10:38:54")
                    }
                );
            #endregion

            #region Cart
            modelBuilder.Entity<Cart>()
                .HasData(
                    new Cart
                    {
                        Id = 1,
                        CustomerId = "KH003",
                        IsActive = 1,
                        CreatedAt = DateTime.Parse("2020-12-04 05:50:20")
                    },
                    new Cart
                    {
                        Id = 2,
                        CustomerId = "KH021",
                        IsActive = 1,
                        CreatedAt = DateTime.Parse("2020-12-04 06:27:20")
                    },
                    new Cart
                    {
                        Id = 3,
                        CustomerId = "KH002",
                        IsActive = 1,
                        CreatedAt = DateTime.Parse("2020-12-04 07:07:20")
                    }
                );
            #endregion

            #region CartItems
            modelBuilder.Entity<CartItems>()
                .HasData(
                    new CartItems
                    {
                        CartId = 1,
                        BookId = "S001",
                        Quantity = 1,
                        CreatedAt = DateTime.Parse("2020-12-04 07:07:20"),
                        UpdatedAt = DateTime.Parse("2020-12-04 07:07:20"),
                        IsSelected = 0
                    },
                    new CartItems
                    {
                        CartId = 2,
                        BookId = "S011",
                        Quantity = 1,
                        CreatedAt = DateTime.Parse("2020-12-04 07:07:20"),
                        UpdatedAt = DateTime.Parse("2020-12-04 07:07:20"),
                        IsSelected = 0
                    },
                    new CartItems
                    {
                        CartId = 3,
                        BookId = "S003",
                        Quantity = 1,
                        CreatedAt = DateTime.Parse("2020-12-04 07:07:20"),
                        UpdatedAt = DateTime.Parse("2020-12-04 07:07:20"),
                        IsSelected = 0
                    }
                );
            #endregion

        }
    }
}
