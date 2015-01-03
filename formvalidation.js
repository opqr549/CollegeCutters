function validateForm() {
    var msg = "";

    var name = document.forms["OrderForm"]["name"].value;


    if (name == "Your Name" || name == " ") {
        msg += "- Please enter your name.\n";
    }

    var email = document.forms["OrderForm"]["email"].value;


    if (email == "Your Email" || email == " ") {
        msg += "- Please enter your email address.\n";
    }

    var phone = document.forms["OrderForm"]["phone"].value;


    if (phone == "Your Phone Number" || phone == " ") {
        msg += "- Please enter your phone number.\n";
    }

    var description = document.forms["OrderForm"]["description"].value;


    if (description == "") {
        msg += "- Please enter a work description.\n";
    }

    if (msg != "") {
        alert("Woops, something went wrong...\n\n" + msg);
        return false;
    }
    else {
        return true;
    }
}