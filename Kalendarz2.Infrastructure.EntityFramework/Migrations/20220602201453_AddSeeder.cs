using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kalendarz2.Infrastructure.EntityFramework
{
    public partial class AddSeeder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Holidays",
                columns: new[] { "Id", "Date", "Description", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Start off the year with an act of daredevilry. Celebrate Polar Plunge Day on January 1 by taking a dip in the cold, freezing waters of your local lake, river or pond.", "Polar Bear Plunge Day" },
                    { 2, new DateTime(2022, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Want to hit the buffet table one last time before you start your New Year’s resolution? Then Buffet Day on January 2 is the fun food holiday for you.", "Buffet Day" },
                    { 3, new DateTime(2022, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fruitcake Toss Day on January 3 is an annual holiday that celebrates fruitcakes - the gift that keeps on giving - by tossing them in an empty space.", "Fruitcake Toss Day" },
                    { 4, new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Here is some trivia for you - January 4 is Trivia Day.", "Trivia Day" },
                    { 5, new DateTime(2022, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "January 5 is Bird Day, a day to think about birds in captivity and to take action to ensure that birds are not exploited and are treated humanely.", "Bird Day" },
                    { 6, new DateTime(2022, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "January 6 is Bean Day. If your question after hearing this is, why? Well, because beans are healthy – they are rich in proteins and fiber and they taste good.", "Bean Day" },
                    { 7, new DateTime(2022, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "January 7 is Old Rock Day. The unofficial holiday encourages people to acknowledge, celebrate, and learn more about old rocks and fossils.", "Old Rock Day" },
                    { 8, new DateTime(2022, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "January 8 is Earth’s Rotation Day. The day commemorates when French Physicist, Leon Foucault, demonstrated the Earth rotates on its axis in 1851.", "Earth's Rotation Day" },
                    { 9, new DateTime(2022, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "January 9 is Static Electricity Day a day to honor this unexpected, mostly unpleasant, and sometimes hair rising phenomenon.", "Static Electricity Day" },
                    { 10, new DateTime(2022, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Forgot to add being thrifty and eco-friendly to your New Year’s resolution list? Now is your chance to rectify that because January 10 is Cut your Energy Cost Day.", "Cut Your Energy Costs Day" },
                    { 11, new DateTime(2022, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "January 11 is celebrated annually as Learn Your Name in Morse Code Day.", "Learn Your Name in Morse Code Day" },
                    { 12, new DateTime(2022, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Celebrate marzipan, the sweet, almond-based multi-purpose confectionary on January 12, Marzipan Day.", "Marzipan Day" },
                    { 13, new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "January 13 is Make your Dreams Come True Day. If you have been procrastinating on fulfilling your dream, this is your chance to get things right.", "Make Your Dreams Come True Day" },
                    { 14, new DateTime(2022, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "January 14 get started early on this year's spring cleaning and organizing on Organize Your Home Day.", "Organize Your Home Day" },
                    { 15, new DateTime(2022, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "January 15 is Strawberry Ice Cream Day. It is an unofficial holiday that celebrates ice cream made with strawberries or added strawberry flavors. ", "Strawberry Ice Cream Day" },
                    { 16, new DateTime(2022, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "January 16 is Nothing Day, a day to celebrate, well, nothing.", "Nothing Day" },
                    { 17, new DateTime(2022, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "January 17 is celebrated worldwide as Benjamin Franklin Day.", "Benjamin Franklin Day" },
                    { 18, new DateTime(2022, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "January 18 is Thesaurus Day. Impress your family and friends with big, complicated, and fancy sounding words to celebrate this lexicographic holiday.", "Thesaurus Day" },
                    { 19, new DateTime(2022, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "On January 19 crack open a can of sardines because it's Tin Can Day. ", "Tin Can Day" },
                    { 20, new DateTime(2022, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "January 20 is Penguin Awareness Day. The day helps raise awareness about the flightless birds whose numbers are dwindling by the day. ", "Penguin Awareness Day" },
                    { 21, new DateTime(2022, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "January 21 is Squirrel Appreciation Day, a day to acknowledge the role that squirrels play in nature and the environment.", "Squirrel Appreciation Day" },
                    { 22, new DateTime(2022, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Turn the heat up in your kitchen or on your dining table by adding hot sauce to everything you eat on January 22, because it is Hot Sauce Day.", "Hot Sauce Day" },
                    { 23, new DateTime(2022, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "January 23 is Handwriting Day, a day to get your hands on a pen or pencil and paper and practice and revive the elegant art of handwriting.", "Handwriting Day" },
                    { 24, new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Compliments - they are free, easy to give and receive, they make people happy and build trust. So give someone a compliment someone on January 24, Compliment Day. ", "Compliment Day" },
                    { 25, new DateTime(2022, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ever wanted to be a rebel? Now is your chance. Don’t celebrate Opposite Day on January 25 by doing everything the wrong way.", "Opposite Day" },
                    { 26, new DateTime(2022, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "January 26 is Spouse's Day, a day to celebrate your spouse, better half, or significant other.", "Spouse's Day" },
                    { 27, new DateTime(2022, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chocolate Cake Day on January 27 celebrates everyone’s and their grandma's favorite cake.", "Chocolate Cake Day" },
                    { 28, new DateTime(2022, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "January 28 is Data Privacy Day. It is observed every year in the United States, United Kingdom, and many other European countries. ", "Data Privacy Day" },
                    { 29, new DateTime(2022, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "What is 24 hours long, all about solving problems, and is one of the best unofficial holidays of the year? Puzzle Day, of course.", "Puzzle Day" },
                    { 30, new DateTime(2022, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "On January 30 wake up and head straight to your favorite bakery to get a croissant for your breakfast, because it is Croissant Day.", "Croissant Day" },
                    { 31, new DateTime(2022, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bored with doing the same thing in and out? On January 31, take a break from the rut by doing everything backwards, because it is Backwards Day.", "Backwards Day" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 31);
        }
    }
}
