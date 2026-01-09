using NuGet.Protocol;

namespace PartyInvites2.Models
{
    public static class StorageClass
    {
        private static List<GuestResponse> guestResponses = new List<GuestResponse>();

        public static IEnumerable<GuestResponse> Responses { get { return guestResponses; } }

        public static void AddResponse(GuestResponse guestResponse)
        {
            guestResponses.Add(guestResponse);
            Console.WriteLine(guestResponse.ToJson());
            Console.WriteLine("Added to list successfully.");
            
            //Console.WriteLine(Environment.NewLine + "test see all");
            //PrintResponses();
            //Console.WriteLine(Environment.NewLine);
        }

        public static void PrintResponses()
        {
            foreach (GuestResponse guestResponse in guestResponses)
            {
                Console.WriteLine(guestResponse.ToJson());
            }   
        }
    }
}
