// See https://aka.ms/new-console-template for more information

#region exercise1
// count days in a week and remainder days
// INPUT
// number of days (string)
Console.WriteLine("Please enter number of days: ");
string? nd = Console.ReadLine();

// OUTPUT
// weeks and days

// PROCESS
// read user input
// divide input to 7 with modular, days are remainder
int formatNd = Convert.ToInt32(nd);
int weeks = formatNd / 7;
int days = formatNd % 7;

string weekLabel = weeks == 1 ? "week" : "weeks";
string dayLabel = days == 1 ? "day" : "days";
Console.WriteLine($"Number of {weekLabel}: {weeks}. Number of {dayLabel}: {days}");
#endregion

#region exercise2
// find total price after discount
// INPUT
// price and discount
Console.WriteLine("Please enter the price ($): ");
string price = Console.ReadLine();
Console.WriteLine("Please enter discount percentage (0-100): ");
string discount = Console.ReadLine();
// OUTPUT
double disAmount;
double finalPrice;

// PROCESS
// format input to int32
double formatPrice = Convert.ToDouble(price);
double formatDiscount = Convert.ToDouble(discount);
// find relationship of discount and price
disAmount = formatPrice * (formatDiscount / 100);
// now find ask price
finalPrice = formatPrice - disAmount;
// print result to console
Console.WriteLine($"discount price you receive: {disAmount:F2}");
Console.WriteLine($"ask price now: {finalPrice:F2}");
#endregion

#region exercise3
// convert time from minutes to hrs and mins
// INPUT
// minutes from user
Console.WriteLine("Please enter minutes you want to convert: ");
string min = Console.ReadLine();
// OUTPUT
// convert hrs and mins
int hours;
int minutes;

// PROCESS
// format user input
int totalMinutes = Convert.ToInt32(min);
// divide format input to 60
// remainder mins will convert to mins
hours = totalMinutes / 60;
minutes = totalMinutes % 60;
// print result to console
Console.WriteLine($"hour(s) : {hours}, minute(s) : {minutes}");
#endregion

#region exercise4
// require user to enter fee and VAT 
// INPUT
// fee, VAT percentage
Console.WriteLine("Please enter fee you want to convert: ");
string fee = Console.ReadLine();
Console.WriteLine("Please enter VAT percentage (0-100): ");
string vat = Console.ReadLine();

// OUTPUT
// sum after tax
double sum;

// PROCESS
// format fee and VAT to int
double formatVat = Convert.ToDouble(vat);
double formatFee = Convert.ToDouble(fee);

// calculate sum: fee + tax from free
sum = formatFee * (1 + formatVat / 100);

// print result
Console.WriteLine($"Total fee you have to pay (included VAT): {sum:F2}");
#endregion

#region exercise5
// convert USD to VND
// today rate: 1 USD = 25,167.00
// INPUT
// number in USD
Console.WriteLine("Please enter the USD amount you want to convert: ");
string usd = Console.ReadLine();
// x-rate
Console.WriteLine("Please enter the rate (USD/VND) from VCB: ");
string rate = Console.ReadLine();
// OUTPUT
// VND
double vnd;
// PROCESS
// enter USD amount
int formatUSD = Convert.ToInt32(usd);
// enter rate
double formatRate = Convert.ToDouble(rate);
// vnd = usd * rate
vnd = formatUSD * formatRate;
Console.WriteLine($"converted {formatUSD} USD to {vnd:F2} VND with the rate {rate:F2}");
#endregion

// EXTRA
#region exercise 6
// INPUT
// balance input from user
// amount input for withdraw

// OUTPUT
// calculate and print out balance after withdraw

// PROCESS
// check inputs from user
// if there is some input, convert to int
// cal minus of balance - amount

Console.WriteLine("Please enter your current balance: ");
if (!int.TryParse(Console.ReadLine(), out int balance))
{
    Console.WriteLine("Invalid input. Please enter a valid integer for the balance.");
    return;
}
Console.WriteLine("Please enter amount to withdraw: ");
if (!int.TryParse(Console.ReadLine(), out int amount))
{
    Console.WriteLine("Invalid input. Please enter a valid integer for the amount.");
    return;
}

int lastBal = balance - amount;

if (lastBal < 0)
{
    Console.WriteLine($"You cannot withdraw more than {balance}.");
}
else
{
    Console.WriteLine($"You withdraw {amount} from {balance}. Now your new balance is {lastBal}.");    
}
#endregion

#region exercise7
// INPUT
// distance input (km)
// time input (h)

// OUTPUT
// average speed (km/h)

// PROCESS
// request inputs from user
// print out average speed

Console.WriteLine("Please enter the distance you have travelled (in km): ");
if (!double.TryParse(Console.ReadLine(), out double distance))
{
    Console.WriteLine("Invalid input. Please enter a valid number for the distance.");
    return;
}

Console.WriteLine("Please enter the time travelled (in h): ");
if (!double.TryParse(Console.ReadLine(), out double timeTravelled) || timeTravelled < 0)
{
    Console.WriteLine("Invalid input. Please enter a valid number greater than 0 for time travelled.");
    return;
}

double averageSpeed = distance / timeTravelled;

Console.WriteLine("The average speed is {averageSpeed:F2} km/h.");

#endregion