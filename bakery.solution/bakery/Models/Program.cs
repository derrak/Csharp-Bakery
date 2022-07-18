using System;
using Bakery.Models;

namespace Bakery
{
  public class Program
  {
    static void Main()
    {
      Console.WriteLine("   ____                                         ?~~bL");
      Console.WriteLine("  z@~ b                                         |  `U,");
      Console.WriteLine(" ]@[  |                                        ]'  z@'");
      Console.WriteLine(" d@~' `|, .__     _----L_________----, __, .  _t'   `@j");
      Console.WriteLine("'@L_,   ' - ~ '--'~-a,  Welcome to  `!!.  ~'''O_    ._`@");
      Console.WriteLine(" q@~'   ]P       ]@[   the C# Bakery  `Y=,   `H+z_  `a@");
      Console.WriteLine(" `@L  _z@        d@     Where every    Ya     `-@b,_a'");
      Console.WriteLine("  `-@d@a'       )@[   3rd item's free!  `VL      `a@@'");
      Console.WriteLine("    aa~'   ],  .a@'    Would you like     qqL  ), ./~");
      Console.WriteLine("    @@_  _z~  _d@[  [B]read or [P]astry?   .V@  .L_d'");
      Console.WriteLine("     ''~@@@'  ]@@@'          __         )@n@bza@-''");
      Console.WriteLine("       `-@zzz@@@L           )@@z         ]@@=%-''");
      Console.WriteLine("         '~~@@@@@bz_       _a@@@@@z______a@@K");
      Console.WriteLine("             '~----@@@@@@@@@@@@@@@@@@~'   ");
      Console.WriteLine("                `~~~-@~~-@@@@@@@~~~~~~~'");
      string breadOrPastry = (Console.ReadLine()).ToUpper();

      if (breadOrPastry == "B")
      {
        Console.WriteLine("   ____                                         ?~~bL");
        Console.WriteLine("  z@~ b                                         |  `U,");
        Console.WriteLine(" ]@[  |                                        ]'  z@'");
        Console.WriteLine(" d@~' `|, .__     _----L_________----, __, .  _t'   `@j");
        Console.WriteLine("'@L_,   ' - ~ '--'~-a,              `!!.  ~'''O_    ._`@");
        Console.WriteLine(" q@~'   ]P       ]@[                  `Y=,   `H+z_  `a@");
        Console.WriteLine(" `@L  _z@        d@     How many        Ya     `-@b,_a'");
        Console.WriteLine("  `-@d@a'       )@[    breads would     `VL      `a@@'");
        Console.WriteLine("    aa~'   ],  .a@'     you like?          qqL  ), ./~");
        Console.WriteLine("    @@_  _z~  _d@[                         .V@  .L_d'");
        Console.WriteLine("     ''~@@@'  ]@@@'          __         )@n@bza@-''");
        Console.WriteLine("       `-@zzz@@@L           )@@z         ]@@=%-''");
        Console.WriteLine("         '~~@@@@@bz_       _a@@@@@z______a@@K");
        Console.WriteLine("             '~----@@@@@@@@@@@@@@@@@@~'   ");
        Console.WriteLine("                `~~~-@~~-@@@@@@@~~~~~~~'");

        int breads = int.Parse(Console.ReadLine());
        Bread breadOrder = new Bread(breads, 5);
        int breadTotalCost = breadOrder.BreadCostCalc();
        breadOrder.BreadOrderTotal = breadTotalCost;
        // Console.WriteLine("bread order total " + breadOrder.BreadOrderTotal);
        Console.WriteLine("   ____                                         ?~~bL");
        Console.WriteLine("  z@~ b                                         |  `U,");
        Console.WriteLine(" ]@[  |                                        ]'  z@'");
        Console.WriteLine(" d@~' `|, .__     _----L_________----, __, .  _t'   `@j");
        Console.WriteLine("'@L_,   ' - ~ '--'~-a,              `!!.  ~'''O_    ._`@");
        Console.WriteLine(" q@~'   ]P       ]@[   " + breads + " breads will  `Y=,   `H+z_  `a@");
        Console.WriteLine(" `@L  _z@        d@    cost you $" + breadTotalCost + "      Ya     `-@b,_a'");
        Console.WriteLine("  `-@d@a'       )@[                      `VL      `a@@'");
        Console.WriteLine("    aa~'   ],  .a@'      How many          qqL  ), ./~");
        Console.WriteLine("    @@_  _z~  _d@[    pastries would        .V@  .L_d'");
        Console.WriteLine("     ''~@@@'  ]@@@'     you like?       )@n@bza@-''");
        Console.WriteLine("       `-@zzz@@@L            --          ]@@=%-''");
        Console.WriteLine("         '~~@@@@@bz_       _a@@@@@z______a@@K");
        Console.WriteLine("             '~----@@@@@@@@@@@@@@@@@@~'   ");
        Console.WriteLine("                `~~~-@~~-@@@@@@@~~~~~~~'");

        int pastries = int.Parse(Console.ReadLine());
        Pastry pastryOrder = new Pastry(pastries, 2);
        int pastryTotalCost = pastryOrder.PastryCostCalc();
        int totalCost = breadTotalCost + pastryTotalCost;
        Console.WriteLine("   ____                                         ?~~bL");
        Console.WriteLine("  z@~ b                                         |  `U,");
        Console.WriteLine(" ]@[  |                                        ]'  z@'");
        Console.WriteLine(" d@~' `|, .__     _----L_________----, __, .  _t'   `@j");
        Console.WriteLine("'@L_,   ' - ~ '--'~-a,              `!!.  ~'''O_    ._`@");
        Console.WriteLine(" q@~'   ]P       ]@[ " + pastries + " pastries will  `Y=,  `H+z_  `a@");
        Console.WriteLine(" `@L  _z@        d@    cost you $" + pastryTotalCost + "      Ya     `-@b,_a'");
        Console.WriteLine("  `-@d@a'       )@[                      `VL      `a@@'");
        Console.WriteLine("    aa~'   ],  .a@'    Your total is       qqL  ), ./~");
        Console.WriteLine("    @@_  _z~  _d@[           $" + totalCost + "            .V@  .L_d'");
        Console.WriteLine("     ''~@@@'  ]@@@'                    )@n@bza@-''");
        Console.WriteLine("       `-@zzz@@@L            --          ]@@=%-''");
        Console.WriteLine("         '~~@@@@@bz_       _a@@@@@z______a@@K");
        Console.WriteLine("             '~----@@@@@@@@@@@@@@@@@@~'   ");
        Console.WriteLine("                `~~~-@~~-@@@@@@@~~~~~~~'");
      }
    }
  }
}