# imageboard-parser-for-stock-tickers
This program is to be used on a certain image board to search for specific threads.

This program is to be used ONLY for reference and by no means should be used for any financial advice. 

***
This program takes a thread, looks through a thread, post by post, and counts the number of times a stock ticker is mentioned, and finally makes a list of the tickers and the amount of times mentioned.

Take the ```string json = client.DownloadString("https://a.4cdn.org/biz/thread/37631449.json");``` line of code and place the appropriate URL into the parentheseis, and then compile the program.  

***
##Known issues 

-The parser does not currently find tickers under 4 letters

-Partial Youtube urls can sometimes show up in the output

***

##Things to add

A search function to search through all known stock tickers to weed out the youtube URL bits and any problems under 4 letters that seems to frequently occur. 
