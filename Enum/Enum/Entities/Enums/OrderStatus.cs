using System;
using System.Collections.Generic;
using System.Text;

namespace Enum.Entities.Enums
{
    enum OrderStatus : int //para especificar que o orderstatus é derivado de um tipo int
    {
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3

    }
}
