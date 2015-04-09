// Fills in table rows and adds new table cells
function fillTable() {
    var table = document.getElementById("tableItems");
    var rowCount = table.rows.length;
    var row = table.insertRow(rowCount);
	
	// Gets values from textboxes and inserts them into the table
    row.insertCell(0).innerHTML = textbox1.value;
	row.insertCell(1).innerHTML = textbox2.value;
	row.insertCell(2).innerHTML = textbox3.value;
	row.insertCell(3).innerHTML = textbox4.value;
	row.insertCell(4).innerHTML = textbox5.value;
	row.insertCell(5).innerHTML = textbox6.value;
	row.insertCell(6).innerHTML = textbox7.value;
	row.insertCell(7).innerHTML = textbox8.value;
	row.insertCell(8).innerHTML = textbox9.value;
	row.insertCell(9).innerHTML = textbox10.value;
	row.insertCell(10).innerHTML = textbox11.value;
	row.insertCell(11).innerHTML = datepicker.value;
	datepicker.value = "";
	
	// Clears textboxes except last one
	for (var i = 1; i <= 11; i++) {
		var textbox = "textbox" + i; 
		document.getElementById(textbox).value = "";
	}
}