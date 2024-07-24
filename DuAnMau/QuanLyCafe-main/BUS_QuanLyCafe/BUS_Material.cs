using DAL_QuanLyCafe;
using DTO_QuanLyCafe;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QuanLyCafe
{
    public class BUS_Material
    {
        private static BUS_Material instance;

        public static BUS_Material Instance
        {
            get { if (instance == null) instance = new BUS_Material(); return BUS_Material.instance; }
            private set { BUS_Material.instance = value; }
        }

        public DataTable ListMaterial()
        {
            return DAL_Material.Instance.ListMaterial();
        }

        public DataTable ListMaterial_DGV()
        {
            return DAL_Material.Instance.ListMaterial_DGV();
        }

        public bool ExistMaterial(DTO_Material material)
        {
            return DAL_Material.Instance.ExistMaterial(material);
        }

        public DataTable SelectMaterial(DTO_Material material)
        {
            return DAL_Material.Instance.SelectMaterial(material);
        }

        public bool InsertMaterial(DTO_Material material)
        {
            return DAL_Material.Instance.InsertMaterial(material);
        }

        public bool UpdateMaterial(DTO_Material material)
        {
            return DAL_Material.Instance.UpdateMaterial(material);
        }

        public bool DeleteMaterial(DTO_Material material)
        {
            return DAL_Material.Instance.DeleteMaterial(material);
        }

        public DataTable FindMaterial(string find)
        {
            return DAL_Material.Instance.FindMaterial(find);
        }

    }
}
