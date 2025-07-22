using System;
using Inheritance;

namespace Inheritance
{
   class Program
    {
        static void Main(string[] args)
        {       Pack pack = new Pack(5, 17, 14);
                Console.WriteLine($"Your pack has a capacity of {pack.Capacity}, " +
                                  $"maximum weight of {pack.MaxWeight}, and maximum volume of {pack.MaxVolume} units.");

                while (true)
                {
                    Console.WriteLine("\nChoose an item to add:");
                    Console.WriteLine("1. Arrow\t2. Bow\t3. Food Ration\t4. Rope\t5. Sword\t6. Water\t0. Pack up");
                    Console.Write("Enter your choice: ");
                    string? input = Console.ReadLine();

                    if (input == "0")
                        break;

                    InventoryItem? item = input switch
                    {
                        "1" => new Arrow(),
                        "2" => new Bow(),
                        "3" => new FoodRation(),
                        "4" => new Rope(),
                        "5" => new Sword(),
                        "6" => new Water(),
                        _ => null
                    };

                    if (item == null)
                    {
                        Console.WriteLine("Invalid selection. Try again.");
                        continue;
                    }

                    bool added = pack.Add(item);
                    Console.WriteLine(added ? $"Added {item}." : $"Cannot add {item}: Exceeds pack limits.");
                }

                Console.WriteLine("\nYour pack includes:");
                foreach (var item in pack.Items)
                {
                    if (item != null)
                        Console.WriteLine($"- {item}");
                }

                Console.WriteLine($"\nSummary:");
                Console.WriteLine($"Items: {pack.ItemCount}/{pack.Capacity}");
                Console.WriteLine($"Weight: {pack.CurrentWeight}/{pack.MaxWeight}");
                Console.WriteLine($"Volume: {pack.CurrentVolume}/{pack.MaxVolume}");
            }
        }
    }
