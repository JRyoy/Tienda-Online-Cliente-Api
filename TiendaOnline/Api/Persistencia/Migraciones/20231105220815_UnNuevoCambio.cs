using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Api.Persistencia.Migraciones
{
    /// <inheritdoc />
    public partial class UnNuevoCambio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Vendedor",
                keyColumn: "Id",
                keyValue: new Guid("27cc81f7-3f6f-456e-9ae5-61645466fe52"));

            migrationBuilder.DeleteData(
                table: "Vendedor",
                keyColumn: "Id",
                keyValue: new Guid("3fc1030c-a230-43a6-adfc-a304eca96c52"));

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Categoria",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(30)",
                oldMaxLength: 30)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "IdCategoria", "Descripcion", "Nombre" },
                values: new object[,]
                {
                    { new Guid("0377c43c-5ee4-4bfc-b6b7-4a66cd7e0fa1"), "Equipos y accesorios deportivos", "Deportes" },
                    { new Guid("1adb2967-c87d-41db-8269-1bc240a870fc"), "Ropa de moda para todas las edades", "Ropa" },
                    { new Guid("2d32e430-a901-4aee-a941-45d9d5f35628"), "Productos electrónicos y gadgets", "Electrónica" },
                    { new Guid("2e26d56a-f4fa-4370-abfa-03e45662d90a"), "Productos alimenticios y comestibles", "Alimentos" },
                    { new Guid("2fff1b06-14ee-4db5-890f-6ce69bab9811"), "Artículos para el hogar y decoración", "Hogar" }
                });

            migrationBuilder.InsertData(
                table: "Producto",
                columns: new[] { "Id", "Descripcion", "Nombre", "Precio", "Stock", "VendedorId", "categoriaIdCategoria" },
                values: new object[,]
                {
                    { new Guid("040213b5-457e-46ce-8ef9-84cf94f3cb55"), "", "Laptop", 150.0, 5, null, null },
                    { new Guid("1a633e85-d197-434f-a734-27c9fb23222b"), "", "Pan integral", 3.9900000000000002, 200, null, null },
                    { new Guid("3e9c240c-f38e-4f0e-b9be-b5605510bde5"), "", "Televisor", 200.0, 5, null, null },
                    { new Guid("54c81ac8-9a8d-41ac-8bc3-0947ab2f557a"), "", "Manzanas", 2.4900000000000002, 150, null, null },
                    { new Guid("bbc5c2eb-2ae9-4023-9311-60def60cdb98"), "", "Smartphone", 120.0, 5, null, null }
                });

            migrationBuilder.InsertData(
                table: "Vendedor",
                columns: new[] { "Id", "Apellido", "Apodo", "Email", "Nombre", "Password" },
                values: new object[,]
                {
                    { new Guid("106788c9-c363-4f50-b42c-c4ee984fb821"), "Martínez", "mari123", "mariam@example.com", "María", "contraseña123" },
                    { new Guid("1da1542c-301e-4508-bfbf-80fc87e643fc"), "Gomez", "anita456", "anagomez@example.com", "Ana", "clave456" },
                    { new Guid("28b06b4e-67b1-4c6d-9094-88f6791d3483"), "Rodriguez", "lucho789", "luisr@example.com", "Luis", "pass789" },
                    { new Guid("64017c7b-2317-443a-a369-6ee3a435240e"), "Gremory", "delfin", "kk@gmail.com", "Rias", "dsfsdfv" },
                    { new Guid("7c3e4e4c-be0b-4053-b80c-8bc688070dff"), "hyodo", "delfin", "ññ@gmail.com", "Issei", "30851" },
                    { new Guid("80bfc8b7-27f9-42aa-b6dc-022e860db641"), "Perez", "juanito123", "juanperez@example.com", "Juan", "password123" },
                    { new Guid("ceb8e92d-0f3a-4a1f-8e04-0194721e36ed"), "López", "carlitos1", "carlosl@example.com", "Carlos", "clave1234" }
                });

            migrationBuilder.InsertData(
                table: "Cliente",
                column: "Id",
                values: new object[]
                {
                    new Guid("106788c9-c363-4f50-b42c-c4ee984fb821"),
                    new Guid("1da1542c-301e-4508-bfbf-80fc87e643fc"),
                    new Guid("28b06b4e-67b1-4c6d-9094-88f6791d3483"),
                    new Guid("80bfc8b7-27f9-42aa-b6dc-022e860db641"),
                    new Guid("ceb8e92d-0f3a-4a1f-8e04-0194721e36ed")
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "IdCategoria",
                keyValue: new Guid("0377c43c-5ee4-4bfc-b6b7-4a66cd7e0fa1"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "IdCategoria",
                keyValue: new Guid("1adb2967-c87d-41db-8269-1bc240a870fc"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "IdCategoria",
                keyValue: new Guid("2d32e430-a901-4aee-a941-45d9d5f35628"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "IdCategoria",
                keyValue: new Guid("2e26d56a-f4fa-4370-abfa-03e45662d90a"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "IdCategoria",
                keyValue: new Guid("2fff1b06-14ee-4db5-890f-6ce69bab9811"));

            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: new Guid("106788c9-c363-4f50-b42c-c4ee984fb821"));

            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: new Guid("1da1542c-301e-4508-bfbf-80fc87e643fc"));

            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: new Guid("28b06b4e-67b1-4c6d-9094-88f6791d3483"));

            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: new Guid("80bfc8b7-27f9-42aa-b6dc-022e860db641"));

            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: new Guid("ceb8e92d-0f3a-4a1f-8e04-0194721e36ed"));

            migrationBuilder.DeleteData(
                table: "Producto",
                keyColumn: "Id",
                keyValue: new Guid("040213b5-457e-46ce-8ef9-84cf94f3cb55"));

            migrationBuilder.DeleteData(
                table: "Producto",
                keyColumn: "Id",
                keyValue: new Guid("1a633e85-d197-434f-a734-27c9fb23222b"));

            migrationBuilder.DeleteData(
                table: "Producto",
                keyColumn: "Id",
                keyValue: new Guid("3e9c240c-f38e-4f0e-b9be-b5605510bde5"));

            migrationBuilder.DeleteData(
                table: "Producto",
                keyColumn: "Id",
                keyValue: new Guid("54c81ac8-9a8d-41ac-8bc3-0947ab2f557a"));

            migrationBuilder.DeleteData(
                table: "Producto",
                keyColumn: "Id",
                keyValue: new Guid("bbc5c2eb-2ae9-4023-9311-60def60cdb98"));

            migrationBuilder.DeleteData(
                table: "Vendedor",
                keyColumn: "Id",
                keyValue: new Guid("64017c7b-2317-443a-a369-6ee3a435240e"));

            migrationBuilder.DeleteData(
                table: "Vendedor",
                keyColumn: "Id",
                keyValue: new Guid("7c3e4e4c-be0b-4053-b80c-8bc688070dff"));

            migrationBuilder.DeleteData(
                table: "Vendedor",
                keyColumn: "Id",
                keyValue: new Guid("106788c9-c363-4f50-b42c-c4ee984fb821"));

            migrationBuilder.DeleteData(
                table: "Vendedor",
                keyColumn: "Id",
                keyValue: new Guid("1da1542c-301e-4508-bfbf-80fc87e643fc"));

            migrationBuilder.DeleteData(
                table: "Vendedor",
                keyColumn: "Id",
                keyValue: new Guid("28b06b4e-67b1-4c6d-9094-88f6791d3483"));

            migrationBuilder.DeleteData(
                table: "Vendedor",
                keyColumn: "Id",
                keyValue: new Guid("80bfc8b7-27f9-42aa-b6dc-022e860db641"));

            migrationBuilder.DeleteData(
                table: "Vendedor",
                keyColumn: "Id",
                keyValue: new Guid("ceb8e92d-0f3a-4a1f-8e04-0194721e36ed"));

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Categoria",
                type: "varchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Vendedor",
                columns: new[] { "Id", "Apellido", "Apodo", "Email", "Nombre", "Password" },
                values: new object[,]
                {
                    { new Guid("27cc81f7-3f6f-456e-9ae5-61645466fe52"), "hyodo", "delfin", "ññ@gmail.com", "Issei", "30851" },
                    { new Guid("3fc1030c-a230-43a6-adfc-a304eca96c52"), "Gremory", "delfin", "kk@gmail.com", "Rias", "dsfsdfv" }
                });
        }
    }
}
