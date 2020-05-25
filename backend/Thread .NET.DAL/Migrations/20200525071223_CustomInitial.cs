using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Thread_.NET.DAL.Migrations
{
    public partial class CustomInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    URL = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    AvatarId = table.Column<int>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Salt = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Images_AvatarId",
                        column: x => x.AvatarId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    AuthorId = table.Column<int>(nullable: false),
                    PreviewId = table.Column<int>(nullable: true),
                    Body = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_Users_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Posts_Images_PreviewId",
                        column: x => x.PreviewId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RefreshTokens",
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
                    table.PrimaryKey("PK_RefreshTokens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RefreshTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    AuthorId = table.Column<int>(nullable: false),
                    PostId = table.Column<int>(nullable: false),
                    Body = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Users_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PostNegativeReactions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    IsDislike = table.Column<bool>(nullable: false),
                    PostId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostNegativeReactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostNegativeReactions_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PostNegativeReactions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PostReactions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    IsLike = table.Column<bool>(nullable: false),
                    PostId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostReactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostReactions_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PostReactions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CommentNegativeReactions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    IsDislike = table.Column<bool>(nullable: false),
                    CommentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommentNegativeReactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CommentNegativeReactions_Comments_CommentId",
                        column: x => x.CommentId,
                        principalTable: "Comments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CommentNegativeReactions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CommentReactions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    IsLike = table.Column<bool>(nullable: false),
                    CommentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommentReactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CommentReactions_Comments_CommentId",
                        column: x => x.CommentId,
                        principalTable: "Comments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CommentReactions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedAt", "URL", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(3556), "https://s3.amazonaws.com/uifaces/faces/twitter/jnmnrd/128.jpg", new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(8202) },
                    { 23, new DateTime(2020, 5, 25, 10, 12, 22, 931, DateTimeKind.Local).AddTicks(27), "https://picsum.photos/640/480/?image=674", new DateTime(2020, 5, 25, 10, 12, 22, 931, DateTimeKind.Local).AddTicks(33) },
                    { 24, new DateTime(2020, 5, 25, 10, 12, 22, 931, DateTimeKind.Local).AddTicks(52), "https://picsum.photos/640/480/?image=966", new DateTime(2020, 5, 25, 10, 12, 22, 931, DateTimeKind.Local).AddTicks(57) },
                    { 25, new DateTime(2020, 5, 25, 10, 12, 22, 931, DateTimeKind.Local).AddTicks(75), "https://picsum.photos/640/480/?image=371", new DateTime(2020, 5, 25, 10, 12, 22, 931, DateTimeKind.Local).AddTicks(80) },
                    { 26, new DateTime(2020, 5, 25, 10, 12, 22, 931, DateTimeKind.Local).AddTicks(99), "https://picsum.photos/640/480/?image=1037", new DateTime(2020, 5, 25, 10, 12, 22, 931, DateTimeKind.Local).AddTicks(103) },
                    { 27, new DateTime(2020, 5, 25, 10, 12, 22, 931, DateTimeKind.Local).AddTicks(123), "https://picsum.photos/640/480/?image=911", new DateTime(2020, 5, 25, 10, 12, 22, 931, DateTimeKind.Local).AddTicks(127) },
                    { 28, new DateTime(2020, 5, 25, 10, 12, 22, 931, DateTimeKind.Local).AddTicks(146), "https://picsum.photos/640/480/?image=574", new DateTime(2020, 5, 25, 10, 12, 22, 931, DateTimeKind.Local).AddTicks(151) },
                    { 29, new DateTime(2020, 5, 25, 10, 12, 22, 931, DateTimeKind.Local).AddTicks(170), "https://picsum.photos/640/480/?image=64", new DateTime(2020, 5, 25, 10, 12, 22, 931, DateTimeKind.Local).AddTicks(175) },
                    { 30, new DateTime(2020, 5, 25, 10, 12, 22, 931, DateTimeKind.Local).AddTicks(194), "https://picsum.photos/640/480/?image=315", new DateTime(2020, 5, 25, 10, 12, 22, 931, DateTimeKind.Local).AddTicks(198) },
                    { 31, new DateTime(2020, 5, 25, 10, 12, 22, 931, DateTimeKind.Local).AddTicks(217), "https://picsum.photos/640/480/?image=742", new DateTime(2020, 5, 25, 10, 12, 22, 931, DateTimeKind.Local).AddTicks(221) },
                    { 32, new DateTime(2020, 5, 25, 10, 12, 22, 931, DateTimeKind.Local).AddTicks(240), "https://picsum.photos/640/480/?image=510", new DateTime(2020, 5, 25, 10, 12, 22, 931, DateTimeKind.Local).AddTicks(244) },
                    { 33, new DateTime(2020, 5, 25, 10, 12, 22, 931, DateTimeKind.Local).AddTicks(263), "https://picsum.photos/640/480/?image=39", new DateTime(2020, 5, 25, 10, 12, 22, 931, DateTimeKind.Local).AddTicks(268) },
                    { 34, new DateTime(2020, 5, 25, 10, 12, 22, 931, DateTimeKind.Local).AddTicks(287), "https://picsum.photos/640/480/?image=553", new DateTime(2020, 5, 25, 10, 12, 22, 931, DateTimeKind.Local).AddTicks(291) },
                    { 35, new DateTime(2020, 5, 25, 10, 12, 22, 931, DateTimeKind.Local).AddTicks(350), "https://picsum.photos/640/480/?image=606", new DateTime(2020, 5, 25, 10, 12, 22, 931, DateTimeKind.Local).AddTicks(355) },
                    { 36, new DateTime(2020, 5, 25, 10, 12, 22, 931, DateTimeKind.Local).AddTicks(374), "https://picsum.photos/640/480/?image=725", new DateTime(2020, 5, 25, 10, 12, 22, 931, DateTimeKind.Local).AddTicks(379) },
                    { 37, new DateTime(2020, 5, 25, 10, 12, 22, 931, DateTimeKind.Local).AddTicks(398), "https://picsum.photos/640/480/?image=882", new DateTime(2020, 5, 25, 10, 12, 22, 931, DateTimeKind.Local).AddTicks(402) },
                    { 38, new DateTime(2020, 5, 25, 10, 12, 22, 931, DateTimeKind.Local).AddTicks(421), "https://picsum.photos/640/480/?image=289", new DateTime(2020, 5, 25, 10, 12, 22, 931, DateTimeKind.Local).AddTicks(426) },
                    { 39, new DateTime(2020, 5, 25, 10, 12, 22, 931, DateTimeKind.Local).AddTicks(445), "https://picsum.photos/640/480/?image=53", new DateTime(2020, 5, 25, 10, 12, 22, 931, DateTimeKind.Local).AddTicks(449) },
                    { 22, new DateTime(2020, 5, 25, 10, 12, 22, 930, DateTimeKind.Local).AddTicks(9968), "https://picsum.photos/640/480/?image=483", new DateTime(2020, 5, 25, 10, 12, 22, 930, DateTimeKind.Local).AddTicks(9998) },
                    { 40, new DateTime(2020, 5, 25, 10, 12, 22, 931, DateTimeKind.Local).AddTicks(468), "https://picsum.photos/640/480/?image=657", new DateTime(2020, 5, 25, 10, 12, 22, 931, DateTimeKind.Local).AddTicks(472) },
                    { 21, new DateTime(2020, 5, 25, 10, 12, 22, 930, DateTimeKind.Local).AddTicks(8825), "https://picsum.photos/640/480/?image=406", new DateTime(2020, 5, 25, 10, 12, 22, 930, DateTimeKind.Local).AddTicks(9624) },
                    { 19, new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(9511), "https://s3.amazonaws.com/uifaces/faces/twitter/hermanobrother/128.jpg", new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(9515) },
                    { 2, new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(9060), "https://s3.amazonaws.com/uifaces/faces/twitter/lisovsky/128.jpg", new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(9087) },
                    { 3, new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(9120), "https://s3.amazonaws.com/uifaces/faces/twitter/marciotoledo/128.jpg", new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(9125) },
                    { 4, new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(9146), "https://s3.amazonaws.com/uifaces/faces/twitter/sprayaga/128.jpg", new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(9150) },
                    { 5, new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(9170), "https://s3.amazonaws.com/uifaces/faces/twitter/abdullindenis/128.jpg", new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(9175) },
                    { 6, new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(9194), "https://s3.amazonaws.com/uifaces/faces/twitter/strikewan/128.jpg", new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(9199) },
                    { 7, new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(9219), "https://s3.amazonaws.com/uifaces/faces/twitter/cbracco/128.jpg", new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(9223) },
                    { 8, new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(9243), "https://s3.amazonaws.com/uifaces/faces/twitter/betraydan/128.jpg", new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(9248) },
                    { 9, new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(9267), "https://s3.amazonaws.com/uifaces/faces/twitter/adhiardana/128.jpg", new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(9272) },
                    { 10, new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(9291), "https://s3.amazonaws.com/uifaces/faces/twitter/rude/128.jpg", new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(9295) },
                    { 11, new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(9316), "https://s3.amazonaws.com/uifaces/faces/twitter/Stievius/128.jpg", new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(9321) },
                    { 12, new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(9341), "https://s3.amazonaws.com/uifaces/faces/twitter/vimarethomas/128.jpg", new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(9345) },
                    { 13, new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(9364), "https://s3.amazonaws.com/uifaces/faces/twitter/we_social/128.jpg", new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(9369) },
                    { 14, new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(9391), "https://s3.amazonaws.com/uifaces/faces/twitter/jayphen/128.jpg", new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(9396) },
                    { 15, new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(9416), "https://s3.amazonaws.com/uifaces/faces/twitter/buddhasource/128.jpg", new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(9421) },
                    { 16, new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(9440), "https://s3.amazonaws.com/uifaces/faces/twitter/thehacker/128.jpg", new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(9445) },
                    { 17, new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(9464), "https://s3.amazonaws.com/uifaces/faces/twitter/mizko/128.jpg", new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(9468) },
                    { 18, new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(9487), "https://s3.amazonaws.com/uifaces/faces/twitter/nepdud/128.jpg", new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(9491) },
                    { 20, new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(9533), "https://s3.amazonaws.com/uifaces/faces/twitter/petebernardo/128.jpg", new DateTime(2020, 5, 25, 10, 12, 22, 925, DateTimeKind.Local).AddTicks(9538) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 21, null, new DateTime(2020, 5, 25, 10, 12, 23, 119, DateTimeKind.Local).AddTicks(7306), "test@gmail.com", "8SFVF2XU2HKZl/6HP4bdQWs+HcVdX+1dA36nQcJUGPw=", "SL+swrGM+Zjprs5cXtTYKLKJchf8mC8Tm8RIvosaLTo=", new DateTime(2020, 5, 25, 10, 12, 23, 119, DateTimeKind.Local).AddTicks(7306), "testUser" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { 17, 3, new DateTime(2020, 5, 25, 10, 12, 23, 89, DateTimeKind.Local).AddTicks(4377), "Oma21@gmail.com", "UVPQfsqUf978KTzqOlDq9bTFLz2bUYDDGiLljExlMtM=", "EQRl0mBoGhuYHDsPi4cG73tPGSsoLkT3Orn/z3GMfoo=", new DateTime(2020, 5, 25, 10, 12, 23, 89, DateTimeKind.Local).AddTicks(4387), "Jamil_Hermann67" },
                    { 2, 19, new DateTime(2020, 5, 25, 10, 12, 22, 975, DateTimeKind.Local).AddTicks(7294), "Tressa.Lakin@yahoo.com", "vijnh46YseuVudGTb2rL4KjCGc4KmI04nPiho3/cxvE=", "+vGOnXvEWiqC7kvEJkeQMdsrJHjWQXnX5r4YmrGa9tw=", new DateTime(2020, 5, 25, 10, 12, 22, 975, DateTimeKind.Local).AddTicks(7345), "Teresa_Schuster" },
                    { 5, 17, new DateTime(2020, 5, 25, 10, 12, 22, 998, DateTimeKind.Local).AddTicks(4071), "Mazie9@hotmail.com", "ndg1+nlugyCK3exUR/O5XhnLWjYQBMRF1q6aY6KNRJo=", "dZIXum27GaWiALGRJ1qNxzVxmsIJOx1mUdHtROqKD3M=", new DateTime(2020, 5, 25, 10, 12, 22, 998, DateTimeKind.Local).AddTicks(4089), "Monty63" },
                    { 6, 15, new DateTime(2020, 5, 25, 10, 12, 23, 5, DateTimeKind.Local).AddTicks(9974), "Gaston.Nikolaus56@gmail.com", "pG7kCBxu0uXciBMDru7iAuLPt+fiGGCzsjNYGmicmN0=", "HNLU+GJ5sqBmMeVkt+xvkXVwGwRhzCBEQh0fQ0URW4U=", new DateTime(2020, 5, 25, 10, 12, 23, 6, DateTimeKind.Local).AddTicks(15), "Houston_Murazik79" },
                    { 1, 15, new DateTime(2020, 5, 25, 10, 12, 22, 967, DateTimeKind.Local).AddTicks(7738), "Nola.Greenholt@yahoo.com", "Hxl+F7DztBCJadpgzohBaqJvWcRyUt2H/D3kU8jynFE=", "wHOZ2r5+MiFt1vTT90n9jJqqjeZv26t1rygLNlTL1Go=", new DateTime(2020, 5, 25, 10, 12, 22, 967, DateTimeKind.Local).AddTicks(8768), "Bud55" },
                    { 12, 14, new DateTime(2020, 5, 25, 10, 12, 23, 51, DateTimeKind.Local).AddTicks(3254), "Margarett.Leuschke3@gmail.com", "UpR3mD6xqW0X2+v9ajT0VpG4gJrz3BcxmshyZcWT82M=", "VT6d5d0pDVLjffvrV8n9ZKz0zxknvNUfL+MrFoFLys8=", new DateTime(2020, 5, 25, 10, 12, 23, 51, DateTimeKind.Local).AddTicks(3265), "Penelope.Cole40" },
                    { 18, 13, new DateTime(2020, 5, 25, 10, 12, 23, 96, DateTimeKind.Local).AddTicks(9711), "Yvette_McKenzie69@gmail.com", "tGie8AdHWLt0DRbsDS7vuMTNcniLJ1BM4Z2BsauphCI=", "n3/qiVWucDMemQfzqDPJQhkg7xru5w8YDZ1vXYLuy60=", new DateTime(2020, 5, 25, 10, 12, 23, 96, DateTimeKind.Local).AddTicks(9731), "Margarette_Lakin36" },
                    { 15, 13, new DateTime(2020, 5, 25, 10, 12, 23, 74, DateTimeKind.Local).AddTicks(3638), "Katrina.Ortiz91@yahoo.com", "WovoAyktIatxMZYKVCPrn+ks52/bscxFa1ywkD1G3hM=", "sJMVa0UV5Ub5y/drZTFIzjhhMDjJQWivNqss1pCvfWg=", new DateTime(2020, 5, 25, 10, 12, 23, 74, DateTimeKind.Local).AddTicks(3664), "Mackenzie38" },
                    { 7, 12, new DateTime(2020, 5, 25, 10, 12, 23, 13, DateTimeKind.Local).AddTicks(5469), "Eleazar97@yahoo.com", "R7n6uvieRMpdN1RFO1ptCchN6ngzpRJtbWtMu+s8aEo=", "cYSvNxNKqdWJE8EVitgVvLKHRcGK4Pfv8HGWrr7YsR0=", new DateTime(2020, 5, 25, 10, 12, 23, 13, DateTimeKind.Local).AddTicks(5480), "Dedrick_Kuvalis46" },
                    { 20, 11, new DateTime(2020, 5, 25, 10, 12, 23, 112, DateTimeKind.Local).AddTicks(1052), "Raul69@yahoo.com", "D8ofsECMryDEHIXklQr+dhJB1Q9xccB3BLRRwXlifj0=", "kMTxRx2Nd25ThOGizTpTRiX/JN6bebTQS39r+lDWP80=", new DateTime(2020, 5, 25, 10, 12, 23, 112, DateTimeKind.Local).AddTicks(1392), "Keith.Kohler" },
                    { 16, 10, new DateTime(2020, 5, 25, 10, 12, 23, 81, DateTimeKind.Local).AddTicks(9310), "Darion75@gmail.com", "tz9Kr2QPejPiS39Bx4LQK1mRInEiCjKs3nzVEj/7OIw=", "T6AsDdA5c5L8C5JUCykpij9+jxkMXi5owkWaKm0NRCQ=", new DateTime(2020, 5, 25, 10, 12, 23, 81, DateTimeKind.Local).AddTicks(9330), "Florence94" },
                    { 13, 8, new DateTime(2020, 5, 25, 10, 12, 23, 59, DateTimeKind.Local).AddTicks(1595), "Dakota_Gleichner@yahoo.com", "uYhvqhlNF+qrBwAkOj781e9JAge2p8ujr+rumlznJ48=", "9qZXjgXIZt+eZFet6mvWDSCHGUQ+US5nwe/My4fSF3o=", new DateTime(2020, 5, 25, 10, 12, 23, 59, DateTimeKind.Local).AddTicks(1657), "Betsy_Kutch91" },
                    { 11, 8, new DateTime(2020, 5, 25, 10, 12, 23, 43, DateTimeKind.Local).AddTicks(8090), "Louvenia39@yahoo.com", "wUE2ViyBFW5oMX85UL0a2qDBVQvBAtXqajQBS0HYCYA=", "vVWHIGT1JKkpW2gCU4F6/NRgPFi1F0ZmB+xErnl3stc=", new DateTime(2020, 5, 25, 10, 12, 23, 43, DateTimeKind.Local).AddTicks(8101), "Afton.Collier63" },
                    { 9, 8, new DateTime(2020, 5, 25, 10, 12, 23, 28, DateTimeKind.Local).AddTicks(7227), "Brigitte73@gmail.com", "/kkuGgucCpXkN0kIDABTn2oBXv7cXyrx+9pwp9ryKyk=", "2xFcEneS2tV8xNRYg25xuATddoVLrOCE//2Zn/hy9p0=", new DateTime(2020, 5, 25, 10, 12, 23, 28, DateTimeKind.Local).AddTicks(7262), "Miracle_Ritchie" },
                    { 8, 8, new DateTime(2020, 5, 25, 10, 12, 23, 21, DateTimeKind.Local).AddTicks(851), "Emma78@yahoo.com", "LGfClcjWVResd4dV3tI+0jSmAE3VzxTXFI6DgsY+UxA=", "QM8oeuhQ/1vaNAViFenxhHaVom+2lvf7+W6CsDdtDD8=", new DateTime(2020, 5, 25, 10, 12, 23, 21, DateTimeKind.Local).AddTicks(872), "Stan.Funk43" },
                    { 14, 6, new DateTime(2020, 5, 25, 10, 12, 23, 66, DateTimeKind.Local).AddTicks(7713), "Conor.Wiza@gmail.com", "slPkqrpay3yU+imem0WcgjmO64/f5d9xIMJR5J0hTWY=", "qBSyBi5bjm/rX0PsdKgctxcwrISE8qfORZLgY+o5Aro=", new DateTime(2020, 5, 25, 10, 12, 23, 66, DateTimeKind.Local).AddTicks(7731), "Natalie_Jenkins67" },
                    { 10, 6, new DateTime(2020, 5, 25, 10, 12, 23, 36, DateTimeKind.Local).AddTicks(2834), "Ayden.Schoen@hotmail.com", "ce3XAVsEwmy+THI4hYH3K29EeTUgVASSEXNF+KycTXc=", "eJm15ZaUq51che3lwCEBfwMbZB43td1QKk1vbzeOVS8=", new DateTime(2020, 5, 25, 10, 12, 23, 36, DateTimeKind.Local).AddTicks(2849), "Mya68" },
                    { 3, 4, new DateTime(2020, 5, 25, 10, 12, 22, 983, DateTimeKind.Local).AddTicks(3216), "Queenie_McClure@gmail.com", "iXPxF6VAWptdhaZWLHXEGq2ttmxUYIdkqtfCcAcL3kY=", "IwvsHU9blGhZXstNoxxDzcsAzviCKWPm/P35K7T7/CI=", new DateTime(2020, 5, 25, 10, 12, 22, 983, DateTimeKind.Local).AddTicks(3232), "Raven68" },
                    { 4, 19, new DateTime(2020, 5, 25, 10, 12, 22, 990, DateTimeKind.Local).AddTicks(8621), "Morris63@hotmail.com", "7n9T1GaZIgX9IVE33x6bI5MloERqaoZbQaJGO8IKuFk=", "0Tf/jqpL3Dc53vgBdjszuLepTKdZYchOXBscgs6Gwz8=", new DateTime(2020, 5, 25, 10, 12, 22, 990, DateTimeKind.Local).AddTicks(8650), "Mariam.Cartwright54" },
                    { 19, 19, new DateTime(2020, 5, 25, 10, 12, 23, 104, DateTimeKind.Local).AddTicks(5384), "Taurean_Davis@hotmail.com", "c8Y+VNjw712Krc7YBw6gPTYicYibL9BpDeQCcReBBCo=", "MdTBK/h+UGyiCsJngDkYVz++jFr+WZlQi4LCx1Y8ejU=", new DateTime(2020, 5, 25, 10, 12, 23, 104, DateTimeKind.Local).AddTicks(5402), "Lillian_Adams" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[,]
                {
                    { 15, 17, @"Voluptatem quia ea fuga quia.
                Fuga et cupiditate non.
                Quibusdam odio in vero exercitationem earum ipsa.
                Sunt tempora neque tempore enim.
                Asperiores reprehenderit magni enim et eveniet illo fugit officiis.", new DateTime(2020, 5, 25, 10, 12, 23, 131, DateTimeKind.Local).AddTicks(2909), 32, new DateTime(2020, 5, 25, 10, 12, 23, 131, DateTimeKind.Local).AddTicks(2915) },
                    { 12, 12, "Numquam rem aliquam eum ipsam. Impedit fugit in culpa totam rerum suscipit asperiores aut. Ratione magnam eius qui tempore. Beatae at earum id earum. Sequi occaecati fuga magni possimus rerum illum iusto.", new DateTime(2020, 5, 25, 10, 12, 23, 131, DateTimeKind.Local).AddTicks(2432), 35, new DateTime(2020, 5, 25, 10, 12, 23, 131, DateTimeKind.Local).AddTicks(2437) },
                    { 8, 12, "Voluptas repellat dolorem iusto distinctio. Doloribus nostrum quas non aut quis deserunt et. Quod est est iusto. Incidunt recusandae itaque vitae tenetur iure. Dicta ullam officia a velit debitis sed autem.", new DateTime(2020, 5, 25, 10, 12, 23, 131, DateTimeKind.Local).AddTicks(1945), 33, new DateTime(2020, 5, 25, 10, 12, 23, 131, DateTimeKind.Local).AddTicks(1962) },
                    { 2, 12, "vel", new DateTime(2020, 5, 25, 10, 12, 23, 130, DateTimeKind.Local).AddTicks(6049), 27, new DateTime(2020, 5, 25, 10, 12, 23, 130, DateTimeKind.Local).AddTicks(6078) },
                    { 17, 7, "occaecati", new DateTime(2020, 5, 25, 10, 12, 23, 131, DateTimeKind.Local).AddTicks(3007), 39, new DateTime(2020, 5, 25, 10, 12, 23, 131, DateTimeKind.Local).AddTicks(3011) },
                    { 7, 7, @"Ipsa accusantium officiis dicta voluptatum et.
                Qui cupiditate quia quidem porro eos enim qui voluptates deserunt.
                Quo et sint et ea temporibus repellendus.", new DateTime(2020, 5, 25, 10, 12, 23, 131, DateTimeKind.Local).AddTicks(396), 38, new DateTime(2020, 5, 25, 10, 12, 23, 131, DateTimeKind.Local).AddTicks(402) },
                    { 10, 20, @"Rerum aliquid dolorem dicta.
                Inventore vitae deleniti ad aperiam et.", new DateTime(2020, 5, 25, 10, 12, 23, 131, DateTimeKind.Local).AddTicks(2125), 40, new DateTime(2020, 5, 25, 10, 12, 23, 131, DateTimeKind.Local).AddTicks(2131) },
                    { 5, 20, @"Voluptatum voluptas repudiandae qui earum suscipit.
                Tenetur quis quia omnis aut qui est ut.
                Ipsum laboriosam aliquam voluptas eum id et.
                Quia tenetur aut qui eum est.
                Ut cumque est et vel voluptatibus.
                Aspernatur id fugit accusantium vel blanditiis.", new DateTime(2020, 5, 25, 10, 12, 23, 131, DateTimeKind.Local).AddTicks(148), 31, new DateTime(2020, 5, 25, 10, 12, 23, 131, DateTimeKind.Local).AddTicks(156) },
                    { 14, 13, "reprehenderit", new DateTime(2020, 5, 25, 10, 12, 23, 131, DateTimeKind.Local).AddTicks(2643), 24, new DateTime(2020, 5, 25, 10, 12, 23, 131, DateTimeKind.Local).AddTicks(2647) },
                    { 6, 11, "enim", new DateTime(2020, 5, 25, 10, 12, 23, 131, DateTimeKind.Local).AddTicks(196), 37, new DateTime(2020, 5, 25, 10, 12, 23, 131, DateTimeKind.Local).AddTicks(201) },
                    { 13, 8, "Enim quo tenetur est ipsam cumque esse voluptatum. Est sit minus ut et debitis qui. Dignissimos quo et accusantium sapiente debitis.", new DateTime(2020, 5, 25, 10, 12, 23, 131, DateTimeKind.Local).AddTicks(2603), 40, new DateTime(2020, 5, 25, 10, 12, 23, 131, DateTimeKind.Local).AddTicks(2609) },
                    { 4, 14, @"Impedit eveniet voluptates eaque quasi.
                Reiciendis aspernatur nam enim eveniet et dicta autem ab.", new DateTime(2020, 5, 25, 10, 12, 23, 130, DateTimeKind.Local).AddTicks(9710), 37, new DateTime(2020, 5, 25, 10, 12, 23, 130, DateTimeKind.Local).AddTicks(9733) },
                    { 3, 14, "Voluptates placeat aut sunt ut recusandae aut rem.", new DateTime(2020, 5, 25, 10, 12, 23, 130, DateTimeKind.Local).AddTicks(6292), 24, new DateTime(2020, 5, 25, 10, 12, 23, 130, DateTimeKind.Local).AddTicks(6299) },
                    { 16, 10, "Enim enim illum aut vel.", new DateTime(2020, 5, 25, 10, 12, 23, 131, DateTimeKind.Local).AddTicks(2970), 37, new DateTime(2020, 5, 25, 10, 12, 23, 131, DateTimeKind.Local).AddTicks(2975) },
                    { 11, 10, "Voluptate iure fugit sed consectetur quaerat eaque velit atque recusandae.", new DateTime(2020, 5, 25, 10, 12, 23, 131, DateTimeKind.Local).AddTicks(2248), 38, new DateTime(2020, 5, 25, 10, 12, 23, 131, DateTimeKind.Local).AddTicks(2254) },
                    { 9, 10, "Accusantium sint ullam veritatis quas magni incidunt.", new DateTime(2020, 5, 25, 10, 12, 23, 131, DateTimeKind.Local).AddTicks(2039), 22, new DateTime(2020, 5, 25, 10, 12, 23, 131, DateTimeKind.Local).AddTicks(2044) },
                    { 1, 10, "Quo possimus commodi iure atque qui sed.", new DateTime(2020, 5, 25, 10, 12, 23, 130, DateTimeKind.Local).AddTicks(3780), 34, new DateTime(2020, 5, 25, 10, 12, 23, 130, DateTimeKind.Local).AddTicks(4606) },
                    { 19, 17, @"Qui sunt temporibus consequuntur quod dolores deserunt veniam enim deleniti.
                Similique vel beatae ipsa eligendi assumenda inventore enim.", new DateTime(2020, 5, 25, 10, 12, 23, 131, DateTimeKind.Local).AddTicks(3244), 29, new DateTime(2020, 5, 25, 10, 12, 23, 131, DateTimeKind.Local).AddTicks(3250) },
                    { 18, 6, "incidunt", new DateTime(2020, 5, 25, 10, 12, 23, 131, DateTimeKind.Local).AddTicks(3042), 31, new DateTime(2020, 5, 25, 10, 12, 23, 131, DateTimeKind.Local).AddTicks(3047) },
                    { 20, 19, "Voluptatum blanditiis et numquam aut commodi vel officia temporibus. Sit nesciunt praesentium qui provident quia non. Molestias tenetur in. Quia magnam illo sed omnis dolor magnam nam quia mollitia. Eaque est veniam optio. Ad rerum nam sunt omnis numquam.", new DateTime(2020, 5, 25, 10, 12, 23, 131, DateTimeKind.Local).AddTicks(3537), 35, new DateTime(2020, 5, 25, 10, 12, 23, 131, DateTimeKind.Local).AddTicks(3543) }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[,]
                {
                    { 2, 9, "Ex cupiditate sit unde nesciunt rem id harum laboriosam consequuntur.", new DateTime(2020, 5, 25, 10, 12, 23, 138, DateTimeKind.Local).AddTicks(632), 15, new DateTime(2020, 5, 25, 10, 12, 23, 138, DateTimeKind.Local).AddTicks(654) },
                    { 16, 20, "Reiciendis molestiae et qui magni ipsam vel saepe magnam qui.", new DateTime(2020, 5, 25, 10, 12, 23, 138, DateTimeKind.Local).AddTicks(1664), 4, new DateTime(2020, 5, 25, 10, 12, 23, 138, DateTimeKind.Local).AddTicks(1669) },
                    { 20, 4, "Delectus facilis officia illum saepe nihil non maxime quia.", new DateTime(2020, 5, 25, 10, 12, 23, 138, DateTimeKind.Local).AddTicks(1947), 8, new DateTime(2020, 5, 25, 10, 12, 23, 138, DateTimeKind.Local).AddTicks(1952) },
                    { 10, 1, "Quos et dolores.", new DateTime(2020, 5, 25, 10, 12, 23, 138, DateTimeKind.Local).AddTicks(1244), 8, new DateTime(2020, 5, 25, 10, 12, 23, 138, DateTimeKind.Local).AddTicks(1248) },
                    { 19, 9, "Eius quia molestiae veniam.", new DateTime(2020, 5, 25, 10, 12, 23, 138, DateTimeKind.Local).AddTicks(1883), 3, new DateTime(2020, 5, 25, 10, 12, 23, 138, DateTimeKind.Local).AddTicks(1889) },
                    { 15, 12, "Assumenda quis vel iure nisi adipisci fugiat.", new DateTime(2020, 5, 25, 10, 12, 23, 138, DateTimeKind.Local).AddTicks(1595), 3, new DateTime(2020, 5, 25, 10, 12, 23, 138, DateTimeKind.Local).AddTicks(1600) },
                    { 14, 1, "Mollitia eius accusantium.", new DateTime(2020, 5, 25, 10, 12, 23, 138, DateTimeKind.Local).AddTicks(1535), 3, new DateTime(2020, 5, 25, 10, 12, 23, 138, DateTimeKind.Local).AddTicks(1540) },
                    { 18, 13, "Ipsum non voluptatum eum blanditiis modi adipisci expedita minima numquam.", new DateTime(2020, 5, 25, 10, 12, 23, 138, DateTimeKind.Local).AddTicks(1835), 16, new DateTime(2020, 5, 25, 10, 12, 23, 138, DateTimeKind.Local).AddTicks(1840) },
                    { 9, 12, "Quod consequatur exercitationem voluptatum laborum voluptatem eius magnam.", new DateTime(2020, 5, 25, 10, 12, 23, 138, DateTimeKind.Local).AddTicks(1198), 11, new DateTime(2020, 5, 25, 10, 12, 23, 138, DateTimeKind.Local).AddTicks(1203) },
                    { 3, 20, "Nihil dolores dolore fuga fugiat qui natus quis nemo quia.", new DateTime(2020, 5, 25, 10, 12, 23, 138, DateTimeKind.Local).AddTicks(746), 11, new DateTime(2020, 5, 25, 10, 12, 23, 138, DateTimeKind.Local).AddTicks(751) },
                    { 4, 10, "Corporis dolores et corporis.", new DateTime(2020, 5, 25, 10, 12, 23, 138, DateTimeKind.Local).AddTicks(799), 11, new DateTime(2020, 5, 25, 10, 12, 23, 138, DateTimeKind.Local).AddTicks(805) },
                    { 11, 19, "Beatae expedita praesentium rerum quidem omnis cupiditate odit ut harum.", new DateTime(2020, 5, 25, 10, 12, 23, 138, DateTimeKind.Local).AddTicks(1318), 2, new DateTime(2020, 5, 25, 10, 12, 23, 138, DateTimeKind.Local).AddTicks(1323) },
                    { 5, 4, "Veniam soluta consequuntur tenetur.", new DateTime(2020, 5, 25, 10, 12, 23, 138, DateTimeKind.Local).AddTicks(853), 5, new DateTime(2020, 5, 25, 10, 12, 23, 138, DateTimeKind.Local).AddTicks(858) },
                    { 17, 11, "Corrupti sapiente esse qui distinctio eum minus.", new DateTime(2020, 5, 25, 10, 12, 23, 138, DateTimeKind.Local).AddTicks(1725), 5, new DateTime(2020, 5, 25, 10, 12, 23, 138, DateTimeKind.Local).AddTicks(1729) },
                    { 8, 19, "Totam reiciendis aperiam tempore.", new DateTime(2020, 5, 25, 10, 12, 23, 138, DateTimeKind.Local).AddTicks(1132), 10, new DateTime(2020, 5, 25, 10, 12, 23, 138, DateTimeKind.Local).AddTicks(1137) },
                    { 12, 17, "Reiciendis hic non voluptatem et omnis voluptatibus nulla.", new DateTime(2020, 5, 25, 10, 12, 23, 138, DateTimeKind.Local).AddTicks(1428), 17, new DateTime(2020, 5, 25, 10, 12, 23, 138, DateTimeKind.Local).AddTicks(1433) },
                    { 1, 15, "Fuga non hic quia.", new DateTime(2020, 5, 25, 10, 12, 23, 137, DateTimeKind.Local).AddTicks(9212), 7, new DateTime(2020, 5, 25, 10, 12, 23, 137, DateTimeKind.Local).AddTicks(9936) },
                    { 6, 6, "Nisi aperiam facere et dolorem perferendis non consequatur magni.", new DateTime(2020, 5, 25, 10, 12, 23, 138, DateTimeKind.Local).AddTicks(926), 7, new DateTime(2020, 5, 25, 10, 12, 23, 138, DateTimeKind.Local).AddTicks(931) },
                    { 7, 1, "Et repellendus rerum quae aliquid molestiae.", new DateTime(2020, 5, 25, 10, 12, 23, 138, DateTimeKind.Local).AddTicks(1075), 20, new DateTime(2020, 5, 25, 10, 12, 23, 138, DateTimeKind.Local).AddTicks(1081) },
                    { 13, 10, "Reprehenderit quos dolorem nisi omnis maxime tempore.", new DateTime(2020, 5, 25, 10, 12, 23, 138, DateTimeKind.Local).AddTicks(1489), 13, new DateTime(2020, 5, 25, 10, 12, 23, 138, DateTimeKind.Local).AddTicks(1494) }
                });

            migrationBuilder.InsertData(
                table: "PostNegativeReactions",
                columns: new[] { "Id", "CreatedAt", "IsDislike", "PostId", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 11, new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(4155), false, 13, new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(4160), 7 },
                    { 18, new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(4337), false, 20, new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(4342), 21 },
                    { 14, new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(4233), true, 10, new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(4238), 9 },
                    { 3, new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(3938), false, 17, new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(3943), 4 },
                    { 20, new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(4389), false, 14, new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(4394), 18 },
                    { 8, new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(4077), false, 7, new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(4081), 7 },
                    { 1, new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(2620), false, 7, new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(3369), 10 },
                    { 5, new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(3997), true, 15, new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(4002), 10 },
                    { 6, new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(4024), true, 15, new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(4029), 19 },
                    { 16, new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(4285), false, 20, new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(4290), 6 },
                    { 7, new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(4050), false, 20, new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(4055), 12 },
                    { 12, new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(4181), true, 19, new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(4186), 6 },
                    { 4, new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(3969), false, 1, new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(3974), 20 },
                    { 17, new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(4312), true, 4, new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(4317), 17 },
                    { 9, new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(4103), false, 1, new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(4107), 20 },
                    { 2, new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(3883), true, 20, new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(3900), 13 },
                    { 15, new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(4259), false, 16, new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(4264), 11 },
                    { 13, new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(4207), false, 3, new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(4211), 2 },
                    { 19, new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(4363), false, 3, new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(4368), 4 },
                    { 10, new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(4129), true, 1, new DateTime(2020, 5, 25, 10, 12, 23, 159, DateTimeKind.Local).AddTicks(4134), 16 }
                });

            migrationBuilder.InsertData(
                table: "PostReactions",
                columns: new[] { "Id", "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 16, new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(4699), false, 17, new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(4704), 14 },
                    { 14, new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(4646), true, 2, new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(4650), 8 },
                    { 18, new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(4752), true, 2, new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(4756), 10 },
                    { 20, new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(4805), true, 12, new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(4810), 12 },
                    { 2, new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(4213), true, 14, new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(4274), 4 },
                    { 15, new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(4672), true, 10, new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(4677), 16 },
                    { 1, new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(2774), true, 10, new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(3502), 16 },
                    { 6, new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(4400), false, 5, new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(4405), 5 },
                    { 9, new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(4484), false, 14, new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(4489), 14 },
                    { 4, new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(4343), true, 14, new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(4348), 11 },
                    { 3, new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(4314), false, 14, new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(4320), 8 },
                    { 19, new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(4778), true, 6, new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(4783), 3 },
                    { 10, new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(4515), true, 6, new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(4520), 1 },
                    { 11, new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(4541), true, 3, new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(4546), 11 },
                    { 13, new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(4619), false, 1, new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(4624), 4 },
                    { 12, new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(4590), false, 1, new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(4596), 3 },
                    { 17, new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(4726), true, 15, new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(4730), 15 },
                    { 5, new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(4372), false, 15, new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(4377), 21 },
                    { 7, new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(4428), false, 7, new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(4433), 3 },
                    { 8, new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(4457), true, 20, new DateTime(2020, 5, 25, 10, 12, 23, 154, DateTimeKind.Local).AddTicks(4462), 10 }
                });

            migrationBuilder.InsertData(
                table: "CommentNegativeReactions",
                columns: new[] { "Id", "CommentId", "CreatedAt", "IsDislike", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 19, 3, new DateTime(2020, 5, 25, 10, 12, 23, 169, DateTimeKind.Local).AddTicks(699), true, new DateTime(2020, 5, 25, 10, 12, 23, 169, DateTimeKind.Local).AddTicks(704), 19 },
                    { 7, 7, new DateTime(2020, 5, 25, 10, 12, 23, 169, DateTimeKind.Local).AddTicks(371), false, new DateTime(2020, 5, 25, 10, 12, 23, 169, DateTimeKind.Local).AddTicks(376), 10 },
                    { 16, 20, new DateTime(2020, 5, 25, 10, 12, 23, 169, DateTimeKind.Local).AddTicks(621), false, new DateTime(2020, 5, 25, 10, 12, 23, 169, DateTimeKind.Local).AddTicks(626), 1 },
                    { 20, 11, new DateTime(2020, 5, 25, 10, 12, 23, 169, DateTimeKind.Local).AddTicks(726), false, new DateTime(2020, 5, 25, 10, 12, 23, 169, DateTimeKind.Local).AddTicks(730), 7 },
                    { 3, 11, new DateTime(2020, 5, 25, 10, 12, 23, 169, DateTimeKind.Local).AddTicks(262), false, new DateTime(2020, 5, 25, 10, 12, 23, 169, DateTimeKind.Local).AddTicks(267), 4 },
                    { 18, 12, new DateTime(2020, 5, 25, 10, 12, 23, 169, DateTimeKind.Local).AddTicks(673), true, new DateTime(2020, 5, 25, 10, 12, 23, 169, DateTimeKind.Local).AddTicks(678), 17 },
                    { 15, 12, new DateTime(2020, 5, 25, 10, 12, 23, 169, DateTimeKind.Local).AddTicks(593), true, new DateTime(2020, 5, 25, 10, 12, 23, 169, DateTimeKind.Local).AddTicks(598), 14 },
                    { 6, 6, new DateTime(2020, 5, 25, 10, 12, 23, 169, DateTimeKind.Local).AddTicks(344), true, new DateTime(2020, 5, 25, 10, 12, 23, 169, DateTimeKind.Local).AddTicks(349), 6 },
                    { 2, 17, new DateTime(2020, 5, 25, 10, 12, 23, 169, DateTimeKind.Local).AddTicks(207), true, new DateTime(2020, 5, 25, 10, 12, 23, 169, DateTimeKind.Local).AddTicks(223), 1 },
                    { 10, 13, new DateTime(2020, 5, 25, 10, 12, 23, 169, DateTimeKind.Local).AddTicks(451), true, new DateTime(2020, 5, 25, 10, 12, 23, 169, DateTimeKind.Local).AddTicks(456), 10 },
                    { 5, 13, new DateTime(2020, 5, 25, 10, 12, 23, 169, DateTimeKind.Local).AddTicks(317), true, new DateTime(2020, 5, 25, 10, 12, 23, 169, DateTimeKind.Local).AddTicks(322), 10 },
                    { 9, 7, new DateTime(2020, 5, 25, 10, 12, 23, 169, DateTimeKind.Local).AddTicks(425), false, new DateTime(2020, 5, 25, 10, 12, 23, 169, DateTimeKind.Local).AddTicks(429), 11 },
                    { 4, 13, new DateTime(2020, 5, 25, 10, 12, 23, 169, DateTimeKind.Local).AddTicks(291), true, new DateTime(2020, 5, 25, 10, 12, 23, 169, DateTimeKind.Local).AddTicks(296), 10 },
                    { 11, 4, new DateTime(2020, 5, 25, 10, 12, 23, 169, DateTimeKind.Local).AddTicks(478), true, new DateTime(2020, 5, 25, 10, 12, 23, 169, DateTimeKind.Local).AddTicks(483), 13 },
                    { 17, 14, new DateTime(2020, 5, 25, 10, 12, 23, 169, DateTimeKind.Local).AddTicks(647), true, new DateTime(2020, 5, 25, 10, 12, 23, 169, DateTimeKind.Local).AddTicks(652), 18 },
                    { 8, 18, new DateTime(2020, 5, 25, 10, 12, 23, 169, DateTimeKind.Local).AddTicks(398), true, new DateTime(2020, 5, 25, 10, 12, 23, 169, DateTimeKind.Local).AddTicks(403), 16 },
                    { 12, 9, new DateTime(2020, 5, 25, 10, 12, 23, 169, DateTimeKind.Local).AddTicks(505), false, new DateTime(2020, 5, 25, 10, 12, 23, 169, DateTimeKind.Local).AddTicks(510), 17 },
                    { 13, 9, new DateTime(2020, 5, 25, 10, 12, 23, 169, DateTimeKind.Local).AddTicks(540), false, new DateTime(2020, 5, 25, 10, 12, 23, 169, DateTimeKind.Local).AddTicks(545), 16 },
                    { 1, 18, new DateTime(2020, 5, 25, 10, 12, 23, 168, DateTimeKind.Local).AddTicks(8962), true, new DateTime(2020, 5, 25, 10, 12, 23, 168, DateTimeKind.Local).AddTicks(9712), 18 },
                    { 14, 15, new DateTime(2020, 5, 25, 10, 12, 23, 169, DateTimeKind.Local).AddTicks(567), true, new DateTime(2020, 5, 25, 10, 12, 23, 169, DateTimeKind.Local).AddTicks(571), 19 }
                });

            migrationBuilder.InsertData(
                table: "CommentReactions",
                columns: new[] { "Id", "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 20, 15, new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(2671), true, new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(2675), 1 },
                    { 5, 3, new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(2267), false, new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(2272), 1 },
                    { 10, 3, new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(2402), false, new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(2407), 19 },
                    { 14, 11, new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(2510), true, new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(2515), 6 },
                    { 3, 4, new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(2207), true, new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(2213), 16 },
                    { 13, 12, new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(2482), true, new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(2487), 4 },
                    { 11, 6, new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(2429), false, new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(2434), 16 },
                    { 1, 9, new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(893), false, new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(1652), 11 },
                    { 6, 17, new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(2294), false, new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(2299), 18 },
                    { 4, 17, new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(2237), false, new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(2242), 12 },
                    { 15, 5, new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(2536), false, new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(2541), 11 },
                    { 2, 13, new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(2147), false, new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(2168), 20 },
                    { 7, 14, new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(2321), false, new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(2326), 19 },
                    { 19, 16, new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(2643), false, new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(2648), 19 },
                    { 18, 19, new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(2616), true, new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(2621), 9 },
                    { 16, 19, new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(2563), true, new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(2568), 19 },
                    { 12, 19, new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(2455), true, new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(2460), 11 },
                    { 8, 19, new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(2348), true, new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(2353), 16 },
                    { 17, 8, new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(2590), false, new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(2595), 1 },
                    { 9, 7, new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(2377), false, new DateTime(2020, 5, 25, 10, 12, 23, 164, DateTimeKind.Local).AddTicks(2381), 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CommentNegativeReactions_CommentId",
                table: "CommentNegativeReactions",
                column: "CommentId");

            migrationBuilder.CreateIndex(
                name: "IX_CommentNegativeReactions_UserId",
                table: "CommentNegativeReactions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CommentReactions_CommentId",
                table: "CommentReactions",
                column: "CommentId");

            migrationBuilder.CreateIndex(
                name: "IX_CommentReactions_UserId",
                table: "CommentReactions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_AuthorId",
                table: "Comments",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PostId",
                table: "Comments",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_PostNegativeReactions_PostId",
                table: "PostNegativeReactions",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_PostNegativeReactions_UserId",
                table: "PostNegativeReactions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PostReactions_PostId",
                table: "PostReactions",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_PostReactions_UserId",
                table: "PostReactions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_AuthorId",
                table: "Posts",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_PreviewId",
                table: "Posts",
                column: "PreviewId");

            migrationBuilder.CreateIndex(
                name: "IX_RefreshTokens_UserId",
                table: "RefreshTokens",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_AvatarId",
                table: "Users",
                column: "AvatarId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CommentNegativeReactions");

            migrationBuilder.DropTable(
                name: "CommentReactions");

            migrationBuilder.DropTable(
                name: "PostNegativeReactions");

            migrationBuilder.DropTable(
                name: "PostReactions");

            migrationBuilder.DropTable(
                name: "RefreshTokens");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Images");
        }
    }
}
