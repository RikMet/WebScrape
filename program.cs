      case "7":


                        string curDir = Directory.GetCurrentDirectory();
                        var localurl = new Uri(String.Format("file:///{0}/Index.html", curDir));
                        

                        string urlAddress2 = "http://www.netfonds.no/";
                        var doc = new HtmlAgilityPack.HtmlDocument();
                        HtmlAgilityPack.HtmlNode.ElementsFlags["br"] = HtmlAgilityPack.HtmlElementFlag.Empty;
                        doc.OptionWriteEmptyNodes = true;
//                        doc.LoadHtml(localurl.);
                        var webRequest = HttpWebRequest.Create(urlAddress2);
//                        var webRequest = HttpWebRequest.Create(localurl);
                        Stream stream = webRequest.GetResponse().GetResponseStream();
                        
                        doc.Load(stream);
                        stream.Close();

                        //get the div by id and then get the inner text 
                        string testDivSelector = "//div[@id='mest-omsatte']";
                        var divString = doc.DocumentNode.SelectSingleNode(testDivSelector).InnerHtml.ToString();
                        Console.WriteLine("divString: " + divString);
                        break;
