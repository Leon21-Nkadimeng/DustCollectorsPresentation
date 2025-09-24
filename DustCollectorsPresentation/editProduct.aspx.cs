using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DustCollectorsPresentation.ServiceReference1;
namespace DustCollectorsPresentation
{
    public partial class editProduct : System.Web.UI.Page
    {
        // all sizes associated with a product
        private List<ProductSizeDTO> sizes;
        // sizes we are inserting
        private List<ProductSizeDTO> newSizes;
        // sizes we are editing
        private List<ProductSizeDTO> editedSizes;
        // ids of sizes we want to remove
        private List<int> sizesToBeRemoved;
        private Service1Client client = new Service1Client();
        // product we are edititng
        private ProductDTO prod;
        // id of product we are editing
        private int prodId;
        // index of size we are editing in sizes list
        private int sizeIndex;

        // page load
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {

                if (Request.QueryString["prodId"] != null)
                {
                    // read the id of the product to edit
                    prodId = int.Parse(Request.QueryString["prodId"].ToString());
                    prod = client.getProductInfoForEditing(prodId);
                    // if such a product does not exists leave the page
                    if (prod == null)
                        Response.Redirect("inventory.aspx");
                }
                else
                {
                    Response.Redirect("inventory.aspx");
                }

                // check if there are any new sizes
                if (Session["newSizes"] != null)
                {
                    newSizes = (List<ProductSizeDTO>)Session["newSizes"];
                }
                else
                {
                    newSizes = new List<ProductSizeDTO>();
                    Session["newSizes"] = newSizes;
                }
                // edited sizes
                if (Session["editedSizes"] != null)
                {
                    editedSizes = (List<ProductSizeDTO>)Session["editedSizes"];
                }
                else
                {
                    editedSizes = new List<ProductSizeDTO>();
                    Session["editedSizes"] = editedSizes;
                }


                // set index of size we are editing to a value outside the possible array indexes
                sizeIndex = -1;
                if (Session["sizeIndex"] != null)
                {
                    sizeIndex = int.Parse(Session["sizeIndex"].ToString());
                }
                if (Session["sizes"] == null)
                {
                    sizes = client.getProductSizes(prodId).ToList();
                    if (sizes == null)
                        Response.Redirect("inventory.aspx");
                    else
                        Session["sizes"] = sizes;
                }
                else
                {
                    sizes = (List<ProductSizeDTO>)Session["sizes"];
                }
                // if we are loading the page for the 1st time populate dropdownlists, textboxes, and the image section
                if (!IsPostBack)
                {

                    fillInBrandDopDownList();
                    fillInCategoryDropDownList();
                    fillColourwaysDropdownList();
                    fillGendersDropdownList();
                    populateTextBoxes();
                    imgSection.InnerHtml = "<img src='" + prod.MainImgURL + "' style='width:600px; height:auto;' />";
                }
                // display all shoe sizes except the one we are editing
                displayShoeSizes(sizeIndex);
            }catch(Exception ex)
            {
                Response.Redirect("inventory.aspx");
            }

        }
        // populate textboxes with product details
        protected void populateTextBoxes()
        {
            txtName.Text = prod.Name;
            isAvailable.Checked = prod.isActive;
            brandsList.SelectedValue = prod.BrandID.ToString();
            categoriesList.SelectedValue = prod.CategoryID.ToString();
            txtPrice.Text = prod.Price.ToString();
            colourwayList.SelectedValue = prod.ColourwayID.ToString();
            txtMainImgURl.Text = prod.MainImgURL;
            txtDescription.Text = prod.Description;
            gendersList.SelectedValue = prod.GenderID.ToString();
        }
        // button to add a new size
        protected void btnNewSize_Click(object sender, EventArgs e)
        {
            newSizeRec.Visible = true;
        }
        
        protected void btnDone_Click(Object sender, EventArgs e)
        {
            ProductSizeDTO size = null;
            if (sizeIndex > -1)
            {
                // make deep copy
                size = new ProductSizeDTO()
                {
                    SizeTag = txtShoeSizeTag.Text.ToString(),
                    System = txtShoeSizeSystem.Text,
                    IsAvailable = isShoeSizeAvailable.Checked,
                    AmountInStock = int.Parse(txtAmountInStock.Text)
                };
                if (!sizeExists(size, editedSizes) && !sizeExists(size, newSizes) && !sizeExists(size, sizes))
                {
                    sizes[sizeIndex].SizeTag = txtShoeSizeTag.Text.ToString();
                    sizes[sizeIndex].System = txtShoeSizeSystem.Text;
                    sizes[sizeIndex].IsAvailable = isShoeSizeAvailable.Checked;
                    sizes[sizeIndex].AmountInStock = int.Parse(txtAmountInStock.Text);
                    editedSizes.Add(sizes[sizeIndex]);

                }
                else if((sizeExists(size, editedSizes) || sizeExists(size, newSizes)) && sizeExists(size, sizes))
                {
                    sizes[sizeIndex].IsAvailable = isShoeSizeAvailable.Checked;
                    sizes[sizeIndex].AmountInStock = int.Parse(txtAmountInStock.Text);
                   

                } 
                else if(sizeExists(size, sizes))
                {
                    sizes[sizeIndex].IsAvailable = isShoeSizeAvailable.Checked;
                    sizes[sizeIndex].AmountInStock = int.Parse(txtAmountInStock.Text);
                    editedSizes.Add(sizes[sizeIndex]);
                }
                
               lblStatus.Text = sizes[sizeIndex].Id.ToString() + " " + sizes[sizeIndex].SizeTag + " " + sizes[sizeIndex].System + " " + sizes[sizeIndex].AmountInStock.ToString();
               

                sizeIndex = -1;
                Session["sizeIndex"] = null;
            }
            else
            {
                size = new ProductSizeDTO()
                {
                    AmountInStock = int.Parse(txtAmountInStock.Text),
                    SizeTag = txtShoeSizeTag.Text,
                    System = txtShoeSizeSystem.Text,
                    IsAvailable = isShoeSizeAvailable.Checked
                };
                if (!sizeExists(size, sizes) && !sizeExists(size, editedSizes) && !sizeExists(size, newSizes))
                {
                    sizes.Add(size);


                    newSizes.Add(size);
                 
                }

            }


            btnNewSize.Visible = true;
            newSizeRec.Visible = false;

            txtAmountInStock.Text = "";
            txtShoeSizeSystem.Text = "";
            txtShoeSizeTag.Text = "";
            isShoeSizeAvailable.Checked = false;
            displayShoeSizes(sizeIndex);
            Session["editedSizes"] = editedSizes;
            Session["newSizes"] = newSizes;
            Session["sizes"] = sizes;
     
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            prod = new ProductDTO()
            {
                Id = prod.Id,
                Name = txtName.Text,
                BrandID = int.Parse(brandsList.SelectedValue),
                Description = txtDescription.Text,
                Price = decimal.Parse(txtPrice.Text),
                isActive = isAvailable.Checked ? true : false,
                CategoryID = int.Parse(categoriesList.SelectedValue),
                ColourwayID = int.Parse(colourwayList.SelectedValue),
                GenderID = int.Parse(gendersList.SelectedValue),
                MainImgURL = txtMainImgURl.Text
            };
            string isUpdated = client.updateProductAndSizes(prod, newSizes.ToArray(), editedSizes.ToArray());
            lblStatus.Text = isUpdated;
            Session["editedSizes"] = null;
            Session["newSizes"] = null;
            Session["sizes"] = null;
        }


        protected void btnRemove_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            int i = int.Parse(button.ID.Substring(3));
           
            if(Session["sizesToBeRemoved"] == null)
            {
                sizesToBeRemoved = new List<int>();
            } 
            else
            {
                sizesToBeRemoved = (List<int>)Session["sizesToBeRemoved"];
            }
            if (sizes[i].Id != -1)
            {
                sizesToBeRemoved.Add(sizes[i].Id);
                Session["sizesToBeRemoved"] = sizesToBeRemoved;
            }
           
            sizes.RemoveAt(i);

            Session["sizes"] = sizes;
            displayShoeSizes(sizeIndex);
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {

            var editBtnClick = (Button)sender;
            sizeIndex = int.Parse(editBtnClick.ID);
            Session["sizeIndex"] = sizeIndex;
            newSizeRec.Visible = true;
            btnNewSize.Visible = false;
            txtShoeSizeSystem.Text = sizes[sizeIndex].System;
            txtShoeSizeTag.Text = sizes[sizeIndex].SizeTag;
            isShoeSizeAvailable.Checked = sizes[sizeIndex].IsAvailable;
            txtAmountInStock.Text = sizes[sizeIndex].AmountInStock.ToString();
            displayShoeSizes(sizeIndex);
        }


        // utility methods
        private bool sizeExists(ProductSizeDTO size, List<ProductSizeDTO> sizesList)
        {
            foreach (ProductSizeDTO s in sizesList)
            {
                if (s.SizeTag.Equals(size.SizeTag) && s.System.ToLower().Equals(size.System.ToLower()))
                    return true;
            }
            return false;
        }
        private void fillInBrandDopDownList()
        {
            dynamic brands = client.getBrands(1);
            brandsList.Items.Clear();
            if (brands != null)
            {
                foreach (BrandDTO b in brands)
                {
                    ListItem item = new ListItem(b.name, b.Id.ToString());

                    brandsList.Items.Add(item);
                }
            }
        }

        private void fillInCategoryDropDownList()
        {
            dynamic categories = client.getCategories(true);
            categoriesList.Items.Clear();
            if (categories != null)
            {
                foreach (CategoryDTO c in categories)
                {
                    ListItem item = new ListItem(c.name, c.id.ToString());

                    categoriesList.Items.Add(item);
                }
            }
        }

        private void fillColourwaysDropdownList()
        {
            dynamic colourways = client.getColourways();
            colourwayList.Items.Clear();
            if (colourways != null)
            {
                foreach (ColourwayDTO c in colourways)
                {
                    ListItem item = new ListItem(c.name, c.id.ToString());

                    colourwayList.Items.Add(item);
                }
            }
        }
        private void fillGendersDropdownList()
        {
            dynamic genders = client.getGenders();
            gendersList.Items.Clear();
            if (genders != null)
            {
                foreach (GenderDTO g in genders)
                {
                    ListItem item = new ListItem(g.name + " (" + g.ageGroup + ")", g.Id.ToString());

                    gendersList.Items.Add(item);
                }
            }
        }


        protected void displayShoeSizes(int sizeToEditIndex)
        {
            List<TableRow> rowsToRemove = new List<TableRow>();
            for (int i = shoeSizesTbl.Rows.Count - 1; i > 1; i--)
            {

                shoeSizesTbl.Rows.RemoveAt(i);


            }
            for (int i = 0; i < sizes.Count(); i++)
            {
                if (sizes[i] != null && i != sizeToEditIndex)
                {
                    TableRow tr = new TableRow();
                    //tr.ID = sizes[i].SizeTag + "_" + sizes[i].System;
                    TableCell sizeTagCell = new TableCell();
                    sizeTagCell.Text = sizes[i].SizeTag;
                    sizeTagCell.CssClass = "column-1";
                    tr.Cells.Add(sizeTagCell);

                    TableCell sizeSystemCell = new TableCell();
                    sizeSystemCell.Text = sizes[i].System;
                    sizeSystemCell.CssClass = "column-1";
                    tr.Cells.Add(sizeSystemCell);

                    TableCell amountInStock = new TableCell();
                    amountInStock.Text = sizes[i].AmountInStock.ToString();
                    amountInStock.CssClass = "column-1";
                    tr.Cells.Add(amountInStock);

                    TableCell isAvailable = new TableCell();
                    isAvailable.Text = (sizes[i].IsAvailable) ? "Yes" : "No";
                    isAvailable.CssClass = "column-1";
                    tr.Cells.Add(isAvailable);

                    TableCell editAndDeactivate = new TableCell();
                    Button edit = new Button();
                    edit.CssClass = "flex-c-m stext-101 cl0 size-112 bg7 bor11 hov-btn3 p-lr-15 trans-04 m-b-10";
                    edit.ID = i.ToString();

                    edit.Click += new EventHandler(btnEdit_Click);
                    edit.Text = "Edit";
                    editAndDeactivate.Controls.Add(edit);

                    Button delete = new Button();
                    delete.CssClass = "flex-c-m stext-101 cl0 size-112 bg7 bor11 hov-btn3 p-lr-15 trans-04 m-b-10";
                    delete.ID = "Rmv" + i.ToString();
                    delete.Click += btnRemove_Click;
                    delete.Text = "Remove";

                    editAndDeactivate.Controls.Add(delete);
                    tr.Cells.Add(editAndDeactivate);
                    shoeSizesTbl.Rows.Add(tr);
                }


            }

        }
    }
}