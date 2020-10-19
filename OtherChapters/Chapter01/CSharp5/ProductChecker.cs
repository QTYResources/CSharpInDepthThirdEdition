using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter01.CSharp5
{
    public partial class ProductChecker : Form
    {
        private readonly Warehouse warehouse = new Warehouse();
        private readonly ProductDirectory directory = new ProductDirectory();

        static void Main()
        {
            Application.Run(new ProductChecker());
        }

        public ProductChecker()
        {
            InitializeComponent();
        }

        private async void CheckProduct(object sender, EventArgs e)
        {
            try
            {
                // Only permit one lookup at a time
                productCheckButton.Enabled = false;
                statusLabel.Text = "Checking...";
                nameValue.Text = "";
                priceValue.Text = "";
                stockValue.Text = "";

                string id = idInput.Text;
                Task<Product> productLookup = directory.LookupProductAsync(id);
                Task<int> stockLookup = warehouse.LookupStockLevelAsync(id);

                Product product = await productLookup;
                if (product == null)
                {
                    statusLabel.Text = "Product not found";
                    // We don't care about the result of the stock check
                    return;
                }
                nameValue.Text = product.Name;
                priceValue.Text = product.Price.ToString("c");

                int stock = await stockLookup;
                stockValue.Text = stock.ToString();
                statusLabel.Text = "Ready";
            }
            finally
            {
                // However we finish this method, allow another lookup
                productCheckButton.Enabled = true;
            }
        }
    }
}
