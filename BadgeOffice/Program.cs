/*
* Name: Oghale Peter Ologeh
* Course: CSCI 1250, Section 001
* Assignment: Lab 03, The Badge Office
* Date: September 30, 2026
* Description: Builds a student badge from a name, two random assignments, and the walking distance to a first class.
*/



//PART 1: The Name
string fullName = Console.ReadLine();
fullName = fullName.Trim();

int spacePosition = fullName.IndexOf(" ");
string firstName = fullName.Substring(0, spacePosition);
string lastName = fullName.Substring(spacePosition + 1);

//Output
System.Console.WriteLine("Name on badge: " + fullName.Trim());
System.Console.WriteLine("Username: " + firstName.Substring(0,1).ToLower() + lastName.ToLower());
System.Console.WriteLine($"Initials: " + firstName.Substring(0,1).ToUpper() + "." + lastName.Substring(0,1).ToUpper() + "." );
System.Console.WriteLine("Letters in last name: " + lastName.Length);


//PART 2: The Numbers
Random rng = new Random();

int studentID = rng.Next(100000, 1000000);
int lockerNumber = rng.Next(1, 501);

System.Console.WriteLine("Student ID: " + studentID);
System.Console.WriteLine("Locker: " + lockerNumber);


//PART 3: The Walk
Console.Write("Dorm x: ");
double dormX = Convert.ToDouble(Console.ReadLine());

Console.Write("Dorm y: ");
double dormY = Convert.ToDouble(Console.ReadLine());

Console.Write("Classroom x: ");
double classroomX = Convert.ToDouble(Console.ReadLine());

Console.Write("Classroom: ");
double classroomY = Convert.ToDouble(Console.ReadLine());

Console.Write("Walking speed: ");
double walkingSpeed = Convert.ToDouble(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(classroomX - dormX, 2) + Math.Pow(classroomY - dormY, 2));

distance = Math.Round(distance, 1);

int totalSeconds = (int)Math.Round(distance / walkingSpeed);
int minutes = totalSeconds / 60;
int seconds = totalSeconds % 60;

//Output
System.Console.WriteLine($"Distance: {distance:F1} feet");
System.Console.WriteLine($"Walking time: {minutes} minutes {seconds} seconds");


//PART 4: The Badge
string username = firstName.Substring(0, 1).ToLower() + lastName.ToLower();
int checkDigit = studentID % 9;

//Output
System.Console.WriteLine("==================================");
System.Console.WriteLine("ETSU STUDENT BADGE");
System.Console.WriteLine("==================================");
System.Console.WriteLine("NAME".PadRight(10) + fullName);
System.Console.WriteLine("USERNAME".PadRight(10) + username);
System.Console.WriteLine("ID".PadRight(10) + studentID + "-" + checkDigit);
System.Console.WriteLine("LOCKER".PadRight(10) + lockerNumber);
System.Console.WriteLine("WALK".PadRight(10) + minutes + " " + "min" + " " + seconds + " " + "sec");
System.Console.WriteLine("==================================");