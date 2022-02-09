using WebApplication1.Models;

namespace WebApplication1
{
    public static class DB
    {
        public static List<Suniukas> Suniukai = new List<Suniukas>()
        {
            new Suniukas()
            {
                Name = "Meskis",
                Picture = "https://images.dog.ceo/breeds/terrier-dandie/n02096437_1207.jpg"
            },
            new Suniukas()
            {
                Name = "Reksas",
                Picture = "https://images.dog.ceo/breeds/cattledog-australian/IMG_1042.jpg"
            },
            new Suniukas()
            {
                Name = "Sargiukas",
                Picture = "https://images.dog.ceo/breeds/mastiff-bull/n02108422_2094.jpg"
            },
            new Suniukas()
            {
                Name = "Kudlius",
                Picture = "https://images.dog.ceo/breeds/ovcharka-caucasian/IMG_20190628_144817.jpg"
            }
        };
    }
}
