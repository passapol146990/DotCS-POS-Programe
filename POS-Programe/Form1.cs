namespace POS_FontEnd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.createSelectTable();
            this.createFoodSelect();
        }

        void createFoodSelect()
        {
            string[] strings = {
                "Steamed wild sea bass",
                "Fillet of turbot",
                "Monkfish tail",
                "Mushroom risotto",
                "Dover sole",
                "Roast cornish cod",
                "Fillet of John Dory",
                "Les Landes magret",
                "Crustaceans",
                "Isil of Wight tomatoes",
                "Cornish red mullet soup",
                "Yellowfin tuna tartare",
                "Seared Orkney Island",
                "Shellfish ravioli",
                "Smoked eel"
            };

            ShowItemListFood.Controls.Clear();
            ShowItemListFood.AutoScroll = true;
            ShowItemListFood.FlowDirection = FlowDirection.LeftToRight;
            ShowItemListFood.WrapContents = true;
            foreach (var item in strings)
            {
                Button button = new Button();
                button.FlatAppearance.BorderSize = 0;
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 2;
                button.FlatAppearance.BorderColor = Color.LightGray;
                button.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
                button.ForeColor = SystemColors.ControlText;
                button.Location = new Point(0, 0);
                button.Margin = new Padding(0);
                button.Name = "item";
                button.Size = new Size(130, 100);
                button.TabIndex = 0;
                button.Text = ""+item;
                button.UseVisualStyleBackColor = false;
                button.Margin = new Padding(10, 5, 10, 5);

                ShowItemListFood.Controls.Add(button);
            }
        }

        void createSelectTable()
        {
            ShowItems.Controls.Clear();
            ShowItems.AutoScroll = true;
            ShowItems.FlowDirection = FlowDirection.LeftToRight;
            ShowItems.WrapContents = true;

            for (int i = 0; i < 20; i++)
            {
                Button newItem = new Button();

                newItem.BackColor = Color.FromArgb(255, 128, 128);
                newItem.FlatStyle = FlatStyle.Flat;
                newItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
                newItem.ForeColor = SystemColors.ControlText;
                newItem.ImageAlign = ContentAlignment.BottomCenter;
                newItem.ImageIndex = 0;
                newItem.ImageList = imageList2;
                newItem.Size = new Size(130, 150);
                newItem.Text = "A" + i;
                newItem.TextAlign = ContentAlignment.TopCenter;
                newItem.UseVisualStyleBackColor = false;

                newItem.Margin = new Padding(10, 5, 10, 5);

                ShowItems.Controls.Add(newItem);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BodyLists_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {

        }
    }
}
