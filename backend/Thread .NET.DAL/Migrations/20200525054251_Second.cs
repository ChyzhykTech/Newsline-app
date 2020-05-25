using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Thread_.NET.DAL.Migrations
{
    public partial class Second : Migration
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
                    { 1, new DateTime(2020, 5, 25, 8, 42, 50, 375, DateTimeKind.Local).AddTicks(6114), "https://s3.amazonaws.com/uifaces/faces/twitter/mrebay007/128.jpg", new DateTime(2020, 5, 25, 8, 42, 50, 376, DateTimeKind.Local).AddTicks(959) },
                    { 23, new DateTime(2020, 5, 25, 8, 42, 50, 381, DateTimeKind.Local).AddTicks(6395), "https://picsum.photos/640/480/?image=496", new DateTime(2020, 5, 25, 8, 42, 50, 381, DateTimeKind.Local).AddTicks(6401) },
                    { 24, new DateTime(2020, 5, 25, 8, 42, 50, 381, DateTimeKind.Local).AddTicks(6420), "https://picsum.photos/640/480/?image=102", new DateTime(2020, 5, 25, 8, 42, 50, 381, DateTimeKind.Local).AddTicks(6426) },
                    { 25, new DateTime(2020, 5, 25, 8, 42, 50, 381, DateTimeKind.Local).AddTicks(6445), "https://picsum.photos/640/480/?image=48", new DateTime(2020, 5, 25, 8, 42, 50, 381, DateTimeKind.Local).AddTicks(6450) },
                    { 26, new DateTime(2020, 5, 25, 8, 42, 50, 381, DateTimeKind.Local).AddTicks(6469), "https://picsum.photos/640/480/?image=825", new DateTime(2020, 5, 25, 8, 42, 50, 381, DateTimeKind.Local).AddTicks(6474) },
                    { 27, new DateTime(2020, 5, 25, 8, 42, 50, 381, DateTimeKind.Local).AddTicks(6494), "https://picsum.photos/640/480/?image=39", new DateTime(2020, 5, 25, 8, 42, 50, 381, DateTimeKind.Local).AddTicks(6499) },
                    { 28, new DateTime(2020, 5, 25, 8, 42, 50, 381, DateTimeKind.Local).AddTicks(6517), "https://picsum.photos/640/480/?image=468", new DateTime(2020, 5, 25, 8, 42, 50, 381, DateTimeKind.Local).AddTicks(6522) },
                    { 29, new DateTime(2020, 5, 25, 8, 42, 50, 381, DateTimeKind.Local).AddTicks(6541), "https://picsum.photos/640/480/?image=454", new DateTime(2020, 5, 25, 8, 42, 50, 381, DateTimeKind.Local).AddTicks(6546) },
                    { 30, new DateTime(2020, 5, 25, 8, 42, 50, 381, DateTimeKind.Local).AddTicks(6564), "https://picsum.photos/640/480/?image=1068", new DateTime(2020, 5, 25, 8, 42, 50, 381, DateTimeKind.Local).AddTicks(6569) },
                    { 31, new DateTime(2020, 5, 25, 8, 42, 50, 381, DateTimeKind.Local).AddTicks(6587), "https://picsum.photos/640/480/?image=456", new DateTime(2020, 5, 25, 8, 42, 50, 381, DateTimeKind.Local).AddTicks(6592) },
                    { 32, new DateTime(2020, 5, 25, 8, 42, 50, 381, DateTimeKind.Local).AddTicks(6611), "https://picsum.photos/640/480/?image=282", new DateTime(2020, 5, 25, 8, 42, 50, 381, DateTimeKind.Local).AddTicks(6616) },
                    { 33, new DateTime(2020, 5, 25, 8, 42, 50, 381, DateTimeKind.Local).AddTicks(6677), "https://picsum.photos/640/480/?image=61", new DateTime(2020, 5, 25, 8, 42, 50, 381, DateTimeKind.Local).AddTicks(6682) },
                    { 34, new DateTime(2020, 5, 25, 8, 42, 50, 381, DateTimeKind.Local).AddTicks(6702), "https://picsum.photos/640/480/?image=635", new DateTime(2020, 5, 25, 8, 42, 50, 381, DateTimeKind.Local).AddTicks(6707) },
                    { 35, new DateTime(2020, 5, 25, 8, 42, 50, 381, DateTimeKind.Local).AddTicks(6727), "https://picsum.photos/640/480/?image=935", new DateTime(2020, 5, 25, 8, 42, 50, 381, DateTimeKind.Local).AddTicks(6732) },
                    { 36, new DateTime(2020, 5, 25, 8, 42, 50, 381, DateTimeKind.Local).AddTicks(6751), "https://picsum.photos/640/480/?image=709", new DateTime(2020, 5, 25, 8, 42, 50, 381, DateTimeKind.Local).AddTicks(6756) },
                    { 37, new DateTime(2020, 5, 25, 8, 42, 50, 381, DateTimeKind.Local).AddTicks(6775), "https://picsum.photos/640/480/?image=567", new DateTime(2020, 5, 25, 8, 42, 50, 381, DateTimeKind.Local).AddTicks(6780) },
                    { 38, new DateTime(2020, 5, 25, 8, 42, 50, 381, DateTimeKind.Local).AddTicks(6798), "https://picsum.photos/640/480/?image=81", new DateTime(2020, 5, 25, 8, 42, 50, 381, DateTimeKind.Local).AddTicks(6803) },
                    { 39, new DateTime(2020, 5, 25, 8, 42, 50, 381, DateTimeKind.Local).AddTicks(6821), "https://picsum.photos/640/480/?image=88", new DateTime(2020, 5, 25, 8, 42, 50, 381, DateTimeKind.Local).AddTicks(6826) },
                    { 22, new DateTime(2020, 5, 25, 8, 42, 50, 381, DateTimeKind.Local).AddTicks(6339), "https://picsum.photos/640/480/?image=386", new DateTime(2020, 5, 25, 8, 42, 50, 381, DateTimeKind.Local).AddTicks(6368) },
                    { 40, new DateTime(2020, 5, 25, 8, 42, 50, 381, DateTimeKind.Local).AddTicks(6845), "https://picsum.photos/640/480/?image=963", new DateTime(2020, 5, 25, 8, 42, 50, 381, DateTimeKind.Local).AddTicks(6850) },
                    { 21, new DateTime(2020, 5, 25, 8, 42, 50, 381, DateTimeKind.Local).AddTicks(5141), "https://picsum.photos/640/480/?image=356", new DateTime(2020, 5, 25, 8, 42, 50, 381, DateTimeKind.Local).AddTicks(5962) },
                    { 19, new DateTime(2020, 5, 25, 8, 42, 50, 376, DateTimeKind.Local).AddTicks(2326), "https://s3.amazonaws.com/uifaces/faces/twitter/kucingbelang4/128.jpg", new DateTime(2020, 5, 25, 8, 42, 50, 376, DateTimeKind.Local).AddTicks(2331) },
                    { 2, new DateTime(2020, 5, 25, 8, 42, 50, 376, DateTimeKind.Local).AddTicks(1781), "https://s3.amazonaws.com/uifaces/faces/twitter/nerdgr8/128.jpg", new DateTime(2020, 5, 25, 8, 42, 50, 376, DateTimeKind.Local).AddTicks(1804) },
                    { 3, new DateTime(2020, 5, 25, 8, 42, 50, 376, DateTimeKind.Local).AddTicks(1839), "https://s3.amazonaws.com/uifaces/faces/twitter/shadeed9/128.jpg", new DateTime(2020, 5, 25, 8, 42, 50, 376, DateTimeKind.Local).AddTicks(1845) },
                    { 4, new DateTime(2020, 5, 25, 8, 42, 50, 376, DateTimeKind.Local).AddTicks(1867), "https://s3.amazonaws.com/uifaces/faces/twitter/rpatey/128.jpg", new DateTime(2020, 5, 25, 8, 42, 50, 376, DateTimeKind.Local).AddTicks(1872) },
                    { 5, new DateTime(2020, 5, 25, 8, 42, 50, 376, DateTimeKind.Local).AddTicks(1894), "https://s3.amazonaws.com/uifaces/faces/twitter/psaikali/128.jpg", new DateTime(2020, 5, 25, 8, 42, 50, 376, DateTimeKind.Local).AddTicks(1899) },
                    { 6, new DateTime(2020, 5, 25, 8, 42, 50, 376, DateTimeKind.Local).AddTicks(1920), "https://s3.amazonaws.com/uifaces/faces/twitter/tristanlegros/128.jpg", new DateTime(2020, 5, 25, 8, 42, 50, 376, DateTimeKind.Local).AddTicks(1925) },
                    { 7, new DateTime(2020, 5, 25, 8, 42, 50, 376, DateTimeKind.Local).AddTicks(1945), "https://s3.amazonaws.com/uifaces/faces/twitter/haligaliharun/128.jpg", new DateTime(2020, 5, 25, 8, 42, 50, 376, DateTimeKind.Local).AddTicks(1950) },
                    { 8, new DateTime(2020, 5, 25, 8, 42, 50, 376, DateTimeKind.Local).AddTicks(1971), "https://s3.amazonaws.com/uifaces/faces/twitter/embrcecreations/128.jpg", new DateTime(2020, 5, 25, 8, 42, 50, 376, DateTimeKind.Local).AddTicks(1976) },
                    { 9, new DateTime(2020, 5, 25, 8, 42, 50, 376, DateTimeKind.Local).AddTicks(1997), "https://s3.amazonaws.com/uifaces/faces/twitter/chanpory/128.jpg", new DateTime(2020, 5, 25, 8, 42, 50, 376, DateTimeKind.Local).AddTicks(2002) },
                    { 10, new DateTime(2020, 5, 25, 8, 42, 50, 376, DateTimeKind.Local).AddTicks(2023), "https://s3.amazonaws.com/uifaces/faces/twitter/fiterik/128.jpg", new DateTime(2020, 5, 25, 8, 42, 50, 376, DateTimeKind.Local).AddTicks(2028) },
                    { 11, new DateTime(2020, 5, 25, 8, 42, 50, 376, DateTimeKind.Local).AddTicks(2048), "https://s3.amazonaws.com/uifaces/faces/twitter/scottkclark/128.jpg", new DateTime(2020, 5, 25, 8, 42, 50, 376, DateTimeKind.Local).AddTicks(2054) },
                    { 12, new DateTime(2020, 5, 25, 8, 42, 50, 376, DateTimeKind.Local).AddTicks(2075), "https://s3.amazonaws.com/uifaces/faces/twitter/lebronjennan/128.jpg", new DateTime(2020, 5, 25, 8, 42, 50, 376, DateTimeKind.Local).AddTicks(2080) },
                    { 13, new DateTime(2020, 5, 25, 8, 42, 50, 376, DateTimeKind.Local).AddTicks(2101), "https://s3.amazonaws.com/uifaces/faces/twitter/clubb3rry/128.jpg", new DateTime(2020, 5, 25, 8, 42, 50, 376, DateTimeKind.Local).AddTicks(2106) },
                    { 14, new DateTime(2020, 5, 25, 8, 42, 50, 376, DateTimeKind.Local).AddTicks(2126), "https://s3.amazonaws.com/uifaces/faces/twitter/dotgridline/128.jpg", new DateTime(2020, 5, 25, 8, 42, 50, 376, DateTimeKind.Local).AddTicks(2132) },
                    { 15, new DateTime(2020, 5, 25, 8, 42, 50, 376, DateTimeKind.Local).AddTicks(2219), "https://s3.amazonaws.com/uifaces/faces/twitter/sgaurav_baghel/128.jpg", new DateTime(2020, 5, 25, 8, 42, 50, 376, DateTimeKind.Local).AddTicks(2225) },
                    { 16, new DateTime(2020, 5, 25, 8, 42, 50, 376, DateTimeKind.Local).AddTicks(2248), "https://s3.amazonaws.com/uifaces/faces/twitter/weavermedia/128.jpg", new DateTime(2020, 5, 25, 8, 42, 50, 376, DateTimeKind.Local).AddTicks(2253) },
                    { 17, new DateTime(2020, 5, 25, 8, 42, 50, 376, DateTimeKind.Local).AddTicks(2274), "https://s3.amazonaws.com/uifaces/faces/twitter/dahparra/128.jpg", new DateTime(2020, 5, 25, 8, 42, 50, 376, DateTimeKind.Local).AddTicks(2279) },
                    { 18, new DateTime(2020, 5, 25, 8, 42, 50, 376, DateTimeKind.Local).AddTicks(2300), "https://s3.amazonaws.com/uifaces/faces/twitter/rachelreveley/128.jpg", new DateTime(2020, 5, 25, 8, 42, 50, 376, DateTimeKind.Local).AddTicks(2305) },
                    { 20, new DateTime(2020, 5, 25, 8, 42, 50, 376, DateTimeKind.Local).AddTicks(2351), "https://s3.amazonaws.com/uifaces/faces/twitter/josep_martins/128.jpg", new DateTime(2020, 5, 25, 8, 42, 50, 376, DateTimeKind.Local).AddTicks(2356) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 21, null, new DateTime(2020, 5, 25, 8, 42, 50, 698, DateTimeKind.Local).AddTicks(4300), "test@gmail.com", "5GSdG62XyttoUerxGhIDoCI88rT+q/gWp9bEBz9Y644=", "no5wLj9dzyM7Ymc42E5Coyq7HRHiBQMTeYfgShbZBqo=", new DateTime(2020, 5, 25, 8, 42, 50, 698, DateTimeKind.Local).AddTicks(4300), "testUser" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 16, 21, "Est assumenda voluptatem dignissimos consectetur aut quo ipsum ut error. Architecto sapiente sed et accusantium aut illum atque amet. Sed dolor voluptatem dolor aut. Totam et hic provident. Excepturi qui explicabo ut tempore in.", new DateTime(2020, 5, 25, 8, 42, 50, 723, DateTimeKind.Local).AddTicks(927), 37, new DateTime(2020, 5, 25, 8, 42, 50, 723, DateTimeKind.Local).AddTicks(937) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { 20, 17, new DateTime(2020, 5, 25, 8, 42, 50, 685, DateTimeKind.Local).AddTicks(7252), "Robert.Cummings@hotmail.com", "kmtB6we1V6Ynmhd9OXTlT9uHayooLyUoRFdGHDQwrio=", "o1ubHdOKCm4YXcEmRKWDPp2FrfU/4JdzUfMtj7c/ETI=", new DateTime(2020, 5, 25, 8, 42, 50, 685, DateTimeKind.Local).AddTicks(7340), "Kristian.Rogahn" },
                    { 3, 15, new DateTime(2020, 5, 25, 8, 42, 50, 459, DateTimeKind.Local).AddTicks(4194), "Joan22@gmail.com", "qSv1GdG6x/EzAN0QuKOCjP3C2IXCAkLi56mOO1JlF24=", "zfohD4eBsTk0csKDHTrN2DGKci29zXGZP0KsKIMCLlU=", new DateTime(2020, 5, 25, 8, 42, 50, 459, DateTimeKind.Local).AddTicks(4294), "Triston19" },
                    { 6, 14, new DateTime(2020, 5, 25, 8, 42, 50, 499, DateTimeKind.Local).AddTicks(7197), "Garland_Feest78@yahoo.com", "QamEj8Y4yh0xNrkooKBSLU55CbtyISIRj6Ji3bWN6sU=", "v/Nwc463OQ5dqtwRil5dG284k1Xzi/CQYjiXWiK7Xec=", new DateTime(2020, 5, 25, 8, 42, 50, 499, DateTimeKind.Local).AddTicks(7294), "Baron_Shanahan" },
                    { 17, 12, new DateTime(2020, 5, 25, 8, 42, 50, 648, DateTimeKind.Local).AddTicks(7682), "April_Thiel0@hotmail.com", "EltDG8ck4eLJo7BBDzAuvz1qA5zyoxFWyGNQldW87/M=", "XYwSDwv9krEgmrNomxOMjzdYGv9zst77ZpQr4l8P0vE=", new DateTime(2020, 5, 25, 8, 42, 50, 648, DateTimeKind.Local).AddTicks(8017), "Bernhard61" },
                    { 16, 10, new DateTime(2020, 5, 25, 8, 42, 50, 635, DateTimeKind.Local).AddTicks(7234), "Khalid84@yahoo.com", "vTqmlniIKDaW1AEE04j4TzcZ+7RyM2yhbCGgz1a+2vo=", "F7CmLYbBh9hyTXJc4oyIAO22/lpJyhNkt3Sz2yqu/j8=", new DateTime(2020, 5, 25, 8, 42, 50, 635, DateTimeKind.Local).AddTicks(7822), "Kitty_Wehner" },
                    { 11, 9, new DateTime(2020, 5, 25, 8, 42, 50, 566, DateTimeKind.Local).AddTicks(8143), "Tessie_Lockman67@gmail.com", "qYP+v3k4A9T+NcIsU5IVGicILP0+xsJkhXmzPrzjsyM=", "jcV+awVf2UnOvYwn7zETk0BUk3x5p4efflR8BHT2GGY=", new DateTime(2020, 5, 25, 8, 42, 50, 566, DateTimeKind.Local).AddTicks(8223), "Mohammed31" },
                    { 1, 9, new DateTime(2020, 5, 25, 8, 42, 50, 431, DateTimeKind.Local).AddTicks(2493), "Ilene.Reynolds@gmail.com", "l7cQx7pSnK0o8nRAx2j0fCP9vaOYdomxK5ajRZmnJbg=", "SPjsbjgyS1sBPi4nUoOV1TKuHnaMpo3BM2gjxEI8E7Q=", new DateTime(2020, 5, 25, 8, 42, 50, 431, DateTimeKind.Local).AddTicks(3515), "Eden.Prosacco30" },
                    { 15, 8, new DateTime(2020, 5, 25, 8, 42, 50, 620, DateTimeKind.Local).AddTicks(5692), "Mellie_Gibson@yahoo.com", "Du6Wpx71bt1fqIa1GB17BCOlTbxzbwnStiAyWC0+DhE=", "YGPIWgX8Zj6gqdL69GzYeTY8HLu+AOKJTjTGCZNICQs=", new DateTime(2020, 5, 25, 8, 42, 50, 620, DateTimeKind.Local).AddTicks(6326), "Douglas1" },
                    { 14, 20, new DateTime(2020, 5, 25, 8, 42, 50, 606, DateTimeKind.Local).AddTicks(6647), "Luella64@yahoo.com", "uG0JbO9V26FIut977PZgo1KkeeS4h1silv6AN4fWMd0=", "MlU8TjlazmRG7HfWeYvyoPg+Eg9di8+Xg2qt5s0Td/E=", new DateTime(2020, 5, 25, 8, 42, 50, 606, DateTimeKind.Local).AddTicks(6734), "Serenity_Grady" },
                    { 12, 7, new DateTime(2020, 5, 25, 8, 42, 50, 580, DateTimeKind.Local).AddTicks(2108), "Ezekiel27@yahoo.com", "qt07c0YJaOqgrGb8MRxPMut47znkDH54XHzr11uKwYQ=", "Z8MGSPDKaxyOe4CO+X1eWbgHe9vZ4S5StRNotIASiO4=", new DateTime(2020, 5, 25, 8, 42, 50, 580, DateTimeKind.Local).AddTicks(2193), "Alanis.Stiedemann" },
                    { 7, 7, new DateTime(2020, 5, 25, 8, 42, 50, 512, DateTimeKind.Local).AddTicks(9743), "Davonte70@yahoo.com", "l98ZauKB0DV3wql3ceNELDirV3FVH726T8e0jRpDj98=", "iP/bJdQZyUUDcQa9jc/eSIwhbWASy9QbUmUV03xYW8I=", new DateTime(2020, 5, 25, 8, 42, 50, 512, DateTimeKind.Local).AddTicks(9846), "Lambert.Berge47" },
                    { 18, 6, new DateTime(2020, 5, 25, 8, 42, 50, 661, DateTimeKind.Local).AddTicks(3780), "Elyse_Hackett@hotmail.com", "9Mom6hxGrpfrETsemFxO7NjhyFubRzy6fyBurE/1614=", "qWrNNpzsSPjXLJ+UMkiGKVIgn0yQAa/bA1/qA/3Ujxc=", new DateTime(2020, 5, 25, 8, 42, 50, 661, DateTimeKind.Local).AddTicks(3871), "Greyson_West54" },
                    { 19, 5, new DateTime(2020, 5, 25, 8, 42, 50, 673, DateTimeKind.Local).AddTicks(5465), "Jarret41@yahoo.com", "ogLq30uyFU0SW301RTaucD3NVqqdsfZeEzNXnEON/WU=", "qfWgsiHgEDOpZEM0Mdmpi+5LAkXyqmCYrAWDWxfUsCc=", new DateTime(2020, 5, 25, 8, 42, 50, 673, DateTimeKind.Local).AddTicks(5553), "Ashlynn.Zulauf88" },
                    { 13, 5, new DateTime(2020, 5, 25, 8, 42, 50, 593, DateTimeKind.Local).AddTicks(5103), "Madisyn.Cassin86@gmail.com", "ComKQOg17mIjePjFNiT0KFTabDwPgw+eQIhRGSibvFk=", "5gbNkAW8eOSWwHwPUyjCZn5O+Hjvdohmov5ruLKRHA8=", new DateTime(2020, 5, 25, 8, 42, 50, 593, DateTimeKind.Local).AddTicks(5190), "Maybelle63" },
                    { 4, 4, new DateTime(2020, 5, 25, 8, 42, 50, 473, DateTimeKind.Local).AddTicks(5320), "Vallie8@gmail.com", "syHsk12xjUjXwi6wmlfRp0uDUWGVaGYxIVsXPfVlX8I=", "9tPv7Al0SUh6fSbLLrkmFj66X1qC7VzriFH4ulKTA/Q=", new DateTime(2020, 5, 25, 8, 42, 50, 473, DateTimeKind.Local).AddTicks(5410), "Novella.Emard" },
                    { 5, 3, new DateTime(2020, 5, 25, 8, 42, 50, 486, DateTimeKind.Local).AddTicks(7869), "Mariah_Bergnaum12@yahoo.com", "z1gEBmNi2wqVZhjyDJWAo5MBlK+5exoiUvrvuMt4TPA=", "I4q9gwEUKs9A5XqYFqXxz6+kO0EXlWAIwq0U6l0u25o=", new DateTime(2020, 5, 25, 8, 42, 50, 486, DateTimeKind.Local).AddTicks(7968), "Mortimer_Wiegand" },
                    { 2, 3, new DateTime(2020, 5, 25, 8, 42, 50, 440, DateTimeKind.Local).AddTicks(6477), "Anais.Schaden30@yahoo.com", "/MzS9S119LxBSoS6i/hkfzRl4xWZL0ePEc9d0eP80nc=", "gxMUFFK0Gb+Bqcs6VsWdHgtbECOBIL5ZcguKgLTitWA=", new DateTime(2020, 5, 25, 8, 42, 50, 440, DateTimeKind.Local).AddTicks(6586), "Bret.Gusikowski62" },
                    { 10, 1, new DateTime(2020, 5, 25, 8, 42, 50, 553, DateTimeKind.Local).AddTicks(3669), "Tracey16@hotmail.com", "low+wE6HBNrQr5Oebe1lcui3722FbFc2a+SxrteFqQA=", "cioYIIlc5CzAQkEpI0Sbw3peHC1xZEbntLas5+n3ehc=", new DateTime(2020, 5, 25, 8, 42, 50, 553, DateTimeKind.Local).AddTicks(3756), "Chasity68" },
                    { 9, 7, new DateTime(2020, 5, 25, 8, 42, 50, 539, DateTimeKind.Local).AddTicks(8600), "Christopher_Doyle49@gmail.com", "2KTW6Cp4795M93LNcToOoNOaSgsBvtMXl+FgFparV8U=", "RYGgKsDIEWmLWN+0r3tI3ewfgq+V0EBdzhGIq3xknFA=", new DateTime(2020, 5, 25, 8, 42, 50, 539, DateTimeKind.Local).AddTicks(8693), "Eriberto90" },
                    { 8, 1, new DateTime(2020, 5, 25, 8, 42, 50, 526, DateTimeKind.Local).AddTicks(6146), "Brant.Harris66@gmail.com", "tKXSvvO00Sf27D7Oj1GT6dUWwlKS9NmJ3X5EIZ+ElYo=", "bXdb+OBbEKXKRnHytHx3DpvkAWmTQdAnx3+wAppCr+0=", new DateTime(2020, 5, 25, 8, 42, 50, 526, DateTimeKind.Local).AddTicks(6226), "Antwon_Towne" }
                });

            migrationBuilder.InsertData(
                table: "PostReactions",
                columns: new[] { "Id", "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { 11, new DateTime(2020, 5, 25, 8, 42, 50, 741, DateTimeKind.Local).AddTicks(8974), true, 16, new DateTime(2020, 5, 25, 8, 42, 50, 741, DateTimeKind.Local).AddTicks(8982), 21 });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[,]
                {
                    { 14, 14, @"Excepturi expedita quia suscipit et maiores repudiandae perferendis quia.
                Commodi facere et odit fugiat magnam sint laboriosam soluta.", new DateTime(2020, 5, 25, 8, 42, 50, 723, DateTimeKind.Local).AddTicks(386), 28, new DateTime(2020, 5, 25, 8, 42, 50, 723, DateTimeKind.Local).AddTicks(396) },
                    { 18, 20, @"Libero aliquid cupiditate.
                Atque sit vitae quas explicabo culpa quia facilis temporibus atque.
                Accusantium temporibus voluptatibus tenetur nesciunt at est.", new DateTime(2020, 5, 25, 8, 42, 50, 723, DateTimeKind.Local).AddTicks(1371), 28, new DateTime(2020, 5, 25, 8, 42, 50, 723, DateTimeKind.Local).AddTicks(1381) },
                    { 7, 20, @"Tempore eveniet tempora eveniet.
                Autem ut quibusdam.
                Ratione consequatur nihil voluptatem natus facilis optio molestiae.", new DateTime(2020, 5, 25, 8, 42, 50, 722, DateTimeKind.Local).AddTicks(7181), 25, new DateTime(2020, 5, 25, 8, 42, 50, 722, DateTimeKind.Local).AddTicks(7191) },
                    { 10, 3, @"Ex vel occaecati autem sit eos voluptatem impedit laudantium.
                Neque hic tempora voluptatem voluptatem dolore.", new DateTime(2020, 5, 25, 8, 42, 50, 722, DateTimeKind.Local).AddTicks(9622), 37, new DateTime(2020, 5, 25, 8, 42, 50, 722, DateTimeKind.Local).AddTicks(9634) },
                    { 15, 12, "Quaerat expedita accusamus consequatur doloribus voluptatem. Aut similique dignissimos. Et tempora minus voluptas quas necessitatibus similique.", new DateTime(2020, 5, 25, 8, 42, 50, 723, DateTimeKind.Local).AddTicks(595), 21, new DateTime(2020, 5, 25, 8, 42, 50, 723, DateTimeKind.Local).AddTicks(605) },
                    { 13, 12, "Et est aut id similique.", new DateTime(2020, 5, 25, 8, 42, 50, 723, DateTimeKind.Local).AddTicks(188), 40, new DateTime(2020, 5, 25, 8, 42, 50, 723, DateTimeKind.Local).AddTicks(197) },
                    { 8, 12, "repellendus", new DateTime(2020, 5, 25, 8, 42, 50, 722, DateTimeKind.Local).AddTicks(7257), 24, new DateTime(2020, 5, 25, 8, 42, 50, 722, DateTimeKind.Local).AddTicks(7266) },
                    { 4, 12, "Fugiat voluptatem qui.", new DateTime(2020, 5, 25, 8, 42, 50, 722, DateTimeKind.Local).AddTicks(6304), 40, new DateTime(2020, 5, 25, 8, 42, 50, 722, DateTimeKind.Local).AddTicks(6314) },
                    { 5, 9, @"Ut consequatur deserunt omnis facere vel quidem recusandae.
                Repudiandae veniam veritatis ducimus dolores eos dolor et ullam autem.
                Tenetur aperiam sunt aut et rerum.
                Ipsam autem minima numquam ea voluptas.", new DateTime(2020, 5, 25, 8, 42, 50, 722, DateTimeKind.Local).AddTicks(6852), 31, new DateTime(2020, 5, 25, 8, 42, 50, 722, DateTimeKind.Local).AddTicks(6864) },
                    { 17, 7, "Dicta odio expedita. Iure voluptatibus ut et quod. Natus sunt labore officia exercitationem nam. Nihil dolore aut deserunt.", new DateTime(2020, 5, 25, 8, 42, 50, 723, DateTimeKind.Local).AddTicks(1139), 21, new DateTime(2020, 5, 25, 8, 42, 50, 723, DateTimeKind.Local).AddTicks(1150) },
                    { 11, 7, "Maxime aliquam ut. Id modi sit et sequi tenetur explicabo alias id. Sunt aut ea consequatur reprehenderit quae consectetur. Est qui quis ipsum. Numquam fugit dolores maxime. Eum placeat est iste reiciendis iste ducimus quidem dolore.", new DateTime(2020, 5, 25, 8, 42, 50, 722, DateTimeKind.Local).AddTicks(9988), 22, new DateTime(2020, 5, 25, 8, 42, 50, 722, DateTimeKind.Local).AddTicks(9999) },
                    { 6, 7, "Provident et sed enim vel hic mollitia.", new DateTime(2020, 5, 25, 8, 42, 50, 722, DateTimeKind.Local).AddTicks(6980), 31, new DateTime(2020, 5, 25, 8, 42, 50, 722, DateTimeKind.Local).AddTicks(6990) },
                    { 3, 18, "Sit rerum placeat officiis.", new DateTime(2020, 5, 25, 8, 42, 50, 722, DateTimeKind.Local).AddTicks(6166), 31, new DateTime(2020, 5, 25, 8, 42, 50, 722, DateTimeKind.Local).AddTicks(6194) },
                    { 9, 19, "Qui vitae aut aliquid. Quis ab dolores cumque vel. Praesentium fugiat maxime sequi natus debitis eum dolorum omnis asperiores. Nemo ut id architecto maxime. In voluptatum commodi ea.", new DateTime(2020, 5, 25, 8, 42, 50, 722, DateTimeKind.Local).AddTicks(9334), 27, new DateTime(2020, 5, 25, 8, 42, 50, 722, DateTimeKind.Local).AddTicks(9360) },
                    { 19, 13, @"Quia odio ab fugit explicabo magni consequatur.
                Consectetur qui omnis asperiores incidunt.
                Id dolores quo ut sed sint.", new DateTime(2020, 5, 25, 8, 42, 50, 723, DateTimeKind.Local).AddTicks(1578), 36, new DateTime(2020, 5, 25, 8, 42, 50, 723, DateTimeKind.Local).AddTicks(1588) },
                    { 12, 4, "Rerum quos et.", new DateTime(2020, 5, 25, 8, 42, 50, 723, DateTimeKind.Local).AddTicks(84), 32, new DateTime(2020, 5, 25, 8, 42, 50, 723, DateTimeKind.Local).AddTicks(94) },
                    { 2, 4, @"Id nesciunt vero tenetur autem.
                Vel iure cumque et vitae optio.
                Ab modi quidem eum et quod ab exercitationem quis distinctio.", new DateTime(2020, 5, 25, 8, 42, 50, 722, DateTimeKind.Local).AddTicks(4748), 35, new DateTime(2020, 5, 25, 8, 42, 50, 722, DateTimeKind.Local).AddTicks(4823) },
                    { 20, 14, @"Est beatae ipsum voluptatem reiciendis.
                Voluptas consectetur quisquam voluptates veritatis ipsa totam.
                Excepturi nihil ipsum.", new DateTime(2020, 5, 25, 8, 42, 50, 723, DateTimeKind.Local).AddTicks(1770), 27, new DateTime(2020, 5, 25, 8, 42, 50, 723, DateTimeKind.Local).AddTicks(1780) },
                    { 1, 4, "enim", new DateTime(2020, 5, 25, 8, 42, 50, 721, DateTimeKind.Local).AddTicks(1620), 36, new DateTime(2020, 5, 25, 8, 42, 50, 721, DateTimeKind.Local).AddTicks(2762) }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[,]
                {
                    { 14, 5, "Occaecati est unde dolore at delectus labore molestiae sit occaecati.", new DateTime(2020, 5, 25, 8, 42, 50, 732, DateTimeKind.Local).AddTicks(1229), 1, new DateTime(2020, 5, 25, 8, 42, 50, 732, DateTimeKind.Local).AddTicks(1240) },
                    { 17, 9, "Sunt dolores cum nihil accusantium et mollitia sit architecto nihil.", new DateTime(2020, 5, 25, 8, 42, 50, 732, DateTimeKind.Local).AddTicks(1557), 14, new DateTime(2020, 5, 25, 8, 42, 50, 732, DateTimeKind.Local).AddTicks(1566) },
                    { 13, 10, "Quis sed culpa qui earum.", new DateTime(2020, 5, 25, 8, 42, 50, 732, DateTimeKind.Local).AddTicks(1058), 18, new DateTime(2020, 5, 25, 8, 42, 50, 732, DateTimeKind.Local).AddTicks(1069) },
                    { 5, 19, "Ea rerum voluptate illo.", new DateTime(2020, 5, 25, 8, 42, 50, 732, DateTimeKind.Local).AddTicks(100), 7, new DateTime(2020, 5, 25, 8, 42, 50, 732, DateTimeKind.Local).AddTicks(109) },
                    { 1, 3, "Doloribus quisquam libero.", new DateTime(2020, 5, 25, 8, 42, 50, 731, DateTimeKind.Local).AddTicks(7700), 4, new DateTime(2020, 5, 25, 8, 42, 50, 731, DateTimeKind.Local).AddTicks(8694) },
                    { 9, 5, "Velit animi est eos esse eveniet unde.", new DateTime(2020, 5, 25, 8, 42, 50, 732, DateTimeKind.Local).AddTicks(537), 20, new DateTime(2020, 5, 25, 8, 42, 50, 732, DateTimeKind.Local).AddTicks(547) },
                    { 12, 10, "Hic labore est quis itaque consequatur dicta.", new DateTime(2020, 5, 25, 8, 42, 50, 732, DateTimeKind.Local).AddTicks(874), 5, new DateTime(2020, 5, 25, 8, 42, 50, 732, DateTimeKind.Local).AddTicks(884) },
                    { 6, 4, "Quia illum debitis enim.", new DateTime(2020, 5, 25, 8, 42, 50, 732, DateTimeKind.Local).AddTicks(192), 5, new DateTime(2020, 5, 25, 8, 42, 50, 732, DateTimeKind.Local).AddTicks(201) },
                    { 20, 6, "Nulla possimus nihil enim ea veritatis porro.", new DateTime(2020, 5, 25, 8, 42, 50, 732, DateTimeKind.Local).AddTicks(1859), 17, new DateTime(2020, 5, 25, 8, 42, 50, 732, DateTimeKind.Local).AddTicks(1869) },
                    { 3, 17, "Quis non repellendus et.", new DateTime(2020, 5, 25, 8, 42, 50, 731, DateTimeKind.Local).AddTicks(9884), 11, new DateTime(2020, 5, 25, 8, 42, 50, 731, DateTimeKind.Local).AddTicks(9894) },
                    { 16, 17, "Eaque voluptas sit ut necessitatibus.", new DateTime(2020, 5, 25, 8, 42, 50, 732, DateTimeKind.Local).AddTicks(1428), 6, new DateTime(2020, 5, 25, 8, 42, 50, 732, DateTimeKind.Local).AddTicks(1437) },
                    { 18, 5, "Perferendis voluptatum error.", new DateTime(2020, 5, 25, 8, 42, 50, 732, DateTimeKind.Local).AddTicks(1643), 5, new DateTime(2020, 5, 25, 8, 42, 50, 732, DateTimeKind.Local).AddTicks(1652) },
                    { 2, 11, "Quis sed autem nulla animi debitis aut assumenda.", new DateTime(2020, 5, 25, 8, 42, 50, 731, DateTimeKind.Local).AddTicks(9755), 2, new DateTime(2020, 5, 25, 8, 42, 50, 731, DateTimeKind.Local).AddTicks(9782) },
                    { 10, 3, "Enim dolores eius unde aut sunt enim nihil.", new DateTime(2020, 5, 25, 8, 42, 50, 732, DateTimeKind.Local).AddTicks(655), 2, new DateTime(2020, 5, 25, 8, 42, 50, 732, DateTimeKind.Local).AddTicks(664) },
                    { 15, 6, "Odit quae aut voluptatem.", new DateTime(2020, 5, 25, 8, 42, 50, 732, DateTimeKind.Local).AddTicks(1329), 12, new DateTime(2020, 5, 25, 8, 42, 50, 732, DateTimeKind.Local).AddTicks(1338) },
                    { 11, 3, "Ipsum tempore ipsam dolorum dolor eveniet eum.", new DateTime(2020, 5, 25, 8, 42, 50, 732, DateTimeKind.Local).AddTicks(765), 19, new DateTime(2020, 5, 25, 8, 42, 50, 732, DateTimeKind.Local).AddTicks(774) },
                    { 8, 8, "Eligendi esse vero sunt debitis aliquam.", new DateTime(2020, 5, 25, 8, 42, 50, 732, DateTimeKind.Local).AddTicks(425), 19, new DateTime(2020, 5, 25, 8, 42, 50, 732, DateTimeKind.Local).AddTicks(434) },
                    { 19, 15, "Voluptatem sequi sunt et.", new DateTime(2020, 5, 25, 8, 42, 50, 732, DateTimeKind.Local).AddTicks(1746), 19, new DateTime(2020, 5, 25, 8, 42, 50, 732, DateTimeKind.Local).AddTicks(1756) },
                    { 7, 5, "Ut blanditiis tempora rerum consequuntur nulla mollitia amet.", new DateTime(2020, 5, 25, 8, 42, 50, 732, DateTimeKind.Local).AddTicks(310), 2, new DateTime(2020, 5, 25, 8, 42, 50, 732, DateTimeKind.Local).AddTicks(320) },
                    { 4, 5, "Cum blanditiis dolore sint accusantium dolores deserunt.", new DateTime(2020, 5, 25, 8, 42, 50, 732, DateTimeKind.Local).AddTicks(6), 19, new DateTime(2020, 5, 25, 8, 42, 50, 732, DateTimeKind.Local).AddTicks(16) }
                });

            migrationBuilder.InsertData(
                table: "PostNegativeReactions",
                columns: new[] { "Id", "CreatedAt", "IsDislike", "PostId", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 5, 25, 8, 42, 50, 750, DateTimeKind.Local).AddTicks(1523), false, 4, new DateTime(2020, 5, 25, 8, 42, 50, 750, DateTimeKind.Local).AddTicks(2577), 17 },
                    { 6, new DateTime(2020, 5, 25, 8, 42, 50, 750, DateTimeKind.Local).AddTicks(3739), false, 4, new DateTime(2020, 5, 25, 8, 42, 50, 750, DateTimeKind.Local).AddTicks(3749), 3 },
                    { 3, new DateTime(2020, 5, 25, 8, 42, 50, 750, DateTimeKind.Local).AddTicks(3571), true, 13, new DateTime(2020, 5, 25, 8, 42, 50, 750, DateTimeKind.Local).AddTicks(3580), 18 },
                    { 12, new DateTime(2020, 5, 25, 8, 42, 50, 750, DateTimeKind.Local).AddTicks(4139), true, 13, new DateTime(2020, 5, 25, 8, 42, 50, 750, DateTimeKind.Local).AddTicks(4148), 2 },
                    { 17, new DateTime(2020, 5, 25, 8, 42, 50, 750, DateTimeKind.Local).AddTicks(4396), true, 15, new DateTime(2020, 5, 25, 8, 42, 50, 750, DateTimeKind.Local).AddTicks(4406), 9 },
                    { 19, new DateTime(2020, 5, 25, 8, 42, 50, 750, DateTimeKind.Local).AddTicks(4563), true, 15, new DateTime(2020, 5, 25, 8, 42, 50, 750, DateTimeKind.Local).AddTicks(4573), 7 },
                    { 16, new DateTime(2020, 5, 25, 8, 42, 50, 750, DateTimeKind.Local).AddTicks(4346), true, 10, new DateTime(2020, 5, 25, 8, 42, 50, 750, DateTimeKind.Local).AddTicks(4353), 5 },
                    { 15, new DateTime(2020, 5, 25, 8, 42, 50, 750, DateTimeKind.Local).AddTicks(4302), false, 1, new DateTime(2020, 5, 25, 8, 42, 50, 750, DateTimeKind.Local).AddTicks(4310), 20 },
                    { 11, new DateTime(2020, 5, 25, 8, 42, 50, 750, DateTimeKind.Local).AddTicks(4082), false, 14, new DateTime(2020, 5, 25, 8, 42, 50, 750, DateTimeKind.Local).AddTicks(4091), 21 },
                    { 20, new DateTime(2020, 5, 25, 8, 42, 50, 750, DateTimeKind.Local).AddTicks(4615), false, 13, new DateTime(2020, 5, 25, 8, 42, 50, 750, DateTimeKind.Local).AddTicks(4623), 14 },
                    { 2, new DateTime(2020, 5, 25, 8, 42, 50, 750, DateTimeKind.Local).AddTicks(3481), true, 19, new DateTime(2020, 5, 25, 8, 42, 50, 750, DateTimeKind.Local).AddTicks(3506), 12 },
                    { 5, new DateTime(2020, 5, 25, 8, 42, 50, 750, DateTimeKind.Local).AddTicks(3685), true, 8, new DateTime(2020, 5, 25, 8, 42, 50, 750, DateTimeKind.Local).AddTicks(3694), 5 },
                    { 9, new DateTime(2020, 5, 25, 8, 42, 50, 750, DateTimeKind.Local).AddTicks(3969), false, 5, new DateTime(2020, 5, 25, 8, 42, 50, 750, DateTimeKind.Local).AddTicks(3977), 20 },
                    { 4, new DateTime(2020, 5, 25, 8, 42, 50, 750, DateTimeKind.Local).AddTicks(3628), false, 9, new DateTime(2020, 5, 25, 8, 42, 50, 750, DateTimeKind.Local).AddTicks(3638), 7 },
                    { 8, new DateTime(2020, 5, 25, 8, 42, 50, 750, DateTimeKind.Local).AddTicks(3909), true, 9, new DateTime(2020, 5, 25, 8, 42, 50, 750, DateTimeKind.Local).AddTicks(3918), 3 },
                    { 18, new DateTime(2020, 5, 25, 8, 42, 50, 750, DateTimeKind.Local).AddTicks(4449), false, 11, new DateTime(2020, 5, 25, 8, 42, 50, 750, DateTimeKind.Local).AddTicks(4458), 20 },
                    { 13, new DateTime(2020, 5, 25, 8, 42, 50, 750, DateTimeKind.Local).AddTicks(4198), true, 6, new DateTime(2020, 5, 25, 8, 42, 50, 750, DateTimeKind.Local).AddTicks(4208), 13 },
                    { 14, new DateTime(2020, 5, 25, 8, 42, 50, 750, DateTimeKind.Local).AddTicks(4253), true, 20, new DateTime(2020, 5, 25, 8, 42, 50, 750, DateTimeKind.Local).AddTicks(4261), 21 },
                    { 10, new DateTime(2020, 5, 25, 8, 42, 50, 750, DateTimeKind.Local).AddTicks(4025), true, 17, new DateTime(2020, 5, 25, 8, 42, 50, 750, DateTimeKind.Local).AddTicks(4034), 19 },
                    { 7, new DateTime(2020, 5, 25, 8, 42, 50, 750, DateTimeKind.Local).AddTicks(3833), false, 17, new DateTime(2020, 5, 25, 8, 42, 50, 750, DateTimeKind.Local).AddTicks(3844), 1 }
                });

            migrationBuilder.InsertData(
                table: "PostReactions",
                columns: new[] { "Id", "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 17, new DateTime(2020, 5, 25, 8, 42, 50, 741, DateTimeKind.Local).AddTicks(9299), false, 14, new DateTime(2020, 5, 25, 8, 42, 50, 741, DateTimeKind.Local).AddTicks(9308), 7 },
                    { 6, new DateTime(2020, 5, 25, 8, 42, 50, 741, DateTimeKind.Local).AddTicks(8716), true, 14, new DateTime(2020, 5, 25, 8, 42, 50, 741, DateTimeKind.Local).AddTicks(8725), 14 },
                    { 9, new DateTime(2020, 5, 25, 8, 42, 50, 741, DateTimeKind.Local).AddTicks(8870), true, 17, new DateTime(2020, 5, 25, 8, 42, 50, 741, DateTimeKind.Local).AddTicks(8879), 14 },
                    { 8, new DateTime(2020, 5, 25, 8, 42, 50, 741, DateTimeKind.Local).AddTicks(8820), false, 17, new DateTime(2020, 5, 25, 8, 42, 50, 741, DateTimeKind.Local).AddTicks(8828), 21 },
                    { 19, new DateTime(2020, 5, 25, 8, 42, 50, 741, DateTimeKind.Local).AddTicks(9402), true, 18, new DateTime(2020, 5, 25, 8, 42, 50, 741, DateTimeKind.Local).AddTicks(9411), 18 },
                    { 15, new DateTime(2020, 5, 25, 8, 42, 50, 741, DateTimeKind.Local).AddTicks(9196), false, 1, new DateTime(2020, 5, 25, 8, 42, 50, 741, DateTimeKind.Local).AddTicks(9205), 18 },
                    { 10, new DateTime(2020, 5, 25, 8, 42, 50, 741, DateTimeKind.Local).AddTicks(8922), false, 7, new DateTime(2020, 5, 25, 8, 42, 50, 741, DateTimeKind.Local).AddTicks(8931), 16 },
                    { 20, new DateTime(2020, 5, 25, 8, 42, 50, 741, DateTimeKind.Local).AddTicks(9454), false, 1, new DateTime(2020, 5, 25, 8, 42, 50, 741, DateTimeKind.Local).AddTicks(9462), 12 },
                    { 16, new DateTime(2020, 5, 25, 8, 42, 50, 741, DateTimeKind.Local).AddTicks(9248), true, 10, new DateTime(2020, 5, 25, 8, 42, 50, 741, DateTimeKind.Local).AddTicks(9257), 18 },
                    { 13, new DateTime(2020, 5, 25, 8, 42, 50, 741, DateTimeKind.Local).AddTicks(9077), false, 10, new DateTime(2020, 5, 25, 8, 42, 50, 741, DateTimeKind.Local).AddTicks(9086), 6 },
                    { 4, new DateTime(2020, 5, 25, 8, 42, 50, 741, DateTimeKind.Local).AddTicks(8614), false, 5, new DateTime(2020, 5, 25, 8, 42, 50, 741, DateTimeKind.Local).AddTicks(8622), 19 },
                    { 12, new DateTime(2020, 5, 25, 8, 42, 50, 741, DateTimeKind.Local).AddTicks(9026), true, 15, new DateTime(2020, 5, 25, 8, 42, 50, 741, DateTimeKind.Local).AddTicks(9035), 14 },
                    { 1, new DateTime(2020, 5, 25, 8, 42, 50, 741, DateTimeKind.Local).AddTicks(6252), false, 11, new DateTime(2020, 5, 25, 8, 42, 50, 741, DateTimeKind.Local).AddTicks(7351), 18 },
                    { 14, new DateTime(2020, 5, 25, 8, 42, 50, 741, DateTimeKind.Local).AddTicks(9129), false, 13, new DateTime(2020, 5, 25, 8, 42, 50, 741, DateTimeKind.Local).AddTicks(9138), 10 },
                    { 5, new DateTime(2020, 5, 25, 8, 42, 50, 741, DateTimeKind.Local).AddTicks(8665), true, 13, new DateTime(2020, 5, 25, 8, 42, 50, 741, DateTimeKind.Local).AddTicks(8674), 7 },
                    { 3, new DateTime(2020, 5, 25, 8, 42, 50, 741, DateTimeKind.Local).AddTicks(8559), false, 13, new DateTime(2020, 5, 25, 8, 42, 50, 741, DateTimeKind.Local).AddTicks(8568), 20 },
                    { 2, new DateTime(2020, 5, 25, 8, 42, 50, 741, DateTimeKind.Local).AddTicks(8472), false, 11, new DateTime(2020, 5, 25, 8, 42, 50, 741, DateTimeKind.Local).AddTicks(8500), 14 },
                    { 18, new DateTime(2020, 5, 25, 8, 42, 50, 741, DateTimeKind.Local).AddTicks(9350), true, 10, new DateTime(2020, 5, 25, 8, 42, 50, 741, DateTimeKind.Local).AddTicks(9359), 16 },
                    { 7, new DateTime(2020, 5, 25, 8, 42, 50, 741, DateTimeKind.Local).AddTicks(8768), false, 11, new DateTime(2020, 5, 25, 8, 42, 50, 741, DateTimeKind.Local).AddTicks(8777), 18 }
                });

            migrationBuilder.InsertData(
                table: "CommentNegativeReactions",
                columns: new[] { "Id", "CommentId", "CreatedAt", "IsDislike", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 7, 7, new DateTime(2020, 5, 25, 8, 42, 50, 764, DateTimeKind.Local).AddTicks(1411), true, new DateTime(2020, 5, 25, 8, 42, 50, 764, DateTimeKind.Local).AddTicks(1419), 18 },
                    { 4, 12, new DateTime(2020, 5, 25, 8, 42, 50, 764, DateTimeKind.Local).AddTicks(1261), true, new DateTime(2020, 5, 25, 8, 42, 50, 764, DateTimeKind.Local).AddTicks(1269), 18 },
                    { 3, 6, new DateTime(2020, 5, 25, 8, 42, 50, 764, DateTimeKind.Local).AddTicks(1210), false, new DateTime(2020, 5, 25, 8, 42, 50, 764, DateTimeKind.Local).AddTicks(1219), 5 },
                    { 20, 9, new DateTime(2020, 5, 25, 8, 42, 50, 764, DateTimeKind.Local).AddTicks(2010), false, new DateTime(2020, 5, 25, 8, 42, 50, 764, DateTimeKind.Local).AddTicks(2015), 7 },
                    { 19, 20, new DateTime(2020, 5, 25, 8, 42, 50, 764, DateTimeKind.Local).AddTicks(1983), false, new DateTime(2020, 5, 25, 8, 42, 50, 764, DateTimeKind.Local).AddTicks(1988), 11 },
                    { 12, 20, new DateTime(2020, 5, 25, 8, 42, 50, 764, DateTimeKind.Local).AddTicks(1665), false, new DateTime(2020, 5, 25, 8, 42, 50, 764, DateTimeKind.Local).AddTicks(1674), 9 },
                    { 8, 20, new DateTime(2020, 5, 25, 8, 42, 50, 764, DateTimeKind.Local).AddTicks(1461), false, new DateTime(2020, 5, 25, 8, 42, 50, 764, DateTimeKind.Local).AddTicks(1470), 14 },
                    { 16, 12, new DateTime(2020, 5, 25, 8, 42, 50, 764, DateTimeKind.Local).AddTicks(1871), true, new DateTime(2020, 5, 25, 8, 42, 50, 764, DateTimeKind.Local).AddTicks(1879), 5 },
                    { 6, 19, new DateTime(2020, 5, 25, 8, 42, 50, 764, DateTimeKind.Local).AddTicks(1361), true, new DateTime(2020, 5, 25, 8, 42, 50, 764, DateTimeKind.Local).AddTicks(1369), 9 },
                    { 13, 11, new DateTime(2020, 5, 25, 8, 42, 50, 764, DateTimeKind.Local).AddTicks(1719), true, new DateTime(2020, 5, 25, 8, 42, 50, 764, DateTimeKind.Local).AddTicks(1727), 1 },
                    { 18, 19, new DateTime(2020, 5, 25, 8, 42, 50, 764, DateTimeKind.Local).AddTicks(1955), false, new DateTime(2020, 5, 25, 8, 42, 50, 764, DateTimeKind.Local).AddTicks(1960), 2 },
                    { 11, 5, new DateTime(2020, 5, 25, 8, 42, 50, 764, DateTimeKind.Local).AddTicks(1613), true, new DateTime(2020, 5, 25, 8, 42, 50, 764, DateTimeKind.Local).AddTicks(1622), 10 },
                    { 2, 15, new DateTime(2020, 5, 25, 8, 42, 50, 764, DateTimeKind.Local).AddTicks(1125), true, new DateTime(2020, 5, 25, 8, 42, 50, 764, DateTimeKind.Local).AddTicks(1152), 18 },
                    { 14, 13, new DateTime(2020, 5, 25, 8, 42, 50, 764, DateTimeKind.Local).AddTicks(1770), true, new DateTime(2020, 5, 25, 8, 42, 50, 764, DateTimeKind.Local).AddTicks(1778), 16 },
                    { 5, 17, new DateTime(2020, 5, 25, 8, 42, 50, 764, DateTimeKind.Local).AddTicks(1311), true, new DateTime(2020, 5, 25, 8, 42, 50, 764, DateTimeKind.Local).AddTicks(1320), 16 },
                    { 15, 10, new DateTime(2020, 5, 25, 8, 42, 50, 764, DateTimeKind.Local).AddTicks(1822), false, new DateTime(2020, 5, 25, 8, 42, 50, 764, DateTimeKind.Local).AddTicks(1830), 8 },
                    { 10, 10, new DateTime(2020, 5, 25, 8, 42, 50, 764, DateTimeKind.Local).AddTicks(1562), false, new DateTime(2020, 5, 25, 8, 42, 50, 764, DateTimeKind.Local).AddTicks(1571), 17 },
                    { 1, 10, new DateTime(2020, 5, 25, 8, 42, 50, 763, DateTimeKind.Local).AddTicks(9530), true, new DateTime(2020, 5, 25, 8, 42, 50, 764, DateTimeKind.Local).AddTicks(321), 13 },
                    { 9, 9, new DateTime(2020, 5, 25, 8, 42, 50, 764, DateTimeKind.Local).AddTicks(1512), true, new DateTime(2020, 5, 25, 8, 42, 50, 764, DateTimeKind.Local).AddTicks(1520), 9 },
                    { 17, 12, new DateTime(2020, 5, 25, 8, 42, 50, 764, DateTimeKind.Local).AddTicks(1920), true, new DateTime(2020, 5, 25, 8, 42, 50, 764, DateTimeKind.Local).AddTicks(1928), 14 }
                });

            migrationBuilder.InsertData(
                table: "CommentReactions",
                columns: new[] { "Id", "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 16, 5, new DateTime(2020, 5, 25, 8, 42, 50, 759, DateTimeKind.Local).AddTicks(385), true, new DateTime(2020, 5, 25, 8, 42, 50, 759, DateTimeKind.Local).AddTicks(389), 18 },
                    { 5, 1, new DateTime(2020, 5, 25, 8, 42, 50, 759, DateTimeKind.Local).AddTicks(67), false, new DateTime(2020, 5, 25, 8, 42, 50, 759, DateTimeKind.Local).AddTicks(73), 15 },
                    { 20, 18, new DateTime(2020, 5, 25, 8, 42, 50, 759, DateTimeKind.Local).AddTicks(492), false, new DateTime(2020, 5, 25, 8, 42, 50, 759, DateTimeKind.Local).AddTicks(497), 17 },
                    { 19, 18, new DateTime(2020, 5, 25, 8, 42, 50, 759, DateTimeKind.Local).AddTicks(466), false, new DateTime(2020, 5, 25, 8, 42, 50, 759, DateTimeKind.Local).AddTicks(470), 20 },
                    { 13, 18, new DateTime(2020, 5, 25, 8, 42, 50, 759, DateTimeKind.Local).AddTicks(292), true, new DateTime(2020, 5, 25, 8, 42, 50, 759, DateTimeKind.Local).AddTicks(297), 21 },
                    { 12, 18, new DateTime(2020, 5, 25, 8, 42, 50, 759, DateTimeKind.Local).AddTicks(265), false, new DateTime(2020, 5, 25, 8, 42, 50, 759, DateTimeKind.Local).AddTicks(270), 9 },
                    { 9, 1, new DateTime(2020, 5, 25, 8, 42, 50, 759, DateTimeKind.Local).AddTicks(182), true, new DateTime(2020, 5, 25, 8, 42, 50, 759, DateTimeKind.Local).AddTicks(187), 4 },
                    { 1, 20, new DateTime(2020, 5, 25, 8, 42, 50, 758, DateTimeKind.Local).AddTicks(8479), false, new DateTime(2020, 5, 25, 8, 42, 50, 758, DateTimeKind.Local).AddTicks(9300), 3 },
                    { 15, 20, new DateTime(2020, 5, 25, 8, 42, 50, 759, DateTimeKind.Local).AddTicks(357), true, new DateTime(2020, 5, 25, 8, 42, 50, 759, DateTimeKind.Local).AddTicks(362), 8 },
                    { 11, 20, new DateTime(2020, 5, 25, 8, 42, 50, 759, DateTimeKind.Local).AddTicks(238), false, new DateTime(2020, 5, 25, 8, 42, 50, 759, DateTimeKind.Local).AddTicks(242), 16 },
                    { 3, 3, new DateTime(2020, 5, 25, 8, 42, 50, 758, DateTimeKind.Local).AddTicks(9986), false, new DateTime(2020, 5, 25, 8, 42, 50, 758, DateTimeKind.Local).AddTicks(9992), 16 },
                    { 10, 16, new DateTime(2020, 5, 25, 8, 42, 50, 759, DateTimeKind.Local).AddTicks(209), true, new DateTime(2020, 5, 25, 8, 42, 50, 759, DateTimeKind.Local).AddTicks(214), 6 },
                    { 6, 4, new DateTime(2020, 5, 25, 8, 42, 50, 759, DateTimeKind.Local).AddTicks(97), false, new DateTime(2020, 5, 25, 8, 42, 50, 759, DateTimeKind.Local).AddTicks(102), 12 },
                    { 17, 15, new DateTime(2020, 5, 25, 8, 42, 50, 759, DateTimeKind.Local).AddTicks(411), false, new DateTime(2020, 5, 25, 8, 42, 50, 759, DateTimeKind.Local).AddTicks(416), 7 },
                    { 7, 15, new DateTime(2020, 5, 25, 8, 42, 50, 759, DateTimeKind.Local).AddTicks(126), true, new DateTime(2020, 5, 25, 8, 42, 50, 759, DateTimeKind.Local).AddTicks(131), 8 },
                    { 14, 10, new DateTime(2020, 5, 25, 8, 42, 50, 759, DateTimeKind.Local).AddTicks(319), false, new DateTime(2020, 5, 25, 8, 42, 50, 759, DateTimeKind.Local).AddTicks(332), 12 },
                    { 4, 10, new DateTime(2020, 5, 25, 8, 42, 50, 759, DateTimeKind.Local).AddTicks(18), false, new DateTime(2020, 5, 25, 8, 42, 50, 759, DateTimeKind.Local).AddTicks(23), 10 },
                    { 2, 7, new DateTime(2020, 5, 25, 8, 42, 50, 758, DateTimeKind.Local).AddTicks(9930), false, new DateTime(2020, 5, 25, 8, 42, 50, 758, DateTimeKind.Local).AddTicks(9949), 1 },
                    { 18, 6, new DateTime(2020, 5, 25, 8, 42, 50, 759, DateTimeKind.Local).AddTicks(438), false, new DateTime(2020, 5, 25, 8, 42, 50, 759, DateTimeKind.Local).AddTicks(443), 7 },
                    { 8, 9, new DateTime(2020, 5, 25, 8, 42, 50, 759, DateTimeKind.Local).AddTicks(154), false, new DateTime(2020, 5, 25, 8, 42, 50, 759, DateTimeKind.Local).AddTicks(159), 6 }
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
