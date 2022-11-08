using MVP.Model;
using MVP.Views;

namespace MVP
{
    public partial class MainView : Form,IMainView
    {
        public MainView()
        {
            InitializeComponent();
        }

        public EventHandler<EventArgs> AddButtonClicked { get; set; }
        public EventHandler<EventArgs> LoadButtonClicked { get; set; }
        public EventHandler<EventArgs> SelectedIndexChanged { get ; set ; }
        public List<Car> Cars { set {
                carListBox.DataSource = null;
                carListBox.DataSource = value;
            } }
        public string ModelText { get => modelTxtb.Text; set => modelTxtb.Text=value; }
        public string VendorText { get => vendorTxt.Text; set => vendorTxt.Text=value; }
        public string ColorText { get => colorTxtb.Text; set => colorTxtb.Text=value; }
        public string YearText { get => yearTxtb.Text; set => yearTxtb.Text=value; }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddButtonClicked(sender, e);
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            LoadButtonClicked(sender, e);
        }

        private void carListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedIndexChanged(sender, e);
        }
    }
}