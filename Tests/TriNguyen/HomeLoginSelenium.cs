namespace N01_NUnit_ShopQuanAo.Tests.TriNguyen
{
    public class HomeLoginSelenium
    {
        private readonly int COL = 8;
        private readonly string WORKSHEET_NAME = "Đăng nhập";
        private readonly string FILE_PATH = @"E:\HUFLIT\BDCLPM\doan\N01_NUnit_ShopQuanAo\Tests\Out";

        #pragma warning disable NUnit1032 // An IDisposable field/property should be Disposed in a TearDown method
        private IWebDriver driver;
        [AllowNull]
        //để gán return của FindElement(By.xxx);
        private IWebElement expected;
        [AllowNull]
        private IWebElement actual;

        [SetUp]
        public void Setup()
        {
            // Thay EdgeDriver thành driver đang sử dụng :) 
            this.driver = new EdgeDriver();
            this.driver.Manage().Window.Maximize();
            this.driver.Navigate().GoToUrl("http://localhost:22222");
        }
        [Test]
        [TestCase("[Đăng nhập_1]", "fifai", "8732441", "Đăng nhập thành công", 10, 8)]
        [TestCase("[Đăng nhập_2]", "abc000", "0900009900", "Tên đăng nhập không tồn tại", 11, 8)]
        [TestCase("[Đăng nhập_3]", "", "8732441", "Tên đăng nhập không tồn tại",  12, 8)]
        [TestCase("[Đăng nhập_4]", "fifai", "", "Mật khẩu không đúng",  13, 8)]
        [TestCase("[Đăng nhập_5]", "fifai", "19001009", "Mật khẩu không đúng",  14, 8)]
        [TestCase("[Đăng nhập_6]", "      ", " ", "Tên đăng nhập không tồn tại", 15, 8)]
        [TestCase(
            "[Đăng nhập_7]",
            "BJZdrjKDn7IxwA8pemDDwhusrqlwjcr97woeUKogETYOyXFNws3kL2VdYqvB7XeLPJ0AWeUT7h9cJf4TkYA0iHyEbKGnYniqzN9phF0RYjmo32T2wbajXnmHUwjLYq5U8Tm5gPwfhsc9fKLi0N16N9SMk1Uvfp3roRpjPYWhp4BpKmmJkBUKz8H9AaVo4BA2yvVNelSc0URS7nB7PKKeUt1pKqjzCsnn4J1ZRYp9t1TfqzBXZXYt1fhF3pCyCdZIqoXywlq1fKvdZW8VpLZpT3vZlvflV07PbLyCcNlxqhNruEqhrrI1Duzx28MAGFfoNfBNh63bjl9vpEohF84osGMrVBJdBlrlCjePCc9vxqRbuEHyUo5IL16GTT2gwZa74YtGkYem8J0Byu7R3VJWqjaLmX6tkc8YQThWUAN5JSJBA5RiWlnaPERV7heMcvCfKcveNk62HONXZYKrFXW8ziIMCLYxgBdXPn1iKwVwouSB035jXxHEZDqlTicBLJVGvzIvgmgSBkUFPHVIQzZt3Y8L7QOlUUkfYMQBvKDuQyDztkVMNUvWtmMW16yQY58r9yrD0TXFvpdEVIcX4BX9jNvw93KyWxWU0Vz43SV47pkEIHAseaVXh8HvD4E7Jit8TIO9ShdlpdC3nrn13bU5b8x1NE18NYvY5lvA3BZ67tsE5OIVRNDrNyhUVWvOqeYQso8B5n72CY7rQs696frAUDLGEaogPLQcVbWRPGZnPLoy00DmawSKwX5oc27f9bm1IfVyWouzGEvJYWPNXBGc2Gp8gsyXJ4oxjxqVfPQvBdDslwPGmtI7VJ8BzWSo0WpLZ7klp3sIuUbZC7WucrvawqcZzpgI6m5py2SnMobsAAMAsj92AiLIlOYtfKwAXkLIZwkKoshyQCawebqPpnHYbwDjdjIB1bVZyEl68zNRAW2jxmOEegUtcwrmsAqFkg6zrB7ZztQ0a0YE4dw0UEgVGl6BX9O7IIqdaD2wozO",
            "vPeTmYnsOO0ugAlsFE6C0fTsRJ4n1lAMfzvFmSUntQ9sSXKdyUwrswXP6vBce91nOnPqOgGxuSSjgkZ39aygySdsbfI0Q1IuZVeoIdPSN96ZdxtWVHdDKUy6",
            "Mật khẩu không đúng", 
            16, 8)
        ]
        [TestCase(
            "[Đăng nhập_8]",
            "sIC9zBrrHG9kQVqzrOjHlls2TkRVyhzRF656zAjt8ZNcx4gzju1jUpqHZKpOtW2kRseUZtAqozJMYQEZEcvDpP7aPygoVU9mgmLFaMZzuK4egesJGPKRky4BvEElMVVTzhpwE891D5TfVc4vGXiFKsBsrKUVIxmYzlp8z5EIQSOofZqSKTfzxPIGf7F4nntPT5qtw56KSaz2eXMSeBLzSxljcic10Keni8Vjs6gPWVhWaQmIuxZlc46fTGRNcETH5LTfBnjhf6c7POJL6UHDu2LnCzQmoSwSBZbO6GHHN1Ffc9QF6FRI6QWCAqdLW73NJJ60x5OzMAz2wpKCjLpiAoWvDYNQn5uQ82WTDaRB1b55adPVfamLRUMfwKxYs7MRQi44S19J3orjsaUjI2vMTi8oq1g2n3S3Pop1jVCnacSnnnwW0NPzM97rjQNbUHg9VyTDuc9xzHv0PVBDEKBZndqQq8RTHlTT6SRyTslXNcAENGbOPKXKFHW2HDXwKqpOyc46DMtVjoLKcmCjgDE6NJNy6ZrQVzMhxwPuMeKCbBlb5LZeAxPHmsApPFAnec9tbnXqWRXC2BfMiw3u9MQijF5EwkfGegh8B1ASytIsZNOkMyHcMPoSMbKVsS4wwRiVdgKqvk6QEhJW0U17cC3O2PwkrojfzV6Hp3GqnarlSXNoRxeXa6TtXTcOtj9HAaatlBr7NLUBVR5eBIT3KME3BMuVa26Ebkk17eCQGgJPmSYFX7MlQF6yWhrYQVhVOPkvqDhhFCwnCzRtyo8cqUxVnwfZxo9v9yAWrmYTapgNSTvgQ8kmWEo4bPI4iItbDBnOy4BLPoCAykCTA8JyDXY4JG4ceevS5FKRqhrV6YWrCnF1My3j84XqmsEsAirv3uFtZuncQx2pAr2gACQqkLTAreo7d9VYrlyRiWbbLbSLCsq50hr7SAKrbEB5Gq9Rbd8Y2k7nkyfJ3I79ysG5RYFqbG0dVgVfbAtjtRCPkEWefAyTGBHXjDADXS7wueSEcAr2YYPgp1VNBlKaShWTY75YApLbUQfFvSBfT54svlrrrwCwHgeMH9peET1tNyMZWPbtkoHWnohxQOqOmYUxvS7wmgbADKe7YRVbUTMdZIjdb2OzmnGyeYoESpGDMGScJkY82O3TM0XnseUuRlXaEqd9nRJpMIQSzHU1dQ6XuxmnBBVxUWvkt2XdGZUlEOGDkFxkKdRBo9pRDz8m5WU0Xpj6t0uD5VTfqiD6Nun1Fu5tMGZQasqs3Qq4f00TsNFTqKkewCYKsdumt0umbdnMokla2IaW3UI2omCCg4eYUfAafDKpGN1Pj3oGiKmolBQYU28HxrGg9P2JkK4y7vQqc2Sv76eWSzwSPmGmFD1YHUQUAfgXPxq0vk5bkMK1NuOJck48ESt342iHm7vbZGHeI6hoqoC239KXGG2alhS6Ew62CyymbsbGmuAgCPRaP0A4rLBgFU02yKZWAom2zabLhDuVGVXVQ2rOwBL0wSgG1jScUogYnYkzZzXnapat7fl6dLj8dvFh3UT7vSAbz8r1R1y6nhaG2wIV8W8JEh52TD5FfZ2Hp849yuplWmV5U9oGL89YU1XRDziN6tbNpSb31JhOrWwbM9hUYy3hadxylm58LbpnLHQChvOBavr7E5FDSOyHz3wLfnRPNjCPqIQEtfwnj1Hpvztqh2q7mixRUEg4d9y1scQ5oBUxbLh7wHZp3lrV2EmIV8to81KjDP6TixBgi3fbA0eNp0A1Sd8ozIkqRpyjA73gKGGFjLx9iKHedg9H1SRkRSeaNVO2E5aC67Cjt5RGp8FoAFMvqqssqTP2lq2O655nuEifdaX5AK4SN0aHJdLXNsWmsK7DCDJuDc45hqRQSwsfY7ovQvFdthZBs5xScU26BKOv5ejcL5Ea91Ov",
            "8732441",
            "Tên đăng nhập không tồn tại", 
            17, 8)
        ]
        [TestCase(
            "[Đăng nhập_9]", 
            "", 
            "ZraWs2kutksya2xyUCCSjNXDanZdfi2CU8OasD5ivhUpqPiLONHXHIDMUX6EdHPKrqdboXFRHehC3rWKFNORaf4M5CFVH0FnSJ7AwGh1H0PnlASmAw9P27tLvRflRuKQZ3tutWX8qXKkQRk4tdVU0zvVZvPfl6kXq8OsRi2oYBjfwJ5dqk2yYzajHYV7H2Wuxw3RD2nLkr6yQQiP0vyADv81iok3N5hfpzrAPoZy7rNr2lS1zFHVEVqByCsZRu7pKaJbiiALVADWiR87VtDIxLbTIqLM5AhNtihbb0SRF69ESTdhDvDhqz1890S1WxPUc0n9thffavD1LXBzNoJK79g3qiclia5RqplbpdxgPhH5wAwlydoroFWdUtSKE3690vLgwjJt1m4Z2kHpv0xEwNnkSHH6KmbVlHEAzQzPT50BK7ltmmYOG1NmHkOobNiOKiyvgG0fAhv0XmaVgYThONOt3c3OCLxFWm0lIzNfw3NiGXPfK2HD3AA7TF2DNldzupduvyNqLyvUAqmfMXEJDtMWl3RC7JSLaXxa3euWpb2FPp6ndW1zhTwBdHI1gKtCfk4n2Mmrnsdm1GH67njlRcoGkw6vV3zfszjouTvQtJMy0KJWAM32lHuD6yCFP0Vt283BhcLn2S1HQzQanjvJ964kFgs6RqB3yc52QHziAQASQmwHimcpFMu5DT6AtPWLR8Tx3YJfuNIt6lUctlYpOVxlsAy7Lyyu3zARS9NKc752DB9b9dRI1r76KrF3jMT5YYzGlCKuXNMQZ5irAW7shp3M1EGk4UkQnAdpM306ThuneqhPJY3NOlYsemOg5jzDn6nYb3fHfAZ95PsLh1bgbWBCmuKjoUAurr9iDIxP3wrNMYxP4D9EHTmQ5kwrs5cL9pSNPKIYDMnopx0O75pkU6mXFtmcWGg7TgNhFj9t5kA5q7lHuhtxP20DC4IghpB6ppVJjTIX55pt5rrIHfsyWtrapKeKbcMPjDPBlciaZW1UNHHUNAYC7Nk674dZy75csZK1bpgp6RZ91XNiCJ7bEKRVdTDq8JmbbYlx6Q3hdsFqxkEkr5WpAeYiHyXHm0qxp7icwalwQZ8VElh3Pd9Dw6b7ACpH2v5mCSA0BlxQTkZkfCegRe2I0nAsflctue3eeVTwkr2npstMh1b7iJ0Y3wwYSSUZJEgzq4GKtr5jlPdH4xKoKfKlnfkrj5dSWcdlM4fnuRN0NQwoToeeIqPn34LLUYlyNnNJv159Sh33RTXXs6Y4a9JqN0rRsUSWpZmkDm2bteLkwWWjhycXAqXOdg65KnR8OhN2rxTFD7L6xi40dHu415W9BYGgq7QFNNWOId2ufWUCeba4mFbD2WHTLO0SqwZGqGskMps9OAZekTej8L4lfNM0GCD4nkDs7OWYt0s7Xby27ms1tQUe2xkc31dJlxWo6qgW6F0Hd6OEZT3eULKWPj0Kn3f1WiWjFJ6QFV4oaMB5jgDj89zZmAZX0WtDj9v4ko8QXmY8Rg6Ch4lH053Wt67FujZtm1EbbGV4hxMVl1IFDWz6vlMoFYLnq3gyMoVZcflbiqjDtiv2y2BXtd8ApaVC5rNnRYI6ftniuYYECI4hnTzy2IEtqUtBJjf0c5wVZyWFOcmVF38gfxZl2ZvITYQK9lYL2hlGWjHy6ukZftowVNgVJ37DKnBAhLGmDbchR2J5qkpIzVnkuezvECC8ji5shGRvo7VEQHedDkpiOzNyAbQDWUiBYd7t6bYjT3d29iTnAWrdXdttUHrF0NZTYUpwJugmMGOVWVycImC9mEn5uNYztSsFeJdp3gdP0FRQOYX8SP7OLZrUquC6Wq24XI0M2JilIxJgxWqVzZgdUe4FcI8Jdh3JMW3FiKGJqVFXPKhTDrG6KYk3OvuuLZIl4ATadkwpTXx8Zg0R", 
            "Tên đăng nhập không tồn tại",  
            18, 8)
        ]
        [TestCase("[Đăng nhập_10]", " fifai", "8732441", "Tên đăng nhập không tồn tại", 19, 8)]
        [TestCase("[Đăng nhập_11]", "fifai ", "8732441", "Tên đăng nhập không tồn tại", 20, 8)]
        [TestCase("[Đăng nhập_12]", " fifai ", "8732441", "Tên đăng nhập không tồn tại", 21, 8)]
        [TestCase("[Đăng nhập_13]", " $fifai", "8732441", "Tên đăng nhập không tồn tại", 22, 8)]
        [TestCase("[Đăng nhập_14]", " fifai$", "8732441", "Tên đăng nhập không tồn tại", 23, 8)]
        [TestCase("[Đăng nhập_15]", " fifai ", "8732441 ", "Tên đăng nhập không tồn tại", 24, 8)]
        [TestCase("[Đăng nhập_16]", "fifai", "8732441 ", "Tên đăng nhập không tồn tại", 25, 8)]
        [TestCase("[Đăng nhập_17]", "admin", "@@@   ", "Mật khẩu không đúng", 26, 8)]
        [TestCase("[Đăng nhập_18]", " admin", "admin", "Tên đăng nhập không tồn tại", 27, 8)]
        [TestCase("[Đăng nhập_20]", " admin", "4343", "Tên đăng nhập không tồn tại", 29, 8)]
        public void DangNhap_ActorKhachHang(string testId, string userName,
                                    string password, string expected, int x, int y)
        {
            try
            {
                // 1. Click "Đăng nhập" trên Navbar
                IWebElement loginLink = this.driver.FindElement(By.XPath(
                    "/html/body/header/div/div/div[2]/ul/li[1]/a"
                ));
                loginLink.Click();
                // 2. Nhập liệu tài khoản
                IWebElement inpUsrName = this.driver.FindElement(By.Id("uname"));
                inpUsrName.Clear();
                inpUsrName.SendKeys(userName);
                // 3. Nhập liệu mật khẩu
                IWebElement inpPassword = this.driver.FindElement(By.Id("psw"));
                inpPassword.Clear();
                inpPassword.SendKeys(password);
                Thread.Sleep(1500);
                // 4. Click nút "Đăng nhập" màu đỏ
                IWebElement loginButton = this.driver.FindElement(By.Id("submit-login"));
                loginButton.Click();
                
                // So sánh chuỗi của expected có giống với toast của web không
                this.actual = this.driver.FindElement(By.XPath(
                    "/html/body/section[1]/div[2]/div/div[2]/span"
                ));;
                bool testResult = this.actual.Text.Trim() == expected;
                string strTestResult = "";
                if(testResult) {
                    strTestResult = "Pass";
                }
                else {
                    strTestResult = "Fail";
                }
                EPPlusEngine.WriteExcelFile(FILE_PATH, WORKSHEET_NAME, strTestResult, x, y);
                Assert.That(testResult);
                // 5. Tắt trình duyệt
                this.driver.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                EPPlusEngine.WriteExcelFile(FILE_PATH, WORKSHEET_NAME, ex.Message, x, y);

                this.driver.Quit();
            }
        }
    }
}
