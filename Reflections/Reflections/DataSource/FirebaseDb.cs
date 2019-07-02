using Firebase.Database;
using Firebase.Database.Query;
using Firebase.Storage;
using Reflections.Model;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Reflections.DataSource
{
   public class FirebaseDb
    {
        FirebaseClient firebaseClient = new FirebaseClient("https://reflections-9dd5d.firebaseio.com/");

        public async Task<List<ReflectionModel>> GetAllReflections()
        {
            return (await firebaseClient
                .Child("Reflections")
                .OnceAsync<ReflectionModel>()).Select(item => new ReflectionModel
                {
                    Title = item.Object.Title,
                    PostContent = item.Object.PostContent,
                    PostDate = item.Object.PostDate,
                    PostType = item.Object.PostType,
                    Author = item.Object.Author,
                    ImagesUrl = item.Object.ImagesUrl
                }).ToList();
        }

        public async Task AddReflection(ReflectionModel reflectionModel)
        {
            await firebaseClient
                .Child("Reflections")
                .PostAsync<ReflectionModel>(reflectionModel);

        }

        public async Task<string> storeImage_ReturnUrl(Stream stream, string imgName)
        {
            var imgUrl = await new FirebaseStorage("reflections-9dd5d.appspot.com")
                .Child("ReflectionsImages")
                .Child(imgName + ".jpg")
                .PutAsync(stream);
            return imgUrl;
        }
    }
}
