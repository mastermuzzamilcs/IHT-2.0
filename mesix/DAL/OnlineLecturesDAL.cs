namespace DAL
{
    //    public class OnlineLecturesDAL
    //    {
    //        public string UploadedVideoId { get; private set; }
    //        public string UploadeVideoId { get; private set; }
    //        public int videosInsertRequest_ProgressChanged { get; private set; }
    //        public int videosInsertRequest_ResponsedRecieved { get; private set; }


    //        //string keyFilePath = "AIzaSyCx_DQb9ArmVtIk21_fNafc9BVRv86V5Tk";
    //        //string serviceAccountEmail = "amsqrsolutions@developer.gserviceaccount.com";

    //        //var certificate = new X509Certificate2(keyFilePath, "notasecret", X509KeyStorageFlags.Exportable);

    //        //ServiceAccountCredential credential = new ServiceAccountCredential(newServiceAccountCredential.Initializer(serviceAccountEmail) //create credential using certigicate

    //        //    Scopes = new[] { "https://spreadsheets.google.com/feeds/" }
    //        // private FromCertificate(Certificate) 
    //        // { 

    //        //      credential.RequestAccessTokenAsync(System.Threading.CancellationToken.None).Wait(); //request token

    //        //      var requestFactory = new GDataRequestFactory("Some Name");
    //        //      requestFactory.CustomHeaders.Add(string.Format("Authorization: Bearer {0}", credential.Token.AccessToken));

    //        //      SpreadsheetsService myService = new SpreadsheetsService("You App Name"); //create your old service
    //        //      myService.RequestFactory = requestFactory; //add new request factory to your old service

    //        //      SpreadsheetQuery query = new SpreadsheetQuery(); //do the job as you done it before
    //        //      SpreadsheetFeed feed = myService.Query(query);

    //        //}


    //        public async Task Run(string videoPath)
    //        {

    //            UserCredential credential;
    //            using (var stream = new FileStream("client_secrets.json", FileMode.Open, FileAccess.Read))
    //            {
    //                credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
    //                    GoogleClientSecrets.Load(stream).Secrets,
    //                    // This OAuth 2.0 access scope allows for full read/write access to the
    //                    // authenticated user's account.
    //                    new[] { Google.Apis.YouTube.v3.YouTubeService.Scope.Youtube },
    //                    "user",
    //                    CancellationToken.None,
    //                    new FileDataStore(this.GetType().ToString())
    //                );
    //            }

    //            var youtubeService = new Google.Apis.YouTube.v3.YouTubeService(new BaseClientService.Initializer()
    //            {
    //                HttpClientInitializer = credential,
    //                ApplicationName = this.GetType().ToString()
    //            });


    //            var video = new Video();
    //            try
    //            {
    //                UploadedVideoId = "1";
    //                video.Snippet = new VideoSnippet();
    //                video.Snippet.Title = "abc";
    //                video.Snippet.Description = "saasas";


    //                video.Status = new VideoStatus();
    //                video.Status.PrivacyStatus = "public";
    //                var filePath = videoPath;
    //                using (var fileStream = new FileStream(filePath, FileMode.Open))
    //                {
    //                    var videosInsertRequest = youtubeService.Videos.Insert(video, "snippet,status", fileStream, "video/*");
    //                    //videosInsertRequest.ProgressChanged += videosInsertRequest_ProgressChanged;
    //                    //videosInsertRequest.ResponseReceived += videosInsertRequest_ResponseReceived;

    //                    await videosInsertRequest.UploadAsync();
    //                }


    //            }
    //            catch (Exception ex)
    //            {
    //                MessageBox.Show("Exception");
    //            }
    //            //// return UploadeVideoId;
    //        }


























    //        //    public string UploadVideoo(string FilePath, string Title, string Description)
    //        //    {
    //        //        YouTubeRequestSettings settings;
    //        //        YouTubeRequest request;
    //        //        string devkey = "AIzaSyCx_DQb9ArmVtIk21_fNafc9BVRv86V5Tk";
    //        //        string username = "amsqrsolutions@gmail.com";
    //        //        string password = "webdir123R";
    //        //        settings = new YouTubeRequestSettings("OnlineSchoolManagement", devkey, username, password) { Timeout = -1 };
    //        //        request = new YouTubeRequest(settings);

    //        //        Video newVideo = new Video();
    //        //        newVideo.Title = Title;
    //        //        newVideo.Description = Description;
    //        //        newVideo.Private = true;
    //        //        newVideo.YouTubeEntry.Private = false;

    //        //        {
    //        //            //onlineschoolmanagement-289110//PROJECT ID
    //        //            //524877478905// PROJECT NUMBER

    //        //            //newVideo.Tags.Add(new MediaCategory("Autos", YouTubeNameTable.CategorySchema));
    //        //            //newVideo.Tags.Add(new MediaCategory("mydevtag, anotherdevtag", YouTubeNameTable.DeveloperTagSchema));
    //        //            //newVideo.YouTubeEntry.setYouTubeExtension("location", "Paris, FR");
    //        //            // You can also specify just a descriptive string ==>
    //        //            // newVideo.YouTubeEntry.Location = new GeoRssWhere(71, -111);
    //        //            // newVideo.YouTubeEntry.setYouTubeExtension("location", "Paris, France.");
    //        //        }

    //        //        newVideo.YouTubeEntry.MediaSource = new MediaFileSource(FilePath, "video/mp4");
    //        //        Video createdVideo = request.Upload(newVideo);
    //        //        return createdVideo.VideoId;

    //        //        //return null;

    //        //    }


    //        //#region NewUploadCode


    //        //internal class UploadVideo
    //        //{
    //        //    [STAThread]
    //        //    static void Main(string[] args)
    //        //    {
    //        //        Console.WriteLine("YouTube Data API: Upload Video");
    //        //        Console.WriteLine("==============================");

    //        //        try
    //        //        {
    //        //            new UploadVideo().Run().Wait();
    //        //        }
    //        //        catch (AggregateException ex)
    //        //        {
    //        //            foreach (var e in ex.InnerExceptions)
    //        //            {
    //        //                Console.WriteLine("Error: " + e.Message);
    //        //            }
    //        //        }

    //        //        Console.WriteLine("Press any key to continue...");
    //        //        Console.ReadKey();
    //        //    }

    //        //    private async Task Run()
    //        //    {
    //        //        UserCredential credential;
    //        //        using (var stream = new FileStream("client_secrets.json", FileMode.Open, FileAccess.Read))
    //        //        {
    //        //            credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
    //        //                GoogleClientSecrets.Load(stream).Secrets,
    //        //                // This OAuth 2.0 access scope allows an application to upload files to the
    //        //                // authenticated user's YouTube channel, but doesn't allow other types of access.
    //        //                new[] { YouTubeService.Scope.YoutubeUpload },
    //        //                "user",
    //        //                CancellationToken.None
    //        //            );
    //        //        }


    //        //        var youtubeService = new YouTubeService(new BaseClientService.Initializer()
    //        //        {
    //        //            HttpClientInitializer = credential,
    //        //            ApplicationName = Assembly.GetExecutingAssembly().GetName().Name
    //        //        });

    //        //        var video = new Video();
    //        //        video.Snippet = new VideoSnippet();
    //        //        video.Snippet.Title = "Default Video Title";
    //        //        video.Snippet.Description = "Default Video Description";
    //        //        video.Snippet.Tags = new string[] { "tag1", "tag2" };
    //        //        video.Snippet.CategoryId = "22"; // See https://developers.google.com/youtube/v3/docs/videoCategories/list
    //        //        video.Status = new VideoStatus();
    //        //        video.Status.PrivacyStatus = "unlisted"; // or "private" or "public"
    //        //        var filePath = @"REPLACE_ME.mp4"; // Replace with path to actual movie file.

    //        //        using (var fileStream = new FileStream(filePath, FileMode.Open))
    //        //        {
    //        //            var videosInsertRequest = youtubeService.Videos.Insert(video, "snippet,status", fileStream, "video/*");
    //        //            videosInsertRequest.ProgressChanged += videosInsertRequest_ProgressChanged;
    //        //            videosInsertRequest.ResponseReceived += videosInsertRequest_ResponseReceived;

    //        //            await videosInsertRequest.UploadAsync();
    //        //        }
    //        //    }

    //        //    void videosInsertRequest_ProgressChanged(Google.Apis.Upload.IUploadProgress progress)
    //        //    {
    //        //        switch (progress.Status)
    //        //        {
    //        //            case UploadStatus.Uploading:
    //        //                Console.WriteLine("{0} bytes sent.", progress.BytesSent);
    //        //                break;

    //        //            case UploadStatus.Failed:
    //        //                Console.WriteLine("An error prevented the upload from completing.\n{0}", progress.Exception);
    //        //                break;
    //        //        }
    //        //    }

    //        //    void videosInsertRequest_ResponseReceived(Video video)
    //        //    {
    //        //        Console.WriteLine("Video id '{0}' was successfully uploaded.", video.Id);
    //        //    }
    //        //}

    //        //#endregion



    //        //public static bool DeleteVideo(string VideoId)
    //        //{
    //        //    try
    //        //    {
    //        //        YouTubeRequestSettings settings;
    //        //        YouTubeRequest request;
    //        //        string devkey = "YOUR DEVELOPPER KEY HERE";
    //        //        string username = "Your Youtube Username";
    //        //        string password = "Your Youtube Password";
    //        //        settings = new YouTubeRequestSettings("Your Application Name", devkey, username, password) { Timeout = -1 };
    //        //        request = new YouTubeRequest(settings);

    //        //        Uri videoEntryUrl = new Uri(String.Format("http://gdata.youtube.com/feeds/api/users/{0}/uploads/{1}", username, VideoId));
    //        //        Video video = request.Retrieve<Video>(videoEntryUrl);
    //        //        request.Delete(video);

    //        //        return true;
    //        //    }
    //        //    catch (Exception ex)
    //        //    {
    //        //        return false;
    //        //    }
    //        //}

    //    }
}