<?php
// Very simple application level authentication
$passwd = 'TwoCats';

if(isset($_POST['passwd']) && $_POST['passwd'] == $passwd)
{
	// Store data somewhere, in this case to file
	if(file_put_contents('post_data.txt', print_r($_REQUEST, true).print_r($_SERVER, true)))
		echo "Post data saved succesfully!";
}
elseif(isset($_GET['passwd']) && $_GET['passwd'] == $passwd)
{
	// Get parameters from somewhere and just print them
	echo 'par=1;par2=2;par3=3';
}
else
{
	echo 'H4x0r!';
}
?>