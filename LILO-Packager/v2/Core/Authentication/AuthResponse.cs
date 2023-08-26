using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.Net;
using System.IO;

namespace LILO_Packager.v2.Core.Authentication
{
    public class AuthResponse
    {
        private string access_token;
        public string Access_token
        {
            get
            {
                if (DateTime.Now.Subtract(created).Hours > 1)
                {
                    refresh();
                }
                return access_token;
            }
            set { access_token = value; }
        }
        public string refresh_token { get; set; }
        public string clientId { get; set; }
        public string secret { get; set; }
        public string expires_in { get; set; }
        public DateTime created { get; set; }        

     
        public static AuthResponse get(string response)
        {
            AuthResponse result = JsonConvert.DeserializeObject<AuthResponse>(response);
            result.created = DateTime.Now;  
            return result;
        }


        public void refresh()
        {
            var request = (HttpWebRequest)WebRequest.Create("https://accounts.google.com/o/oauth2/token");
            string postData = string.Format("client_id={0}&client_secret={1}&refresh_token={2}&grant_type=refresh_token", this.clientId, this.secret, this.refresh_token);
            var data = Encoding.ASCII.GetBytes(postData);

            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = data.Length;

            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }

            var response = (HttpWebResponse)request.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            var refreshResponse = AuthResponse.get(responseString);
            this.access_token = refreshResponse.access_token;
            this.created = DateTime.Now;
        }


        public static AuthResponse Exchange(string authCode, string clientid, string secret, string redirectURI)
        {

            var request = (HttpWebRequest)WebRequest.Create("https://accounts.google.com/o/oauth2/token");

            string postData = string.Format("code={0}&client_id={1}&client_secret={2}&redirect_uri={3}&grant_type=authorization_code", authCode, clientid, secret, redirectURI);
            var data = Encoding.ASCII.GetBytes(postData);

            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = data.Length;

            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }

            var response = (HttpWebResponse)request.GetResponse();

            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

            var x = AuthResponse.get(responseString);

            x.clientId = clientid;
            x.secret = secret;

            return x;

        }



        public static Uri GetAutenticationURI(string clientId, string redirectUri)
        {
            string scopes = "https://www.googleapis.com/auth/userinfo.email https://www.googleapis.com/auth/userinfo.profile";

            if (string.IsNullOrEmpty(redirectUri))
            {
                redirectUri = "urn:ietf:wg:oauth:2.0:oob";
            }
            string oauth = string.Format("https://accounts.google.com/o/oauth2/auth?client_id={0}&redirect_uri={1}&scope={2}&response_type=code", clientId, redirectUri, scopes);
            return new Uri(oauth);
        }

    }
}
