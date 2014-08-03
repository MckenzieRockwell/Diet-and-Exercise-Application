using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Diet_and_Exercise_Application
{
    public partial class AddMeal : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                populateFoodGroup(FoodGroupSelect);
            }
        }

        protected void AddMealComponent_Click(object sender, EventArgs e)
        {
            int elementCount = newMealcomponentSlot.ContentTemplateContainer.Controls.Count;
            if (newMealcomponentSlot.ContentTemplateContainer.Controls.Count <= 6)
            {
                DropDownList newFoodGroupdd = new DropDownList();

                newFoodGroupdd.ID = "FoodGroupSelect" + Convert.ToString(elementCount);

                newMealcomponentSlot.ContentTemplateContainer.Controls.Add(newFoodGroupdd);

                populateFoodGroup(newFoodGroupdd);

                newddlID.Text = elementCount.ToString();

                if (elementCount > 6)
                {
                    AddMealComponent.Enabled = false;
                }


            }
        }



        protected void populateFoodGroup(DropDownList myControl)
        {
            using (NutrientDataEntities ObjEnt = new NutrientDataEntities())
            {
                var data = from FD_GROUP in ObjEnt.FD_GROUP
                           select new
                           {
                               foodGroupDesc = FD_GROUP.FdGrp_Desc,
                               foodGroupCode = FD_GROUP.FdGrp_CD,
                           };


                myControl.DataSource = data.ToList();
                myControl.DataTextField = "foodGroupDesc";
                myControl.DataValueField = "foodGroupCode";
                myControl.DataBind();
            }


        }

        protected void updateCalSum(Object sender, EventArgs e)
        {
            try
            {
                decimal ProCal = 0;
                decimal CarbsCal = 0;
                decimal FatCal = 0;
                if (!String.IsNullOrEmpty(proteintxtb.Text))
                {
                    ProCal = Convert.ToDecimal(proteintxtb.Text) * 4;
                }
                if (!String.IsNullOrEmpty(carbstxtb.Text))
                {
                    CarbsCal = Convert.ToDecimal(carbstxtb.Text) * 4;
                }
                if (!String.IsNullOrEmpty(fattxtb.Text))
                {
                    FatCal = Convert.ToDecimal(fattxtb.Text) * 9;
                }

                if (ProCal < 0 || CarbsCal < 0 || FatCal < 0)
                {
                    throw new FormatException();
                }

                calsumlabel.Text = Convert.ToString(ProCal + CarbsCal + FatCal);

            }
            catch (FormatException ex)
            {
                calsumlabel.Text = "Please enter only Positive numerical values for all";
            }
        }

    }
}