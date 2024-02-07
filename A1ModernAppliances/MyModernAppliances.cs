using ModernAppliances.Entities;
using ModernAppliances.Entities.Abstract;
using ModernAppliances.Helpers;
using System;
using System.ComponentModel.Design;
using System.Linq;
using static ModernAppliances.Entities.Abstract.Appliance;

namespace ModernAppliances
{
    /// <summary>
    /// Manager class for Modern Appliances
    /// </summary>
    /// <remarks>Author: Tzu-Yun, Huang</remarks>
    /// <remarks>Date: 02.02.2024</remarks>
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
            // Get user input as string and assign to variable.
            // Convert user input from string to long and store as item number variable.
            long itemNumber = long.Parse(Console.ReadLine());

            // Create 'foundAppliance' variable to hold appliance with item number
            // Assign null to foundAppliance (foundAppliance may need to be set as nullable)
            Appliance foundAppliance = null;

            // Loop through Appliances
            // Test appliance item number equals entered item number
            // Assign appliance in list to foundAppliance variable
            foreach (Appliance appliance in Appliances)
            {
                // Break out of loop (since we found what need to)
                if (appliance.ItemNumber == itemNumber)
                {
                    foundAppliance = appliance;
                    break;
                }
            }

            // Test appliance was not found (foundAppliance is null)
            // Write "No appliances found with that item number."
            if (foundAppliance == null)
            {
                Console.WriteLine("No appliances found with that item number");
            }

            // Otherwise (appliance was found)
            // Test found appliance is available
            // Checkout found appliance

            if (foundAppliance != null)
            {
                if (foundAppliance.Quantity > 0)
                {
                    Console.WriteLine("Appliance has been checked out.");
                }
                else
                {
                    Console.WriteLine("The appliance is not available to be checked out.");
                }
            }
            else if (foundAppliance == null)
            {
                Console.WriteLine("The appliance is not available to be checked out.");
            }
            // Write "Appliance has been checked out."
            // Otherwise (appliance isn't available)
            // Write "The appliance is not available to be checked out."
        }

        /// <summary>
        /// Option 2: Finds appliances
        /// </summary>
        public override void Find()
        {
            // Write "Enter brand to search for:"
            Console.WriteLine("Enter brand to search for: ");
            // Create string variable to hold entered brand
            // Get user input as string and assign to variable.
            string enteredBrand = Console.ReadLine();
            enteredBrand = char.ToUpper(enteredBrand[0]) + enteredBrand.Substring(1);////////clara
            // Create list to hold found Appliance objects
            List<Appliance> foundAppliances = new List<Appliance>();
            // Iterate through loaded appliances
            // Test current appliance brand matches what user entered
            // Add current appliance in list to found list
            foreach (Appliance appliance in Appliances)
            {

                if (appliance.Brand == enteredBrand)
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
            Console.WriteLine("Possible options:");
            // Write "0 - Any"
            // Write "2 - Double doors"
            // Write "3 - Three doors"
            // Write "4 - Four doors"
            Console.WriteLine("0 - Any");
            Console.WriteLine("2 - Double doors");
            Console.WriteLine("3 - Three doors");
            Console.WriteLine("4 - Four doors");
            // Write "Enter number of doors: "
            Console.WriteLine("Enter number of doors: ");
            // Create variable to hold entered number of doors
            int door_num;
            // Get user input as string and assign to variable
            // Convert user input from string to int and store as number of doors variable.
            int door_input = Convert.ToInt32(Console.ReadLine());
            // Create list to hold found Appliance objects
            List<Appliance> foundRefrigerators = new List<Appliance>();
            // Iterate/loop through Appliances
            // Test that current appliance is a refrigerator
            // Down cast Appliance to Refrigerator
            // Refrigerator refrigerator = (Refrigerator) appliance;
            foreach(Appliance b in Appliances) 
            {
                // Test user entered 0 or refrigerator doors equals what user entered.
                // Add current appliance in list to found list
                if (b is Refrigerator refrigerator)
                {
                    if (door_input == 0 || door_input == refrigerator.Doors)
                    { 
                        foundRefrigerators.Add(b);
                    }
                }
            }
            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
            DisplayAppliancesFromList(foundRefrigerators, 0);
        }

        /// <summary>
        /// Displays Vacuums
        /// </summary>
        /// <param name="grade">Grade of vacuum to find (or null for any grade)</param>
        /// <param name="voltage">Vacuum voltage (or 0 for any voltage)</param>
        public override void DisplayVacuums()
        {
            // Write "Possible options:"
            Console.WriteLine("Possible options: ");
            // Write "0 - Any"
            // Write "1 - Residential"
            // Write "2 - Commercial"
            Console.WriteLine("0 - Any");
            Console.WriteLine("1 - Residential");
            Console.WriteLine("2 - Commercial");
            // Write "Enter grade:"
            Console.WriteLine("Enter grade:");

            // Get user input as string and assign to variable
            string input_grade = Console.ReadLine();
            // Create grade variable to hold grade to find (Any, Residential, or Commercial)
            string grade = "";

            // Test input is "0"
            // Assign "Any" to grade
            // Test input is "1"
            // Assign "Residential" to grade
            // Test input is "2"
            // Assign "Commercial" to grade
            // Otherwise (input is something else)
            // Write "Invalid option."
            if (input_grade == "0")
            {
                grade = "Any";
            }
            else if (input_grade == "1")
            {
                grade = "Residential";
            }
            else if (input_grade == "2")
            {
                grade = "Commercial";
            }
            else 
            {
                // Return to calling (previous) method
                // return;
                Console.WriteLine("Invalid option.");
                return;
            }
            // Write "Possible options:"
            Console.WriteLine("Possible options:");
            // Write "0 - Any"
            // Write "1 - 18 Volt"
            // Write "2 - 24 Volt"
            Console.WriteLine("0 - Any");
            Console.WriteLine("1 - 18 Volt");
            Console.WriteLine("2 - 24 Volt");

            // Write "Enter voltage:"
            Console.WriteLine("Enter voltage:");
            // Get user input as string
            // Create variable to hold voltage
            string input_Voltage = Console.ReadLine();
            int voltage = 0;

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
            if (input_Voltage == "0")
            {
                voltage = 0;
            }
            else if (input_Voltage == "1")
            {
                voltage = 18;
            }
            else if (input_Voltage == "2")
            {
                voltage = 24;
            }
            else
            {
                Console.WriteLine("Invalid option.");
                return;
            }

            // Create found variable to hold list of found appliances.
            List<Appliance> foundVacuums = new List<Appliance>();
            // Loop through Appliances
            // Check if current appliance is vacuum
            // Down cast current Appliance to Vacuum object
            // Vacuum vacuum = (Vacuum)appliance;
            foreach (Appliance c in Appliances)
            {
                if (c is Vacuum)
                {
                    Vacuum vacuum = (Vacuum)c;
                    // Test grade is "Any" or grade is equal to current vacuum grade and voltage is 0 or voltage is equal to current vacuum voltage
                    // Add current appliance in list to found list
                    if (grade == "Any" || (vacuum.Grade == grade && (voltage == 0 || vacuum.BatteryVoltage == voltage)))
                    {
                        foundVacuums.Add(c);
                    }
                }
            }
            // Display found appliances
            // DisplayAppliancesFromList(found, 0)
            DisplayAppliancesFromList(foundVacuums, 0);
        }

        /// <summary>
        /// Displays microwaves
        /// </summary>
        public override void DisplayMicrowaves()
        {
            // Write "Possible options:"
            Console.WriteLine("Possible options:");
            // Write "0 - Any"
            // Write "1 - Kitchen"
            // Write "2 - Work site"
            Console.WriteLine("0 - Any");
            Console.WriteLine("1 - Kitchen");
            Console.WriteLine("2 - Work site");

            // Write "Enter room type:"
            Console.WriteLine("Enter room type:");
            // Get user input as string and assign to variable
            string input_roomtype = Console.ReadLine();
            // Create character variable that holds room type
            char roomtype = '\0';

            // Test input is "0"
            // Assign 'A' to room type variable
            // Test input is "1"
            // Assign 'K' to room type variable
            // Test input is "2"
            // Assign 'W' to room type variable
            // Otherwise (input is something else)
            // Write "Invalid option."
            // Return to calling method
            // return;
            if (input_roomtype == "0")
            {
                roomtype = 'A';
            }
            else if (input_roomtype == "1")
            {
                roomtype = 'K';
            }
            else if (input_roomtype == "2")
            {
                roomtype = 'W';
            }
            else
            {
                Console.WriteLine("Invalid option.");
                return;
            }

            // Create variable that holds list of 'found' appliances
            List<Appliance> foundMicrowaves = new List<Appliance>();
            // Loop through Appliances
            // Test current appliance is Microwave
            // Down cast Appliance to Microwave
            foreach (Appliance d in Appliances)
            {
                if (d is Microwave)
                {
                    // Test room type equals 'A' or microwave room type
                    // Add current appliance in list to found list
                    Microwave microwave = (Microwave)d;
                    if (roomtype == 'A' || microwave.RoomType == roomtype)
                    { 
                        foundMicrowaves.Add(d);
                    }
                }
            
            }
            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
            DisplayAppliancesFromList(foundMicrowaves, 0);
        }

        /// <summary>
        /// Displays dishwashers
        /// </summary>
        public override void DisplayDishwashers()
        {
            // Write "Possible options:"
            Console.WriteLine("Possible options:");
            // Write "0 - Any"
            // Write "1 - Quietest"
            // Write "2 - Quieter"
            // Write "3 - Quiet"
            // Write "4 - Moderate"
            Console.WriteLine("0 - Any");
            Console.WriteLine("1 - Quietest");
            Console.WriteLine("2 - Quieter");
            Console.WriteLine("3 - Quiet");
            Console.WriteLine("4 - Moderate");

            // Write "Enter sound rating:"
            Console.WriteLine("Enter sound rating:");
            // Get user input as string and assign to variable
            string input_soundRate = Console.ReadLine();
            // Create variable that holds sound rating
            string soundRating = "";

            // Test input is "0"
            // Assign "Any" to sound rating variable
            // Test input is "1"
            // Assign "Qt" to sound rating variable
            // Test input is "2"
            // Assign "Qr" to sound rating variable
            // Test input is "3"
            // Assign "Qu" to sound rating variable
            // Test input is "4"
            // Assign "M" to sound rating variable
            // Otherwise (input is something else)
            // Write "Invalid option."
            // Return to calling method
            if (input_soundRate == "0")
            {
                soundRating = "Any";
            }
            else if (input_soundRate == "1")
            {
                soundRating = "Qt";
            }
            else if (input_soundRate == "2")
            {
                soundRating = "Qr";
            }
            else if (input_soundRate == "3")
            {
                soundRating = "Qu";
            }
            else if (input_soundRate == "4")
            {
                soundRating = "M";
            }
            else 
            {
                Console.WriteLine("Invalid option.");
                return;
            }

            // Create variable that holds list of found appliances
            List<Appliance> found  = new List<Appliance>();
            // Loop through Appliances
            // Test if current appliance is dishwasher
            // Down cast current Appliance to Dishwasher
            foreach (Appliance d in Appliances) 
            {
                if (d is Dishwasher)
                {
                    // Test sound rating is "Any" or equals soundrating for current dishwasher
                    // Add current appliance in list to found list
                    Dishwasher dishwasher = (Dishwasher)d;
                    if (soundRating == "Any" || dishwasher.SoundRating == soundRating)
                    {
                        found.Add(d);
                    }
                }
            }
            // Display found appliances (up to max. number inputted)
            // DisplayAppliancesFromList(found, 0);
            DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Generates random list of appliances
        /// </summary>
        public override void RandomList()
        {
            // Write "Appliance Types"
            // Write "0 - Any"
            // Write "1 – Refrigerators"
            // Write "2 – Vacuums"
            // Write "3 – Microwaves"
            // Write "4 – Dishwashers"
            // Write "Enter type of appliance:"
            // Get user input as string and assign to appliance type variable
            
            // Write "Enter number of appliances: "
            Console.WriteLine("Enter number of appliances: ");
            // Get user input as string and assign to variable
            // Convert user input from string to int
            int appliance_num = Convert.ToInt32(Console.ReadLine());
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
            foreach (Appliance e in Appliances)
            {
                if (appliance_num == 0 || found.Count < appliance_num)
                {
                    found.Add(e);
                }
            }
            found = found.OrderBy(a => Guid.NewGuid()).ToList();
            Console.WriteLine("Random appliances:");
            foreach (Appliance appliance in found)
            {
                Console.WriteLine(appliance);
            }

            // Randomize list of found appliances
            // found.Sort(new RandomComparer());
            // Display found appliances (up to max. number inputted)
            // DisplayAppliancesFromList(found, num);
        }
    }
}
