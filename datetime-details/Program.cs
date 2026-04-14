var currentDateTime = DateTime.Now;
var currentDay = DateTime.Now.DayOfWeek;
var currentMonth = DateTime.Now.Month;
var currentYear = DateTime.Now.Year;

Console.WriteLine("Do you want the 1.DateTime, 2.Day, 3.Month, or 4.Year? Enter 1-4");

var userInput = Console.ReadLine()?.Trim().ToLower();

var message = userInput switch
{
	"1" => $"Current Date and Time: {currentDateTime}",
	"2" => $"Current Day: {currentDay}",
	"3" => $"Current Month: {currentMonth}",
	"4" => $"Current Year: {currentYear}",
	_ => "Invalid input. Please enter a number between 1 and 4."
};

Console.WriteLine(message);

Console.WriteLine("Press any key to close...");

Console.ReadKey();

