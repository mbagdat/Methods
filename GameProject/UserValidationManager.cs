﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1983 && gamer.Name == "Mutlu" && gamer.Soyadi == "Bağdat" && gamer.IdentityNumber == 222222222)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
