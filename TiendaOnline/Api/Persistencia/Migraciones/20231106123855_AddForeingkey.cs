using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Api.Persistencia.Migraciones
{
    /// <inheritdoc />
    public partial class AddForeingkey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Producto_Categoria_categoriaIdCategoria",
                table: "Producto");

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

            migrationBuilder.RenameColumn(
                name: "categoriaIdCategoria",
                table: "Producto",
                newName: "IdCategoria");

            migrationBuilder.RenameIndex(
                name: "IX_Producto_categoriaIdCategoria",
                table: "Producto",
                newName: "IX_Producto_IdCategoria");

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "IdCategoria", "Descripcion", "Nombre" },
                values: new object[,]
                {
                    { new Guid("333cb75d-8444-4325-84c6-e539fdc46f22"), "Ropa de moda para todas las edades", "Ropa" },
                    { new Guid("35db293b-c55d-43fd-9722-840b02c77d26"), "Productos alimenticios y comestibles", "Alimentos" },
                    { new Guid("554a879f-204b-42fc-9028-a5835d700582"), "Artículos para el hogar y decoración", "Hogar" },
                    { new Guid("897cf089-90b6-43d1-a5ff-4037970bdbbf"), "Productos electrónicos y gadgets", "Electrónica" },
                    { new Guid("8e24c6f4-cccb-46aa-b6ca-ffec77a24d82"), "Equipos y accesorios deportivos", "Deportes" }
                });

            migrationBuilder.InsertData(
                table: "Producto",
                columns: new[] { "Id", "Descripcion", "IdCategoria", "Nombre", "Precio", "Stock", "VendedorId" },
                values: new object[,]
                {
                    { new Guid("2bd6c181-9c61-4ca9-aa7b-bb058e3040fc"), "", null, "Pan integral", 3.9900000000000002, 200, null },
                    { new Guid("72ca7f60-491e-432b-b18a-4610622b1bb9"), "", null, "Smartphone", 120.0, 5, null },
                    { new Guid("89781313-25fd-4546-a22a-c4f217cb8389"), "", null, "Televisor", 200.0, 5, null },
                    { new Guid("e6ba5dba-f598-4f50-add8-bb053b7ed581"), "", null, "Laptop", 150.0, 5, null },
                    { new Guid("f8a4f4a8-ffa3-477b-ba28-0ad81fce1273"), "", null, "Manzanas", 2.4900000000000002, 150, null }
                });

            migrationBuilder.InsertData(
                table: "Vendedor",
                columns: new[] { "Id", "Apellido", "Apodo", "Email", "Nombre", "Password" },
                values: new object[,]
                {
                    { new Guid("2ca2592d-fd09-4915-9eb7-02d1004ce6e4"), "Gomez", "anita456", "anagomez@example.com", "Ana", "clave456" },
                    { new Guid("3888a184-8e06-4593-a8d1-086ff578119d"), "hyodo", "delfin", "ññ@gmail.com", "Issei", "30851" },
                    { new Guid("6e4262ca-2163-47b4-b156-57b54f804def"), "Perez", "juanito123", "juanperez@example.com", "Juan", "password123" },
                    { new Guid("7bd5e208-8d15-463b-a8a0-bc8f7433a599"), "Rodriguez", "lucho789", "luisr@example.com", "Luis", "pass789" },
                    { new Guid("c49c2e1f-48e6-43c8-9f7c-52c8e49e9d6b"), "López", "carlitos1", "carlosl@example.com", "Carlos", "clave1234" },
                    { new Guid("c848ef91-d1c0-441e-bc6d-ad3db24f60bf"), "Martínez", "mari123", "mariam@example.com", "María", "contraseña123" },
                    { new Guid("f1430abf-6c04-4e19-bed9-98d030eea630"), "Gremory", "delfin", "kk@gmail.com", "Rias", "dsfsdfv" }
                });

            migrationBuilder.InsertData(
                table: "Cliente",
                column: "Id",
                values: new object[]
                {
                    new Guid("2ca2592d-fd09-4915-9eb7-02d1004ce6e4"),
                    new Guid("6e4262ca-2163-47b4-b156-57b54f804def"),
                    new Guid("7bd5e208-8d15-463b-a8a0-bc8f7433a599"),
                    new Guid("c49c2e1f-48e6-43c8-9f7c-52c8e49e9d6b"),
                    new Guid("c848ef91-d1c0-441e-bc6d-ad3db24f60bf")
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Producto_Categoria_IdCategoria",
                table: "Producto",
                column: "IdCategoria",
                principalTable: "Categoria",
                principalColumn: "IdCategoria");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Producto_Categoria_IdCategoria",
                table: "Producto");

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "IdCategoria",
                keyValue: new Guid("333cb75d-8444-4325-84c6-e539fdc46f22"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "IdCategoria",
                keyValue: new Guid("35db293b-c55d-43fd-9722-840b02c77d26"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "IdCategoria",
                keyValue: new Guid("554a879f-204b-42fc-9028-a5835d700582"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "IdCategoria",
                keyValue: new Guid("897cf089-90b6-43d1-a5ff-4037970bdbbf"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "IdCategoria",
                keyValue: new Guid("8e24c6f4-cccb-46aa-b6ca-ffec77a24d82"));

            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: new Guid("2ca2592d-fd09-4915-9eb7-02d1004ce6e4"));

            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: new Guid("6e4262ca-2163-47b4-b156-57b54f804def"));

            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: new Guid("7bd5e208-8d15-463b-a8a0-bc8f7433a599"));

            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: new Guid("c49c2e1f-48e6-43c8-9f7c-52c8e49e9d6b"));

            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: new Guid("c848ef91-d1c0-441e-bc6d-ad3db24f60bf"));

            migrationBuilder.DeleteData(
                table: "Producto",
                keyColumn: "Id",
                keyValue: new Guid("2bd6c181-9c61-4ca9-aa7b-bb058e3040fc"));

            migrationBuilder.DeleteData(
                table: "Producto",
                keyColumn: "Id",
                keyValue: new Guid("72ca7f60-491e-432b-b18a-4610622b1bb9"));

            migrationBuilder.DeleteData(
                table: "Producto",
                keyColumn: "Id",
                keyValue: new Guid("89781313-25fd-4546-a22a-c4f217cb8389"));

            migrationBuilder.DeleteData(
                table: "Producto",
                keyColumn: "Id",
                keyValue: new Guid("e6ba5dba-f598-4f50-add8-bb053b7ed581"));

            migrationBuilder.DeleteData(
                table: "Producto",
                keyColumn: "Id",
                keyValue: new Guid("f8a4f4a8-ffa3-477b-ba28-0ad81fce1273"));

            migrationBuilder.DeleteData(
                table: "Vendedor",
                keyColumn: "Id",
                keyValue: new Guid("3888a184-8e06-4593-a8d1-086ff578119d"));

            migrationBuilder.DeleteData(
                table: "Vendedor",
                keyColumn: "Id",
                keyValue: new Guid("f1430abf-6c04-4e19-bed9-98d030eea630"));

            migrationBuilder.DeleteData(
                table: "Vendedor",
                keyColumn: "Id",
                keyValue: new Guid("2ca2592d-fd09-4915-9eb7-02d1004ce6e4"));

            migrationBuilder.DeleteData(
                table: "Vendedor",
                keyColumn: "Id",
                keyValue: new Guid("6e4262ca-2163-47b4-b156-57b54f804def"));

            migrationBuilder.DeleteData(
                table: "Vendedor",
                keyColumn: "Id",
                keyValue: new Guid("7bd5e208-8d15-463b-a8a0-bc8f7433a599"));

            migrationBuilder.DeleteData(
                table: "Vendedor",
                keyColumn: "Id",
                keyValue: new Guid("c49c2e1f-48e6-43c8-9f7c-52c8e49e9d6b"));

            migrationBuilder.DeleteData(
                table: "Vendedor",
                keyColumn: "Id",
                keyValue: new Guid("c848ef91-d1c0-441e-bc6d-ad3db24f60bf"));

            migrationBuilder.RenameColumn(
                name: "IdCategoria",
                table: "Producto",
                newName: "categoriaIdCategoria");

            migrationBuilder.RenameIndex(
                name: "IX_Producto_IdCategoria",
                table: "Producto",
                newName: "IX_Producto_categoriaIdCategoria");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Producto_Categoria_categoriaIdCategoria",
                table: "Producto",
                column: "categoriaIdCategoria",
                principalTable: "Categoria",
                principalColumn: "IdCategoria");
        }
    }
}
