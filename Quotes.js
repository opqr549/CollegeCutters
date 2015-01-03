// Display Random Blockquotes and Cites


// Create Quotes Array
var quotes = [];

// The List of Quotes!
quotes[0] = "This Lawn Care Company is literally the best ever.";
quotes[1] = "This company has made my lawn look like the best lawn ever.";
quotes[2] = "Everything here is awesome.  Best 2014 ever.";
quotes[3] = "Man.  Grass.  That stuff.";
quotes[4] = "I am running out of quotes to make up.";
quotes[5] = "It took me thirty hours to figure out this random quote thing.";
quotes[6] = "Madfsadfsdafs.";
quotes[7] = "I don't have a lawn ";
quotes[8] = "dfdsfa";
quotes[9] = "just random words for proof of concept";
quotes[10] = "cats meow occasionally";
quotes[11] = "guitar soup";

// Assign the Variable "quote" with a Random Quotation from Above

var quote = quotes[Math.floor(Math.random() * quotes.length)];

// Alter the Current (Default) Quote Text with a Random Quote
$('#preloader blockquote').text(quote);