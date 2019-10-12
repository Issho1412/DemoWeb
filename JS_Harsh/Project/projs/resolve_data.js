var arr_email = ['Admin@gmail.com'];
var arr_pass = ['Admin@1999'];

function setData () {

	if (localStorage.clickcount) {
      localStorage.clickcount = Number(localStorage.clickcount)+1;
    } else {
      localStorage.clickcount = 0;
    }

	var user = new Object();
		
	let name = document.getElementById('res_fullname').value;
	let email = document.getElementById('res_email').value;
	let pass = document.getElementById('pass_login').value;
	localStorage.setItem('id', localStorage.clickcount);
	user.id = localStorage.getItem('id');

	user.name = name;
	user.email = email;
	user.pass = pass;
	//localStorage.setItem('id', value: DOMString)
	
	localStorage.setItem('kname' + user.id, name);
	localStorage.setItem('kemail' + user.id, email);
	localStorage.setItem('kpass' + user.id,  pass);
	localStorage.setItem('kindex'+ user.id, user.id);

	arr_email.push(localStorage.getItem('kemail' + user.id));
	arr_pass.push(localStorage.getItem('kpass' + user.id));
	
}

function similarEmail () {
	// body... 
	let email = document.getElementById('res_email').value;
	for(let m = 0; m < localStorage.length; m++)
	{
		if (email == localStorage.getItem('kemail' +  m)){
			document.getElementById('error_email').style.display = 'block';
			document.getElementById('error_email').innerHTML = "Email has existed! Please change other email.";
			document.getElementById('res_email').value = "";
			location.reload();
		}
		else
		{
			continue;
		}
		
	}
}

let res = "";
function checkLogin() {

	// Get value of email, pass from login form input
	var x = document.getElementById('email_login').value;
	var y = document.getElementById('pass_login').value;
	for(let i = 0; i < localStorage.length; i++)
	{
		if(x == localStorage.getItem('kemail' + i) && y == localStorage.getItem('kpass'+i))
		{
			alert("right");
			document.getElementById('frmlogin').action= "./login_success.html";

			res = localStorage.getItem("kname"+i) + "";
			localStorage.setItem('key', i);
			localStorage.setItem('userpass', localStorage.getItem('kpass'+i));
			localStorage.setItem('user', res);
			localStorage.setItem('useremail', localStorage.getItem('kemail'+i));
			break;
		}
		else {
			continue;	
		}
	}
	if(x == "Admin@gmail.com" && y == "Admin@999")
	{
		document.getElementById('frmlogin').action= "./admin.html";
	} 
}



// Catch error get Name user when login successfully
try {
	// statements
	document.getElementById('result_user').innerHTML = localStorage.getItem('user');

} catch(e) {
	// statements
	console.log(e);
}




function showData () {
	// body... 
	document.getElementById('email_edt').value = localStorage.getItem('useremail');
	document.getElementById('pass_edt').value = localStorage.getItem('userpass');
}

function editData()
{
	// get value old pass & old email user
	var old_pass = localStorage.getItem('userpass');
	var old_email = localStorage.getItem('useremail');
	
	// get value of key to edit data
	var k = localStorage.getItem('key');
	

	// get new value of pass & email user
	var edt_email = document.getElementById('email_edt').value;
	var edt_pass = document.getElementById('pass_edt').value;
	alert(edt_email + edt_pass);

	// key to login is removed = ""
	localStorage.setItem('userpass', "");
	localStorage.setItem('useremail', "");

	// Set data & reload()
	localStorage.setItem('kpass' + k, edt_pass);
	localStorage.setItem('kemail' + k, edt_email);
	location.reload();
}
//Get name of user when login success

function deleteUser (t) {
	// body... 
	//var t = prompt("Input user you want to delete(index)", '');
	alert(t);
	localStorage.removeItem('kemail' + t);
	localStorage.removeItem('kpass' + t);
	localStorage.removeItem('kname' + t);
	location.reload();
	//localStorage.setItem('id', localStorage.clickcount--);
}
function showDataAdmin (id) {
	// body... 
	var ids = id.getAttribute('data-id');
	document.getElementById('email_edt').value = localStorage.getItem('kemail'+ids);
	document.getElementById('pass_edt').value = localStorage.getItem('kpass'+i);
}
function setDataAdmin () {
	// body...
	var id = document.getElementById('id_admin').value;
	alert(id);
	var old_pass = localStorage.getItem('kpass' + id);
	var old_email = localStorage.getItem('kemail' + id);

	
	var edt_email = document.getElementById('email_admin').value;
	var edt_pass = document.getElementById('pass_admin').value 
	alert(edt_email);

	localStorage.setItem('kpass' + id, edt_pass);
	localStorage.setItem('kemail' + id, edt_email); 
}
