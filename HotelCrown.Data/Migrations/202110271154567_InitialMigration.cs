namespace HotelCrown.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Local = c.Boolean(nullable: false),
                        FullName = c.String(maxLength: 70),
                        IdentityNumber = c.String(maxLength: 11),
                        PhoneNumber = c.String(maxLength: 15),
                        BirthDate = c.DateTime(nullable: false),
                        Gender = c.Boolean(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CheckInDate = c.DateTime(nullable: false),
                        CheckOutDate = c.DateTime(nullable: false),
                        CheckedInTime = c.DateTime(),
                        CheckedOutTime = c.DateTime(),
                        IsPaid = c.Boolean(nullable: false),
                        IsPaidServices = c.Boolean(nullable: false),
                        RoomId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Rooms", t => t.RoomId, cascadeDelete: true)
                .Index(t => t.RoomId);
            
            CreateTable(
                "dbo.ReservationServices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ReservationId = c.Int(nullable: false),
                        ServiceId = c.Int(nullable: false),
                        ServiceName = c.String(),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Quantity = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Reservations", t => t.ReservationId, cascadeDelete: true)
                .ForeignKey("dbo.Services", t => t.ServiceId, cascadeDelete: true)
                .Index(t => t.ReservationId)
                .Index(t => t.ServiceId);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ServiceName = c.String(maxLength: 70),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoomName = c.String(maxLength: 70),
                        Capacity = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Features",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FeatureName = c.String(maxLength: 70),
                        IsStandard = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ReservationCustomers",
                c => new
                    {
                        Reservation_Id = c.Int(nullable: false),
                        Customer_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Reservation_Id, t.Customer_Id })
                .ForeignKey("dbo.Reservations", t => t.Reservation_Id, cascadeDelete: true)
                .ForeignKey("dbo.Customers", t => t.Customer_Id, cascadeDelete: true)
                .Index(t => t.Reservation_Id)
                .Index(t => t.Customer_Id);
            
            CreateTable(
                "dbo.FeatureRooms",
                c => new
                    {
                        Feature_Id = c.Int(nullable: false),
                        Room_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Feature_Id, t.Room_Id })
                .ForeignKey("dbo.Features", t => t.Feature_Id, cascadeDelete: true)
                .ForeignKey("dbo.Rooms", t => t.Room_Id, cascadeDelete: true)
                .Index(t => t.Feature_Id)
                .Index(t => t.Room_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservations", "RoomId", "dbo.Rooms");
            DropForeignKey("dbo.FeatureRooms", "Room_Id", "dbo.Rooms");
            DropForeignKey("dbo.FeatureRooms", "Feature_Id", "dbo.Features");
            DropForeignKey("dbo.ReservationServices", "ServiceId", "dbo.Services");
            DropForeignKey("dbo.ReservationServices", "ReservationId", "dbo.Reservations");
            DropForeignKey("dbo.ReservationCustomers", "Customer_Id", "dbo.Customers");
            DropForeignKey("dbo.ReservationCustomers", "Reservation_Id", "dbo.Reservations");
            DropIndex("dbo.FeatureRooms", new[] { "Room_Id" });
            DropIndex("dbo.FeatureRooms", new[] { "Feature_Id" });
            DropIndex("dbo.ReservationCustomers", new[] { "Customer_Id" });
            DropIndex("dbo.ReservationCustomers", new[] { "Reservation_Id" });
            DropIndex("dbo.ReservationServices", new[] { "ServiceId" });
            DropIndex("dbo.ReservationServices", new[] { "ReservationId" });
            DropIndex("dbo.Reservations", new[] { "RoomId" });
            DropTable("dbo.FeatureRooms");
            DropTable("dbo.ReservationCustomers");
            DropTable("dbo.Features");
            DropTable("dbo.Rooms");
            DropTable("dbo.Services");
            DropTable("dbo.ReservationServices");
            DropTable("dbo.Reservations");
            DropTable("dbo.Customers");
        }
    }
}
