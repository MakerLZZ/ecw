using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECW.Models.Indent
{
    class IndentModel
    {
        public int id { get; set; }
        public int userId { get; set; }
        public int goodsId { get; set; }
        public int shippingAddressId { get; set; }

        //订单号
        public int indentNumber { get; set; }

        //订单提交时间
        public DateTime submissionTime { get; set; }

        //订单状态
        public string condition { get; set; }

        //单价
        public float unitPrice { get; set; }

        //商品数量
        public int goodsNumber { get; set; }

        //总价
        public float totalPrice { get; set; }
    }
}
