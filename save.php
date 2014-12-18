<?php
/*Get the data dat has been send
The data will be formatted so it can be send to a database
After that we send back a response saying we got the name*/
$name = $_GET ['name'];

echo 'Name received: ' .$name;
?>