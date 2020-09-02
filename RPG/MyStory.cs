using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class MyStory
    {
        public string Story1 { get; }
        public string Story2 { get; }
        public string Story3 { get; }
        public string Story4 { get; }
        public string Story5 { get; }
        public string Story6 { get; }
        public string Story7 { get; }

        public MyStory()
        {
            Story1 = "Hello, my friend. Stay awhile and listen...";
            Story2 = "Long ago, Diablo and his brothers were cast out of Hell by the Lesser Evils. \nIt seems that Hell's balance has shifted, as Andariel is now aligned with the Lord of Terror. \nHer presence here in the mortal realm does not bode well for us.";
            Story3 = "Diablo nears his goal. We have little time to lose. \nRemember, my friend, that Adariel gave herself willingly to Diablo's cause. \nIt would be prudent to assume that the other Evils will attempt to aid their master as well.";
            Story4 = "You must reach Mephisto before his brothers do. \nThe ancient Horadrim always feared that the Three would escape their prisons and unite. \nI can't believe that I, the last of their Order, have seen it come to pass.";
            Story5 = "You don't have time to dally about here! \nDiablo awaits you in Hell. Remember... Diablo's greatest weapon against you is Terror. \nDon't give in to your fears. Resist his power and put an end to him for good!";
            Story6 = "Remember this. Baal once possessed Tal Rasha, one of the most powerful of the ancient Horadrim. \nYour battles with Mephisto and Diablo will pale in comparison to your battle with Baal. \nThe Lord of Destruction aided by Tal Rasha's knowledge...The mountain itself will tremble when you clash.";
            Story7 = "I knew in time you would defeat Baal. You have done everything you set out to do, my friend. \nEver since you rescued me from Tristram, I have believed in you. It has been a supreme honor to aid you along the way. \nSo...The Worldstone was corrupted by Baal. And now Tyrael must destroy it. Worry not. Though whatever lies ahead I have faith that the Light will guide us both. \nGo, now, back to the Worldstone chamber, and enter the portal Tyrael has opened for you.";
        }
    }
}
