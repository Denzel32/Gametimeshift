<?php
$servername = "localhost";
$username = "root";
$password = "black234";
$dbname = "GameTimeShift";
$t = time();

//make connection
$con = new mysqli($servername, $username, $password, $dbname);

//Check connection
if(!$con){
	die("Connection failed: " . mysqli_connect_error());
}

$sql = "INSERT INTO PlayerChange (Hair, Scent)
VALUES ('5', '10')";

if(mysqli_query($con, $sql))
{
	echo "New record created succesfully";
}else{
	echo "Error" .$sql . "<br>" . mysqli_error($con);
}


//echo "Connected succesfully";

mysqli_close($con);

echo ($t. "<br>");
?>