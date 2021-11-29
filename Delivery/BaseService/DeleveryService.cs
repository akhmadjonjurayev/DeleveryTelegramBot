using Delivery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot.Types;

namespace Delivery.BaseService
{
    public class DeleveryService
    {
        private readonly DeleveryDB _deleveryDB;
        public DeleveryService(DeleveryDB deleveryDB)
        {
            this._deleveryDB = deleveryDB;
        }

        public void MainAction(Update update)
        {
            
        }


    }
}
