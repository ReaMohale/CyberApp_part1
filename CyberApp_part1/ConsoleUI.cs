using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberApp_part1
{
    public static class ConsoleUI
    {
        //showing ASCII art in cyan color
        public static void ShowAsciiArt()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            string art = @"
    
  ____      _                                        _ _         
 / ___|   _| |__   ___ _ __ ___  ___  ___ _   _ _ __(_) |_ _   _ 
| |  | | | | '_ \ / _ \ '__/ __|/ _ \/ __| | | | '__| | __| | | |
| |__| |_| | |_) |  __/ |  \__ \  __/ (__| |_| | |  | | |_| |_| |
 \____\__, |_.__/ \___|_|  |___/\___|\___|\__,_|_|  |_|\__|\__, |
  ____|___/        _   ____        _                       |___/ 
 / ___| |__   __ _| |_| __ )  ___ | |_                           
| |   | '_ \ / _` | __|  _ \ / _ \| __|                          
| |___| | | | (_| | |_| |_) | (_) | |_                           
 \____|_| |_|\__,_|\__|____/ \___/ \__|   
        'Your shield against online threats'          
    
        ";
            Console.WriteLine(art);
            Console.ResetColor();
        }

    }
