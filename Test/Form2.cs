using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form2 : Form
    {



        int question = 0;
        int a1 = 0;
        int b1 = 0;
        int a2 = 0;
        int b2 = 0;
        int a3 = 0;
        int b3 = 0;
        int a4 = 0;
        int b4 = 0;
        int E = 0;
        int I = 0;
        int S = 0;
        int N = 0;
        int T = 0;
        int F = 0;
        int J = 0;
        int P = 0;
        public Form2()
        {
            
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {


            if (question < 70)
            {
                label3.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label2.Visible = true;
                label1.Visible = true;
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                button1.Text = "Следующий вопрос";
                button1.Visible = false;
            }
            else
            {
                label2.Visible = false;
                label1.Visible = false;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                label11.Visible = true;
                button1.Text = "закрыть";
            }
            

            if (question == 1 || question == 8 || question == 15 || question == 22 || question == 29 || question == 36 || question == 43 || question == 50 || question == 57 || question == 64)
            {
                if (radioButton1.Checked == true)
                    a1++;
                else if (radioButton2.Checked == true)
                    b1++;
            }
            if (question == 2 || question == 3 || question == 9 || question == 10 || question == 16 || question == 17 || question == 23 || question == 24 || question == 30 || question == 31 || question == 37 || question == 38 || question == 44 || question == 45 || question == 51 || question == 52 || question == 58 || question == 59 || question == 65 || question == 66)
            {
                if (radioButton1.Checked == true)
                    a2++;
                else if (radioButton2.Checked == true)
                    b2++;
            }
            if (question == 4 || question == 5 || question == 11 || question == 12 || question == 18 || question == 19 || question == 25 || question == 26 || question == 32 || question == 33 || question == 39 || question == 40 || question == 46 || question == 47 || question == 53 || question == 54 || question == 60 || question == 61 || question == 67 || question == 68)
            {
                if (radioButton1.Checked == true)
                    a3++;
                else if (radioButton2.Checked == true)
                    b3++;
            }
            if (question == 6 || question == 7 || question == 13 || question == 14 || question == 20 || question == 21 || question == 27 || question == 28 || question == 34 || question == 35 || question == 41 || question == 42 || question == 48 || question == 49 || question == 55 || question == 56 || question == 62 || question == 63 || question == 69 || question == 70)
            {
                if (radioButton1.Checked == true)
                    a4++;
                else if (radioButton2.Checked == true)
                    b4++;
            }



            switch (question)
            {

                case 0:
                    label1.Text = "Вопрос № 1";
                    label2.Text = " В компании (на вечеринке) Вы:";
                    label2.Text = " В компании (на вечеринке) Вы:";
                    radioButton1.Text = "общаетесь со многими, включая и незнакомцев";
                    radioButton2.Text = "общаетесь с немногими – Вашими знакомыми";
                    break;
                case 1:
                    label1.Text = "Вопрос № 2";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    label2.Text = " Вы человек скорее:";
                    radioButton1.Text = "реалистичный, чем склонный теоретизировать";
                    radioButton2.Text = "склонный теоретизировать, чем реалистичный";
                    break;
                case 2:
                    label1.Text = "Вопрос № 3";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    label2.Text = " Как по-Вашему, что хуже:";
                    radioButton1.Text = "«витать в облаках»";
                    radioButton2.Text = "придерживаться проторенной дорожки";
                    break;
                case 3:
                    label1.Text = "Вопрос № 4";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    label2.Text = " Вы более подвержены влиянию:";
                    radioButton1.Text = "принципов, законов";
                    radioButton2.Text = "эмоции, чувств";
                    break;
                case 4:
                    label1.Text = "Вопрос № 5";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    label2.Text = " Вы более склонны:";
                    radioButton1.Text = "убеждать";
                    radioButton2.Text = "затрагивать чувства";
                    break;
                case 5:
                    label1.Text = "Вопрос № 6";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    label2.Text = " Вы предпочитаете работать:";
                    radioButton1.Text = "выполняя все точно в срок";
                    radioButton2.Text = "не связывая себя определенными сроками";
                    break;
                case 6:
                    label1.Text = "Вопрос № 7";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    label2.Text = " Вы склонны делать выбор:";
                    radioButton1.Text = "довольно осторожно";
                    radioButton2.Text = "внезапно импульсивно";
                    break;
                case 7:
                    label1.Text = "Вопрос № 8";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    label2.Text = " В компании (на вечеринке) Вы:";
                    radioButton1.Text = "остаетесь допоздна, не чувствуя усталости";
                    radioButton2.Text = "быстро утомляетесь и предпочитаете пораньше уйти";
                    break;
                case 8:
                    label1.Text = "Вопрос № 9";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    label2.Text = " Вас бoлee привлекают:";
                    radioButton1.Text = "здравомыслящие люди";
                    radioButton2.Text = "люди с богатым воображением";
                    break;
                case 9:
                    label1.Text = "Вопрос № 10";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    label2.Text = " Вам интереснее:";
                    radioButton1.Text = "то что происходит в действительности";
                    radioButton2.Text = "те события, которые могут произойти";
                    break;
                case 10:
                    label1.Text = "Вопрос № 11";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    label2.Text = " Оценивая поступки людей, Вы больше учитываете:";
                    radioButton1.Text = "требования закона, чем обстоятельства";
                    radioButton2.Text = "обстоятельства, чем требования закона";
                    break;
                case 11:
                    label1.Text = "Вопрос № 12";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    label2.Text = " Обращаясь к другим, Вы склонны:";
                    radioButton1.Text = "соблюдать формальности, этикет";
                    radioButton2.Text = "проявлять свои личные, индивидуальные качества";
                    break;
                case 12:
                    label1.Text = "Вопрос № 13";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    label2.Text = " Вы человек скорее:";
                    radioButton1.Text = "точный, пунктуальный";
                    radioButton2.Text = "неторопливый, медленный";
                    break;
                case 13:
                    label1.Text = "Вопрос № 14";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    label2.Text = " Вас больше беспокоит необходимость:";
                    radioButton1.Text = "оставлять дела незаконченными";
                    radioButton2.Text = "непременно доводить дело до конца";
                    break;
                case 14:
                    label1.Text = "Вопрос № 15";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    label2.Text = " В кругу знакомых Вы, как правило:";
                    radioButton1.Text = "в курсе происходящих событий";
                    radioButton2.Text = "узнаете о новостях с опозданием";
                    break;
                case 15:
                    label1.Text = "Вопрос № 16";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    label2.Text = " Повседневные дела вам нравится делать:";
                    radioButton1.Text = "общепринятым способом";
                    radioButton2.Text = "своим оригинальным способом";
                    break;
                case 16:
                    label1.Text = "Вопрос № 17";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    label2.Text = " Предпочитаю таких писателей, которые:";
                    radioButton1.Text = "выражаются буквально, напрямую";
                    radioButton2.Text = "пользуются аналогиями, иносказаниями";
                    break;
                case 17:
                    label1.Text = "Вопрос № 18";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    label2.Text = " Что Вас больше привлекает:";
                    radioButton1.Text = "стройность мысли";
                    radioButton2.Text = "гармония человеческих отношений";
                    break;
                case 18:
                    label1.Text = "Вопрос № 19";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    label2.Text = " Вы чувствуете себя увереннее:";
                    radioButton1.Text = "в логических умозаключениях";
                    radioButton2.Text = "в практических оценках ситуаций";
                    break;
                case 19:
                    label1.Text = "Вопрос № 20";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    label2.Text = " Вы предпочитаете, когда дела:";
                    radioButton1.Text = "решены и устроены";
                    radioButton2.Text = "не решены и не устроены";
                    break;
                case 20:
                    label1.Text = "Вопрос № 21";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    label2.Text = " Как по-Вашему, Вы человек:";
                    radioButton1.Text = "серьезный, определенный";
                    radioButton2.Text = "беззаботный, беспечный";
                    break;
                case 21:
                    label1.Text = "Вопрос № 22";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    label2.Text = " При телефонных разговорах Вы:";
                    radioButton1.Text = "заранее не продумываете все, что надо сказать";
                    radioButton2.Text = "мысленно «репетируете» то, что будет сказано";
                    break;
                case 22:
                    label1.Text = "Вопрос № 23";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    label2.Text = " Как Вы считаете факты:";
                    radioButton1.Text = "важны сами по себе";
                    radioButton2.Text = "есть проявление общих закономерностей";
                    break;
                case 23:
                    label1.Text = "Вопрос № 24";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    label2.Text = " Фантазеры, мечтатели:";
                    radioButton1.Text = "раздражают Вас";
                    radioButton2.Text = "довольно симпатичны Вам";
                    break;
                case 24:
                    label1.Text = "Вопрос № 25";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    label2.Text = " Вы чаще действуете как человек";
                    radioButton1.Text = "хладнокровный";
                    radioButton2.Text = "вспыльчивый, горячий";
                    break;
                case 25:
                    label1.Text = "Вопрос № 26";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    label2.Text = " Как по-Вашему, хуже быть:";
                    radioButton1.Text = "несправедливым";
                    radioButton2.Text = "беспощадным";
                    break;
                case 26:
                    label1.Text = "Вопрос № 27";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    label2.Text = " Обычно Вы предпочитаете действовать:";
                    radioButton1.Text = "тщательно оценив возможности";
                    radioButton2.Text = "полагаясь на волю случая";
                    break;
                case 27:
                    label1.Text = "Вопрос № 28";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    label2.Text = " Вам приятнее:";
                    radioButton1.Text = "покупать что-то";
                    radioButton2.Text = "иметь возможность купить";
                    break;
                case 28:
                    label1.Text = "Вопрос № 29";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    label2.Text = " В компании Вы как правило:";
                    radioButton1.Text = "первым заводите беседу";
                    radioButton2.Text = "ждете, когда с Вами заговорят";
                    if (radioButton1.Checked == true)
                        a1++;
                    else
                        b1++;
                    break;
                case 29:
                    label1.Text = "Вопрос № 30";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    label2.Text = " Здравый смысл:";
                    radioButton1.Text = "редко ошибается";
                    radioButton2.Text = "часто попадает впросак";
                    break;
                case 30:
                    label1.Text = "Вопрос № 31";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    label2.Text = " Детям часто не хватает:";
                    radioButton1.Text = "практичности";
                    radioButton2.Text = "воображения";
                    break;
                case 31:
                    label1.Text = "Вопрос № 32";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    label2.Text = " В принятии решений Вы руководствуетесь скорее:";
                    radioButton1.Text = "принятыми нормами";
                    radioButton2.Text = "своими чувствами, ощущениями";
                    break;
                case 32:
                    label1.Text = "Вопрос № 33";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    label2.Text = " Вы человек скорее";
                    radioButton1.Text = "твердый, чем мягкий";
                    radioButton2.Text = "мягкий, чем твердый";
                    break;
                case 33:
                    label1.Text = "Вопрос № 34";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    label2.Text = " Что, по-Вашему, больше впечатляет:";
                    radioButton1.Text = "умение методично организовывать";
                    radioButton2.Text = "умение приспособиться и довольствоваться достигнутым";
                    break;
                case 34:
                    label1.Text = "Вопрос № 35";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    label2.Text = " Вы больше цените:";
                    radioButton1.Text = "определенность, законченность";
                    radioButton2.Text = "открытость, многовариантность";
                    break;
                case 35:
                    label1.Text = "Вопрос № 36";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    label2.Text = " Новые и нестандартные отношении с людьми:";
                    radioButton1.Text = "стимулируют, придают Вам энергии";
                    radioButton2.Text = "утомляют";
                    break;
                case 36:
                    label1.Text = "Вопрос № 37";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    label2.Text = " Вы чаще действуете как:";
                    radioButton1.Text = "человек практического склада";
                    radioButton2.Text = "человек оригинальный, необычный";
                    break;
                case 37:
                    label1.Text = "Вопрос № 38";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    label2.Text = " Вы более склонны:";
                    radioButton1.Text = "находить пользу в отношениях с людьми";
                    radioButton2.Text = "понимать мысли и чувства других";
                    break;
                case 38:
                    label1.Text = "Вопрос № 39";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    label2.Text = " Что приносит Вам больше удовлетворения:";
                    radioButton1.Text = "тщательное всестороннее обсуждение спорного вопроса";
                    radioButton2.Text = "достижения соглашения по поводу спорного вопроса";
                    break;
                case 39:
                    label1.Text = "Вопрос № 40";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    label2.Text = " Вы руководствуетесь более:";
                    radioButton1.Text = "рассудком";
                    radioButton2.Text = "велениями сердца";
                    break;
                case 40:
                    label1.Text = "Вопрос № 41";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    label2.Text = " Вам удобнее выполнять работу:";
                    radioButton1.Text = "по предварительной договоренности";
                    radioButton2.Text = "которая подвернулась случайно";
                    break;
                case 41:
                    label1.Text = "Вопрос № 42";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    label2.Text = " Вы обычно полагаетесь:";
                    radioButton1.Text = "на организованность, порядок";
                    radioButton2.Text = "на случайность, неожиданность";
                    break;
                case 42:
                    label1.Text = "Вопрос № 43";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    label2.Text = " Вы предпочитаете иметь:";
                    radioButton1.Text = "много друзей на непродолжительный срок";
                    radioButton2.Text = "несколько старых друзей";
                    break;
                case 43:
                    label1.Text = "Вопрос № 44";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    label2.Text = " Вы руководствуетесь в большей степени:";
                    radioButton1.Text = "фактами, обстоятельствами";
                    radioButton2.Text = "общими положениями, принципами";
                    break;
                case 44:
                    label1.Text = "Вопрос № 45";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    label2.Text = " Вас больше интересуют:";
                    radioButton1.Text = "производство и сбыт продукции";
                    radioButton2.Text = "проектирование и исследования";
                    break;
                case 45:
                    label1.Text = "Вопрос № 46";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    label2.Text = " Что Вы скорее сочтете за комплимент:";
                    radioButton1.Text = "«Вы очень логичный человек»";
                    radioButton2.Text = "«Вы тонко чувствующий человек»";
                    break;
                case 46:
                    label1.Text = "Вопрос № 47";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    label2.Text = " Вы более цените в себе:";
                    radioButton1.Text = "невозмутимость";
                    radioButton2.Text = "увлеченность";
                    break;
                case 47:
                    label1.Text = "Вопрос № 48";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    label2.Text = " Вы предпочитаете высказывать:";
                    radioButton1.Text = "окончательные и определенные утверждения";
                    radioButton2.Text = "предварительные и неоднозначные утверждения";
                    break;
                case 48:
                    label1.Text = "Вопрос № 49";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    label2.Text = " Вы лучше чувствуете себя:";
                    radioButton1.Text = "после принятия решения";
                    radioButton2.Text = "не ограничивая себя решениями";
                    break;
                case 49:
                    label1.Text = "Вопрос № 50";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    label2.Text = " Общаясь с незнакомыми, Вы:";
                    radioButton1.Text = "легко завязываете продолжительные беседы";
                    radioButton2.Text = "не всегда находите общие темы для разговора";
                    break;
                case 50:
                    label1.Text = "Вопрос № 51";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    label2.Text = " Вы больше доверяете:";
                    radioButton1.Text = "своему опыту";
                    radioButton2.Text = "своим предчувствиям";
                    break;
                case 51:
                    label1.Text = "Вопрос № 52";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    label2.Text = " Вы чувствуете себя человеком:";
                    radioButton1.Text = "более практичным, чем изобретательным";
                    radioButton2.Text = "более изобретательным, чем практичным";
                    break;
                case 52:
                    label1.Text = "Вопрос № 53";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    label2.Text = " Кто заслуживает больше одобрения:";
                    radioButton1.Text = "рассудительный, здравомыслящий человек";
                    radioButton2.Text = "человек глубоко переживающий";
                    break;
                case 53:
                    label1.Text = "Вопрос № 54";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    label2.Text = " Вы более склонны:";
                    radioButton1.Text = "быть прямым и беспристрастным";
                    radioButton2.Text = "сочувствовать людям";
                    break;
                case 54:
                    label1.Text = "Вопрос № 55";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    label2.Text = " Что, по-Вашему, предпочтительней:";
                    radioButton1.Text = "удостовериться, что все подготовлено и улажено";
                    radioButton2.Text = "предоставить событиям идти своим чередом";
                    break;
                case 55:
                    label1.Text = "Вопрос № 56";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    label2.Text = " Отношения между людьми должны строиться:";
                    radioButton1.Text = "по предварительной взаимной договоренности";
                    radioButton2.Text = "в зависимости от обстоятельств";
                    break;
                case 56:
                    label1.Text = "Вопрос № 57";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    label2.Text = " Когда звонит телефон, Вы:";
                    radioButton1.Text = "торопитесь подойти первым";
                    radioButton2.Text = "надеетесь, что подойдет кто-нибудь другой";
                    break;
                case 57:
                    label1.Text = "Вопрос № 58";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    label2.Text = "  Что Вы цените в себе больше:";
                    radioButton1.Text = "развитое чувство реальности";
                    radioButton2.Text = "пылкое воображение";
                    break;
                case 58:
                    label1.Text = "Вопрос № 59";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    label2.Text = " Вы больше придаете значения:";
                    radioButton1.Text = "тому, что сказано";
                    radioButton2.Text = "тому, как сказано";
                    break;
                case 59:
                    label1.Text = "Вопрос № 60";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    label2.Text = " Что выглядит большим заблуждением:";
                    radioButton1.Text = "излишняя пылкость, горячность";
                    radioButton2.Text = "чрезмерная объективность, беспристрастность";
                    break;
                case 60:
                    label1.Text = "Вопрос № 61";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    label2.Text = " Вы в основном считаете себя:";
                    radioButton1.Text = "трезвым и практичным";
                    radioButton2.Text = "сердечным отзывчивым";
                    break;
                case 61:
                    label1.Text = "Вопрос № 62";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    label2.Text = " Какие ситуации привлекают Вас больше:";
                    radioButton1.Text = "регламентированные и упорядоченные";
                    radioButton2.Text = "неупорядоченные и нерегламентированные";
                    break;
                case 62:
                    label1.Text = "Вопрос № 63";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    label2.Text = " Вы человек скорее:";
                    radioButton1.Text = "педантичный, чем капризный";
                    radioButton2.Text = "капризный, чем педантичный";
                    break;
                case 63:
                    label1.Text = "Вопрос № 64";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    label2.Text = " Вы чаще склонны:";
                    radioButton1.Text = "быть открытым, доступным людям";
                    radioButton2.Text = "быть сдержанным, скрытным";
                    break;
                case 64:
                    label1.Text = "Вопрос № 65";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    label2.Text = " В литературных произведениях вы предпочитаете:";
                    radioButton1.Text = "буквальность, конкретность";
                    radioButton2.Text = "образность, переносный смысл";
                    break;
                case 65:
                    label1.Text = "Вопрос № 66";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    label2.Text = " Что для Вас труднее:";
                    radioButton1.Text = "находить общий язык";
                    radioButton2.Text = "использовать других в своих интересах";
                    break;
                case 66:
                    label1.Text = "Вопрос № 67";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    label2.Text = " Что бы Вы себе больше пожелали:";
                    radioButton1.Text = "ясности размышлений";
                    radioButton2.Text = "умения сочувствовать";
                    break;
                case 67:
                    label1.Text = "Вопрос № 68";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    label2.Text = " Что хуже:";
                    radioButton1.Text = "быть неприхотливым";
                    radioButton2.Text = "быть излишне привередливым";
                    break;
                case 68:
                    label1.Text = "Вопрос № 69";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    label2.Text = " Вы предпочитаете";
                    radioButton1.Text = "запланировать события";
                    radioButton2.Text = "незапланированные события";
                    break;
                case 69:
                    label1.Text = "Вопрос № 70";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    label2.Text = " Вы склонны поступать скорее:";
                    radioButton1.Text = "обдуманно, чем импульсивно";
                    radioButton2.Text = "импульсивно, чем обдуманно";
                    break;
            }
            
            question++;

            if (question == 70)
            {
                button1.Text = "Завершить тест";

            }


            if (question == 72)
            {
                
                E = a1;
                I = b1;
                S = a2;
                N = b2;
                T = a3;
                F = b3;
                J = a4;
                P = b4;

                string res;


                if (E>I)
                {
                    if (S>N)
                    {
                        if (T > F)
                        {
                            if (J > P)
                            {
                                res = "ESTJ - лидер, ответственный, долг, иерархия; порядок, практичный; открытый; все по плану, без глупостей и лишних выдумок; бесхитростный, исполнительный, цельная натура.";
                            }
                            else
                                res = "ESTP - энергия, игра, неистощимый, искушенный в обращении с людьми, остроумие, прагматизм; работа в условиях риска и на грани катастрофы, поиск острых ощущений; выгода во взаимоотношениях; погоня за госпожой удачей, риск.";

                        }
                        else if (J > P)
                            res = "ESFJ -  открытый, практичный, житейская мудрость; компанейский, гостеприимный, общительный; интересы клиента превыше всего; ответственный.";
                        else
                            res = "ESFP -  оптимизм и  теплота, избегают одиночества, идут по  жизни смеясь, жизнь  – сплошные приключения; игнорируют все мрачное; щедрость; поддаются соблазнам; старший друг для своего ребенка, умение работать с людьми; богатство языка; наука – дело не для них, бизнес, торговля.";
                    }
                    else if(T > F)
                    {
                        if (J > P)
                        {
                            res = "ENTJ -  руководитель; ориентация на цель, логичный; эффективность в работе – превыше всего; хранитель домашнего очага; интеллигент; требовательный родитель; неутомимый; карьера иногда важнее, чем семейное благополучие.";
                        }
                        else
                            res = "ENTP - применяет интуицию на практике (в изобретениях); энтузиаст; новатор – важна воплощенная идея, а не идея сама по себе; очаровательный собеседник, инициативный в общении; нетерпение к банальным, рутинным операциям; хороший педагог; юмор; девиз – «понимать людей!».";
                    }
                    else if (J > P)
                    {
                        res = "ENFJ - лидер, общительный, внимательный к  чувствам других людей; образцовый родитель; нетерпеливый по отношению к рутине и монотонной деятельности; умение распределить роли в группе.";                    
                    }
                    else
                        res = "ENFP - умение влиять на окружающих, видит людей насквозь; отрыв от реальности в поиске гармонии; подмечает все необычное, чувствительность, отрицание сухой логики, творчество, энтузиазм, оптимизм, богатая фантазия; торговец, политик, драматург; практический психолог; экстравагантность, щедрость, иногда до безрассудства.";
                }
                else if (S > N)
                {
                    if (T > F)
                    {
                        if (J > P)
                        {
                            res = "ISTJ -  долг, человек слова, ответственный; спокойный, твердый, надежный, логичный, малоэмоциональный; семьянин; основательность и детальность.";
                        }
                        else
                            res = "ISTP -  не  признают субординации; бесстрашие, жажда действий, пилотирование, серфинг, умение обращаться с инструментами: скальпель, долото или штурвал авиалайнера; боевики, ниндзя; братские взаимоотношения; часто бросают школу и не стремятся к высшему образованию.";

                    }
                    else if (J > P)
                        res = "ISFJ - спокойный; интересы организации, традиции, ответственный; связь времен; все по  плану; заботливый; выполнять поручения спокойнее, чем руководить; хозяин в своем доме.";
                    else
                        res = "ISFP - свойства личности проявляются в искусстве; эпикурейский образ жизни; острота ощущения текущей минуты, высочайшая чувствительность к оттенкам и полутонам; тонкости устной и письменной речи обычно не интересуют их; музыка, танцы, рисование  – вот их  область; свобода, оптимистичность, непокорность, уход от  всякого рода ограничений.";
                }
                else if (T > F)
                {
                    if (J > P)
                    {
                        res = "INTJ -  самоуверенный, интересы в будущем, авторитеты не имеют значения; теоретик, «мозговой штурм», жизнь – игра на гигантской шахматной доске, логика; высокие руководящие должности; отсутствие эмоциональности, высокие способности к обучению, независимость, интуиция; возможные трудности в мире эмоций и чувств.";
                    }
                    else
                        res = "INTP - ценитель мыслей и речи, мгновенная оценка ситуации, логичность; познание законов природы, интеллектуал; несколько высокомерный; философ, математик; неистощимый фонтан новых идей; чуткий и умный родитель; сложный внутренний мир, полный ассоциаций.";
                }
                else if (J > P)
                {
                    res = "INFJ - радость друзей  – радость и  для него; проницательность и  прозорливость; успешное самообразование; ранимость, не любят споров и конфликтов; богатое воображение, поэтичность, любовь к метафорам; врач, писатель, гармония человеческих взаимоотношений, психолог.";
                }
                else
                    res = "INFP -  спокойный, идеалист, чувство собственного достоинства; борьба со злом за идеалы добра и справедливости; лирический символизм; писатель, психолог, архитектор, кто угодно, только не бизнесмен; способности в изучении языков; «мой дом – моя крепость»; крайне уживчивые и покладистые супруги.";



                System.IO.StreamWriter writer = new System.IO.StreamWriter(@"result.txt", true);
                writer.WriteLine("Ваш результат прохождения теста:");
                writer.WriteLine();
                writer.WriteLine(res);
                writer.Close();

                Application.Exit();
            }              
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                button1.Visible = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                button1.Visible = true;
            }
        }
    }
}
