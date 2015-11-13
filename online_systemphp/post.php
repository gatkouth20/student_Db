<?php
$hostname="localhost"; 
$username="root";
$db_name="onlinee";
$tbl_name="post";
// connect to the server
$search= mysql_connect("localhost", "root", "")or die("cannot connect to the Server");
mysql_select_db("onlinee",$search) or die("cannot connect to Mysql");

//start posting
$a=$_POST['ID'];
$b=$_POST['Firstname'];
$c=$_POST['Lastname'];
$d=$_POST['M_name'];
$e=$_POST['Country'];
$f=$_POST['City'];
$g=$_POST['State'];
$h=$_POST['Zip_code'];
$i=$_POST['Day'];
$y=$_POST['month'];
$z=$_POST['Year'];
$x=$_POST['Place_birth'];
$j=$_POST['Age'];
$k=$_POST['status'];
$l=$_POST['Gender'];
$m=$_POST['Email_address'];
$n=$_POST['P_phone'];
$o=$_POST['home_phone'];
$p=$_POST['best_choice'];
$q=$_POST['programs'];
$r=$_POST['start'];
$s=$_POST['Education'];
$t=$_POST['comment'];


// insert into mysql
$sql=mysql_query("INSERT INTO post(ID,Firstname,Lastname,M_name,Country,City,State,Zip_code,Day,Place_birth,month,Year,Age)values('$a','$b','$c','$d','$e','$f','$g','$h','$i','$x','$y','$z','$j')")or die(mysql_error());
$sql=mysql_query("INSERT INTO post2(status,Gender,Email_address,P_phone,home_phone,best_choice,programs,start,Education,comment)values('$k','$l','$m','$n ','$o','$p','$q','$r','$s','$t')")or die(mysql_error());
 
if(!$sql)
{
echo "ERROR";
echo "<br>";
}else{
echo "Thank for registing";
}
?>
<h1><a href"student.html">Back to main</a></h1>