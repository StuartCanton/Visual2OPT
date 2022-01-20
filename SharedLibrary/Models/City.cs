using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.Models
{
    public class City
    {
        public City(int id, string name, double lat, double lng, string country, string continent, string iso2, string iso3, int population, int profit, int identifier)
        {
            Id = id;
            Continent = continent;
            Name = name;
            Lat = lat;
            Lng = lng;
            Country = country;
            this.iso2 = iso2;
            this.iso3 = iso3;
            Population = population;
            Profit = profit;
            Identifier = identifier;
        }

        public int Id { get; set; }
        public string Continent { get; set; }
        public string Name { get; set; }
        public double Lat { get; set; }
        public double Lng { get; set; }
        public string Country { get; set; }
        public string iso2 { get; set; }
        public string iso3 { get; set; }
        public int Population { get; set; }
        public int Profit { get; set; }
        public int Identifier { get; set; }


    }

    //public class CityViewModel
    //{
    //    public async Task<List<City>> GetAll()
    //    {
    //        return await CapitalCities.Capitals;
    //    }
    //}


    public static class CapitalCities
    {
        //public static async <List<City> GetAll()
        //{
        //    //var list = new List<City>();
        //    return Capitals;
        //}

    //private async Task<List<SuperHero>> GetDbHeroes()
    //{
    //    return await _context.SuperHeroes.Include(sh => sh.Comic).ToListAsync();
    //}

    public static readonly List<City> Capitals = new List<City>()
        {

            new City(1,"Tokyo",35.6897,139.6922,"Japan","Asia","JP","JPN",37977000,37977000,1392685764),
            new City(2,"Jakarta",-6.2146,106.8451,"Indonesia","Asia","ID","IDN",34540000,34540000,1360771077),
            new City(3,"Manila",14.6,120.9833,"Philippines","Asia","PH","PHL",23088000,23088000,1608618140),
            new City(4,"Seoul",37.56,126.99,"Korea, South","Asia","KR","KOR",21794000,21794000,1410836482),
            new City(5,"Mexico City",19.4333,-99.1333,"Mexico","North America","MX","MEX",20996000,20996000,1484247881),
            new City(6,"Beijing",39.905,116.3914,"China","Asia","CN","CHN",19433000,19433000,1156228865),
            new City(7,"Cairo",30.0561,31.2394,"Egypt","Africa","EG","EGY",19372000,19372000,1818253931),
            new City(8,"Moscow",55.7558,37.6178,"Russia","Europe","RU","RUS",17125000,17125000,1643318494),
            new City(9,"Bangkok",13.75,100.5167,"Thailand","Asia","TH","THA",17066000,17066000,1764068610),
            new City(10,"Buenos Aires",-34.5997,-58.3819,"Argentina","South America","AR","ARG",16157000,16157000,1032717330),
            new City(11,"Dhaka",23.7289,90.3944,"Bangladesh","Asia","BD","BGD",15443000,15443000,1050529279),
            new City(12,"Tehran",35.7,51.4167,"Iran","Asia","IR","IRN",13633000,13633000,1364305026),
            new City(13,"Kinshasa",-4.3233,15.3081,"Congo (Kinshasa)","Africa","CD","COD",13528000,13528000,1180000363),
            new City(14,"Paris",48.8566,2.3522,"France","Europe","FR","FRA",11020000,11020000,1250015082),
            new City(15,"London",51.5072,-0.1275,"United Kingdom","Europe","GB","GBR",10979000,10979000,1826645935),
            new City(16,"Lima",-12.05,-77.0333,"Peru","South America","PE","PER",9848000,9848000,1604728603),
            new City(17,"Bogota",4.6126,-74.0705,"Colombia","South America","CO","COL",9464000,9464000,1170483426),
            new City(18,"Luanda",-8.8383,13.2344,"Angola","Africa","AO","AGO",8417000,8417000,1024949724),
            new City(19,"Kuala Lumpur",3.1478,101.6953,"Malaysia","Asia","MY","MYS",8285000,8285000,1458988644),
            new City(20,"Hanoi",21.0245,105.8412,"Vietnam","Asia","VN","VNM",7785000,7785000,1704413791),
            new City(21,"Hong Kong",22.305,114.185,"Hong Kong","Asia","HK","HKG",7347000,7347000,1344982653),
            new City(22,"Khartoum",15.6031,32.5265,"Sudan","Africa","SD","SDN",7282000,7282000,1729268475),
            new City(23,"Santiago",-33.45,-70.6667,"Chile","South America","CL","CHL",7007000,7007000,1152554349),
            new City(24,"Riyadh",24.65,46.71,"Saudi Arabia","Asia","SA","SAU",6881000,6881000,1682999334),
            new City(25,"Dar es Salaam",-6.8,39.2833,"Tanzania","Africa","TZ","TZA",6698000,6698000,1834843853),
            new City(26,"Madrid",40.4167,-3.7167,"Spain","Europe","ES","ESP",6026000,6026000,1724616994),
            new City(27,"Baghdad",33.35,44.4167,"Iraq","Asia","IQ","IRQ",5796000,5796000,1368596238),
            new City(28,"Singapore",1.3,103.8,"Singapore","Asia","SG","SGP",5745000,5745000,1702341327),
            new City(29,"Nairobi",-1.2864,36.8172,"Kenya","Africa","KE","KEN",5545000,5545000,1404000661),
            new City(30,"Ankara",39.93,32.85,"Turkey","Asia","TR","TUR",5503985,5503985,1792572891),
            new City(31,"Rangoon",16.8,96.15,"Myanmar","Asia","MM","MMR",5430000,5430000,1104616656),
            new City(32,"Washington",38.9047,-77.0163,"United States","North America","US","USA",5379184,5379184,1840006060),
            new City(33,"Abidjan",5.3364,-4.0267,"Côte D’Ivoire","Africa","CI","CIV",4980000,4980000,1384207980),
            new City(34,"Amman",31.95,35.9333,"Jordan","Asia","JO","JOR",4007526,4007526,1400522593),
            new City(35,"Kabul",34.5328,69.1658,"Afghanistan","Asia","AF","AFG",3678034,3678034,1004993580),
            new City(36,"Berlin",52.5167,13.3833,"Germany","Europe","DE","DEU",3644826,3644826,1276451290),
            new City(37,"Algiers",36.7764,3.0586,"Algeria","Africa","DZ","DZA",3415811,3415811,1012973369),
            new City(38,"Addis Ababa",9.0272,38.7369,"Ethiopia","Africa","ET","ETH",3041002,3041002,1231824991),
            new City(39,"Brasilia",-15.7939,-47.8828,"Brazil","South America","BR","BRA",3015268,3015268,1076144436),
            new City(40,"Kuwait City",29.375,47.98,"Kuwait","Asia","KW","KWT",2989000,2989000,1414102075),
            new City(41,"Kyiv",50.45,30.5236,"Ukraine","Europe","UA","UKR",2963199,2963199,1804382913),
            new City(42,"Sanaa",15.35,44.2,"Yemen","Asia","YE","YEM",2957000,2957000,1887750814),
            new City(43,"Rome",41.8931,12.4828,"Italy","Europe","IT","ITA",2872800,2872800,1380382862),
            new City(44,"La Paz",-16.4942,-68.1475,"Bolivia","South America","BO","BOL",2867504,2867504,1068000064),
            new City(45,"Pyongyang",39.03,125.73,"Korea, North","Asia","KP","PRK",2863000,2863000,1408738594),
            new City(46,"Taipei",25.0478,121.5319,"Taiwan","Asia","TW","TWN",2684567,2684567,1158881289),
            new City(47,"Antananarivo",-18.9386,47.5214,"Madagascar","Africa","MG","MDG",2610000,2610000,1450978461),
            new City(48,"Santo Domingo",18.4764,-69.8933,"Dominican Republic","North America","DO","DOM",2581827,2581827,1214636202),
            new City(49,"Guatemala City",14.6099,-90.5252,"Guatemala","North America","GT","GTM",2450212,2450212,1320197916),
            new City(50,"Yaounde",3.8578,11.5181,"Cameroon","Africa","CM","CMR",2440462,2440462,1120298240),
            new City(51,"Tashkent",41.3,69.2667,"Uzbekistan","Asia","UZ","UZB",2424100,2424100,1860331871),
            new City(52,"Accra",5.6037,-0.187,"Ghana","Africa","GH","GHA",2291352,2291352,1288299415),
            new City(53,"Baku",40.3667,49.8352,"Azerbaijan","Asia","AZ","AZE",2181800,2181800,1031946365),
            new City(54,"Harare",-17.8292,31.0522,"Zimbabwe","Africa","ZW","ZWE",2150000,2150000,1716196799),
            new City(55,"Havana",23.1367,-82.3589,"Cuba","North America","CU","CUB",2141652,2141652,1192752771),
            new City(56,"Phnom Penh",11.5696,104.921,"Cambodia","Asia","KH","KHM",2129371,2129371,1116260534),
            new City(57,"Mogadishu",2.0408,45.3425,"Somalia","Africa","SO","SOM",2120000,2120000,1706893395),
            new City(58,"Bamako",12.6458,-7.9922,"Mali","Africa","ML","MLI",2009109,2009109,1466965925),
            new City(59,"Quito",-0.2186,-78.5097,"Ecuador","South America","EC","ECU",2011388,2011388,1218441993),
            new City(60,"Minsk",53.9022,27.5618,"Belarus","Europe","BY","BLR",2009786,2009786,1112348503),
            new City(61,"Caracas",10.5,-66.9333,"Venezuela","South America","VE","VEN",1943901,1943901,1862748204),
            new City(62,"Vienna",48.2083,16.3731,"Austria","Europe","AT","AUT",1911191,1911191,1040261752),
            new City(63,"Bucharest",44.4,26.0833,"Romania","Europe","RO","ROU",1883425,1883425,1642414442),
            new City(64,"Asuncion",-25.3,-57.6333,"Paraguay","South America","PY","PRY",1870000,1870000,1600057911),
            new City(65,"Brazzaville",-4.2667,15.2833,"Congo (Brazzaville)","Africa","CG","COG",1827000,1827000,1178340306),
            new City(66,"Warsaw",52.2167,21.0333,"Poland","Europe","PL","POL",1790658,1790658,1616024847),
            new City(67,"Damascus",33.5131,36.2919,"Syria","Asia","SY","SYR",1754000,1754000,1760685964),
            new City(68,"Brussels",50.8333,4.3333,"Belgium","Europe","BE","BEL",1743000,1743000,1056469830),
            new City(69,"Budapest",47.4983,19.0408,"Hungary","Europe","HU","HUN",1752286,1752286,1348611435),
            new City(70,"Lusaka",-15.4167,28.2833,"Zambia","Africa","ZM","ZMB",1742979,1742979,1894157390),
            new City(71,"Conakry",9.5092,-13.7122,"Guinea","Africa","GN","GIN",1667864,1667864,1324568159),
            new City(72,"Kampala",0.3136,32.5811,"Uganda","Africa","UG","UGA",1659600,1659600,1800406299),
            new City(73,"Ouagadougou",12.3572,-1.5353,"Burkina Faso","Africa","BF","BFA",1626950,1626950,1854029208),
            new City(74,"Muscat",23.6139,58.5922,"Oman","Asia","OM","OMN",1421409,1421409,1512035506),
            new City(75,"The Hague",52.0767,4.2986,"Netherlands","Europe","NL","NLD",1406000,1406000,1528799905),
            new City(76,"Ulaanbaatar",47.9203,106.9172,"Mongolia","Asia","MN","MNG",1396288,1396288,1496024767),
            new City(77,"Belgrade",44.8167,20.4667,"Serbia","Europe","RS","SRB",1378682,1378682,1688374696),
            new City(78,"Sofia",42.6979,23.3217,"Bulgaria","Europe","BG","BGR",1355142,1355142,1100762037),
            new City(79,"Prague",50.0833,14.4167,"Czechia","Europe","CZ","CZE",1335084,1335084,1203744823),
            new City(80,"Montevideo",-34.8667,-56.1667,"Uruguay","South America","UY","URY",1319108,1319108,1858107000),
            new City(81,"Doha",25.3,51.5333,"Qatar","Asia","QA","QAT",1312947,1312947,1634459660),
            new City(82,"Abuja",9.0556,7.4914,"Nigeria","Africa","NG","NGA",1235880,1235880,1566342270),
            new City(83,"Maputo",-25.9153,32.5764,"Mozambique","Africa","MZ","MOZ",1191613,1191613,1508074843),
            new City(84,"Dublin",53.3497,-6.2603,"Ireland","Europe","IE","IRL",1173179,1173179,1372595407),
            new City(85,"Nay Pyi Taw",19.7475,96.115,"Myanmar","Asia","MM","MMR",1160242,1160242,1104838105),
            new City(86,"Dakar",14.7319,-17.4572,"Senegal","Africa","SN","SEN",1146053,1146053,1686604760),
            new City(87,"Kigali",-1.9536,30.0606,"Rwanda","Africa","RW","RWA",1156663,1156663,1646923541),
            new City(88,"Tegucigalpa",14.0942,-87.2067,"Honduras","North America","HN","HND",1126534,1126534,1340344059),
            new City(89,"Tripoli",32.8752,13.1875,"Libya","Africa","LY","LBY",1126000,1126000,1434201852),
            new City(90,"Tbilisi",41.7225,44.7925,"Georgia","Europe","GE","GEO",1118035,1118035,1268203191),
            new City(91,"N_Djamena",12.11,15.05,"Chad","Africa","TD","TCD",1092066,1092066,1148708596),
            new City(92,"Yerevan",40.1814,44.5144,"Armenia","Europe","AM","ARG",1075800,1075800,1051074169),
            new City(93,"Nur-Sultan",51.1333,71.4333,"Kazakhstan","Asia","KZ","KAZ",1078362,1078362,1398516045),
            new City(94,"Nouakchott",18.0858,-15.9785,"Mauritania","Africa","MR","MRT",1077169,1077169,1478414984),
            new City(95,"Tunis",36.8008,10.18,"Tunisia","Africa","TN","TUN",1056247,1056247,1788742103),
            new City(96,"Bishkek",42.8667,74.5667,"Kyrgyzstan","Asia","KG","KGZ",1027200,1027200,1417191971),
            new City(97,"Ashgabat",37.95,58.3833,"Turkmenistan","Asia","TM","TKM",1031992,1031992,1795049992),
            new City(98,"Niamey",13.5086,2.1111,"Niger","Africa","NE","NER",1026848,1026848,1562932886),
            new City(99,"Managua",12.15,-86.2667,"Nicaragua","North America","NI","NIC",1028808,1028808,1558296252),
            new City(100,"Monrovia",6.3106,-10.8047,"Liberia","Africa","LR","LBR",1021762,1021762,1430477826),
            new City(101,"Port-au-Prince",18.5425,-72.3386,"Haiti","North America","HT","HTI",987310,987310,1332401940),
            new City(102,"Islamabad",33.6989,73.0369,"Pakistan","Asia","PK","PAK",1014825,1014825,1586306717),
            new City(103,"Kathmandu",27.7167,85.3667,"Nepal","Asia","NP","NPL",975453,975453,1524589448),
            new City(104,"Abu Dhabi",24.4781,54.3686,"United Arab Emirates","Asia","AE","ARE",1000000,1000000,1784176710),
            new City(105,"Stockholm",59.3294,18.0686,"Sweden","Europe","SE","SWE",972647,972647,1752425602),
            new City(106,"Asmara",15.3333,38.9167,"Eritrea","Africa","ER","ERI",963000,963000,1232791236),
            new City(107,"Freetown",8.4833,-13.2331,"Sierra Leone","Africa","SL","SLE",951000,951000,1694085071),
            new City(108,"Jerusalem",31.7833,35.2167,"Israel","Asia","IL","ISR",919438,919438,1376261644),
            new City(109,"Bangui",4.3732,18.5628,"Central African Republic","Africa","CF","CAF",889231,889231,1140080881),
            new City(110,"Panama City",9,-79.5,"Panama","North America","PA","PAN",880691,880691,1591672475),
            new City(111,"Amsterdam",52.3667,4.8833,"Netherlands","Europe","NL","NLD",862965,862965,1528355309),
            new City(112,"Lome",6.1319,1.2228,"Togo","Africa","TG","TGO",837437,837437,1768409132),
            new City(113,"Libreville",0.3901,9.4544,"Gabon","Africa","GA","GAB",797003,797003,1266952885),
            new City(114,"Zagreb",45.8,15.95,"Croatia","Europe","HR","HRV",790017,790017,1191233290),
            new City(115,"Dushanbe",38.5731,68.7864,"Tajikistan","Asia","TJ","TJK",778500,778500,1762930616),
            new City(116,"Lilongwe",-13.9833,33.7833,"Malawi","Africa","MW","MWI",781538,781538,1454688499),
            new City(117,"Cotonou",6.4,2.52,"Benin","Africa","BJ","BEN",762000,762000,1204955174),
            new City(118,"Vientiane",17.9667,102.6,"Laos","Asia","LA","LAO",760000,760000,1418732714),
            new City(119,"Colombo",6.9167,79.8333,"Sri Lanka","Asia","LK","LKA",752993,752993,1144251314),
            new City(120,"Pretoria",-25.7464,28.1881,"South Africa","africa","ZA","ZAF",741651,741651,1710176249),
            new City(121,"Oslo",59.9111,10.7528,"Norway","Europe","NO","NOR",693494,693494,1578324706),
            new City(122,"Athens",37.9842,23.7281,"Greece","Europe","GR","GRC",664046,664046,1300715560),
            new City(123,"Bujumbura",-3.3825,29.3611,"Burundi","Africa","BI","BDI",658859,658859,1108101689),
            new City(124,"Helsinki",60.1756,24.9342,"Finland","Europe","FI","FIN",642045,642045,1246177997),
            new City(125,"Skopje",41.9833,21.4333,"Macedonia","Europe","MK","MKD",640000,640000,1807600615),
            new City(126,"Chisinau",47.0228,28.8353,"Moldova","Europe","MD","MDA",639000,639000,1498011437),
            new City(127,"Riga",56.9475,24.1069,"Latvia","Europe","LV","LVA",614618,614618,1428586192),
            new City(128,"Copenhagen",55.6761,12.5689,"Denmark","Europe","DK","DNK",602481,602481,1208763942),
            new City(129,"Kingston",17.9714,-76.7931,"Jamaica","North America","JM","JAM",580000,580000,1388709177),
            new City(130,"Rabat",34.0253,-6.8361,"Morocco","Africa","MA","MAR",572717,572717,1504023252),
            new City(131,"Vilnius",54.6833,25.2833,"Lithuania","Europe","LT","LTU",574147,574147,1440887149),
            new City(132,"San Salvador",13.6989,-89.1914,"El Salvador","North America","SV","SLV",567698,567698,1222647454),
            new City(133,"Djibouti",11.595,43.1481,"Djibouti","Africa","DJ","DJI",562000,562000,1262028958),
            new City(134,"Lisbon",38.7452,-9.1604,"Portugal","Europe","PT","PRT",506654,506654,1620619017),
            new City(135,"Tallinn",59.4372,24.745,"Estonia","Europe","EE","EST",438341,438341,1233260021),
            new City(136,"Cape Town",-33.925,18.425,"South Africa","Africa","ZA","ZAF",433688,433688,1710680650),
            new City(137,"Bratislava",48.1447,17.1128,"Slovakia","Europe","SK","SVK",429564,429564,1703195001),
            new City(138,"Tirana",41.33,19.82,"Albania","Europe","AL","ALB",418495,418495,1008162156),
            new City(139,"Canberra",-35.2931,149.1269,"Australia","Australasia","AU","AUS",426704,426704,1036142029),
            new City(140,"Wellington",-41.2889,174.7772,"New Zealand","Australasia","NZ","NZL",418500,418500,1554772152),
            new City(141,"Beirut",33.8869,35.5131,"Lebanon","Asia","LB","LBN",361366,361366,1422847713),
            new City(142,"Dodoma",-6.1835,35.746,"Tanzania","Africa","TZ","TZA",410956,410956,1834288497),
            new City(143,"Bissau",11.8592,-15.5956,"Guinea-Bissau","Africa","GW","GNB",395954,395954,1624168850),
            new City(144,"Juba",4.85,31.6,"South Sudan","Africa","SS","SSD",372410,372410,1728444337),
            new City(145,"Port Moresby",-9.4789,147.1494,"Papua New Guinea","Australasia","PG","PNG",364125,364125,1598685395),
            new City(146,"Yamoussoukro",6.8161,-5.2742,"Côte D’Ivoire","Africa","CI","CIV",355573,355573,1384683557),
            new City(147,"Maseru",-29.31,27.48,"Lesotho","Africa","LS","LSO",330790,330790,1426977668),
            new City(148,"Nicosia",35.1725,33.365,"Cyprus","Europe","CY","CYP",330000,330000,1196944155),
            new City(149,"Windhoek",-22.57,17.0836,"Namibia","Africa","NA","NAM",322500,322500,1516802003),
            new City(150,"Porto-Novo",6.4833,2.6167,"Benin","Africa","BJ","BEN",300000,300000,1204172060),
            new City(151,"Sucre",-19.0431,-65.2592,"Bolivia","South America","BO","BOL",300000,300000,1068823873),
            new City(152,"San Jose",9.9333,-84.0833,"Costa Rica","North America","CR","CRI",288054,288054,1188749877),
            new City(153,"Ljubljana",46.05,14.5167,"Slovenia","Europe","SI","SVN",286745,286745,1705917455),
            new City(154,"Sarajevo",43.8667,18.4167,"Bosnia And Herzegovina","Europe","BA","BIH",275524,275524,1070966777),
            new City(155,"Nassau",25.0667,-77.3333,"Bahamas, The","North America","BS","BHS",274400,274400,1044318561),
            new City(156,"Bloemfontein",-29.1,26.2167,"South Africa","Africa","ZA","ZAF",256185,256185,1710495933),
            new City(157,"Fort-de-France",14.6104,-61.08,"Martinique","North America","MQ","MTQ",253995,253995,1474969110),
            new City(158,"Gaborone",-24.6569,25.9086,"Botswana","Africa","BW","BWA",231626,231626,1072756768),
            new City(159,"Paramaribo",5.8667,-55.1667,"Suriname","South America","SR","SUR",223757,223757,1740518660),
            new City(160,"Dili",-8.5586,125.5736,"Timor-Leste","Asia","TL","TLS",222323,222323,1626308942),
            new City(161,"Pristina",42.6667,21.1667,"Kosovo","Europe","XK","XKS",204725,204725,1901760068),
            new City(162,"Georgetown",6.7833,-58.1667,"Guyana","South America","GY","GUY",200500,200500,1328160906),
            new City(163,"Malabo",3.7521,8.7737,"Equatorial Guinea","Africa","GQ","GNQ",187302,187302,1226861333),
            new City(164,"Gibraltar",36.1324,-5.3781,"Gibraltar","Europe","GI","GIB",187083,187083,1292385245),
            new City(165,"Saint-Denis",-20.8789,55.4481,"Reunion","Africa","RE","REU",190047,190047,1638024662),
            new City(166,"Male",4.175,73.5083,"Maldives","Africa","MV","MDV",133019,133019,1462441685),
            new City(167,"Podgorica",42.4397,19.2661,"Montenegro","Europe","ME","MNE",174515,174515,1499454516),
            new City(168,"Manama",26.225,50.5775,"Bahrain","Asia","BH","BHR",157474,157474,1048989486),
            new City(169,"Port Louis",-20.1667,57.5,"Mauritius","Africa","MU","MUS",149194,149194,1480131261),
            new City(170,"Willemstad",12.108,-68.935,"Curaçao","South America","CW","CUW",150000,150000,1531000000),
            new City(171,"New Delhi",28.7,77.2,"India","Asia","IN","IND",142004,142004,1356215164),
            new City(172,"Bern",46.948,7.4474,"Switzerland","Europe","CH","CHE",133798,133798,1756374318),
            new City(173,"Papeete",-17.5334,-149.5667,"French Polynesia","Australasia","PF","PYF",131695,131695,1258907380),
            new City(174,"Reykjavik",64.1475,-21.935,"Iceland","Europe","IS","ISL",128793,128793,1352327190),
            new City(175,"Praia",14.9177,-23.5092,"Cabo Verde","Africa","CV","CPV",127832,127832,1132398770),
            new City(176,"Luxembourg",49.6106,6.1328,"Luxembourg","Europe","LU","LUX",124509,124509,1442262731),
            new City(177,"Sri Jayewardenepura Kotte",6.9,79.9164,"Sri Lanka","Asia","LK","LKA",115826,115826,1144239330),
            new City(178,"Bridgetown",13.0975,-59.6167,"Barbados","North America","BB","BRB",110000,110000,1052274244),
            new City(179,"Moroni",-11.7036,43.2536,"Comoros","Africa","KM","COM",111329,111329,1174793581),
            new City(180,"Thimphu",27.4833,89.6333,"Bhutan","Asia","BT","BTN",104000,104000,1064010361),
            new City(181,"Mbabane",-26.3208,31.1617,"Swaziland","Africa","SZ","SWZ",94874,94874,1748811945),
            new City(182,"Noumea",-22.2625,166.4443,"New Caledonia","Australasia","NC","NCL",93060,93060,1540958092),
            new City(183,"Honiara",-9.4333,159.95,"Solomon Islands","Australasia","SB","SLB",84520,84520,1090737486),
            new City(184,"Suva",-18.1333,178.4333,"Fiji","Australasia","FJ","FJI",88271,88271,1242615095),
            new City(185,"Castries",14.0167,-60.9833,"Saint Lucia","North America","LC","LCA",70000,70000,1662922505),
            new City(186,"Cayenne",4.933,-52.33,"French Guiana","South America","GF","GUF",61550,61550,1254304969),
            new City(187,"Sao Tome",0.3333,6.7333,"Sao Tome And Principe","Africa","ST","STP",56166,56166,1678301324),
            new City(188,"Port-Vila",-17.7333,168.3167,"Vanuatu","Australasia","VU","VUT",51437,51437,1548805075),
            new City(189,"Hamilton",32.2942,-64.7839,"Bermuda","North America","BM","BMU",52320,52320,1060000000),
            new City(190,"Bandar Seri Begawan",4.9167,114.9167,"Brunei","Asia","BN","BRN",50000,50000,1096465895),
            new City(191,"Monaco",43.7396,7.4069,"Monaco","Europe","MC","MCO",36371,36371,1492854256),
            new City(192,"Gitega",-3.4264,29.9306,"Burundi","Africa","BI","BDI",41944,41944,1108778000),
            new City(193,"Port of Spain",10.6667,-61.5167,"Trinidad And Tobago","Africa","TT","TTO",37074,37074,1780670676),
            new City(194,"Apia",-13.8333,-171.8333,"Samoa","Australasia","WS","WSM",37708,37708,1882489296),
            new City(195,"Douglas",54.15,-4.4819,"Isle Of Man","Europe","IM","IMN",35854,35854,1833688345),
            new City(196,"Oranjestad",12.5186,-70.0358,"Aruba","South America","AW","ABW",34980,34980,1533513057),
            new City(197,"Saint Helier",49.1833,-2.1167,"Jersey","Europe","JE","JEY",33522,33522,1832490253),
            new City(198,"Vaduz",47.1415,9.5215,"Liechtenstein","Europe","LI","LIE",36281,36281,1438317747),
            new City(199,"Banjul",13.4531,-16.5775,"Gambia, The","Africa","GM","GMB",31356,31356,1270723713),
            new City(200,"Mamoudzou",-12.7871,45.275,"Mayotte","Africa","YT","MYT",32057,32057,1175099654),
            new City(201,"Majuro",7.0918,171.3802,"Marshall Islands","Australasia","MH","MHL",30000,30000,1584000000),
            new City(202,"Tarawa",1.3382,173.0176,"Kiribati","Australasia","KI","KIR",28802,28802,1296152641),
            new City(203,"George Town",19.2866,-81.3744,"Cayman Islands","North America","KY","CYM",27704,27704,1136159124),
            new City(204,"Victoria",-4.6236,55.4544,"Seychelles","Africa","SC","SYC",26450,26450,1690193579),
            new City(205,"Kingstown",13.1667,-61.2333,"Saint Vincent And The Grenadines","North America","VC","VCT",25000,25000,1670376659),
            new City(206,"Saint John_s",17.1211,-61.8447,"Antigua And Barbuda","North America","AG","ATG",21926,21926,1028912067),
            new City(207,"Nuku`alofa",-21.1347,-175.2083,"Tonga","Australasia","TO","TON",23221,23221,1776737461),
            new City(208,"Andorra la Vella",42.5,1.5,"Andorra","Europe","AD","AND",22151,22151,1020828846),
            new City(209,"Nuuk",64.175,-51.7333,"Greenland","Europe","GL","GRL",18326,18326,1304028354),
            new City(210,"Belmopan",17.25,-88.7675,"Belize","Africa","BZ","BLZ",17222,17222,1084586375),
            new City(211,"Roseau",15.3,-61.3833,"Dominica","North America","DM","DMA",16582,16582,1212060440),
            new City(212,"Basseterre",17.2983,-62.7342,"Saint Kitts And Nevis","North America","KN","KNA",13220,13220,1659198919),
            new City(213,"Torshavn",62,-6.7833,"Faroe Islands","Europe","FO","FRO",13326,13326,1234904517),
            new City(214,"Pago Pago",-14.274,-170.7046,"American Samoa","Australasia","AS","ASM",12576,12576,1016976740),
            new City(215,"Valletta",35.8978,14.5125,"Malta","Europe","MT","MLT",6444,6444,1470574399),
            new City(216,"Gaza",31.5069,34.456,"Gaza Strip","Asia","XG","XGZ",6000,6000,1916116052),
            new City(217,"Grand Turk",21.4664,-71.136,"Turks And Caicos Islands","North America","TC","TCA",5801,5801,1796965313),
            new City(218,"Palikir",6.9178,158.185,"Micronesia, Federated States Of","Australasia","FM","FSM",6227,6227,1583008885),
            new City(219,"Funafuti",-8.5167,179.2167,"Tuvalu","Australasia","TV","TUV",6025,6025,1798251391),
            new City(220,"Lobamba",-26.4465,31.2064,"Swaziland","Africa","SZ","SWZ",5800,5800,1748963140),
            new City(221,"Avarua",-21.207,-159.771,"Cook Islands","Australasia","CK","COK",5445,5445,1184217570),
            new City(222,"Saint George_s",12.0444,-61.7417,"Grenada","North America","GD","GRD",4315,4315,1308891766),
            new City(223,"San Marino",43.932,12.4484,"San Marino","Europe","SM","SMR",4040,4040,1674741947),
            new City(224,"Al Quds",31.7764,35.2269,"West Bank","Asia","XW","XWB",3000,3000,1934000006),
            new City(225,"Capitol Hill",15.2137,145.7546,"Northern Mariana Islands","Australasia","MP","MNP",2500,2500,1580556972),
            new City(226,"Basse-Terre",16,-61.7167,"Guadeloupe","North America","GP","GLP",2400,2400,1312938008),
            new City(227,"Stanley",-51.7,-57.85,"Falkland Islands (Islas Malvinas)","South America","FK","FLK",2213,2213,1238780509),
            new City(228,"Vatican City",41.9,12.4478,"Vatican City","Europe","VA","VAT",825,825,1336000000),
            new City(229,"Alofi",-19.056,-169.921,"Niue","Australasia","NU","NIU",1611,1611,1570882835),
            new City(230,"Hagta",13.4745,144.7504,"Guam","Australasia","GU","GUM",1051,1051,1316937540),
            new City(231,"Jamestown",-15.9251,-5.7179,"Saint Helena, Ascension, And Tristan Da Cunha","Africa","SH","SHN",714,714,1654761576),
            new City(232,"Marigot",18.0706,-63.0847,"Saint Martin","North America","MF","MAF",600,600,1663133172),
            new City(233,"Philipsburg",18.0256,-63.0492,"Sint Maarten","North America","SX","SXM",550,550,1534859858),
            new City(234,"Road Town",18.4167,-64.6167,"Virgin Islands, British","North America","VG","VGB",540,540,1092732412),
            new City(235,"Gustavia",17.8958,-62.8508,"Saint Barthelemy","North America","BL","BLM",530,530,1652681565),
            new City(236,"Saint-Pierre",46.7811,-56.1764,"Saint Pierre And Miquelon","North America","PM","SPM",520,520,1666340272),
            new City(237,"The Valley",18.2167,-63.05,"Anguilla","North America","AI","AIA",510,510,1660698387),
            new City(238,"Mata-Utu",-13.2825,-176.1736,"Wallis And Futuna","Australasia","WF","WLF",500,500,1876784844),
            new City(239,"Kingston",-29.0569,167.9617,"Norfolk Island","Australasia","NF","NFK",490,490,1574121434),
            new City(240,"Ngerulmud",7.5006,134.6242,"Palau","Australasia","PW","PLW",480,480,1585525081),
            new City(241,"Tifariti",26.0928,-10.6089,"Morocco","Africa","MA","MAR",470,470,1504999990),
            new City(242,"Tifariti",26.0928,-10.6089,"Western Sahara","Africa","EH","ESH",460,460,1732006359),
            new City(243,"Longyearbyen",78.2167,15.6333,"Svalbard","Europe","XR","XSV",450,450,1930654114),
            new City(244,"Adamstown",-25.0667,-130.0833,"Pitcairn Islands","Australasia","PN","PCN",440,440,1612000000),
            new City(245,"Flying Fish Cove",-10.4167,105.7167,"Christmas Island","Asia","CX","CXR",430,430,1162889600),


        };

    }


}
