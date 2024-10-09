using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace card_simulator
{
    public partial class Form1 : Form
    {
        private List<Image> common_list;
        private List<Image> Uncommon_list;
        private List<Image> Rare_list;
        private List<Image> pack;
        private int currentImageIndex;


        public Form1()
        {
            InitializeComponent();
            
            // Ensure event is bound
            this.card.Click += new EventHandler(this.pictureBox1_Click);

            common_list = new List<Image>
            {
                Properties.Common.common__2_,
                Properties.Common.common__3_,
                Properties.Common.common__4_,
                Properties.Common.common__5_,
                Properties.Common.common__6_,
                Properties.Common.common__7_,
                Properties.Common.common__8_,
                Properties.Common.common__9_,
                Properties.Common.common__10_,
                Properties.Common.common__11_,
                Properties.Common.common__12_,
                Properties.Common.common__13_,
                Properties.Common.common__14_,
                Properties.Common.common__15_,
                Properties.Common.common__16_,
                Properties.Common.common__17_,
                Properties.Common.common__18_,
                Properties.Common.common__19_,
                Properties.Common.common__20_,
                Properties.Common.common__21_,
                Properties.Common.common__22_,
                Properties.Common.common__23_,
                Properties.Common.common__24_,
                Properties.Common.common__25_,
                Properties.Common.common__26_,
                Properties.Common.common__27_,
                Properties.Common.common__28_,
                Properties.Common.common__29_,
                Properties.Common.common__30_,
                Properties.Common.common__31_,
                Properties.Common.common__32_,
                Properties.Common.common__33_,
                Properties.Common.common__34_,
                Properties.Common.common__35_,
                Properties.Common.common__36_,
                Properties.Common.common__37_,
                Properties.Common.common__38_,
                Properties.Common.common__39_,
                Properties.Common.common__40_,
                Properties.Common.common__41_,
                Properties.Common.common__42_,
                Properties.Common.common__43_,
                Properties.Common.common__44_,
                Properties.Common.common__45_,
                Properties.Common.common__46_,
                Properties.Common.common__47_,
                Properties.Common.common__48_,
                Properties.Common.common__49_,
                Properties.Common.common__50_,
                Properties.Common.common__51_,
                Properties.Common.common__52_,
                Properties.Common.common__53_,
                Properties.Common.common__54_,
                Properties.Common.common__55_,
                Properties.Common.common__56_,
                Properties.Common.common__57_,
                Properties.Common.common__58_,
                Properties.Common.common__59_,
                Properties.Common.common__60_,
                Properties.Common.common__61_,
                Properties.Common.common__62_,
                Properties.Common.common__63_,
                Properties.Common.common__64_,
                Properties.Common.common__65_,
                Properties.Common.common__66_,
                Properties.Common.common__67_,
                Properties.Common.common__68_,
                Properties.Common.common__69_,
                Properties.Common.common__70_,
                Properties.Common.common__71_,
                Properties.Common.common__72_,
                Properties.Common.common__73_,
                Properties.Common.common__74_
            };
            Uncommon_list = new List<Image>
            {
                Properties.Uncommon.uncommon__1_,
                Properties.Uncommon.uncommon__2_,
                Properties.Uncommon.uncommon__3_,
                Properties.Uncommon.uncommon__4_,
                Properties.Uncommon.uncommon__5_,
                Properties.Uncommon.uncommon__6_,
                Properties.Uncommon.uncommon__7_,
                Properties.Uncommon.uncommon__8_,
                Properties.Uncommon.uncommon__9_,
                Properties.Uncommon.uncommon__10_,
                Properties.Uncommon.uncommon__11_,
                Properties.Uncommon.uncommon__12_,
                Properties.Uncommon.uncommon__13_,
                Properties.Uncommon.uncommon__14_,
                Properties.Uncommon.uncommon__15_,
                Properties.Uncommon.uncommon__16_,
                Properties.Uncommon.uncommon__17_,
                Properties.Uncommon.uncommon__18_,
                Properties.Uncommon.uncommon__19_,
                Properties.Uncommon.uncommon__20_,
                Properties.Uncommon.uncommon__21_,
                Properties.Uncommon.uncommon__22_,
                Properties.Uncommon.uncommon__23_,
                Properties.Uncommon.uncommon__24_,
                Properties.Uncommon.uncommon__25_,
                Properties.Uncommon.uncommon__26_,
                Properties.Uncommon.uncommon__27_,
                Properties.Uncommon.uncommon__28_,
                Properties.Uncommon.uncommon__29_,
                Properties.Uncommon.uncommon__30_,
                Properties.Uncommon.uncommon__31_,

            };
            Rare_list = new List<Image> {
            Properties.Rare.rare__1_,
            Properties.Rare.rare__2_,
            Properties.Rare.rare__3_,
            Properties.Rare.rare__4_,
            Properties.Rare.rare__5_,
            Properties.Rare.rare__6_,
            Properties.Rare.rare__7_,
            Properties.Rare.rare__8_,
            Properties.Rare.rare__9_,
            Properties.Rare.rare__10_,
            Properties.Rare.rare__11_,
            Properties.Rare.rare__12_,
            Properties.Rare.rare__13_,
            Properties.Rare.rare__14_,
            Properties.Rare.rare__15_,
            Properties.Rare.rare__16_,
            Properties.Rare.rare__17_,
            Properties.Rare.rare__18_,
            Properties.Rare.rare__19_,
            Properties.Rare.rare__20_,
            Properties.Rare.rare__21_,
            Properties.Rare.rare__22_,
            Properties.Rare.rare__23_,
            Properties.Rare.rare__24_,
            Properties.Rare.rare__25_,
            Properties.Rare.rare__26_,
            Properties.Rare.rare__25_,
            Properties.Rare.rare__26_,
            Properties.Rare.rare__27_,
            Properties.Rare.rare__28_,
            Properties.Rare.rare__29_,
            Properties.Rare.rare__30_,
            Properties.Rare.rare__31_,
            Properties.Rare.rare__32_,
            Properties.Rare.rare__33_,
            Properties.Rare.rare__34_,
            Properties.Rare.rare__36_,
            Properties.Rare.rare__37_,
            Properties.Rare.rare__38_,
            Properties.Rare.rare__39_,
            Properties.Rare.rare__40_,
            Properties.Rare.rare__41_,
            Properties.Rare.rare__42_,
            Properties.Rare.rare__43_,
            Properties.Rare.rare__44_,
            Properties.Rare.rare__45_,
            Properties.Rare.rare__46_,
            Properties.Rare.rare__47_,
            Properties.Rare.rare__48_,
            Properties.Rare.rare__49_,
            Properties.Rare.rare__50_,
            Properties.Rare.rare__51_,
            Properties.Rare.rare__52_,
            Properties.Rare.rare__53_,
            Properties.Rare.rare__54_,
            Properties.Rare.rare__55_,
            Properties.Rare.rare__56_,
            Properties.Rare.rare__57_,
            Properties.Rare.rare__58_,
            Properties.Rare.rare__60_,
            Properties.Rare.rare__61_,
            Properties.Rare.rare__62_,
            Properties.Rare.rare__63_,
            Properties.Rare.rare__64_,
            Properties.Rare.rare__65_,

            
            };
            pack = new List<Image> { };
            pack_creation();



            currentImageIndex = 0;
            card.Image = pack[currentImageIndex]; // Set initial image
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
             // For debugging
            currentImageIndex++;
            if (currentImageIndex >= pack.Count) // Change to >=
            {
                currentImageIndex = 0; // Wrap around to the first image
            }
            card.Image = pack[currentImageIndex]; // Set the new image
        }

        private void pack_creation() 
        {
            Random rnd = new Random();

            int uncommon_amount;
            uncommon_amount = Uncommon_list.Count;

            int common_amount;
            common_amount = common_list.Count;

            int rare_amount;
            rare_amount = Rare_list.Count;

            //common card pulls
            for (int i = 0; i < 3; i++) 
            {
                pack.Add(common_list[rnd.Next(common_amount)]);
            };

            //uncommon card pulls
            for (int i = 0; i < 2; i++)
            {
                pack.Add(Uncommon_list[rnd.Next(uncommon_amount)]);
            };

            //rare card pulls
            pack.Add(Rare_list[rnd.Next(rare_amount)]);



        }
    }
}
