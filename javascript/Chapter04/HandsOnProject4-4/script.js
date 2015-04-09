"use strict";

var places = new Array(5); // new array to store entered places
var i = 0; // counter variable to track array indexes

// function to add input to array and then generate list after 5th submission
function processInput() {
	places[i] = document.getElementById("placeBox").value;
	document.getElementById("placeBox").value = ""; // clear text box
	i++;
	if (i > 4) {
		results();
	}
}

function results()
{
	var listItem = "";
	for (var j = 0; j < places.length; j++) {
		listItem = "item" + (j+1);
		document.getElementById("resultsExpl").innerHTML = "You entered the following places:";
		document.getElementById(listItem).innerHTML = places[j];
			 
	}
}