//Console.WriteLine("Hello World!");
/*Console.Write("Congratulations!");
Console.Write(" ");
Console.Write("You wrote your first lines of code.");
*/

/*Console.WriteLine("This is the first line.");
Console.Write("This is the second line.");
*/

/*Console.WriteLine('b');
 * Console.WriteLine(123+23.25m);M decimal, D double (default), F float, case insensitive
 */

/*string firstName = "Bobber";

Console.WriteLine(firstName);
firstName = "Copper";
Console.WriteLine(firstName);
firstName = "Hopper";
Console.WriteLine(firstName);
*/

/* var testName = "Heya" ; implicitly set to string for full code. Must be initialized.
 */

/* string username = "Bob";
int unreadMails = 3;
double temperatureCels = 34.4;

Console.Write("Hello, " + username + "!");
Console.Write(" You have " + unreadMails + " messages in your inbox.");
Console.Write(" The temperature is " + temperatureCels + " celsius."); 
*/


string projectName = "ACME";

string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

Console.Write("View English output:\n\t" + $@"c:\Exercise\{projectName}\data.txt");

Console.Write($"\n\n{russianMessage}:\n\t" + $@"c:\Exercise\{projectName}\ru-RU\data.txt");


/* int fahrenheit = 94;
float toCelsius = ((fahrenheit-32.0f) * 5/9);
Console.WriteLine(toCelsius);

Console.Write($"{fahrenheit}F is {toCelsius}C"); 
*/