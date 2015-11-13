<?php
// make connection 
mysql_connect('localhost','root','');
// select database
mysql_select_db('onlinee');
$sql = "select * from post";
$records = mysql_query($sql);
?> 
<html>
<head>
<title>Student Registration page</title>
<body>
 <table width="1338" border="1" cellpadding="2" cellspacing="2" background="#EEEEEE" align="center">
 <tr bgcolor="#CCFF66">
 <th width="23">ID</th>
 <th width="79" bordercolor="#00FF33">firstname</th>
 <th width="82" bordercolorlight="#DD0000">Lastname</th>
 <th width="89">M_name</th>
 <th width="141">Country</th>
 <th width="68">City</th>
 <th width="117">State</th>
 <th width="63">Zip_code</th>
 <th width="94">Day</th>
 <th width="99">month</th>
 <th width="90">Year</th>
 <th width="145">Place_birth</th>
 <th width="66">Age</th>
 
 <tr>
 <?php
 while($post=mysql_fetch_assoc($records)){
 echo "<tr>";
 echo "<td>".$post['ID']."</td>";
 echo "<td>".$post['firstname']."</td>";
 echo "<td>".$post['Lastname']."</td>";
 echo "<td>".$post['M_name']."</td>";
 echo "<td>".$post['Country']."</td>";
 echo "<td>".$post['City']."</td>";
 echo "<td>".$post['State']."</td>";
 echo "<td>".$post['Zip_code']."</td>";
 echo "<td>".$post['Day']."</td>";
 echo "<td>".$post['month']."</td>";
 echo "<td>".$post['Year']."</td>";
 echo "<td>".$post['Place_birth']."</td>";
 echo "<td>".$post['Age']."</td>";
 
 }// end while
 ?>
</table>
<a href="student.html">Back to main </a>
</body>
</head>
</html>
