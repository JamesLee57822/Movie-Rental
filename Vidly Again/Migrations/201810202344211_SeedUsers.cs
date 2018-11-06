namespace Vidly_Again.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'00b30405-3e1f-4b74-b7b9-b1f36966b772', N'jameslee57822@gmail.com', 0, N'ABybDxOas56bMKWc3KNHKmuODO1LHQ1PNPUS2mts1/Xzunz9Ixpkhus9xgrWKnhQEg==', N'13270fab-9a7e-42b8-ba35-566908e2ec4c', NULL, 0, 0, NULL, 1, 0, N'jameslee57822@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'8a8e45cf-ea93-4ef3-898e-97715c07830e', N'admin@vidly.com', 0, N'ACyR60xl2GpF4PpJ5CBCqyc2l+IEVi5obZ2DzqQMPpzZ26pcOK6Cj39BjNw7sQjyUg==', N'31561bdd-b6c7-4367-a63a-769dd4a46df4', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'a5c2180f-f5ae-4cd5-b5f7-4094879ff228', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'8a8e45cf-ea93-4ef3-898e-97715c07830e', N'a5c2180f-f5ae-4cd5-b5f7-4094879ff228')
");
        }
        
        public override void Down()
        {
        }
    }
}
