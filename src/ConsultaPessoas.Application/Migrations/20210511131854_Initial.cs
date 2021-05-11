using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsultaPessoas.Application.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pessoas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "DATE", nullable: false),
                    Cpf = table.Column<string>(type: "VARCHAR(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoas", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Pessoas",
                columns: new[] { "Id", "Cpf", "DataNascimento", "Nome" },
                values: new object[,]
                {
                    { new Guid("f641b7e8-616d-4297-a650-c135a11fcbb4"), "27476834275", new DateTime(1982, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maitê" },
                    { new Guid("8e01a0a4-ad6a-4d11-bbf2-44b189face2d"), "52703430531", new DateTime(1961, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Valentina" },
                    { new Guid("718518b6-2179-4c96-ba43-4fdea60a31e4"), "79895935307", new DateTime(1923, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lara" },
                    { new Guid("26019cdd-86b8-4868-8e5b-26a27646ae8a"), "49176366472", new DateTime(1962, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Arthur" },
                    { new Guid("1148d316-4575-4e05-b64c-0e049cde8791"), "90904857590", new DateTime(1941, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Allana" },
                    { new Guid("258f5834-3ce1-4149-a98e-6dd94c5d9e71"), "57599842179", new DateTime(1973, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Júlia" },
                    { new Guid("93dba988-ddf8-4895-b38f-593d6d263d51"), "63320533053", new DateTime(1976, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Louise" },
                    { new Guid("dbc7a423-1845-429a-ac5c-de08e4b98558"), "32955525251", new DateTime(1968, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Raul" },
                    { new Guid("1c7b8413-3303-4030-a1f9-cfd3abcf3741"), "36252310344", new DateTime(1924, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Milena" },
                    { new Guid("7e98e468-8d23-49dd-9223-1dfc6f6656d3"), "23510535839", new DateTime(2017, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "José" },
                    { new Guid("05249613-665b-4308-966d-205b976153bb"), "99563548728", new DateTime(2003, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pedro" },
                    { new Guid("5fbeda90-6438-4828-a1c2-64f8e368ac53"), "32772682846", new DateTime(1942, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Levi" },
                    { new Guid("7f0d001b-549e-46dc-9b09-b7567042814c"), "78930685668", new DateTime(1982, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Francisco" },
                    { new Guid("5f58d3d7-ad31-4cdd-b78a-f14c23a9a64e"), "15270628309", new DateTime(1993, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sophie" },
                    { new Guid("760abbcd-2734-4627-8597-403619ee059d"), "46572225119", new DateTime(1983, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maitê" },
                    { new Guid("4ac6df8d-860c-40be-9254-0f366fb933ba"), "57126138679", new DateTime(2003, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Breno" },
                    { new Guid("ea814626-4088-4cf7-bbe9-b24341bd754c"), "49916439966", new DateTime(1933, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fernando" },
                    { new Guid("fe587ad5-f16b-4a15-bdcc-5943ce4d44d0"), "99642111551", new DateTime(2009, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pedro" },
                    { new Guid("f089611f-6755-4c6c-b9e8-bbc50fd3dbe2"), "71611693560", new DateTime(1960, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ian" },
                    { new Guid("c5fc2e4d-a9a0-4aeb-a0ba-e45831bd422a"), "99969304160", new DateTime(2006, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Felipe" },
                    { new Guid("7b41ab6c-ec9a-4a7f-938d-9f125d76f844"), "66476041703", new DateTime(1991, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beatriz" },
                    { new Guid("9ac2e2b6-6bb0-45fb-b22a-6eaa6c9a39ba"), "20290670241", new DateTime(2016, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Helena" },
                    { new Guid("97078218-fd60-47aa-8d58-8698e638d39d"), "82536604640", new DateTime(1979, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Matheus" },
                    { new Guid("a1807c83-07c6-4849-9a99-2561cdc5e2f9"), "12713503787", new DateTime(1927, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pedro" },
                    { new Guid("6cafdac9-8a8f-49d0-a0ab-da7a47da34b7"), "27483949767", new DateTime(1980, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laura" },
                    { new Guid("64f007d2-6aef-45b9-b5bf-55953955c018"), "83063777960", new DateTime(2018, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Arthur" },
                    { new Guid("99b91f6f-1817-4495-bc82-a9f6ff89140b"), "81885078579", new DateTime(1966, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sophie" },
                    { new Guid("a50bfb68-35c4-4be8-9a93-332b85226f1a"), "71252047169", new DateTime(1934, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cecília" },
                    { new Guid("80766add-930e-4e73-acb6-f0c4af16f5bf"), "33971278159", new DateTime(1955, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Larissa" },
                    { new Guid("4e2410e9-898f-4789-a486-038f455e5de6"), "92105027792", new DateTime(2008, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Caio" },
                    { new Guid("5763994e-d513-4445-b0de-d4f3961b8a65"), "81487293445", new DateTime(1996, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Benício" },
                    { new Guid("1d49b239-85ba-4ef8-a676-bc78809fd7fe"), "30447442023", new DateTime(1968, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Joaquim" },
                    { new Guid("122f69c5-c24b-4464-a935-1b0690230e17"), "86943615157", new DateTime(2002, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cecília" },
                    { new Guid("b9f824f6-50f8-4d2e-a663-75b74e81988b"), "69731803882", new DateTime(1923, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Heloise" },
                    { new Guid("045321b9-ea76-4bbc-a79d-f46e051f6351"), "90228376106", new DateTime(1927, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amanda" },
                    { new Guid("7836a3b6-22f3-44d9-9748-342abcfd401b"), "70213017156", new DateTime(2016, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Heloísa" },
                    { new Guid("17ce30c3-cefa-4886-9d9c-3a25b491b4cd"), "56743822124", new DateTime(2005, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daniel" },
                    { new Guid("09fbdc12-9179-444b-9216-afe876d7ff58"), "25871804730", new DateTime(1977, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Felipe" },
                    { new Guid("a35607f3-8956-465e-b2e9-1b1acecedb05"), "10569002613", new DateTime(2001, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Guilherme" },
                    { new Guid("381cd3c9-34a2-4f56-9c9a-998bcb919cdd"), "40430801319", new DateTime(1984, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Davi" },
                    { new Guid("ac2cd9ee-2ebb-42d4-b961-f1e2c50f3272"), "86389340842", new DateTime(1948, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carolina" },
                    { new Guid("578583e3-7875-46ab-91ea-30df6be60d63"), "19196256745", new DateTime(1984, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antonella" }
                });

            migrationBuilder.InsertData(
                table: "Pessoas",
                columns: new[] { "Id", "Cpf", "DataNascimento", "Nome" },
                values: new object[,]
                {
                    { new Guid("0cd138d4-31e1-4d66-ae6e-e3e7dcd75b72"), "46041087220", new DateTime(1995, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Malu" },
                    { new Guid("6ca9aa31-8ce2-49d8-8caa-a2ac2b4185ce"), "55414726957", new DateTime(1995, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vinícius" },
                    { new Guid("cfad0310-3e5e-477c-a993-f8e28f68dad3"), "57149739172", new DateTime(1990, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Benício" },
                    { new Guid("576b6cca-b563-4a78-8775-3ae98ff06b67"), "44040813839", new DateTime(1965, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pietro" },
                    { new Guid("188b7992-48eb-4d20-aa4f-90be0be9f674"), "57491251650", new DateTime(1937, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Danilo" },
                    { new Guid("834331a6-4742-436f-b665-0d43a5fe460a"), "60529120577", new DateTime(1952, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Milena" },
                    { new Guid("6a4b1fae-6e03-4211-bf13-d5fa1b632f40"), "84029426875", new DateTime(1993, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pietro" },
                    { new Guid("e2d89b9e-42bd-43cc-8a40-1b758c10e44d"), "68891915955", new DateTime(2012, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "André" },
                    { new Guid("64898525-8d6d-4379-8847-2f455dad164a"), "16336208400", new DateTime(1931, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Felipe" },
                    { new Guid("25de9f3b-fcf3-493d-b8bd-403ecaec34da"), "36362686608", new DateTime(1983, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gael" },
                    { new Guid("c522e2b1-cdac-4c39-a51b-f006c7cab3b1"), "64908291934", new DateTime(1991, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Davi" },
                    { new Guid("25c30132-48d6-4ba3-ba12-7820d4084cb2"), "30340145200", new DateTime(1997, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amanda" },
                    { new Guid("918705d3-c511-4a73-9158-8d9a9d0dd6f2"), "20792689968", new DateTime(1984, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Heitor" },
                    { new Guid("b7e68764-bd49-438d-90b9-11dec6bea908"), "68839984542", new DateTime(2012, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elisa" },
                    { new Guid("fdd6b6c6-c7ad-4ac8-8548-26cfd2006a64"), "31408900360", new DateTime(1984, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rodrigo" },
                    { new Guid("984b4c0d-9514-4f0f-acba-c83e3d50de77"), "54769343329", new DateTime(1931, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thiago" },
                    { new Guid("4808358d-cace-4c9f-af76-c2f08c1a6aec"), "60900206802", new DateTime(1997, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Emanuelly" },
                    { new Guid("333243f1-b6f2-449f-b198-a0554a6faa4a"), "73559629810", new DateTime(1922, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eloá" },
                    { new Guid("3e0019ec-41b3-4376-a529-8e1defb51cae"), "37760953771", new DateTime(1980, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Analu" },
                    { new Guid("0c16f010-5a1a-4459-ba0c-b709f524dd20"), "85536522035", new DateTime(1938, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Analu" },
                    { new Guid("ca087f84-6c5d-4554-865b-bde99835ef7e"), "52564830480", new DateTime(1999, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agatha" },
                    { new Guid("bcac5ea1-7ac7-40e4-86bf-6a7d830d5583"), "90671564935", new DateTime(1957, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eduarda" },
                    { new Guid("114341d4-9114-4f24-b913-b161e493dc85"), "78415285906", new DateTime(1937, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sophia" },
                    { new Guid("98a6ebd7-4364-4059-95f2-3eb9e6473ebe"), "28368431280", new DateTime(1966, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antônia" },
                    { new Guid("7b07000f-ce05-4be1-bfe4-c507cfad941c"), "30368961397", new DateTime(1981, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Malu" },
                    { new Guid("b9e2d903-2529-483f-8e64-0eeb9e0abb2e"), "16585444981", new DateTime(2020, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eloá" },
                    { new Guid("0f3ecea2-f6a7-4542-a35f-d810176c778b"), "42341902928", new DateTime(1947, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Arthur" },
                    { new Guid("7b32f0c8-d2ed-4199-b359-57e51fbffe83"), "26761868505", new DateTime(1980, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laura" },
                    { new Guid("0c312fbc-fad7-4e2a-a37e-d179640baeb1"), "95475573433", new DateTime(1920, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vinícius" },
                    { new Guid("c6504ce0-7b3c-466f-af10-77baa3cddbc3"), "84174064768", new DateTime(2011, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fernanda" },
                    { new Guid("310a33fa-0406-4531-8854-4d2d7ff03cfc"), "79816586916", new DateTime(1974, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Isis" },
                    { new Guid("feaf9ac6-4235-448c-826c-e964f0f327f1"), "36038737006", new DateTime(1976, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elisa" },
                    { new Guid("423e1ab9-da1f-490e-86ba-9e371b2b6ab5"), "17639851211", new DateTime(2000, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "André" },
                    { new Guid("0345087e-9a39-4742-9e69-8501f3762a1d"), "43580748475", new DateTime(1988, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Murilo" },
                    { new Guid("438ba9c0-dc50-4154-8bf7-b5508fd5a115"), "41525832077", new DateTime(1924, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Isabel" },
                    { new Guid("d238701c-ca6e-4151-9833-aa9dac770be1"), "51307437095", new DateTime(2008, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cauã" },
                    { new Guid("e4e4c086-5ce3-4309-8533-5e515acf5220"), "99937967430", new DateTime(1950, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Felipe" },
                    { new Guid("b167aa87-7c1d-47da-8d77-8ca2119b63e5"), "79741065574", new DateTime(1930, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Martin" },
                    { new Guid("c752d69d-b082-47be-a548-4485d9bfdfaa"), "78218089705", new DateTime(1997, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Henrique" },
                    { new Guid("6fd201ab-0c27-4e47-a249-63049aa456bb"), "70578137836", new DateTime(1958, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rafael" },
                    { new Guid("0fec9114-f7e2-4250-91d5-e068e0746c93"), "89214654484", new DateTime(2000, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Matheus" },
                    { new Guid("8a45d9a2-d907-4b87-9822-ce8523cd9fef"), "24495264982", new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gabriela" }
                });

            migrationBuilder.InsertData(
                table: "Pessoas",
                columns: new[] { "Id", "Cpf", "DataNascimento", "Nome" },
                values: new object[,]
                {
                    { new Guid("b41e57cf-ac0e-4d75-bee7-f587439b9493"), "39295867203", new DateTime(2016, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Emilly" },
                    { new Guid("826eacfc-a963-4908-9a40-72456012625b"), "50235302210", new DateTime(1938, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Manuela" },
                    { new Guid("ae06422b-07f0-454d-9136-dbd98c2c6171"), "90933648715", new DateTime(1994, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Valentina" },
                    { new Guid("96f70053-d4da-4584-a695-a89115d14dee"), "71749658658", new DateTime(2002, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Benício" },
                    { new Guid("898adeb1-5eed-4bb6-830c-1cca4bc0d898"), "91845117379", new DateTime(1939, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pietro" },
                    { new Guid("7a608767-131b-4f31-9ca5-d0db46625026"), "60283007303", new DateTime(2015, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fernanda" },
                    { new Guid("221cdf32-9e29-4416-9ed8-b0465866d272"), "17592182432", new DateTime(2000, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mirella" },
                    { new Guid("3d30365b-810a-40c7-811b-5df15159654e"), "97577883255", new DateTime(1953, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sophie" },
                    { new Guid("a31a251a-9fc0-47a6-b200-191d7a082390"), "14166291734", new DateTime(1985, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kaique" },
                    { new Guid("6f21fa16-07a5-4543-9bd1-876402f5b31f"), "30932917631", new DateTime(1995, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noah" },
                    { new Guid("348ba73c-be04-48e3-b3f9-50d3b373b719"), "74121619544", new DateTime(1972, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Augusto" },
                    { new Guid("847c44ea-42e3-453a-8a7d-4d398e3094ba"), "69585180553", new DateTime(2014, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Heitor" },
                    { new Guid("c4acf8f4-1d77-4738-83d7-2266daef1f2a"), "26800169986", new DateTime(1993, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oliver" },
                    { new Guid("66b995c0-5cc1-45c8-986a-de0c95ad0bc5"), "16917694100", new DateTime(1986, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Luiza" },
                    { new Guid("a2f7495a-86f4-47b1-b5d4-35d0f2914f76"), "59260024358", new DateTime(1925, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leonardo" },
                    { new Guid("67d339dd-d886-4417-a91c-ba23e7b7a81f"), "32460021186", new DateTime(1981, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amanda" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pessoas");
        }
    }
}
