﻿using MockSharp.PrimitiveFactories.Abstract;
using MockSharp.Utils;

namespace MockSharp.PrimitiveFactories
{
   public class ByteFactory : IPrimitiveFactory<byte>
   {
      public byte Create()
      {
         //TODO: Enchance byte array performance
         byte[] randomByte = new byte[1];
         RandomUtil.Instance.NextBytes(randomByte);
         return randomByte[0];
      }
   }
}
