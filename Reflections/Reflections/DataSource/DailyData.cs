using Reflections.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reflections.DataSource
{
   public class DailyData
    {
        List<ReflectionModel> getReflections;
        public DailyData()
        {
            getReflections = new List<ReflectionModel>
            {
                new ReflectionModel
                {
                    Title="Happy Feast and Workers Day",
                     Author="Fr. Michael Odubela, OSJ",
                      PostDate=DateTime.Now,
                       PostContent=@"As we honour St. Joseph on this workers' day, in this month of Mary and in this season of Jesus' Resurrection, May God multiply His favour in you, grant you abundant increase in all areas of life, bless the work of your hands and keep you inseparably United with Him. Amen! 
May you be fruitful in your work, joyful in your service and outstanding in witnessing to the reign of God on earth. Amen!

Happy Workers Day and Blessed New Month to you!",
                       ImagesUrl="fairy.png",
                       PostType= Model.Type.Daily
                },

                new ReflectionModel
                {
                    Title="DEEP WITHIN: A MOMENT WITH JESUS ",
                     Author="Fr. Michael Odubela, OSJ",
                      PostDate=DateTime.Now,
                       PostContent=@"Reflection for the 2nd Sunday of Easter, Yr.C
1st Rd. Acts 5: 27-32,40-41; Ps 29; 2nd Rd. Apo. 5:11-14; Gosp. Jn 21: 1-19.

     Beloved in the Risen Lord, we are invited on this third Sunday of Easter to witness with courage and love to the Lord's Gospel of Life. 
     The first reading from the Acts of the Apostles witnesses to the power of the Holy Spirit, as it motivates the Apostles to bear testimony to the Lord's Resurrection without fear, before the Jewish Supreme Court - the Sanhedrin. The once timid Peter, who denied his Lord before maids and common people now have the courage to stand before the high and the mighty of the land's judicial body to speak truth to power. The courage of Peter stems from the mercy and love he received and for this he was entirely renewed and set to bear all for Christ's sake. With the Confirmation of the Spirit on Pentecost the belt around his waist was fastened and the mission to witness commissioned. 
     Jesus' manifestation again to the disciples, after giving them His peace and calming their fears, was to bring them into closer union with Him and, thus, commission them for the ministry. By directing them to the catch of fish and inviting them to meal, Jesus showed Himself as the true master of events. He gives abundance, calls and feeds His own. His first miracle in John was providing wine to drink and the last is now providing bread and fish to eat. He continues to nourish us today through the same Bread and wine in the Eucharist. 
     Upon nourishing the disciples, Jesus questioned Peter three times, 'Do you love me'. Using Agape twice and Philia once, Jesus made Peter renounce his denial of Him and then renew his love and commitment to Him, even though imperfectly, since Peter could not rise twice to the level of love (Agape) Jesus really wished. In spite of the known imperfections of Peter, Jesus still entrusted the care of His flock to him. Again He demonstrates that He is the True Good Shepherd, who continues to guide His flock through Peter and his successors. He is the one who qualifies the called and turns every imperfection into a blessing. 
     The Lord wants us to truly love him, as much as it's humanly possible and then He can perfect His grace in us. Without true love no one can truly serve God or become a true servant of His Gospel. It was for love that He who knew no sin was made a sinner and the innocent lamb slaughtered to ransom humanity. It is also by that same love that humanity can bring glory, honour, worship and adoration to Him, for He alone is worthy.
     May God keep us truly in love with Him and use us for His glory. Amen!
     I wish you a joyful Sunday and a fruitful Week.
     Peace be with you!",
                       ImagesUrl="img.png",
                       PostType= Model.Type.Weekly
                },
                          new ReflectionModel
                {
                    Title="Happy Feast and Workers Day",
                     Author="Fr. Michael Odubela, OSJ",
                      PostDate=DateTime.Now,
                       PostContent=@"As we honour St. Joseph on this workers' day, in this month of Mary and in this season of Jesus' Resurrection, May God multiply His favour in you, grant you abundant increase in all areas of life, bless the work of your hands and keep you inseparably United with Him. Amen! 
May you be fruitful in your work, joyful in your service and outstanding in witnessing to the reign of God on earth. Amen!

Happy Workers Day and Blessed New Month to you!",
                       ImagesUrl="fairy.png",
                       PostType= Model.Type.Monthly
                },

                new ReflectionModel
                {
                    Title="DEEP WITHIN: A MOMENT WITH JESUS ",
                     Author="Fr. Michael Odubela, OSJ",
                      PostDate=DateTime.Now,
                       PostContent=@"Reflection for the 2nd Sunday of Easter, Yr.C
1st Rd. Acts 5: 27-32,40-41; Ps 29; 2nd Rd. Apo. 5:11-14; Gosp. Jn 21: 1-19.

     Beloved in the Risen Lord, we are invited on this third Sunday of Easter to witness with courage and love to the Lord's Gospel of Life. 
     The first reading from the Acts of the Apostles witnesses to the power of the Holy Spirit, as it motivates the Apostles to bear testimony to the Lord's Resurrection without fear, before the Jewish Supreme Court - the Sanhedrin. The once timid Peter, who denied his Lord before maids and common people now have the courage to stand before the high and the mighty of the land's judicial body to speak truth to power. The courage of Peter stems from the mercy and love he received and for this he was entirely renewed and set to bear all for Christ's sake. With the Confirmation of the Spirit on Pentecost the belt around his waist was fastened and the mission to witness commissioned. 
     Jesus' manifestation again to the disciples, after giving them His peace and calming their fears, was to bring them into closer union with Him and, thus, commission them for the ministry. By directing them to the catch of fish and inviting them to meal, Jesus showed Himself as the true master of events. He gives abundance, calls and feeds His own. His first miracle in John was providing wine to drink and the last is now providing bread and fish to eat. He continues to nourish us today through the same Bread and wine in the Eucharist. 
     Upon nourishing the disciples, Jesus questioned Peter three times, 'Do you love me'. Using Agape twice and Philia once, Jesus made Peter renounce his denial of Him and then renew his love and commitment to Him, even though imperfectly, since Peter could not rise twice to the level of love (Agape) Jesus really wished. In spite of the known imperfections of Peter, Jesus still entrusted the care of His flock to him. Again He demonstrates that He is the True Good Shepherd, who continues to guide His flock through Peter and his successors. He is the one who qualifies the called and turns every imperfection into a blessing. 
     The Lord wants us to truly love him, as much as it's humanly possible and then He can perfect His grace in us. Without true love no one can truly serve God or become a true servant of His Gospel. It was for love that He who knew no sin was made a sinner and the innocent lamb slaughtered to ransom humanity. It is also by that same love that humanity can bring glory, honour, worship and adoration to Him, for He alone is worthy.
     May God keep us truly in love with Him and use us for His glory. Amen!
     I wish you a joyful Sunday and a fruitful Week.
     Peace be with you!",
                       ImagesUrl="img.png",
                       PostType= Model.Type.Solemnity
                }
            };
        }



        public List<ReflectionModel> GetReflections => getReflections;

    }
}
