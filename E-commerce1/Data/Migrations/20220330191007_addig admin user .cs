using Microsoft.EntityFrameworkCore.Migrations;

namespace E_commerce1.Data.Migrations
{
    public partial class addigadminuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [dbo].[users] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [FirstName], [LastName]) VALUES (N'717df042-228c-42f0-b056-5d258e0369ba', N'admin', N'ADMIN', N'admin@mail.com', N'ADMIN@MAIL.COM', 0, N'AQAAAAEAACcQAAAAEAmmExs65/0yab3CAo765r/zGoc+9TQOOMA76UwtrG4Sv2JluQfdD6C9OBblXCSn4A==', N'TO4MKKUKVH3E62CB5DKQCHPJEH3DLRSM', N'005e4c4d-fa64-4ab8-a4f4-7ca27e764ce1', NULL, 0, 0, NULL, 1, 0, N'admin', N'admin')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from [dbo].[users] WHERE  [Id] = '717df042-228c-42f0-b056-5d258e0369ba'");
        }
    }
}
