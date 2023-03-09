namespace AlgorithmTutorial.TutorialOne;

public class Question
{
    /* *
	 * Question One
	 * =================================
	 * Comaprison = n
	 * Fewest number increment = 0
	 * Largest number = n
	 * */
    public void Q1_CountCapitalLetter()
	{
        // Open the file and read its contents into a string variable
        var filePath = @"string.txt";
		StreamReader reader = new StreamReader(filePath);

        // HeLLo World
        var content = reader.ReadToEnd();
        // Initialize a counter variable to 0.
        var counter = 0;

        // For each character in the string
        for (var i = 0; i < content.Length; i++)
		{
            // If the character is an uppercase letter, increment the counter variable.
            if (char.IsUpper(content[i]))
			{
				counter++;
			}
		}
		Console.WriteLine($"Q1: Total capital letter in the file = {counter}");
	}

    /* *
	 * Question Two
	 * =================================
	 * addition, increment, and division
	 * addition and increment operation for n times
	 * division operations for one time
	 * */
    public void Q2_AverageNumber()
	{
        // Open the file and read its contents into a string variable.
        var filePath = @"number.txt";
        StreamReader reader = new StreamReader(filePath);

        // 1 3 5 7 9
        var content = reader.ReadToEnd();
		// Split the number into list
		var list = content.Split(" ");
        // Initialize a sum variable to 0.
        var sum = 0;

        // // For each number in the list
        for (var i = 0; i < list.Length; i++)
		{
            // Add the number to the sum variable.
            sum += int.Parse(list[i]);
		}

        // Calculate the average by dividing the sum variable by the count variable.
        var result = sum / list.Length;
		Console.WriteLine($"Q2: The average number is {result}");
    }

	/* *
	 * Question Three
	 * =================================
	 * */
	public void Q3_FindRealRoot(int a, int b, int c)
	{
        // coefficient of the equation
        //a = 2; b = 3; c = 4; // no real root
        //a = 1; b = 4; c = 4; // one real root
        a = 1; b = 3; c = -10; // one real root

        // Calculate the discriminant, d = b^2 - 4ac
        var d = b * b - 4 * a * c;

        // Find the root
        if (d < 0)
        {
            Console.WriteLine("Q3: The equation has no real roots.");
        }
        else if (d == 0)
        {
            var x = -b / (2 * a);
            Console.WriteLine($"Q3: The equation has one real root: x = {x}");
        }
        else
        {
            var x1 = (-b + Math.Sqrt(d)) / (2 * a);
            var x2 = (-b - Math.Sqrt(d)) / (2 * a);
            Console.WriteLine($"Q3: The equation has two real roots: x1 = {x1}, x2 = {x2}");
        }
    }

    /* *
	 * Question Four
	 * =================================
	 * 1. Insert card
	 * 2. Enter PIN number
	 * 3. Display account's information and account's balance
	 * 4. Select withdrawal amount
	 * 5. If (withdrawal amount <= account's balance) proceed to step 6
	 * 6. Dispense cash and update account's balance
	 * 7. Print receipt and eject card
	 * 8. End process
	 * 9. If (withdrawal amount > account's balance) prompt error message
	 * 10. cancel transaction then eject card
	 * */
}

