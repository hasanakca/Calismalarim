using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje
{
    public partial class Form1 : Form
    {
        bool mouseDown;
        private Point offset;

        public Form1()
        {
            InitializeComponent();

            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            panel1.Visible = true;
            label4.Visible = false;
          
        }      
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {
            
            panel2.Visible = true;
            pictureBox8.Visible = true;
            pictureBox9.Visible = true;            
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void MouseUp_E(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void mouseDown_Event(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            Form2 ff = new Form2();
            ff.Show();
        }

        private void mouseMove_event(object sender, MouseEventArgs e)
        {
            if(mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

      

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel4.Visible = true;
            label4.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
        }

        private void label2_Click_2(object sender, EventArgs e)
        {
            
       
            
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox1.ImageLocation = "flantadin1.jfif";
            pictureBox2.ImageLocation = "flantadin2.jpg";
            label4.Visible = true;
            label4.Text = @" 
(Flantadin 30 mg)

Ağız yoluyla alınır.

• Etkin madde: Deflazakort 30 mg
• Yardımcı maddeler: Laktoz monohidrat (inek sütünden elde edilen), mısır nişastası,
magnezyum stearat, mikrokristalin selüloz

1. FLANTADİN nedir ve ne için kullanılır?

FLANTADİN 30 mg tablet, yuvarlak, beyaz, bir yüzü çapraz diğer yüzü 30 baskılı
kaplanmamış tabletler halindedir. Her bir tablet 30 mg deflazakort etkin maddesini içerir. 10
tablet içeren blister ambalajlarda kullanıma sunulmuştur. Piyasada ayrıca 1 tablet içinde 6 mg
deflazakort etkin maddesi içeren FLANTADİN 6 mg tablet formu da mevcuttur.
FLANTADİN sentetik bir kortikosteroiddir. Kortikosteroidler vücutta doğal olarak bulunur ve
vücudun sağlığının korunmasına yardımcı olur. Dışarıdan FLANTADİN gibi
kortikosteroidlerin uygulanması vücutta inflamasyona yol açan çeşitli hastalıkların
tedavisinde etkili bir yoldur.
FLANTADİN önemli sağlık sorunlarına yol açabilecek inflamasyonun azalmasını sağlayarak
etki gösterir.
FLANTADİN otoimmün reaksiyonları durdurur. Bu reaksiyonlarda vücudun bağışıklık
sistemi kendi dokularına karşı olumsuz etkilere yol açıp hasara neden olmaktadır.
Doktorunuz size FLANTADİN’i aşağıdaki nedenlerden biri veya birkaçı dolayısıyla reçete
etmiş olabilir:
• Vücudun alerji oluşturan maddelere karşı verdiği çok şiddetli yanıt, ani aşırı duyarlılık
reaksiyonları (anafilaksi) ve astım (akciğerlerde hava yollarının daralmasına bağlı gelişen
nefes darlığı) tedavisi
• Bazı romatizmal hastalıkların (romatoid artirit, jüvenil kronik artirit, polimiyalji romatika)
tedavisi
• Deri, böbrek, kalp, sindirim sistemi, gözde bozukluklara yol açan bağ dokusu
hastalıklarının (Sistemik lupus eritematozus, dermatomiyozit, karma bağ dokusu hastalığı
(sistemik skleroz hariç), poliarteritis nodosa, sarkoidoz) tedavisi
• Bazı deri hastalıklarının (pemfigus, büllöz pemfigoid, piyoderma gangrenosum) tedavisi
• Böbrek aracılığıyla aşırı protein kaybedilmesi ile ortaya çıkan, bacaklarda, göz
kapaklarında şişmeye (ödem) sebep olan nefrotik sendrom adlı bir böbrek hastalığının,
iştahsızlık, aşırı susama, kusma ile seyreden böbrek iltihabı hastalığının (akut interstisiyel
nefrit) tedavisinde
• Kalbin bir çeşit iltihabi hastalığının (romatizmal kardit) tedavisi
• Bağırsakların (ülseratif kolit) ve sindirim kanalının (Crohn hastalığı) iltihabi hastalıklarının
tedavisi
• Bazı göz hastalıklarının tedavisi (üveit, optik nörit)
• Vücudun kendi dokusuna karşı bağışıklık sistemi saldırıları sonucu gelişen kan
hastalıkların (otoimmün hemolitik anemi, idiyopatik trombositopenik purpura) tedavisi
• Kan kanseri ya da vücudunuzdaki başka tümörlerin (akut ve lenfatik lösemi, malign
lenfoma, multipl miyelom) tedavisi
• Nakil yapılan organa karşı bağışıklık sisteminizin baskılanması (transplantasyonda
immünsüpresyon)

2. FLANTADİN’ i kullanmadan önce dikkat edilmesi gerekenler

FLANTADİN’i aşağıdaki durumlarda KULLANMAYINIZ

Eğer;
• Etkin madde olan deflazakorta karşı veya ilacın içerdiği diğer maddelere karşı alerjiniz
varsa
• Canlı virüs bağışıklaması (aşı) uygulanmışsa
• Vücudunuzda özel bir tedavi uygulanmayan yaygın bir enfeksiyonunuz varsa.
FLANTADİN’i aşağıdaki durumlarda DİKKATLİ KULLANINIZ
• Daha önce ağır depresyon veya manik-depresif bozukluk (ruhsal durumda zıt yönlü
değişikliklerle kendini gösteren bipolar bozukluk) geçirdiyseniz. Bu FLANTADİN gibi
steroid bir ilaç kullanırken ortaya çıkan depresyonu da içerir.
• Birinci derece akrabalarınızdan birinde bu bozukluklar görüldüyse.
• Sizde şu anda depresyon veya psikoz gibi ruhsal bozukluklar varsa (FLANTADİN gibi
steroidlerle tedavi sırasında ruhsal sağlık sorunları ortaya çıkabilir. Bu hastalıklar ciddi
olabilir. Genellikle ilaca başlandıktan sonra birkaç gün/hafta sonra başlar. Yüksek doz
kullanımda daha sıktır. Bu sorunların çoğu doz azaltıldığında ya da ilaç kesildiğinde
ortadan kalkar. Buna karşın tedavi de gerekli olabilir. Sizde ruhsal sorunlarla ilgili bir
belirti ortaya çıkarsa doktorunuza başvurunuz. Bu durum özellikle sizde depresyon veya
intihar düşüncesi ortaya çıkarsa önem taşır. Az sayıda olguda doz azaltıldığında ya da
kesildiğinde de ruhsal sorunlar ortaya çıkmıştır.
• FLANTADİN kullandığınız sırada asıl hastalığınızın yanı sıra başka bir enfeksiyona
yakalanırsanız.
• FLANTADİN kullanıyorsanız ya da son üç ay içinde FLANTADİN veya benzeri başka bir
ilaç kullanmış iseniz suçiçeği, kızamık ya da zona (sinir iltihabına bağlı ağrılı bir deri
hastalığı) hastalarıyla yakın temastan kaçınmalısınız, eğer temas söz konusu ise acil tıbbi
yardım için size en yakın hastaneye veya doktorunuza başvurmalısınız. 

• Tüberkülozunuz (verem hastalığı) aktif, hızlı ilerleyen ve yaygın ise FLANTADİN
kullanabilirsiniz. Bu durumda FLANTADİN ile birlikte uygun tüberküloz tedavisini de
sürdürmeniz gerekir.
• Sistemik glukokortikoid tedavisi görme kaybı dahil görme bozukluklarına neden olabilen
korioretinopatiye neden olabildiğinden, retina (gözün ağ tabakası) ayrılması, dışarı doğru
şiş gözlere sebep olan göz hastalığınız varsa
• FLANTADİN’in uzun süreli kullanımı durumunda göze perde inmesi (posterior
subkapsüler katarakt) ve göz içi basıncında artış oluşabilir. Ayrıca uzun süreli kullanım
mantar veya virüslere bağlı olan göz enfeksiyonu olasılığını artırabilir.
• İlaç tedavisine bağlı olarak böbrek üstü bezinizde bir yetmezlik tablosu ortaya çıkarsa
(Doktorunuz böyle bir durumda ilacın dozunu kademeli olarak azaltarak durumu kontrol
altına alabilir ve uygun hormonal tedaviyi uygulayabilir).
• Uzun süreli tedavi sonrası ilacınızın aniden kesilmesi sonucu ölümcül olabilen bir tablo
ortaya çıkabilir (adrenal yetmezlik) veya “glukokortikoid sendromu” denilen ateş, kas
ağrısı, eklem ağrısı ve kırıklık görülebilir (ilacı aniden kesmeyiniz, ilacı bırakırken
doktorunuz kademeli doz azaltması yapacaktır).
• FLANTADİN’i kinolon sınıfı antibiyotiklerle birlikte kullanıyorsanız, kası kemiğe
bağlayan bağ ve kirişlerde yangı (tendinit) veya kopma (tendon rüptürü) ortaya çıkabilir.
• Diğer kortikosteroidler gibi FLANTADİN de düzensiz adet görmeye ve beyaz kan
hücrelerinde artışa neden olabilir.
• Kalp hastalıkları, su tutulumundan kaynaklanan kalp yetersizliğine bağlı olarak solunum
yetmezliği, ödem, karaciğerde büyüme ile belirgin hastalık, yüksek tansiyon, toplardamar
tıkanıklığınız varsa
• Mide, bağırsak ya da yemek borusu iltihabınız (peptik ülser, ülseratif kolit, divertikülit,
özafajit) varsa
• Şeker hastasıysanız
• Kemik erimeniz varsa
• Bir tür kas güçsüzlüğünüz varsa (miyastenia gravis)
• Sara hastasıysanız
• Böbrek yetmezliğiniz varsa
• Tiroid hormonlarınızda eksiklik söz konusu ise
• Karaciğer yetmezliğiniz var ise
• Vücudunuzda enfeksiyon varsa
• Çocuklarda uzun süreli tedavi gerekiyorsa büyüme ve gelişme üstünde durdurucu etki
yapabileceği için, doktor tarafından sıkı kontrol altında kullanılacaktır.
• Yaşlılarda ilacın yan etkileri daha ciddi sonuçlara yol açabilir.
• Yanınızda riskleri en aza indirgemek için alınması gereken önlemlerle ilgili açık
yönlendirmelerle birlikte, reçete eden kişi, ilaç, dozaj ve tedavi süresi ile ilgili ayrıntıları
içeren ‘Steroid tedavi kartları’ taşımalısınız.
• Gözde herpes simpleks hastalığınız varsa.
Bu uyarılar geçmişteki herhangi bir dönemde dahi olsa sizin için geçerliyse lütfen
doktorunuza danışınız.
FLANTADİN’in yiyecek ve içecek ile kullanılması
Bilinen herhangi bir etkisi yoktur.
Hamilelik
İlacı kullanmadan önce doktorunuza veya eczacınıza danışınız.
Hamileyseniz ilacı doktorunuza danışmadan hamilelik döneminde kullanmayınız.

Tedaviniz sırasında hamile olduğunuzu fark ederseniz hemen doktorunuza veya eczacınıza
danışınız.
Emzirme
İlacı kullanmadan önce doktorunuza veya eczacınıza danışınız.
İlaç süte geçer ve yeni doğanda istenmeyen etkilere neden olabilir. Emzirme sırasında
FLANTADİN ile tedavi edilmeniz gerekiyorsa, süt vermeyi bırakmanız gerekir.
Araç ve makine kullanımı
FLANTADİN kullanımı sersemlemiş, etrafınızdaki her şey dönüyormuş veya yönünüzü
şaşırıyormuşsunuz gibi hissetmenize neden olabilir (vertigo). Bu durumları yaşarsanız araba,
araç ya da makine kullanmayınız.
FLANTADİN’in içeriğinde bulunan bazı yardımcı maddeler hakkında önemli bilgiler
Bu tıbbi ürün laktoz içermektedir. Eğer daha önceden doktorunuz tarafından bazı şekerlere
karşı intoleransınız (dayanıksızlığınız) olduğu söylenmişse bu tıbbi ürünü almadan önce
doktorunuzla temasa geçiniz.
Diğer ilaçlar ile birlikte kullanımı
Aşağıdaki ilaçlarla birlikte uygulandığında dikkatli olunmalıdır:
• Reçetesiz alınan ilaçlar dahil olmak üzere herhangi bir ilacı şu anda kullanıyorsanız veya
son zamanlarda kullandınız ise lütfen doktorunuza söyleyiniz.
• Bazı ilaçlar FLANTADİN’in etkisini artırabilir ve doktorunuz bu ilaçları (İnsan İmmün
Yetmezlik Virüsü (HIV) enfeksiyonu tedavisinde kullanılan ritonavir, kobisistat gibi bazı
ilaçlar dahil) kullanırken sizi yakından takip etmek isteyebilir.
• Aspirin gibi ağrı kesiciler (bu ilaçların böbrekten atılımı artar).
• Bazı kanser türlerinde kullanılan aminoglutetimid (FLANTADİN dozunun artırılması
gerekebilir)
• Enfeksiyon tedavisinde kullanılan ketokonazol (FLANTADİN dozunun azaltılması
gerekebilir)
• Varfarin gibi kanınızın pıhtılaşmasını engelleyen ilaçlarla birlikte kullanıldığında bu tip
ilaçlara verilen cevap bazen artabilir.
• Spironolakton, triamteren veya amilorid gibi idrar söktürücü ilaçlar, kardiyak glikozitler,
beta 2 agonistler adı verilen astım ilaçları ve akciğer hastalıklarında kullanılan ksantinler
ile birlikte kullanıldığında, bu ilaçlara verilen cevap ve potasyum kaybı artabilir.
• Diyabet ilaçları (bu ilaçlara verilen cevap azalabilir)
• Fenobarbiton, pirimidon, fenitoin, karbamazepin, asetozolamid gibi sara ilaçları
(FLANTADİN dozunun artırılması gerekebilir)
• Doğum kontrol hapları gibi östrojen içeren ilaçlar (FLANTADİN dozunun azaltılması
gerekebilir)
• Rifampisin ve rifabutin gibi tüberküloz ilaçları (FLANTADİN dozunun artırılması
gerekebilir)
• Hipertansiyon tedavisinde kullanılan ilaçlar (bu ilaçlara verilen cevap azalabilir)
• Bazı kas gevşeticiler (uzun süreli gevşemeye veya akut kas hastalığına neden olabilir)
• Hazımsızlık ve mide yanması tedavisinde kullanılan antiasitler (antiasitlerle
FLANTADİN’in kullanımı arasında en az 2 saatlik bir ara bırakınız).
• Canlı virüs aşıları hastalığa yol açabilirken diğer aşılara karşı bağışıklık yanıtı azalabilir.
Eğer reçeteli ya da reçetesiz herhangi bir ilacı şu anda kullanıyorsanız veya son zamanlarda
kullandınız ise lütfen doktorunuza veya eczacınıza bunlar hakkında bilgi veriniz. 

3. FLANTADİN nasıl kullanılır?
Uygun kullanım ve doz/uygulama sıklığı için talimatlar:
Doktorunuz, ilacınızı nasıl ve hangi dozda kullanmanız gerektiğini size söyleyecektir.
Tedavi edilen hastalığınızın şiddetine ve seyrine göre uygulanan dozlar değişkenlik
gösterebilir. Ciddi ve hayatı tehdit edici durumlarda FLANTADİN’in yüksek dozlarını
doktorunuz reçete edebilir.
• Akut hastalıklarda günlük başlangıç dozu tek doz 120 mg FLANTADİN’dir. Çoğu
durumda devam dozu 18 mg’ı geçmez.
• Romatoid artirit (eklem romatizması): Devam dozu genellikle günde 3 - 18 mg arasındadır.
Etkili en düşük doz kullanılmalı ve gerektiğinde artırılmalıdır.
• Bronşial astım: Akut atak tedavisinde şiddete göre günde 48-72 mg kadar yüksek dozlar
gerekli olabilir ve atak kontrol edildikten sonra doz giderek azaltılır. Kronik astımda idame
doz semptomları kontrol eden en düşük doz olarak ayarlanmalıdır.
• Diğer durumlar: Deflazakort dozu klinik ihtiyaca bağlı olarak etkili en düşük doz olacak
şekilde titrasyon yapılır.
Uygulama yolu ve metodu:
• FLANTADİN ağızdan alınır. Tabletleri bir bardak su ile doktorunuzun önerdiği miktarda
yutunuz. Yemeklerden önce ya da sonra kullanılabilir.
• Uzun süreli tedavi amacıyla kullanılırsa doktorunuz size özel olarak en düşük etkin dozu
ayarlayacaktır. Bu ayarlama teşhise, hastalığınızın ciddiyetine ve sizin tedaviye
vereceğiniz yanıt ve toleransınıza göre yapılır.
• İlacı bıraktıktan sonraki yaşanabilecek problemlerin önüne geçmek için uzun süreli
tedaviden sonra kademeli doz azaltılması uygulanmalıdır.
Değişik yaş grupları
Çocuklarda kullanımı:
FLANTADİN uygulama dozu erişkinleri ile aynıdır. Doktorunuz çocuğunuz için uygun olan
en düşük etkili dozu ayarlayacaktır.
FLANTADİN dozu genellikle 0,25 ile 1,5 mg/kg/gün aralığındadır.
Jüvenil kronik artirit (çocuklarda görülen eklem iltihabı): Yaygın kullanılan devam dozu 0,25
– 1 mg/kg/gün aralığındadır.
Nefrotik sendrom (böbrek hastalığı): Başlangıç dozu genellikle 1,5 mg/kg/gün olup klinik
ihtiyaca göre doz azaltılır.
Bronşial astım: Kortikosteroid gücü temelinde başlangıç dozu gün aşırı uygulanan 0,25 – 1
mg/kg deflazakort olmalıdır.
Bebeklerde; kalbin kas dokusunun yapısını ve işlevini izlemek için doktor tarafından
ekokardiyogram (ultrason) yapılmalıdır.
Yaşlılarda kullanımı:
Doktorunuz yan etkiler açısından sizi daha sık takip edecektir.
Özel kullanım durumları:
Böbrek/Karaciğer yetmezliği:
Karaciğer yetmezliğiniz varsa FLANTADİN’in kan düzeyleri yükselebilir. Doktorunuz size
uygulanan dozu takip edecek ve size özel en düşük etkin dozu ayarlayacaktır.
Böbrek yetmezliğiniz varsa FLANTADİN dozunun ayarlanması gerekmez.
 
Eğer FLANTADİN’in etkisinin çok güçlü veya zayıf olduğuna dair bir izleniminiz var ise
doktorunuz veya eczacınız ile konuşunuz.
Kullanmanız gerekenden daha fazla FLANTADİN kullandıysanız:
FLANTADİN’den kullanmanız gerekenden fazlasını kullanmışsanız bir doktor veya eczacı ile
konuşunuz.
FLANTADİN’i kullanmayı unutursanız:
Unutulan dozları dengelemek için çift doz almayınız.
FLANTADİN ile tedavi sonlandırıldığında oluşabilecek etkiler:
Uzun süreli tedavi sonrası glukokortikoidlerin aniden kesilmesi glukokortikoid bırakma
sendromunun belirtileri ile sonuçlanabilir. Bunlar ateş, burun akıntısı, gözlerde kaşıntı,
kızarıklık ve ağrı, kas ve eklem ağrısı, deride kaşıntı ve kilo kaybıdır. Özellikle çocuklarda
kusma, baş ağrısı ve sersemlik olabilir. Ayrıca böbrek üstü (adrenal) bezi yetmezliği
gelişebilir; sırt, mide ve bacaklarda ani ağrı, kusma ve ishal, kan basıncı düşmesine bağlı baş
dönmesi ve baygınlık ortaya çıkabilir.
Doktorunuzun onayı olmadan tedavinizi kendiniz sonlandırmayınız. Doktorunuz ilacın
kesilmesi gerektiğinde dozu kademeli olarak azaltarak kesecektir.
4. Olası yan etkiler nelerdir?
Tüm ilaçlar gibi, FLANTADİN içeriğinde bulunan maddelere duyarlı olan kişilerde yan
etkiler olabilir.
Aşağıdakilerden biri olursa FLANTADİN’i kullanmayı durdurunuz ve DERHAL
doktorunuza bildiriniz ya da size en yakın hastanenin acil bölümüne başvurunuz:
• Aşırı duyarlılık reaksiyonları (anafilaksi dahil): Yutma ya da nefes almada zorlanmaya
neden olabilecek el, ayak, ayak bileği, yüz, dudak ya da boğaz şişlik, deride kabarık,
kızarık ve kaşıntılı döküntü (kurdeşen) gibi belirtilerle kendini gösteren alerjik durum,
• Siyah katrana benzeyen dışkı veya dışkıda taze ya da pıhtılaşmış kan, kahve telvesi
gibi kusma (mide ülseri belirtileri olabilir),
• Sırtınıza kadar ulaşabilecek şiddetli mide ağrıları (pankreatit belirtisi olabilir).
Bunların hepsi çok ciddi yan etkilerdir. Eğer bunlardan biri sizde mevcut ise, acil tıbbi
müdahaleye veya hastaneye yatırılmanıza gerek olabilir.
Aşağıda bildirilen olası yan etkilerin sıklığı aşağıdaki gibidir:
Çok yaygın (10 kişide 1 den fazlasında görülen yan etkiler)
Yaygın (100 kişide 1 ila 10 kişi arasında görülen yan etkiler)
Yaygın olmayan (1,000 kişide 1 ila 10 kişi arasında görülen yan etkiler)
Seyrek (10.000 kişide 1 ila 10 kişi arasında görülen yan etkiler)
Çok seyrek (10.000 kişide 1 den azında görülen yan etkiler)
Bilinmiyor (eldeki verilere dayanarak sıklık bilinmiyor)
Yaygın
- Kilo artışı
 
Yaygın olmayan
- Enfeksiyonlara eğilimde artış, klinik semptom ve belirtilerin baskılanması nedeniyle
enfeksiyon şiddetinde artış, fırsatçı enfeksiyonlar, sesiz seyreden veremin (tüberkülozun)
tekrarlaması
- Şiddetli ve ölümcül reaksiyon (anafilaksi) dahil aşırı duyarlılık
- Adet görmeme, ay dede yüzü, beyin ile böbrek üstü bezi arasındaki hormon sisteminin
baskılanması
- Şeker hastalığı tedavisinin etkisinin azalmasına yol açabilen bozukluk, su ve tuz tutulması
ile birlikte kan basıncı artışı, kanda potasyum azalmasına bağlı bozukluk
- Ruhsal çökkünlük ve duygulanım değişiklikleri, davranış bozuklukları
- Baş ağrısı, baş dönmesi
- Hazımsızlık, midede ülser, kanama, bulantı
- Kıllanma artışı, sivilce, deride çizgiler
- Kemik erimesi, omur ve uzun kemiklerde kırıklar
- Şişlik (ödem)
Seyrek
- Kafa içi basınç artışı
- Kas erimesi
- Morarma
Bilinmiyor
- Mantar enfeksiyonu (kandidiazis)
- Kanda beyaz kan hücre sayısında azalma
- Bebek, çocuk ve ergenlerde büyümenin baskılanması
- Feokromositoma krizi (belirtiler, kalp atışınızın farkındalığı, kalp atış hızınızın artması
(çarpıntı), aşırı terleme, yüksek tansiyon, şiddetli baş ağrısı veya titreme hissi olabilir)
- Negatif protein ve kalsiyum dengesi, iştah artışı
- İrritabilite, aşırı keyifli olma, intihar düşünceleri, aşırı mutluluk ve taşkınlık içeren ruhsal
bozukluk (mani), olmayan şeylerin görülmesi ya da duyulması, şizofreni adı verilen ruhsal
bozukluğun şiddetlenmesi, kaygı, uyku bozuklukları, zihin bulanıklığı, bellek bozukluğu,
çocuklarda genellikle tedavi bırakıldıktan sonra kafa içi basınç artışı, sara hastalığının
şiddetlenmesi
- Retina (gözün ağ tabakası) ayrılması ve dışarı doğru şiş gözler
- Bulanık görme
- Özellikle çocuklarda gözdeki lensin opaklaşması (katarakt); göz içi basınç artışı (glokom),
göz dibinde şişme (papilloödem), göz tabakalarında incelme, gözün virüs ya da mantar
hastalıklarının alevlenmesi
- Kalp yetmezliği
- Prematüre bebeklerde kalp kasının anormal şekilde kalınlaşması (hipertrofik
kardiyomiyopati)
- Peptik ülser perforasyonu (yemek borusu, mide ya da oniki parmak bağırsağının iç
yüzeyinde aşınma, yara oluşumuna bağlı olarak delinme) ve özellikle çocuklarda görülen akut
pankreas iltihaplanması
- Eğilimli hastalarda damarlarda kan pıhtısı gelişimi
- Deride incelme, kılcal damar genişlemesi
- Kas bozukluğu, kemik bozukluğu (avasküler osteonekroz denilen kemiğe giden kan
akımının kesilmesiyle kemik hücrelerinin ölmesine yol açan, ağrı ve hareketlerde kısıtlamaya
neden olan durum), kas kirişlerinde iltihaplanma (tendinit) ve yırtılma (tendon rüptürü)
- Adet düzensizliği
- Yara iyileşmesinde bozukluk
 
- Uzun süreli tedavi ardından kortikosteroid dozunun hızla düşürülmesi akut adrenal
yetmezlik, hipotansiyon ve ölüme yol açabilir. Ateş, kas ve eklem ağrısı, nezle, göz iltihabı,
ağrılı kaşıntılı deri döküntüleri ve kilo kaybını içeren “ilaç bırakma sendromu” da gelişebilir.
Bu tablo adrenal yetmezlik kanıtı saptanmayan hastalarda da ortaya çıkabilir.
Eğer bu kullanma talimatında bahsi geçmeyen herhangi bir yan etki ile karşılaşırsanız
doktorunuzu veya eczacınızı bilgilendiriniz.
Yan etkilerin raporlanması
Kullanma talimatında yer alan veya almayan herhangi bir yan etki meydana gelmesi
durumunda, hekiminiz, eczacınız veya hemşireniz ile konuşunuz. Ayrıca karşılaştığınız yan
etkileri www.titck.gov.tr sitesinde yer alan “İlaç Yan Etki Bildirimi” ikonunu tıklayarak ya da
0 800 314 00 08 numaralı yan etki bildirim hattını arayarak Türkiye Farmakovijilans Merkezi
(TÜFAM)’ne bildiriniz. Meydana gelen yan etkileri bildirerek kullanmakta olduğunuz ilacın
güvenliliği hakkında daha fazla bilgi edinilmesine katkı sağlamış olacaksınız.
5. FLANTADİN’in saklanması
FLANTADİN’i çocukların göremeyeceği, erişemeyeceği yerlerde ve ambalajında saklayınız.
25°C’nin altındaki oda sıcaklığında saklayınız.
Son kullanma tarihiyle uyumlu olarak kullanınız
Ambalajdaki son kullanma tarihinden sonra FLANTADİN’i kullanmayınız.
                

                ";

        }

        private void label3_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox1.ImageLocation = "anapolon1.jpg";
            pictureBox2.ImageLocation = "anapolon2.jpg";
            label4.Visible = true;
            label4.Text = @" 
Bir tablet; 50 mg Oksimetolon içerir.

Farmakolojik özellikleri:

Anapolon Tablet’in içinde bulunan oksimetolon güçlü bir anabolik ve androjenik maddedir.
Anabolik steroidler, testosteronun sentetik deriveleridir. Kemik iliği yetersizliğine bağlı 
anemisi olan hastalarda eritropoietin’in üretimini ve üriner itrahını arttırır.Kırmızı hücre 
yapımı yetersizliğine bağlı anemilerde ise, eritropoezi sıklıkla stimüle eder.

Farmakokinetik özellikler:

Testosteron deriveleri ağızdan verildiğinde aktifdir.Testosterona göre relatif androjenik/ anabolik 
aktivitesi 1:3 düzeyindedir.

Endikasyonları:

Anapolon Tablet, konjenital aplastik anemi, hipoplastik anemi, myelofibrozis, myelotoksik ilaçların 
yol açtığı aplastik anemi ve eritrosit yapım bozukluğuna bağlı anemilerin tedavisinde kullanılır. 
Ancak Anapolon, bu rahatsızlıklar sırasında uygulanması gerekebilen; Demir, Folik asit, 
B12 Vitamini ve Piridoksin yetersizliği tedavileri ile transfüzyon, antibakteriyel ilaç tedavisi 
ve kortikosteroid tedavi yöntemlerinin yerine geçmez.

Kontrendikasyonları:

Aşağıdaki durumlarda anabolik ilaçlarla tedavi genellikle kontrendikedir.Bu nedenle bu gibi hallerde 
tedavi düzenlemesi yapılırken hastanın gereksinimleri ile, karşılaşabileceği riskler göz önünde 
bulundurulmalıdır:

• Erkeklerde prostat ve meme karsinomu,
• Hiperkalsemili kadınlarda meme karsinomu; (anabolik androjenik steroidler kemiklerin osteolitik 
rezorpsiyonunu stimüle edebilir),
• Hamilelik(Oksimetolon hamile kadınlara verildiğinde fetusa zarar verebilir.Hamilelerle, hamile 
kalması muhtemel olan kadınlara verilmemelidir.İlacı kullanırken hamile kalması durumunda, ilacın 
bebeğe verebileceği zararlar hastaya anlatılmalıdır),
• Nefrozis ve nefritin nefrotik fazı,
• Aşırı duyarlılık
• Ağır karaciğer bozukluğu

Uyarılar / Önlemler:

Ciddi yan etkileri nedeniyle anabolik steroidler sporcuların yeteneklerini arttırmak amacıyla 
kullanılmamalıdır. Meme kanseri bulunan hastalarda androjenik ilaç tedavisi osteolizisi uyararak 
hiperkalsemiye neden olabilir. Böyle durumlarda ilaç kesilmelidir.

Hepatotoksisite:

Sarılık da dahil olmak üzere hepatotoksik etkiler normal dozlarda sık görülür.Klinik sarılık 
ağrısız ve kaşıntılı ya da kaşıntısız olabilir.Keza akut karaciğer büyümesi ve sağ üst kadranda
ağrı ile birlikte ortaya çıkarak yanlışlıkla akut safra kanalı tıkanıklığı şeklinde 
değerlendirilebilir. İlaca bağlı sarılık ilaç kesildiğinde genellikle düzelir.Tedaviye devam 
edilmesi durumunda hepatik koma ve ölüm ortaya çıkabilir. Hepatotoksisite nedeniyle
Oksimetolon tedavisi sırasında periodik karaciğer fonksiyon testleri önerilir.
Oksimetolon ve diğer androjenlerle uzun süre tedavi edilen konjenital ve edinilmiş aplastik 
anemili hastalarda, karaciğerde kan dolu kistlerle karakterli, etiolojisi tam olarak tanımlanmamış 
nadir bir durum olan peliosis hepatis ve hepatosellüler karsinoma gözlenmiştir.Bazı vakalarda 
ilacın kesilmesi sonunda hepatik lezyonlarda düzelme ortaya çıkmıştır.

Virilizasyon: 

Kadınlarda virilizasyon ortaya çıkabilir. Yetişkin kadınlarda trombositopeni varlığında bile,
genillikle amenore görülür.Menorajinin kontrolü için yüksek dozda progestasyonel ajanların 
tedaviye eklenmesi önerilmez.

Demir Yetersizliği: 

Oksimetolon ile tedavi edilen hastaların bazılarında serum demirinin düşmesi ve transferin 
saturasyon yüzdesinin azalması şeklinde ortaya çıkan demir yetersizliği anemisinin geliştiği 
gözlenmiştir.Bu durumda serum demir ve demir bağlama kapasitesini periyodik olarak tespit 
edilmesi tavsiye edilmektedir. Demir yetersizliği saptandığı takdirde uygun demir preparatı 
verilerek tedavi edilmelidir.

Oksimetolon ile tedavi edilen aplastik anemili hastalarda lösemi gözlenmiştir.Ancak burada 
ilacın rolünün bulunup bulunmadığı ve eğer varsa bunun ne olduğu açıklığa kavuşmamıştır.
Çünkü kan diskrazilerinde malignleşme ortaya çıkabilmektedir, aplastik anemili olupta 
Oksimetolon ile tedavi edilmeyen hastalarda lösemi bildirilmiştir.

Bu gibi ilaçları kalp, böbrek veya karaciğer hastalığı bulunan hastalara verirken dikkatli 
olunmalıdır. Bazen konjestif kalp yetmezliği ile birlikte verildiğinde ödem fazlalaşabilir.
Bu durum uygun diüretik ve / veya digital tedavisi ile kontrol altına alınabilir.

Disemine meme karsinomu bulunan kadınlarda hormonal tedavinin bir sonucu olarak veya 
kendiliğinden hiperkalsemi gelişebilir. İlaç kullanılırken böyle bir durum ortaya çıkarsa 
ilaç kesilmelidir.

Anabolik steroidler antikoagülanlara duyarlılığı arttırabilir.Antikoagülan dozunun, 
protrombin zamanını normal düzeyde tutmak amacı ile azaltılması gerekebilir.

Anabolik steroidlerin glukoz tolerans testlerini değiştirdikleri gösterilmiştir.Diyabetik 
hastalar dikkatle izlenmeli, insülin veya hipoglisemik ilaç dozajı uygun şekilde 
ayarlanmalıdır.

Benign prostatik hipertrofili hastalarda anabolik steroidler dikkatle kullanılmalıdır. 
Androjenik anabolik steroidlerle tedavi edilen yaşlı erkek hastalar prostat hipertirofisi 
ve prostat karsinomunun gelişmesi bakımından daha yüksek bir risk altında bulunabilirler.

Androjenik, anabolik steroidlerle tedavi edilen hastalarda aterosklerozis ile birlikte 
görülen kan lipid değişiklikleri ortaya çıkabilmektedir. Bu değişikliklere örnek olarak 
yüksek yoğunluklu lipoproteinlerin azalması ve bazen düşük yoğunluklu lipoproteinlerin 
artması gösterilebilir.Bu değişiklikler önemli ölçüde fazla olabilir ve aterosklerozis 
ile koroner arter hastalığı için ciddi riskler doğurabilir.

Çocuklarda: 

Anabolik / androjenik steroidler çocuklarda çok dikkatli kullanılmalıdır.Anabolik ajanlar 
çocuklarda epifizeal matürasyonu lineer büyümeden daha hızlı bir şekilde 
çabuklaştırabilmekte ve bu etki ilaç bırakıldıktan sonra 6 ay devam edebilmektedir.
Bu nedenle tedavi 6 aylık aralarla alınan radyogramlar yardımıyla izlenmeli ve çocuğun 
yetişkin boya ulaşması güvence altına alınmalıdır.

Hamilelerde:

Gebelik kategoroisi X’tir.Hamilelerde ve hamile olması muhtemel olanlarda kullanılmamalıdır.
Anaboliklerin insan sütüne geçip geçmedikleri bilinmemektedir. İlacın doğurabileceği 
istenmeyen etkiler bebekte ortaya çıkabileceğinden emzikli anneler ilacı kullandıkları 
sürece bebeklerine süt vermemelidir.

Yan etkiler/ Advers etkiler:

Anabolik steroid tedavisinde ortaya çıkan en ciddi yan etki hepatotoksisitedir. Doğrudan 
doğruya doza bağlı olarak tedavinin erken döneminde BSP retansiyonunda geçici yükselme 
ortaya çıkar. Yalnız başına ya da serum alkalen fosfataz ve transaminazlarındaki(SGOT, SGPT)
yükselmelerle birlikte ortaya çıkan serum bilirubin yükselmesi daha ileri düzeyde bir itrah 
disfonksiyonunu gösterir. İlaç bırakıldığında geçici olarak klinik sarılık ortaya çıkabilir. 
Bu durumda histolojik bulgu, hücre hasarının bulunmadığı veya az miktarda bulunduğu 
intrahepatik kolestazdır. Tedaviye devam edilmesi halinde hepatik koma ve ölüm ortaya 
çıkabilir.

Anabolik steroid tedavisi ile birlikte en sık görülen yan etki virilizasyondur.Akne, bütün 
yaş gruplarında sıklıkla ortaya çıkar. Puberte öncesi erkek hastalarda ilk belirtiler fallik 
büyüme ve ereksiyon sıklığında artmadır. Hirsutizm ve deri pigmentasyonunda artma bulguları 
da görülebilir. Puberte sonrası erkek hastalarda, uzun süreli veya yüksek dozlarla yapılan 
anabolik tedaviler sırasında libide değişiklikleri, empotans, seminal hacim azalması ve 
oligospermi ile birlikte testis fonksiyonları inhibisyonu ortaya çıkabilir.Jinekomasti ve 
testis atrofisi de görülebilen yan etkilerdendir. Kronik priapizm, saç dökülmesi, 
epididimitis ve mesane irritabilitesi bildirilmiştir. Kadınlarda; hirsutizm, boğukluk ve 
derinden gelme gibi ses değişiklikleri, klitoral büyüme, libido değişiklikleri, adet 
düzensizlikleri ve erkek tipi kellik görülebilir.Ses değişiklikleri ve klitoral büyüme, 
tedavinin kesilmesinden sonra genellikle tamamen düzelir.

Anabolik / androjenik tedavi ile birlikte görülen diğer yan etkiler; 

Kas krampları, bulantı, eksitasyon, uykusuzluk, döküntü, antikoagülan ilaçlarla birlikte 
bu tedaviyi alan hastalarda kanama, epifizlerin çocuklarda erken kapanması, 
kusma ve ishaldir.

Oksimetolon ile tedavide fertilite bozukluğunun ortaya çıkması mümkündür.

İlaç etkileşimleri:

Tiroid fonksiyon testleri: PBI azalması, tiroksin bağlama kapasitesi ve radyoaktif 
iyot alımı azalması, eritrositler veya resin tarafından T3 alımı artması saptanabilir. 
Serbest tiroksin normaldir.Testlerdeki değişiklikler anabolik tedavinin durdurulmasından 
sonra genellikle 2 - 3 hafta daha devam edebilir.

Elektrolitler: Sodyum, klorür, su, potasyum fosfat ve kalsiyum retansiyonu görülebilir. 
Serum kolestrolünde artma veya azalma ortaya çıkabilir.Pıhtılaşma faktörlerinden II, V, 
VII ve X’un supresyonu, tedavinin terkedilmesinden sonra iki hafta kadar süren kreatin ve 
kreatinin itrahı artışı ve 17 - ketosteroid itrahı azalması görülebilir.

Uzun süreli androjenik ve anabolik steroid tedavi ile birlikte hepatosellüler neoplazmlar 
ve peliozis hepatis nadiren 
bildirilmiştir.

Kullanım şekli ve dozu:

Çocuk ve yetişkinlerde tavsiye edilen doz günde 1.5 mg/kg’dır. Genellikle etkin doz 
1-2 mg/kg/gün’dür, fakat daha yüksek dozlar gerekebilir. Doz hastanın durumuna göre 
ayarlanmalıdır.

Tedaviye cevap sıklıkla hemen görülmez ve tedavinin üç ila altı ay sürdürülmesi 
gerekebilir. Remisyondan sonra hastalardan bir kısmı ilaçsız idame ettirilebilir, 
diğer bir kısım hastaya ise daha düşük dozda devam edilebilir. Konjenital aplastik anemili 
hastalar için genellikle devamlı bir idame dozu gereklidir.


";

        }

        private void label5_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox1.ImageLocation = "eprex1.jpg";
            pictureBox2.ImageLocation = "eprex2.jfif";
            label4.Visible = true;
            label4.Text = @"
2000 Iu/ml 6 Flakon /4000 Iu/ml 6 Flakon /10000 Iu/ml 6 Flakon /0.3 Ml 3000 Iu 6 Hazır Şırınga 
/0.4 Ml 4000 Iu 6 Hazır Şırınga 

Formülü:
r-HuEPO parenteral uygulama için steril bir solüsyondur (şişe ve kullanıma hazır şırınga).

2000 IU/ml şişe : recombinant human erythropoietin, 16.8 mcg/ml, Albumin (Human) 
EP 2.5 mg/ml Sodyum, klorür, fosfat, enjeksiyonluk su k.m., Hacim 1.0 ml

2000 IU/0.5 ml şırınga : recombinant human
erythropoietin, 16.8 mcg/0.5 ml , Albumin (Human) EP 1.25 mg/0.5 ml Sodyum, klorür,
fosfat, enjeksiyonluk su k.m., Hacim 0.5 ml

4000 IU/ml şişe : recombinant human
erythropoietin, 33.6 mcg/ml Albumin (Human) EP 2.5 mg/ml, Sodyum, klorür, fosfat, 
enjeksiyonluk su k.m. Hacim 1.0 ml

4000 IU/0.4 ml şırınga : recombinant human
erythropoietin,33.6 mcg/0.4 ml Albumin (Human) EP 1.00 mg/0.4 ml Sodyum, klorür, fosfat, 
enjeksiyonluk su k.m. Hacim 0.4 ml

10000 IU/ml şişe : recombinant human
erythropoietin, 84 mcg/ml Albumin (Human) EP 2.5 mg/ml Sodyum, klorür, fosfat, 
enjeksiyonluk su k.m. Hacim 1.0 ml

Farmakolojik özellikleri:

Endikasyonları:

- Kronik böbrek yetmezliği eşliğindeki semptomatik veya transfüzyon gerektiren aneminin 
tedavisinde,

- Kemoterapi uygulanan kanser hastalarında aneminin önlenmesi ve tedavisinde.

Kontrendikasyonları:

Kontrol altına alınmamış hipertansiyonu olan hastalar ile bu preparatın herhangi bir 
bileşenine karşı aşırı hassasiyet göstermiş olanlarda kullanılmamalıdır.

Uyarılar/Önlemler:

r-HuEPO, sistemik vasküler hastalıklı, epilepsi nöbet hikayesi olanlarda dikkatle 
kullanılmalıdır. İlk deliller, hipertansif nöbetlerin (bazı vakalarda hipertansif 
ansefalopati ve epilepsi-konvülsiyon ile birliktedir) çoğunlukla çabuk Hb cevabı görülen 
vakalarda olduğunu telkin ettiğinden hastalar Hb, kan basıncı ve serum elektrolitlerindeki 
değişiklikler yönünden yakından takip edilmelidir. Hb'de ayda 2 g/dl'den az bir artış 
tavsiye edilir. Kan basıncı yükselmeye başlar veya baş ağrısı eşliğinde olursa daha güçlü 
antihipertansif tedavi uygulanmalıdır.

r-HuEPO, epilepsi, trombositoz ve kronik karaciğer yetmezliğinde dikkatli kullanılmalıdır. 
B12 vitamini ve folik asit eksikliği r-HuEPO etkinliğini azalttığı için ortadan 
kaldırılmalıdır.

r-HuEPO tedavisi gören bütün hastalarda stabil bir düzeye ulaşana kadar en azından haftalık 
hemoglobin düzeyleri ölçülmeli ve daha sonra buna periodik olarak devam edilmelidir. 
Aneminin düzelmesi iştah artmasına ve potasyum alımının artmasına yol açabilir. 
Diyalizdeki hastalarda hiperkalemi oluşursa diyet ve diyaliz reçetesi uygun olarak 
düzenlenmelidir.

Birçok vakada, serum ferritin seviyeleri hücre hacmi artışı ile aynı anda düşmektedir. 
Bu sebeple transferin saturasyon indeksi % 20'nin altında ve serum ferritin seviyesi 
100 ng/ml'nin altında olan her hastada demir tedavisi önerilmektedir.

(Kronik böbrek yetmezliği hastalarında, Eprex veya diğer eritopoiteinlerle tedaviden aylar, 
yıllar sonra çok nadiren saf kırmızı hücre aplazisi (eritroblastopeni)bildirilmiştir.
Bu hastaların çoğunda, eritropoiteinlere karşı antikor gözlenmiştir.İlaç etkisinde ani azalma 
gelişen hastalarda cevapsızlığın tipik nedenleri(örneğin; demir, folik asit, vitamin B12 
eksikliği, alüminyum intoksikasyonu, infeksiyon veya inflamasyon, kan kaybı ve hemoliz) 
araştırılmalıdır.Hiçbir neden belirlenmiyorsa, kemik iliği incelemesi dikkate alınmalıdır.
Saf kırmızı hücre aplazisi teşhis edilirse, eritropoietin antikorları için tahlil yapılmalı 
ve Eprex tedavisi kesilmelidir. Hstalara başka bir eritropoitein verilmemelidir.Saf kırmızı 
hücre aplazisinin diğer nedenleri araştırılmalı ve uygun tedaviye başlanmalıdır)

GEBELİK ve LAKTASYON SÜRESİNCE KULLANIMI:

r-HuEPO gebelik ve laktasyon süresince sadece olası yarar fetus üzerine olası riskten önemli 
ise uygulanmalıdır.

r-HuEPO'nun gebe bir kadına verildiğinde fetal zarara sebep olup olmadığı ve üreme kapasitesini 
etkileyip etkilemediği bilinmemektedir.

Yan etkiler/Advers etkiler:

Kronik böbrek yetmezliği

Baş ağrısı, eklem ağrıları, halsizlik, baş dönmesi, yorgunluk gibi grip benzeri semptomlar 
özellikle tedavinin başlangıcında görülebilir. r-HuEPO tedavisi sırasında en sık görülen 
istenmeyen etki doza bağlı olarak kan basıncının yükselmesi veya mevcut hipertansiyonun 
şiddetlenmesidir. Doktorun acil müdahalesi ve yoğun tıbbi bakımı gerektiren, ansefalopatiye 
benzer belirtiler ile (örneğin; baş ağrısı ve konfüzyon durumu) hipertansif krizler ve jeneralize 
tonik-klonik nöbetler normal veya düşük tansiyonlu izole hastalarda bile ortaya çıkabilir. 
Aniden ortaya çıkan migren-benzeri baş ağrıları olası bir uyarı sinyalı olabileceğinden dikkat 
edilmelidir. Başlangıçta normal sınırlar içinde doza bağlı orta şiddette trombosit sayısında 
artma olabilirse de tedavinin devamında gerilemektedir. Trombositoz gelişmesi çok nadirdir. 
r-HuEPO tedavisi sırasında dolaşan hücre hacminin artmasına bağlı olarak sıklıkla hemodiyaliz 
esnasında heparin dozunda artma gerekebilir. Heparinizasyon optimum seviyede değil ise diyaliz 
sisteminde tıkanmalar oluşabilir. Özellikle, hipotansiyona yatkınlığı olanlarda veya arterio-venöz 
fistülünde komplikasyonu (örneğin; stenoz, anevrizma) olanlarda fistül trombozu oluşabilir.

(Kronik böbrek yetmezliği hastalarında Eprex veya diğer eritropoiteinlerle tedaviden aylar, 
yıllar sonra çok nadiren saf kırmızı hücre aplazisi (eritroblastopeni) bildirilmiştir. 
Bu hastaların çoğunda, eritropoiteinlere karşı antikor gözlenmiştir)

Kanser hastaları
Her ne kadar klinik çalışma raporlarında, hipertansiyon insidansının Eprex® (%5) ve plasebo 
(%4) da benzer olduğu rapor edilmişse de, şahsi vaka hikayeleri göstermiştir ki hemoglobinde 
anlamlı artış görülen bazı hastalarda hipertansiyon oluşabilir.

İlaç etkileşimleri:
r-HuEPO tedavisinin, diğer ilaçların metabolizması üzerinde etkisi olduğuna dair bulgu yoktur. 
Ancak, siklosporin, kırmızı kan hücrelerine bağlandığı için ilaç etkileşimi ihtimali vardır. 
Eğer r-HuEPO siklosporin ile birlikte uygulanacak ise; siklosporin kan seviyesi monitorize 
edilmeli ve siklosporin dozu hematokrit yükselmesine göre ayarlanmalıdır.


            ";
        }

        private void label6_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox1.ImageLocation = "supradyn1.jpg";
            pictureBox2.ImageLocation = "supradyn2.jpg";
            label4.Visible = true;
            label4.Text = @"
Formülü:

Bir lak tablet
A vit. 4000 I.U., B1 1.6 mg, B2 1.8mg, B6 2.6 mg, B12 4 mcg, C 100 mg, D2 500 I.U., E 15 I.U., 
D-biotin 0.2 mg, Ca-pantotenat 10 mg, Folik asit 0.8 mg, Nikotinamid 19 mg , Kalsiyum 125 mg, 
Demir 60 mg, Magnezyum 100 mg, Fosfor 125 mg, Bakır 1 mg, Mangan 1 mg, Çinko 7.5 mg

Farmakolojik özellikleri:

Endikasyonları:

Gebelik ve emzirme döneminde artan gereksinim ve yetersiz alım sonucunda ortaya çıkabilen
genel vitamin ve mineral eksikliklerinin önlenmesi ve tedavisinde; Nöral tüp defektleri ve 
doğumsal anomalilerin profilaksisinde; Gebelik anemisine karşı artan demir ve folik asit 
ihtiyacını karşılamak.

Kontrendikasyonları:

Supradyn Pronatal, A ve/veya D hipervitaminozu bulunan vakalarda, böbrek fonksiyon bozukluğu 
olan hastalarda, demir birikiminin ya da demir demir kullanım bozukluğunun söz konusu olduğu 
bireylerdde, hiperkalsemi ya da hiperkalsiürili vakalarda ve ilacın içerdiği bileşenlerden bir 
ya da birkaçına alerjisi olduğu bilinen kişilerde kullanılmamalıdır.

Uyarılar/Önlemler:

Supradyn Pronatal, önerilen dozlarda kullanılmalıdır. Yüksek dozlarda alındığında 
hipervitaminoza yol açabilceği unutulmamalıdır. Başka vitamin ihtiva eden preparatlarla 
beraber doktora danışılmadan kullanılmamalıdır. 

Gebelik Emzirme Döneminde Kullanımı:
Supradyn Pronatal gebel ve emzirme döneminde endikedir.

Yan etkiler/Advers etkiler:

Supradyn Pronatal iyi tolere edilir. Nadir vakalarda gastrointestinal bozukluklar olabilir. 
(örneğin kabızlık), ancak bunlar genellikle tedavinin kesilmesini gerektirmez.

İlaç etkileşimleri:

Birbirlerinin emilimlerini bozabileceklerinden, demir içeren preparatlar tetrasiklinler ile 
aynı zamanda kullanılmaları gerekiyorsa, her iki ilacın alınması sırasında yaklaşık iki saatlik
bir zaman farkı olmalıdır.

Kullanım şekli ve dozu:

Doktor tarafından başka bir şekilde tavsiye edilmediği taktirde; Yetişkinlerde günde bir tablet 
kahvaltı ile birlikte alınmalıdır. Hastanın sabahları hiperemezisi varsa, tabletlerin öğle vakti 
veya gerekirse akşam alınması gerekir. Doz Aşımı: Supradyn Pronatal'da bulunan besinsel vitamin 
ve mineral dozlarında doz aşımı riski yoktur.ancak gebelik süresince bazı esansiyel besinler 
yüksek miktarlarda alınmamalıdır.






";
        }

        private void label7_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox1.ImageLocation = "evigen1.png";
            pictureBox2.ImageLocation = "evigen2.jfif";
            label4.Visible = true;
            label4.Text = @"
Farmakolojik özellikleri:

Endikasyonları:

E vitamini gereksiniminde kullanılır. Prematürler ve yeni doğanlarda görülen hemolitik anemiler, 
malnütrasyona bağlı anemiler, malabsorbisyonla bbirlikte olan anemiler, akantositoz halinde 
oluşan hemolitik anemi, kas distrofilleri, düşük kardiyovasküler rahatsızlıklar, azospermi ve 
üretrim organları disfonksiyonunda endikedir.

Kontrendikasyonları:

Uyarılar/Önlemler:

Enjeksiyonların damar içine yapılmamasına gereken özen gösterilmelidir.

Yan etkiler/Advers etkiler:

Bulantı, yorgunluk, güçsüzlük, bulanık görme, keratinüri ve gonad defekti gibi yan etkiler 
görülebilir.

İlaç etkileşimleri:

Prevantif ve tedavi dozlarında alınan E vitamini, Avitamininin absorbsiyonunu artırmakla 
birlikte, yüksek dozlarda bu etkinin ters olduğu ve absorbsiyonu azalttığı bilinmektedir. 
E vitamininin anti-K vitamini etkisi olduğu ve bu nedenle yüksek doz E vitamini uygulamalarının 
kanama riskini artırabileceği göz önünde bulundurulmalıdır.

Kullanım şekli ve dozu:

Günde 1 ampul intramüsküler(kas içi) yoldan uygulanır.




";
        }

        private void label8_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox1.ImageLocation = "epargriseovit1.jpeg";
            pictureBox2.ImageLocation = "epargriseovit2.jpg";
            label4.Visible = true;
            label4.Text = @"
Formülü:

Ampul Tip I (Kırmızı solüsyon) :

B12 vitamini 2.5 mg,
Folik asid 0.7 mg,
PP vitamini 12 mg,

Ampul Tip II (renksiz solüsyon) :

C vitamini 150 mg ihtiva eder.

Farmakolojik özellikleri:

Endikasyonları:

Pernisiyöz anemide,
Ameliyat sonrası ve nekahat dönemi gibi organizmada yıkım meydana getiren durumlarda,
Proteinden fakir beslenme halleri ile gastrektomi ve malabsorbsiyon sonucu oluşan B12 vitamini 
eksikliklerinde B12 vitamini eksikliğinden kaynaklanan diğer hiperkrom makrositer anemilerin 
tedavi ve proflaksisinde B12 vitamininin yüksek miktarlarda bulunması sebebiyle, nevraljilerde 
ve trigeminus nevraljilerinde.

Kontrendikasyonları:

Fenitoin, fenitoin ya da diğer hidantoinlere aşırı duyarlılığı olan hastalarda kontrendikedir.
Ventriküler otomatisite üzerindeki etkisi nedeniyle fenitoin sinüs bradikardisi, sino-atriyal
blok, ikinci ve üçüncü derece A-V blok ve Adams-Stokes sendromu olan hastalarda 
kontrendikedir.

Uyarılar/Önlemler:

Sodyum salisilat, sodyum nitrat, teobromin ve metenaminle birlikte kullanılmamalıdır.

Yan etkiler/Advers etkiler:

Bu ilacın intravenöz kullanımıyla bağlantılı en önemli toksisite belirtileri kardiyovasküler
kollaps ve/veya merkez sinir sistemi depresyonudur. İlaç intravenöz yolla hızla uygulandığında
hipotansiyon meydana gelir. Uygulama hızı çok önemlidir, erişkinlerde dakikada 50 mg'yi ve
yenidoğanlarda dakikada 1-3 mg/kg'ı geçmemelidir. Bu hızla toksisite minimum düzeyde olacaktır.

Kardiyovasküler Sistem: Atriyal ve ventriküler ileti depresyonu ve ventriküler fibrilasyon ile 
ciddi kardiyotoksik reaksiyonlar ve ölümler bildirilmiştir. Ağır komplikasyonlar en sık yaşlı 
ya da ciddi hastalık tablosunda olanlarda görülür.

Merkezi Sinir Sistemi: Fenitoin tedavisinde en sık karşılaşılan belirtiler bu sistemle 
ilgilidir ve genellikle dozla ilişkilidir. Bunlardan bazıları nistagmus, ataksi, konuşmada 
güçlük, koordinasyon azalması ve mental konfüzyondur.
Baş dönmesi, uykusuzluk, geçici sinirlilik, motor seğirmeler ve baş ağrısı de gözlemlenmiştir. 
Ayrıca seyrek de olsa, fenotiazin ve diğer nöroleptik ilaçların neden oldukları kore, distoni, 
tremor ve asteriksise benzer, fenitoine bağlı diskinezi bildirilmiştir.

Uzun süreli fenitoin tedavisi uygulanan hastalarda baskın duyusal periferik polinöropati 
gözlemlenmiştir.

Gastrointestinal Sistem: 

Bulantı, kusma, kabızlık, toksik hepatit ve karaciğer hasarı (Bkz Uyarılar/Önlemler).

Deri ve Ekleri:

Skarlitiniform veya morbiliform döküntüleri de içeren ve bazen ateşin eşlik ettiği
dermatolojik belirtiler. En sık morbiliform döküntü (kızamık benzeri) görülür, diğer tip 
dermatitler daha seyrek görülür. Ölüme yol açabilecek daha ciddi diğer formlar büllü, 
eksfolyatif ya da purpuralı dermatit, lupus eritematosus, Stevens-Johnson sendromu ve toksik 
epidermal nekrolizdir (Bkz Uyarılar/Önlemler).

Hemopoetik Sistem: 

Fenitoin uygulanmasına bağlı zaman zaman bazıları ölümcül olabilen hemopoetik komplikasyonlar 
bildirilmiştir. Bunlardan bazıları trombositopeni, lökopeni, granülositopeni, agranülositoz 
ve kemik iliği baskılanması ile beraber ya da tek başına seyreden pansitopenidir.
Makrositoz ve megaloblastik anemi meydana geldiğinde, bu durumlar genellikle folik asit
tedavisine yanıt verir (Bkz Uyarılar/Önlemler). Benign lenf düğümü hiperplazisi, psödolenfoma, 
lenfoma ve Hodgkin hastalığı gibi lenfadenopati bildirilmiştir (Bkz Uyarılar/Önlemler).

Bağdoku Sistemi: 

Yüz hatlarında kabalaşma, dudaklarda büyüme, gingiva hiperplazisi, hipertrikoz ve Peyronie 
hastalığı.

Enjeksiyon Bölgesi: 

İntravenöz fenitoinin damar dışına çıkmasıyla ya da çıkış olmadan lokal iritasyon, inflamasyon, 
duyarlılık, nekroz ve deride dökülme bildirilmiştir.

Immünolojik: 

Aşırı duyarlılık sendromu (artraljiler, eozinofili, ateş, karaciğer işlev bozukluğu, 
lenfadenopati ya da döküntü gibi semptomlar içerir, ancak bunlarla sınırlı değildir), 
sistemik lupus eritematosus, periarteritis nodosa ve immün globülin anormallikleri meydana 
gelebilir. Hala seyrek de olsa, bir kaç bireysel vaka bildirimi siyahlarda deride döküntü
ve hepatotoksisite dahil aşırı duyarlılık reaksiyonlarının insidansının, artmış olabileceğini 
düşündürmektedir.

İlaç etkileşimleri:

İlaç Etkileşimleri

Serum fenitoin düzeylerini artıran ya da azaltan ya da fenitoinin etkileyebileceği pek çok 
ilaç vardır. Serum fenitoin konsantrasyonlarının belirlenmesi özellikle olası ilaç 
etkileşimlerinden şüphelenildiğinde önem taşır. En sık meydana gelen ilaç etkileşimleri 
aşağıda belirtilmiştir.

1. Fenitoinin serum düzeylerini artırabilecek ilaçlardan bazıları akut alkol kullanımı, 
dikumarol, disulfiram, metilfenidat, omeprazol, tiklopidin ve viloksazindir. 
Aşağıdaki ilaç sınıfları da dahildir.

İlaç Sınıfları, Her Sınıftaki İlaçlar (örnek)şeklinde
analjezik / antiinflamatuar ajanlar; Azapropazon,
Fenilbutazon, Salisilatlar
Anestezikler; Halotan
Antibakteriyel ajanlar; Kloramfenikol, Eritromisin,İzoniazid,Sulfonamidler
Antikonvülsanlar; Felbamat, süksinimidler
Antifungal ajanlar; Amfoterisin B,Flukonazol,
Ketokonazol,Mikonazol,İtrakonazol
Benzodiazepinler / psikotrop ajanlar; Klordiazepoksit,Diazepam Trazodon
Kalsiyum kanal blokerleri / kardiyovasküler ajanlar; Amiodaron Diltiazem,Nifedipin
H2-antagonistleri;
Hormonlar; Östrojenler
Oral hypoglisemik ajanlar; Tolbutamid
Serotonin geri alım inhibitörleri; Fluoksetin

2. Fenitoinin serum düzeylerini düşürebilecek ilaçlardan bazıları antibakteriyel 
ajanlar/florokinolonlar (siprofloksasin ve rifampin gibi), kronik alkol kullanımı, 
diazoksit, rezerpin, sükralfat, teofilin ve vigabatrindir.

Molindon hidroklorür fenitoinin emilimini bozan kalsiyum iyonları içerir. Emilim 
sorunlarının önüne geçmek için, kalsiyum içeren antasit preparatları dahil kalsiyum 
preparatları ile fenitoinin alım zamanları buna göre ayarlanmalıdır.

3. Fenitoinin serum düzeylerini artırabilen ya da azaltabilen ilaçlardan bazıları şunlardır.

İlaç Sınıfları Her Sınıftaki İlaç (örnek) şeklinde
Antikonvülsanlar; karbamazepin, fenobarbital
sodyum valproat,valproik asit
Antineoplastik ajanlar;
benzodiazepinler,fenotiazinler,psikotrop ajanlar; klordiazepoksit,diazepam

Bunun gibi, fenitoinin karbamazepin, fenobarbital, valproik asit ve sodyum valproatın
serum düzeyleri üzerindeki etkileri önceden tahmin edilememektedir.

4. Gerçek bir ilaç etkileşimi olmasa da, trisiklik antidepresanlar duyarlı hastalarda 
konvülsiyonları başlatabilir ve fenitoin dozunun ayarlanması gerekebilir.

5. Kandaki düzeyleri ve/veya etkileri fenitoin tarafından değiştirilebilecek ilaçlardan 
bazıları klozapin, kortikosteroidler, kumarin grubu antikoagülanlar, siklosporin, diazoksit, 
furosemid, lamotrigin, paroksetin, teofilin ve vitamin D'dir. Aşağıdaki ilaç sınıfları da 
dahildir.

İlaç Sınıfları; Her Sınıftaki İlaçlar (örnek) şeklinde

Antibakteriyel ajanlar; Doksisiklin,prazikuantel,
rifampin,tetrasiklin
Antifungal ajanlar; Antineoplastik ajanlar;
Kalsiyum kanal blokerleri / kardiyovasküler ajanlar; Dijitoksin,Nikardipin,Nimodipin,Kinidin,
Verapamil
Hormonlar; Östrojenler,Oral kontraseptifler
Nöromüsküler blok yapan ajanlar; alkuronyum,
pankuronyum,vekuronyum
opioid analjezikler; metadon
Oral hipoglisemik ajanlar; klorpropamid,glibürid
tolbutamid

İlaç Enteral Beslenme/Beslenme Preparatları Etkileşimi
Literatürde bildirilen vakalar enteral beslenme preparatları ve/veya benzeri beslenme 
takviyeleri verilen hastalarda fenitoinin plazma düzeylerinin beklenenden daha düşük 
olduğunu düşündürmektedir. Bu nedenle fenitoinin enteral beslenme preparatlarıyla birlikte 
uygulanmaması önerilir.
Bu hastalarda serumdaki fenitoin düzeyinin daha sık izlenmesi gerekebilir.

İlaç-Laboratuvar Testi Etkileşimleri
Fenitoin serumdaki proteine bağlı iyot (PBİ) düzeylerinin azalmasına neden olabilir. 
Ayrıca deksametazon ya da metirapon testlerinde değerlerin normalden düşük çıkmasına da yol 
açabilir. Fenitoin serum glukoz, alkali fosfataz ve gama glutamil transpeptidaz (GGT) 
düzeylerinin yükselmesine neden olabilir. Fenitoin kan kalsiyumu ve kan şekeri metabolizma 
testlerini etkileyebilir.

Kullanım şekli ve dozu:

Kırmızı ve renksiz ampullerden birer adedi aynı enjektöre çekilerek hekim tavsiyesine göre 
intramüsküler olarak verilir.

Erişkinlere:

Haftada 2-3 enjeksiyon yapılır.
Ağır ve özel durumlarda günde 1-2 enjeksiyona kadar çıkabilir.

Çocuklarda:

Doz hekim tavsiyesine göre ayarlanır.


";
        }

        private void label9_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox1.ImageLocation = "tribeksol1.jpg";
            pictureBox2.ImageLocation = "tribeksol2.jpg";
            label4.Visible = true;
            label4.Text = @"
Formülü:

Her film tablet;
Vitamin B1 250 mg
Vitamin B6 250 mg
Vitamin B12 1 mg
ihtiva eder.

Farmakolojik özellikleri:

Endikasyonları:

* Nevrit ve polinevritlerde,
* Trigeminus nevraljisinde
* Siyatikte,
* Beriberi ve beriberiye bağlı nörolojik, kardiovasküler ve gastrointestinal semptomlarda,
* Kronik alkoliklerde ve bu şahıslarda alkole bağlı olarak ortaya çıkan merkezi sinir sistemi 
ve kardiovasküler sistem semptomlarında,
* Pernisiyöz anemide,
* Hiperkrom makrositer anemide
* Hipokrom anemide
* B1, B6 ve B12 vitaminlerine ihtiyacın arttığı nekahat dönemlerinde,
* Aşırı stres hallerinde,
* Uzun süre geniş spektrumlu antibiyotik veya diüretik kullananlarda,
* Vitamin absorbsiyonunu etkileyen gastrointestinal bozukluklarda,
* Gebelik dönemlerinde
endikedir.

Kontrendikasyonları:

İlaca bağlı hiperkalemi gelişmesi, azotemi, anüri ve oligoürinin artması ile ilerleyen renal
yetmezliklerde kontrendikedir.

Uyarılar/Önlemler:

L dopa ile birlikte kullanılmaz. INH, sikloserin ve oral kontraseptifler, B6 vitamini 
gereksinimini arttırır.

Yan etkiler/Advers etkiler:

Allerjik reaksiyonlar, ağız kuruluğu, baş ağrısı ve adale krampları gibi yan etkiler görülebilir.

İlaç etkileşimleri:

Levotiroksin, dekstrotiroksin, liotironin ve TRIAC gibi diğer tiroid hormonları
analogları, TRH-testlerinde TSH'nin doza bağımlı artışını engeller.
Glukokortikoidler, somatostatin, dopamin, bromokriptin, lisurid, levodapa, salisilatlar,
morfin ve röntgen kontrast maddeleri ile artış azalır; GnRH, GH-RH, CRH, östrojen,
klomifen, spironolakton, iyodür, amiodaron, lityum, teofilin, metoklopramid,
domperidon, sülpirid, klorpromazin, biperidin, haloperidol veya prostaglandinler ile
aynı zamanda verildiğinde artış biraz fazlalaşabilir. Ancak bu etkileşimlerden dolayı
testin yorumlanması ancak nadir durumda bozulabilir.

Kullanım şekli ve dozu:

Normal doz günde 1 film tablettir.

Bu doz gereğinde hekim tarafından arttırılabilir.



";
        }

        private void label10_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox1.ImageLocation = "desferal1.jpeg";
            pictureBox2.ImageLocation = "desferal2.jfif";
            label4.Visible = true;
            label4.Text = @"
Formülü:

Bir flakon 500 mg enjeksiyonluk kuru aktif madde (deferoksamin metansülfonat)
içermektedir.

Farmakolojik özellikleri:

Endikasyonları:

1- Tedavi amacıyla
Kronik demir birikiminde demir kelasyonu monoterapisi için örneğin;
• Transfüzyon hemosiderozu; talasemi major, sideroblastik anemi, otoimmün
hemolitik anemi ve diğer kronik anemilerde;
• Flebotomiyi engelleyen hastalıkların (şiddetli anemi, kalp hastalıkları, hipoproteinemi
gibi) eşlik ettiği idyopatik (primer) hemokromatozda;
• Flebotomiyi tolere edemeyen hastalarda porfiria kutanea tarda ile bağlantılı demir
birikiminde.

Akut demir zehirlenmesinin tedavisinde.
Son dönem böbrek yetersizliği olan (idame diyaliz uygulanan)
• Alüminyumla ilişkili kemik hastalığı,
• Diyaliz ensefalopatisi veya
• Alüminyumla ilişkili anemisi olan hastalardaki kronik alüminyum birikimi tedavisinde.

2- Tanı amacıyla
Demir ve alüminyum birikiminin tanısında kullanılır.

Kontrendikasyonları:

Başarılı desensitizasyonun tedaviyi mümkün kıldığı vakalar dışında etken maddeye
karşı bilinen aşırı duyarlık.

Uyarılar/Önlemler:

Hızlı intravenöz infüzyon hipotansiyon ve şoka (örn. deride kızarma, taşikardi, kollaps
ve ürtiker gibi) yol açabilir.

Yüksek Desferal dozları, özellikle plazma ferritin düzeyleri düşük olan hastalarda görme
ve işitme bozukluklarına yol açabilir (Bkz. Yan Etkiler/ Advers Etkiler). Böbrek
yetersizliği nedeni ile idame diyalizi uygulanan ve ferritin düzeyleri düşük olan hastalar
advers reaksiyonlara özellikle yatkın olabildiklerinden bir tek Desferal dozu ile bile
görme bozukluğu belirtileri bildirilmiştir.Tedavi düşük dozda uygulandığında yan etki
riski azaltılır. Görsel veya işitsel bozukluklar görüldüğünde, ilacın kullanılmasına hemen
son verilmelidir.Desferal'in neden olduğu değişiklikler, erken tanınması halinde
genellikle geri dönüşümlüdür.Daha sonra Desferal tedavisine daha düşük dozla, görme
ve işitme işlevleri yakından izlenerek yeniden başlanabilir.
Metal kompleksin yaklaşık yarısı, böbrek işlevi normal olan aşırı demir yüklü hastalarda
böbrekler yoluyla atılır. Bu nedenle, ciddi böbrek yetmezliği olan hastalarda dikkatli
olmak gerekir.Deferoksaminin demir ve alüminyum kompleksleri vücuttan diyalizle
uzaklaştırılabilir; böbrek yetmezliği olan hastalarda bunların vücuttan uzaklaştırılması,
diyaliz nedeniyle artabilir.

Yüksek Desferal dozları ile ferritin düzeyleri düşük olan, ya da genç yaştaki (tedavi
başlangıcında 3 yaşın altındaki) hastalarda büyüme geriliği ile ilişki bulunmuştur (Bkz.
Kullanım Şekli ve Dozu: Kronik demir birikmesinde tedavi). Büyüme geriliği eğer
Desferal'in aşırı dozları ile ilişkili ise bunun aşırı demir yüklemesi ile ilişkili olandan
ayırıcı tanısı yapılmalıdır.Doz 40 mg / kg'ın altında tutulabilirse Desferal ile büyüme
geriliği çok nadirdir; büyüme geriliği bu değerin üzerindeki dozlarla ilişkilendirilmiş ise
dozun azaltılmasından sonra büyüme hızı, bazı hastalarda tedavi öncesi düzeylere
dönebilir, ancak beklenen erişkin boyuna ulaşılamaz.
Akut demir zehirlenmesi olan hastalarda ve talasemi hastalarında da intravenöz yoldan
çok yüksek Desferal dozları ile tedaviyi takiben akut respiratuvar distres sendromu
bildirilmiştir.Bu nedenle önerilen günlük dozlar aşılmamalıdır.
Aşırı demir yüklemesi olan hastalarda Desferal'in, özellikle Yersinia enterocolitica ve
Yersinia pseudotuberculosis ile olan enfeksiyonlara duyarlılığı arttırabileceği
bildirilmiştir.Desferal tedavisindeki bir hastanın ateşi akut enterit / enterokolit, yaygın
abdominal ağrı veya farenjitle birlikte yükselirse, tedavi geçici olarak kesilmeli,
bakteriyolojik testler yapılmalı ve uygun antibiyotik tedavisine bir an önce başlanmalıdır.
Enfeksiyon iyileştikten sonra, Desferal tedavisine tekrar başlanabilir.
Demir ve/ veya alüminyum birikimi nedeniyle Desferal alan hastalarda, ciddi bir mantar
enfeksiyonu olan mukormikoz vakaları çok nadiren bildirilmiştir.Enfeksiyon şüphesi
doğuran herhangi bir belirti veya semptom karşısında Desferal tedavisi durdurulmalı,
mikolojik testler yapılmalı ve hemen gerekli tedaviye başlanmalıdır.Mukormikozun Desferal 
kullanmayanlarda da görülebilmesi, bu enfeksiyonun gelişmesinde diyaliz,
diabetes mellitus, asit - baz dengesi bozuklukları, hematolojk maliniteler,
immünosupressif ilaçlar veya diğer faktörler nedeniyle bağışıklık sisteminin yetersizliği
gibi daha başka etmenlerin de rol oynayabileceğini göstermektedir.
Demir kompleksi atılırken, idrarın kırmızımsı-kahverengi olmasına yol açabilir.
Desferal önerileni aşan dozlarda uygulanmamalıdır.İlaç % 10'u aşan
konsantrasyonlarda subkutan olarak verilmemelidir, çünkü lokal reaksiyon riski artar
(Bkz.Kullanım talimatları). İntramusküler uygulamanın yegane seçenek olması halinde
enjeksiyonu kolaylaştırmak için daha yüksek konsantrasyonların uygulanması
gerekebilir.

Önerilen %10'luk konsantrasyonlarda hazırlanmış solüsyon berrak, veya renksiz ya da
hafif sarımsı olabilir. Sadece berrak olan solüsyonlar uygulanabilir. Opak ya da bulanık
solüsyonlar atılmalıdır. Enjeksiyon tekniğine çok dikkat edilmelidir.
Subkutan infüzyon uygulamada iğne dermise çok yakın sokulmamalıdır.
Şiddetli kronik demir birikimi olan hastalarda, Desferal ve yüksek dozlarda (günde 500
mg'ın üzerinde) C vitamininin birlikte kullanılması ile kalp fonksiyon bozukluğu
bildirilmiştir. Kalpte fonksiyon bozukluğu C vitamininin kesilmesi ile geri dönüşümlüdür.
Desferal ve C vitamininin birlikte kullanılması gereğinde şu noktalara dikkat edilmelidir:
• Kalp yetmezliği olan hastalara C vitamini takviyesi verilmemelidir.
• C vitamini ile tedaviye, ancak 1 aylık düzenli Desferal tedavisinden sonra
başlanmalıdır.
• C vitamini yalnızca Desferal'i düzenli olarak kullanan hastalara ve ideal olarak da
pompanın hazırlanmasından hemen sonra verilmelidir.
• Günlük C vitamini, bölünmüş dozlarda toplam 200 mg 'ı aşmamalıdır.
• Bu gibi kombinasyon tedavisi sırasında kalp fonksiyonunun izlenmesi önerilir.
Desferal tedavisine başlanmadan önce oftalmolojik ve odyolojik muayeneler uzmanları
tarafından yapılmalı ve tedavi sırasında, özellikle ferritin düzeyleri düşük ise, düzenli
aralıklarla (her 3 ayda bir) tekrarlanmalıdır. Ortalama günlük Desferal (mg/kg) dozunun,
serum ferritinine (µg/L) bölümüm oranının 0.025'in altında olması ile talasemi
hastalarında odyometrik anormallik riski azaltılabilir.
Desferal alan pediyatrik hastalar vücut ağırlığı ve boy uzaması açısından her 3 ayda bir
izlenmelidir.
Alüminyumla bağlantılı ensefalopatisi olan hastalarda yüksek Desferal dozları,
muhtemelen dolaşımdaki alüminyum miktarının birdenbire artması nedeniyle nörolojik
fonksiyon bozukluğunu (nöbetler) şiddetlendirebilir. Desferal, diyaliz demansının
başlamasına zemin hazırlayabilir. Klonazepam ile ön tedavinin, bu nörolojik
kötüleşmeye karşı koruma sağladığı bildirilmiştir. Alüminyum birikiminin tedavisi, serum
kalsiyum düzeyinin azalmasına ve hiperparatiroidinin şiddetlenmesine yol açabilir.
GEBELİK VE EMZİRME
Bugüne kadar, gebelikleri sırasında Desferal tedavisi uygulanan tüm kadınlardan doğan
çocuklarda herhangi bir malformasyon görülmemiştir. Gebelik sırasında Desferal,
özellikle ilk 3 aylık dönemde, ancak zorunlu ise kullanılmalıdır.

Deferoksaminin anne sütüne geçip geçmediği bilinmemektedir. Her vakada annenin
elde edeceği yarar, çocuğun karşılaşabileceği riskle dengelenmelidir.
Araç ve Makine Kullanma Yeteneği Üzerine Etkileri
Sersemlik veya diğer merkezi sinir sistemi bozuklukları gelişen ya da görme/işitme
bozuklukları ortaya çıkan hastalar, araç ve makine kullanmaktan kaçınmalıdır 
(bkz.Yan Etkiler/ Advers Etkiler).

Yan etkiler/Advers etkiler:
Sıklık skalası: Çok sık ≥ %10; sık olarak ≥ %1 - <%10; seyrek olarak ≥ % 0.1 - < %1;
ender olarak ≥ % 0.01 - < % 0.1; çok ender olarak < % 0.01.
Advers etki olarak bildirilen bulgu ve belirtilerin bazıları mevcut hastalığa (demir ve/veya
aluminyum yüklemesi) bağlı olabilir.

Lokal reaksiyonlar / bağlantılı sistemik reaksiyonlar: 
Çok sık enjeksiyon yerinde ağrı, şişlik, sertleşme, eritem, kaşıntı ve kabuk; sık olarak 
lokal ödem, yanma ve kabarcıklar. Lokal reaksiyonlara aşağıdaki sistemik reaksiyonlar eşlik 
edebilir: çok sık artralji/miyalji; sık olarak baş ağrısı, ürtiker, bulantı, ateş; seyrek 
olarak kusma, karın ağrısı veya astım.

Allerji:

Çok ender olarak şokla birlikte veya şok gelişmeksizin anafilaktik/anafilaktoid
reaksiyonlar, anjiyoödem.

Özel duyular :

Dozlar önerilen sınırlar içinde tutulursa ve ferritin düzeylerinin düşmesi
(Desferal' in ortalama günlük dozunun serum ferritinine oranı 0.025 in altında olmalıdır)
halinde dozlar da azaltılırsa, yüksek frekansta sensörinöral işitme kaybı ve tinitus
seyrektir; yüksek dozlar verilmediği takdirde ender olarak bulanık görme, görme
keskinliğinin azalması, görme kaybı, renk görme bozukluğu (diskromatopsi), gece
körlüğü (niktalopi), görme alanı defektleri, skotom, retinopati (retinada pigmenter
dejenerasyon), optik nevrit, kataraktlar (lens opasiteleri), korneal opasiteler
(Bkz. Uyarılar / Önlemler).

Deri : 

Çok ender olarak yaygın döküntü.

Kas-iskelet sistemi:

Büyüme geriliği ve kemiklerde değişikliklere (örn. metafiz
displazisi), 60 mg/kg ın üzerinde doz uygulanan kelasyon hastalarında, özellikle demir
kelasyonuna yaşamın ilk üç yılında başlananlarda sık rastlanır. Dozların 40 mg/kg ve
altında tutulması ile risk belirgin olarak azaltılabilir.

Solunum sistemi : 

Çok ender olarak akut respiratuvar distres sendromu (dispne,
siyanoz ve interstisyel infiltrasyonlarla birlikte) (bkz. Uyarılar / Önlemler).

Merkezi sinir sistemi: 
Çok ender olarak nörolojik bozukluklar, sersemlik, alüminyumla
ilişkili diyaliz ensefalopatisinin hızlanması ya da alevlenmesi, periferik duyusal, motor ya
da karışık nöropati, parestezi(bkz. Uyarılar/Önlemler).

Gastrointestinal sistem:

Çok ender olarak diyare.

Renal sistem: 

Çok ender olarak böbrek fonksiyon bozukluğu (bkz. Uyarılar/Önlemler).

Kardiyovasküler sistem : 
Desferal' in uygulanması ile ilgili önlemlere dikkat edilmemesi halinde hipotansiyon 
görülebilir (bkz. Kullanım şekli ve dozu ve Uyarılar/Önlemler).

Hematolojik sistem :

Çok ender olarak kan diskrazileri (örneğin trombositopeni).

Enfeksiyona duyarlılık: 

Çok ender olgularda Desferal tedavisi ile ilişkili olarak Yersinia ve Mukormikoz 
enfeksiyonları bildirilmiştir.

İlaç etkileşimleri:

Desferal ve bir fenotiyazin türevi olan proklorperazinin birlikte kullanımı geçici bilinç
bozukluklarına neden olabilir.
Şiddetli kronik demir depolama hastalığı olan, Desferal ve yüksek doz C vitamini (günde
500 mg'ın üzerinde) ile kombine tedavi uygulanan hastalarda kalp fonksiyon
bozukluğuna rastlanmıştır (bkz. Uyarılar / Önlemler). C vitamini kesildiğinde bu
bozukluk düzelmiştir.
Desferal'e bağlı galyum-67 izotopunun hızla idrara çıkarılması nedeniyle galyum-67
görüntüleme sonuçları bozulabilir.Sintigrafiden 48 saat önce Desferal tedavisinin
kesilmesi önerilir.

GEÇİMSİZLİKLERİ
- Enjeksiyonluk heparin çözeltisi.
-Serum fizyolojik(% 0.9) kuru aktif maddeyi çözmek için, çözücü olarak
kullanılmamalıdır; fakat aktif maddeyi enjeksiyonluk suda çözdükten sonraki
seyreltmeler için kullanılabilir.


            ";
        }

        private void label11_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox1.ImageLocation = "deksamet1.jfif";
            pictureBox2.ImageLocation = "deksamet2.jpg";
            label4.Visible = true;
            label4.Text = @"
0.05 Mg 100 Ml Şurup / 8 Mg 2 Ml 1 Ampul

Formülü:

Her bir ampulde:
8 mg deksametazon fosfata ekivalan deksametazon sodyum fosfat.

Kreatinin 16 mg
Sodyum sitrat 20 mg
Sodyum metabisülfit 2 mg
Metil paraben 3 mg
Propil paraben 0.4 mg
İnjeksiyonluk su k.m 2 ml

Şurup :
Beher ölçekte (5 ml)
Aktif madde :
Deksametazon 0.25 mg
Yardımcı maddeler :
Etil alkol, şeker, nipajin-M, nipazol, portakal esansı.

Farmakolojik özellikleri:

Endikasyonları:

Ampul :

İntravenöz ve intramüsküler enjeksiyon ile :

Endokrin Hastalıklar :
Konjenital adrenal hiperplazi, nonsuppuratif tiroidit, kansere bağlı hiperkalsemi, 
primer ve sekonder adrenokortikal yetmezlikte (mineralokortikoidlere yardımcı olarak), 
kut adrenokortikal yetmezlikte (mineralokortikoidlere yardımcı olarak), ciddi bir travma 
veya hastalık durumunda adrenal yetmezliği olan veya adrenokortikal rezervi dolu olan 
hastalarda ameliyat öncesinde, standart tedaviye cevap vermeyen şok vakalarında.

Romatizmal Hastalıklar :

Aşağıdaki hastalıkların akut hecmelerinde kısa süreli tedavi olarak: Posttravmatik
osteoartrit, sinovit, romatoid artrit, juvenil romatoid artrit, akut ve subakut bursit,
epikondilit, akut nonspesifik tenosinovit, psöriatik artrit, akut gut artriti, ankilozan 
spondilit.

Kollagen Hastalıkları :

Alevlenme durumunda ya da idame tedavisi olarak sistemik lupus eritematosus, akut romatoid 
karditis durumunda.

Dermatolojik Hastalıklar:

Pemfigus, eksfoliatif dermatit, büllöz dermatit herpetiformis, ağır seborreik dermatit, 
ağır psöriasis, mikosis fungoides, eritema multiforme (Stevens-Johnson syndrome).

Allerjik Hastalıklar :

Ağır ve mutad tedavi yöntemleriyle kontrol edilemeyen bronşial astma, kontakt dermatit, 
topik dermatit, serum hastalığı, allerjik rinit, ürtikeriel transfüzyon reaksiyonları, 
ilaç duyarlılığı reaksiyonları, akut larinks ödemi (önce adrenalin verilmelidir).

Göz Hastalıkları :

Herpes zoster oftalmikus, iritis, iridosiklit, korioretinit, diffüz posterior uveit ve 
koroidit, optik nevrit, simpatetik oftalmia, ön segment iltihabı, allerjik konjunktivit, 
keratit, allerjik korneal marjinal ülserler.

Gastrointestinal Hastalıklar :

Hastanın kritik bir devreyi atlatmasına yardımcı olarak : Ülseratif kolit, regional enterit.
Solunum Sistemi :
Semptomatik sarkoidoz, berillioz, fulminan veya dissemine akciğer tüberkülozu 
(antitüberküler ilaçlarla birlikte), Loeffler sendromu (başka metodlarla tedavisi mümkün 
değilse) aspirasyon pnömonisi.

Hematolojik Hastalıklar :

Sekonder otoimmün hemolitik anemi, yetişkinlerde idiopatik trombositopenik purpura (yalnız 
intravenöz yolla; intramusküler enjeksiyon kontrendikedir). Yetişkinlerde sekonder trombositopeni,
eritroblastopeni, konjenital (eritroid) hipoplastik anemi.

Neoplastik Hastalıklar (Palliatif Olarak) :

Yetişkinlerde lösemi ve limfomalar, çocuklarda akut lösemi.

Böbrek Hastalıkları :

İdiopatik veya lupus eritematosus'a bağlı sekonder nefrotik sendromda diüresisin ve proteinürinin 
hafifletilmesinde.

Diğer Endikasyonlar :

Tüberküloz menenjit (subaraknoid blok varsa, antitüberküler ilaçlarla birlikte), trişinoz 
(nörolojik ve miyokardial belirtiler varsa).

Diagnostik :

Adrenokortikal hiperfonksiyon testi için.

Beyin Ödemi :

Primer veya metastatik beyin tümörü, kraniotomi, kafa travmaları.

İntraartiküler Enjeksiyon İle :

Akut hecmelerin kontrolü için :

Sinovit, osteoartrit, romatoid artrit, bursit, akut gut artriti, epikondilit, akut nonspesifik
tenosinovit, post-travmatik osteoartrit.

İntralezyonel Enjeksiyon İle :

Kolloidler, lichen planus, psöriasis, granuloma annulare, nevrodermatit, lupus eritematosus 
diskoides, nekrobiosis lipoidika diabetikorum, alopesia areata, ganglia (aponevroz ve 
tendonların sistik tümörleri).

Şurup :

Allerjik Hastalıklar :

Allerjik rinit, bronşiyal astma, serum hastalığı, ilaç veya hipersensitivite reaksiyonları.

Solunum Sistemi Hastalıkları :

Fulminan ve dissemine pulmoner tüberküloz (antitüberküloz ilaçlarla beraber), aspirasyon 
pnömonisi.

Kontrendikasyonları:

Canlı aşı uygulanması, gebelik, aşırı duyarılılık, akut enfeksiyon ve Herpes zoster'de 
kontrendikedir.

Uyarılar/Önlemler:

Peptik ülser, osteoporosis, psikoz, kalp yetmezliği, böbrek yetmezliği, diyabet, yaşlılık ve 
tüberkülozda kullanılmaz. YavaŞ enjeksiyonla uygulanır. (i.v.enjeksiyonlar 10 dakika). 
Barbitürat, fenitoin ve rifampisinle birlikte kullanılmaz.

Yan etkiler/Advers etkiler:

Ay yüz, yağ depolanması, ödem, hipertansiyon, deride atroti, depresyon, peptik ülser, 
hipergilsemi, halsizlik ve göz içi basıncında artma gibi yan etkiler görülebilir.

İlaç etkileşimleri:

Kortikosteroidler, barbitüratlar, fenitoin ve rifamisin ile birlikte verildiğinde
metabolizmaların artması sonucunda kortikostreoidin etkisi azalabilir. Antiogülanlara cevap 
genellikle azalır bazen de artabilir. Potasyum itrahını arttıran diüretiklerle birlikte 
kullanılması aşırı potasyum kaybına neden olabilir.

Kullanım şekli ve dozu:

Ampul: akut devrelerde kullanılır. Günlük doz 4-20mg'dır (max. 80mg). 
Tablet: Günlük doz 0.75-9 mg'dır. Bu doz 3-4 kısma bölünerek verilir. 
Kronik durumlarda günlük doz 1.5-3 mg ve idame doz ise 0 75 mg'dır. 
Damla: Günlük doz 3-4x1-2 damladır.



";
        }

        private void label12_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox1.ImageLocation = "venofer1.jpg";
            pictureBox2.ImageLocation = "venofer2.png";
            label4.Visible = true;
            label4.Text = @"
Formülü:

Fe III 100 mg./5 ml.

Farmakolojik özellikleri:

Endikasyonları:

Demir depolarının hızlı ve güvenilir bir şekilde doldurulmasının gerektiği hipokrom demir 
eksikliği anemisi.1. ağır demir eksikliği anemisi hızlı bir terapötik etkinin elde edinmek 
istendiği aşağıdaki durumlar buna örnektir. Hanileliğin son 4 ayı içinde, kanamalardan sonra,
gastrointestinal sistemde demir emiliminin bozulması ve demire intolerans. Oral demir 
preperatlarına karşı belirgin bir tedaviye uyumsuzluk durumunda. Oral tedaviye güvenilemeyecek 
ve hastanın düzensiz aralıklarla doktor kontrolüne geldiği, tedaviye dirençli demir eksikliği 
vakalarında. Oral demir tedavisine yeterli cevap vermeyen demir eksikliği anemisi vakalarında, 
örneğin diyaliz hastaları.

Kontrendikasyonları:

Aşırı demir yüklenmesinin veya demir kullanım bozukluğunun söz konusu olduğu vakalar.

Uyarılar/Önlemler:

Miyadı dolmuş ve sediment içeren ampuller kesinlikle enjekte edilmemelidir. Venofer i.v. çok 
yavaş uygulanmalı (1ml/1dk.) ve diğer hiçbir ilaç ile karıştırılmalıdır.

Yan etkiler/Advers etkiler:

İlaç etkileşimleri:

Santral sinir sistemini deprese eden alkol veya anestetikler, hipnotikler, antidpresanlar, 
nöroleptikler veya santral etkili kas gevşetiicilerin etkisini güçlendirir.

Kullanım şekli ve dozu:

1. gün 2.5 ml =50mg Fe(III) 
2. gün; 5.0 ml =100 mg Fe (III) 
3. gün; 10.0 ml = 200 mg Fe (III)
Bunu izleyerek, hemoglabin düzeyleri göz önünde tutularak haftada 2 kez 10ml ile tedaviye 
devam edilir.

";
        }

        private void label13_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox1.ImageLocation = "ferrum1.jfif";
            pictureBox2.ImageLocation = "ferrum2.jfif";
            label4.Visible = true;
            label4.Text = @"
Formülü:

Bir film tablet 100 mg Elementer Demir'e eşdeğer Demir Hidroksit Polimaltoz Kompleksi ve 
0.350 mg Folik asit (etken madde), FDC Yellow 5, FDC Yellow 6, Ponceau 4R, Black PN, 
FDC Red 3 (boyar madde), Vanilin (koku maddesi) ve Şeker (tatlandırıcı) içerir.

Farmakolojik özellikleri:

Endikasyonları:

Özellikle hamilelik ve laktasyon dönemindeki demir ve folik asit desteği olmak üzere değişik
kökenli tüm demir eksiklikleri ile demir eksikliği anemisinin tedavi ve profilaksisinde kullanılır.

Kontrendikasyonları:

Demir yüklenmesi (hemokromatozis, kronik hemolizis), demire karşı aşırı duyarlılık, demir 
kullanımı bozukluğu (kurşun anemisi, sidero-akrestik anemi) ve talasemi durumlarında 
kullanılmamalıdır.

Uyarılar/Önlemler:

Mide ülseri bulunan hastalara dikkatle verilmelidir. Oral demir preparatlarının kullanımı sırasında
dışkının rengi koyulaşabilir, bu durum normal olup, herhangi bir önlem gerektirmez. Dışkıda gizli 
kan aranması sırasında yanılgıya neden olmaz. Bu nedenle bu inceleme sırasında tedavinin 
kesilmesine gerek yoktur.

Yan etkiler/Advers etkiler:

Gastrointestinal yan etkiler görülebilir.

İlaç etkileşimleri:

İki değerlikli demir içeren preparatların gıdalarla ve bazı ilaçlarla (terkasiklin vd.) birlikte
alınması halinde ortaya çıkan etkileşmelerin Ferrum Fort Film Tablet'in bileşimindeki 
demir-hidroksit polimaltoz kompleksi ile gözlenmediği bildirilmiştir.

Kullanım şekli ve dozu:

Ferrum Fort Film Tablet yemeklerle birlikte veya yemeklerden sonra alınmalıdır. Normal dozu 
günde 1 film tablettir. Hekimin gerekli gördüğü durumlarda günde iki defa 1 tablet alınabilir. 
Hekimin önereceği süre kadar kullanılmalıdır. Demir eksikliği belirtilerinin ortadan 
kalkmasından sonra depoların dolması için en az bir ay daha kullanılmalıdır.

DOZ AŞIMI

Aşırı miktarda alınması akut demir zehirlenmesine neden olabilir. Zehirlenme halinde 
Desferroksamin veya Kalsiyum Disodyum EDTA kullanılır. Desferroksamin teratojenik etkiye 
sahiptir.


";
        }

        private void label14_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox1.ImageLocation = "dekort1.jfif";
            pictureBox2.ImageLocation = "dekort2.jpg";
            label4.Visible = true;
            label4.Text = @"
0,50 Mg 20 Tablet / 0,75 Mg 20 Tablet

Farmakolojik özellikleri:

Endikasyonları:

Farmasötik şekle göre: Enflamatuar ve allerjik hastalıkların supresyonunda, şokta, 
Cushing Hastalığı teşhisinde, konjenital adrenal hiperplazide, serebral ödemde, 
intraartiküler enjeksiyonla romatoid artritte endikedir.

DEKORT Tablet 0.75 mg antienflamatuvar, antiromatizmal ve antiallerjik tesirlerinden 
dolayı, kortikosteroidlerle tedaviye cevap veren vakaların hepsinde kullanılır.

Romatizmal Hastalıklar
Ör: Romatoid artrit
Allerjik Hastalıklar
Ör: Anjinörotik ödem, anafilaksi
Dermatolojik Hastalıklar
Ör: Pemghigus
Arteritis Collagenosis
Ör: Polyarteritis nodosa
Solunum Sistemi Hastalıkları
Ör: Bronşiyal astma, aspirasyon pnömoniti
Oftalmik Hastalıklar
Ör: Anterior ve posterior uveit, optik nörit.
Hematolojik Bozukluklar
Ör: Hemolitik anemi, lösemi, myeloma
Kardiyovasküler bozukluklar
Ör: Post-myokard enfarktüsü sendromu
Hiperkalsemi
Ör: Sarkoidosis
Enfeksiyonlar
Ör: Miliyer tüberküloz (uygun kemoterapi ile birlikte)
Kas hastalıkları
Ör: Polymyositis
Ödeme Yol Açan Hastalıklar
Ör: İdiopatik veya lupus erythematosus' un neden olduğu nefrotik sendrom.
Gastrointestinal Sistem Hastalıkları
Ör: Ülseratif kolit,Crohn hastalığı
Nörolojik bozukluklar
Ör: Serebral tümörlerle birlikte görülen beyin ödemleri
Endokrin Bozukluklar
Ör: Primer veya sekonder adrenokortikal kifayetsizlikler, konjenital adrenal hiperplazi,

Damla:

Göz Hastalıkları:

Konjonktiva, kornea ve göz küresinin ön kesiminin steroid tedavisine cevap veren enflamatuar 
hastalıklarında endikedir. Bunlar arasında allerjik konjonktivit, akne rosacea, yüzeysel iritis, 
siklit sayılabilir.
DEKORT ödem ve enflamasyonun giderilmesi için steroid kullanımının uygun görüldüğü yabancı 
cisimlerin batmasının, termal veya kimyasal yanıkların neden olduğu kornea hasarları vakalarında 
da tatbik edilir.

Kulak hastalıkları:
Alerjik dış kulak iltihabı, steroid kullanımının ödem ve enflamasyonun giderilmesi için gerekli 
görüldüğü pürülan ve non pürülan enfeksiyöz dış kulak iltihabı.

Kontrendikasyonları:

Canlı aşı uygulanması, gebelik, aşırı duyarılılık, akut enfeksiyon ve Herpes zoster'de 
kontrendikedir.

Uyarılar/Önlemler:

Peptik ülser, osteoporosis, psikoz, kalp yetmezliği, böbrek yetmezliği, diyabet, yaşlılık ve 
tüberkülozda kullanılmaz. Yavaç enjeksiyonla uygulanır. (i.v.enjeksiyonlar 10 dakika). Barbitürat,
fenitoin ve rifampisinle birlikte kullanılmaz.

Yan etkiler/Advers etkiler:

Ay yüz, yağ depolanması, ödem, hipertansiyon, deride atroti, depresyon, peptik ülser, 
hipergilsemi, halsizlik ve göz içi basıncında artma gibi yan etkiler görülebilir.

İlaç etkileşimleri:

Dehydrobenzperidol için belirli bir etkileşim bildirilmemiştir. Ancak MSS dpresanı olarak diğer 
MSS aktif ilaçların etkinliğini arttırabilir.

Kullanım şekli ve dozu:

Ampul: akut devrelerde kullanılır. Günlük doz 4-20mg'dır (max. 80mg).Tablet: Günlük doz 
0.75-9 mg'dır. Bu doz 3-4 kısma bölünerek verilir.Kronik durumlarda günlük doz 1.5-3 mg ve 
idame doz ise 0 75 mg'dır. Damla: Günlük doz 3-4x1-2 damladır.

Tedavi süresi lezyonun tipine bağlıdır ve alınan cevaba göre birkaç günden birkaç haftaya kadar 
değişebilir.

Göz:
Başlangıçta gündüzleri her saatte ve geceleri her iki saatte bir göze 1-2 damla damlatılır.
Tedaviden cevap alındıktan sonra uygulama 3-4 saatte bir 1 damla olarak azaltılır ve daha 
sonraları günde 3-4 defa 1 damla damlatılması yeterli olur.

Kulak:
Kulak iyice temizlenip kurulandıktan sonra günde 2-3 defa 3-4 damla kulak kanalına damlatılır.
Tedaviden cevap alındıktan sonra doz giderek azaltılır.

Diğer kortikosteroidlerde olduğu gibi DEKORT'un dozu da hastalığın türü, şiddeti ve hastanın 
reaksiyonuna göre ayarlanır.

Günlük doz 0.75-9 mg arasında değişebilir.
Ancak ağır vakalarda daha yüksek dozlar verilebilir. Günlük dozun 3 veya 4 kısma bölünerek 
verilmesi gerekir.

Tedavide;

Romatoid artrit ve kronik astma bronşiyal gibi kronik vakalarda;
Günde 1.5-3 mg, idame dozu ise 0.75 mg' dır.
Şiddetli mevsim astması, akut deri hastalıkları, akut ülseratif kolit gibi akut hastalıklarda;
Günde 2-3 mg' dır.
Romatizma, dissemine lupus eritematosus, nefrotik sendrom gibi kronik hastalıklarda;
Günde 2-4.5 mg kullanılır.
Hayatı tehdit eden status asthmaticus gibi ciddi durumlarda ve hemopatilerde;
Hekim gerekli bulursa başlangıç dozu olarak 7-10 mg verilebilir.
İdame dozu belirtiler yeterince düzelince gerekli görülen minimum doza kadar giderek 
azaltılarak tayin edilir.
Deksametazon'un idame dozu ortalama olarak günde 1-1.5 mg arasında olup bazı vakalarda 
günlük 0.75 mg' lık doz yeterli gelmektedir.

Deksametazon ile uygulanan testlerde:

Cushing Sendromu:
Gece 11' de 1 mg DEKORT oral olarak verilir. Sabah 8' de plazma kortizol düzeyini tayin 
etmek üzere kan alınır. Daha kesin bir sonuç temini için 48 saat süre ile 6 saatte bir 
0.5 mg DEKORT tablet verilir. Bunu takip eden 24 saatteki idrar toplanır ve itrah edilen 
17-hydroksikortikosteroid miktarı tayin olunur.

Pitiuter ACTH fazlalığına bağlı Cushing Sendromunu diğer sebeplerden kaynaklanan Cushing 
Sendromundan ayırmak için:
48 saat süre ile 6 saatte bir 2 mg DEKORT oral olarak verilir. Daha sonraki 24 saat idrar
toplanır ve itrah edilen 17-hydroksikortikosteroid miktarı tayin olunur.


";
        }

        private void label15_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox1.ImageLocation = "ferimax1.jfif";
            pictureBox2.ImageLocation = "ferimax2.jfif";
            label4.Visible = true;
            label4.Text = @"
Formülü:
Her bir oral flakon (5 mL); etken madde olarak 100 mg Elementer Demir'e eşdeğer Demir (III) 
Hidroksit Polimaltoz Kompleksi, tatlandırıcı olarak sukroz, koruyucu olarak sodyum metil 
parahidroksibenzoat ve sodyum propil parahidroksibenzoat ve koku maddesi olarak krem 
aroması AG 6134 içerir.

Farmakolojik özellikleri:

Farmakodinamik Özellikler:

Ferimax oral solüsyon, demir eksikliğinin tedavi ve profilaksisi için geliştirilmiştir. 
Polinüklear Demir (III) Hidroksit çekirdekleri yüzeysel olarak non-kovalent bağlanmış 
polimaltoz molekülleri ile çevrilidir.

Demir (III) Hidroksit Polimaltoz Kompleksi stabildir ve fizyolojik koşullarda iyonik demiri
salmamaktadır. Polinüklear çekirdeklerde demir fizyolojik olarak oluşan ferritine benzer 
yapıda bağlanmaktadır ve aktif olarak emilmektedir.

Demir (III) Hidroksit Polimaltoz'un prooksidatif özellikleri yoktur. VLDL, LDL gibi 
lipoproteinlerin oksidasyona eğilimi azalır.

Yaş Grubu | Demir (mg/gün)
Bebekler | 0-6 ay 0.27 mg, 7-12 ay 11 mg
Çocuklar | 1-3 yaş 7 mg, 4-8 yaş 10 mg
Gebelik | < 18 yaş 27 mg, 19-30 yaş 27 mg, 31-50 yaş 27 mg
Emzirme | < 18 yaş 10 mg, 19-30 yaş 9 mg, 31-50 yaş 9 mg
Erkekler | 9-13 yaş 8 mg, 14-18 yaş 11 mg, 19-30 yaş 8 mg, 31-50 yaş 8 mg, 
51-70 yaş 8 mg, > 70 yaş 8 mg
Kadınlar | 9-13 yaş 8 mg, 14-18 yaş 15 mg, 19-30 yaş 18 mg, 31-50 yaş 18 mg, 
51-70 yaş 8 mg, > 70 yaş 8 mg

Farmakokinetik Özellikler:

Emilim çalışmaları; hemoglobin ve myoglobin sentezi baz alındığında Demir (III) Hidroksit 
Polimaltoz Kompleksinin ve demir (II) tuzlarının fizyolojik ve terapötik dozlarında demir 
emiliminin benzer olduğunu göstermiştir. Demir emilimi başlıca duodenum ve üst jejunum 
bölgesinden olmaktadır. Hidroklorik asit, askorbik asit gibi diğer indirgeyici maddeler de 
absorbsiyona yardımcı olurken; fosfatlar, fitatlar, tannat, antasitler absorbsiyonu olumsuz 
yönde etkiler. 1 gram'a kadar C vitamini (Askorbik asit) demir emilimini sadece %10 artırır. 
100 mg gibi düşük dozlar demir emilimi üzerine belirgin etki yapmamaktadırlar. Vücut gebelik, 
laktasyon dönemi, büyüme ve demir eksikliği anemisi gibi ihtiyacın arttığı durumlarda demir 
emilimini arttırma kapasitesine sahiptir, kısaca demir depoları ile demir emilimi arasında 
ters orantı bulunmaktadır. Demir barsaklardan emilince mukozal hücrelerden kana geçer, 
transferin proteini ile kemik iliğinde gelişmekte olan eritrositlere taşınır. Kemik iliği, 
karaciğer ve dalak olmak üzere başlıca retiküloendotelyal hücrelerde depolanır. Demir (III)
Hidroksit Polimaltoz Kompleksi ile demir depolarının doldurulması, serum ferritinin artması 
demir (II) tuzlarına göre biraz daha uzun zaman alır. Bunun nedeni absorpsiyon mekanizmasının 
farklı olmasıdır ve bu, Demir (III) Hidroksit Polimaltoz Kompleksi ile zehirlenme görülmemesinin 
de nedenidir. Ferik demir emilimi plazma ferritini ile ilişki halindedir. Emilen demir miktarı
kişinin demir eksikliği miktarına ve dozaja bağlıdır. Emilmeyen demir feçesle atılmaktadır.

Endikasyonları:

Özellikle demir eksikliği anemisi başta olmak üzere tüm latent ve manifest demir eksikliklerinin 
tedavisinde kullanılır.

Kontrendikasyonları:

Demir yüklenmesi bulunanlarda veya demirin kullanımında bir bozukluğun söz konusu olduğu 
durumlarda (ör. hemokromatoz, hemosideroz, kurşun anemisi, sideroakrestik anemi ve talasemi) 
ve demir eksikliğinin neden olmadığı anemilerde (ör. hemolitik anemi) kullanılmamalıdır.

Uyarılar/Önlemler:

Mide ülseri bulunan hastalara dikkatle verilmelidir. Oral demir preparatlarının kullanım 
sırasında dışkının rengi koyulaşabilir, bu durum normal olup, herhangi bir önlem gerektirmez.
Dışkıda gizli kan aranması sırasında yanılgıya neden olmaz. Bu nedenle bu inceleme sırasında 
tedavinin kesilmesine gerek yoktur.

Gebelikte kullanım:
Gebelik kategorisi: A

Deneysel üreme çalışmaları herhangi bir risk göstermemiştir. Gebelerdeki kontrollü çalışmaları 
gebeliğin ilk trimestrinde anne ve fötusta risk oluşturmamıştır. İlk trimesterde riske dair 
bulguya rastlanmamıştır.
Hamilelikte demir desteği ile birlikte folik asit takviyesi de göz önünde bulundurulmalıdır

Emziren Kadınlarda Kullanım:

Gebelik ve süt verme döneminde hekimin önerdiği şekilde ve kontrolünde kullanılmalıdır.

Araç ve makine kullanımına etkisi:

İlacın araç ve makine kullanımına etkisine dair bir bilgiye rastlanmamıştır.

Yan etkiler/Advers etkiler:

Demir preparatlarının oral kullanımı ile birlikte dışkı genellikle siyah bir renk alır. 
Bunun sebebi absorbe olamayan demirdir ve bu durum zararsızdır. Demir (III) Hidroksit 
Polimaltoz Kompleksindeki demir (III) esasen non-iyonik olduğundan, Ferimax Oral Solüsyon 
ile iyonize demir tuz preparatlarında gözlenen gastrointestinal iritasyon, epigastrik 
dolgunluk, bulantı, diyare, kabızlık gibi istenmeyen etkiler nadirdir.

BEKLENMEYEN BİR ETKİ GÖRÜLDÜĞÜNDE DOKTORUNUZA BAŞVURUNUZ.

İlaç etkileşimleri:
Demir (III) Hidroksit Polimaltoz Kompleksindeki demir (III) kompleks yapmış olduğundan, 
yiyeceklerdeki bileşenlerle (fitin, oksalat, tannin) ve birlikte uygulanan ilaçlarla 
(tetrasiklin, antiasidler) iyonik etkileşme görülmez. Buna karşın demir iyonları 
(Ferröz tuzları) yukarıda sayılan maddelerle çözünmeyen kelatlar oluşturarak demir 
emilimini azaltırlar.

Dışkıda gizli kan aranması sırasında yanılgıya neden olmaz. Bu nedenle bu inceleme 
sırasında tedavinin kesilmesine gerek yoktur.

Demir emilimini bozan süt, çay ve kepekli gıdaların demir preparatları ile birlikte 
alınmaması, C vitamininden zengin portakal suyu gibi emilimi artırıcı besinlerle verilmesi 
önerilmektedir.

Kullanım şekli ve dozu:

Ferimax Oral Solüsyon yemekler sırasında veya hemen yemekten sonra alınmalıdır.

Çocuklar (>12 yaş),erişkin ve yaşlılar:

Gizli (latent) demir eksikliği: Günde ½ - 1 flakon (50-100 mg)
Ciddi demir eksikliği: Günde 2-3 defa 1 flakon (200-300 mg)

Tedavi süresi demir metabolizmasının durumuna (azalmış alım, artan ihtiyaç, patolojik kayıp)
ve eritrosit sayısının normalleşmesine bağlıdır. Belirgin (manifest) demir eksikliğinde normal 
kan değerlerine ulaşmak ortalama 3-5 aylık tedavi ile olur. Gizli (latent) demir eksikliğinde 
tedavi süresi 1-2 aydır.

Hemoglobin konsantrasyonunun normale dönmesinden sonra depoların dolması için 2-3 aylık 
süre boyunca her gün 1 flakon içilmesi gerekmektedir.

";
        }

        private void label16_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox1.ImageLocation = "santafer1.jpg";
            pictureBox2.ImageLocation = "santafer2.jpg";
            label4.Visible = true;
            label4.Text = @"
Formülü:

Bir ölçekte (5 ml'de); etkin madde olarak 50 mg elementer demire eşdeğer demir III hidroksit 
polimaltoz kompleksi, tatlandırıcı olarak şeker ve sorbitol, koruyucu olarak metin paraben, 
propil paraben ve ayrıca krem esansı içerir.

Farmakolojik özellikleri:

Endikasyonları:

Değişik kökenli tüm demir eksiklikleri ile demir eksikliği anemisinin tedavi ve profilaksisinde;
hamilelik, laktasyon ve çocukluk döneminde demir desteği tedavisinde kullanılır. 
Hamilelikte demir desteği ile birlikte folik asit takviyesi de göz önünde bulundurulmalıdır.

Kontrendikasyonları:

Değişik kökenli tüm demir eksiklikleri ile demir eksikliği anemisinin tedavi ve profilaksisinde; 
hamilelik, laktasyon ve çocukluk döneminde demir desteği tedavisinde kullanılır. Hamilelikte 
demir desteği ile birlikte folik asit takviyesi de göz önünde bulundurulmalıdır.

Uyarılar/Önlemler:

Mide ülseri bulunan hastalara dikkatle verilmelidir. Oral demir preparatlarının kullanımı 
sırasında dışkının rengi koyulaşabilir. Bu durum, normal olup herhangi bir önlem gerektirmez. 
Dışkıda gizli kan aranması sırasında yanılgıya neden olmaz. Bu nedenle, bu inceleme sırasında 
tedavinin kesilmesine gerek yoktur.

Gebelerde kullanımı:

Gebelik kategorisi, A'dır. İlaçların gebeliğin ilk üç ayı sırasında kullanımı, potansiyel 
riskler ile elde edilecek yararların dikkatli değerlendirmesini gerektirir. Bu nedenle, 
ilk üç aylık dönemde çok gerekli olmadıkça kullanılmamalıdır. Gebeliğin diğer dönemleri için 
demir tedavisi, sadece doktorun önerisi üzerine endike olabilir.

Emzirenlerde kullanımı:

Demir, klinik yönden anlamlı olmayan konsantrasyonlarda (günde 0,5 mg) da olsa meme sütüne 
geçer.

Yan etkiler/Advers etkiler:

Gastrointestinal yan etkiler görülebilir. Konstipasyon, bulantı, kusma ve mide krampları en fazla 
görülen yan etkilerdir.

İlaç etkileşimleri:

İki değerlikli demir içeren preparatların gıdalarla ve bazı ilaçlarla (tetrasiklin vs.) birlikte 
alınması halinde ortaya çıkan etkileşimlerin Santafer Şurup'un bileşimindeki üç değerlikli demir 
hidroksit polimaltoz kompleksi ile gözlenmediği bildirilmiştir.

Kullanım şekli ve dozu:

Yemeklerle birlikte veya yemeklerden sonra, hekim başka bir şekilde önermedikçe;

- Çocuklar: Günde 1-2 defa 1 ölçek (5 ml),

- Yetişkinler: Günde 2-3 defa 1 ölçek (5 ml).

Meyve veya sebze suları ile karıştırılarak alınabilir.

Hekimin önereceği süre kadar kullanılmalıdır.

Demir eksikliği belirtilerinin ortadan kalkmasından sonra depoların dolması için en az bir ay 
daha kullanılmalıdır.

DOZ AŞIMI ve TEDAVİSİ

Aşırı miktarda alınması, akut demir zehirlenmesine neden olabilir. Zehirlenme halinde 
desferroksamin veya kalsiyum disodyum EDTA kullanılır.

Desferroksamin, teratojenik etkiye sahiptir.


";
        }

        private void label17_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox1.ImageLocation = "aktibol1.jpg";
            pictureBox2.ImageLocation = "aktibol2.jpg";
            label4.Visible = true;
            label4.Text = @"
Formülü:

Her liyofilize ampulde 1000 mcg kobamamid, 40 mg mannitol, 1 mg sodyum klorid ve 2
5 mcg sodyum mertiolat bulunmaktadır. Her eritici ampul 2 ml apirojen enjeksiyonluk 
distile su içerir. Preparat sterildir.

Farmakolojik özellikleri:

AKTİBOL Tüm aktif maddesi olan kobamamid yağ ve karbonhidrat metabolizması ile protein 
sentezini içeren birçok metabolik fonksiyonda koenzim olarak görev yapar. Bu da büyüme, 
hücre bölünmesi, hematopoez, nükleoprotein ve miyelin sentezi için gereklidir. 
Bu etkilerini metionin, folik asit ve malonik asit metabolizmalarını etkileyerek 
ortaya koyar.

Endikasyonları:

Pernisiyöz, makrositer ve hemolitik anemiler.
Kronik enfeksiyonlu hastalıklar ve cerrahi müdahalelerden sonra görülen anemiler.
Kanser ve kronik karaciğer hastalıklarında görülen anemiler.

Kontrendikasyonları:

Kobamamide karşı duyarlı olan kişilerde ve Lebers hastalığı (optik sinir atrofisi, 
kullanımdan hemen sonra ortaya çıkabilir) ve gutta kullanılmamalıdır.

Uyarılar/Önlemler:

Ancak doktor tavsiyesi ile kullanılmalıdır.
Habis tümörlerde, hücre mültiplikasyonunun B12 vitamini tarafından kamçılanabilmesi 
nedeniyle tümoral alevlenme riski göz önünde bulundurulmalıdır.

Yan etkiler/Advers etkiler:

Böbrek fonksiyonu normal hastalarda nadiren toksisiteye neden olabilir.
Anafilaktik reaksiyonlar (ürtiker, şok, deri döküntüleri, diyare ve kaşıntı) görülebilir.

BEKLENMEYEN BİR ETKİ GÖRÜLDÜĞÜNDE DOKTORUNUZA BAŞVURUNUZ.

laç etkileşimleri:

Alkol, aminoglikozitler, aminosalisilatlar, antikonvülsanlar, kolestiramin, kolşisin 
absorpsiyonunu azaltabilir; C vitamini, B12 vitaminini tahrip edebilir. Bu nedenle yüksek 
dozda C vitaminini bir saat önce ya da sonra almak gerekir.Kloramfenikol hematopoetik 
cevabı antagonize edebilir.

Kullanım şekli ve dozu:

(Hekim tarafından başka bir şekilde önerilmediği hallerde)
Çocuklar: Gün aşırı 1 ampul I.M. uygulanır. İstenen sonuç alındıktan sonra haftada 
1 ampulle doktorun önereceği süre tedaviye devam edilir.

Erişkinler: Günde 1 ampul 1M. uygulanır. İstenen sonuç alındıktan sonra haftada 
1-2 ampulle doktorun önereceği süre tedaviye devam edilir.



";
        }

        private void label18_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox1.ImageLocation = "aranesp1.png";
            pictureBox2.ImageLocation = "aranesp2.jpg";
            label4.Visible = true;
            label4.Text = @"
150 mcg / 100 mcg / 80 mcg / 60 mcg / 40 mcg/ 30 mcg / 20 mcg / 15 mcg / 10 mcg

Formülü:

Darbepoetin alfa

Farmakolojik özellikleri:
Endikasyonları:
Erişkinler ve 11 yaş ve üzerindeki pediatrik bireylerde, kronik renal 
yetmezliğe bağlı anemi tedavisinde

Kontrendikasyonları:

Zomig aşağıdaki durumlarda kontrendikedir;

- Ürünün bileşiminde bulunan maddelerden herhangi birine karşı bilinen aşırı duyarlığı olanlarda
- Kan basıncı kontrol altında olmayan hipertansiyon vakalarında
- İskemik kalp hastalığında
- Koroner spazm/printzmetal angina vakalarında

Uyarılar/Önlemler:

'Zomig' yalnızca, migren teşhisi açıkça konulmuş olan hastalarda kullanılmalı ve önemli 
olabilecek diğer nörolojik durumların bulunmadığına dikkat edilmelidir. 'Zomig'in hemiplejik 
veya baziler migren tedavisinde kullanımıyla ilgili herhangi bir veri mevcut değildir.

'Zomig', semptomatik Wollf-Parkinson-White sendromu vakalarına veya kalpteki aksesuvar uyaran
iletimi yollarına eşlik eden aritmileri olan hastalara verilmemelidir.

Çok nadir durumlarda bu sınıftan olan bileşikler (5HT1B/1D agonistleri) koroner vazospazm ve 
miyokard enfarktüsü ile ilgili olabilir. İskemik kalp hastalığı riski olan hastalara Zomig'de 
dahil bu sınıftan bileşiklerle tedaviye başlamadan önce kardiyovasküler değerlendirme yapılması 
önerilir(Bkz. Kontren).

Diğer 5HT1B/1D agonistleri gibi zolmitriptan kullanılmasından sonra da prekordiyal bölge 
üzerinde atipik duyular bildirilmiştir. Fakat klinik çalışmalarda bu his, aritmilere veya 
EKG'deki iskemik değişikliklere eşlik etmemiştir.

'Zomig' kan basıncını (ileri yaştakilerde daha da belirgin olmak üzere) hafif ve geçici bir 
şekilde yükseltebilir. Ancak klinik çalışma programında bu, herhangi bir klinik sekel ile 
bağlantılı bulunmamıştır.

Gebelik
Gebe kadınlarda 'Zomig' yalnızca, annede elde edilecek faydaların, fetusun karşı karşıya 
kalabileceği risklerden açıkça daha fazla olması durumunda kullanılmalıdır. Gebe kadınlarda 
yapılmış herhangi bir çalışma yoktur.

Laktasyon
Zolmitriptan'ın insanlarda anne sütüne geçişi konusunda herhangi bir veri mevcut olmadığından 
'Zomig'in bebeğini emziren kadınlarda kullanılması sırasında dikkatli olmak gerekir.

Araç ve Makina Kullanmaya Etkisi
20 miligrama kadar çıkan 'Zomig' dozları, psikomotor test performansını anlamlı şekilde
bozmamıştır. 'Zomig' kullanımının, hastaların araç ya da makine kullanma yeteneğini bozma 
olasılığı yoktur. Ancak somnolans görülebileceği dikkate alınmalıdır.

Yan etkiler/Advers etkiler:

'Zomig' iyi tolere edilir. Yan etkiler genelde hafif/orta şiddettedir, geçicidir, ciddi değildir 
ve ilave tedavi uygulanmaksızın kendiliğinden düzelir. Olası yan etkilerin, dozun alınmasını 
izleyen 4 saat içerisinde görülme eğilimi vardır ve bunlar, tekrarlanan dozlardan sonra sıklaşmaz.

Çok nadir vakalarda diğer 5HT1B/1D agonistleri ile olduğu gibi angina pectoris ve miyokard 
enfarktüsü rapor edilmiştir.

En çok aşağıdaki yan etkiler bildirilmiştir:
Bulantı
Göz kararması
Somnolans
Sıcaklık hissi
Asteni
Ağız kuruması

Duyu anormallikleri veya bozuklukları bildirilmiştir; boğazda, boyunda, ekstremitelerde ve 
göğüste (EKG'de iskemik değişikliklerin eşlik etmediği) ağırlık, daralma, ağrı ya da baskı hissi
ortaya çıkabilir; kas ağrıları, kaslarda dermansızlık, parestezi ve dizestezi görülebilir.

BEKLENMEYEN BİR ETKİ GÖRÜLDÜĞÜNDE DOKTORUNUZA BAŞVURUNUZ.

İlaç etkileşimleri:

Beta blokerler, oral dihidroergotamin, pizotifen gibi migren profilaksisi ilaçlarının
birlikte kullanılmasının, 'Zomig'in etkinliğinde değişiklik yaptığını veya istenmeyen
etkilere yol açtığını gösteren hiçbir kanıt yoktur.

Parasetamol, metoklopramid ve ergotamin gibi akut semptomların tedavisi amacıyla kullanılan 
ilaçlar, 'Zomig' farmakokinetiği ve tolerabilitesi üzerinde etkisizdir. 'Zomig' tedavisini
izleyen 12 saat içerisinde diğer 5HT1B/1D agonistleri alınmamalıdır.

Spesifik bir MAO-A inhibitörü olan moklobemid alınmasından sonra zolmitriptan'ın AUC 
değerinde %26 yükselme görülmüş, aktif metabolitin AUC değeri ise 3 kat artmıştır. 
Bu nedenle, bir MAO-A inhibitörünün alınmasından sonraki 24 saat içerisinde kullanılacak 
'Zomig' miktarı, 7.5 mg'ı aşmamalıdır.

Genel bir P450 inhibitörü olan simetidin uygulamasını takiben zolmitriptan'ın yarı ömrü %44 
ve AUC değeri %48 artar. Buna ilave olarak aktif metaboliti (183C91) N-desmetil yarı ömrü ve 
AUC değeri iki katına çıkar. Simetidin kullanan hastalarda 24 saatte maksimum 5 mg Zomig
kullanılması önerilir. Bütün etkileşim profili baz olarak alındığında sitokrom P450 izoenzim 
CYP1A2 inhibitörleri ile etkileşim gözardı edilemez. Bundan dolayı bu tip bileşiklerden 
fluvoksamin ve kinolon grubu antibiyotikler (siprofloksasin gibi) ile de aynı şekilde doz 
azaltılması önerilir.

Fluoksetin zolmitriptan'ın farmakokinetik parametrelerini etkilemez. Spesifik serotonin 
geri alım inhibitörleri olan fluoksetin, sertraline, paroksetin ve sitalopram'ın terapötik 
dozları, CYP1A2'yi inhibe etmez.

Sağlıklı küçük bir gönüllü grubunda zolmitriptan, ergotaminle birlikte kullanıldığında 
farmakokinetik etkileşim görülmemiştir. 'Zomig'in ergotamin/kafein ile birlikte verilmesi, 
iyi tolere edilmiş ve yan etkilerde ya da kan basıncı değişikliklerinde, 'Zomig'in tek 
başına kullanılmasına kıyasla herhangi bir artışla sonuçlanmamıştır.

Bir MAO-B inhibitörü olan selegilin ve bir selektif serotonin geri-alım inhibitörü (SSRI) 
olan fluoksetin, zolmitriptanın farmakokinetik parametreleri üzerinde etkili olmamıştır.

Rifampisin uygulamasını takiben zolmitriptan veya onun aktif metabolitinin farmakokinetiği 
ile ilgili klinik herhangi bir değişiklik gözlemlenmemiştir.



";
        }

        private void label19_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox1.ImageLocation = "aktibolkaps1.jpg";
            pictureBox2.ImageLocation = "aktibolkaps2.jpg";
            label4.Visible = true;
            label4.Text = @"
Formülü:

Her kapsül, 1000 mcg kobamamid içerir.
Her liyofilize ampul, 1000 mcg kobamamid içerir.

Farmakolojik özellikleri:

Protein sentezini stimüle eder.
Gıda ile alınan proteinlerin sindirimini kolaylaştırır.
Azot bilançosunu pozitif yapar.
Vücudun direncini artırır.
Non – hormonal olduğundan, hormonal anabolizanların yan etkileri görülmez.
Çok iyi tolere edilir.

Endikasyonları:

Pernisiyöz, makrositer ve hemolitik anemiler. Kronik enfeksiyonlu hastalıklar ve cerrahi 
müdahalelerden sonra görülen anemiler. Kanser ve kronik karaciğer hastalıklarında görülen 
anemiler.

Kontrendikasyonları:

Bilinen bir kontrendikasyonu yoktur.

Uyarılar/Önlemler:

Sadece doktor önerisi ile kullanılmalıdır. Habis tümörlerde, hücre mültiplikasyonunun 
B12 vitamini tarafından kamçılanabilmesi nedeniyle tümoral alevlenme riski göz önünde
bulundurulmalıdır.

Yan etkiler/Advers etkiler:

Böbrek fonksiyonu normal hastalarda nadiren toksisiteye neden olabilir. Anafilaktik 
reaksiyonlar ( ürtiker, şok, deri döküntüleri, diyare ve kaşıntı ) görülebilir.

İlaç etkileşimleri:

Alkol, aminoglikozitler, aminosalisilatlar, antikonvülsanlar, kolestiramin, kolşisin 
absorpsiyonunu azaltabilir; C vitamini, B12 vitaminini tahrip edebilir. Bu nedenle 
yüksek dozda C vitaminini bir saat önce ya da sonra almak gerekir.Kloramfenikol 
hematopoetik cevabı antagonize edebilir.

Kullanım şekli ve dozu:

Prematüreler: Günde 1 kapsül (kapsül içeriği açılıp sıvıya karıştırılır)
Süt çocukları: Günde 2 kapsül
1 yaşından büyük çocuklar: Günde 3 kapsül veya gün aşırı 1 ampul
Erişkinler: Günde 6 kapsül (3 x 2) veya günde 1 ampul



";
        }

        private void label20_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox1.ImageLocation = "anador1.png";
            pictureBox2.ImageLocation = "anador2.jfif";
            label4.Visible = true;
            label4.Text = @"
Farmakolojik özellikleri:

Endikasyonları:

Aplastik anemi, osteoporozda endikedir.

Kontrendikasyonları:

Prostat karsinomu, gebeliğin ilk aylarında, porfiride, erkeklerde meme kanserinde 
ve doping amacıyla sporcularda kullanılması kontrendikedir.

Uyarılar/Önlemler:

Kardiyak ve rehnal yetmezlik, hipertansiyon, diyabet, epilepsi, migrende dikkatle 
kullanılır. Kümarin ve indandoin türevi oral antikoagülanların etkisini potansiyalize
eder. Kadınlarda görülen ses kalınlaşmasında tedaviye son verilmelidir.

Yan etkiler/Advers etkiler:

Metotreksatın yan etkilerini artırır.

İlaç etkileşimleri:

Geçimsizliği ve etkileşimleri yoktur.

Kullanım şekli ve dozu:

Her 15 veya 30 günde bir i.m. yolla 1 ampul kullanılır. Enjeksiyon tercihen gluteus 
bölgesine derin olarak yapılmalıdır.


";
        }

        private void label21_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox1.ImageLocation = "antr1.jpg";
            pictureBox2.ImageLocation = "antr2.jpg";
            label4.Visible = true;
            label4.Text = @"
1000 IU 2.5 ml 1 Flakon / 1500 IU 2.5 ml 1 Flakon

Endikasyonları:

Terapatik Özellikler :

Anti-Rhesus (D) immunoglobuline,Rh(D)negatif kadınlarda Rh(D) antijene karşı immünizasyonu 
korumak amacıyla;

Rh (D)pozitif veya Rh (D) faktörü bilinmeyen çocukların doğumdan sonra,

Sezeryandan sonra,plasentanın elle atılması, cenin ölümü, anemik bebek doğumu ve çoklu 
gebeliklerde,

Kendiliğinden veya dış etkenlerden oluşan düşüklerden sonra,

Amniosentezde (amnion sıvısı alma amacıyla iğne ile amnion kesesine girme),

Kronik virüs biyopsilerinde,

Göbek kordonunun delinmesi durumunda,

Gebelik sırasındaki travmalar sonrasında

Bebek doğumunda makat gelişinde dışarıdan müdahalede,

Hidatik kistlerde,

30. Haftadaki gebelik profilaksisinde,özellikle henüz canlı doğum yapmamış kadınlarda,

Anti_Rhesus (D) immünoglobuline ayrıca 45 yaş altı ve genç kızlarda da Rh (D) antijenine 
karşı immünizasyon amacıyla kullanılabilir.

Rh (D) pozitif olan kan veya trombosit transfüzyonundan sonra,

Rh (D) pozitif donörden organ veya doku; özellikle böbrek ve kemik dokusu nakillerinden sonra,

Kontrendikasyonları:

Hepatik porfiri, doğuştan glukoz-6 fosfat dehidrogenaz eksikliği, astım, kobalta duyarlılık, 
az miktarda alkol alımına bağlı rahatsızlık, kan diskrazisi, gebelik, laktasyon, renal ve 
hepatik yetmezlik, peptik ülser ve etken maddeye duyarlılık durumlarında İki yaşından küçük 
çocuklarda kontrendikedir.

Uyarılar/Önlemler:

i.v. uygulamalardan sakınılmalıdır. Preparat 2-8°C'de ve ışıktan uzak ortamlarda korunmalıdır.
1x2ml'lik ambalajlarda. Enjeksiyonlar derin i.m. ve yavaş olarak yapılmalıdır. Klorpromazinle 
birlikte kullanılmamalıdır.

Anti-Rhesus (D)immünoglobulin doğumdan sonra anneye uygulanır.

Yan etkiler/Advers etkiler:

Uyuşukluk, baş dönmesi, ağız kuruluğu, bulanık görme ve baş ağrısı gibi yan etkiler görülebilir.

İlaç etkileşimleri:

Deney hayvanlarında yapılmış çalışmalar Antepsin'in (sukralfat) tetrasiklin ve fenitoin ile birlikte 
kullanılması halinde bu ilaçların biyoyararlılığında anlamlı bir azalmanın oluştuğunu göstermiştir.
Bu açıdan Antepsin Tablet'in bazı ilaçların emilimini engelleyebileceği düşünülerek, diğer ilaçlardan
ayrı olarak alınması önerilir.



";
        }

        private void label22_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox1.ImageLocation = "Bevitab1.png";
            pictureBox2.ImageLocation = "Bevitab2.jpg";
            label4.Visible = true;
            label4.Text = @"
20 Tablet / 30 Tablet / 50 Tablet 

Formülü:

Beher Tablet ;
Tiamin hidroklorür 250 mg
Pridoksin hidroklorür 250 mg içerir.
Yardımcı Madde : Titan Dioksit

Farmakolojik özellikleri:

Endikasyonları:

Periferik sinir sistemi komplikasyonları : Nevrit, polinevrit, optik nevrit, gebelik nevriti, 
diyabetik nevrit,herpes zoster, santral sinir sistemi komplikasyonları, Wernicke sendromu, 
Korsakoff psikozu, pridoksin eksikliğine bağlı konvülziyonlar, prementrüel sendroma bağlı 
psikolojik rahatsızlıklar, idyopatik ve yaşlılığı bağlı tremor.
Çeşitli ağrılar : Artrit, periartrit, siyatalji, lumbalji, artralji, miyalji, kramplar 
trigeminal nevralji,romatizma ağrıları.
Çeşitli Entoksikasyonlar : Alkolizm, gebelik kusmaları, ameliyat sonrası kusmalar, 
radyasyon hastalığı, diyabet komlikasyonları, izoniyazid, hidralazin ve oral kontraseptiflere 
bağlı komplikasyonlar.
Dolaşım Sistemi Komplikasyonları : Anemi (hipokromik, sideroblastik, megaloblastik lipit ve 
aplastik vs...) kalp yetmezlikleri, kalp büyümesi, trombus tehdidi.
Karbonhidrat, lipid ve kolesterol metabolizması bozuklukları :
Cilt ve mukozada lezyonlar : (Seboreye benzeyen).
Ürolojik komplikasyonlar : Oksalat taşı oluşumuna karşı.

Kontrendikasyonları:

Tiamin hidroklorür ve Pridoksin hidroklorür'e aşırı duyarlılığı olanlarda kontrendikedir.

Uyarılar/Önlemler:

Uzun süreli ve yüksek doz pridoksin uygulaması ile periferal nöropati gelişebilir.
Pridoksin levodopa' nın etkilerini azaltır, periferik dopadekarboksilaz enzimleri olmadan bir 
arada kullanılmamalıdırlar.

Hamilelerde ve Emziren kadınlarda Kullanımı : Hamilelerde özellikle ilk üç aylık dönemde 
kullanılmaması gerekir. Pridoksinin laktasyonu inhibe ettiğine dair bulgular olduğu için,
emziren kadınlarda kullanılmaması tavsiye edilmektedir.

Yan etkiler/Advers etkiler:

Yüksek dozlarda bile çok iyi tolere edilir. Pridoksin için el ve ayaklarda hissizlik, 
ağırlaşma gibi bazı vakalar bildirilmiştir.

İlaç etkileşimleri:

İsoniazid, oral kontraseptifler, hidralazin ve penisilamin pridoksin itrahını artırır. 
Pridoksin levadopa' nın etkilerini azaltır. Tiamin metabisülfit, fenobarbital, sulu çözeltilerde 
riboflavin, bazı oksidan ve redüktanlar, demir sülfat, civa klorür gibi bazı tuzlarla geçimsizdir.

Kullanım şekli ve dozu:

Proflaksi : Günde 1-2 tablet
Tedavi : Günde 2-4 tablet

DOZ AŞIMI :

Uzun süreli yüksek doz pridoksin kullanıldığında (Örn : 2-40 ay süre ile günde 2-6 gram) periferik 
nevrit ve nörolojik zafiyet gelişmektedir. Bu durumda, ilaç derhal kesilerek destekleyici önlemler 
alınmalıdır.



";
        }

        private void label24_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox1.ImageLocation = "dekortamp1.jpg";
            pictureBox2.ImageLocation = "dekortamp2.jpg";
            label4.Visible = true;
            label4.Text = @"
Farmakolojik özellikleri:

Endikasyonları:

Farmasötik şekle göre: Enflamatuar ve allerjik hastalıkların supresyonunda, şokta, 
Cushing Hastalığı teşhisinde, konjenital adrenal hiperplazide, serebral ödemde, 
intraartiküler enjeksiyonla romatoid artritte endikedir.

DEKORT Tablet 0.75 mg antienflamatuvar, antiromatizmal ve antiallerjik tesirlerinden 
dolayı, kortikosteroidlerle tedaviye cevap veren vakaların hepsinde kullanılır.

Romatizmal Hastalıklar
Ör: Romatoid artrit
Allerjik Hastalıklar
Ör: Anjinörotik ödem, anafilaksi
Dermatolojik Hastalıklar
Ör: Pemghigus
Arteritis Collagenosis
Ör: Polyarteritis nodosa
Solunum Sistemi Hastalıkları
Ör: Bronşiyal astma, aspirasyon pnömoniti
Oftalmik Hastalıklar
Ör: Anterior ve posterior uveit, optik nörit.
Hematolojik Bozukluklar
Ör: Hemolitik anemi, lösemi, myeloma
Kardiyovasküler bozukluklar
Ör: Post-myokard enfarktüsü sendromu
Hiperkalsemi
Ör: Sarkoidosis
Enfeksiyonlar
Ör: Miliyer tüberküloz (uygun kemoterapi ile birlikte)
Kas hastalıkları
Ör: Polymyositis
Ödeme Yol Açan Hastalıklar
Ör: İdiopatik veya lupus erythematosus' un neden olduğu nefrotik sendrom.
Gastrointestinal Sistem Hastalıkları
Ör: Ülseratif kolit,Crohn hastalığı
Nörolojik bozukluklar
Ör: Serebral tümörlerle birlikte görülen beyin ödemleri
Endokrin Bozukluklar
Ör: Primer veya sekonder adrenokortikal kifayetsizlikler, konjenital adrenal hiperplazi,

Damla:

Göz Hastalıkları:

Konjonktiva, kornea ve göz küresinin ön kesiminin steroid tedavisine cevap veren enflamatuar 
hastalıklarında endikedir. Bunlar arasında allerjik konjonktivit, akne rosacea, yüzeysel iritis, 
siklit sayılabilir.
DEKORT ödem ve enflamasyonun giderilmesi için steroid kullanımının uygun görüldüğü yabancı 
cisimlerin batmasının, termal veya kimyasal yanıkların neden olduğu kornea hasarları vakalarında 
da tatbik edilir.

Kulak hastalıkları:
Alerjik dış kulak iltihabı, steroid kullanımının ödem ve enflamasyonun giderilmesi için gerekli 
görüldüğü pürülan ve non pürülan enfeksiyöz dış kulak iltihabı.

Kontrendikasyonları:

Canlı aşı uygulanması, gebelik, aşırı duyarılılık, akut enfeksiyon ve Herpes zoster'de 
kontrendikedir.

Uyarılar/Önlemler:

Peptik ülser, osteoporosis, psikoz, kalp yetmezliği, böbrek yetmezliği, diyabet, yaşlılık ve 
tüberkülozda kullanılmaz. Yavaç enjeksiyonla uygulanır. (i.v.enjeksiyonlar 10 dakika). Barbitürat,
fenitoin ve rifampisinle birlikte kullanılmaz.

Yan etkiler/Advers etkiler:

Ay yüz, yağ depolanması, ödem, hipertansiyon, deride atroti, depresyon, peptik ülser, 
hipergilsemi, halsizlik ve göz içi basıncında artma gibi yan etkiler görülebilir.

İlaç etkileşimleri:

Dehydrobenzperidol için belirli bir etkileşim bildirilmemiştir. Ancak MSS dpresanı olarak diğer 
MSS aktif ilaçların etkinliğini arttırabilir.

Kullanım şekli ve dozu:

Ampul: akut devrelerde kullanılır. Günlük doz 4-20mg'dır (max. 80mg).Tablet: Günlük doz 
0.75-9 mg'dır. Bu doz 3-4 kısma bölünerek verilir.Kronik durumlarda günlük doz 1.5-3 mg ve 
idame doz ise 0 75 mg'dır. Damla: Günlük doz 3-4x1-2 damladır.

Tedavi süresi lezyonun tipine bağlıdır ve alınan cevaba göre birkaç günden birkaç haftaya kadar 
değişebilir.

Göz:
Başlangıçta gündüzleri her saatte ve geceleri her iki saatte bir göze 1-2 damla damlatılır.
Tedaviden cevap alındıktan sonra uygulama 3-4 saatte bir 1 damla olarak azaltılır ve daha 
sonraları günde 3-4 defa 1 damla damlatılması yeterli olur.

Kulak:
Kulak iyice temizlenip kurulandıktan sonra günde 2-3 defa 3-4 damla kulak kanalına damlatılır.
Tedaviden cevap alındıktan sonra doz giderek azaltılır.

Diğer kortikosteroidlerde olduğu gibi DEKORT'un dozu da hastalığın türü, şiddeti ve hastanın 
reaksiyonuna göre ayarlanır.

Günlük doz 0.75-9 mg arasında değişebilir.
Ancak ağır vakalarda daha yüksek dozlar verilebilir. Günlük dozun 3 veya 4 kısma bölünerek 
verilmesi gerekir.

Tedavide;

Romatoid artrit ve kronik astma bronşiyal gibi kronik vakalarda;
Günde 1.5-3 mg, idame dozu ise 0.75 mg' dır.
Şiddetli mevsim astması, akut deri hastalıkları, akut ülseratif kolit gibi akut hastalıklarda;
Günde 2-3 mg' dır.
Romatizma, dissemine lupus eritematosus, nefrotik sendrom gibi kronik hastalıklarda;
Günde 2-4.5 mg kullanılır.
Hayatı tehdit eden status asthmaticus gibi ciddi durumlarda ve hemopatilerde;
Hekim gerekli bulursa başlangıç dozu olarak 7-10 mg verilebilir.
İdame dozu belirtiler yeterince düzelince gerekli görülen minimum doza kadar giderek 
azaltılarak tayin edilir.
Deksametazon'un idame dozu ortalama olarak günde 1-1.5 mg arasında olup bazı vakalarda 
günlük 0.75 mg' lık doz yeterli gelmektedir.

Deksametazon ile uygulanan testlerde:

Cushing Sendromu:
Gece 11' de 1 mg DEKORT oral olarak verilir. Sabah 8' de plazma kortizol düzeyini tayin 
etmek üzere kan alınır. Daha kesin bir sonuç temini için 48 saat süre ile 6 saatte bir 
0.5 mg DEKORT tablet verilir. Bunu takip eden 24 saatteki idrar toplanır ve itrah edilen 
17-hydroksikortikosteroid miktarı tayin olunur.

Pitiuter ACTH fazlalığına bağlı Cushing Sendromunu diğer sebeplerden kaynaklanan Cushing 
Sendromundan ayırmak için:
48 saat süre ile 6 saatte bir 2 mg DEKORT oral olarak verilir. Daha sonraki 24 saat idrar
toplanır ve itrah edilen 17-hydroksikortikosteroid miktarı tayin olunur.


";
        }

        private void label25_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox1.ImageLocation = "dodex1.jpg";
            pictureBox2.ImageLocation = "dodex2.jpg";
            label4.Visible = true;
            label4.Text = @"
Formülü:

Her ampul 1000 mcg B12 vitamini (siyanokobalamin) ihtiva eder.

Farmakolojik özellikleri:

Endikasyonları:

Pernisiyöz anemi,
B12 vitamini eksikliğinden kaynaklanan hiperkrom makrositer anemi,
Trigeminus nevraljisi,
Siyatik
Akut nevrit ve nevraljilerde

Kontrendikasyonları:

İdiopatik hipertrofik subaortikstenozda kontrendikedir.

Uyarılar/Önlemler:

Omurilik yan ve arka kordonundaki subakut dejenerasyonlarda semptomları maskeleyebileceğinden
tam teşhis konmadan önce verilmemelidir. Optik nöropatileri kötüleştirebilir. B12 vitaminiyle 
aneminin tedavisi sırasında folik asit, demir ve potasyum tuzları vermek gerekebilir. Metformin, 
potasyum sitrat, kalsiyum glukonat, kolşisin ve PAS'la birlikte kullanılmaz. Işıktan korunmalıdır.

Yan etkiler/Advers etkiler:

Taşikardi, hipertansiyon, sistolik kan basıncında belirgin artış, bulantı, baş ağrısı, anjinal ağrı 
ve göğüs ağrısı gibi yan etkiler görülebilir.

İlaç etkileşimleri:

Yoktur.

Kullanım şekli ve dozu:

Akut nevraljilerde:

Günde 500-1000 mcg B12 vitamini İ.M. olarak verilir.
Akut nevrit ve nevraljilerde tedavinin 10 gün sürdürülmesi tavsiye edilir.
Zamanla nüks eden vakalarda yeniden bir DODEX kürü yapılmalıdır.

Pernisiyöz anemi ve hiperkrom makrositer anemide:

Tedaviye gün aşırı 250-1000 mcg B12 vitamini (İ.M.) verilerek başlanır ve bu uygulama 
1-2 hafta sürdürülür.
Daha sonra, kan tahlilleri hastanın normale döndüğünü kanıtlayana kadar, haftada 1 defa 
250 mcg B12 vitamini (İ.M.) tatbik edilir, ancak hastada nörolojik komplikasyonlar mevcutsa 
günaşırı 1000 mcg B12 vitamini (İ.M.) verilmeye devam edilir.
Hastanın kan tahlili sonuçları düzeldiğinde gösterdiğinde, ayda 1 defa 1000 mcg B12 vitamini 
İ.M. olarak tatbik edilerek idame tedavisi uygulanır.




";
        }

        private void label26_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox1.ImageLocation = "deltacortril1.jfif";
            pictureBox2.ImageLocation = "deltacortril2.jpg";
            label4.Visible = true;
            label4.Text = @"
Formülü:

DELTACORTRIL Tablet 5 mg. prednisolon içerir.

Farmakolojik özellikleri:

Endikasyonları:

Endokrin bozukluklar
Primer ve sekonder adrenokortikal yetmezlik (hidro-kortizon veya kortizon ilk seçenektir;
gerekli hallerde sentetik analoglar mineralortikoid'ler ile birlikte kullanılabilirler; 
bebeklerde mineralokortikoid takviyesi özel önem taşır).
Konjenital adrenal hiperplazi
Non-süpüratif tiroidit
Kanserle birlikte görülen hiperkalsemi
Romatizmal hastalıklar
Kısa süre için yardımcı tedavi olarak verilmek üzere (hastanın akut bir hadiseyi veya 
alevlenmeyi atlatabilmesi için):
Psoriatik artrit
Romatoid artrit, juvenil romatoid artrit (seçilmiş vakalar düşük doz idame tedavisi 
gerektirebilir)
Ankilozan spondilit
Akut ve subakut bursit
Akut non-spesifik tenosinovit
Akut gut artriti
Posttravmatik osteoartrit
Osteoartrit sinoviti
Epikondilit
Kollajen hastalıklar
Bir alevlenme esnasında veya seçilmiş vakalarda idame tedavisi olarak:
Sistemik lupus eritematosus
Sistemik dermatomiyozit (polimiyozit)
Akut romatizmal kardit
Deri hastalıkları
Pemfigus
Bullöz herpetiform dermatit
Şiddetli eritema multiforme (Stevens-Johnson Sendromu)
Eksfoliatif dermatit
Mikozis fungoides
Şiddetli psoriaz
Şiddetli seboreik dermatit
Alerjik durumlar
Geleneksel tedavinin yeterli miktarına rağmen geçmeyen şiddetli veya faaliyeti engelleyen 
alerjik durumları kontrol altına almak için:
Mevsime bağlı veya perennial alerjik rinit
Bronşial astma
Kontakt dermatit
Atopik dermatit
Serum hastalığı
İlaç aşırı duyarlılık reaksiyonları
Göz hastalıkları
Göz ve etrafındaki dokuların şiddetli, akut veya kronik, alerjik veya enflamatuar 
rahatsızlıkları:
Alerjik konjonktivit
Keratit
Alerjik marjinal kornea ülserleri
Oftalmik herpes zoster
Irit ve iridosiklit
Korioretinit
Anterior segman enflamasyonu
Diffüz posterior uveit ve koroidit
Optik nörit
Sempatik oftalmi
Solunum yolu hastalıkları
Semptomatik sarkoidoz
Diğer yöntemlerle tedavi edilemeyen Loeffler sendromu
Berilioz
Fulminan veya disemine akciğer tüberkülozu - uygun antitüberkülö kemoterapi ile birlikte 
kullanılarak
Aspirasyon pnömonisi
Hematolojik bozuklukluklar
Erişkinde idiopatik trombositopenik purpura
Erişkinde sekonder trombositopeni
Kazanılmış (oto-immün) hemolitik anemi
Eritroblastopeni (kırmızı kan hücresi anemisi)
Konjenital (eritroid) hipoplastik anemi
Neoplastik hastalıklar
Şunların palyatif tedavisinde:
Erişkinde lösemiler ve lenfoma'lar
Çocuklukta akut lösemi
Ödem durumları
Üremisiz idiopatik veya lupus eritematosus'a bağlı nefrotik sendromda diürezi başlatmak 
veya proteinüriyi durdurmak için.
Gastro-intestinal hastalıklar
Hastanın, hastalığın kritik bir dönemini atlatabilmesi için:
Ülseratif kolit
Rejyonel enterit
Muhtelif
Subaraknoid blok teşekkül etmiş veya etmek üzere olan tüberküloz menenjit'de uygun 
antitüberkülö kemoterapi ile birlikte kullanmak üzere
Nörolojik veya myokardial tutulum gösteren trişinozda.

Kontrendikasyonları:
Prednisolon sistemik mantar enfeksiyonu bulunan hastalarda kontrendikedir.
Tablet formülünde yer alan maddelerden herhangi birisine aşırı duyarlılığı olanlarda kontrendikedir.

Uyarılar/Önlemler:

Kortikosteroid alan hastalar alışılmışın üstünde strese maruz kaldıklarında, stres durumundan 
önce, o sürede ve stresden sonra doz artırımı gerektirebilirler.

Kortikosteroidler enfeksiyonun bazı belirtilerini maskeleyebilirler veya kullanım sürelerinde 
yeni enfeksiyonlar ortaya çıkabilir. Kortikosteroidler kullanıldığında direnç düşüklüğü ve 
enfeksiyonu lokalize etme güçlüğü olabilir.
Kortikosteroidlerin uzun süre kullanılışı posterior subkapsüler kataraktlara, glokoma ve 
muhtemel optik sinir hasarına yol açabilir, ve mantarlar veya virüslerle sekonder oküler 
enfeksiyon oluşumunu kolaylaştırabilirler.
Gebelikte kullanılışı
Yeterli reprodüktif çalışmalar mevcut olmadığından, bu ilaçların gebelikte, emziren annelerde 
veya gebe kalabilecek kadınlarda kullanılması, ilacın muhtemel faydalarının ana ve fetüse 
olabilecek zararlarına karşı tartılmasını gerektirir. Gebelik sırasında önemli dozlarda 
kortikosteroid kullanmış annelerden doğan bebekler, hipoadrenalizm belirtileri yönünden 
dikkatle gözlenmelidir. 
Orta veya yüksek dozda hidrokortizon ve kortizon, kan basıncı yükselmesi, tuz ve su tutulması
ve potasyum itrahında artma yapabilir. Bu etkiler, yüksek dozda kullanım dışında, sentetik 
türevlerle daha az bir ihtimalle ortaya çıkar. Diyette tuz kısıtlaması ve ilave potasyum 
verilmesi gerekebilir. Bütün kortikosteroidler kalsiyum atılımını artırırlar.
Aktif tüberkülozda DELTACORTRIL kullanımı, uygun antitüberkülö tedavi rejimi ile 
kortikosteroidlerin birlikte kullanıldığı fulminan veya disemine tüberküloz vakalarına 
sınırlandırılmalıdır. Latent tüberkülozlu veya tüberkülin reaktivitesi olan hastalarda 
kortikosteroidler gerekiyorsa, hastalığın reaktivasyonu olabileceğinden yakın gözlem lazımdır.
Bu hastalarda uzun süreli kortikosteroid tedavisi süresince kemoprofilaksi yapılmalıdır.
İmmünosüpresyon yapan ilaçlarla tedavi edilmekte olan çocuklar enfeksiyonlara sağlıklı 
çocuklara oranla daha fazla duyarlıdırlar. Örneğin su çiçeği ve kızamık immünosüpresan 
kortikosteroid almakta olan çocuklarda daha ağır, hatta ölümcül seyredebilir. Bu hastalıkları 
geçirmemiş olan çocuk ya da erişkinler kortikosteroidleri immünosüpresyon yapacak dozda 
almakta iseler, su çiçeği ve kızamık geçirmekte olan kişilerle temastan kaçınmaları ve 
temas etmiş olmaları durumunda hekime başvurmaları konusunda uyarılmalıdırlar. 
Temas durumunda varicella zoster immünoglobulin (VZIG) ya da toplanmış (pooled) 
intravenöz immünoglobulin (IVIG) kullanılması endike olabilir. Hastada su çiçeği görülürse 
antiviral ajanlarla tedavi düşünülmelidir. İlaçla oluşan sekonder adrenokortikal yetmezlik,
dozajda tedrici azaltma yaparak asgariye indirilebilir. Bu tip nisbi yetmezlik, tedavi
kesildikten sonra aylarca sürebilir. Dolayısıyla bu devrede olabilecek stres durumlarında
hormon tedavisi yeniden başlatılmalıdır. Mineralokortikoid sekresyonu bozulabileceğinden 
tuz ve/veya beraberce bir mineralokortikoid uygulanmalıdır.

Hipotiroidizmli veya sirozlu hastalarda kortikosteroidlerin etkisinde artma olur.
Oküler herpes simpleksli hastalarda, muhtemel perforasyondan dolayı kortikosteroidler
ihtiyatla kullanılmalıdır.
Tedavi edilen durumu kontrole yeterli mümkün olan en düşük kortikosteroid dozu 
kullanılmalıdır ve doz indirmesi imkanı olunca bu azaltma tedricen yapılmalıdır.

Kortikosteroidler kullanılırken, öfori, uykusuzluk, mizaç dalgalanmaları, kişilik değişmeleri
ve şiddetli depresyondan açık psikotik belirtilere kadar değişik psişik bozukluklar görülebilir.
Kortikosteroidler aynı zamanda psikotik eğilimlerin mevcut emosyonel istikrarsızlığını artırabilir.
Steroidler, perforasyon ihtimali bulunan non-spesifik ülseratif kolit, abse veya diğer pyojenik 
enfeksiyon; divertikülit; yeni intestinal anastomoz; aktif veya latent peptik ülser; renal yetmezlik;
hipertansiyon; osteoporoz ve myastenia graviste ihtiyatla kullanılmalıdır.
Uzun süreli kortikosteroid tedavisi gören bebek veya çocukların büyüme ve gelişmeleri dikkatle 
gözlenmelidir.

Yan etkiler/Advers etkiler:

Sıvı ve Elektrolit Bozukluklukları
Sodyum tutulması
Sıvı tutulması
Eğilimli hastalarda konjestif kalp yetmezliği
Potasyum kaybı
Hipokalemik asidoz
Hipertansiyon
Muskulo-skeletal
Kas güçsüzlüğü
Steroid myopatisi
Kas kitlesi kaybı
Osteoporoz
Omurgada kompresyon fraktürleri
Femur ve humerus başında aseptik nekroz
Uzun kemiklerde patolojik fraktür
Gastrointestinal
Peptik ülser ile muhtemel perforasyon ve kanama
Pankreatit
Abdominal gerginlik
Ülseratif özofajit
Dermatolojik
Hafif hirsutism
Yara iyileşmesinde bozulma
Incelmiş ve nazik deri
Peteşi ve ekimoz'lar
Yüzde eritem
Artmış terleme
Deri testleri baskılanabilir
Nörolojik
Konvülsiyonlar
Genellikle tedaviden sonra artmış intrakranial basınç ve papilla ödemi (psödo-tümör serebri)
Vertigo
Başağrısı
Endokrin
Menstrüel düzensizlikler
Cushingoid durum gelişmesi
Çocuklarda büyüme-gelişme geriliği
Sekonder adrenokortikal ve hipofizer cevapsızlık, özellikle travma, cerrahi veya hastalık gibi 
stres zamanlarında
Karbonhidrat toleransında azalma
Latent diabetes mellitus belirtileri
Diabetiklerde insülin veya oral hipoglisemik ilaçlara gereksinme artması
Oftalmik
Posterior subkapsüler kataraktlar
Intraoküler basınç artması
Glokom
Ekzoftalmi
Metabolik
Protein katabolizmasına bağlı negatif azot dengesi

İlaç etkileşimleri:

Hepatik mikrozomal enzim indükleyicileri
Barbitüratlar, fenitoin ve rifampin gibi karaciğer mikrozomal enzim indüksiyonu yapan ilaçlar 
glukokortikoid metabolizmasını artırabilirler. Bu nedenle, glukortikoid tedavisi ile stabilize 
durumdaki hastalarda bu ilaçların da birlikte kullanımına başlanması ya da bu ilaçların 
kullanımlarının kesilmesi durumlarında glukokortikoid tedavisinde doz ayarlaması yapmak 
gerekebilir.
Östrojenler
Östrojenler muhtemelen transkortin konsantrasyonunu artırarak ve buna bağlı olarak metabolize 
edilebilecek hidrokortizon miktarını azaltmak yolu ile hidrokortizonun etkilerini artırabilirler. 
Transkortine bağlanan diğer glukokortikoidlerin etkileri de benzer şekilde artabilir ve 
prednisolon tedavisi sırasında östrojenlerin tedaviye eklenmesi ya da tedaviden çıkarılması söz
konusu ise, doz ayarlaması gerekebilir.
Non-steroid anti inflamatuar ajanlar
Indometasin gibi ülserojen ilaçların kortikosteroidlerle birlikte verilmesi gastrointestinal
ülserasyon riskini artırabilir. Hipoprotrombinemili hastalarda aspirin ve glukokortikoid 
kombinasyonu dikkatle uygulanmalıdır. Salisilatlar ve glukokortikoidlerin birlikte kullanımı 
gastrointestinal ülserasyon ensidansını ve ciddiyetini artırmamakla birlikte, böyle bir etki 
olasılığı akılda bulundurulmalıdır.
Her iki ilaç birlikte kullanıldığında, serum salisilat düzeyleri düşebilir. Benzer şekilde, 
salisilat almakta olan hastalarda kortikosteroid tedavisi kesilirse, serum salisilat konsantrasyonu 
artabilir ve nadiren salisilat intoksikasyonu görülebilir. Salisilatlar ve kortikosteroidler birlikte 
dikkatle kullanılmalıdırlar. Her iki ilacı da almakta olan hastalar her iki ilacın advers etkileri
yönünden dikkatle izlenmelidir.
Potasyum kaybettirici ajanlar
Potasyum kaybettirici diüretikler (örneğin, tiazidler, furosemid, etakrinik asit) ve amfoterisin B 
gibi potasyum kaybettirici diğer ilaçlar glukokortikoidlerin potasyum azaltıcı etkilerini 
güçlendirebilirler. Glukokortikoidler ve potasyum kaybettirici ilaçları birlikte alan hastalarda serum 
potasyumu dikkatle izlenmelidir.
Antikolinesteraz ajanlar
Glukokortikoidler ve ambenonium, neostigmin ya da piridostigmin (ve muhtemelen organofosfat 
antikolinesteraz pestisidler) gibi antikolinesteraz ajanlar arasındaki etkileşim myastenia gravisli 
hastalarda ağır kas zaafiyetine neden olabilir. Mümkünse glukokortikoid tedavisine başlamadan 
en az 24 saat önce antikolinesteraz tedavisi kesilmelidir.
Aşılar ve toksoidler
Kortikosteroidler antikor cevabını inhibe edeceklerinden toksoidlere ve canlı ya da inaktive aşılara 
cevabı azaltabilirler. Ayrıca, kortikosteroidler canlı atenue aşılarda bulunan bazı organizmaların
üremesini kolaylaştırabilirler. Ilaçların suprafizyolojik dozları bazı aşılara karşı nörolojik 
reaksiyonları kuvvetlendirebilirler. Kortikosteroid tedavi devam ederken aşı ya da toksoidlerin 
rutin uygulanmaları ertelenmelidir. Kortikosteroid almakta olan bir hastada immünizasyon gerekli 
ise antikor cevabının yeterli olup olmadığının serolojik testlerle araştırılması ve aşı ya da 
toksoidin ilave dozları gerekebilir.
Oral antikoagülanlar
Nadiren, kortizonun kan pıhtılaşmasını artırdığı ve oral antikoagülanlarla tedavi edilmekte olan 
hastalarda antikoagülan dozunun artırılmasını gerektireceği bildirilmektedir.

Kullanım şekli ve dozu:

DELTACORTRIL'in başlangıç dozu, tedavi edilen spesifik hastalığa göre, günde 5-60 mg. 
arasında değişir. Az şiddetli durumlarda düşük dozlar genellikle yeterli olursa da, seçilmiş 
hastalarda yüksek inisyal dozlar gerekebilir. Tatminkar bir cevap alınana kadar başlangıç dozları 
devam ettirilir veya ayarlanır. Makul bir süreden sonra yeterli klinik cevap yoksa DELTACORTRIL
kesilerek hasta başka uygun bir tedaviye geçirilir.

DOZ GEREKSINMELERININ DEĞIŞKEN OLDUĞU VE TEDAVI EDILEN HASTALIĞA 
VE HASTANIN CEVABINA GÖRE KIŞISEL OLARAK AYARLANMASI GEREKTIĞI 
VURGULANMALIDIR.

Olumlu bir cevap alındıktan sonra başlangıç dozunu uygun aralıklarla ve küçük miktarlarla 
azaltarak, elde edilen yeterli klinik cevabı devam ettirecek en düşük idame dozları saptanmalıdır.
Ilaç dozajının sürekli izlenmesi lüzumu hatırda tutulmalıdır. Doz ayarlamalarını gerekli kılan 
haller arasında, hastalık sürecindeki iyileşme ve alevlenmelere bağlı klinik durum değişmeleri, 
hastanın ilaca verdiği kişisel cevap ve tedavi edilen hastalıkla direkt bir ilişkisi olmadan 
hastanın streslere maruz kalmasının etkileri sayılabilir ki bu son durumda DELTACORTRIL 
dozunu, hastanın durumuyla orantılı bir süre için artırmak gerekebilir. Uzun süreli tedaviden 
sonra ilacıkesmek gerekirse, ani değil tedricen azaltarak kesmek tavsiye edilir.

Çocuklarda kullanım

Erişkin dozlarının uygun olarak azaltılmış miktarı kullanılmakla birlikte genellikle erişkinlerde 
olduğu gibi dozaj klinik cevaba göre ayarlanır. Kortikosteroidler bebeklik, çocukluk ve ergenlikte 
büyüme geriliğine neden olurlar. Tedavi minimum dozaj ve mümkün olan en kısa süre ile 
sınırlandırılmalıdır. Hipotalamo - hipofizer adrenal aksis süpresyonunun ve büyüme geriliğinin 
en aza indirilmesi için mümkünse tedavi günaşırı ve tek doz halinde uygulanmalıdır.

Doz Aşımı

Glukokortikoidlerin doz aşımına bağlı toksisite ve/veya ölüm nadir olarak bildirilmektedir. 
Doz aşımı durumunda spesifik bir antidot olmayıp tedavi destekleyici ve semptomatiktir. 
Serum elektrolitleri monitorize edilebilir.





";
        }

        private void label27_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox1.ImageLocation = "endoxan1.jpg";
            pictureBox2.ImageLocation = "endoxan2.jpg";
            label4.Visible = true;
            label4.Text = @"
50 mg draje / 500 mg i.v / 1 g i.v flakon

Farmakolojik özellikleri:

Endikasyonları:

Lösemiler,özellikle kronik lenfositer ve miyeloid lösemi, maliyn lenfomalar, paraptoinemiler,
Waldenström hastalığı, maliyn solid tümörler,özellikle over ve meme kanseri,nöroblastoma, 
seminoma, Ewing sarkomu, kemoterapiye duyarlı tümörlerin postoperatif ajuvan tedavisi.
Ramatoid artrit, dahil otoimmün hastalıklar, arthropati psoriatica, lupus eritamatosuz, 
skledormia, Myasthenia gravis, otoimmünhemolitik anemi, soğuk aglütinasyon hastalıkları, 
nefrotik sendrom gibi  otoimmün hastalıklar, organ trnspllantasyonları.
(500-1 gr flakon-50 mg draje için)

200 mg flakon için (eriticili): Başlangıç tedavisi genel olarak intravenöz zerkler şeklinde 
olmalıdır. Endoxan gerktiğinde adele içine, periton ve plevra boşluğuna zerkedilebilir, 
intralenfatik ve intratekal uygulanabilir. Tatmin edici cevap alındıktan sonra Endokxan draje
ile idame tedavisine geçilmesi salık verilmektedir.

Kontrendikasyonları:

Siklofosfamide aşırı duyarlığı bilinenlerde, kemik iliği depresyonu olanlarda, hamilellerde 
kullanılmamalıdır.(500-1 gr flakon-50 mg draje için)

Uyarılar/Önlemler:

Siklofosfamid tedavisi sırasında düzenli olarak kan sayımı yapılmalıdır. Lökosit sayısında 
anlamlı azalma genellikle yüksek doz uygulamasıyla meydana gelmektedir. gerektiğimde doz 
azaltılmalı, tedaviler arasındaki süre artırılmalı veya tedavi kesilmelidir. Siklofosfamid 
uygulamasından sonra görülen lökopeni geri dönüşümlüdür. Sadece ağır lökopeni vakaların kan
tranfüzyonu ve gamma-globulin uygulaması gerekebilir.Kullanım öncesinde mevcut kemik iliği
depresyonu yoksa, trombosit ve eritrosit yapımı çok az etkilenir.Nadiren trombositopeni ve 
anemi gelişir. Bu hematolitik etkiler ilacın dozunu azaltarak veya tedaviyi keserek geri 
çevrilebilir. Siklofosfamid ile tedavi edilen hastalarda idrar yolları ile ilgili bazı 
reaksiyonlar gelişebilir. Bu nadenle idrar sedimenti takip edilmelidir. Sistit oluşumunu 
önlemek için ENDOXAN uygulaması sırasında veya hemen sonrasında bol miktarda sıvı alımı 
tavsiye edilir. Gerektiğinde idrar çıkışını arttırmak için önlemler alınmalıdır. 10 mg/kg
veya daha yüksek dozlarda ve bu konuda yüksek risk taşıyan hastalarda ayrıca mesna ile 
korunmalıdırlar. Eğer mesna ile profilaksi uygulanmamışsa veya yetersiz ve sistit ya da 
idrarda kan görülürse ENDOXAN'la tedaviye son verilmelidir. Özellikle yüksek doz siklofosfamid 
uygulaması sırasında immün sistemin baskılanacağı göz önünde tutulmalıdır. Bunun sonucu 
olarak fetal enfeksiyonlar gelişebilir. Bu nedenle özellikle yüksek doz uygulandığında uygun 
antibiyotik ve antimikotik koruma önemlidir. Endoxan şeker hastalarına dikkatle verilmelidir.
Yaşlılarda ve güçsüz hastalarda, böbrek ve karaciğer yetmezliği olanlarda, adrenelektomi 
geçirmiş hastalarda azaltılmış dozlar uygulanmalıdır. Tedavinin başlangıcında normal olan 
böbrek ve karaciğer fonksiyonları siklofosfamid etkisi ile bozulmaz. Kullanım sırasında 
nadiren görülen mide bulantısı ve kusmayı önlemek için antiemetik verilmesi önerilir.
Hamilelerde kullanılmamalı, çocuk doğurma potansiyeli olan kadınlara siklofosfamid ile tedavi 
sırasında hamile kalmaktan kaçınmaları önerilmektedir. (500-1 gr flakon için)

Yan etkiler/Advers etkiler:

ENDOXAN'a genel ve lokal tolerans iyidir. Sıklıkla ve özellikle yüksek dozlar kullanıldığında,
mide bulantısı, kusma veya baş ağrısı gözlenmiştir.Siklofosfamidle tedavi edilen hastalarda 
sıklıkla alopesi meydana gelir. Renkte farklılık olamkla beraber tedavi sirasında veya sonrasında
saçlar tekrar uzar. Kaza deride renk değişimi ve tırnaklarda değişiklikler meydana gelebilir. 
Gonad fonksiyonlarında azalma görülebilir. Yüksek dozda uygulandığından interstiyel Pulmoner 
fibrozis ve kardiyak toksisite görülebilir. (500-1 gr flakon-50 mg draje için)

200 mg flakon( eriticili):

ENDOXAN'a genel tahammül iyi olmakla beraber bazen, özellikle yüksek dozlu uygulamada, 
bulantı, kusma ve baş ağrısı görülebilir. Böyle vakalarda ya bir analjezik veya bir antienemik
kullanılabilir.Bazı ahvalde reverzibl saç dökülmesi meydana gelebilir. Tedavinin başında hastaya 
saçlarının dökülebileceğini bildirmek salık verilir. Büttün stotatiklerde olduğu gibi ENDOXAN 
uygulaması sırasında da kan tablosumuhtazam olarak kontrol edilmelidir. Özellikle yüksek dozlu 
tedavi sırasında lökositlerin azaldıkları görülebilir. Bu gibi durumlarda doz azalştılmalı, 
gerekirse tedavi durdurulmalıdır. ENDOKSAN'a bağlı lökopenilerin bir özelliği süratle reverzibl 
oluşlarıdır. Ancak ciddi lökopenilerde gerekirse kan nakline ve kortikosteroid uygulamasına baş 
vurulmalıdır. Tedavi sırasında non-bakteriyel hemorajik sistit görülebilir. ENDOXAN gebeliğin 
ilk üç ayında kontrendikedir.

İlaç etkileşimleri:

Oral antikoagülanların etkisini arttırır.

Kullanım şekli ve dozu:

İ.V yolla siklofosfamid başlangıç tedavisi aşağıdaki dozlarda önerilir; Günde 3-6 mg/kg vücut 
ağırlığı (200-400 mg) veya 2 veya 5 gün aralıklı yoğun tedavi için 10-15 mg/kg vücut ağırlığı 
(500-1000 mg) veya 10-20 gün aralıklı yoğun tedavi için 20-40 mg/kg vücut ağırlığı idame tedavisi
için günde 50-200 mg/kg siklofosfamid (1-4 draje) oral yolla verilebilir. ENDOXAN sabahları 
uygulanmalıdır. Uygulama esnasında ve haman sonrasında hastaya bol sıvı verilmelidir. 
(500-1gr flakon-50 mg draje için)

200 mg flakon için(Eriticili): Doz hastanın genel durumu veb lökosit sayısı göz önüne alınarak 
kişisel olarak düzenlenmelidir. Salık verilen başlangıç tedavisi doz şemaları aşağıda gösterilmiştir. 
Mutat doz şeması: Bir defada yeterli doz verilemediğinden ve her gün uygulama gerektiğinde 
bu tedavi şemasından halen vazgeçilmiş gibidir. Doz: 1 zerkte kg/3-6 mg. (total 200-400 mg) dır. 
Günlük doz lökozit sayısını 3000 de tutacak bir biçimde ayarlanır.

Lökositler 2000'e düşünce tedavi durdurulur, 4000'e çıkınca yeniden başlanır. Kullanılan 
200-400 mg lık günlük doz hastanın verdiği cevaba ve lökosit sayısına göre her gün ya da gün 
aşırı uygulanır. Bir kür ortalama 6-8 gr dır. Gerekirse 12 kg kadar çıkabilir.

Hutedil masif doz şeması: Bir defada yeterli doz verildiğinden ve hergün uygulama külfetini 
kaldırdığından  halen tercih edilen şemadır. Doz: 1 zerkte kg/10-15 mg (total 500-1000 mg) dır.
Doz lökosit sayısı 5000'e varınca yapılır. Bir kür 6-10 zerkte biter.
Masif doz şeması: Bu tedavi için ancak tecrübeli uzmanlar tarafından hastanede yatan hastalara 
uygulanabilir. Doz: 1 zerkte kg/20-40 mg (total 1.4-2.8 gr) dır. Tedavi lökosit sayısını 
500-1500 arasında tutacak şekilde ayarlanır. Zerkler 10 ya da 20 günde bir yani lökosit sayısı 
4000'e varınca yapılır. Bir kür 4-6 zerkte yapılır.




            ";
        }

        private void label28_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox1.ImageLocation = "1000endoxan1.jfif";
            pictureBox2.ImageLocation = "1000endoxan2.jpg";
            label4.Visible = true;
            label4.Text = @"
Formülü:
Her bir flakon, 500 mg susuz siklofosfamide eşdeğer 534.5 mg siklofosfamid monohidrat içerir.
Her bir çözücü ampul: 25 ml İzotonik sodyum klorür.

Farmakolojik özellikleri:

Endikasyonları:

ENDOXAN®, aşağıdaki durumlarda, kombine bir kemoterapi protokolü içinde ya da monoterapi 
olarak kullanılır.
Lösemiler: Akut ya da kronik lenfositik ya da miyelositik lösemiler
Habis lenfomalar: Hodgkin hastalığı, Hodgkin dışı lenfomalar, plasmasitoma
Metastaz yapmış ya da yapmamış habis solid tümörler: Over kanseri, testiküler kanser, 
meme kanseri, küçük hücreli akciğer kanseri, nöroblastoma, Ewing sarkoma.
Progresif (otoimmün hastalıklar): örn. Romatoid artrit, psoriatik artropati, 
sistemik lupus eritematoz, skleroderma, sistemik vaskülit (örn. nefrotik sendrom ile), 
glomerülonefrit (örn. nefrotik sendrom ile), myasthenia gravis, otoimmün hemolitik anemi, 
soğuk aglutinin hastalıkları.
Organ nakillerinde immunosupresif tedavi

Kontrendikasyonları:

ENDOXAN® aşağıdaki durumlarda kullanılmamalıdır:

•Siklofosfamide karşı aşırı duyarlılığı bilinen kişilerde
•Ciddi kemik iliği fonksiyon yetmezliği olanlarda (özellikle daha önceden sitotoksik 
preparat ve/veya radyoterapi uygulanmış olan hastalarda)
•Mesane enflamasyonunda (sistit)
•İdrar akışı engellendiğinde
•Aktif enfeksiyon varlığında
•Hamilelik ve laktasyon dönemlerinde

Uyarılar/Önlemler:

Tedaviye başlamadan önce idrar yollarında herhangi bir tıkanıklığın, sistit, enfeksiyon ve 
elektrolit denge bozukluğunun olmadığından emin olunmalı, bu durumlar varsa tedavi edilmelidir.
Diğer sitostatikler gibi, genelde ENDOXAN® zayıf düşmüş ya da yaşlı hastalarda ve daha 
önceden radyoterapi almış hastalarda dikkatle kullanılmalıdır.
Diabetes mellitus, kronik hepatit ya da böbrek yetmezliği olanlar gibi, immün sistemi zayıf olan
hastalarda da yakın takip gereklidir.
ENDOXAN® ile tedavi sırasında, sistit ile birlikte mikro ya da makrohematüri görülürse durum 
normale dönünceye kadar ENDOXAN® tedavisi kesilmelidir.
Tedavi sırasında düzenli kan sayımları yapılmalıdır: Tedaviye başlarken her 5-7 günde bir 
ve lökosit sayısı 3.000/mm3'ün altına düşerse, her iki günde bir kan sayımı yapılmalıdır. 
Kan sayımının bazı durumlarda her gün yapılması gerekebilir. Uzun süreli tedavilerde, iki 
haftada bir yapılan kan sayımları genellikle yeterlidir. Eğer kemik iliği baskılanmasına bağlı 
bulgular ağırlık kazanırsa, eritrosit ve trombosit sayımları yapılması önerilir. Eritrosit 
varlığı açısından idrar sedimenti düzenli olarak kontrol edilmelidir.
Tümörlü hayvanlar üzerinde yapılan çalışmalarda, etanolle (alkol) birlikte oral düşük doz 
siklofosfamid tedavisi verilen deneklerde, preparatın antitümör aktivitesinde azalma 
gözlenmiştir. Alkolün kendisi siklofosfamide bağlı bulantı ve kusmayı artırabilir; bu nedenle 
siklofosfamidle tedavi edilen hastaların alkol kullanımı tekrar değerlendirilmelidir.
Tromboembolizm, DIK (yaygın damar içi pıhtılaşma) ya da hemolitik üremik sendrom gibi 
altta yatan hastalıktan kaynaklanan ancak hasta ENDOXAN®'ın da içinde bulunduğu kemoterapi 
ilaçları alırken daha yüksek oranda görülebilen bazı hastalıklar vardır.
Anti-emetiklerin zamanında uygulanmasına ve ağız hijyenine titizlikle dikkat edilmelidir.
Eğer siklofosfamid çözeltisi istemeyerek ven dışına enjekte edilir ise, genellikle sitostatik
doku hasarı tehlikesi yoktur çünkü siklofosfamidin karaciğerde biyolojik olarak aktive 
edilmeden önce, böyle bir hasar yapması beklenmez. Çözeltinin damar dışına kaçması halinde 
hemen infüzyon durdurulmalı ve yerleştirilen kanül ile damar dışına çıkan solüsyon aspire 
edilmeli, bölge serum fizyolojik ile yıkanmalı ve ekstremite hareketsiz hale getirilmelidir.

Gebelik ve laktasyonda kullanımı

Gebelik kategorisi: D

Siklofosfamid tedavisi kadınlarda ve erkeklerde genotip anomalilere neden olabilir.
Gebeliğin ilk üç ayında siklofosfamid kullanımını gerektiren hayati bir endikasyon olması
durumunda abortus için medikal konsültasyon gereklidir.

Gebeliğin ilk üç ayından sonra, eğer tedavi ertelenemiyor ise ve hasta gebeliğini sürdürmek
istiyorsa, hastaya teratojenik etki riskinin küçük olmakla birlikte mevcut olduğunu bildirmek 
koşuluyla kemoterapi uygulanabilir.
Kadınlar ENDOXAN® kullanımı sırasında gebe kalmamalıdır. Bu uyarıya rağmen tedavi 
sırasında gebe kalınmış ise, genetik konsültasyon yapılmalıdır.
Siklofosfamid anne sütüne geçtiği için, tedavi sırasında anneler bebeklerini emzirmemelidirler.
ENDOXAN® tedavisi uygulanacak olan erkekler, tedaviden önce, sperm preservasyonu yapmaları 
için bilgilendirilmelidirler.
Kemoterapi sona erdikten sonra, kadında ve erkekte gebelik açısından korunma süresi, primer
hastalığın prognozuna ve kişilerin çocuk sahibi olma isteklerine bağlıdır.

Araç ve makine kullanmaya etkisi
Siklofosfamid uygulandığında; bulantı, kusma gibi dolaşımda yetersizliklerle sonuçlanabilecek 
yan etkilerin olasılığı nedeniyle; hekim, hastanın trafiğe girme ya da makine kullanma yeterliliği
konusunda özel karar vermelidir.

Yan etkiler/Advers etkiler:

ENDOXAN® alan hastalarda, birçok durumda geri dönüşümlü olan ve doza bağlı, aşağıdaki yan 
etkiler görülebilir

Kan ve kemik iliği:

Uygulanan doza bağlı olarak, lökopeni, trombositopeni ve anemiyi de içerecek şekilde, değişik 
derecelerde kemik iliği baskılanması meydana gelebilir. Ateşin eşlik ettiği ya da etmediği 
lökopeni ve buna bağlı olarak (bazen yaşamı tehdit eden) sekonder enfeksiyonların gelişmesi 
beklenebilir. Trombositopeniye bağlı olarak kanama riski artar. Lökosit ve trombosit nadirleri 
normal olarak tedavinin başlamasından 1-2 hafta sonra görülür ve 3-4 hafta içinde normale döner.
Aneminin ortaya çıkması için genellikle birkaç tedavi kürü gerekmektedir. Daha önceden 
kemoterapi ve/veya radyoterapi ile tedavi edilmiş hastalarda ve böbrek fonksiyon bozukluğu
olan hastalarda, daha ciddi bir kemik iliği baskılanması beklenmelidir.
Diğer miyelosupresif preparatlar ile bir kombinasyon tedavisi doz ayarlamasını gerektirebilir. 
Tedavi periyodunun başlangıcında, kan sayımlarına göre sitotoksik ilaçların dozunun ayarlanması 
ve sitotoksik ilaçların en düşük ayarlanmış dozajı ile ilgili tablolara bakılması önerilir.

Gastrointestinal yan etkiler:

Bulantı ve kusma gibi gastrointestinal yan etkiler, doza bağlı advers etkilerdir. Hastaların 
%50'sinde, orta ve şiddetli düzeyde yan etkiler görülebilir. Nadiren, anoreksi, ishal, kabızlık
ve stomatitten ülserasyona kadar değişen mukoza enflamasyonu bulguları (mukozit) görülebilir. 
İzole hemorajik kolit vakaları bildirilmiştir.

öbrekler ve üriner sistem:

Siklofosfamid metabolitleri, idrar yoluyla uzaklaştırıldıktan sonra, üriner sistemde özellikle de 
mesanede değişikliklere yol açar. Hemorajik sistit, mikrohematüri ve makrohematüri, ENDOXAN® 
tedavisine bağlı olarak en sık görülen doza bağlı komplikasyonlardır ve tedavinin kesilmesini 
gerektirir. Başlangıçta sistit sterildir fakat sekonder mikrobiyal kolonizasyon görülebilir. 
Nadir olgularda, ölümle sonuçlanan ağır hemorajik sistit bildirilmiştir. Mesane duvarında ödem, 
subüretral kanama, fibroz ile birlikte interstisiyel enflamasyon ve giderek mesane duvarında 
sertleşme gibi değişiklikler gözlenmiştir.
Renal lezyonlar (özellikle geçmişinde renal fonksiyon yetmezliği olması durumunda), yüksek 
dozlardan sonra ender görülen bir yan etkidir.
Mesna kullanımı ya da yeterli hidrasyon, bu ürotoksik yan etkilerin sıklığını ve şiddetini 
önemli ölçüde azaltabilir.

Genital sistem:

Alkilasyon yoluyla etki göstermesi nedeniyle, siklofosfamidin spermatogenez üzerinde, azospermi 
ya da kalıcı oligospermi ile sonuçlanabilen, kısmen geri dönüşümsüz bozulmalara neden 
olabileceği düşünülebilir. Her iki cinste de kısırlığa yol açabilir. Kısırlığın ortaya çıkması, 
doza, tedavinin süresine ve tedavi sırasında gonadların durumuna bağlıdır.
Siklofosfamidle tedavi edilen kadınların önemli bir kısmında, gonadotropin salınımının artmasına 
ve östrojen salınımının azalmasına bağlı olarak amenore görülebilir. Tedavinin kesilmesinden 
sonraki birkaç ay içerisinde, menstrüel siklus normale döner. Puberte öncesinde tedavi edilen 
genç kızlarda genellikle sekonder seks karakterleri gelişir ve menstrüel siklus düzenlidir.
Puberte öncesi dönemde uzun süreli siklofosfamid tedavisine bağlı olarak, germ hücrelerinin 
tamamen yok olmasıyla birlikte over fibrozu görülebilir.
Erkeklerde, siklofosfamid tedavisi sonrası oligospermi ya da azospermi ile birlikte gonadotropin 
salınımı artar. Testosteron salınımı normaldir. Bu hastalarda cinsel potens ve libido etkilenmez. 
Puberte öncesi tedavi edilen erkek çocuklarda, sekonder seks karakterleri gelişir. Oligospermi, 
azospermi ve gonadotropin salınımında artış görülür. Testiküler atrofi gelişebilir.

Karaciğer:

Nadiren, ilgili laboratuar parametrelerinde (ALT, AST, gamma-GT, alkalen fosfataz, bilirubin) 
yükselme ile belirlenen, karaciğer fonksiyonlarında bozulma bildirilmiştir.
Allojenik kemik iliği transplantasyonu sırasında busulfan ya da tüm vücut radyoterapisi ile 
kombine olarak yüksek doz siklofosfamid uygulanan hastaların yaklaşık %15-50'sinde 
veno-oklüziv hastalık gözlenmiştir. Buna karşılık, veno-oklüziv hastalık tek başına yüksek 
doz siklofosfamid alan aplastik anemili hastalarda nadiren görülmüştür. Sendrom, tipik 
olarak transplantasyondan 1-3 hafta sonra gelişmekte ve ani kilo artışı, hepatomegali, 
assit ve hiperbilirubinemi ile karakterize olmaktadır.
Hastalarda, veno-oklüziv hastalık gelişmesi açısından bilinen risk faktörleri, daha önceden var 
olan karaciğer fonksiyon bozuklukları ve özellikle bir alkilasyon preparatı olan busulfanın içinde
bulunduğu yüksek doz kemoterapiye bağlı, hepatotoksik ilaç tedavisidir.

Kardiyovasküler etkiler:

Özellikle yüksek doz siklofosfamid (120-140 mg/kg) kullanımından sonra, sitotoksik ilaçların 
neden olduğu aritmi, EKG değişiklikleri ya da LVEF (örn. miyokard enfarktüsü) gibi bulgularla 
karakterizenolan sekonder kardiyomiyopati bildirilmiştir. Ayrıca, kalp bölgesine uygulanan 
radyoterapiden sonranve/veya antrasiklin ya da pentostatin ile birlikte kullanımlarda, 
siklofosfamidin kardiyotoksisitesinde artış olduğuna dair bulgular vardır. Bu açıdan, daha 
önceden bilinen kalp rahatsızlığı olan hastalara özel bir dikkatle yaklaşılması ve düzenli
elektrolit kontrolü yapılması gerekliliği akılda tutulmalıdır.

Sekonder tümörler:

Diğer sitotoksik tedavilerde olduğu gibi, siklofosfamid ile tedavi, geç sekeller olarak, sekonder
tümör ve prekürsörleri için de risk taşıyabilir. Üriner sistemde kanser gelişmesi riskinin yanısıra,
kısmen akut lösemilere kadar ilerleyebilen miyelodisplastik değişikliklerde artış olur. Hayvan 
çalışmaları, yeterli mesna kullanımı ile mesane kanseri riskinin önemli ölçüde azalabileceğini 
kanıtlamıştır.

Diğer advers etkiler:

Sık bir yan etki olan alopesi genellikle geri dönüşümlüdür. Avuç içlerinde, tırnaklarda ve ayak 
tabanlarında pigment değişimleri de bildirilmiştir.
Ayrıca, aşağıdaki yan etkiler gözlenmiştir:
•Hiponatremi ve su retansiyonu ile birlikte uygunsuz ADH sekresyonu sendromu 
(Schwartz-Bartter sendromu).
•Cilt ve mukozalarda enflamasyon.
•Bazı olgularda şoka kadar gidebilen, ateşin eşlik ettiği aşırı duyarlılık reaksiyonları.
•Geçici bulanık görme ve baş dönmesi atakları.
•Nadiren akut pankreatit.
•Çok nadir olgularda (< %0.01), Stevens Johnson sendromu ve toksik epidermal nekroliz gibi
ciddi reaksiyonlar bildirilmiştir.

İlaç etkileşimleri:

Allopurinol ya da hidroklorotiazid ile birlikte uygulandığında, sülfonil ürelerin 
miyelosupresif etkileri ve kan glukozunu düşürücü etkileri artabilir.
Fenobarbital, fenitoin, benzodiazepinler ya da kloralhidratın yakın zamanda kullanılmış 
olması ya da birlikte kullanımları halinde, mikrozomal karaciğer enzim indüksiyonu 
olasılığına neden olabilir.
Siklofosfamid bağışıklık sistemini baskılayıcı bir etkiye sahip olduğu için, hastada aşılara 
karşı daha zayıf cevap alınmasına yol açabilir. Preparatın canlı aşılarla birlikte uygulanması, 
aşıya bağlı enfeksiyon gelişmesine neden olabilir.

Depolarizan kas gevşeticileri (örn. süksinilkolinin halojenli tuzları) ile birlikte uygulanması
durumunda, psödokolinesteraz konsantrasyonundaki azalma nedeniyle, uzun süreli apne gelişebilir.
Kloramfenikol ile birarada kullanılması siklofosfamidin yarı ömrünün uzamasına ve 
metabolizasyonunda gecikmeye neden olabilir.

Antrasiklinler ve pentostatin, siklofosfamidin potansiyel kardiyotoksisitesini artırabilir. 
Kardiyotoksik etkide benzer bir artışın, kalp bölgesine uygulanan radyoterapiden sonra 
siklofosfamid kullanılması durumunda da görülebilme olasılığı vardır.

Tek bir olguda akut su intoksikasyonu bildirilmiş olduğundan, indometazin ile birlikte 
kullanımında dikkatli olunmalıdır.
Kinolon grubu antibiyotiklerle birlikte kullanıldığında, antimikrobiyal etkisinin azalmasına
neden olabilir.
Digoksinin serum düzeylerinde azalmaya yol açabilir.
Tiazid diüretikleri, siklofosfamid uygulamasına bağlı olarak gelişen lökopeniyi uzatabilir.
Siklofosfamid uygulaması, vücuttaki antikoagülan etkiyi artırabilir.
Greyfurtun içerisinde siklofosfamidin aktivasyonunu ve dolayısıyla etkinliğini bozan bir 
madde bulunduğu için, hasta tedavi sırasında greyfurt yememeli ya da greyfurt suyu içmemelidir.

Geçimsizlik

Benzil alkol içeren solüsyonlar, siklofosfamidin stabilitesini bozabilir.

Kullanım şekli ve dozu:

ENDOXAN® sadece deneyimli hekimler tarafından uygulanmalıdır.
Dozaj, her hasta için bireysel olarak saptanmalıdır.
Başka şekilde önerilmedikçe, aşağıda belirtilen dozlarda kullanımı önerilir:
•Yetişkinler ve çocuklarda devamlı uygulama için günde 3-6 mg/kg (120-240 mg/m2'ye eşdeğer).
•Aralıklı uygulama için, 2-5 gün aralıklarla 10-15 mg/kg (400-600 mg/m2'ye eşdeğer).
•Yüksek doz aralıklı uygulama için, örn. 20-40 mg/kg (800-1600 mg/m2) ve daha yüksek dozlar 
(örn. kemik iliği nakli öncesi için) 21-28 günlük aralıklarda.

Çözeltinin hazırlanması

Enjeksiyona uygun bir solüsyon hazırlamak için flakon içindeki kuru toz maddeye, çözücü olarak 
izotonik sodyum klorür eklenir (25 ml).
Çözücünün eklenmesinden sonra flakonların iyice çalkalanmasıyla, flakon içeriği kolayca 
çözülebilir. Eğer madde hemen ve tamamen çözünmüyor ise, flakonun birkaç dakika süreyle,
kendi halinde beklemeye bırakılması tavsiye edilir.
Flakon içeriğinin suda çözülmesiyle hazırlanan solüsyon intravenöz uygulama için uygundur 
(tercihan infüzyon şeklinde). Kısa süreli intravenöz infüzyon için, hazırlanmış olan ENDOXAN 
solüsyonu örneğin 500 ml'lik bir toplam hacim oluşturmak üzere Ringer solüsyonu, izotonik 
sodyum klorür solüsyonu ya da dekstroz solüsyonuna ilave edilir.
İnfüzyon süresi, hacme bağlı olarak, 30 dakika ile 2 saat arasında olabilir.
Yukarıda önerilen dozlar genellikle ENDOXAN monoterapi olarak uygulandığında önerilen 
dozlardır. 
Benzer toksisiteye sahip diğer sitostatiklerle kombine kullanıldığında dozu azaltmak 
ya da tedavisiz dönemlerin süresini uzun tutmak gerekebilir.
Karaciğer ya da renal yetmezlik durumunda doz ayarlaması
Ciddi karaciğer ya da renal yetmezlik durumunda dozu azaltmak gerekir. Dozu, serum 
bilirubin düzeyleri 3.1-5 mg / 100 ml değerleri arasında olduğunda %25 ve glomerüler 
filtrasyon miktarı dakikada 10 ml'nin altına düştüğünde %50 kadar azaltmak gerekir. 
Siklofosfamid diyalizle vücuttan temizlenebilir.
Tedavinin süresi ve aralıkları, ilacın kullanıldığı endikasyona, uygulandığı kombine 
kemoterapi şemasına, hastanın genel sağlık durumuna, laboratuvar parametrelerine ve 
kan hücre sayımlarının normale dönmesine bağlıdır.
Hastaya yeterli miktarda sıvı desteği verilmesine ve üriner sistem koruyucusu bir 
preparat olan mesna uygulanmasına dikkat edilmelidir.
ENDOXAN'ın hazırlanmasında ve kullanılması sırasında, sitotoksik preparatlar için 
uygulanan güvenlik önlemlerine uyulmalıdır.

DOZ AŞIMI

Siklofosfamidin herhangi bir spesifik antidotu bilinmediğinden, her kullanılışında büyük 
dikkat gösterilmelidir. Siklofosfamid diyaliz edilebilir. Bu nedenle, herhangi bir intihar
amaçlı ya da kaza ile doz aşımı ya da intoksikasyon durumunda hemen hemodiyaliz uygulanması 
tavsiye edilir. Diyalizatta metabolize olmamış siklofosfamidin konsantrasyonundan 78 ml/dak.'lık 
bir diyaliz klirensi hesaplanmıştır (normal renal klirens 5-11 ml/dak. civarındadır). 
Bir diğer çalışma grubu 194 ml/dak.'lık bir değer bildirmiştir. 6 saat diyalizden sonra, 
uygulanan siklofosfamid dozunun %72'si diyalizatta bulunmuştur. Doz aşımı durumunda, diğer 
reaksiyonlara oranla, kemik iliği baskılanması ve daha çok lökopeni beklenir. Kemik iliği 
baskılanmasının şiddeti ve süresi doz aşımının derecesine bağlıdır. Kan sayımı kontrollerinin 
sık olarak yapılması ve hastanın izlenmesi gerekir. Eğer nötropeni gelişirse, enfeksiyon
profilaksisi yapılmalı ve enfeksiyon gelişmişse antibiyotiklerle yeterli şekilde tedavi
edilmelidir. Eğer trombositopeni gelişirse, ihtiyaca göre trombosit replasmanı sağlanmalıdır.
Herhangi bir ürotoksik etkiden kaçınmak için, mesna ile sistit profilaksisi yapılması esastır.






";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int x = 16;

            List<Control> ilaclar = new List<Control>();
           
            foreach (Control ctrl in panel1.Controls)
            {
                // Check if control is of type label
                if (ctrl.GetType() == typeof(Label))
                {
                    // check the name of the label
                    if (ctrl.Text.ToLower().Contains(textBox1.Text.ToLower()))
                    {
                        ilaclar.Add(ctrl);
                        
                        
                        
                    }
                    else
                    {
                        ctrl.Visible = false;
                    }

                }
            }
            List<Control> duzenli = ilaclar.OrderBy(Control => Control.Text).ToList();
            foreach (var item in duzenli)
            {
                item.Location = new Point(3, x);
                item.Visible = true;
                x += 22;
            }

        }
    }
}
