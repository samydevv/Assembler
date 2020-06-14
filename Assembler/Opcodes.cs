﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assembler
{
    static public class InstructionsOpcode
    {
        /// <summary>
        /// Other Instructions
        /// </summary>
        static public string Nop
        {
            get
            {
                return "11000";
            }
        }
        static public string SETC
        {
            get
            {
                return "11001";
            }
        }
        static public string CLRC
        {
            get
            {
                return "11010";
            }
        }
        static public string OUT
        {
            get
            {
                return "11011";
            }
        }
        static public string IN
        {
            get
            {
                return "11100";
            }
        }
        static public string PUSH
        {
            get
            {
                return "11101";
            }
        }
        static public string POP
        {
            get
            {
                return "11110";
            }
        }
        /// <summary>
        /// ALU Instructions
        /// </summary>
        static public string SWAP
        {
            get
            {
                return "10000";
            }
        }
        static public string ADD
        {
            get
            {
                return "10001";
            }
        }
        static public string SUB
        {
            get
            {
                return "10010";
            }
        }
        static public string AND
        {
            get
            {
                return "10011";
            }
        }
        static public string OR
        {
            get
            {
                return "10100";
            }
        }
        static public string NOT
        {
            get
            {
                return "10101";
            }
        }
        static public string INC
        {
            get
            {
                return "10110";
            }
        }
        static public string DEC
        {
            get
            {
                return "10111";
            }
        }
        /// <summary>
        /// Branch Instructions
        /// </summary>
        static public string JZ
        {
            get
            {
                return "01000";
            }
        }
        static public string JN
        {
            get
            {
                return "01001";
            }
        }
        static public string JC
        {
            get
            {
                return "01010";
            }
        }
        static public string JMP
        {
            get
            {
                return "01011";
            }
        }
        static public string CALL
        {
            get
            {
                return "01100";
            }
        }
        static public string RET
        {
            get
            {
                return "01101";
            }
        }
        static public string RTI
        {
            get
            {
                return "01110";
            }
        }
        /// <summary>
        /// Imm 16/EA 20 Instructions
        /// </summary>
        static public string IADD
        {
            get
            {
                return "00000";
            }
        }
        static public string SHL
        {
            get
            {
                return "00001";
            }
        }
        static public string SHR
        {
            get
            {
                return "00010";
            }
        }
        static public string LDM
        {
            get
            {
                return "00011";
            }
        }
        static public string LDD
        {
            get
            {
                return "00100";
            }
        }
        static public string STD
        {
            get
            {
                return "00101";
            }
        }
    }
}