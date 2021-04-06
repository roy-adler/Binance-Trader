using System;

namespace Binance

{	
		public class BinanceTrader
		{
				private string ApiKey;
				private string SecretKey;

				/// <summary>
				/// Creates the main object to do all the api-calls.
				/// 
				/// </summary>
				/// <param name="apiKey">Your apiKey from your Binance-Api.</param>
				/// <param name="secretKey">Your secretKey from your Binance-Api.</param>
				public BinanceTrader(string apiKey, string secretKey)
				{
						ApiKey = apiKey;
						SecretKey = secretKey;
				}
		}
}
