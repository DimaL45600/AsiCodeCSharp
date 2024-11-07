namespace EntityFrameWork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            OutputListBox.Items.Clear();
            BrandIdSelect.Items.Clear();
            BrandIdSelect.Items.Add("Select Brand");
            BrandIdSelect.SelectedIndex = 0;
            ModelIdSelect.Items.Clear();
            ModelIdSelect.Items.Add("Select model");
            ModelIdSelect.SelectedIndex = 0;
            var brands = Program.context.Brands.ToList();
            foreach (var brand in brands)
            {
                OutputListBox.Items.Add($"{brand.Name}");
                BrandIdSelect.Items.Add($"{brand.Name}({brand.Id})");
                var models = Program.context.Models.Where(m => m.BrandId == brand.Id).ToList();
                foreach (var model in models)
                {
                    OutputListBox.Items.Add($" - {model.Name} :");
                    ModelIdSelect.Items.Add($"{model.Name}({model.Id})");
                    var specs = Program.context.Specs.Where(s => s.ModelId == model.Id).ToList();
                    foreach (var spec in specs)
                    {
                        OutputListBox.Items.Add($"   - {spec.Name}: {spec.Engine}, {spec.Transmission}, {spec.DriveType}; Price: {spec.AdditionalPrice + model.BasePrice}$");
                    }
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(BrandNameInput.Text))
            {
                Brand newBrand = new Brand() { Name = BrandNameInput.Text };
                Program.context.Brands.Add(newBrand);
                Program.context.SaveChanges();
                LoadData();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (BrandIdSelect.SelectedIndex != 0 && !string.IsNullOrEmpty(ModelNameInput.Text))
            {
                int brandId = int.Parse(BrandIdSelect.SelectedItem.ToString().Split('(', ')')[1]);
                Model newModel = new Model() { BasePrice = (int)BasePriceInput.Value, Name = ModelNameInput.Text, BrandId = brandId };
                Program.context.Models.Add(newModel);
                Program.context.SaveChanges();
                LoadData();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ModelIdSelect.SelectedIndex != 0)
            {
                int modelId = int.Parse(ModelIdSelect.SelectedItem.ToString().Split('(', ')')[1]);
                Spec newSpec = new Spec() { ModelId = modelId, Name = SpecNameInput.Text, Engine = EngineInput.Text, Transmission = TransmissionInput.Text, DriveType = DriveTypeInput.Text, AdditionalPrice = (int)AddedPriceInput.Value };
                Program.context.Specs.Add(newSpec);
                Program.context.SaveChanges();
                LoadData();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var spec = Program.context.Specs.FirstOrDefault(s => s.Id == 2);
            Program.context.Specs.Remove(spec);
            Program.context.SaveChanges();
        }
    }
}
