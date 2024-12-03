﻿using EncrptDecrptAPI.Services.Interfaces;
using System.Security.Cryptography;

namespace EncrptDecrptAPI.Services.Implementations
{
    public class RandomNumberGeneratorService : IRandomNumberGeneratorService
    {
        public byte[] GetRandomNumber(int digitCount)
        {
            var numberAsBytes = new byte[digitCount];

            using (var randomGenerator = RandomNumberGenerator.Create())
            {
                randomGenerator.GetBytes(numberAsBytes);
            }

            return numberAsBytes;

        }
    }
}
