using OyunApp.Business.Abstract;
using OyunApp.Validation.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunApp.Business.Concrete
{
    class PlayerManager : IOyuncu
    {
        List<IValidationService> _validationServices;

        public PlayerManager(List<IValidationService> validationServices)
        {
            _validationServices = validationServices;
        }

        public string Adi => throw new NotImplementedException();

        public void Delete(IOyuncu oyuncu)
        {
          
        }

        public void Save(IOyuncu oyuncu)
        {
            try
            {
                foreach (var item in _validationServices)
                {
                    item.Validation((Oyuncu)oyuncu);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(IOyuncu oyuncu)
        {
            
        }
    }
}
