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
                    { 15, new DateTime(2022, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "January 15 is Strawberry Ice Cream Day. It is an unofficial holiday that celebrates ice cream made with strawberries or added strawberry flavors.", "Strawberry Ice Cream Day" },
                    { 16, new DateTime(2022, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "January 16 is Nothing Day, a day to celebrate, well, nothing.", "Nothing Day" },
                    { 17, new DateTime(2022, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "January 17 is celebrated worldwide as Benjamin Franklin Day.", "Benjamin Franklin Day" },
                    { 18, new DateTime(2022, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "January 18 is Thesaurus Day. Impress your family and friends with big, complicated, and fancy sounding words to celebrate this lexicographic holiday.", "Thesaurus Day" },
                    { 19, new DateTime(2022, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "On January 19 crack open a can of sardines because it's Tin Can Day.", "Tin Can Day" },
                    { 20, new DateTime(2022, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "January 20 is Penguin Awareness Day. The day helps raise awareness about the flightless birds whose numbers are dwindling by the day.", "Penguin Awareness Day" },
                    { 21, new DateTime(2022, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "January 21 is Squirrel Appreciation Day, a day to acknowledge the role that squirrels play in nature and the environment.", "Squirrel Appreciation Day" },
                    { 22, new DateTime(2022, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Turn the heat up in your kitchen or on your dining table by adding hot sauce to everything you eat on January 22, because it is Hot Sauce Day.", "Hot Sauce Day" },
                    { 23, new DateTime(2022, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "January 23 is Handwriting Day, a day to get your hands on a pen or pencil and paper and practice and revive the elegant art of handwriting.", "Handwriting Day" },
                    { 24, new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Compliments - they are free, easy to give and receive, they make people happy and build trust. So give someone a compliment someone on January 24, Compliment Day.", "Compliment Day" },
                    { 25, new DateTime(2022, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ever wanted to be a rebel? Now is your chance. Don’t celebrate Opposite Day on January 25 by doing everything the wrong way.", "Opposite Day" },
                    { 26, new DateTime(2022, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "January 26 is Spouse's Day, a day to celebrate your spouse, better half, or significant other.", "Spouse's Day" },
                    { 27, new DateTime(2022, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chocolate Cake Day on January 27 celebrates everyone’s and their grandma's favorite cake.", "Chocolate Cake Day" },
                    { 28, new DateTime(2022, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "January 28 is Data Privacy Day. It is observed every year in the United States, United Kingdom, and many other European countries.", "Data Privacy Day" },
                    { 29, new DateTime(2022, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "What is 24 hours long, all about solving problems, and is one of the best unofficial holidays of the year? Puzzle Day, of course.", "Puzzle Day" },
                    { 30, new DateTime(2022, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "On January 30 wake up and head straight to your favorite bakery to get a croissant for your breakfast, because it is Croissant Day.", "Croissant Day" },
                    { 31, new DateTime(2022, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bored with doing the same thing in and out? On January 31, take a break from the rut by doing everything backwards, because it is Backwards Day.", "Backwards Day" },
                    { 32, new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "February 2 is celebrated as the Day of the Crêpe in France.", "Day of the Crêpe" },
                    { 33, new DateTime(2022, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Celebrated annually on February 3, the holiday celebrates this cake made with carrots.", "Carrot Cake Day" },
                    { 34, new DateTime(2022, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Do you dream of working from home in your most comfortable attire? Then Work Naked Day on the first Friday of February is the holiday for you.", "Work Naked Day" },
                    { 35, new DateTime(2022, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Make ice cream the breakfast of champions on the first Saturday of February, also known as Eat Ice Cream for Breakfast Day.", "Eat Ice Cream for Breakfast Day" },
                    { 36, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "February 6 is Lame Duck Day. The unofficial holiday honors anyone who is on their way out of their jobs or their elected office.", "Lame Duck Day" },
                    { 37, new DateTime(2022, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "e-Day celebrates the mathematical constant e, which has a value of 2.7182818. It is celebrated on February 7 in countries that follow the month/day (m/d) date format. This is because the first two digits of the date - 2/7 - correspond to the first two digits of the constant.", "e-Day" },
                    { 38, new DateTime(2022, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "February 8 is Laugh and Get Rich Day. A day for enriching your life with happiness.", "Laugh and Get Rich Day" },
                    { 39, new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "February 9 is Toothache Day. It is admittedly not a fun holiday, especially if you are suffering from, or have bad memories of, a toothache.", "Toothache Day" },
                    { 40, new DateTime(2022, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "February 10 is Umbrella Day, so honor the humble umbrella for shielding you from the elements all year long.", "Umbrella Day" },
                    { 41, new DateTime(2022, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Make a Friend Day on February 11 is an unofficial holiday that encourages people to stop and take stock of their friend list and make new friends.", "Make a Friend Day" },
                    { 42, new DateTime(2022, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Darwin Day is held annually on or around February 12, the birthday of Charles Darwin.", "Darwin Day" }
                });

            migrationBuilder.InsertData(
                table: "Holidays",
                columns: new[] { "Id", "Date", "Description", "Name" },
                values: new object[,]
                {
                    { 43, new DateTime(2022, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "On February 13 or World Radio Day, take the time to honor the role of radio in the world of communication and its contribution in our daily lives.", "World Radio Day" },
                    { 44, new DateTime(2022, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Have you been putting off cleaning out those old files on your desktop? Well, today is the day you should do it, because it is Clean Out Your Computer Day.", "Clean Out Your Computer Day" },
                    { 45, new DateTime(2022, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "February 15 is Gumdrop Day. Celebrate this day by treating yourself to a bowlful of the colorful, chewy, and delicious candy.", "Gumdrop Day" },
                    { 46, new DateTime(2022, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "On February 16 or Do a Grouch a Favor Day, make someone’s day by doing something nice for them and getting them out of their funk.", "Do a Grouch a Favor Day" },
                    { 47, new DateTime(2022, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "February 17, also known as Random Act of Kindness Day, is a day to practice kindness and pay it forward.", "Random Act of Kindness Day" },
                    { 48, new DateTime(2022, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "February 18 is Battery Day. It is a day to acknowledge the device that makes it possible for the smallest household items to the largest heavy-duty equipment to work smoothly.", "Battery Day" },
                    { 49, new DateTime(2022, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chocolate Mint Day on February 19 is devoted to the classic combination of chocolate and mint", "Chocolate Mint Day" },
                    { 50, new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "You may have been praised for your multitasking skills, but have you ever tried single tasking i.e. doing only one thing at a time? Try it on February 22, Single Tasking Day.", "Single Tasking Day" },
                    { 51, new DateTime(2022, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "February 23 is Dog Biscuit Appreciation Day. Show your appreciation for your furry canine friends by spoiling them with their favorite dog biscuits.", "International Dog Biscuit Appreciation Day" },
                    { 52, new DateTime(2022, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Honor the tortilla chip – the carrier of delicious dips – on February 24, Tortilla Chip Day.", "Tortilla Chip Day" },
                    { 53, new DateTime(2022, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Archeologists believe that pistachios were used as food as early as 6000 BCE. Celebrate this ancient and healthy nut on February 26, Pistachio Day.", "Pistachio Day" },
                    { 54, new DateTime(2022, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "International Polar Bear Day on February 27 is an unofficial holiday created by Polar Bear International (PBI). It raises awareness of the impact of global warming on Polar Bears.", "International Polar Bear Day" },
                    { 55, new DateTime(2022, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Catch a few winks or take a long nap in public to celebrate Public Sleeping Day on February 28.", "Public Sleeping Day" },
                    { 56, new DateTime(2022, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "March 1 is celebrated as World Compliment Day, a day that aims to address the “basic human need for recognition and appreciation.”", "World Compliment Day" },
                    { 57, new DateTime(2022, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "March 2 is Old Stuff Day. Take some time on this made-up holiday to appreciate the beauty of all things old and vintage.", "Old Stuff Day" },
                    { 58, new DateTime(2022, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "March 3 is I Want You to be Happy Day, a day to set aside selfish thoughts and to make someone feel special and happy.", "I Want You to be Happy Day" },
                    { 59, new DateTime(2022, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "March Forth and Do Something Day is a made-up holiday celebrated each year on March 4.", "March Forth and Do Something Day" },
                    { 60, new DateTime(2022, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "On March 5, or Learn What Your Name Means Day, do some research to find out the out the origin and history of your name - first and last. Maybe you'll find a great tale behind your name!", "Learn What Your Name Means Day" },
                    { 61, new DateTime(2022, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Celebrate dentists all over the world and honor their role in keeping us healthy and smiling on March 6 or Dentist’s Day.", "Dentist’s Day" },
                    { 62, new DateTime(2022, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alexander Graham Bell Day is celebrated every year on March 7.", "Alexander Graham Bell Day" },
                    { 63, new DateTime(2022, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "March 8 is Proofreading Day. The day promotes error-free communication and encourages everyone to spend some time updating and expanding his or her proofreading skills.", "Proofreading Day" },
                    { 64, new DateTime(2022, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "March 10 is Mario Day, a day to celebrate the main character of the popular Nintendo video game franchise, Super Mario.", "Mario Day" },
                    { 65, new DateTime(2022, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "March 11 is Oatmeal Nut Waffle Day. It is a day to treat yourself to not just waffles, but the healthier version of the popular breakfast food.", "Oatmeal Nut Waffle Day" },
                    { 66, new DateTime(2022, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "March 12 is National Alfred Hitchcock Day, a day to celebrate the life, times, and work of master filmmaker Alfred Hitchcock.", "Alfred Hitchcock Day" },
                    { 67, new DateTime(2022, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Celebrate all things shiny, blingy, and sparkly on March 13, or Jewel Day.", "Jewel Day" },
                    { 68, new DateTime(2022, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Napping Day is an unofficial holiday that falls on the Monday after DST begins in the United States.", "Napping Day" },
                    { 69, new DateTime(2022, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "March 15 is Everything You Think is Wrong Day.", "Everything You Think is Wrong Day" },
                    { 70, new DateTime(2022, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Because every bad day is followed by a good day, March 16 is Everything You Do is Right Day.", "Every Thing You Do is Right Day" },
                    { 71, new DateTime(2022, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Honor all the incredible kids in your life on Absolutely Incredible Kids Day, a holiday celebrated every year on the third Thursday in March.", "Absolutely Incredible Kid Day" },
                    { 72, new DateTime(2022, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "On March 18, or Awkward Moments Day, celebrate (or forget) those awkward and embarrassing moments in our lives that may have made us want to hide.", "Awkward Moments Day" },
                    { 73, new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Let’s Laugh Day is celebrated every year on March 19. It is an unofficial holiday that encourages people to laugh and enjoy the benefits of laughter.", "Let's Laugh Day" },
                    { 74, new DateTime(2022, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "World Storytelling Day is celebrated globally every year on the March Equinox.", "World Storytelling Day" },
                    { 75, new DateTime(2022, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "21 March 7 o'clock is John Paul II Day,", "John Paul II Day" },
                    { 76, new DateTime(2022, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "March 22 is International Goof Off Day. The unofficial holiday encourages people to take the day to relax and do unproductive and useless things.", "International Goof Off Day" },
                    { 77, new DateTime(2022, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "March 23 is Puppy Day, a day reserved for recognizing the joy and love that puppies bring to our lives.", "Puppy Day" },
                    { 78, new DateTime(2022, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Celebrate the almost healthy, chewy, and chocolatey snack on March 24 or Chocolate Covered Raisin Day.", "Chocolate Covered Raisins Day" },
                    { 79, new DateTime(2022, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Waffles have, as far as we know, three holidays in the year dedicated to them – On March 11, March 25, and August 24.", "Waffle Day" },
                    { 80, new DateTime(2022, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "March 26 is Make Up Your Own Holiday Day. It is a day to think up of a thing, person, animal, phrase, or food and create a holiday to celebrate it.", "Make Up Your Own Holiday Day" },
                    { 81, new DateTime(2022, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "March 27 is Spanish Paella Day. Celebrate this unofficial holiday by cooking this rice and saffron dish.", "Spanish Paella Day" },
                    { 82, new DateTime(2022, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "March 28 is Something on a Stick Day. It is a day to have fun with your food and to celebrate delicious and easy-to-eat dishes on a stick.", "Something on a Stick Day" },
                    { 83, new DateTime(2022, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Celebrate the magic on Smoke and Mirrors Day. Also sometimes known as Festival of Smoke and Mirrors Day, this unofficial holiday is celebrated annually on March 29.", "Smoke and Mirrors Day" },
                    { 84, new DateTime(2022, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Commune with nature and enjoy the bounties it has to offer on Take a Walk in the Park Day.", "Take a Walk in the Park Day" }
                });

            migrationBuilder.InsertData(
                table: "Holidays",
                columns: new[] { "Id", "Date", "Description", "Name" },
                values: new object[,]
                {
                    { 85, new DateTime(2022, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bunsen Burner Day on March 31 celebrates the inventor of the Bunsen Burner, German chemist Robert Wilhelm Eberhard von Bunsen.", "Bunsen Burner Day" },
                    { 86, new DateTime(2022, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Have double the fun on April 1, because it is not only April Fool’s Day but it is also Fun at Work Day.", "Fun at Work Day" },
                    { 87, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "April 3 is World Party Day. Also known as P Day, it is an annually celebrated unofficial holiday that aims to achieve social change and harmony by encouraging people to celebrate life by partying.", "World Party Day" },
                    { 88, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nope, we aren’t lying, we promise! April 4 is Tell a Lie Day!", "Tell a Lie Day" },
                    { 89, new DateTime(2022, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Read a Road Map Day is on April 5. It encourages people to go on an adventure the old-fashioned way – with a paper map!", "Read a Road Map Day" },
                    { 90, new DateTime(2022, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "April 6 is Sorry Charlie Day, a day to recognize that everyone gets rejected sometimes in his or her life. The name of the holiday comes from the phrase Sorry Charlie, popular in the United States.", "Sorry Charlie Day" },
                    { 91, new DateTime(2022, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Honor your sibling on Siblings Day, an unofficial holiday celebrated annually on April 10.", "Siblings Day" },
                    { 92, new DateTime(2022, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "March 17 is Submarine Day. The unofficial holiday celebrates the technological advances that make the use of the watercraft possible.", "Submarine Day" },
                    { 93, new DateTime(2022, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Honor the lawyer in your life on Be Kind to Lawyers Day, celebrated annually on the second Tuesday of April.", "Be Kind to Lawyers Day" },
                    { 94, new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "April 13 is Scrabble Day, a day to celebrate the popular board game created in 1938 by Alfred Mosher Butts, an American architect.", "Scrabble Day" },
                    { 95, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "On April 14, stop, smell the roses, and laugh a little (or a lot), because it is International Moment of Laughter Day.", "International Moment of Laughter Day" },
                    { 96, new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Celebrate the hearty breakfast (or any other meal, in our very humble opinion) that is Eggs Benedict on April 16, Eggs Benedict Day.", "Eggs Benedict Day" },
                    { 97, new DateTime(2022, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "April 17 is Haiku Poetry Day. The unofficial holiday honors the short poetry form that originated in Japan.", "Haiku Poetry Day" },
                    { 98, new DateTime(2022, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "April 18 is celebrated annually as Columnists Day to commemorate the life and work of columnist Ernest Taylor Pyle.", "Columnist Day" },
                    { 99, new DateTime(2022, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "If you have ever been told that you look familiar or look like someone else, then Look Alike Day on April 20 is the holiday you should be celebrating.", "Look Alike Day" },
                    { 100, new DateTime(2022, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "April 22 is Jelly Bean Day. It is an unofficial holiday that honors the sugary bean-shaped candies that are hard on the outside and gel-like on the inside.", "Jelly Bean Day" },
                    { 101, new DateTime(2022, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Take A Chance Day on April 23 is the perfect excuse for you to play with some odds and venture out into unchartered territories.", "Take a Chance Day" },
                    { 102, new DateTime(2022, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "The last Sunday in April is celebrated worldwide as World Pinhole Photography Day.", "World Pinhole Photography Day" },
                    { 103, new DateTime(2022, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Observed every year on April 25 since 2003, DNA Day celebrates and recognizes the importance of genetics and the scientific advances made in the field.", "DNA Day" },
                    { 104, new DateTime(2022, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Celebrate the doughy, salty snack called Pretzel on April 26, Pretzel Day.", "Pretzel Day" },
                    { 105, new DateTime(2022, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Take Our Daughters and Sons to Work Day is celebrated every year on the fourth Thursday in April.", "Take Our Daughters and Sons to Work Day" },
                    { 106, new DateTime(2022, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "On April 29, celebrate the zipper it because it is Zipper Day.", "Zipper Day" },
                    { 107, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "April begins with a day that celebrates falsehoods – April Fool’s Day. End it with a day that celebrates and acknowledges the importance of honesty – Honesty Day.", "Honesty Day" },
                    { 108, new DateTime(2022, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "May 1 is Batman Day. The unofficial holiday celebrates and honors one of the world's most well-known comic book superhero. While the origins of this holiday are unknown, the general consensus is that the day commemorates the date in 1939 when the crime fighter made his debut in the Detective Comics", "Batman Day" },
                    { 109, new DateTime(2022, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "May 4 is celebrated as Star Wars Day by fans of the popular sci-fi film series, Star Wars. It is one of the two days in a year that recognizes the place of the Star Wars franchise in popular culture.", "Star Wars Day" },
                    { 110, new DateTime(2022, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "No Pants Day is an unofficial holiday that occurs on the first Friday of May. Celebrated mostly in the United States, it calls for participants to spend their day without wearing pants in public. Participants are encouraged to act as if not wearing pants is a normal thing to do.", "No Pants Day" },
                    { 111, new DateTime(2022, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Astronomy Day is celebrated twice a year, once in the spring and once in the fall.", "Astronomy Day" },
                    { 112, new DateTime(2022, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "May 9 is celebrated as Europe Day in the European Union (E.U.) and around the world.", "Europe Day" },
                    { 113, new DateTime(2022, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "May 10 is Clean Your Room Day - an unofficial holiday that is bound to be any parent's or roommate's favorite holiday and perhaps every child's, teenager's and lazy person's nightmare.", "Clean Up Your Room Day" },
                    { 114, new DateTime(2022, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Wednesday between May 6 and May 12 of each year is National School Nurse Day, a day to celebrate and thank all school nurses that take care of children when they are at school.", "National School Nurse Day" },
                    { 115, new DateTime(2022, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "May 12 is Limerick Day. It is an unofficial holiday that encourages people to read and write limericks, a genre of humorous poetry that first originated in England in the 18th century.", "Limerick Day" },
                    { 116, new DateTime(2022, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "May 13 is Frog Jumping Day, a fun day to jump like a frog.", "Frog Jumping Day" },
                    { 117, new DateTime(2022, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "On May 14, is Dance Like a Chicken Day. Also known as Chicken Dance Day, the goofy holiday celebrates the silly dance that is accompanied by the Chicken Song or the Chicken Dance Song.", "Dance Like a Chicken Day" },
                    { 118, new DateTime(2022, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "May 15 is Chocolate Chip Day, a day to celebrate the tiny morsels of chocolate that make any dessert even better.", "Chocolate Chip Day" },
                    { 119, new DateTime(2022, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pack Rat Day is celebrated every year on May 17. The unofficial holiday encourages people to do some late spring-cleaning and to make space for newer, more useful things in their lives.", "Pack Rat Day" },
                    { 120, new DateTime(2022, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "May 18 is No Dirty Dishes Day, a day you could celebrate by either not washing any dirty dishes or by washing all the dishes you can!", "No Dirty Dishes Day" },
                    { 121, new DateTime(2022, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "On May 19, step out of your offices and homes and soak in the Sun's rays because it is May Ray Day. While the origins of the day are unknown, the day encourages people to enjoy some time under the Sun.", "May Ray Day" },
                    { 122, new DateTime(2022, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mark our words, the third Friday of May will soon become your favorite holiday of the year. Why, you ask? Because it is Pizza Party Day!", "Pizza Party Day" },
                    { 123, new DateTime(2022, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Talk like Yoda Day it is on May 21. The day honors the popular Star Wars character whose grammar is any language teacher’s worst nightmare.", "Talk Like Yoda Day" },
                    { 124, new DateTime(2022, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fancy yourself a musician? Then, on May 22 take the first step towards fulfilling your dreams and go and buy yourself a musical instrument because it is Buy a Musical Instrument Day.", "Buy a Musical Instrument Day" },
                    { 125, new DateTime(2022, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "May 24 is Scavenger Hunt Day, an annual celebration of the popular party game called scavenger hunt. The unofficial holiday encourages people to get together with friends and family and participate in a scavenger hunt.", "Scavenger Hunt Day" },
                    { 126, new DateTime(2022, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Open up your vocal chords and sing out loud from your heart on Sing Out Day. Celebrated every year on May 25 the unofficial holiday encourages people to sing their hearts out. Loudly.", "Sing Out Day" }
                });

            migrationBuilder.InsertData(
                table: "Holidays",
                columns: new[] { "Id", "Date", "Description", "Name" },
                values: new object[,]
                {
                    { 127, new DateTime(2022, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Put on your dancing shoes and do the Lindy Hop, because May 26 is World Lindy Hop Day.", "World Lindy Hop Day" },
                    { 128, new DateTime(2022, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Get ready for the summer (if you live in the Northern Hemisphere) by learning more about sunscreen and its advantages on May 27, Sunscreen Day.", "Sun Screen Day" },
                    { 129, new DateTime(2022, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Celebrate the humble, but delicious hamburger on May 28, Hamburger Day.", "Hamburger Day" },
                    { 130, new DateTime(2022, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "On May 29 put a pillow on your fridge to bring good luck and wealth to your home because it is Put a Pillow on Your Fridge Day.", "Put a Pillow on Your Fridge Day" },
                    { 131, new DateTime(2022, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "May 30 is My Bucket’s Got A Hole in It Day, a day to carry around a bucket with a hole with you.", "My Bucket's Got a Hole Day" },
                    { 132, new DateTime(2022, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "May 31 is Macaroon day, a day to celebrate the unleavened cakes or cookies made of egg whites, sugar, and almond paste or coconut.", "Macaroon Day" },
                    { 133, new DateTime(2022, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "On June 1, be kind to everyone you meet and say something nice to them because it is Say Something Nice Day. The day aims to encourage people to spread cheer and goodwill by opening up channels of communication and by focusing on the good in everyone.", "Say Something Nice Day" },
                    { 134, new DateTime(2022, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "While we all love our jobs (sure, we do), but nothing is more relaxing and fun than leaving work just a bit earlier than one normally does. So on June 2, pack up your things and get out of the office earlier than usual because it is Leave The Office Earlier Day or Leave The Office Early Day.", "Leave the Office Early Day" },
                    { 135, new DateTime(2022, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "June 3 is Repeat Day! June 3 is Repeat Day! June 3 is Repeat Day!", "Repeat Day" },
                    { 136, new DateTime(2022, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "June 4 is Hug Your Cat Day. On this unofficial holiday, go give your feline friend a big hug. You never know, the hug might just be the thing to stop them from plotting against you!", "Hug Your Cat Day" },
                    { 137, new DateTime(2022, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Get the popcorn and soda, pop, or water and drive over to your closest drive-in theater to watch a movie on June 6, because it is Drive-in Movie Day!", "Drive-In Movie Day" },
                    { 138, new DateTime(2022, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rewind to the past and celebrate the humble Video Cassette Recorder (VCR) on June 7, VCR Day. This unofficial holiday of unknown origins encourages people to learn more about the technology that completely changed the way people watched television and recorded memories.", "VCR Day" },
                    { 139, new DateTime(2022, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "June 8 is Best Friends Day, a day to celebrate your best friend and let them know how important they are to you.", "Best Friends Day" },
                    { 140, new DateTime(2022, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Celebrate everyone’s favorite cartoon character, Donald Duck on June 9, Donald Duck Day.", "Donald Duck Day" },
                    { 141, new DateTime(2022, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "June 10 is Iced Tea Day. Say hello to the summer and celebrate this delicious and refreshing holiday by treating yourself to a big glass of iced tea.", "Iced Tea Day" },
                    { 142, new DateTime(2022, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Summer is finally here, and what better way to celebrate it than with some delicious corn on the cob? Celebrate this popular summer side dish on Corn on the Cob Day, celebrated annually on June 11.", "Corn on the Cob Day" },
                    { 143, new DateTime(2022, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "June 12 is Red Rose Day. It is an annual celebration of the universal symbol of love and romance - the humble, but beautiful red rose.", "Red Rose Day" },
                    { 144, new DateTime(2022, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "They say a stitch in time saves nine. So, on June 13, Sewing Machine Day, dust off your sewing machine and sew away!", "Sewing Machine Day" },
                    { 145, new DateTime(2022, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "June 14 is Bourbon Day. So, set aside some time in the day to enjoy a glass of the uniquely American distilled liquor.", "Bourbon Day" },
                    { 146, new DateTime(2022, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "June 15 is Nature Photography Day. The North American Nature Photography Association (NANPA) created the day in 2006 as a way to encourage people to learn and enjoy capturing the beauty of nature through their cameras.", "Nature Photography Day" },
                    { 147, new DateTime(2022, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Celebrated annually on June 16, Bloomsday celebrates the life and times of Irish author James Joyce.", "Bloomsday" },
                    { 148, new DateTime(2022, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Whether you love your veggies or can’t stand them, you should celebrate Eat Your Vegetables Day on June 17. Why, you ask? Because the doctor says so, and because vegetables are delicious!", "Eat Your Vegetables Day" },
                    { 149, new DateTime(2022, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "World Juggling Day is held annually on a Saturday closest to June 17 to commemorate the anniversary of the foundation of the International Jugglers Association (IJA) in 1975.", "World Juggling Day" },
                    { 150, new DateTime(2022, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "June 19 is Sauntering Day, an annual holiday that reminds people to pause, take a stock of their busy schedules, and slow down for a bit. And because the day has the word sauntering in it, it also encourages everyone to take a leisurely walk.", "Sauntering Day" },
                    { 151, new DateTime(2022, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "On June 21, wear your flip-flops, put on your sunglasses, and step outdoors to enjoy some Sun, because it is Daylight Appreciation Day. The holiday was created by Solatube International as a way to raise awareness about the advantages of daylighting.", "Daylight Appreciation Day" },
                    { 152, new DateTime(2022, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Celebrate the delicious deep fried snack on June 22, Onion Ring Day.", "Onion Ring Day" },
                    { 153, new DateTime(2022, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "June 23, the anniversary of the granting of a patent to American inventor Christopher Latham Sholes in 1868 is celebrated around the world as Typewriter Day. So, take out your old typewriter from the attic, dust it and get started on your magnum opus!", "Typewriter Day" },
                    { 154, new DateTime(2022, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Studies have shown that bringing pets to work can increase productivity. So, on a Friday in June, take your dog to work to celebrate Take Your Dog to Work Day.", "Take Your Dog to Work Day" },
                    { 155, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Please Take my Children to Work Day first began as a tongue-in-cheek holiday for overworked and tired stay-at-home mothers to take a day off from their routines. The holiday is celebrated annually on June 25.", "Please Take my Children to Work Day" },
                    { 156, new DateTime(2022, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "June 26 is Chocolate Pudding Day. This unofficial holiday celebrates everyone's favorite lunch dessert snack - the chocolate pudding.", "Chocolate Pudding Day" },
                    { 157, new DateTime(2022, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Celebrate human resilience and achievement on Helen Keller Day. Celebrated annually on June 27, the day commemorates the life and achievements of Helen Keller, American activist, author, and suffragist.", "Helen Keller Day" },
                    { 158, new DateTime(2022, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tau Day, an anti-Pi Day holiday, is an unofficial observance held every year since 2010 on June 28, or 06/28 as written in the American date format.", "Tau Day" },
                    { 159, new DateTime(2022, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "June 29 is Camera Day, a day to celebrate the gadget that lets you record all your memories.", "Camera Day" },
                    { 160, new DateTime(2022, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "June 30 is Meteor Watch Day, a day to look up at the skies and behold the wonder of nature's celestial fireworks, meteors.", "Meteor Watch Day" },
                    { 161, new DateTime(2022, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Not only does July 1 mark the middle of the year in the Gregorian Calendar, it is also International Joke Day. The unofficial holiday encourages participants to share their funniest and sidesplitting jokes with the world.", "International Joke Day" },
                    { 162, new DateTime(2022, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "July 2 is I Forgot Day. If you are you a forgetful person who frequently forgets anniversaries, birthdays, special occasions, or even to bring the milk from the store on your way back home, then this is the unofficial holiday you should be celebrating.", "I Forgot Day" },
                    { 163, new DateTime(2022, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "July 3 is Compliment Your Mirror Day, a day to encourage self-acceptance and to acknowledge that you are beautiful, smart, and strong.", "Compliment Your Mirror Day" },
                    { 164, new DateTime(2022, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "July 4 is Sidewalk Egg Frying Day, an annual celebration of summer.", "Sidewalk Egg Frying Day" },
                    { 165, new DateTime(2022, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "July 5 is Workaholics Day, a day dedicated to people who spend all their time working and tend to ignore other pursuits in life.", "Workaholics Day" },
                    { 166, new DateTime(2022, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "On July 6, pucker up and lock lips with your sweetie because it is World Kissing Day.", "World Kissing Day" },
                    { 167, new DateTime(2022, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "July 7 is Tell the Truth Day, a day dedicated to honesty and the rejection of manipulation and lying.", "Tell the Truth Day" },
                    { 168, new DateTime(2022, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "On July 8 celebrate video games on Video Games Day. It is a day to acknowledge the art and science behind video games and to appreciate the skills required to play them.", "Video Games Day" }
                });

            migrationBuilder.InsertData(
                table: "Holidays",
                columns: new[] { "Id", "Date", "Description", "Name" },
                values: new object[,]
                {
                    { 169, new DateTime(2022, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "On July 9, whip up a batch of warm, delicious, and sugary sugar cookies because it is Sugar Cookie Day.", "Sugar Cookie Day" },
                    { 170, new DateTime(2022, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "If you have kids in your life, take them out with their teddy bears for a picnic on July 10, Teddy Bears’ Picnic Day.", "Teddy Bears' Picnic Day" },
                    { 171, new DateTime(2022, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Make someone smile on Cheer up the Lonely Day. Annually celebrated on July 11, the unofficial holiday aims to encourage people to give some of their time to make people who are lonely smile.", "Cheer Up the Lonely Day" },
                    { 172, new DateTime(2022, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Simplicity Day is celebrated every year on July 12. The unofficial holiday commemorates the life, times and work of American philosopher and proponent of simple living, Henry David Thoreau.", "Simplicity Day" },
                    { 173, new DateTime(2022, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "On July 13 embrace your geekness and use it as your secret power because it is Embrace Your Geekness Day.", "Embrace Your Geekness Day" },
                    { 174, new DateTime(2022, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "July 14 is Pandemonium Day, an annual celebration of chaos and disorder. Pandemonium Day is a reminder of the chaos and uncertainty that marks most of our lives.", "Pandemonium Day" },
                    { 175, new DateTime(2022, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Held annually on July 15, Gummi Worm Day celebrates and honors these chewy and yummy creepy crawly sweet treats.", "Gummi Worm Day" },
                    { 176, new DateTime(2022, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "July 16 is Corn Fritters Day. So, take out your best cooking pan, mix a batch of flour, sweet corn, eggs, and milk and whip up a batch of delicious and comforting corn fritters.", "Corn Fritters Day" },
                    { 177, new DateTime(2022, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "July 17 is Yellow Pig Day. Despite its name, the day is not a celebration of the porcine world, but a celebration of the number 17.", "Yellow Pig Day" },
                    { 178, new DateTime(2022, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Insurance Nerd Day on July 18 celebrates the insurance industry and helps raise awareness about the importance of insurance in our daily lives.", "Insurance Nerd Day" },
                    { 179, new DateTime(2022, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "July 19 is Stick Out Your Tongue Day.", "Stick Out Your Tongue Day" },
                    { 180, new DateTime(2022, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "On July 20, look up at the sky and think back on all the advances humankind has made in exploring and understanding space because it is Space Exploration Day.", "Space Exploration Day" },
                    { 181, new DateTime(2022, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "On July 21, let go of your diet and indulge in all your favorite unhealthy snacks without any guilt because it is Junk Food Day.", "Junk Food Day" },
                    { 182, new DateTime(2022, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "July 22 is Pi Approximation Day. Also known as Casual Pi Day, the day is dedicated to the mathematical constant pi (π).", "Pi Approximation Day" },
                    { 183, new DateTime(2022, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "July 23 is Vanilla Ice Cream Day. Celebrate this unofficial holiday of unknown origins by eating as much vanilla ice cream as you want without any guilt.", "Vanilla Ice Cream Day" },
                    { 184, new DateTime(2022, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cousins are fun to be with – they are almost like your siblings but you don’t have to share all your prized possessions with them all the time. Celebrate them on Cousins Day, an annual celebration of the special bond you share with your cousins.", "Cousins Day" },
                    { 185, new DateTime(2022, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "July 25 is Culinarians Day, an unofficial holiday that honors all cooks and chefs who bring good taste and great food in people's lives.", "Culinarians Day" },
                    { 186, new DateTime(2022, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Honor all the awesome uncles and aunts in your life on Uncle and Aunt Day. The unofficial holiday is celebrated every year on July 26.", "Uncle and Aunt Day" },
                    { 187, new DateTime(2022, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "July 27 is Take Your Pants For A Walk Day. Because the purpose or the origins of the day are unknown, we can only surmise that the unofficial holiday encourages people (in pants) to go out for a walk and enjoy the many benefits that walking provides.", "Take your Pants for a Walk Day" },
                    { 188, new DateTime(2022, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "July 28 is Milk Chocolate Day, everyone's favorite type of chocolate.", "Milk Chocolate Day" },
                    { 189, new DateTime(2022, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Who doesn’t love lasagna – the versatile and delicious dish made of layers of pasta or noodles, sauce, vegetables, and meat? Celebrate it on July 29, Lasagna Day.", "Lasagna Day" },
                    { 190, new DateTime(2022, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "July 30 is National Cheesecake Day, a day to treat yourself with a slice (or two) of this decadent dessert made of cream cheese, eggs, sugar, and a graham cracker crust.", "National Cheesecake Day" },
                    { 191, new DateTime(2022, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "July 31 is Uncommon Musical Instrument Awareness Day, a day to celebrate odd, rare, experimental, and well, uncommon musical instruments.", "Uncommon Musical Instrument Day" },
                    { 192, new DateTime(2022, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "August 1 is Girlfriend’s Day. It is unclear whether the unknown creators of this holiday wanted it to be a day for people to honor their female friends or for them to celebrate their female romantic partners.", "National Girlfriend Day" },
                    { 193, new DateTime(2022, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "What is better than a scoop of ice cream on a hot (or cold or rainy or snowy) day? A scoop of ice cream sandwiched between two layers of cookies or cake. In other words, an ice cream sandwich!", "Ice Cream Sandwich Day" },
                    { 194, new DateTime(2022, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "August 3 is Watermelon Day, an annual holiday that celebrates everyone's favorite summer fruit.", "Watermelon Day" },
                    { 195, new DateTime(2022, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "August 4 is Single Working Women's Day, a day reserved to recognize the important role that single working women play in our communities and societies", "Single Working Women's Day" },
                    { 196, new DateTime(2022, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "August 5 is Work Like a Dog Day, a day to work hard and to reward people who work day and night and are very productive.", "Work Like a Dog Day" },
                    { 197, new DateTime(2022, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "August 6 is Fresh Breath Day", "Fresh Breath Day" },
                    { 198, new DateTime(2022, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "The first Sunday of August every year is celebrated around the world as Sisters’ Day.", "Sisters' Day" },
                    { 199, new DateTime(2022, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "August 8 is Happiness Happens Day, a day to celebrate all things happy.", "Happiness Happens Day" },
                    { 200, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "August 9 is Book Lovers Day, an unofficial holiday that encourages people to pick up a book (or two) and spend the day reading.", "Book Lovers Day" },
                    { 201, new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "August 10 is Lazy Day. Celebrate your inner couch potato by giving up all your daily chores and doing nothing the whole day long!", "Lazy Day" },
                    { 202, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "August 11 is Son and Daughter Day, a day for parents to show their love and appreciation for their children.", "Son and Daughter Day" },
                    { 203, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "August 12 is Middle Child Day, a day to recognize middle born children and to acknowledge their place in their families.", "Middle Child Day" },
                    { 204, new DateTime(2022, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "August 13 is Left-Handers Day. Created in 1992 by the Left-Handers Club as a way to celebrate left-handers, the unofficial holiday aims to ‘raise awareness of the advantages and disadvantages left-handers face.’", "Left-Handers Day" },
                    { 205, new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sweltering in the summer heat? Need something to refreshing to cool down? Then just walk to your closest ice cream shop and treat yourself to a cold and delicious creamsicle (or two) because it is Creamsicle Day!", "Creamsicle Day" },
                    { 206, new DateTime(2022, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "On August 15, take a day off from your daily routine, put your feet up and relax because it is Relaxation Day.", "Relaxation Day" },
                    { 207, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "On August 16, make everyone around you giggle, guffaw, chortle, cackle or in other words, laugh, by telling them a joke because it is Tell A Joke Day.", "Tell a Joke Day" },
                    { 208, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "August 17 is Thrift Shop Day. It is a perfect holiday for those of you who like a good bargain and are a fan of old, vintage items.", "Thrift Shop Day" },
                    { 209, new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "August 18 is Mail Order Catalog Day, an annual holiday that celebrates the old-fashioned way of shopping by choosing items from a printed catalog, and ordering and paying for it through the post/ mail or over the telephone.", "Mail Order Catalog Day" },
                    { 210, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "August 19 is World Photo Day. The unofficial holiday, which is also sometimes known as Photo Day or World Photography Day, is an annual celebration of the art and science of photography.", "World Photo Day" }
                });

            migrationBuilder.InsertData(
                table: "Holidays",
                columns: new[] { "Id", "Date", "Description", "Name" },
                values: new object[,]
                {
                    { 211, new DateTime(2022, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Don't wait till the holiday season to treat yourself and your loved ones to the dessert that many believe is southern United States on a plate - chocolate pecan pie. Enjoy a slice or two of this decadent dessert on August 20, or Chocolate Pecan Pie Day.", "Chocolate Pecan Pie Day" },
                    { 212, new DateTime(2022, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "August 21 is Spumoni Day, so treat yourself to a slice (or two) of the delicious layered Italian ice cream dessert.", "Spumoni Day" },
                    { 213, new DateTime(2022, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "August 22 is Be An Angel Day. Established in 1993 by Jaune Howard Feldman, the day encourages people to be angels to those in need.", "Be An Angel Day" },
                    { 214, new DateTime(2022, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "August 23 is Ride Like the Wind Day, a day to well, ride like the wind if you can. The day also commemorates the first time the Kremer Prize was awarded in 1977. The prize is awarded to people who pioneer human powered flight.", "Ride Like the Wind Day" },
                    { 215, new DateTime(2022, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pluto Demoted Day on August 24 commemorates the day in 2006 when Pluto's status was downgraded from a full sized planet to a dwarf planet by the International Astronomical Union (IAU).", "Pluto Demoted Day" },
                    { 216, new DateTime(2022, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "August 25 is Kiss and Make Up Day, a day to let go of resentment, grudges, anger, and indignation. The unofficial holiday encourages people to make up and reconcile with anyone they are estranged with - at work, school, or in their family.", "Kiss and Make up Day" },
                    { 217, new DateTime(2022, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "August 26 is Dog Day or Dog Appreciation Day, a day to appreciate your best friend on four legs.", "Dog Appreciation Day" },
                    { 218, new DateTime(2022, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Duchess Who Wasn’t Day on August 27 celebrates the life, times and works of Irish author Margaret Wolfe Hungerford.", "The Duchess Who Wasn't Day" },
                    { 219, new DateTime(2022, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "August 28 is Bow Tie Day, an annual holiday that celebrates the elegant fashion accessory usually worn by men at formal occasions.", "Bow Tie Day" },
                    { 220, new DateTime(2022, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "On August 29, honor expertise, authority, and the rules because it is According to Hoyle Day. Named after the English language phrase, according to Hoyle, the unofficial holiday celebrates the life and times of Englishman Edmond Hoyle, who died on this day in 1769.", "According to Hoyle Day" },
                    { 221, new DateTime(2022, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "August 30 is Frankenstein Day. The unofficial holiday celebrates the life and times of English author Mary Shelley who wrote one of the word’s most read monster novel, Frankenstein, or The Modern Prometheus.", "Frankenstein Day" },
                    { 222, new DateTime(2022, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "August 31 is Eat Outside Day. So, pack up a lunch, head on over to the park and commune with nature while you eat your meal under the Sun.", "Eat Outside Day" },
                    { 223, new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Emma Nutt Day on September 1 celebrates the world’s first female telephone operator, Emma M Nutt.", "Emma Nutt Day" },
                    { 224, new DateTime(2022, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "On September 2 celebrate the 200th anniversary of any imaginary character of your choosing because it is Bison-Ten-Yell Day.", "Bison Ten Yell Day" },
                    { 225, new DateTime(2022, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Skyscraper Day is held annually on September 3. Celebrate this unofficial holiday by climbing or taking the elevator/lift up a skyscraper and by acknowledging the architectural and engineering feats that make such buildings possible.", "Skyscraper Day" },
                    { 226, new DateTime(2022, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "September 4 is Eat an Extra Dessert Day, a day that encourages people to treat their sweet tooth with a second (or well, even a third) helping of dessert.", "Eat an Extra Dessert Day" },
                    { 227, new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "We would normally not encourage you to do this on any other day, but Be Late For Something Day on September 5 is the perfect excuse for you to be late.", "Be Late for Something Day" },
                    { 228, new DateTime(2022, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "September 6 is Fight Procrastination Day. It is an unofficial holiday that encourages people to take charge of their procrastination problem and to find ways to combat the never-ending urge to put off important tasks for another day.", "Fight Procrastination Day" },
                    { 229, new DateTime(2022, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "September 7 is Salami Day, a annual holiday that honors the delicious and spicy cured Italian sausage that is a perfect wine and cheese accompaniment.", "Salami Day" },
                    { 230, new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "September 8 is Pardon Day, a day to seek and give forgiveness. On Pardon Day put aside all your grudges, be kind to everyone and forgive those who may have hurt you.", "Pardon Day" },
                    { 231, new DateTime(2022, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "September 9 is Teddy Bear Day, a day to bring out all your teddy bears and thank them for their company, the fun times you have had with them, and for all the days and nights they comforted you.", "Teddy Bear Day" },
                    { 232, new DateTime(2022, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "September 10 is Swap Ideas Day. It is a day to share thoughts, barter goods, exchange ideas, trade opinions and discuss viewpoints with family members, friends, co-workers and strangers.", "Swap Ideas Day" },
                    { 233, new DateTime(2022, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "When you wake up on September 11, make a point to make your bed because it is Make Your Bed Day!", "Make Your Bed Day" },
                    { 234, new DateTime(2022, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "September 12 is Chocolate Milkshake Day. So, what are you waiting for? Take out that blender and make yourself a glass of yummy chocolate milkshake.", "Chocolate Milkshake Day" },
                    { 235, new DateTime(2022, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Is life getting you down? Are you on your way to getting a Ph.D. in complaining? If your answer is a yes, then Positive Thinking Day (PTD) on September 13 is just the holiday you need to celebrate.", "Positive Thinking Day" },
                    { 236, new DateTime(2022, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "On September 15, don your creative hat, gather your craft supplies, channel the secret milliner in your soul and make yourself a hat because it is Make a Hat Day.", "Make a Hat Day" },
                    { 237, new DateTime(2022, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "On September 16 take a walk to the park, the beach, or to the jewelers, and collect some pretty looking rocks. Why, you ask? Because it is Collect Rocks Day.", "Collect Rocks Day" },
                    { 238, new DateTime(2022, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "The third Saturday in September is National CleanUp Day in the United States.", "National CleanUp Day" },
                    { 239, new DateTime(2022, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "September 18 is Rice Krispie Treat Day, an unofficial holiday dedicated to the no-bake, quick to make yummy gooey sweet treat.", "Rice Krispie Treat Day" },
                    { 240, new DateTime(2022, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "September 19 is National Gymnastics Day, an unofficial celebration of the graceful sport that tests everything from physical strength to agility to balance and coordination.", "National Gymnastics Day" },
                    { 241, new DateTime(2022, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "September 20 is Punch Day. Celebrate this unofficial holiday of unknown origins by drinking a tall glass of this delicious party beverage.", "Punch Day" },
                    { 242, new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "On September 21 head on over to your local miniature golf course with your family and friends for a day of fun and adventure, because it is Miniature Golf Day!", "Miniature Golf Day" },
                    { 243, new DateTime(2022, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fans of JRR Tolkien’s Lord of the Rings (LOTR) and the Hobbit epic celebrate September 22 as Hobbit Day. The week containing Hobbit Day is also celebrated as Tolkien Week.", "Hobbit Day" },
                    { 244, new DateTime(2022, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "September 23 is Checkers Day. The unofficial holiday is not about the board game but has a political origin. The holiday commemorates a speech given by American President Richard Nixon on this day in 1952 as a Vice Presidential candidate.", "Checkers Day" },
                    { 245, new DateTime(2022, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Do you find yourself correcting punctuation while reading a restaurant menu? Do you see red anytime you see an incorrect usage of the apostrophe? Then, Punctuation Day on September 24 is your kind of holiday.", "Punctuation Day" },
                    { 246, new DateTime(2022, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "September 25 is Comic Book Day. The holiday celebrates the art and science behind comic books and encourages people to read and share comic books.", "Comic Book Day" },
                    { 247, new DateTime(2022, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "September 26 is Love Note Day, an unofficial holiday that encourages you to write and send notes full of love to the special person in your life.", "Love Note Day" },
                    { 248, new DateTime(2022, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Take out all your frustrations and anger and be green and environmentally friendly at the same time by crushing a can to celebrate Crush A Can Day on September 27.", "Crush a Can Day" },
                    { 249, new DateTime(2022, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "September 28 is Ask a Stupid Question Day, a day that is devoted to all stupid and silly questions out there.", "Ask a Stupid Question Day" },
                    { 250, new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "If you are in the Northern Hemisphere chances are that by the time the end of September rolls by, the days are getting shorter and colder. Warm the days up by drinking Hot Mulled Cider on September 30.", "Hot Mulled Cider Day" },
                    { 251, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Astronomy Day is celebrated twice a year, once in the spring and once in the fall.", "Astronomy Day" },
                    { 252, new DateTime(2022, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "October 2 is Phileas Fogg Wager Day. The holiday celebrates key events in Jules Verne’s novel Around the World in Eighty Days.", "Phileas Fogg Wager Day" }
                });

            migrationBuilder.InsertData(
                table: "Holidays",
                columns: new[] { "Id", "Date", "Description", "Name" },
                values: new object[,]
                {
                    { 253, new DateTime(2022, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lettuce taco 'bout Taco Day. It's on October 4 and that gives you the perfect excuse to spend the entire day eating tacos.", "Taco Day" },
                    { 254, new DateTime(2022, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "October 5 is Chic Spy Day, a day to acknowledge that a well-dressed spy is always more successful in catching the bad guys than a scruffy one.", "Chic Spy Day" },
                    { 255, new DateTime(2022, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Celebrated annually on October 6, Mad Hatter Day celebrates the Hatter, a key character in Lewis Carol’s Alice in Wonderland.", "Mad Hatter Day" },
                    { 256, new DateTime(2022, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "The first Friday of October every year is celebrated around the globe as World Smile Day. The unofficial holiday encourages people to do acts of kindness to spread good will and cheer.", "World Smile Day" },
                    { 257, new DateTime(2022, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "October 8 is Pierogi Day, a day to stock up your fridge with delicious dumplings made of unleavened dough.", "Pierogi Day" },
                    { 258, new DateTime(2022, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Love conspiracy theories? Enjoy pondering about bizarre events that seem to have no explanations? Then Curious Events Day, a made-up holiday celebrated every year on October 9, is just the holiday you need to celebrate!", "Curious Events Day" },
                    { 259, new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Handbag Day is celebrated annually on October 10.", "Handbag Day" },
                    { 260, new DateTime(2022, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "October 11 is It’s My Party Day, a great excuse to have a party for no reason at all! All you need to do is to invite all your friends and family to a fun party!", "It's My Party Day" },
                    { 261, new DateTime(2022, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "October 12 is Old Farmers Day, a day devoted to old farmers and their farming techniques.", "Old Farmers Day" },
                    { 262, new DateTime(2022, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Are you one of those people who takes everything they hear with a grain of salt? Do you question everything and never accept things at their face value? Then, International Skeptics Day on October 13 is the holiday for you.", "International Skeptics Day" },
                    { 263, new DateTime(2022, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "The third Saturday in October is celebrated as Sweetest Day in parts of the United States.", "Sweetest Day" },
                    { 264, new DateTime(2022, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dictionary Day is on October 16. The unofficial holiday celebrates the birth anniversary of American lexicographer, Noah Webster.", "Dictionary Day" },
                    { 265, new DateTime(2022, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "On October 17 is Wear Something Gaudy Day. Celebrate this unofficial holiday by wearing everything flashy, loud and gaudy in your wardrobe!", "Wear Something Gaudy Day" },
                    { 266, new DateTime(2022, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "October 18 is Chocolate Cupcake Day. Need we say anything more?", "Chocolate Cupcake Day" },
                    { 267, new DateTime(2022, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "October 20 is International Sloth Day, a day to honor the adorable slow-moving, tree-dwelling, and leaf-eating mammals.", "International Sloth Day" },
                    { 268, new DateTime(2022, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "October 21 is Count Your Buttons Day. As far as made-up holidays go, this one is a head scratcher.", "Count your Buttons Day" },
                    { 269, new DateTime(2022, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "October 22 IS CAPS LOCK DAY! The day celebrates the Caps Lock on a computer keyboard and was created by Derek Arnold in 2000.", "Caps Lock Day" },
                    { 270, new DateTime(2022, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mole Day is an unofficial holiday celebrated by chemists and chemistry students on October 23 in honor of the mole, a measuring unit in Chemistry.", "Mole Day" },
                    { 271, new DateTime(2022, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "October 24 is Bologna Day, an unofficial holiday that was created to honor everyone's favorite sausage and sandwich meat - bologna.", "Bologna Day" },
                    { 272, new DateTime(2022, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "October 25 is Sourest Day, a day to celebrate all things sour – people or foods.", "Sourest Day" },
                    { 273, new DateTime(2022, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "October 26 is Howl At the Moon Day and Night.", "Howl at the Moon Day and Night" },
                    { 274, new DateTime(2022, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "On October 27, visit your favorite pub or bar and enjoy some American brewed beers because it is American Beer Day!", "American Beer Day" },
                    { 275, new DateTime(2022, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "October 28 is International Animation Day. It's a day to recognize and celebrate the artists, the scientists and the technicians behind animated art including animated movies.", "International Animation Day" },
                    { 276, new DateTime(2022, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "October 29 is celebrated every year as Internet Day around the world.", "Internet Day" },
                    { 277, new DateTime(2022, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nothing says Halloween is just around the corner than a bowl full of candy corn. Celebrate this multicolored candy that resembles a corn kernel on October 30, Candy Corn Day.", "Candy Corn Day" },
                    { 278, new DateTime(2022, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "October 31 is Magic Day, a day that commemorates the life and times of one of the world’s best-known magicians Harry Houdini.", "Magic Day" },
                    { 279, new DateTime(2022, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "November 1 is Author's Day, a day to honor all your favorite authors and to encourage any writers in your life to keep working on their magnum opus.", "Author's Day" },
                    { 280, new DateTime(2022, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "On November 2, boil some eggs, and make some delicious deviled or devilled eggs as they are spelled in the United Kingdom, because it is Deviled Eggs Day.", "Deviled Eggs Day" },
                    { 281, new DateTime(2022, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "November 3 is celebrated every year as Sandwich Day.", "Sandwich Day" },
                    { 282, new DateTime(2022, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Are you familiar with the saying “common sense is not that common”? Celebrate this rarely used quality on November 4, Common Sense Day.", "Common Sense Day" },
                    { 283, new DateTime(2022, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "The first Sunday of November is not only the end of the Daylight Saving Time period in the United States, it is also Zero Tasking Day.", "Zero Tasking Day" },
                    { 284, new DateTime(2022, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "It's healthy, it's delicious and it's an easy-to-make, go-to snack. Celebrate almonds covered with sweet and bitter dark chocolate on November 7 or Bittersweet Chocolate With Almond Day.", "Bittersweet Chocolate with Almonds Day" },
                    { 285, new DateTime(2022, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Say, Peter Piper picked a peck of pickled peppers ten times really fast on November 8, because it is Tongue Twister Day!", "Tongue Twister Day" },
                    { 286, new DateTime(2022, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Feel like your life sometimes spirals into a chaotic mess? Then Chaos Never Dies Day on November 9 is the holiday for you.", "Chaos Never Dies Day" },
                    { 287, new DateTime(2022, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "November 10 is Forget Me Not Day. All of us have people in our lives that we care about but are bad about keeping in touch with.", "Forget Me Not Day" },
                    { 288, new DateTime(2022, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "November 11 is Origami Day. First observed in Japan, the unofficial holiday honors the ancient Japanese art of creating intricate objects and complex shapes out of square pieces of paper.", "Origami Day" },
                    { 289, new DateTime(2022, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "November 12 is Happy Hour Day. So, on this unofficial fun holiday take advantage of happy hours at your favorite bar, cafe or restaurant.", "Happy Hour Day" },
                    { 290, new DateTime(2022, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oh, hello dear reader! Thank you so much for visiting this page! Will you please keep coming back? November 13 is World Kindness Day, a day to be kind and do acts of kindness.", "World Kindness Day" },
                    { 291, new DateTime(2022, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "November 14 is Spicy Guacamole Day. The holiday encourages guacamole lovers to spice up their favorite party dip.", "Spicy Guacamole Day" },
                    { 292, new DateTime(2022, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "November 15 is Clean Out Your Refrigerator Day, a day to clear out your fridge of all the suspicious looking, probably living and now procreating foods.", "Clean Out Your Refrigerator Day" },
                    { 293, new DateTime(2022, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Head out to your closest fast food restaurant and indulge in your favorite fast food on November 16 because it is Fast Food Day.", "Fast Food Day" },
                    { 294, new DateTime(2022, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "On November 17, wear your most comfortable hiking shoes and take a hike because it is Take A Hike Day.", "Take A Hike Day" }
                });

            migrationBuilder.InsertData(
                table: "Holidays",
                columns: new[] { "Id", "Date", "Description", "Name" },
                values: new object[,]
                {
                    { 295, new DateTime(2022, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "November 18 is Push Button Phone Day. The unofficial holiday commemorates the anniversary of the introduction of the push button phone by Bell Systems in the United States.", "Push Button Phone Day" },
                    { 296, new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Embrace the absurd and the ridiculous on November 20, National Absurdity Day. This holiday encourages people to acknowledge that absurdity is part of life.", "National Absurdity Day" },
                    { 297, new DateTime(2022, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "World Hello Day on November 21 is an unofficial holiday created to promote world peace through interpersonal communication.", "World Hello Day" },
                    { 298, new DateTime(2022, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "On November 22, take out your car, bike, segway, unicycle, kayak, horse or your tractor for a spin because it is Go For A Ride Day.", "Go For a Ride Day" },
                    { 299, new DateTime(2022, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "November 23 is Fibonacci Day, an annual holiday that honors one of the most influential mathematicians of the Middle Ages - Leonardo Bonacci.", "Fibonacci Day" },
                    { 300, new DateTime(2022, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Embrace your unique talent and celebrate it, no matter how quirky it is on November 24 or Celebrate Your Unique Talent Day.", "Celebrate Your Unique Talent Day" },
                    { 301, new DateTime(2022, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "On November 25, get your holiday shopping list organized and get ready to shop till you drop because it is Shopping Reminder Day!", "Shopping Reminder Day" },
                    { 302, new DateTime(2022, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cake Day is on November 26. Have your cake and eat it too on one of the greatest holidays ever invented.", "Cake Day" },
                    { 303, new DateTime(2022, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "November 28 is Red Planet Day, a day to celebrate and learn more about the Red Planet - Mars. The planet is called so because it appears red in color.", "Red Planet Day" },
                    { 304, new DateTime(2022, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "November 29 is Electronic Greeting Card Day. Spread cheer by sending personalized e-cards to your family and friends.", "Electronic Greeting Card Day" },
                    { 305, new DateTime(2022, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "November 30 is Computer Security Day. The unofficial holiday encourages people to secure their computers and their personal information.", "Computer Security Day" },
                    { 306, new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "December 1 is Eat a Red Apple Day, an unofficial holiday that celebrates one of the healthiest fruits available in nature's pantry.", "Eat a Red Apple Day" },
                    { 307, new DateTime(2022, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "December 2 is Fritters Day, an unofficial holiday that is dedicated to the snack made by frying battered vegetables, fruits or meat.", "Fritters Day" },
                    { 308, new DateTime(2022, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Take out the glitter, the yarn and your glue gun because it is Make A Gift Day.", "Make a Gift Day" },
                    { 309, new DateTime(2022, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "On December 4 take our your best brown shoes and wear them because it is Wear Brown Shoes Day.", "Wear Brown Shoes Day" },
                    { 310, new DateTime(2022, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "December 5 is the Day of the Ninja, a day to honor and celebrate the sneaky and stealthy masked warriors in black garb from ancient Japan.", "Day of the Ninja" },
                    { 311, new DateTime(2022, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "December 6 is Put On Your Own Shoes Day. It is a day to, well, put on your own shoes or if you are in the Southern Hemisphere, strap on your own sandals.", "Put on Your Own Shoes Day" },
                    { 312, new DateTime(2022, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "On December 7 bring out your finest stationery and your writing equipment and pen a letter to someone special because it is Letter Writing Day!", "Letter Writing Day" },
                    { 313, new DateTime(2022, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "December 8 is Pretend To Be A Time Traveler Day.", "Pretend to Be a Time Traveler Day" },
                    { 314, new DateTime(2022, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Christmas is just a few weeks away, and if you haven’t sent out your greeting cards, make sure you do it on December 9 because it is Christmas Card Day.", "Christmas Card Day" },
                    { 315, new DateTime(2022, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "December 10 is Dewey Decimal System Day. The day commemorates the birth of Melville Dewey, the inventor of the Dewey Decimal System of library classification.", "Dewey.12imal System Day" },
                    { 316, new DateTime(2022, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "December 11 is Noodle Ring Day, a day for comforting baked pasta.", "Noodle Ring Day" },
                    { 317, new DateTime(2022, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Take out all your baking supplies, unleash your imagination and build a gingerbread house on December 12 or Gingerbread House Day.", "Gingerbread House Day" },
                    { 318, new DateTime(2022, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "December 14 is Monkey Day. The day celebrates monkeys and all other primate cousins of humans such as apes, chimpanzees, and gibbons.", "Monkey Day" },
                    { 319, new DateTime(2022, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "December 16 is all about chocolate because it is Chocolate Covered Anything Day.", "Chocolate Covered Anything Day" },
                    { 320, new DateTime(2022, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wright Brothers Day on December 17 recognizes the first time Orville and Wilbur Wright successfully flew their heavier-than-air, mechanically propelled aircraft in 1903.", "Wright Brothers Day" },
                    { 321, new DateTime(2022, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "December 20 is Sangria Day. This unofficial holiday encourages people around the world to enjoy the day with a tall glass of the delicious alcoholic beverage.", "Sangria Day" },
                    { 322, new DateTime(2022, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "December 21 is International Dalek Remembrance Day, a day to remember the extraterrestrial cyborgs called Daleks in BBC's Doctor Who universe.", "International Dalek Remembrance Day" },
                    { 323, new DateTime(2022, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "On December 22 add date nut bread to your holiday baking list because it is Date Nut Bread Day.", "Date Nut Bread Day" },
                    { 324, new DateTime(2022, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Festivus is a made up secular holiday popularized and celebrated by the fans of the TV series, Seinfeld.", "Festivus" },
                    { 325, new DateTime(2022, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "December 24 is Eggnog Day, a day to celebrate, and drink a delicious cocktail of eggs, milk, cream, sugar and spices.", "Eggnog Day" },
                    { 326, new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grav-Mass Day is an unofficial holiday celebrated annually on December 25, the birth anniversary of English physicist and mathematician Isaac Newton.", "Grav Mass Day" },
                    { 327, new DateTime(2022, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "On December 26, take out your best stationary and write thank you notes to everyone you need to thank because it is Write a Thank You Note Day.", "Thank You Note Day" },
                    { 328, new DateTime(2022, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Put up a 'Do Not Disturb' sign on your door and ban all interruptions on December 27 because it is No Interruptions Day.", "No Interruptions Day" },
                    { 329, new DateTime(2022, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tired of all the holiday activities? Need a break before the New Year fun begins? Get your family and friends together for a quiet and fun night in on Card Playing Day.", "Card Playing Day" },
                    { 330, new DateTime(2022, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "December 29 is Pepper Pot Day, an unofficial holiday that honors the stew famously associated with George Washington's army during the American Revolution.", "Pepper Pot Day" },
                    { 331, new DateTime(2022, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "December 30 is Bicarbonate Of Soda Day. Also known as baking soda, sodium bicarbonate is one of the most commonly found chemical compound in households.", "Bicarbonate of Soda Day" },
                    { 332, new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Are you indecisive? Then, Make Up Your Mind Day is the unofficial holiday you should choose to close out the year with.", "Make Up Your Mind Day" }
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

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 332);
        }
    }
}
