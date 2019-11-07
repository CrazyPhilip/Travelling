using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Travelling.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyRoutePage : ContentPage
    {
        public MyRoutePage()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            
        }

        private void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {
            string t = "宽窄巷子";
            string d = "宽窄巷子,宽窄巷子位于四川省成都市青羊区长顺街附近，由宽巷子、窄巷子、井巷子平行排列组成，全为青黛砖瓦的仿古四合院落，" +
                "这里也是成都遗留下来的较成规模的清朝古街道，与大慈寺、文殊院一起并称为成都三大历史文化名城保护街区。";
            string u = "心有萌虎（嗷呜）";
            DetailView detailView = new DetailView(t, d, u);

            stack.Children.Clear();
            stack.Children.Add(detailView);
        }

        private void TapGestureRecognizer_Tapped_3(object sender, EventArgs e)
        {
            string t = "春熙路";
            string d = "春熙路，是成都最繁华的商业街，位于成都市锦江区春熙路街道，覆盖北新街以东、总府路以南、红星路以西、东大街以北、南新街、" +
                "中新街以及临街区域，面积大约20公顷。街市热闹繁华，现大约有商业网点700家，网点面积大约220000㎡。";
            string u = "";
            DetailView detailView = new DetailView(t, d, u);

            stack.Children.Clear();
            stack.Children.Add(detailView);
        }

        private void TapGestureRecognizer_Tapped_4(object sender, EventArgs e)
        {
            string t = "太古里";
            string d = "成都远洋太古里(Sino-Ocean Taikoo Li Chengdu)坐落成都中心地带，是太古地产(Swire Properties)和远洋商业携手发展的开放式、低密度的街区形态购物中心。";
            string u = "心有萌虎（嗷呜）";
            DetailView detailView = new DetailView(t, d, u);

            stack.Children.Clear();
            stack.Children.Add(detailView);
        }

        private void TapGestureRecognizer_Tapped_5(object sender, EventArgs e)
        {
            string t = "安顺廊桥";
            string d = "安顺廊桥位于成都府河与南河交汇处的合江亭旁，横跨南河，安顺桥有着悠久的历史，最初的建筑踪迹可以追溯到元代。在马可·波罗的游记中，安顺廊桥是他印象中较为深刻的四座大桥之一。";
            string u = "心有萌虎（嗷呜）";
            DetailView detailView = new DetailView(t, d, u);

            stack.Children.Clear();
            stack.Children.Add(detailView);
        }
    }
}