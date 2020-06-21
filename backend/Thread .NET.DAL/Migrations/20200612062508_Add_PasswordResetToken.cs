using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Thread_.NET.DAL.Migrations
{
    public partial class Add_PasswordResetToken : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PasswordResetTokens",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    Token = table.Column<string>(nullable: true),
                    Expires = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PasswordResetTokens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PasswordResetTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "CommentNegativeReactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CommentId", "CreatedAt", "IsDislike", "UpdatedAt", "UserId" },
                values: new object[] { 12, new DateTime(2020, 6, 12, 9, 25, 7, 434, DateTimeKind.Local).AddTicks(328), false, new DateTime(2020, 6, 12, 9, 25, 7, 434, DateTimeKind.Local).AddTicks(1192), 7 });

            migrationBuilder.UpdateData(
                table: "CommentNegativeReactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 14, new DateTime(2020, 6, 12, 9, 25, 7, 434, DateTimeKind.Local).AddTicks(1861), new DateTime(2020, 6, 12, 9, 25, 7, 434, DateTimeKind.Local).AddTicks(1880), 21 });

            migrationBuilder.UpdateData(
                table: "CommentNegativeReactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CommentId", "CreatedAt", "IsDislike", "UpdatedAt", "UserId" },
                values: new object[] { 1, new DateTime(2020, 6, 12, 9, 25, 7, 434, DateTimeKind.Local).AddTicks(1925), true, new DateTime(2020, 6, 12, 9, 25, 7, 434, DateTimeKind.Local).AddTicks(1930), 13 });

            migrationBuilder.UpdateData(
                table: "CommentNegativeReactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 2, new DateTime(2020, 6, 12, 9, 25, 7, 434, DateTimeKind.Local).AddTicks(1958), new DateTime(2020, 6, 12, 9, 25, 7, 434, DateTimeKind.Local).AddTicks(1963), 7 });

            migrationBuilder.UpdateData(
                table: "CommentNegativeReactions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 10, new DateTime(2020, 6, 12, 9, 25, 7, 434, DateTimeKind.Local).AddTicks(1987), new DateTime(2020, 6, 12, 9, 25, 7, 434, DateTimeKind.Local).AddTicks(1992), 20 });

            migrationBuilder.UpdateData(
                table: "CommentNegativeReactions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CommentId", "CreatedAt", "IsDislike", "UpdatedAt", "UserId" },
                values: new object[] { 20, new DateTime(2020, 6, 12, 9, 25, 7, 434, DateTimeKind.Local).AddTicks(2017), false, new DateTime(2020, 6, 12, 9, 25, 7, 434, DateTimeKind.Local).AddTicks(2022), 11 });

            migrationBuilder.UpdateData(
                table: "CommentNegativeReactions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 2, new DateTime(2020, 6, 12, 9, 25, 7, 434, DateTimeKind.Local).AddTicks(2045), new DateTime(2020, 6, 12, 9, 25, 7, 434, DateTimeKind.Local).AddTicks(2050), 9 });

            migrationBuilder.UpdateData(
                table: "CommentNegativeReactions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CommentId", "CreatedAt", "IsDislike", "UpdatedAt", "UserId" },
                values: new object[] { 19, new DateTime(2020, 6, 12, 9, 25, 7, 434, DateTimeKind.Local).AddTicks(2075), false, new DateTime(2020, 6, 12, 9, 25, 7, 434, DateTimeKind.Local).AddTicks(2080), 19 });

            migrationBuilder.UpdateData(
                table: "CommentNegativeReactions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 15, new DateTime(2020, 6, 12, 9, 25, 7, 434, DateTimeKind.Local).AddTicks(2102), new DateTime(2020, 6, 12, 9, 25, 7, 434, DateTimeKind.Local).AddTicks(2107), 13 });

            migrationBuilder.UpdateData(
                table: "CommentNegativeReactions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 18, new DateTime(2020, 6, 12, 9, 25, 7, 434, DateTimeKind.Local).AddTicks(2248), new DateTime(2020, 6, 12, 9, 25, 7, 434, DateTimeKind.Local).AddTicks(2254), 6 });

            migrationBuilder.UpdateData(
                table: "CommentNegativeReactions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 13, new DateTime(2020, 6, 12, 9, 25, 7, 434, DateTimeKind.Local).AddTicks(2280), new DateTime(2020, 6, 12, 9, 25, 7, 434, DateTimeKind.Local).AddTicks(2285), 14 });

            migrationBuilder.UpdateData(
                table: "CommentNegativeReactions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 11, new DateTime(2020, 6, 12, 9, 25, 7, 434, DateTimeKind.Local).AddTicks(2308), new DateTime(2020, 6, 12, 9, 25, 7, 434, DateTimeKind.Local).AddTicks(2313), 20 });

            migrationBuilder.UpdateData(
                table: "CommentNegativeReactions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CommentId", "CreatedAt", "IsDislike", "UpdatedAt", "UserId" },
                values: new object[] { 4, new DateTime(2020, 6, 12, 9, 25, 7, 434, DateTimeKind.Local).AddTicks(2338), true, new DateTime(2020, 6, 12, 9, 25, 7, 434, DateTimeKind.Local).AddTicks(2343), 1 });

            migrationBuilder.UpdateData(
                table: "CommentNegativeReactions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 9, new DateTime(2020, 6, 12, 9, 25, 7, 434, DateTimeKind.Local).AddTicks(2366), new DateTime(2020, 6, 12, 9, 25, 7, 434, DateTimeKind.Local).AddTicks(2371), 3 });

            migrationBuilder.UpdateData(
                table: "CommentNegativeReactions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 4, new DateTime(2020, 6, 12, 9, 25, 7, 434, DateTimeKind.Local).AddTicks(2393), new DateTime(2020, 6, 12, 9, 25, 7, 434, DateTimeKind.Local).AddTicks(2398), 8 });

            migrationBuilder.UpdateData(
                table: "CommentNegativeReactions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 16, new DateTime(2020, 6, 12, 9, 25, 7, 434, DateTimeKind.Local).AddTicks(2421), new DateTime(2020, 6, 12, 9, 25, 7, 434, DateTimeKind.Local).AddTicks(2426), 12 });

            migrationBuilder.UpdateData(
                table: "CommentNegativeReactions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 13, new DateTime(2020, 6, 12, 9, 25, 7, 434, DateTimeKind.Local).AddTicks(2448), new DateTime(2020, 6, 12, 9, 25, 7, 434, DateTimeKind.Local).AddTicks(2453), 6 });

            migrationBuilder.UpdateData(
                table: "CommentNegativeReactions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 14, new DateTime(2020, 6, 12, 9, 25, 7, 434, DateTimeKind.Local).AddTicks(2475), new DateTime(2020, 6, 12, 9, 25, 7, 434, DateTimeKind.Local).AddTicks(2480), 13 });

            migrationBuilder.UpdateData(
                table: "CommentNegativeReactions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 10, new DateTime(2020, 6, 12, 9, 25, 7, 434, DateTimeKind.Local).AddTicks(2501), new DateTime(2020, 6, 12, 9, 25, 7, 434, DateTimeKind.Local).AddTicks(2506), 7 });

            migrationBuilder.UpdateData(
                table: "CommentNegativeReactions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 7, new DateTime(2020, 6, 12, 9, 25, 7, 434, DateTimeKind.Local).AddTicks(2529), new DateTime(2020, 6, 12, 9, 25, 7, 434, DateTimeKind.Local).AddTicks(2534), 12 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 17, new DateTime(2020, 6, 12, 9, 25, 7, 427, DateTimeKind.Local).AddTicks(2057), new DateTime(2020, 6, 12, 9, 25, 7, 427, DateTimeKind.Local).AddTicks(2795), 12 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 18, new DateTime(2020, 6, 12, 9, 25, 7, 427, DateTimeKind.Local).AddTicks(3324), new DateTime(2020, 6, 12, 9, 25, 7, 427, DateTimeKind.Local).AddTicks(3383), 11 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 6, new DateTime(2020, 6, 12, 9, 25, 7, 427, DateTimeKind.Local).AddTicks(3422), false, new DateTime(2020, 6, 12, 9, 25, 7, 427, DateTimeKind.Local).AddTicks(3427), 21 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 6, new DateTime(2020, 6, 12, 9, 25, 7, 427, DateTimeKind.Local).AddTicks(3452), true, new DateTime(2020, 6, 12, 9, 25, 7, 427, DateTimeKind.Local).AddTicks(3457), 3 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 12, new DateTime(2020, 6, 12, 9, 25, 7, 427, DateTimeKind.Local).AddTicks(3482), new DateTime(2020, 6, 12, 9, 25, 7, 427, DateTimeKind.Local).AddTicks(3487), 21 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 9, new DateTime(2020, 6, 12, 9, 25, 7, 427, DateTimeKind.Local).AddTicks(3513), true, new DateTime(2020, 6, 12, 9, 25, 7, 427, DateTimeKind.Local).AddTicks(3517), 17 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 6, new DateTime(2020, 6, 12, 9, 25, 7, 427, DateTimeKind.Local).AddTicks(3542), new DateTime(2020, 6, 12, 9, 25, 7, 427, DateTimeKind.Local).AddTicks(3547), 7 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 14, new DateTime(2020, 6, 12, 9, 25, 7, 427, DateTimeKind.Local).AddTicks(3570), false, new DateTime(2020, 6, 12, 9, 25, 7, 427, DateTimeKind.Local).AddTicks(3574), 3 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 19, new DateTime(2020, 6, 12, 9, 25, 7, 427, DateTimeKind.Local).AddTicks(3597), new DateTime(2020, 6, 12, 9, 25, 7, 427, DateTimeKind.Local).AddTicks(3602), 3 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 18, new DateTime(2020, 6, 12, 9, 25, 7, 427, DateTimeKind.Local).AddTicks(3626), true, new DateTime(2020, 6, 12, 9, 25, 7, 427, DateTimeKind.Local).AddTicks(3631), 9 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 2, new DateTime(2020, 6, 12, 9, 25, 7, 427, DateTimeKind.Local).AddTicks(3655), new DateTime(2020, 6, 12, 9, 25, 7, 427, DateTimeKind.Local).AddTicks(3660), 10 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 11, new DateTime(2020, 6, 12, 9, 25, 7, 427, DateTimeKind.Local).AddTicks(3735), new DateTime(2020, 6, 12, 9, 25, 7, 427, DateTimeKind.Local).AddTicks(3740), 21 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 3, new DateTime(2020, 6, 12, 9, 25, 7, 427, DateTimeKind.Local).AddTicks(3767), false, new DateTime(2020, 6, 12, 9, 25, 7, 427, DateTimeKind.Local).AddTicks(3771), 15 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 13, new DateTime(2020, 6, 12, 9, 25, 7, 427, DateTimeKind.Local).AddTicks(3794), false, new DateTime(2020, 6, 12, 9, 25, 7, 427, DateTimeKind.Local).AddTicks(3799), 18 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 2, new DateTime(2020, 6, 12, 9, 25, 7, 427, DateTimeKind.Local).AddTicks(3822), true, new DateTime(2020, 6, 12, 9, 25, 7, 427, DateTimeKind.Local).AddTicks(3826), 4 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 5, new DateTime(2020, 6, 12, 9, 25, 7, 427, DateTimeKind.Local).AddTicks(3855), new DateTime(2020, 6, 12, 9, 25, 7, 427, DateTimeKind.Local).AddTicks(3859), 1 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 1, new DateTime(2020, 6, 12, 9, 25, 7, 427, DateTimeKind.Local).AddTicks(3895), true, new DateTime(2020, 6, 12, 9, 25, 7, 427, DateTimeKind.Local).AddTicks(3900), 10 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 427, DateTimeKind.Local).AddTicks(3924), false, new DateTime(2020, 6, 12, 9, 25, 7, 427, DateTimeKind.Local).AddTicks(3928), 16 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 9, new DateTime(2020, 6, 12, 9, 25, 7, 427, DateTimeKind.Local).AddTicks(3951), new DateTime(2020, 6, 12, 9, 25, 7, 427, DateTimeKind.Local).AddTicks(3956), 2 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 9, new DateTime(2020, 6, 12, 9, 25, 7, 427, DateTimeKind.Local).AddTicks(3978), new DateTime(2020, 6, 12, 9, 25, 7, 427, DateTimeKind.Local).AddTicks(3982), 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 21, "Ut sit unde quia optio neque cum qui voluptatem possimus.", new DateTime(2020, 6, 12, 9, 25, 7, 406, DateTimeKind.Local).AddTicks(1041), 18, new DateTime(2020, 6, 12, 9, 25, 7, 406, DateTimeKind.Local).AddTicks(1776) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 14, "Voluptates unde ullam dolor magni minima omnis deleniti.", new DateTime(2020, 6, 12, 9, 25, 7, 406, DateTimeKind.Local).AddTicks(2432), 19, new DateTime(2020, 6, 12, 9, 25, 7, 406, DateTimeKind.Local).AddTicks(2481) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "UpdatedAt" },
                values: new object[] { 17, "Doloremque consequuntur aut.", new DateTime(2020, 6, 12, 9, 25, 7, 406, DateTimeKind.Local).AddTicks(2614), new DateTime(2020, 6, 12, 9, 25, 7, 406, DateTimeKind.Local).AddTicks(2621) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 21, "Eius debitis magni exercitationem rem repellat aut magnam.", new DateTime(2020, 6, 12, 9, 25, 7, 406, DateTimeKind.Local).AddTicks(2694), 12, new DateTime(2020, 6, 12, 9, 25, 7, 406, DateTimeKind.Local).AddTicks(2700) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 7, "Facere blanditiis ad error vel est dolor et.", new DateTime(2020, 6, 12, 9, 25, 7, 406, DateTimeKind.Local).AddTicks(2769), 11, new DateTime(2020, 6, 12, 9, 25, 7, 406, DateTimeKind.Local).AddTicks(2774) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 3, "Eos hic et aliquam.", new DateTime(2020, 6, 12, 9, 25, 7, 406, DateTimeKind.Local).AddTicks(2823), 11, new DateTime(2020, 6, 12, 9, 25, 7, 406, DateTimeKind.Local).AddTicks(2829) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 12, "Sunt inventore et sed deleniti.", new DateTime(2020, 6, 12, 9, 25, 7, 406, DateTimeKind.Local).AddTicks(2882), 2, new DateTime(2020, 6, 12, 9, 25, 7, 406, DateTimeKind.Local).AddTicks(2887) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 16, "Ex odio omnis consectetur provident dolor cumque veritatis.", new DateTime(2020, 6, 12, 9, 25, 7, 406, DateTimeKind.Local).AddTicks(2954), 4, new DateTime(2020, 6, 12, 9, 25, 7, 406, DateTimeKind.Local).AddTicks(2960) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 1, "Praesentium est sint molestiae ad velit eos dicta.", new DateTime(2020, 6, 12, 9, 25, 7, 406, DateTimeKind.Local).AddTicks(3122), 4, new DateTime(2020, 6, 12, 9, 25, 7, 406, DateTimeKind.Local).AddTicks(3130) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 16, "Numquam eveniet deserunt a eum occaecati consequatur omnis reiciendis.", new DateTime(2020, 6, 12, 9, 25, 7, 406, DateTimeKind.Local).AddTicks(3204), 10, new DateTime(2020, 6, 12, 9, 25, 7, 406, DateTimeKind.Local).AddTicks(3210) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "UpdatedAt" },
                values: new object[] { 17, "Aliquam quod hic eos alias tenetur neque rerum.", new DateTime(2020, 6, 12, 9, 25, 7, 406, DateTimeKind.Local).AddTicks(3272), new DateTime(2020, 6, 12, 9, 25, 7, 406, DateTimeKind.Local).AddTicks(3277) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 8, "Inventore facilis illo dolores harum alias.", new DateTime(2020, 6, 12, 9, 25, 7, 406, DateTimeKind.Local).AddTicks(3333), 10, new DateTime(2020, 6, 12, 9, 25, 7, 406, DateTimeKind.Local).AddTicks(3339) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 14, "Omnis iste tempora.", new DateTime(2020, 6, 12, 9, 25, 7, 406, DateTimeKind.Local).AddTicks(3380), 12, new DateTime(2020, 6, 12, 9, 25, 7, 406, DateTimeKind.Local).AddTicks(3386) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { "Quibusdam dolor aliquam quia non ut asperiores.", new DateTime(2020, 6, 12, 9, 25, 7, 406, DateTimeKind.Local).AddTicks(3443), 6, new DateTime(2020, 6, 12, 9, 25, 7, 406, DateTimeKind.Local).AddTicks(3449) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 18, "Voluptas veritatis dolores dolores.", new DateTime(2020, 6, 12, 9, 25, 7, 406, DateTimeKind.Local).AddTicks(3565), 6, new DateTime(2020, 6, 12, 9, 25, 7, 406, DateTimeKind.Local).AddTicks(3571) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 7, "Ratione et provident.", new DateTime(2020, 6, 12, 9, 25, 7, 406, DateTimeKind.Local).AddTicks(3617), 7, new DateTime(2020, 6, 12, 9, 25, 7, 406, DateTimeKind.Local).AddTicks(3623) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 15, "Quia unde harum quis iure aspernatur.", new DateTime(2020, 6, 12, 9, 25, 7, 406, DateTimeKind.Local).AddTicks(3675), 11, new DateTime(2020, 6, 12, 9, 25, 7, 406, DateTimeKind.Local).AddTicks(3681) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { "Ut nihil nesciunt voluptatibus et.", new DateTime(2020, 6, 12, 9, 25, 7, 406, DateTimeKind.Local).AddTicks(3734), 18, new DateTime(2020, 6, 12, 9, 25, 7, 406, DateTimeKind.Local).AddTicks(3740) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 7, "Et facilis autem hic nemo earum quia.", new DateTime(2020, 6, 12, 9, 25, 7, 406, DateTimeKind.Local).AddTicks(3799), 5, new DateTime(2020, 6, 12, 9, 25, 7, 406, DateTimeKind.Local).AddTicks(3805) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 10, "Provident beatae modi et voluptatem.", new DateTime(2020, 6, 12, 9, 25, 7, 406, DateTimeKind.Local).AddTicks(3856), 16, new DateTime(2020, 6, 12, 9, 25, 7, 406, DateTimeKind.Local).AddTicks(3861) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 178, DateTimeKind.Local).AddTicks(2786), "https://s3.amazonaws.com/uifaces/faces/twitter/gonzalorobaina/128.jpg", new DateTime(2020, 6, 12, 9, 25, 7, 178, DateTimeKind.Local).AddTicks(7888) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 178, DateTimeKind.Local).AddTicks(8889), "https://s3.amazonaws.com/uifaces/faces/twitter/craighenneberry/128.jpg", new DateTime(2020, 6, 12, 9, 25, 7, 178, DateTimeKind.Local).AddTicks(8923) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 178, DateTimeKind.Local).AddTicks(8957), "https://s3.amazonaws.com/uifaces/faces/twitter/ariffsetiawan/128.jpg", new DateTime(2020, 6, 12, 9, 25, 7, 178, DateTimeKind.Local).AddTicks(8963) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 178, DateTimeKind.Local).AddTicks(8985), "https://s3.amazonaws.com/uifaces/faces/twitter/damenleeturks/128.jpg", new DateTime(2020, 6, 12, 9, 25, 7, 178, DateTimeKind.Local).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 178, DateTimeKind.Local).AddTicks(9010), "https://s3.amazonaws.com/uifaces/faces/twitter/elbuscainfo/128.jpg", new DateTime(2020, 6, 12, 9, 25, 7, 178, DateTimeKind.Local).AddTicks(9016) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 178, DateTimeKind.Local).AddTicks(9034), "https://s3.amazonaws.com/uifaces/faces/twitter/craighenneberry/128.jpg", new DateTime(2020, 6, 12, 9, 25, 7, 178, DateTimeKind.Local).AddTicks(9039) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 178, DateTimeKind.Local).AddTicks(9059), "https://s3.amazonaws.com/uifaces/faces/twitter/apriendeau/128.jpg", new DateTime(2020, 6, 12, 9, 25, 7, 178, DateTimeKind.Local).AddTicks(9064) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 178, DateTimeKind.Local).AddTicks(9084), "https://s3.amazonaws.com/uifaces/faces/twitter/russell_baylis/128.jpg", new DateTime(2020, 6, 12, 9, 25, 7, 178, DateTimeKind.Local).AddTicks(9089) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 178, DateTimeKind.Local).AddTicks(9110), "https://s3.amazonaws.com/uifaces/faces/twitter/j04ntoh/128.jpg", new DateTime(2020, 6, 12, 9, 25, 7, 178, DateTimeKind.Local).AddTicks(9115) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 178, DateTimeKind.Local).AddTicks(9134), "https://s3.amazonaws.com/uifaces/faces/twitter/mandalareopens/128.jpg", new DateTime(2020, 6, 12, 9, 25, 7, 178, DateTimeKind.Local).AddTicks(9139) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 178, DateTimeKind.Local).AddTicks(9160), "https://s3.amazonaws.com/uifaces/faces/twitter/chacky14/128.jpg", new DateTime(2020, 6, 12, 9, 25, 7, 178, DateTimeKind.Local).AddTicks(9164) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 178, DateTimeKind.Local).AddTicks(9183), "https://s3.amazonaws.com/uifaces/faces/twitter/lhausermann/128.jpg", new DateTime(2020, 6, 12, 9, 25, 7, 178, DateTimeKind.Local).AddTicks(9188) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 178, DateTimeKind.Local).AddTicks(9207), "https://s3.amazonaws.com/uifaces/faces/twitter/trueblood_33/128.jpg", new DateTime(2020, 6, 12, 9, 25, 7, 178, DateTimeKind.Local).AddTicks(9212) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 178, DateTimeKind.Local).AddTicks(9231), "https://s3.amazonaws.com/uifaces/faces/twitter/billyroshan/128.jpg", new DateTime(2020, 6, 12, 9, 25, 7, 178, DateTimeKind.Local).AddTicks(9236) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 178, DateTimeKind.Local).AddTicks(9255), "https://s3.amazonaws.com/uifaces/faces/twitter/edhenderson/128.jpg", new DateTime(2020, 6, 12, 9, 25, 7, 178, DateTimeKind.Local).AddTicks(9260) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 178, DateTimeKind.Local).AddTicks(9279), "https://s3.amazonaws.com/uifaces/faces/twitter/matt3224/128.jpg", new DateTime(2020, 6, 12, 9, 25, 7, 178, DateTimeKind.Local).AddTicks(9283) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 178, DateTimeKind.Local).AddTicks(9304), "https://s3.amazonaws.com/uifaces/faces/twitter/bartoszdawydzik/128.jpg", new DateTime(2020, 6, 12, 9, 25, 7, 178, DateTimeKind.Local).AddTicks(9309) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 178, DateTimeKind.Local).AddTicks(9328), "https://s3.amazonaws.com/uifaces/faces/twitter/adobi/128.jpg", new DateTime(2020, 6, 12, 9, 25, 7, 178, DateTimeKind.Local).AddTicks(9332) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 178, DateTimeKind.Local).AddTicks(9353), "https://s3.amazonaws.com/uifaces/faces/twitter/mastermindesign/128.jpg", new DateTime(2020, 6, 12, 9, 25, 7, 178, DateTimeKind.Local).AddTicks(9357) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 178, DateTimeKind.Local).AddTicks(9376), "https://s3.amazonaws.com/uifaces/faces/twitter/yecidsm/128.jpg", new DateTime(2020, 6, 12, 9, 25, 7, 178, DateTimeKind.Local).AddTicks(9381) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 184, DateTimeKind.Local).AddTicks(4121), "https://picsum.photos/640/480/?image=623", new DateTime(2020, 6, 12, 9, 25, 7, 184, DateTimeKind.Local).AddTicks(4937) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 184, DateTimeKind.Local).AddTicks(5217), "https://picsum.photos/640/480/?image=1023", new DateTime(2020, 6, 12, 9, 25, 7, 184, DateTimeKind.Local).AddTicks(5246) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 184, DateTimeKind.Local).AddTicks(5274), "https://picsum.photos/640/480/?image=997", new DateTime(2020, 6, 12, 9, 25, 7, 184, DateTimeKind.Local).AddTicks(5279) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 184, DateTimeKind.Local).AddTicks(5359), "https://picsum.photos/640/480/?image=924", new DateTime(2020, 6, 12, 9, 25, 7, 184, DateTimeKind.Local).AddTicks(5365) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 184, DateTimeKind.Local).AddTicks(5388), "https://picsum.photos/640/480/?image=449", new DateTime(2020, 6, 12, 9, 25, 7, 184, DateTimeKind.Local).AddTicks(5393) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 184, DateTimeKind.Local).AddTicks(5412), "https://picsum.photos/640/480/?image=333", new DateTime(2020, 6, 12, 9, 25, 7, 184, DateTimeKind.Local).AddTicks(5417) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 184, DateTimeKind.Local).AddTicks(5436), "https://picsum.photos/640/480/?image=886", new DateTime(2020, 6, 12, 9, 25, 7, 184, DateTimeKind.Local).AddTicks(5441) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 184, DateTimeKind.Local).AddTicks(5461), "https://picsum.photos/640/480/?image=95", new DateTime(2020, 6, 12, 9, 25, 7, 184, DateTimeKind.Local).AddTicks(5466) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 184, DateTimeKind.Local).AddTicks(5486), "https://picsum.photos/640/480/?image=778", new DateTime(2020, 6, 12, 9, 25, 7, 184, DateTimeKind.Local).AddTicks(5490) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 184, DateTimeKind.Local).AddTicks(5510), "https://picsum.photos/640/480/?image=266", new DateTime(2020, 6, 12, 9, 25, 7, 184, DateTimeKind.Local).AddTicks(5514) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 184, DateTimeKind.Local).AddTicks(5534), "https://picsum.photos/640/480/?image=944", new DateTime(2020, 6, 12, 9, 25, 7, 184, DateTimeKind.Local).AddTicks(5539) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 184, DateTimeKind.Local).AddTicks(5558), "https://picsum.photos/640/480/?image=626", new DateTime(2020, 6, 12, 9, 25, 7, 184, DateTimeKind.Local).AddTicks(5563) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 184, DateTimeKind.Local).AddTicks(5582), "https://picsum.photos/640/480/?image=1050", new DateTime(2020, 6, 12, 9, 25, 7, 184, DateTimeKind.Local).AddTicks(5587) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 184, DateTimeKind.Local).AddTicks(5607), "https://picsum.photos/640/480/?image=696", new DateTime(2020, 6, 12, 9, 25, 7, 184, DateTimeKind.Local).AddTicks(5611) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 184, DateTimeKind.Local).AddTicks(5631), "https://picsum.photos/640/480/?image=662", new DateTime(2020, 6, 12, 9, 25, 7, 184, DateTimeKind.Local).AddTicks(5636) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 184, DateTimeKind.Local).AddTicks(5656), "https://picsum.photos/640/480/?image=585", new DateTime(2020, 6, 12, 9, 25, 7, 184, DateTimeKind.Local).AddTicks(5660) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 184, DateTimeKind.Local).AddTicks(5680), "https://picsum.photos/640/480/?image=6", new DateTime(2020, 6, 12, 9, 25, 7, 184, DateTimeKind.Local).AddTicks(5685) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 184, DateTimeKind.Local).AddTicks(5745), "https://picsum.photos/640/480/?image=371", new DateTime(2020, 6, 12, 9, 25, 7, 184, DateTimeKind.Local).AddTicks(5750) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 184, DateTimeKind.Local).AddTicks(5770), "https://picsum.photos/640/480/?image=9", new DateTime(2020, 6, 12, 9, 25, 7, 184, DateTimeKind.Local).AddTicks(5775) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 184, DateTimeKind.Local).AddTicks(5795), "https://picsum.photos/640/480/?image=849", new DateTime(2020, 6, 12, 9, 25, 7, 184, DateTimeKind.Local).AddTicks(5800) });

            migrationBuilder.UpdateData(
                table: "PostNegativeReactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IsDislike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 420, DateTimeKind.Local).AddTicks(6192), true, 5, new DateTime(2020, 6, 12, 9, 25, 7, 420, DateTimeKind.Local).AddTicks(6921), 9 });

            migrationBuilder.UpdateData(
                table: "PostNegativeReactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "IsDislike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 420, DateTimeKind.Local).AddTicks(7453), false, 11, new DateTime(2020, 6, 12, 9, 25, 7, 420, DateTimeKind.Local).AddTicks(7469), 2 });

            migrationBuilder.UpdateData(
                table: "PostNegativeReactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "IsDislike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 420, DateTimeKind.Local).AddTicks(7508), true, 3, new DateTime(2020, 6, 12, 9, 25, 7, 420, DateTimeKind.Local).AddTicks(7513), 15 });

            migrationBuilder.UpdateData(
                table: "PostNegativeReactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "IsDislike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 420, DateTimeKind.Local).AddTicks(7542), true, 19, new DateTime(2020, 6, 12, 9, 25, 7, 420, DateTimeKind.Local).AddTicks(7547), 1 });

            migrationBuilder.UpdateData(
                table: "PostNegativeReactions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 420, DateTimeKind.Local).AddTicks(7571), 7, new DateTime(2020, 6, 12, 9, 25, 7, 420, DateTimeKind.Local).AddTicks(7576), 20 });

            migrationBuilder.UpdateData(
                table: "PostNegativeReactions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 420, DateTimeKind.Local).AddTicks(7599), 4, new DateTime(2020, 6, 12, 9, 25, 7, 420, DateTimeKind.Local).AddTicks(7604), 13 });

            migrationBuilder.UpdateData(
                table: "PostNegativeReactions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 420, DateTimeKind.Local).AddTicks(7628), 17, new DateTime(2020, 6, 12, 9, 25, 7, 420, DateTimeKind.Local).AddTicks(7632), 14 });

            migrationBuilder.UpdateData(
                table: "PostNegativeReactions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "IsDislike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 420, DateTimeKind.Local).AddTicks(7654), true, 13, new DateTime(2020, 6, 12, 9, 25, 7, 420, DateTimeKind.Local).AddTicks(7659), 2 });

            migrationBuilder.UpdateData(
                table: "PostNegativeReactions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 420, DateTimeKind.Local).AddTicks(7682), 12, new DateTime(2020, 6, 12, 9, 25, 7, 420, DateTimeKind.Local).AddTicks(7687), 19 });

            migrationBuilder.UpdateData(
                table: "PostNegativeReactions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "IsDislike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 420, DateTimeKind.Local).AddTicks(7710), false, 7, new DateTime(2020, 6, 12, 9, 25, 7, 420, DateTimeKind.Local).AddTicks(7715), 18 });

            migrationBuilder.UpdateData(
                table: "PostNegativeReactions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 420, DateTimeKind.Local).AddTicks(7737), 7, new DateTime(2020, 6, 12, 9, 25, 7, 420, DateTimeKind.Local).AddTicks(7742), 3 });

            migrationBuilder.UpdateData(
                table: "PostNegativeReactions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 420, DateTimeKind.Local).AddTicks(7764), 17, new DateTime(2020, 6, 12, 9, 25, 7, 420, DateTimeKind.Local).AddTicks(7768), 15 });

            migrationBuilder.UpdateData(
                table: "PostNegativeReactions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "IsDislike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 420, DateTimeKind.Local).AddTicks(7882), true, 8, new DateTime(2020, 6, 12, 9, 25, 7, 420, DateTimeKind.Local).AddTicks(7888), 7 });

            migrationBuilder.UpdateData(
                table: "PostNegativeReactions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "IsDislike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 420, DateTimeKind.Local).AddTicks(7914), false, 14, new DateTime(2020, 6, 12, 9, 25, 7, 420, DateTimeKind.Local).AddTicks(7919), 2 });

            migrationBuilder.UpdateData(
                table: "PostNegativeReactions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "IsDislike", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 420, DateTimeKind.Local).AddTicks(7942), true, new DateTime(2020, 6, 12, 9, 25, 7, 420, DateTimeKind.Local).AddTicks(7946), 14 });

            migrationBuilder.UpdateData(
                table: "PostNegativeReactions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "IsDislike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 420, DateTimeKind.Local).AddTicks(7967), true, 14, new DateTime(2020, 6, 12, 9, 25, 7, 420, DateTimeKind.Local).AddTicks(7972), 13 });

            migrationBuilder.UpdateData(
                table: "PostNegativeReactions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "IsDislike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 420, DateTimeKind.Local).AddTicks(7994), false, 13, new DateTime(2020, 6, 12, 9, 25, 7, 420, DateTimeKind.Local).AddTicks(7999), 4 });

            migrationBuilder.UpdateData(
                table: "PostNegativeReactions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 420, DateTimeKind.Local).AddTicks(8024), 1, new DateTime(2020, 6, 12, 9, 25, 7, 420, DateTimeKind.Local).AddTicks(8028), 5 });

            migrationBuilder.UpdateData(
                table: "PostNegativeReactions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 420, DateTimeKind.Local).AddTicks(8100), 7, new DateTime(2020, 6, 12, 9, 25, 7, 420, DateTimeKind.Local).AddTicks(8105), 17 });

            migrationBuilder.UpdateData(
                table: "PostNegativeReactions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 420, DateTimeKind.Local).AddTicks(8127), 4, new DateTime(2020, 6, 12, 9, 25, 7, 420, DateTimeKind.Local).AddTicks(8132), 5 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 413, DateTimeKind.Local).AddTicks(7059), 12, new DateTime(2020, 6, 12, 9, 25, 7, 413, DateTimeKind.Local).AddTicks(7856), 14 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 413, DateTimeKind.Local).AddTicks(8974), false, 19, new DateTime(2020, 6, 12, 9, 25, 7, 413, DateTimeKind.Local).AddTicks(9002), 13 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 413, DateTimeKind.Local).AddTicks(9102), 1, new DateTime(2020, 6, 12, 9, 25, 7, 413, DateTimeKind.Local).AddTicks(9111), 15 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 413, DateTimeKind.Local).AddTicks(9157), false, 20, new DateTime(2020, 6, 12, 9, 25, 7, 413, DateTimeKind.Local).AddTicks(9165), 15 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 413, DateTimeKind.Local).AddTicks(9210), 9, new DateTime(2020, 6, 12, 9, 25, 7, 413, DateTimeKind.Local).AddTicks(9219), 15 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 413, DateTimeKind.Local).AddTicks(9262), true, 10, new DateTime(2020, 6, 12, 9, 25, 7, 413, DateTimeKind.Local).AddTicks(9270), 19 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 413, DateTimeKind.Local).AddTicks(9310), 9, new DateTime(2020, 6, 12, 9, 25, 7, 413, DateTimeKind.Local).AddTicks(9319), 12 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 413, DateTimeKind.Local).AddTicks(9386), false, 9, new DateTime(2020, 6, 12, 9, 25, 7, 413, DateTimeKind.Local).AddTicks(9394), 13 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 413, DateTimeKind.Local).AddTicks(9440), 17, new DateTime(2020, 6, 12, 9, 25, 7, 413, DateTimeKind.Local).AddTicks(9448), 4 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 413, DateTimeKind.Local).AddTicks(9491), 2, new DateTime(2020, 6, 12, 9, 25, 7, 413, DateTimeKind.Local).AddTicks(9499), 10 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 413, DateTimeKind.Local).AddTicks(9539), 14, new DateTime(2020, 6, 12, 9, 25, 7, 413, DateTimeKind.Local).AddTicks(9547), 4 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 413, DateTimeKind.Local).AddTicks(9590), true, 20, new DateTime(2020, 6, 12, 9, 25, 7, 413, DateTimeKind.Local).AddTicks(9599), 12 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 413, DateTimeKind.Local).AddTicks(9641), true, 10, new DateTime(2020, 6, 12, 9, 25, 7, 413, DateTimeKind.Local).AddTicks(9650), 20 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 413, DateTimeKind.Local).AddTicks(9695), false, 6, new DateTime(2020, 6, 12, 9, 25, 7, 413, DateTimeKind.Local).AddTicks(9704), 5 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 413, DateTimeKind.Local).AddTicks(9749), new DateTime(2020, 6, 12, 9, 25, 7, 413, DateTimeKind.Local).AddTicks(9757), 9 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 413, DateTimeKind.Local).AddTicks(9802), true, 12, new DateTime(2020, 6, 12, 9, 25, 7, 413, DateTimeKind.Local).AddTicks(9810), 8 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 413, DateTimeKind.Local).AddTicks(9857), 8, new DateTime(2020, 6, 12, 9, 25, 7, 413, DateTimeKind.Local).AddTicks(9866), 17 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 413, DateTimeKind.Local).AddTicks(9911), false, 19, new DateTime(2020, 6, 12, 9, 25, 7, 413, DateTimeKind.Local).AddTicks(9922), 13 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 413, DateTimeKind.Local).AddTicks(9968), 1, new DateTime(2020, 6, 12, 9, 25, 7, 413, DateTimeKind.Local).AddTicks(9978), 5 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 414, DateTimeKind.Local).AddTicks(23), 9, new DateTime(2020, 6, 12, 9, 25, 7, 414, DateTimeKind.Local).AddTicks(33), 14 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 21, "eaque", new DateTime(2020, 6, 12, 9, 25, 7, 397, DateTimeKind.Local).AddTicks(5842), 32, new DateTime(2020, 6, 12, 9, 25, 7, 397, DateTimeKind.Local).AddTicks(6599) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 17, "Harum dicta possimus qui. Eum libero voluptates dolores mollitia facere est est quia aut. Odio est numquam unde. Totam perspiciatis explicabo ab vel suscipit quibusdam accusamus perferendis impedit.", new DateTime(2020, 6, 12, 9, 25, 7, 398, DateTimeKind.Local).AddTicks(5374), 37, new DateTime(2020, 6, 12, 9, 25, 7, 398, DateTimeKind.Local).AddTicks(5417) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 10, "Unde accusamus et quas facilis ut adipisci voluptatum amet.", new DateTime(2020, 6, 12, 9, 25, 7, 398, DateTimeKind.Local).AddTicks(6364), 26, new DateTime(2020, 6, 12, 9, 25, 7, 398, DateTimeKind.Local).AddTicks(6385) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 8, @"Qui fugit sed omnis aut consectetur dolorem ut nam explicabo.
Dolores accusamus eaque.
Rerum non aut consequatur sit omnis.
Sint ut sunt enim omnis.", new DateTime(2020, 6, 12, 9, 25, 7, 398, DateTimeKind.Local).AddTicks(7387), 40, new DateTime(2020, 6, 12, 9, 25, 7, 398, DateTimeKind.Local).AddTicks(7406) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 21, "Possimus eveniet quae ut. Enim rerum consequuntur tempore consequatur quia dolorem. Voluptatem commodi sequi repellat corporis sit. Velit dolore ut voluptatum mollitia recusandae voluptatibus. Et dolor sit fugiat quos dolorem id.", new DateTime(2020, 6, 12, 9, 25, 7, 398, DateTimeKind.Local).AddTicks(7668), 40, new DateTime(2020, 6, 12, 9, 25, 7, 398, DateTimeKind.Local).AddTicks(7676) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 9, @"Asperiores labore distinctio unde eos eligendi quo nihil.
Id asperiores inventore dolores ipsa quae molestias omnis similique corporis.
Nostrum voluptatem optio dolores dolorem autem suscipit.", new DateTime(2020, 6, 12, 9, 25, 7, 398, DateTimeKind.Local).AddTicks(7865), 33, new DateTime(2020, 6, 12, 9, 25, 7, 398, DateTimeKind.Local).AddTicks(7872) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 13, "Esse molestiae cum similique.", new DateTime(2020, 6, 12, 9, 25, 7, 398, DateTimeKind.Local).AddTicks(7928), 40, new DateTime(2020, 6, 12, 9, 25, 7, 398, DateTimeKind.Local).AddTicks(7934) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 18, "Explicabo iste dolorum dolorem amet consequuntur suscipit ducimus omnis incidunt. Nihil minima et consequatur cum perspiciatis. Quisquam omnis ex ut. Omnis dignissimos culpa.", new DateTime(2020, 6, 12, 9, 25, 7, 398, DateTimeKind.Local).AddTicks(8156), 23, new DateTime(2020, 6, 12, 9, 25, 7, 398, DateTimeKind.Local).AddTicks(8163) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 11, "Et facere tempora.", new DateTime(2020, 6, 12, 9, 25, 7, 398, DateTimeKind.Local).AddTicks(8256), 28, new DateTime(2020, 6, 12, 9, 25, 7, 398, DateTimeKind.Local).AddTicks(8262) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 10, @"Enim cumque eaque rerum dolorem sit aut quod eos.
Enim saepe esse.
Beatae in omnis eos perspiciatis et.
Id doloribus excepturi reiciendis est nemo.
Adipisci aut quia harum aut libero at voluptatem.", new DateTime(2020, 6, 12, 9, 25, 7, 398, DateTimeKind.Local).AddTicks(8442), 35, new DateTime(2020, 6, 12, 9, 25, 7, 398, DateTimeKind.Local).AddTicks(8448) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 18, "Culpa cumque odio aut excepturi culpa tempore dolores cum.", new DateTime(2020, 6, 12, 9, 25, 7, 398, DateTimeKind.Local).AddTicks(8555), 34, new DateTime(2020, 6, 12, 9, 25, 7, 398, DateTimeKind.Local).AddTicks(8561) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 2, @"Corrupti nihil impedit non voluptates dolores officiis enim.
Aliquam et soluta sint placeat sunt illo.", new DateTime(2020, 6, 12, 9, 25, 7, 398, DateTimeKind.Local).AddTicks(8665), 38, new DateTime(2020, 6, 12, 9, 25, 7, 398, DateTimeKind.Local).AddTicks(8670) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "UpdatedAt" },
                values: new object[] { 12, "Corrupti soluta dolorem voluptatibus alias qui sit vel.", new DateTime(2020, 6, 12, 9, 25, 7, 398, DateTimeKind.Local).AddTicks(8734), new DateTime(2020, 6, 12, 9, 25, 7, 398, DateTimeKind.Local).AddTicks(8740) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 8, "cumque", new DateTime(2020, 6, 12, 9, 25, 7, 398, DateTimeKind.Local).AddTicks(8772), 29, new DateTime(2020, 6, 12, 9, 25, 7, 398, DateTimeKind.Local).AddTicks(8778) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 5, "ratione", new DateTime(2020, 6, 12, 9, 25, 7, 398, DateTimeKind.Local).AddTicks(8872), 27, new DateTime(2020, 6, 12, 9, 25, 7, 398, DateTimeKind.Local).AddTicks(8878) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 5, @"Ut sequi amet non fugiat distinctio et et fuga quibusdam.
Ipsum voluptatum voluptatem consequatur ut qui cupiditate sint fugit.
Quia alias eius.", new DateTime(2020, 6, 12, 9, 25, 7, 398, DateTimeKind.Local).AddTicks(9012), 22, new DateTime(2020, 6, 12, 9, 25, 7, 398, DateTimeKind.Local).AddTicks(9018) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 21, @"Quod expedita cupiditate dolor possimus eius.
Reiciendis assumenda ipsum minus explicabo necessitatibus commodi.
Enim provident delectus consectetur quis est qui tempore.
Nesciunt eveniet earum.", new DateTime(2020, 6, 12, 9, 25, 7, 398, DateTimeKind.Local).AddTicks(9266), 24, new DateTime(2020, 6, 12, 9, 25, 7, 398, DateTimeKind.Local).AddTicks(9273) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 8, "mollitia", new DateTime(2020, 6, 12, 9, 25, 7, 398, DateTimeKind.Local).AddTicks(9308), 22, new DateTime(2020, 6, 12, 9, 25, 7, 398, DateTimeKind.Local).AddTicks(9314) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 4, "Eos labore asperiores quisquam non veniam natus a ex dolor.", new DateTime(2020, 6, 12, 9, 25, 7, 398, DateTimeKind.Local).AddTicks(9425), 21, new DateTime(2020, 6, 12, 9, 25, 7, 398, DateTimeKind.Local).AddTicks(9432) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 16, "Similique enim iure adipisci illum sequi maiores deleniti sit vero. Quis perferendis expedita sunt est. Reprehenderit deleniti est aperiam ut et voluptatem sunt. Et ipsam voluptatem.", new DateTime(2020, 6, 12, 9, 25, 7, 398, DateTimeKind.Local).AddTicks(9713), 23, new DateTime(2020, 6, 12, 9, 25, 7, 398, DateTimeKind.Local).AddTicks(9720) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 13, new DateTime(2020, 6, 12, 9, 25, 7, 227, DateTimeKind.Local).AddTicks(5399), "Karson_Fay@yahoo.com", "Zgfd6nuQ65VRg2OXKzGgF34QTeci/M4jdgSLWTqzd1k=", "F39xzqFsJmrMymE7HjYntaDgeCxw0PXMGeBqVsvd9j8=", new DateTime(2020, 6, 12, 9, 25, 7, 227, DateTimeKind.Local).AddTicks(6355), "Kristin_Hills" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 11, new DateTime(2020, 6, 12, 9, 25, 7, 236, DateTimeKind.Local).AddTicks(261), "Devon20@gmail.com", "89zCWheDuRWIXaBBbd4su0Z9RwmgQC37zUxa6/H6cns=", "X5Whzpx7z5vuJcqHiapr1LyEsgStUkU1JwehlTCTB2Y=", new DateTime(2020, 6, 12, 9, 25, 7, 236, DateTimeKind.Local).AddTicks(341), "Mona_Glover42" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 14, new DateTime(2020, 6, 12, 9, 25, 7, 244, DateTimeKind.Local).AddTicks(4876), "Alfonzo_Haley31@yahoo.com", "aBCr4OkRvxiEPz2C34USxgHpCKOdmrnjgceDcVlN10w=", "5Gc0VB6EPzAuGKUjK+hyQTUQxv9STfnliImqnA7YYtE=", new DateTime(2020, 6, 12, 9, 25, 7, 244, DateTimeKind.Local).AddTicks(4951), "Elroy_Bahringer96" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 3, new DateTime(2020, 6, 12, 9, 25, 7, 252, DateTimeKind.Local).AddTicks(8323), "Amanda5@hotmail.com", "OH9RxXjvT0DRtklGvt7HSu6shAYOFGJNRl2dizR7h/8=", "f+rksdm7EHJe0Sxzd3PUp/iIcg7IIKRoH7yqdTjhq8Q=", new DateTime(2020, 6, 12, 9, 25, 7, 252, DateTimeKind.Local).AddTicks(8426), "Frederik.Frami28" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 8, new DateTime(2020, 6, 12, 9, 25, 7, 261, DateTimeKind.Local).AddTicks(9949), "Elliot.Nolan37@yahoo.com", "cTQhO03w+Na1NVyF9uhFFZ134ZVa6uRDCZgo3p9uZio=", "PNH/Wrr8eMGNQ4SlVOJsyniQejnCow4MwSL1aWs3t1M=", new DateTime(2020, 6, 12, 9, 25, 7, 262, DateTimeKind.Local).AddTicks(11), "Gunnar.Abshire44" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 13, new DateTime(2020, 6, 12, 9, 25, 7, 269, DateTimeKind.Local).AddTicks(7442), "Ayana_Green71@yahoo.com", "nMn6Kny27YFjAF1gspXoN0Y0Hdh14Ni0nV51azFI0+g=", "PxuY69fhQcFs7sNu+0objNv7nXb+FZZOKYHvuiikDxw=", new DateTime(2020, 6, 12, 9, 25, 7, 269, DateTimeKind.Local).AddTicks(7516), "Kailee32" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 9, new DateTime(2020, 6, 12, 9, 25, 7, 277, DateTimeKind.Local).AddTicks(8949), "Delilah5@yahoo.com", "U0pZ/1rvS2FT9EZUjmWfBH3khXfW32cYe17ifRBGIKY=", "TXbEUBQnGMUyGtNW+m1SXXMhCG/mTfURjUAYkJS2HJ0=", new DateTime(2020, 6, 12, 9, 25, 7, 277, DateTimeKind.Local).AddTicks(9017), "Samir_Breitenberg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 9, new DateTime(2020, 6, 12, 9, 25, 7, 285, DateTimeKind.Local).AddTicks(7592), "William42@yahoo.com", "5qx05qoPjGWv5C9s4+eVKX+HeIfnolYncp5t5dux7Mo=", "r5LbBhS3XZW3Q/NeschidKEI/JehnGin7vO6qUFp01U=", new DateTime(2020, 6, 12, 9, 25, 7, 285, DateTimeKind.Local).AddTicks(7662), "Vaughn_Heaney20" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 4, new DateTime(2020, 6, 12, 9, 25, 7, 293, DateTimeKind.Local).AddTicks(4946), "Halie79@gmail.com", "RZQF/g34z4jkXe6fHUaaeTEjcQj0433pKKSR2r0llgE=", "VuD4A1u6S1Gs1RovjdjmhdeUh2W5u3ozGYc9BDwSaGM=", new DateTime(2020, 6, 12, 9, 25, 7, 293, DateTimeKind.Local).AddTicks(5018), "Olaf.Cartwright91" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 9, new DateTime(2020, 6, 12, 9, 25, 7, 301, DateTimeKind.Local).AddTicks(4961), "Kayli27@hotmail.com", "XXG8Eh36RvxhKwIV4GyBCnenJLPfhyvjWcUB94fieHU=", "Wyw9QUJJNm/u3rjRx7z1dGip2XrhKpTo4xHVUFtB56Y=", new DateTime(2020, 6, 12, 9, 25, 7, 301, DateTimeKind.Local).AddTicks(5040), "Sid_Corkery" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 11, new DateTime(2020, 6, 12, 9, 25, 7, 309, DateTimeKind.Local).AddTicks(3509), "Laney8@hotmail.com", "54T9AO/m540q9i5XadK21sIzSpku+WBLxnSKTK9JFyw=", "Hp2Ky6VPh+CdAZ5OVK2+b4AF11S2BvIov0209yb+DKI=", new DateTime(2020, 6, 12, 9, 25, 7, 309, DateTimeKind.Local).AddTicks(3565), "Cordia2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 16, new DateTime(2020, 6, 12, 9, 25, 7, 317, DateTimeKind.Local).AddTicks(2823), "Dayton.Veum64@yahoo.com", "u0KBXt9J0Dt4kMqHYHBconTyiTvTCQXSBGxrEuwtLJ4=", "igxQw32FlAYGfB2qLewnPSt9xPOnMxeOUuDiB6XhLok=", new DateTime(2020, 6, 12, 9, 25, 7, 317, DateTimeKind.Local).AddTicks(2891), "Lulu_Hirthe62" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 5, new DateTime(2020, 6, 12, 9, 25, 7, 325, DateTimeKind.Local).AddTicks(753), "Pearlie96@hotmail.com", "H4B8l7WerEj07ZWl2TN0/bHjj9wjlSWSMXR9hCnHXD4=", "H//70Vf9f72iZ3A9ZNwrjByXi1+VWir//JoWS2oWgyg=", new DateTime(2020, 6, 12, 9, 25, 7, 325, DateTimeKind.Local).AddTicks(799), "Loyal67" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 8, new DateTime(2020, 6, 12, 9, 25, 7, 332, DateTimeKind.Local).AddTicks(6567), "Reva.Littel@gmail.com", "NgKrb99KbbR2v2W3fG5bu6biaTZV1OwsFOAeoqA/Lg4=", "U8m3LFPgOBF0AlrccPRe0cGqCndtHWucIG3A9D/Bz+Q=", new DateTime(2020, 6, 12, 9, 25, 7, 332, DateTimeKind.Local).AddTicks(6593), "Vida18" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 12, new DateTime(2020, 6, 12, 9, 25, 7, 342, DateTimeKind.Local).AddTicks(4426), "Trudie_Ratke89@gmail.com", "k+rjlYK/7q4X77ypdekd805QlQLSaRpTly0ALREM8mA=", "hhzoxCT8Qe6G0PixjLt1/+w57STI+d7vdp7huPYtv5M=", new DateTime(2020, 6, 12, 9, 25, 7, 342, DateTimeKind.Local).AddTicks(4500), "Yazmin40" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 15, new DateTime(2020, 6, 12, 9, 25, 7, 351, DateTimeKind.Local).AddTicks(1954), "Kenny.Grimes48@gmail.com", "ya1gWTVRiVbJoT8oCWbCrtdD9wCtsDPnpxOt8WaZHcA=", "C5OdYz/hwQJALjTuNg17S5g6GGNwy5tKLNjE9ugWHF0=", new DateTime(2020, 6, 12, 9, 25, 7, 351, DateTimeKind.Local).AddTicks(2026), "Willow.Ondricka62" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 14, new DateTime(2020, 6, 12, 9, 25, 7, 359, DateTimeKind.Local).AddTicks(628), "Carlee.Romaguera59@hotmail.com", "n0QoLjbW8L0n4JlBgNPKTLYJUMbhpE7BE4Mj96GMMcc=", "A83NFncBbudAcp5hoeU2a7hTlsQ2yvSwGhBqu2TPe5A=", new DateTime(2020, 6, 12, 9, 25, 7, 359, DateTimeKind.Local).AddTicks(673), "Ozella_Schneider" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 8, new DateTime(2020, 6, 12, 9, 25, 7, 366, DateTimeKind.Local).AddTicks(8247), "Esperanza.Steuber@hotmail.com", "rKNCOvSbZ9CIwpGPXRHkVjdtYAN1EMcCoYMd+YvTfhw=", "+xgYZ1YTXrnaanRd7UZsXVpaL4ioRy4hAIuS+Y3vfBg=", new DateTime(2020, 6, 12, 9, 25, 7, 366, DateTimeKind.Local).AddTicks(8321), "Aurore_Huel19" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 17, new DateTime(2020, 6, 12, 9, 25, 7, 374, DateTimeKind.Local).AddTicks(4766), "Angel.Hessel40@gmail.com", "IZGCMEmlQurDmYM0ol+sXJ7p93dLAho3GWZfQIRQalU=", "TH92h/470k/TojIwc++qmy8JKQv6SCeQ5SdcS34wklQ=", new DateTime(2020, 6, 12, 9, 25, 7, 374, DateTimeKind.Local).AddTicks(4826), "Fausto_Huels" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 16, new DateTime(2020, 6, 12, 9, 25, 7, 382, DateTimeKind.Local).AddTicks(985), "Erna7@yahoo.com", "azVZewhDQ4yQWZBV1DDS3XQhg5yAm7glizs7qgOAhPk=", "TOyP/3RsdEBw13Dvj4zcgkTDywJ2r4kSPddMNQi5aGs=", new DateTime(2020, 6, 12, 9, 25, 7, 382, DateTimeKind.Local).AddTicks(1000), "Jo.Crooks5" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "Password", "Salt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 12, 9, 25, 7, 389, DateTimeKind.Local).AddTicks(9370), "5spmNrzRAdyZG7JPrHJv0f6II4njih/B4LTwMsGE/70=", "6G0ehgAiRhOcz228bQmWrZQKyyZyWZIsu3e6xqqciKk=", new DateTime(2020, 6, 12, 9, 25, 7, 389, DateTimeKind.Local).AddTicks(9370) });

            migrationBuilder.CreateIndex(
                name: "IX_PasswordResetTokens_UserId",
                table: "PasswordResetTokens",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PasswordResetTokens");

            migrationBuilder.UpdateData(
                table: "CommentNegativeReactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CommentId", "CreatedAt", "IsDislike", "UpdatedAt", "UserId" },
                values: new object[] { 18, new DateTime(2020, 5, 25, 10, 12, 23, 168, DateTimeKind.Local).AddTicks(8962), true, new DateTime(2020, 5, 25, 10, 12, 23, 168, DateTimeKind.Local).AddTicks(9712), 18 });

            migrationBuilder.UpdateData(
                table: "CommentNegativeReactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 17, new DateTime(2020, 5, 25, 10, 12, 23, 169, DateTimeKind.Local).AddTicks(207), new DateTime(2020, 5, 25, 10, 12, 23, 169, DateTimeKind.Local).AddTicks(223), 1 });

            migrationBuilder.UpdateData(
                table: "CommentNegativeReactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CommentId", "CreatedAt", "IsDislike", "UpdatedAt", "UserId" },
                values: new object[] { 11, new DateTime(2020, 5, 25, 10, 12, 23, 169, DateTimeKind.Local).AddTicks(262), false, new DateTime(2020, 5, 25, 10, 12, 23, 169, DateTimeKind.Local).AddTicks(267), 4 });

            migrationBuilder.UpdateData(
                table: "CommentNegativeReactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 13, new DateTime(2020, 5, 25, 10, 12, 23, 169, DateTimeKind.Local).AddTicks(291), new DateTime(2020, 5, 25, 10, 12, 23, 169, DateTimeKind.Local).AddTicks(296), 10 });

            migrationBuilder.UpdateData(
                table: "CommentNegativeReactions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 13, new DateTime(2020, 5, 25, 10, 12, 23, 169, DateTimeKind.Local).AddTicks(317), new DateTime(2020, 5, 25, 10, 12, 23, 169, DateTimeKind.Local).AddTicks(322), 10 });

            migrationBuilder.UpdateData(
                table: "CommentNegativeReactions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CommentId", "CreatedAt", "IsDislike", "UpdatedAt", "UserId" },
                values: new object[] { 6, new DateTime(2020, 5, 25, 10, 12, 23, 169, DateTimeKind.Local).AddTicks(344), true, new DateTime(2020, 5, 25, 10, 12, 23, 169, DateTimeKind.Local).AddTicks(349), 6 });

            migrationBuilder.UpdateData(
                table: "CommentNegativeReactions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 7, new DateTime(2020, 5, 25, 10, 12, 23, 169, DateTimeKind.Local).AddTicks(371), new DateTime(2020, 5, 25, 10, 12, 23, 169, DateTimeKind.Local).AddTicks(376), 10 });

            migrationBuilder.UpdateData(
                table: "CommentNegativeReactions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CommentId", "CreatedAt", "IsDislike", "UpdatedAt", "UserId" },
                values: new object[] { 18, new DateTime(2020, 5, 25, 10, 12, 23, 169, DateTimeKind.Local).AddTicks(398), true, new DateTime(2020, 5, 25, 10, 12, 23, 169, DateTimeKind.Local).AddTicks(403), 16 });

            migrationBuilder.UpdateData(
                table: "CommentNegativeReactions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 7, new DateTime(2020, 5, 25, 10, 12, 23, 169, DateTimeKind.Local).AddTicks(425), new DateTime(2020, 5, 25, 10, 12, 23, 169, DateTimeKind.Local).AddTicks(429), 11 });

            migrationBuilder.UpdateData(
                table: "CommentNegativeReactions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 13, new DateTime(2020, 5, 25, 10, 12, 23, 169, DateTimeKind.Local).AddTicks(451), new DateTime(2020, 5, 25, 10, 12, 23, 169, DateTimeKind.Local).AddTicks(456), 10 });

            migrationBuilder.UpdateData(
                table: "CommentNegativeReactions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 4, new DateTime(2020, 5, 25, 10, 12, 23, 169, DateTimeKind.Local).AddTicks(478), new DateTime(2020, 5, 25, 10, 12, 23, 169, DateTimeKind.Local).AddTicks(483), 13 });

            migrationBuilder.UpdateData(
                table: "CommentNegativeReactions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 9, new DateTime(2020, 5, 25, 10, 12, 23, 169, DateTimeKind.Local).AddTicks(505), new DateTime(2020, 5, 25, 10, 12, 23, 169, DateTimeKind.Local).AddTicks(510), 17 });

            migrationBuilder.UpdateData(
                table: "CommentNegativeReactions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CommentId", "CreatedAt", "IsDislike", "UpdatedAt", "UserId" },
                values: new object[] { 9, new DateTime(2020, 5, 25, 10, 12, 23, 169, DateTimeKind.Local).AddTicks(540), false, new DateTime(2020, 5, 25, 10, 12, 23, 169, DateTimeKind.Local).AddTicks(545), 16 });

            migrationBuilder.UpdateData(
                table: "CommentNegativeReactions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 15, new DateTime(2020, 5, 25, 10, 12, 23, 169, DateTimeKind.Local).AddTicks(567), new DateTime(2020, 5, 25, 10, 12, 23, 169, DateTimeKind.Local).AddTicks(571), 19 });

            migrationBuilder.UpdateData(
                table: "CommentNegativeReactions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 12, new DateTime(2020, 5, 25, 10, 12, 23, 169, DateTimeKind.Local).AddTicks(593), new DateTime(2020, 5, 25, 10, 12, 23, 169, DateTimeKind.Local).AddTicks(598), 14 });

            migrationBuilder.UpdateData(
                table: "CommentNegativeReactions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 20, new DateTime(2020, 5, 25, 10, 12, 23, 169, DateTimeKind.Local).AddTicks(621), new DateTime(2020, 5, 25, 10, 12, 23, 169, DateTimeKind.Local).AddTicks(626), 1 });

            migrationBuilder.UpdateData(
                table: "CommentNegativeReactions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 14, new DateTime(2020, 5, 25, 10, 12, 23, 169, DateTimeKind.Local).AddTicks(647), new DateTime(2020, 5, 25, 10, 12, 23, 169, DateTimeKind.Local).AddTicks(652), 18 });

            migrationBuilder.UpdateData(
                table: "CommentNegativeReactions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 12, new DateTime(2020, 5, 25, 10, 12, 23, 169, DateTimeKind.Local).AddTicks(673), new DateTime(2020, 5, 25, 10, 12, 23, 169, DateTimeKind.Local).AddTicks(678), 17 });

            migrationBuilder.UpdateData(
                table: "CommentNegativeReactions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 3, new DateTime(2020, 5, 25, 10, 12, 23, 169, DateTimeKind.Local).AddTicks(699), new DateTime(2020, 5, 25, 10, 12, 23, 169, DateTimeKind.Local).AddTicks(704), 19 });

            migrationBuilder.UpdateData(
                table: "CommentNegativeReactions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 11, new DateTime(2020, 5, 25, 10, 12, 23, 169, DateTimeKind.Local).AddTicks(726), new DateTime(2020, 5, 25, 10, 12, 23, 169, DateTimeKind.Local).AddTicks(730), 7 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 9, new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(893), new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(1652), 11 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 13, new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(2147), new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(2168), 20 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 4, new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(2207), true, new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(2213), 16 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 17, new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(2237), false, new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(2242), 12 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 3, new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(2267), new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(2272), 1 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 17, new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(2294), false, new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(2299), 18 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 14, new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(2321), new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(2326), 19 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 19, new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(2348), true, new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(2353), 16 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 7, new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(2377), new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(2381), 5 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 3, new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(2402), false, new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(2407), 19 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 6, new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(2429), new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(2434), 16 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 19, new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(2455), new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(2460), 11 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 12, new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(2482), true, new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(2487), 4 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 11, new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(2510), true, new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(2515), 6 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 5, new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(2536), false, new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(2541), 11 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 19, new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(2563), new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(2568), 19 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 8, new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(2590), false, new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(2595), 1 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(2616), true, new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(2621), 9 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 16, new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(2643), new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(2648), 19 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 15, new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(2671), new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(2675), 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 15, "Fuga non hic quia.", new DateTime(2020, 5, 25, 10, 12, 23, 137, DateTimeKind.Local).AddTicks(9212), 7, new DateTime(2020, 5, 25, 10, 12, 23, 137, DateTimeKind.Local).AddTicks(9936) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 9, "Ex cupiditate sit unde nesciunt rem id harum laboriosam consequuntur.", new DateTime(2020, 5, 25, 10, 12, 23, 138, DateTimeKind.Local).AddTicks(632), 15, new DateTime(2020, 5, 25, 10, 12, 23, 138, DateTimeKind.Local).AddTicks(654) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "UpdatedAt" },
                values: new object[] { 20, "Nihil dolores dolore fuga fugiat qui natus quis nemo quia.", new DateTime(2020, 5, 25, 10, 12, 23, 138, DateTimeKind.Local).AddTicks(746), new DateTime(2020, 5, 25, 10, 12, 23, 138, DateTimeKind.Local).AddTicks(751) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 10, "Corporis dolores et corporis.", new DateTime(2020, 5, 25, 10, 12, 23, 138, DateTimeKind.Local).AddTicks(799), 11, new DateTime(2020, 5, 25, 10, 12, 23, 138, DateTimeKind.Local).AddTicks(805) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 4, "Veniam soluta consequuntur tenetur.", new DateTime(2020, 5, 25, 10, 12, 23, 138, DateTimeKind.Local).AddTicks(853), 5, new DateTime(2020, 5, 25, 10, 12, 23, 138, DateTimeKind.Local).AddTicks(858) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 6, "Nisi aperiam facere et dolorem perferendis non consequatur magni.", new DateTime(2020, 5, 25, 10, 12, 23, 138, DateTimeKind.Local).AddTicks(926), 7, new DateTime(2020, 5, 25, 10, 12, 23, 138, DateTimeKind.Local).AddTicks(931) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 1, "Et repellendus rerum quae aliquid molestiae.", new DateTime(2020, 5, 25, 10, 12, 23, 138, DateTimeKind.Local).AddTicks(1075), 20, new DateTime(2020, 5, 25, 10, 12, 23, 138, DateTimeKind.Local).AddTicks(1081) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 19, "Totam reiciendis aperiam tempore.", new DateTime(2020, 5, 25, 10, 12, 23, 138, DateTimeKind.Local).AddTicks(1132), 10, new DateTime(2020, 5, 25, 10, 12, 23, 138, DateTimeKind.Local).AddTicks(1137) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 12, "Quod consequatur exercitationem voluptatum laborum voluptatem eius magnam.", new DateTime(2020, 5, 25, 10, 12, 23, 138, DateTimeKind.Local).AddTicks(1198), 11, new DateTime(2020, 5, 25, 10, 12, 23, 138, DateTimeKind.Local).AddTicks(1203) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 1, "Quos et dolores.", new DateTime(2020, 5, 25, 10, 12, 23, 138, DateTimeKind.Local).AddTicks(1244), 8, new DateTime(2020, 5, 25, 10, 12, 23, 138, DateTimeKind.Local).AddTicks(1248) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "UpdatedAt" },
                values: new object[] { 19, "Beatae expedita praesentium rerum quidem omnis cupiditate odit ut harum.", new DateTime(2020, 5, 25, 10, 12, 23, 138, DateTimeKind.Local).AddTicks(1318), new DateTime(2020, 5, 25, 10, 12, 23, 138, DateTimeKind.Local).AddTicks(1323) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 17, "Reiciendis hic non voluptatem et omnis voluptatibus nulla.", new DateTime(2020, 5, 25, 10, 12, 23, 138, DateTimeKind.Local).AddTicks(1428), 17, new DateTime(2020, 5, 25, 10, 12, 23, 138, DateTimeKind.Local).AddTicks(1433) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 10, "Reprehenderit quos dolorem nisi omnis maxime tempore.", new DateTime(2020, 5, 25, 10, 12, 23, 138, DateTimeKind.Local).AddTicks(1489), 13, new DateTime(2020, 5, 25, 10, 12, 23, 138, DateTimeKind.Local).AddTicks(1494) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { "Mollitia eius accusantium.", new DateTime(2020, 5, 25, 10, 12, 23, 138, DateTimeKind.Local).AddTicks(1535), 3, new DateTime(2020, 5, 25, 10, 12, 23, 138, DateTimeKind.Local).AddTicks(1540) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 12, "Assumenda quis vel iure nisi adipisci fugiat.", new DateTime(2020, 5, 25, 10, 12, 23, 138, DateTimeKind.Local).AddTicks(1595), 3, new DateTime(2020, 5, 25, 10, 12, 23, 138, DateTimeKind.Local).AddTicks(1600) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 20, "Reiciendis molestiae et qui magni ipsam vel saepe magnam qui.", new DateTime(2020, 5, 25, 10, 12, 23, 138, DateTimeKind.Local).AddTicks(1664), 4, new DateTime(2020, 5, 25, 10, 12, 23, 138, DateTimeKind.Local).AddTicks(1669) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 11, "Corrupti sapiente esse qui distinctio eum minus.", new DateTime(2020, 5, 25, 10, 12, 23, 138, DateTimeKind.Local).AddTicks(1725), 5, new DateTime(2020, 5, 25, 10, 12, 23, 138, DateTimeKind.Local).AddTicks(1729) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { "Ipsum non voluptatum eum blanditiis modi adipisci expedita minima numquam.", new DateTime(2020, 5, 25, 10, 12, 23, 138, DateTimeKind.Local).AddTicks(1835), 16, new DateTime(2020, 5, 25, 10, 12, 23, 138, DateTimeKind.Local).AddTicks(1840) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 9, "Eius quia molestiae veniam.", new DateTime(2020, 5, 25, 10, 12, 23, 138, DateTimeKind.Local).AddTicks(1883), 3, new DateTime(2020, 5, 25, 10, 12, 23, 138, DateTimeKind.Local).AddTicks(1889) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 4, "Delectus facilis officia illum saepe nihil non maxime quia.", new DateTime(2020, 5, 25, 10, 12, 23, 138, DateTimeKind.Local).AddTicks(1947), 8, new DateTime(2020, 5, 25, 10, 12, 23, 138, DateTimeKind.Local).AddTicks(1952) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(3556), "https://s3.amazonaws.com/uifaces/faces/twitter/jnmnrd/128.jpg", new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(8202) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(9060), "https://s3.amazonaws.com/uifaces/faces/twitter/lisovsky/128.jpg", new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(9087) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(9120), "https://s3.amazonaws.com/uifaces/faces/twitter/marciotoledo/128.jpg", new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(9125) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(9146), "https://s3.amazonaws.com/uifaces/faces/twitter/sprayaga/128.jpg", new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(9150) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(9170), "https://s3.amazonaws.com/uifaces/faces/twitter/abdullindenis/128.jpg", new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(9175) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(9194), "https://s3.amazonaws.com/uifaces/faces/twitter/strikewan/128.jpg", new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(9199) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(9219), "https://s3.amazonaws.com/uifaces/faces/twitter/cbracco/128.jpg", new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(9223) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(9243), "https://s3.amazonaws.com/uifaces/faces/twitter/betraydan/128.jpg", new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(9248) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(9267), "https://s3.amazonaws.com/uifaces/faces/twitter/adhiardana/128.jpg", new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(9272) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(9291), "https://s3.amazonaws.com/uifaces/faces/twitter/rude/128.jpg", new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(9295) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(9316), "https://s3.amazonaws.com/uifaces/faces/twitter/Stievius/128.jpg", new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(9321) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(9341), "https://s3.amazonaws.com/uifaces/faces/twitter/vimarethomas/128.jpg", new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(9345) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(9364), "https://s3.amazonaws.com/uifaces/faces/twitter/we_social/128.jpg", new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(9369) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(9391), "https://s3.amazonaws.com/uifaces/faces/twitter/jayphen/128.jpg", new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(9396) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(9416), "https://s3.amazonaws.com/uifaces/faces/twitter/buddhasource/128.jpg", new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(9421) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(9440), "https://s3.amazonaws.com/uifaces/faces/twitter/thehacker/128.jpg", new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(9445) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(9464), "https://s3.amazonaws.com/uifaces/faces/twitter/mizko/128.jpg", new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(9468) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(9487), "https://s3.amazonaws.com/uifaces/faces/twitter/nepdud/128.jpg", new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(9491) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(9511), "https://s3.amazonaws.com/uifaces/faces/twitter/hermanobrother/128.jpg", new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(9515) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(9533), "https://s3.amazonaws.com/uifaces/faces/twitter/petebernardo/128.jpg", new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(9538) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 22, 930, DateTimeKind.Local).AddTicks(8825), "https://picsum.photos/640/480/?image=406", new DateTime(2020, 5, 25, 10, 12, 22, 930, DateTimeKind.Local).AddTicks(9624) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 22, 930, DateTimeKind.Local).AddTicks(9968), "https://picsum.photos/640/480/?image=483", new DateTime(2020, 5, 25, 10, 12, 22, 930, DateTimeKind.Local).AddTicks(9998) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 22, 931, DateTimeKind.Local).AddTicks(27), "https://picsum.photos/640/480/?image=674", new DateTime(2020, 5, 25, 10, 12, 22, 931, DateTimeKind.Local).AddTicks(33) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 22, 931, DateTimeKind.Local).AddTicks(52), "https://picsum.photos/640/480/?image=966", new DateTime(2020, 5, 25, 10, 12, 22, 931, DateTimeKind.Local).AddTicks(57) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 22, 931, DateTimeKind.Local).AddTicks(75), "https://picsum.photos/640/480/?image=371", new DateTime(2020, 5, 25, 10, 12, 22, 931, DateTimeKind.Local).AddTicks(80) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 22, 931, DateTimeKind.Local).AddTicks(99), "https://picsum.photos/640/480/?image=1037", new DateTime(2020, 5, 25, 10, 12, 22, 931, DateTimeKind.Local).AddTicks(103) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 22, 931, DateTimeKind.Local).AddTicks(123), "https://picsum.photos/640/480/?image=911", new DateTime(2020, 5, 25, 10, 12, 22, 931, DateTimeKind.Local).AddTicks(127) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 22, 931, DateTimeKind.Local).AddTicks(146), "https://picsum.photos/640/480/?image=574", new DateTime(2020, 5, 25, 10, 12, 22, 931, DateTimeKind.Local).AddTicks(151) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 22, 931, DateTimeKind.Local).AddTicks(170), "https://picsum.photos/640/480/?image=64", new DateTime(2020, 5, 25, 10, 12, 22, 931, DateTimeKind.Local).AddTicks(175) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 22, 931, DateTimeKind.Local).AddTicks(194), "https://picsum.photos/640/480/?image=315", new DateTime(2020, 5, 25, 10, 12, 22, 931, DateTimeKind.Local).AddTicks(198) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 22, 931, DateTimeKind.Local).AddTicks(217), "https://picsum.photos/640/480/?image=742", new DateTime(2020, 5, 25, 10, 12, 22, 931, DateTimeKind.Local).AddTicks(221) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 22, 931, DateTimeKind.Local).AddTicks(240), "https://picsum.photos/640/480/?image=510", new DateTime(2020, 5, 25, 10, 12, 22, 931, DateTimeKind.Local).AddTicks(244) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 22, 931, DateTimeKind.Local).AddTicks(263), "https://picsum.photos/640/480/?image=39", new DateTime(2020, 5, 25, 10, 12, 22, 931, DateTimeKind.Local).AddTicks(268) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 22, 931, DateTimeKind.Local).AddTicks(287), "https://picsum.photos/640/480/?image=553", new DateTime(2020, 5, 25, 10, 12, 22, 931, DateTimeKind.Local).AddTicks(291) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 22, 931, DateTimeKind.Local).AddTicks(350), "https://picsum.photos/640/480/?image=606", new DateTime(2020, 5, 25, 10, 12, 22, 931, DateTimeKind.Local).AddTicks(355) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 22, 931, DateTimeKind.Local).AddTicks(374), "https://picsum.photos/640/480/?image=725", new DateTime(2020, 5, 25, 10, 12, 22, 931, DateTimeKind.Local).AddTicks(379) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 22, 931, DateTimeKind.Local).AddTicks(398), "https://picsum.photos/640/480/?image=882", new DateTime(2020, 5, 25, 10, 12, 22, 931, DateTimeKind.Local).AddTicks(402) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 22, 931, DateTimeKind.Local).AddTicks(421), "https://picsum.photos/640/480/?image=289", new DateTime(2020, 5, 25, 10, 12, 22, 931, DateTimeKind.Local).AddTicks(426) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 22, 931, DateTimeKind.Local).AddTicks(445), "https://picsum.photos/640/480/?image=53", new DateTime(2020, 5, 25, 10, 12, 22, 931, DateTimeKind.Local).AddTicks(449) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 22, 931, DateTimeKind.Local).AddTicks(468), "https://picsum.photos/640/480/?image=657", new DateTime(2020, 5, 25, 10, 12, 22, 931, DateTimeKind.Local).AddTicks(472) });

            migrationBuilder.UpdateData(
                table: "PostNegativeReactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IsDislike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(2620), false, 7, new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(3369), 10 });

            migrationBuilder.UpdateData(
                table: "PostNegativeReactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "IsDislike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(3883), true, 20, new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(3900), 13 });

            migrationBuilder.UpdateData(
                table: "PostNegativeReactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "IsDislike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(3938), false, 17, new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(3943), 4 });

            migrationBuilder.UpdateData(
                table: "PostNegativeReactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "IsDislike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(3969), false, 1, new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(3974), 20 });

            migrationBuilder.UpdateData(
                table: "PostNegativeReactions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(3997), 15, new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(4002), 10 });

            migrationBuilder.UpdateData(
                table: "PostNegativeReactions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(4024), 15, new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(4029), 19 });

            migrationBuilder.UpdateData(
                table: "PostNegativeReactions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(4050), 20, new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(4055), 12 });

            migrationBuilder.UpdateData(
                table: "PostNegativeReactions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "IsDislike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(4077), false, 7, new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(4081), 7 });

            migrationBuilder.UpdateData(
                table: "PostNegativeReactions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(4103), 1, new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(4107), 20 });

            migrationBuilder.UpdateData(
                table: "PostNegativeReactions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "IsDislike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(4129), true, 1, new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(4134), 16 });

            migrationBuilder.UpdateData(
                table: "PostNegativeReactions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(4155), 13, new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(4160), 7 });

            migrationBuilder.UpdateData(
                table: "PostNegativeReactions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(4181), 19, new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(4186), 6 });

            migrationBuilder.UpdateData(
                table: "PostNegativeReactions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "IsDislike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(4207), false, 3, new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(4211), 2 });

            migrationBuilder.UpdateData(
                table: "PostNegativeReactions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "IsDislike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(4233), true, 10, new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(4238), 9 });

            migrationBuilder.UpdateData(
                table: "PostNegativeReactions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "IsDislike", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(4259), false, new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(4264), 11 });

            migrationBuilder.UpdateData(
                table: "PostNegativeReactions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "IsDislike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(4285), false, 20, new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(4290), 6 });

            migrationBuilder.UpdateData(
                table: "PostNegativeReactions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "IsDislike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(4312), true, 4, new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(4317), 17 });

            migrationBuilder.UpdateData(
                table: "PostNegativeReactions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(4337), 20, new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(4342), 21 });

            migrationBuilder.UpdateData(
                table: "PostNegativeReactions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(4363), 3, new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(4368), 4 });

            migrationBuilder.UpdateData(
                table: "PostNegativeReactions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(4389), 14, new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(4394), 18 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(2774), 10, new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(3502), 16 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(4213), true, 14, new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(4274), 4 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(4314), 14, new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(4320), 8 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(4343), true, 14, new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(4348), 11 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(4372), 15, new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(4377), 21 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(4400), false, 5, new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(4405), 5 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(4428), 7, new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(4433), 3 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(4457), true, 20, new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(4462), 10 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(4484), 14, new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(4489), 14 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(4515), 6, new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(4520), 1 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(4541), 3, new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(4546), 11 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(4590), false, 1, new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(4596), 3 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(4619), false, 1, new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(4624), 4 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(4646), true, 2, new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(4650), 8 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(4672), new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(4677), 16 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(4699), false, 17, new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(4704), 14 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(4726), 15, new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(4730), 15 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(4752), true, 2, new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(4756), 10 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(4778), 6, new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(4783), 3 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(4805), 12, new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(4810), 12 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 10, "Quo possimus commodi iure atque qui sed.", new DateTime(2020, 5, 25, 10, 12, 23, 130, DateTimeKind.Local).AddTicks(3780), 34, new DateTime(2020, 5, 25, 10, 12, 23, 130, DateTimeKind.Local).AddTicks(4606) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 12, "vel", new DateTime(2020, 5, 25, 10, 12, 23, 130, DateTimeKind.Local).AddTicks(6049), 27, new DateTime(2020, 5, 25, 10, 12, 23, 130, DateTimeKind.Local).AddTicks(6078) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 14, "Voluptates placeat aut sunt ut recusandae aut rem.", new DateTime(2020, 5, 25, 10, 12, 23, 130, DateTimeKind.Local).AddTicks(6292), 24, new DateTime(2020, 5, 25, 10, 12, 23, 130, DateTimeKind.Local).AddTicks(6299) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 14, @"Impedit eveniet voluptates eaque quasi.
Reiciendis aspernatur nam enim eveniet et dicta autem ab.", new DateTime(2020, 5, 25, 10, 12, 23, 130, DateTimeKind.Local).AddTicks(9710), 37, new DateTime(2020, 5, 25, 10, 12, 23, 130, DateTimeKind.Local).AddTicks(9733) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 20, @"Voluptatum voluptas repudiandae qui earum suscipit.
Tenetur quis quia omnis aut qui est ut.
Ipsum laboriosam aliquam voluptas eum id et.
Quia tenetur aut qui eum est.
Ut cumque est et vel voluptatibus.
Aspernatur id fugit accusantium vel blanditiis.", new DateTime(2020, 5, 25, 10, 12, 23, 131, DateTimeKind.Local).AddTicks(148), 31, new DateTime(2020, 5, 25, 10, 12, 23, 131, DateTimeKind.Local).AddTicks(156) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 11, "enim", new DateTime(2020, 5, 25, 10, 12, 23, 131, DateTimeKind.Local).AddTicks(196), 37, new DateTime(2020, 5, 25, 10, 12, 23, 131, DateTimeKind.Local).AddTicks(201) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 7, @"Ipsa accusantium officiis dicta voluptatum et.
Qui cupiditate quia quidem porro eos enim qui voluptates deserunt.
Quo et sint et ea temporibus repellendus.", new DateTime(2020, 5, 25, 10, 12, 23, 131, DateTimeKind.Local).AddTicks(396), 38, new DateTime(2020, 5, 25, 10, 12, 23, 131, DateTimeKind.Local).AddTicks(402) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 12, "Voluptas repellat dolorem iusto distinctio. Doloribus nostrum quas non aut quis deserunt et. Quod est est iusto. Incidunt recusandae itaque vitae tenetur iure. Dicta ullam officia a velit debitis sed autem.", new DateTime(2020, 5, 25, 10, 12, 23, 131, DateTimeKind.Local).AddTicks(1945), 33, new DateTime(2020, 5, 25, 10, 12, 23, 131, DateTimeKind.Local).AddTicks(1962) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 10, "Accusantium sint ullam veritatis quas magni incidunt.", new DateTime(2020, 5, 25, 10, 12, 23, 131, DateTimeKind.Local).AddTicks(2039), 22, new DateTime(2020, 5, 25, 10, 12, 23, 131, DateTimeKind.Local).AddTicks(2044) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 20, @"Rerum aliquid dolorem dicta.
Inventore vitae deleniti ad aperiam et.", new DateTime(2020, 5, 25, 10, 12, 23, 131, DateTimeKind.Local).AddTicks(2125), 40, new DateTime(2020, 5, 25, 10, 12, 23, 131, DateTimeKind.Local).AddTicks(2131) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 10, "Voluptate iure fugit sed consectetur quaerat eaque velit atque recusandae.", new DateTime(2020, 5, 25, 10, 12, 23, 131, DateTimeKind.Local).AddTicks(2248), 38, new DateTime(2020, 5, 25, 10, 12, 23, 131, DateTimeKind.Local).AddTicks(2254) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 12, "Numquam rem aliquam eum ipsam. Impedit fugit in culpa totam rerum suscipit asperiores aut. Ratione magnam eius qui tempore. Beatae at earum id earum. Sequi occaecati fuga magni possimus rerum illum iusto.", new DateTime(2020, 5, 25, 10, 12, 23, 131, DateTimeKind.Local).AddTicks(2432), 35, new DateTime(2020, 5, 25, 10, 12, 23, 131, DateTimeKind.Local).AddTicks(2437) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "UpdatedAt" },
                values: new object[] { 8, "Enim quo tenetur est ipsam cumque esse voluptatum. Est sit minus ut et debitis qui. Dignissimos quo et accusantium sapiente debitis.", new DateTime(2020, 5, 25, 10, 12, 23, 131, DateTimeKind.Local).AddTicks(2603), new DateTime(2020, 5, 25, 10, 12, 23, 131, DateTimeKind.Local).AddTicks(2609) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 13, "reprehenderit", new DateTime(2020, 5, 25, 10, 12, 23, 131, DateTimeKind.Local).AddTicks(2643), 24, new DateTime(2020, 5, 25, 10, 12, 23, 131, DateTimeKind.Local).AddTicks(2647) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 17, @"Voluptatem quia ea fuga quia.
Fuga et cupiditate non.
Quibusdam odio in vero exercitationem earum ipsa.
Sunt tempora neque tempore enim.
Asperiores reprehenderit magni enim et eveniet illo fugit officiis.", new DateTime(2020, 5, 25, 10, 12, 23, 131, DateTimeKind.Local).AddTicks(2909), 32, new DateTime(2020, 5, 25, 10, 12, 23, 131, DateTimeKind.Local).AddTicks(2915) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 10, "Enim enim illum aut vel.", new DateTime(2020, 5, 25, 10, 12, 23, 131, DateTimeKind.Local).AddTicks(2970), 37, new DateTime(2020, 5, 25, 10, 12, 23, 131, DateTimeKind.Local).AddTicks(2975) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 7, "occaecati", new DateTime(2020, 5, 25, 10, 12, 23, 131, DateTimeKind.Local).AddTicks(3007), 39, new DateTime(2020, 5, 25, 10, 12, 23, 131, DateTimeKind.Local).AddTicks(3011) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 6, "incidunt", new DateTime(2020, 5, 25, 10, 12, 23, 131, DateTimeKind.Local).AddTicks(3042), 31, new DateTime(2020, 5, 25, 10, 12, 23, 131, DateTimeKind.Local).AddTicks(3047) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 17, @"Qui sunt temporibus consequuntur quod dolores deserunt veniam enim deleniti.
Similique vel beatae ipsa eligendi assumenda inventore enim.", new DateTime(2020, 5, 25, 10, 12, 23, 131, DateTimeKind.Local).AddTicks(3244), 29, new DateTime(2020, 5, 25, 10, 12, 23, 131, DateTimeKind.Local).AddTicks(3250) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 19, "Voluptatum blanditiis et numquam aut commodi vel officia temporibus. Sit nesciunt praesentium qui provident quia non. Molestias tenetur in. Quia magnam illo sed omnis dolor magnam nam quia mollitia. Eaque est veniam optio. Ad rerum nam sunt omnis numquam.", new DateTime(2020, 5, 25, 10, 12, 23, 131, DateTimeKind.Local).AddTicks(3537), 35, new DateTime(2020, 5, 25, 10, 12, 23, 131, DateTimeKind.Local).AddTicks(3543) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 15, new DateTime(2020, 5, 25, 10, 12, 22, 967, DateTimeKind.Local).AddTicks(7738), "Nola.Greenholt@yahoo.com", "Hxl+F7DztBCJadpgzohBaqJvWcRyUt2H/D3kU8jynFE=", "wHOZ2r5+MiFt1vTT90n9jJqqjeZv26t1rygLNlTL1Go=", new DateTime(2020, 5, 25, 10, 12, 22, 967, DateTimeKind.Local).AddTicks(8768), "Bud55" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 19, new DateTime(2020, 5, 25, 10, 12, 22, 975, DateTimeKind.Local).AddTicks(7294), "Tressa.Lakin@yahoo.com", "vijnh46YseuVudGTb2rL4KjCGc4KmI04nPiho3/cxvE=", "+vGOnXvEWiqC7kvEJkeQMdsrJHjWQXnX5r4YmrGa9tw=", new DateTime(2020, 5, 25, 10, 12, 22, 975, DateTimeKind.Local).AddTicks(7345), "Teresa_Schuster" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 4, new DateTime(2020, 5, 25, 10, 12, 22, 983, DateTimeKind.Local).AddTicks(3216), "Queenie_McClure@gmail.com", "iXPxF6VAWptdhaZWLHXEGq2ttmxUYIdkqtfCcAcL3kY=", "IwvsHU9blGhZXstNoxxDzcsAzviCKWPm/P35K7T7/CI=", new DateTime(2020, 5, 25, 10, 12, 22, 983, DateTimeKind.Local).AddTicks(3232), "Raven68" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 19, new DateTime(2020, 5, 25, 10, 12, 22, 990, DateTimeKind.Local).AddTicks(8621), "Morris63@hotmail.com", "7n9T1GaZIgX9IVE33x6bI5MloERqaoZbQaJGO8IKuFk=", "0Tf/jqpL3Dc53vgBdjszuLepTKdZYchOXBscgs6Gwz8=", new DateTime(2020, 5, 25, 10, 12, 22, 990, DateTimeKind.Local).AddTicks(8650), "Mariam.Cartwright54" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 17, new DateTime(2020, 5, 25, 10, 12, 22, 998, DateTimeKind.Local).AddTicks(4071), "Mazie9@hotmail.com", "ndg1+nlugyCK3exUR/O5XhnLWjYQBMRF1q6aY6KNRJo=", "dZIXum27GaWiALGRJ1qNxzVxmsIJOx1mUdHtROqKD3M=", new DateTime(2020, 5, 25, 10, 12, 22, 998, DateTimeKind.Local).AddTicks(4089), "Monty63" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 15, new DateTime(2020, 5, 25, 10, 12, 23, 5, DateTimeKind.Local).AddTicks(9974), "Gaston.Nikolaus56@gmail.com", "pG7kCBxu0uXciBMDru7iAuLPt+fiGGCzsjNYGmicmN0=", "HNLU+GJ5sqBmMeVkt+xvkXVwGwRhzCBEQh0fQ0URW4U=", new DateTime(2020, 5, 25, 10, 12, 23, 6, DateTimeKind.Local).AddTicks(15), "Houston_Murazik79" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 12, new DateTime(2020, 5, 25, 10, 12, 23, 13, DateTimeKind.Local).AddTicks(5469), "Eleazar97@yahoo.com", "R7n6uvieRMpdN1RFO1ptCchN6ngzpRJtbWtMu+s8aEo=", "cYSvNxNKqdWJE8EVitgVvLKHRcGK4Pfv8HGWrr7YsR0=", new DateTime(2020, 5, 25, 10, 12, 23, 13, DateTimeKind.Local).AddTicks(5480), "Dedrick_Kuvalis46" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 8, new DateTime(2020, 5, 25, 10, 12, 23, 21, DateTimeKind.Local).AddTicks(851), "Emma78@yahoo.com", "LGfClcjWVResd4dV3tI+0jSmAE3VzxTXFI6DgsY+UxA=", "QM8oeuhQ/1vaNAViFenxhHaVom+2lvf7+W6CsDdtDD8=", new DateTime(2020, 5, 25, 10, 12, 23, 21, DateTimeKind.Local).AddTicks(872), "Stan.Funk43" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 8, new DateTime(2020, 5, 25, 10, 12, 23, 28, DateTimeKind.Local).AddTicks(7227), "Brigitte73@gmail.com", "/kkuGgucCpXkN0kIDABTn2oBXv7cXyrx+9pwp9ryKyk=", "2xFcEneS2tV8xNRYg25xuATddoVLrOCE//2Zn/hy9p0=", new DateTime(2020, 5, 25, 10, 12, 23, 28, DateTimeKind.Local).AddTicks(7262), "Miracle_Ritchie" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 6, new DateTime(2020, 5, 25, 10, 12, 23, 36, DateTimeKind.Local).AddTicks(2834), "Ayden.Schoen@hotmail.com", "ce3XAVsEwmy+THI4hYH3K29EeTUgVASSEXNF+KycTXc=", "eJm15ZaUq51che3lwCEBfwMbZB43td1QKk1vbzeOVS8=", new DateTime(2020, 5, 25, 10, 12, 23, 36, DateTimeKind.Local).AddTicks(2849), "Mya68" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 8, new DateTime(2020, 5, 25, 10, 12, 23, 43, DateTimeKind.Local).AddTicks(8090), "Louvenia39@yahoo.com", "wUE2ViyBFW5oMX85UL0a2qDBVQvBAtXqajQBS0HYCYA=", "vVWHIGT1JKkpW2gCU4F6/NRgPFi1F0ZmB+xErnl3stc=", new DateTime(2020, 5, 25, 10, 12, 23, 43, DateTimeKind.Local).AddTicks(8101), "Afton.Collier63" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 14, new DateTime(2020, 5, 25, 10, 12, 23, 51, DateTimeKind.Local).AddTicks(3254), "Margarett.Leuschke3@gmail.com", "UpR3mD6xqW0X2+v9ajT0VpG4gJrz3BcxmshyZcWT82M=", "VT6d5d0pDVLjffvrV8n9ZKz0zxknvNUfL+MrFoFLys8=", new DateTime(2020, 5, 25, 10, 12, 23, 51, DateTimeKind.Local).AddTicks(3265), "Penelope.Cole40" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 8, new DateTime(2020, 5, 25, 10, 12, 23, 59, DateTimeKind.Local).AddTicks(1595), "Dakota_Gleichner@yahoo.com", "uYhvqhlNF+qrBwAkOj781e9JAge2p8ujr+rumlznJ48=", "9qZXjgXIZt+eZFet6mvWDSCHGUQ+US5nwe/My4fSF3o=", new DateTime(2020, 5, 25, 10, 12, 23, 59, DateTimeKind.Local).AddTicks(1657), "Betsy_Kutch91" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 6, new DateTime(2020, 5, 25, 10, 12, 23, 66, DateTimeKind.Local).AddTicks(7713), "Conor.Wiza@gmail.com", "slPkqrpay3yU+imem0WcgjmO64/f5d9xIMJR5J0hTWY=", "qBSyBi5bjm/rX0PsdKgctxcwrISE8qfORZLgY+o5Aro=", new DateTime(2020, 5, 25, 10, 12, 23, 66, DateTimeKind.Local).AddTicks(7731), "Natalie_Jenkins67" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 13, new DateTime(2020, 5, 25, 10, 12, 23, 74, DateTimeKind.Local).AddTicks(3638), "Katrina.Ortiz91@yahoo.com", "WovoAyktIatxMZYKVCPrn+ks52/bscxFa1ywkD1G3hM=", "sJMVa0UV5Ub5y/drZTFIzjhhMDjJQWivNqss1pCvfWg=", new DateTime(2020, 5, 25, 10, 12, 23, 74, DateTimeKind.Local).AddTicks(3664), "Mackenzie38" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 10, new DateTime(2020, 5, 25, 10, 12, 23, 81, DateTimeKind.Local).AddTicks(9310), "Darion75@gmail.com", "tz9Kr2QPejPiS39Bx4LQK1mRInEiCjKs3nzVEj/7OIw=", "T6AsDdA5c5L8C5JUCykpij9+jxkMXi5owkWaKm0NRCQ=", new DateTime(2020, 5, 25, 10, 12, 23, 81, DateTimeKind.Local).AddTicks(9330), "Florence94" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 3, new DateTime(2020, 5, 25, 10, 12, 23, 89, DateTimeKind.Local).AddTicks(4377), "Oma21@gmail.com", "UVPQfsqUf978KTzqOlDq9bTFLz2bUYDDGiLljExlMtM=", "EQRl0mBoGhuYHDsPi4cG73tPGSsoLkT3Orn/z3GMfoo=", new DateTime(2020, 5, 25, 10, 12, 23, 89, DateTimeKind.Local).AddTicks(4387), "Jamil_Hermann67" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 13, new DateTime(2020, 5, 25, 10, 12, 23, 96, DateTimeKind.Local).AddTicks(9711), "Yvette_McKenzie69@gmail.com", "tGie8AdHWLt0DRbsDS7vuMTNcniLJ1BM4Z2BsauphCI=", "n3/qiVWucDMemQfzqDPJQhkg7xru5w8YDZ1vXYLuy60=", new DateTime(2020, 5, 25, 10, 12, 23, 96, DateTimeKind.Local).AddTicks(9731), "Margarette_Lakin36" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 19, new DateTime(2020, 5, 25, 10, 12, 23, 104, DateTimeKind.Local).AddTicks(5384), "Taurean_Davis@hotmail.com", "c8Y+VNjw712Krc7YBw6gPTYicYibL9BpDeQCcReBBCo=", "MdTBK/h+UGyiCsJngDkYVz++jFr+WZlQi4LCx1Y8ejU=", new DateTime(2020, 5, 25, 10, 12, 23, 104, DateTimeKind.Local).AddTicks(5402), "Lillian_Adams" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 11, new DateTime(2020, 5, 25, 10, 12, 23, 112, DateTimeKind.Local).AddTicks(1052), "Raul69@yahoo.com", "D8ofsECMryDEHIXklQr+dhJB1Q9xccB3BLRRwXlifj0=", "kMTxRx2Nd25ThOGizTpTRiX/JN6bebTQS39r+lDWP80=", new DateTime(2020, 5, 25, 10, 12, 23, 112, DateTimeKind.Local).AddTicks(1392), "Keith.Kohler" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "Password", "Salt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 25, 10, 12, 23, 119, DateTimeKind.Local).AddTicks(7306), "8SFVF2XU2HKZl/6HP4bdQWs+HcVdX+1dA36nQcJUGPw=", "SL+swrGM+Zjprs5cXtTYKLKJchf8mC8Tm8RIvosaLTo=", new DateTime(2020, 5, 25, 10, 12, 23, 119, DateTimeKind.Local).AddTicks(7306) });
        }
    }
}
