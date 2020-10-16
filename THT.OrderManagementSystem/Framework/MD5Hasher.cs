using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace THT.OrderManagementSystem.Framework
{

      public static class MD5Hasher
        {
            public static string ComputeHash(string data)
            {
                return BitConverter.ToString(
                  MD5.Create().ComputeHash(
                    Encoding.UTF8.GetBytes(data)
                  )
                );
            }

            public static string ComputeHashMIS(string input)   

            {

                // step 1, calculate MD5 hash from input

                var md5 = System.Security.Cryptography.MD5.Create();

                var inputBytes = System.Text.Encoding.ASCII.GetBytes(input);

                var hash = md5.ComputeHash(inputBytes);

                // step 2, convert byte array to hex string

                var sb = new StringBuilder();

                foreach (var t in hash)
                {
                    sb.Append(t.ToString("X2"));
                }

                return sb.ToString();

            }
    }
    }

