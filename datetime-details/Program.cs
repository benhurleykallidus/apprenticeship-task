var continueRunning = true;
while (continueRunning)
{
	var currentDateTime = DateTime.Now;
	var currentDay = DateTime.Now.DayOfWeek;
	var currentMonth = DateTime.Now.Month;
	var currentYear = DateTime.Now.Year;

	Console.WriteLine("Do you want the 1.DateTime, 2.Day, 3.Month, or 4.Year? Enter 1-4. Enter 'x' to close");

	var userInput = Console.ReadLine()?.Trim().ToLower();

	if (userInput == "x")
	{
		continueRunning = false;
	}

	var message = userInput switch
	{
		"1" => $"Current Date and Time: {currentDateTime}",
		"2" => $"Current Day: {currentDay}",
		"3" => $"Current Month: {currentMonth}",
		"4" => $"Current Year: {currentYear}",
		"x" => $"Exiting the program. Goodbye!",
		_ => "Invalid input. Please enter a number between 1 and 4."
	};

	Console.WriteLine(message);
}
