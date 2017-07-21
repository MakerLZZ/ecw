using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECW.Models.Goods
{
    class GoodsModel
    {
        //商品的Id
        public int id { get; set; }

        //编号
        public string no { get; set; }

        //标题
        public string title { get; set; }

        //副标题
        public string subhead { get; set; }

        //名称
        public string name { get; set; }

        //价格
        public float price { get; set; }

        //产地
        public string orgin { get; set; }

        //类型
        public string type { get; set; }

        //品牌
        public string brand { get; set; }

        //味道
        public string taste { get; set; }

        //库存
        public int inventory { get; set; }

        //销量
        public int sales { get; set; }

        //折扣
        //public string discount { get; set; }

        //状态（上下架）
        public bool condition { get; set; }

        //图片
        public string picture { get; set; }
    }
}
