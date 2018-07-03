﻿using MockSharp.PrimitiveFactories.Abstract;
using MockSharp.Utils;

namespace MockSharp.PrimitiveFactories
{
   public class CharFactory : IPrimitiveFactory<char>
   {
      public char Create()
      {
         char[] chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();
         return chars[RandomUtil.Instance.Next(0, chars.Length - 1)];
      }
   }
}
