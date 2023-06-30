using System.Data;
using System.Xml.Linq;
using static MudBlazor.CategoryTypes;
using static MudBlazor.Icons.Custom;

namespace eShop.Web.Controls
{
    public class ThemSanPhamController
    {
        DataAccess DAC = new DataAccess();
        string[] name = { }; //Luu ten cac tham so
        object[] value = { }; //Mang luu gia tri cac tham so
        public int Insert(int Id, string Brand, string Name, double Price, string ImageLink, string Description)
        {
            name = new string[6];
            value = new object[6];
            name[0] = "@productid";
            name[1] = "@brand";
            name[2] = "@name";
            name[3] = "@price";
            name[4] = "@imagelink";
            name[5] = "@description";

            value[0] = Id;
            value[1] = Brand;
            value[2] = Name;
            value[3] = Price;
            value[4] = ImageLink;
            value[5] = Description;
            return DAC.Thuchien_HanhDong("InsProduct", name, value, 6);
        }
        public int Delete(int Id)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@productid";
            value[0] = Id;
            return DAC.Thuchien_HanhDong("DelProduct", name, value, 1);
        }
        public int Update(int Id, string Brand, string Name, double Price, string ImageLink, string Description)
        {
            name = new string[6];
            value = new object[6];
            name[0] = "@productid";
            name[1] = "@brand";
            name[2] = "@name";
            name[3] = "@price";
            name[4] = "@imagelink";
            name[5] = "@description";

            value[0] = Id;
            value[1] = Brand;
            value[2] = Name;
            value[3] = Price;
            value[4] = ImageLink;
            value[5] = Description;
            return DAC.Thuchien_HanhDong("UpProduct", name, value, 6);
        }

    }
}