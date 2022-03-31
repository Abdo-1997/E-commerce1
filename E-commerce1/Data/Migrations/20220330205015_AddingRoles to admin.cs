using Microsoft.EntityFrameworkCore.Migrations;

namespace E_commerce1.Data.Migrations
{
    public partial class AddingRolestoadmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [dbo].[usersroles] (UserId,RoleID) SELECT '717df042-228c-42f0-b056-5d258e0369ba' , Id From [dbo].[roles]");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [dbo].[usersroles] Where UserId='717df042-228c-42f0-b056-5d258e0369ba'");
        }
    }
}
