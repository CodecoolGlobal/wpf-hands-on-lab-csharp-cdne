using HandsOnLab1.ClientEntities;
using HandsOnLab1.ServiceAgents;

namespace HandsOnLab1
{
    /// <summary>
    /// Interaction logic for ProductList.xaml
    /// </summary>
    public partial class ProductList : System.Windows.Controls.UserControl
    {
        private ProductSummaryCollection _products;

        public ProductSummaryCollection Products
        {
            get { return _products; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductList"/> class.
        /// </summary>
        public ProductList()
        {
            InitializeComponent();
            _products = ProductAgent.GetProductList();
            DataContext = this;
        }
    }
}