function checkpass () {
	// body... 
	var x = document.getElementById('pass_login').value;
	if(x.length<1)
    {
      document.getElementById('error_p').style.display = "block";
      document.getElementById('error_p').innerHTML = "Please fill out password!";
    }
    else 
      document.getElementById('error_p').style.display = "none";
    var bind = /^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{6,20}$/;
    if (x.match(bind))
    {
      document.getElementById('error_p').style.display = "none";
    }
    else
    {
      document.getElementById('error_p').style.display = "block";
      document.getElementById('error_p').style.fontSize = '10px';
      document.getElementById('error_p').innerHTML = "Password has upper, lowercase, number, special & not null characters";
    }
}

function checkname () {
	// body... 
	var x = document.getElementById('res_fullname').value;
	
	if(x.length == 0)
	{
		document.getElementById('error_name').style.display = "block";
		document.getElementById('error_name').innerHTML = "Please fill out user!";
	}
	else 
	document.getElementById('error_name').style.display = "none";
	if (!isNaN(x.slice(0,1)))
	{
		document.getElementById('error_name').style.display = "block";
		document.getElementById('error_name').innerHTML = "Please user does not start by number.";
	}
	else
	{
		document.getElementById('error_name').style.display = "none";
	}
}

function checkrepass () {
	// body.
	let password = document.getElementById('pass_login').value; 
	let repass = document.getElementById('res_repass').value;
	if (repass != password)
	{
		document.getElementById('error_repass').style.display = "block";
		document.getElementById('error_repass').innerHTML = "Please check repassword!";
	}
	else
		document.getElementById('error_repass').style.display = "none";
}

