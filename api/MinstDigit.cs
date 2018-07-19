using Microsoft.ML.Runtime.Api;
using System;
using System.Reflection;

namespace api
{
    public class MinstDigit
    {
        public static MinstDigit FromList(float[] list, bool hasLabel = true)
        {
            var result = new MinstDigit();
            var fields = typeof(MinstDigit).GetFields();
            foreach (var field in fields)
            {
                Type t = Nullable.GetUnderlyingType(field.FieldType) ?? field.FieldType;
                var mappingAttr = field.GetCustomAttribute<ColumnAttribute>();
                var index = hasLabel ? int.Parse(mappingAttr.Ordinal): int.Parse(mappingAttr.Ordinal) -1;
                if (index >= 0)
                {
                    object safeValue = Convert.ChangeType(list[index], t);
                    field.SetValue(result, safeValue);
                }
            }
            return result;
        }
        [Column("0")]
        [ColumnName("Label")]
        public float Label;
        [Column("1")]
        public float pixel0;
        [Column("2")]
        public float pixel1;
        [Column("3")]
        public float pixel2;
        [Column("4")]
        public float pixel3;
        [Column("5")]
        public float pixel4;
        [Column("6")]
        public float pixel5;
        [Column("7")]
        public float pixel6;
        [Column("8")]
        public float pixel7;
        [Column("9")]
        public float pixel8;
        [Column("10")]
        public float pixel9;
        [Column("11")]
        public float pixel10;
        [Column("12")]
        public float pixel11;
        [Column("13")]
        public float pixel12;
        [Column("14")]
        public float pixel13;
        [Column("15")]
        public float pixel14;
        [Column("16")]
        public float pixel15;
        [Column("17")]
        public float pixel16;
        [Column("18")]
        public float pixel17;
        [Column("19")]
        public float pixel18;
        [Column("20")]
        public float pixel19;
        [Column("21")]
        public float pixel20;
        [Column("22")]
        public float pixel21;
        [Column("23")]
        public float pixel22;
        [Column("24")]
        public float pixel23;
        [Column("25")]
        public float pixel24;
        [Column("26")]
        public float pixel25;
        [Column("27")]
        public float pixel26;
        [Column("28")]
        public float pixel27;
        [Column("29")]
        public float pixel28;
        [Column("30")]
        public float pixel29;
        [Column("31")]
        public float pixel30;
        [Column("32")]
        public float pixel31;
        [Column("33")]
        public float pixel32;
        [Column("34")]
        public float pixel33;
        [Column("35")]
        public float pixel34;
        [Column("36")]
        public float pixel35;
        [Column("37")]
        public float pixel36;
        [Column("38")]
        public float pixel37;
        [Column("39")]
        public float pixel38;
        [Column("40")]
        public float pixel39;
        [Column("41")]
        public float pixel40;
        [Column("42")]
        public float pixel41;
        [Column("43")]
        public float pixel42;
        [Column("44")]
        public float pixel43;
        [Column("45")]
        public float pixel44;
        [Column("46")]
        public float pixel45;
        [Column("47")]
        public float pixel46;
        [Column("48")]
        public float pixel47;
        [Column("49")]
        public float pixel48;
        [Column("50")]
        public float pixel49;
        [Column("51")]
        public float pixel50;
        [Column("52")]
        public float pixel51;
        [Column("53")]
        public float pixel52;
        [Column("54")]
        public float pixel53;
        [Column("55")]
        public float pixel54;
        [Column("56")]
        public float pixel55;
        [Column("57")]
        public float pixel56;
        [Column("58")]
        public float pixel57;
        [Column("59")]
        public float pixel58;
        [Column("60")]
        public float pixel59;
        [Column("1")]
        public float pixel60;
        [Column("1")]
        public float pixel61;
        [Column("1")]
        public float pixel62;
        [Column("1")]
        public float pixel63;
        [Column("1")]
        public float pixel64;
        [Column("1")]
        public float pixel65;
        [Column("1")]
        public float pixel66;
        [Column("1")]
        public float pixel67;
        [Column("1")]
        public float pixel68;
        [Column("1")]
        public float pixel69;
        [Column("1")]
        public float pixel70;
        [Column("1")]
        public float pixel71;
        [Column("1")]
        public float pixel72;
        [Column("1")]
        public float pixel73;
        [Column("1")]
        public float pixel74;
        [Column("1")]
        public float pixel75;
        [Column("1")]
        public float pixel76;
        [Column("1")]
        public float pixel77;
        [Column("1")]
        public float pixel78;
        [Column("1")]
        public float pixel79;
        [Column("1")]
        public float pixel80;
        [Column("1")]
        public float pixel81;
        [Column("1")]
        public float pixel82;
        [Column("1")]
        public float pixel83;
        [Column("1")]
        public float pixel84;
        [Column("1")]
        public float pixel85;
        [Column("1")]
        public float pixel86;
        [Column("1")]
        public float pixel87;
        [Column("1")]
        public float pixel88;
        [Column("1")]
        public float pixel89;
        [Column("1")]
        public float pixel90;
        [Column("1")]
        public float pixel91;
        [Column("1")]
        public float pixel92;
        [Column("1")]
        public float pixel93;
        [Column("1")]
        public float pixel94;
        [Column("1")]
        public float pixel95;
        [Column("1")]
        public float pixel96;
        [Column("1")]
        public float pixel97;
        [Column("1")]
        public float pixel98;
        [Column("100")]
        public float pixel99;
        [Column("101")]
        public float pixel100;
        [Column("102")]
        public float pixel101;
        [Column("103")]
        public float pixel102;
        [Column("104")]
        public float pixel103;
        [Column("105")]
        public float pixel104;
        [Column("106")]
        public float pixel105;
        [Column("107")]
        public float pixel106;
        [Column("108")]
        public float pixel107;
        [Column("109")]
        public float pixel108;
        [Column("111")]
        public float pixel109;
        [Column("111")]
        public float pixel110;
        [Column("112")]
        public float pixel111;
        [Column("113")]
        public float pixel112;
        [Column("114")]
        public float pixel113;
        [Column("115")]
        public float pixel114;
        [Column("116")]
        public float pixel115;
        [Column("117")]
        public float pixel116;
        [Column("118")]
        public float pixel117;
        [Column("119")]
        public float pixel118;
        [Column("120")]
        public float pixel119;
        [Column("121")]
        public float pixel120;
        [Column("122")]
        public float pixel121;
        [Column("123")]
        public float pixel122;
        [Column("124")]
        public float pixel123;
        [Column("125")]
        public float pixel124;
        [Column("126")]
        public float pixel125;
        [Column("127")]
        public float pixel126;
        [Column("128")]
        public float pixel127;
        [Column("129")]
        public float pixel128;
        [Column("130")]
        public float pixel129;
        [Column("1")]
        public float pixel130;
        [Column("1")]
        public float pixel131;
        [Column("1")]
        public float pixel132;
        [Column("1")]
        public float pixel133;
        [Column("1")]
        public float pixel134;
        [Column("1")]
        public float pixel135;
        [Column("1")]
        public float pixel136;
        [Column("1")]
        public float pixel137;
        [Column("1")]
        public float pixel138;
        [Column("1")]
        public float pixel139;
        [Column("1")]
        public float pixel140;
        [Column("1")]
        public float pixel141;
        [Column("1")]
        public float pixel142;
        [Column("1")]
        public float pixel143;
        [Column("1")]
        public float pixel144;
        [Column("1")]
        public float pixel145;
        [Column("1")]
        public float pixel146;
        [Column("1")]
        public float pixel147;
        [Column("149")]
        public float pixel148;
        [Column("150")]
        public float pixel149;
        [Column("151")]
        public float pixel150;
        [Column("152")]
        public float pixel151;
        [Column("153")]
        public float pixel152;
        [Column("154")]
        public float pixel153;
        [Column("155")]
        public float pixel154;
        [Column("156")]
        public float pixel155;
        [Column("157")]
        public float pixel156;
        [Column("158")]
        public float pixel157;
        [Column("159")]
        public float pixel158;
        [Column("160")]
        public float pixel159;
        [Column("161")]
        public float pixel160;
        [Column("162")]
        public float pixel161;
        [Column("163")]
        public float pixel162;
        [Column("164")]
        public float pixel163;
        [Column("165")]
        public float pixel164;
        [Column("166")]
        public float pixel165;
        [Column("167")]
        public float pixel166;
        [Column("168")]
        public float pixel167;
        [Column("169")]
        public float pixel168;
        [Column("170")]
        public float pixel169;
        [Column("171")]
        public float pixel170;
        [Column("172")]
        public float pixel171;
        [Column("173")]
        public float pixel172;
        [Column("174")]
        public float pixel173;
        [Column("175")]
        public float pixel174;
        [Column("1")]
        public float pixel175;
        [Column("1")]
        public float pixel176;
        [Column("1")]
        public float pixel177;
        [Column("1")]
        public float pixel178;
        [Column("1")]
        public float pixel179;
        [Column("1")]
        public float pixel180;
        [Column("1")]
        public float pixel181;
        [Column("1")]
        public float pixel182;
        [Column("1")]
        public float pixel183;
        [Column("1")]
        public float pixel184;
        [Column("1")]
        public float pixel185;
        [Column("1")]
        public float pixel186;
        [Column("1")]
        public float pixel187;
        [Column("1")]
        public float pixel188;
        [Column("190")]
        public float pixel189;
        [Column("191")]
        public float pixel190;
        [Column("192")]
        public float pixel191;
        [Column("193")]
        public float pixel192;
        [Column("194")]
        public float pixel193;
        [Column("195")]
        public float pixel194;
        [Column("196")]
        public float pixel195;
        [Column("197")]
        public float pixel196;
        [Column("198")]
        public float pixel197;
        [Column("199")]
        public float pixel198;
        [Column("200")]
        public float pixel199;
        [Column("201")]
        public float pixel200;
        [Column("202")]
        public float pixel201;
        [Column("203")]
        public float pixel202;
        [Column("204")]
        public float pixel203;
        [Column("205")]
        public float pixel204;
        [Column("206")]
        public float pixel205;
        [Column("207")]
        public float pixel206;
        [Column("208")]
        public float pixel207;
        [Column("209")]
        public float pixel208;
        [Column("1")]
        public float pixel209;
        [Column("1")]
        public float pixel210;
        [Column("1")]
        public float pixel211;
        [Column("1")]
        public float pixel212;
        [Column("1")]
        public float pixel213;
        [Column("1")]
        public float pixel214;
        [Column("1")]
        public float pixel215;
        [Column("1")]
        public float pixel216;
        [Column("1")]
        public float pixel217;
        [Column("219")]
        public float pixel218;
        [Column("220")]
        public float pixel219;
        [Column("221")]
        public float pixel220;
        [Column("222")]
        public float pixel221;
        [Column("223")]
        public float pixel222;
        [Column("224")]
        public float pixel223;
        [Column("225")]
        public float pixel224;
        [Column("226")]
        public float pixel225;
        [Column("227")]
        public float pixel226;
        [Column("228")]
        public float pixel227;
        [Column("229")]
        public float pixel228;
        [Column("230")]
        public float pixel229;
        [Column("231")]
        public float pixel230;
        [Column("232")]
        public float pixel231;
        [Column("233")]
        public float pixel232;
        [Column("234")]
        public float pixel233;
        [Column("235")]
        public float pixel234;
        [Column("236")]
        public float pixel235;
        [Column("237")]
        public float pixel236;
        [Column("238")]
        public float pixel237;
        [Column("239")]
        public float pixel238;
        [Column("240")]
        public float pixel239;
        [Column("241")]
        public float pixel240;
        [Column("242")]
        public float pixel241;
        [Column("243")]
        public float pixel242;
        [Column("244")]
        public float pixel243;
        [Column("245")]
        public float pixel244;
        [Column("246")]
        public float pixel245;
        [Column("247")]
        public float pixel246;
        [Column("248")]
        public float pixel247;
        [Column("1")]
        public float pixel248;
        [Column("1")]
        public float pixel249;
        [Column("1")]
        public float pixel250;
        [Column("1")]
        public float pixel251;
        [Column("1")]
        public float pixel252;
        [Column("1")]
        public float pixel253;
        [Column("1")]
        public float pixel254;
        [Column("1")]
        public float pixel255;
        [Column("1")]
        public float pixel256;
        [Column("1")]
        public float pixel257;
        [Column("1")]
        public float pixel258;
        [Column("1")]
        public float pixel259;
        [Column("1")]
        public float pixel260;
        [Column("1")]
        public float pixel261;
        [Column("1")]
        public float pixel262;
        [Column("1")]
        public float pixel263;
        [Column("1")]
        public float pixel264;
        [Column("1")]
        public float pixel265;
        [Column("1")]
        public float pixel266;
        [Column("1")]
        public float pixel267;
        [Column("1")]
        public float pixel268;
        [Column("1")]
        public float pixel269;
        [Column("1")]
        public float pixel270;
        [Column("1")]
        public float pixel271;
        [Column("1")]
        public float pixel272;
        [Column("1")]
        public float pixel273;
        [Column("1")]
        public float pixel274;
        [Column("1")]
        public float pixel275;
        [Column("277")]
        public float pixel276;
        [Column("278")]
        public float pixel277;
        [Column("279")]
        public float pixel278;
        [Column("280")]
        public float pixel279;
        [Column("281")]
        public float pixel280;
        [Column("282")]
        public float pixel281;
        [Column("283")]
        public float pixel282;
        [Column("284")]
        public float pixel283;
        [Column("285")]
        public float pixel284;
        [Column("286")]
        public float pixel285;
        [Column("287")]
        public float pixel286;
        [Column("288")]
        public float pixel287;
        [Column("289")]
        public float pixel288;
        [Column("290")]
        public float pixel289;
        [Column("291")]
        public float pixel290;
        [Column("292")]
        public float pixel291;
        [Column("293")]
        public float pixel292;
        [Column("294")]
        public float pixel293;
        [Column("295")]
        public float pixel294;
        [Column("296")]
        public float pixel295;
        [Column("297")]
        public float pixel296;
        [Column("298")]
        public float pixel297;
        [Column("299")]
        public float pixel298;
        [Column("300")]
        public float pixel299;
        [Column("301")]
        public float pixel300;
        [Column("302")]
        public float pixel301;
        [Column("303")]
        public float pixel302;
        [Column("304")]
        public float pixel303;
        [Column("305")]
        public float pixel304;
        [Column("306")]
        public float pixel305;
        [Column("307")]
        public float pixel306;
        [Column("308")]
        public float pixel307;
        [Column("309")]
        public float pixel308;
        [Column("310")]
        public float pixel309;
        [Column("311")]
        public float pixel310;
        [Column("312")]
        public float pixel311;
        [Column("313")]
        public float pixel312;
        [Column("314")]
        public float pixel313;
        [Column("315")]
        public float pixel314;
        [Column("316")]
        public float pixel315;
        [Column("317")]
        public float pixel316;
        [Column("318")]
        public float pixel317;
        [Column("319")]
        public float pixel318;
        [Column("320")]
        public float pixel319;
        [Column("321")]
        public float pixel320;
        [Column("322")]
        public float pixel321;
        [Column("323")]
        public float pixel322;
        [Column("324")]
        public float pixel323;
        [Column("325")]
        public float pixel324;
        [Column("326")]
        public float pixel325;
        [Column("327")]
        public float pixel326;
        [Column("328")]
        public float pixel327;
        [Column("329")]
        public float pixel328;
        [Column("330")]
        public float pixel329;
        [Column("331")]
        public float pixel330;
        [Column("332")]
        public float pixel331;
        [Column("333")]
        public float pixel332;
        [Column("334")]
        public float pixel333;
        [Column("335")]
        public float pixel334;
        [Column("336")]
        public float pixel335;
        [Column("337")]
        public float pixel336;
        [Column("338")]
        public float pixel337;
        [Column("339")]
        public float pixel338;
        [Column("340")]
        public float pixel339;
        [Column("341")]
        public float pixel340;
        [Column("342")]
        public float pixel341;
        [Column("343")]
        public float pixel342;
        [Column("344")]
        public float pixel343;
        [Column("345")]
        public float pixel344;
        [Column("346")]
        public float pixel345;
        [Column("347")]
        public float pixel346;
        [Column("348")]
        public float pixel347;
        [Column("349")]
        public float pixel348;
        [Column("350")]
        public float pixel349;
        [Column("351")]
        public float pixel350;
        [Column("352")]
        public float pixel351;
        [Column("353")]
        public float pixel352;
        [Column("354")]
        public float pixel353;
        [Column("355")]
        public float pixel354;
        [Column("356")]
        public float pixel355;
        [Column("357")]
        public float pixel356;
        [Column("358")]
        public float pixel357;
        [Column("359")]
        public float pixel358;
        [Column("360")]
        public float pixel359;
        [Column("361")]
        public float pixel360;
        [Column("362")]
        public float pixel361;
        [Column("363")]
        public float pixel362;
        [Column("364")]
        public float pixel363;
        [Column("365")]
        public float pixel364;
        [Column("366")]
        public float pixel365;
        [Column("367")]
        public float pixel366;
        [Column("368")]
        public float pixel367;
        [Column("369")]
        public float pixel368;
        [Column("370")]
        public float pixel369;
        [Column("371")]
        public float pixel370;
        [Column("372")]
        public float pixel371;
        [Column("373")]
        public float pixel372;
        [Column("374")]
        public float pixel373;
        [Column("375")]
        public float pixel374;
        [Column("376")]
        public float pixel375;
        [Column("377")]
        public float pixel376;
        [Column("378")]
        public float pixel377;
        [Column("379")]
        public float pixel378;
        [Column("380")]
        public float pixel379;
        [Column("381")]
        public float pixel380;
        [Column("382")]
        public float pixel381;
        [Column("383")]
        public float pixel382;
        [Column("384")]
        public float pixel383;
        [Column("385")]
        public float pixel384;
        [Column("386")]
        public float pixel385;
        [Column("387")]
        public float pixel386;
        [Column("388")]
        public float pixel387;
        [Column("389")]
        public float pixel388;
        [Column("390")]
        public float pixel389;
        [Column("391")]
        public float pixel390;
        [Column("392")]
        public float pixel391;
        [Column("393")]
        public float pixel392;
        [Column("394")]
        public float pixel393;
        [Column("395")]
        public float pixel394;
        [Column("396")]
        public float pixel395;
        [Column("397")]
        public float pixel396;
        [Column("398")]
        public float pixel397;
        [Column("399")]
        public float pixel398;
        [Column("400")]
        public float pixel399;
        [Column("401")]
        public float pixel400;
        [Column("402")]
        public float pixel401;
        [Column("403")]
        public float pixel402;
        [Column("404")]
        public float pixel403;
        [Column("405")]
        public float pixel404;
        [Column("406")]
        public float pixel405;
        [Column("407")]
        public float pixel406;
        [Column("408")]
        public float pixel407;
        [Column("409")]
        public float pixel408;
        [Column("410")]
        public float pixel409;
        [Column("411")]
        public float pixel410;
        [Column("412")]
        public float pixel411;
        [Column("413")]
        public float pixel412;
        [Column("414")]
        public float pixel413;
        [Column("415")]
        public float pixel414;
        [Column("414")]
        public float pixel415;
        [Column("1")]
        public float pixel416;
        [Column("1")]
        public float pixel417;
        [Column("419")]
        public float pixel418;
        [Column("420")]
        public float pixel419;
        [Column("421")]
        public float pixel420;
        [Column("422")]
        public float pixel421;
        [Column("423")]
        public float pixel422;
        [Column("424")]
        public float pixel423;
        [Column("425")]
        public float pixel424;
        [Column("426")]
        public float pixel425;
        [Column("427")]
        public float pixel426;
        [Column("428")]
        public float pixel427;
        [Column("429")]
        public float pixel428;
        [Column("430")]
        public float pixel429;
        [Column("431")]
        public float pixel430;
        [Column("432")]
        public float pixel431;
        [Column("433")]
        public float pixel432;
        [Column("434")]
        public float pixel433;
        [Column("435")]
        public float pixel434;
        [Column("436")]
        public float pixel435;
        [Column("437")]
        public float pixel436;
        [Column("438")]
        public float pixel437;
        [Column("439")]
        public float pixel438;
        [Column("440")]
        public float pixel439;
        [Column("441")]
        public float pixel440;
        [Column("442")]
        public float pixel441;
        [Column("443")]
        public float pixel442;
        [Column("444")]
        public float pixel443;
        [Column("445")]
        public float pixel444;
        [Column("446")]
        public float pixel445;
        [Column("447")]
        public float pixel446;
        [Column("448")]
        public float pixel447;
        [Column("449")]
        public float pixel448;
        [Column("450")]
        public float pixel449;
        [Column("451")]
        public float pixel450;
        [Column("452")]
        public float pixel451;
        [Column("453")]
        public float pixel452;
        [Column("454")]
        public float pixel453;
        [Column("455")]
        public float pixel454;
        [Column("456")]
        public float pixel455;
        [Column("457")]
        public float pixel456;
        [Column("458")]
        public float pixel457;
        [Column("459")]
        public float pixel458;
        [Column("460")]
        public float pixel459;
        [Column("461")]
        public float pixel460;
        [Column("462")]
        public float pixel461;
        [Column("463")]
        public float pixel462;
        [Column("464")]
        public float pixel463;
        [Column("465")]
        public float pixel464;
        [Column("466")]
        public float pixel465;
        [Column("467")]
        public float pixel466;
        [Column("468")]
        public float pixel467;
        [Column("469")]
        public float pixel468;
        [Column("470")]
        public float pixel469;
        [Column("471")]
        public float pixel470;
        [Column("472")]
        public float pixel471;
        [Column("473")]
        public float pixel472;
        [Column("474")]
        public float pixel473;
        [Column("475")]
        public float pixel474;
        [Column("476")]
        public float pixel475;
        [Column("477")]
        public float pixel476;
        [Column("478")]
        public float pixel477;
        [Column("479")]
        public float pixel478;
        [Column("480")]
        public float pixel479;
        [Column("481")]
        public float pixel480;
        [Column("482")]
        public float pixel481;
        [Column("483")]
        public float pixel482;
        [Column("484")]
        public float pixel483;
        [Column("485")]
        public float pixel484;
        [Column("486")]
        public float pixel485;
        [Column("487")]
        public float pixel486;
        [Column("488")]
        public float pixel487;
        [Column("489")]
        public float pixel488;
        [Column("490")]
        public float pixel489;
        [Column("491")]
        public float pixel490;
        [Column("492")]
        public float pixel491;
        [Column("493")]
        public float pixel492;
        [Column("494")]
        public float pixel493;
        [Column("495")]
        public float pixel494;
        [Column("496")]
        public float pixel495;
        [Column("497")]
        public float pixel496;
        [Column("498")]
        public float pixel497;
        [Column("499")]
        public float pixel498;
        [Column("500")]
        public float pixel499;
        [Column("501")]
        public float pixel500;
        [Column("502")]
        public float pixel501;
        [Column("503")]
        public float pixel502;
        [Column("504")]
        public float pixel503;
        [Column("505")]
        public float pixel504;
        [Column("506")]
        public float pixel505;
        [Column("507")]
        public float pixel506;
        [Column("508")]
        public float pixel507;
        [Column("509")]
        public float pixel508;
        [Column("510")]
        public float pixel509;
        [Column("511")]
        public float pixel510;
        [Column("512")]
        public float pixel511;
        [Column("513")]
        public float pixel512;
        [Column("514")]
        public float pixel513;
        [Column("515")]
        public float pixel514;
        [Column("516")]
        public float pixel515;
        [Column("517")]
        public float pixel516;
        [Column("518")]
        public float pixel517;
        [Column("1")]
        public float pixel518;
        [Column("1")]
        public float pixel519;
        [Column("1")]
        public float pixel520;
        [Column("1")]
        public float pixel521;
        [Column("1")]
        public float pixel522;
        [Column("1")]
        public float pixel523;
        [Column("1")]
        public float pixel524;
        [Column("1")]
        public float pixel525;
        [Column("1")]
        public float pixel526;
        [Column("1")]
        public float pixel527;
        [Column("1")]
        public float pixel528;
        [Column("1")]
        public float pixel529;
        [Column("1")]
        public float pixel530;
        [Column("1")]
        public float pixel531;
        [Column("1")]
        public float pixel532;
        [Column("1")]
        public float pixel533;
        [Column("1")]
        public float pixel534;
        [Column("1")]
        public float pixel535;
        [Column("1")]
        public float pixel536;
        [Column("1")]
        public float pixel537;
        [Column("1")]
        public float pixel538;
        [Column("1")]
        public float pixel539;
        [Column("1")]
        public float pixel540;
        [Column("1")]
        public float pixel541;
        [Column("1")]
        public float pixel542;
        [Column("1")]
        public float pixel543;
        [Column("545")]
        public float pixel544;
        [Column("546")]
        public float pixel545;
        [Column("547")]
        public float pixel546;
        [Column("548")]
        public float pixel547;
        [Column("549")]
        public float pixel548;
        [Column("550")]
        public float pixel549;
        [Column("551")]
        public float pixel550;
        [Column("552")]
        public float pixel551;
        [Column("553")]
        public float pixel552;
        [Column("554")]
        public float pixel553;
        [Column("555")]
        public float pixel554;
        [Column("556")]
        public float pixel555;
        [Column("557")]
        public float pixel556;
        [Column("558")]
        public float pixel557;
        [Column("559")]
        public float pixel558;
        [Column("560")]
        public float pixel559;
        [Column("561")]
        public float pixel560;
        [Column("1")]
        public float pixel561;
        [Column("1")]
        public float pixel562;
        [Column("1")]
        public float pixel563;
        [Column("1")]
        public float pixel564;
        [Column("1")]
        public float pixel565;
        [Column("1")]
        public float pixel566;
        [Column("1")]
        public float pixel567;
        [Column("1")]
        public float pixel568;
        [Column("1")]
        public float pixel569;
        [Column("1")]
        public float pixel570;
        [Column("1")]
        public float pixel571;
        [Column("1")]
        public float pixel572;
        [Column("1")]
        public float pixel573;
        [Column("1")]
        public float pixel574;
        [Column("1")]
        public float pixel575;
        [Column("1")]
        public float pixel576;
        [Column("1")]
        public float pixel577;
        [Column("1")]
        public float pixel578;
        [Column("1")]
        public float pixel579;
        [Column("1")]
        public float pixel580;
        [Column("1")]
        public float pixel581;
        [Column("1")]
        public float pixel582;
        [Column("1")]
        public float pixel583;
        [Column("1")]
        public float pixel584;
        [Column("1")]
        public float pixel585;
        [Column("1")]
        public float pixel586;
        [Column("1")]
        public float pixel587;
        [Column("1")]
        public float pixel588;
        [Column("1")]
        public float pixel589;
        [Column("1")]
        public float pixel590;
        [Column("1")]
        public float pixel591;
        [Column("1")]
        public float pixel592;
        [Column("1")]
        public float pixel593;
        [Column("1")]
        public float pixel594;
        [Column("1")]
        public float pixel595;
        [Column("1")]
        public float pixel596;
        [Column("1")]
        public float pixel597;
        [Column("1")]
        public float pixel598;
        [Column("1")]
        public float pixel599;
        [Column("1")]
        public float pixel600;
        [Column("1")]
        public float pixel601;
        [Column("1")]
        public float pixel602;
        [Column("1")]
        public float pixel603;
        [Column("1")]
        public float pixel604;
        [Column("1")]
        public float pixel605;
        [Column("1")]
        public float pixel606;
        [Column("1")]
        public float pixel607;
        [Column("1")]
        public float pixel608;
        [Column("1")]
        public float pixel609;
        [Column("1")]
        public float pixel610;
        [Column("1")]
        public float pixel611;
        [Column("1")]
        public float pixel612;
        [Column("1")]
        public float pixel613;
        [Column("1")]
        public float pixel614;
        [Column("1")]
        public float pixel615;
        [Column("1")]
        public float pixel616;
        [Column("1")]
        public float pixel617;
        [Column("1")]
        public float pixel618;
        [Column("1")]
        public float pixel619;
        [Column("1")]
        public float pixel620;
        [Column("1")]
        public float pixel621;
        [Column("1")]
        public float pixel622;
        [Column("1")]
        public float pixel623;
        [Column("1")]
        public float pixel624;
        [Column("1")]
        public float pixel625;
        [Column("1")]
        public float pixel626;
        [Column("1")]
        public float pixel627;
        [Column("1")]
        public float pixel628;
        [Column("1")]
        public float pixel629;
        [Column("1")]
        public float pixel630;
        [Column("1")]
        public float pixel631;
        [Column("1")]
        public float pixel632;
        [Column("1")]
        public float pixel633;
        [Column("1")]
        public float pixel634;
        [Column("1")]
        public float pixel635;
        [Column("1")]
        public float pixel636;
        [Column("1")]
        public float pixel637;
        [Column("1")]
        public float pixel638;
        [Column("1")]
        public float pixel639;
        [Column("1")]
        public float pixel640;
        [Column("1")]
        public float pixel641;
        [Column("1")]
        public float pixel642;
        [Column("1")]
        public float pixel643;
        [Column("1")]
        public float pixel644;
        [Column("1")]
        public float pixel645;
        [Column("1")]
        public float pixel646;
        [Column("1")]
        public float pixel647;
        [Column("1")]
        public float pixel648;
        [Column("1")]
        public float pixel649;
        [Column("1")]
        public float pixel650;
        [Column("1")]
        public float pixel651;
        [Column("1")]
        public float pixel652;
        [Column("1")]
        public float pixel653;
        [Column("1")]
        public float pixel654;
        [Column("1")]
        public float pixel655;
        [Column("1")]
        public float pixel656;
        [Column("1")]
        public float pixel657;
        [Column("1")]
        public float pixel658;
        [Column("1")]
        public float pixel659;
        [Column("1")]
        public float pixel660;
        [Column("1")]
        public float pixel661;
        [Column("1")]
        public float pixel662;
        [Column("1")]
        public float pixel663;
        [Column("1")]
        public float pixel664;
        [Column("1")]
        public float pixel665;
        [Column("1")]
        public float pixel666;
        [Column("1")]
        public float pixel667;
        [Column("1")]
        public float pixel668;
        [Column("1")]
        public float pixel669;
        [Column("1")]
        public float pixel670;
        [Column("1")]
        public float pixel671;
        [Column("1")]
        public float pixel672;
        [Column("1")]
        public float pixel673;
        [Column("1")]
        public float pixel674;
        [Column("1")]
        public float pixel675;
        [Column("1")]
        public float pixel676;
        [Column("1")]
        public float pixel677;
        [Column("1")]
        public float pixel678;
        [Column("1")]
        public float pixel679;
        [Column("1")]
        public float pixel680;
        [Column("1")]
        public float pixel681;
        [Column("1")]
        public float pixel682;
        [Column("1")]
        public float pixel683;
        [Column("1")]
        public float pixel684;
        [Column("1")]
        public float pixel685;
        [Column("1")]
        public float pixel686;
        [Column("1")]
        public float pixel687;
        [Column("1")]
        public float pixel688;
        [Column("1")]
        public float pixel689;
        [Column("1")]
        public float pixel690;
        [Column("1")]
        public float pixel691;
        [Column("1")]
        public float pixel692;
        [Column("1")]
        public float pixel693;
        [Column("1")]
        public float pixel694;
        [Column("1")]
        public float pixel695;
        [Column("1")]
        public float pixel696;
        [Column("1")]
        public float pixel697;
        [Column("1")]
        public float pixel698;
        [Column("1")]
        public float pixel699;
        [Column("1")]
        public float pixel700;
        [Column("1")]
        public float pixel701;
        [Column("1")]
        public float pixel702;
        [Column("1")]
        public float pixel703;
        [Column("1")]
        public float pixel704;
        [Column("1")]
        public float pixel705;
        [Column("1")]
        public float pixel706;
        [Column("1")]
        public float pixel707;
        [Column("1")]
        public float pixel708;
        [Column("1")]
        public float pixel709;
        [Column("1")]
        public float pixel710;
        [Column("1")]
        public float pixel711;
        [Column("1")]
        public float pixel712;
        [Column("1")]
        public float pixel713;
        [Column("1")]
        public float pixel714;
        [Column("1")]
        public float pixel715;
        [Column("1")]
        public float pixel716;
        [Column("1")]
        public float pixel717;
        [Column("1")]
        public float pixel718;
        [Column("1")]
        public float pixel719;
        [Column("1")]
        public float pixel720;
        [Column("1")]
        public float pixel721;
        [Column("1")]
        public float pixel722;
        [Column("1")]
        public float pixel723;
        [Column("1")]
        public float pixel724;
        [Column("1")]
        public float pixel725;
        [Column("1")]
        public float pixel726;
        [Column("1")]
        public float pixel727;
        [Column("1")]
        public float pixel728;
        [Column("1")]
        public float pixel729;
        [Column("1")]
        public float pixel730;
        [Column("1")]
        public float pixel731;
        [Column("1")]
        public float pixel732;
        [Column("1")]
        public float pixel733;
        [Column("1")]
        public float pixel734;
        [Column("1")]
        public float pixel735;
        [Column("1")]
        public float pixel736;
        [Column("1")]
        public float pixel737;
        [Column("1")]
        public float pixel738;
        [Column("1")]
        public float pixel739;
        [Column("1")]
        public float pixel740;
        [Column("1")]
        public float pixel741;
        [Column("1")]
        public float pixel742;
        [Column("1")]
        public float pixel743;
        [Column("1")]
        public float pixel744;
        [Column("1")]
        public float pixel745;
        [Column("1")]
        public float pixel746;
        [Column("1")]
        public float pixel747;
        [Column("1")]
        public float pixel748;
        [Column("1")]
        public float pixel749;
        [Column("1")]
        public float pixel750;
        [Column("752")]
        public float pixel751;
        [Column("753")]
        public float pixel752;
        [Column("754")]
        public float pixel753;
        [Column("755")]
        public float pixel754;
        [Column("756")]
        public float pixel755;
        [Column("757")]
        public float pixel756;
        [Column("758")]
        public float pixel757;
        [Column("759")]
        public float pixel758;
        [Column("760")]
        public float pixel759;
        [Column("761")]
        public float pixel760;
        [Column("762")]
        public float pixel761;
        [Column("763")]
        public float pixel762;
        [Column("764")]
        public float pixel763;
        [Column("765")]
        public float pixel764;
        [Column("766")]
        public float pixel765;
        [Column("767")]
        public float pixel766;
        [Column("768")]
        public float pixel767;
        [Column("769")]
        public float pixel768;
        [Column("770")]
        public float pixel769;
        [Column("771")]
        public float pixel770;
        [Column("772")]
        public float pixel771;
        [Column("773")]
        public float pixel772;
        [Column("774")]
        public float pixel773;
        [Column("775")]
        public float pixel774;
        [Column("776")]
        public float pixel775;
        [Column("777")]
        public float pixel776;
        [Column("778")]
        public float pixel777;
        [Column("779")]
        public float pixel778;
        [Column("780")]
        public float pixel779;
        [Column("781")]
        public float pixel780;
        [Column("782")]
        public float pixel781;
        [Column("783")]
        public float pixel782;
        [Column("784")]
        public float pixel783;

        public static string[] GetColumnNames()
        {
            return new string[] { "pixel0", "pixel1", "pixel2", "pixel3", "pixel4", "pixel5", "pixel6", "pixel7", "pixel8", "pixel9", "pixel10", "pixel11", "pixel12", "pixel13", "pixel14", "pixel15", "pixel16", "pixel17", "pixel18", "pixel19", "pixel20", "pixel21", "pixel22", "pixel23", "pixel24", "pixel25", "pixel26", "pixel27", "pixel28", "pixel29", "pixel30", "pixel31", "pixel32", "pixel33", "pixel34", "pixel35", "pixel36", "pixel37", "pixel38", "pixel39", "pixel40", "pixel41", "pixel42", "pixel43", "pixel44", "pixel45", "pixel46", "pixel47", "pixel48", "pixel49", "pixel50", "pixel51", "pixel52", "pixel53", "pixel54", "pixel55", "pixel56", "pixel57", "pixel58", "pixel59", "pixel60", "pixel61", "pixel62", "pixel63", "pixel64", "pixel65", "pixel66", "pixel67", "pixel68", "pixel69", "pixel70", "pixel71", "pixel72", "pixel73", "pixel74", "pixel75", "pixel76", "pixel77", "pixel78", "pixel79", "pixel80", "pixel81", "pixel82", "pixel83", "pixel84", "pixel85", "pixel86", "pixel87", "pixel88", "pixel89", "pixel90", "pixel91", "pixel92", "pixel93", "pixel94", "pixel95", "pixel96", "pixel97", "pixel98", "pixel99", "pixel100", "pixel101", "pixel102", "pixel103", "pixel104", "pixel105", "pixel106", "pixel107", "pixel108", "pixel109", "pixel110", "pixel111", "pixel112", "pixel113", "pixel114", "pixel115", "pixel116", "pixel117", "pixel118", "pixel119", "pixel120", "pixel121", "pixel122", "pixel123", "pixel124", "pixel125", "pixel126", "pixel127", "pixel128", "pixel129", "pixel130", "pixel131", "pixel132", "pixel133", "pixel134", "pixel135", "pixel136", "pixel137", "pixel138", "pixel139", "pixel140", "pixel141", "pixel142", "pixel143", "pixel144", "pixel145", "pixel146", "pixel147", "pixel148", "pixel149", "pixel150", "pixel151", "pixel152", "pixel153", "pixel154", "pixel155", "pixel156", "pixel157", "pixel158", "pixel159", "pixel160", "pixel161", "pixel162", "pixel163", "pixel164", "pixel165", "pixel166", "pixel167", "pixel168", "pixel169", "pixel170", "pixel171", "pixel172", "pixel173", "pixel174", "pixel175", "pixel176", "pixel177", "pixel178", "pixel179", "pixel180", "pixel181", "pixel182", "pixel183", "pixel184", "pixel185", "pixel186", "pixel187", "pixel188", "pixel189", "pixel190", "pixel191", "pixel192", "pixel193", "pixel194", "pixel195", "pixel196", "pixel197", "pixel198", "pixel199", "pixel200", "pixel201", "pixel202", "pixel203", "pixel204", "pixel205", "pixel206", "pixel207", "pixel208", "pixel209", "pixel210", "pixel211", "pixel212", "pixel213", "pixel214", "pixel215", "pixel216", "pixel217", "pixel218", "pixel219", "pixel220", "pixel221", "pixel222", "pixel223", "pixel224", "pixel225", "pixel226", "pixel227", "pixel228", "pixel229", "pixel230", "pixel231", "pixel232", "pixel233", "pixel234", "pixel235", "pixel236", "pixel237", "pixel238", "pixel239", "pixel240", "pixel241", "pixel242", "pixel243", "pixel244", "pixel245", "pixel246", "pixel247", "pixel248", "pixel249", "pixel250", "pixel251", "pixel252", "pixel253", "pixel254", "pixel255", "pixel256", "pixel257", "pixel258", "pixel259", "pixel260", "pixel261", "pixel262", "pixel263", "pixel264", "pixel265", "pixel266", "pixel267", "pixel268", "pixel269", "pixel270", "pixel271", "pixel272", "pixel273", "pixel274", "pixel275", "pixel276", "pixel277", "pixel278", "pixel279", "pixel280", "pixel281", "pixel282", "pixel283", "pixel284", "pixel285", "pixel286", "pixel287", "pixel288", "pixel289", "pixel290", "pixel291", "pixel292", "pixel293", "pixel294", "pixel295", "pixel296", "pixel297", "pixel298", "pixel299", "pixel300", "pixel301", "pixel302", "pixel303", "pixel304", "pixel305", "pixel306", "pixel307", "pixel308", "pixel309", "pixel310", "pixel311", "pixel312", "pixel313", "pixel314", "pixel315", "pixel316", "pixel317", "pixel318", "pixel319", "pixel320", "pixel321", "pixel322", "pixel323", "pixel324", "pixel325", "pixel326", "pixel327", "pixel328", "pixel329", "pixel330", "pixel331", "pixel332", "pixel333", "pixel334", "pixel335", "pixel336", "pixel337", "pixel338", "pixel339", "pixel340", "pixel341", "pixel342", "pixel343", "pixel344", "pixel345", "pixel346", "pixel347", "pixel348", "pixel349", "pixel350", "pixel351", "pixel352", "pixel353", "pixel354", "pixel355", "pixel356", "pixel357", "pixel358", "pixel359", "pixel360", "pixel361", "pixel362", "pixel363", "pixel364", "pixel365", "pixel366", "pixel367", "pixel368", "pixel369", "pixel370", "pixel371", "pixel372", "pixel373", "pixel374", "pixel375", "pixel376", "pixel377", "pixel378", "pixel379", "pixel380", "pixel381", "pixel382", "pixel383", "pixel384", "pixel385", "pixel386", "pixel387", "pixel388", "pixel389", "pixel390", "pixel391", "pixel392", "pixel393", "pixel394", "pixel395", "pixel396", "pixel397", "pixel398", "pixel399", "pixel400", "pixel401", "pixel402", "pixel403", "pixel404", "pixel405", "pixel406", "pixel407", "pixel408", "pixel409", "pixel410", "pixel411", "pixel412", "pixel413", "pixel414", "pixel415", "pixel416", "pixel417", "pixel418", "pixel419", "pixel420", "pixel421", "pixel422", "pixel423", "pixel424", "pixel425", "pixel426", "pixel427", "pixel428", "pixel429", "pixel430", "pixel431", "pixel432", "pixel433", "pixel434", "pixel435", "pixel436", "pixel437", "pixel438", "pixel439", "pixel440", "pixel441", "pixel442", "pixel443", "pixel444", "pixel445", "pixel446", "pixel447", "pixel448", "pixel449", "pixel450", "pixel451", "pixel452", "pixel453", "pixel454", "pixel455", "pixel456", "pixel457", "pixel458", "pixel459", "pixel460", "pixel461", "pixel462", "pixel463", "pixel464", "pixel465", "pixel466", "pixel467", "pixel468", "pixel469", "pixel470", "pixel471", "pixel472", "pixel473", "pixel474", "pixel475", "pixel476", "pixel477", "pixel478", "pixel479", "pixel480", "pixel481", "pixel482", "pixel483", "pixel484", "pixel485", "pixel486", "pixel487", "pixel488", "pixel489", "pixel490", "pixel491", "pixel492", "pixel493", "pixel494", "pixel495", "pixel496", "pixel497", "pixel498", "pixel499", "pixel500", "pixel501", "pixel502", "pixel503", "pixel504", "pixel505", "pixel506", "pixel507", "pixel508", "pixel509", "pixel510", "pixel511", "pixel512", "pixel513", "pixel514", "pixel515", "pixel516", "pixel517", "pixel518", "pixel519", "pixel520", "pixel521", "pixel522", "pixel523", "pixel524", "pixel525", "pixel526", "pixel527", "pixel528", "pixel529", "pixel530", "pixel531", "pixel532", "pixel533", "pixel534", "pixel535", "pixel536", "pixel537", "pixel538", "pixel539", "pixel540", "pixel541", "pixel542", "pixel543", "pixel544", "pixel545", "pixel546", "pixel547", "pixel548", "pixel549", "pixel550", "pixel551", "pixel552", "pixel553", "pixel554", "pixel555", "pixel556", "pixel557", "pixel558", "pixel559", "pixel560", "pixel561", "pixel562", "pixel563", "pixel564", "pixel565", "pixel566", "pixel567", "pixel568", "pixel569", "pixel570", "pixel571", "pixel572", "pixel573", "pixel574", "pixel575", "pixel576", "pixel577", "pixel578", "pixel579", "pixel580", "pixel581", "pixel582", "pixel583", "pixel584", "pixel585", "pixel586", "pixel587", "pixel588", "pixel589", "pixel590", "pixel591", "pixel592", "pixel593", "pixel594", "pixel595", "pixel596", "pixel597", "pixel598", "pixel599", "pixel600", "pixel601", "pixel602", "pixel603", "pixel604", "pixel605", "pixel606", "pixel607", "pixel608", "pixel609", "pixel610", "pixel611", "pixel612", "pixel613", "pixel614", "pixel615", "pixel616", "pixel617", "pixel618", "pixel619", "pixel620", "pixel621", "pixel622", "pixel623", "pixel624", "pixel625", "pixel626", "pixel627", "pixel628", "pixel629", "pixel630", "pixel631", "pixel632", "pixel633", "pixel634", "pixel635", "pixel636", "pixel637", "pixel638", "pixel639", "pixel640", "pixel641", "pixel642", "pixel643", "pixel644", "pixel645", "pixel646", "pixel647", "pixel648", "pixel649", "pixel650", "pixel651", "pixel652", "pixel653", "pixel654", "pixel655", "pixel656", "pixel657", "pixel658", "pixel659", "pixel660", "pixel661", "pixel662", "pixel663", "pixel664", "pixel665", "pixel666", "pixel667", "pixel668", "pixel669", "pixel670", "pixel671", "pixel672", "pixel673", "pixel674", "pixel675", "pixel676", "pixel677", "pixel678", "pixel679", "pixel680", "pixel681", "pixel682", "pixel683", "pixel684", "pixel685", "pixel686", "pixel687", "pixel688", "pixel689", "pixel690", "pixel691", "pixel692", "pixel693", "pixel694", "pixel695", "pixel696", "pixel697", "pixel698", "pixel699", "pixel700", "pixel701", "pixel702", "pixel703", "pixel704", "pixel705", "pixel706", "pixel707", "pixel708", "pixel709", "pixel710", "pixel711", "pixel712", "pixel713", "pixel714", "pixel715", "pixel716", "pixel717", "pixel718", "pixel719", "pixel720", "pixel721", "pixel722", "pixel723", "pixel724", "pixel725", "pixel726", "pixel727", "pixel728", "pixel729", "pixel730", "pixel731", "pixel732", "pixel733", "pixel734", "pixel735", "pixel736", "pixel737", "pixel738", "pixel739", "pixel740", "pixel741", "pixel742", "pixel743", "pixel744", "pixel745", "pixel746", "pixel747", "pixel748", "pixel749", "pixel750", "pixel751", "pixel752", "pixel753", "pixel754", "pixel755", "pixel756", "pixel757", "pixel758", "pixel759", "pixel760", "pixel761", "pixel762", "pixel763", "pixel764", "pixel765", "pixel766", "pixel767", "pixel768", "pixel769", "pixel770", "pixel771", "pixel772", "pixel773", "pixel774", "pixel775", "pixel776", "pixel777", "pixel778", "pixel779", "pixel780", "pixel781", "pixel782", "pixel783" };
        }
    }
    public class MinstPrediction
    {
        [ColumnName("Label")]
        public float Label;
        [ColumnName("Score")]
        public float[] Score;
    }


}
