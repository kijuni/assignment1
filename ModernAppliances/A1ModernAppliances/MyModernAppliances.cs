using ModernAppliances.Entities;
using ModernAppliances.Entities.Abstract;
using ModernAppliances.Helpers;

namespace ModernAppliances
{
    /// <summary>
    /// Manager class for Modern Appliances
    /// </summary>
    /// <remarks>Author: </remarks>
    /// <remarks>Date: </remarks>
    internal class MyModernAppliances : ModernAppliances
    {
        /// <summary>
        /// Option 1: Performs a checkout
        /// </summary>
        public override void Checkout()
        {
            // Write "Enter the item number of an appliance: "
            Console.WriteLine("Enter the item number of an appliance: ");

            // Create long variable to hold item number
            long itemNumberVar;

            // Get user input as string and assign to variable.
            string itemNumberStr = Console.ReadLine();

            // Convert user input from string to long and store as item number variable.
            itemNumberVar = long.Parse(itemNumberStr);

            // Create 'foundAppliance' variable to hold appliance with item number
            Appliance foundAppliance;

            // Assign null to foundAppliance (foundAppliance may need to be set as nullable)
            foundAppliance = null;

            // Loop through Appliances
            foreach (Appliance a in Appliances)
            {
                // Test appliance item number equals entered item number
                if (a.ItemNumber == itemNumberVar)
                {
                    //Assign appliance in list to foundAppliance variable
                    foundAppliance = a;

                    // Break out of loop (since we found what need to)
                    break;
                }
            }

            // Test appliance was not found (foundAppliance is null)
            if (foundAppliance == null)
            {
                // Write "No appliances found with that item number."
                Console.WriteLine("No appliances found with that item number.");
            }

            // Otherwise (appliance was found)
            else if (foundAppliance != null)
            {
                // Test found appliance is available
                if (foundAppliance.Quantity >= 0)
                {
                    // Checkout found appliance
                    foundAppliance.Checkout();

                    // Write "Appliance has been checked out."
                    Console.WriteLine("Appliance has been checked out");
                }

                // Otherwise (appliance isn't available)
                else
                {
                    // Write "The appliance is not available to be checked out."
                    Console.WriteLine("The appliance is not available to be checked out.");
                }
            }
        }

        /// <summary>
        /// Option 2: Finds appliances
        /// </summary>
        public override void Find()
        {
            // Write "Enter brand to search for:"
            Console.WriteLine("Enter the brand to search for:");
            // Create string variable to hold entered brand

            // Get user input as string and assign to variable.
            string userInput = Console.ReadLine();
            // Create list to hold found Appliance objects
            List<Appliance> foundAppliances = new List<Appliance>();
            // Iterate through loaded appliances
            // Test current appliance brand matches what user entered
            // Add current appliance in list to found list
            foreach (var appliance in Appliances)
            {
                // this line pre much compares like the user Input to the brand with the String Comparison var which is used in Enum
                if (appliance.Brand.Equals(userInput, StringComparison.OrdinalIgnoreCase))
                {
                    foundAppliances.Add(appliance);
                }
            }

            // Display found appliances
            DisplayAppliancesFromList(foundAppliances, 0);
        }

        /// <summary>
        /// Displays Refridgerators
        /// </summary>
        public override void DisplayRefrigerators()
        {
            // Write "Possible options:"
            Console.WriteLine("Possible options: ");

            // Write "0 - Any"
            Console.WriteLine("0 - Any");
            // Write "2 - Double doors"
            Console.WriteLine("2 - Double doors");
            // Write "3 - Three doors"
            Console.WriteLine("3 - Three doors");
            // Write "4 - Four doors"
            Console.WriteLine("4 - Four doors");

            // Write "Enter number of doors: "
            Console.WriteLine("Enter number of doors: ");

            // Create variable to hold entered number of doors
            // Get user input as string and assign to variable
            // Convert user input from string to int and store as number of doors variable.
            int numberDoors = Convert.ToInt32(Console.ReadLine());

            // Create list to hold found Appliance objects
            List<Appliance> foundAppliances = new List<Appliance>();

            // Iterate/loop through Appliances
            foreach (Appliance r in Appliances)
            {
                // Test that current appliance is a refrigerator
                if (r is Refrigerator)
                {
                    // Down cast Appliance to Refrigerator
                    // Refrigerator refrigerator = (Refrigerator) appliance;
                    Refrigerator refrigerator = (Refrigerator)r;

                    // Test user entered 0 or refrigerator doors equals what user entered.
                    // Add current appliance in list to found list
                    if (refrigerator.Doors == 2 || refrigerator.Doors == 3 || refrigerator.Doors == 4)
                    {
                        foundAppliances.Add(refrigerator);
                    }
                }
            }

            // Display found appliances
            DisplayAppliancesFromList(foundAppliances, 0);
        }
        public override void DisplayVacuums()
 {
     // Write "Possible options:"
    
     // Create grade variable to hold grade to find (Any, Residential, or Commercial)
     
     // Test input is "0"
     // Assign "Any" to grade
     // Test input is "1"
     // Assign "Residential" to grade
     // Test input is "2"
     // Assign "Commercial" to grade
     // Otherwise (input is something else)
     // Write "Invalid option."
   
     List<Appliance> foundAppliancesVacuum = new List<Appliance>();
     // Return to calling (previous) method
     //return;

     // Write "Possible options:"
     //Console.WriteLine("Possible Options");
     // Write "0 - Any"
     // Write "1 - 18 Volt"
     // Write "2 - 24 Volt"
 
     // Write "Enter voltage:"
     Console.WriteLine("Enter Voltage Value");
     // Get user input as string
     string userIVoltage= Console.ReadLine();
     int userIVoltageInt= Convert.ToInt32(userIVoltage);
     // Create variable to hold voltage
     int voltage;
     // Test input is "0"
     // Assign 0 to voltage
     // Test input is "1"
     // Assign 18 to voltage
     // Test input is "2"
     // Assign 24 to voltage
     // Otherwise
     // Write "Invalid option."
     // Return to calling (previous) method
     // return;
     if (userIVoltageInt == 0)
     {
         voltage = 0;
     }
     else if (userIVoltageInt == 18)
     {
         voltage = 18;
     }

     else if (userIVoltageInt == 24)
     {
         voltage = 24;
     }
     else
     {
         Console.WriteLine("Invalid Option");
     }
     // Create found variable to hold list of found appliances.
     //List<Appliance> foundAppliancesVacuum = new List<Appliance>();
     // Loop through appliances
     // Check if current appliance is vacuum
     // Down cast current Appliance to Vacuum object
     foreach (Appliance v in Appliances)
     {
         if (v is Vacuum)
         {
             Vacuum vacuum = (Vacuum)v;
             if (userIVoltageInt == 0)
             {
                 foundAppliancesVacuum.Add(vacuum);

             }

             else if (userIVoltageInt == 18)
             {
                 if (vacuum.BatteryVoltage == 18)
                 {
                     foundAppliancesVacuum.Add(vacuum);
                 }
             }

             else if (userIVoltageInt == 24)
             {
                 if (vacuum.BatteryVoltage == 24)
                 {
                     foundAppliancesVacuum.Add(vacuum);
                 }
             }
             else
             {
                 Console.WriteLine("Invalid Input");
             }
         }

     }
     //Making sure there are no duplicates in the list
     //List<Appliance> foundAppliancesVacuumWithoutDupes = foundAppliancesVacuum.Distinct().ToList();
     

     //Vacuum vacuum = (Vacuum)appliance;

     // Test grade is "Any" or grade is equal to current vacuum grade and voltage is 0 or voltage is equal to current vacuum voltage
     // Add current appliance in list to found list

     // Display found appliances
     DisplayAppliancesFromList(foundAppliancesVacuum, 0);
 }

        /// <summary>
        /// Displays microwaves
        /// </summary>
        public override void DisplayMicrowaves()
        {
            Console.WriteLine("Possible options: \n0 - Any\n1 - Kitchen\n2 - Work site\nEnter room type: ");

            string userInput = Console.ReadLine();

            char roomType;

            if (userInput == "0")
            {
                roomType = 'A';
            }
            else if (userInput == "1")
            {
                roomType = 'K';
            }
            else if (userInput == "2")
            {
                roomType = 'W';
            }
            else
            {
                Console.WriteLine("Invalid option.");
                return;
            }

            List<Appliance> foundApp = new List<Appliance>();

            string[] appliance = File.ReadAllLines("appliances.txt");

            foreach (Appliance m in Appliances)
            {
                if (m is Microwave)
                {
                    Microwave microwave = (Microwave)m;
                    if (roomType == 'A' || roomType == 'K' || roomType == 'W')
                    {
                        foundApp.Add(microwave);
                    }
                }
            }
            DisplayAppliancesFromList(foundApp, 0);
        }

        /// <summary>
        /// Displays dishwashers
        /// </summary>
        public override void DisplayDishwashers()
        {
            Console.WriteLine("Possible options: \n0 - Any\n1 - Quietest\n2 - Quieter\n3 - Quiet\n4 - Moderate\nEnter sound rating: ");

            string userInput = Console.ReadLine();

             string soundRating;

            if (userInput == "0")
            {
                soundRating = "Any";
            }
            else if (userInput == "1")
            {
                soundRating = "Qt";
            }
            else if (userInput == "2")
            {
                soundRating = "Qr";
            }
            else if (userInput == "3")
            {
                soundRating = "Qu";
            }
            else if (userInput == "4")
            {
                soundRating = "M";
            }
            else
            {
                Console.WriteLine("Invalid option.");
                return;
            }

            List<Appliance> foundApp = new List<Appliance>();

            string[] appliance = File.ReadAllLines("appliances.txt");

            foreach (Appliance d in Appliances)
            {
                if (d is Dishwasher)
                {
                    Dishwasher dishwasher = (Dishwasher)d;
                    if (soundRating == "Any" || soundRating == "Qt" || soundRating == "Qr" || soundRating == "Qu" || soundRating == "M")
                    {
                        foundApp.Add(dishwasher);
                    }
                }
            }
            DisplayAppliancesFromList(foundApp, 0);
        }

        /// <summary>
        /// Generates random list of appliances
        /// </summary>
        public override void RandomList()
        {
            // Write "Appliance Types"
            Console.WriteLine("Appliance Types");

            // Write "0 - Any"
            // Write "1 – Refrigerators"
            // Write "2 – Vacuums"
            // Write "3 – Microwaves"
            // Write "4 – Dishwashers"

            Console.WriteLine("0 - Any");
            Console.WriteLine("1 – Refrigerators");
            Console.WriteLine("2 – Vacuums");
            Console.WriteLine("3 – Microwaves");
            Console.WriteLine("4 – Dishwashers");

            // Write "Enter type of appliance:"
            Console.WriteLine("Enter type of appliance: ");

            // Get user input as string and assign to appliance type variable
            string inputType = Console.ReadLine();
            int inputTypeInt = int.Parse(inputType);

            // Write "Enter number of appliances: "
            Console.WriteLine("Please enter the number of appliances that you want: ");

            // Get user input as string and assign to variable
            string appliancesNumInputString = Console.ReadLine();

            // Convert user input from string to int
            int num = int.Parse(appliancesNumInputString);

            // Create variable to hold list of found appliances
            List<Appliance> found = new List<Appliance>();

            // Loop through appliances
            // Test inputted appliance type is "0"
            // Add current appliance in list to found list
            // Test inputted appliance type is "1"
            // Test current appliance type is Refrigerator
            // Add current appliance in list to found list
            // Test inputted appliance type is "2"
            // Test current appliance type is Vacuum
            // Add current appliance in list to found list
            // Test inputted appliance type is "3"
            // Test current appliance type is Microwave
            // Add current appliance in list to found list
            // Test inputted appliance type is "4"
            // Test current appliance type is Dishwasher
            // Add current appliance in list to found list
            this.Appliances.ForEach(appliance =>
            {
                if ((inputTypeInt == 1 || inputTypeInt == 0) && appliance.Type == Appliance.ApplianceTypes.Refrigerator)
                {
                    found.Add(appliance);
                }
                else if (appliance.Type == Appliance.ApplianceTypes.Vacuum && (inputTypeInt == 2 || inputTypeInt == 0))
                {
                    found.Add(appliance);
                }
                else if (appliance.Type == Appliance.ApplianceTypes.Microwave && (inputTypeInt == 3 || inputTypeInt == 0))
                {
                    found.Add(appliance);
                }
                else if (appliance.Type == Appliance.ApplianceTypes.Dishwasher && (inputTypeInt == 4 || inputTypeInt == 0))
                {
                    found.Add(appliance);
                }
            });

            // Randomize list of found appliances
            found.Sort(new RandomComparer());

            // Display found appliances (up to max. number inputted)
            DisplayAppliancesFromList(found, num);
        }
    }
}
