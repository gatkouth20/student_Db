<?php
include_once("db.php");
// make code insert image to database../
if(isset($_POST['save']))
{
if (($_FILES['file']['type']=='image/gif')
|| ($_FILES['file']['type']=='image/jpeg')
|| ($_FILES['file']['type']=='image/pjpeg')
 &&($_FILES['file']['size'] < 200000))
{
if($_FILES['file']['error'] > 0)
{
echo "return code:".($_FILES['file']['error']); 
}
else if(file_exists('upload/'.$_FILES['file']['name']))
{
echo $_FILES['file']['name']."already exists";
}
else if(move_uploaded_file($_FILES['file']['tmp_name'],
        'upload/'.$_FILES['file']['name']))
		{
		$studname = $_POST['studname'];
		$gender = $_POST['gender'];
		$pob = $_POST['pob'];
		$address = $_POST['address'];
		$status = $_POST['status'];
		$photo = $_POST['photo'];
		
		$part = $_FILES['file']['name'];
		$sql = mysql_query("INSERT INTO db(studname,gender,pob,address,status,photo)
		      VALUES('$studname','$gender','$pob','$address','$status','$part')");
		
	if($sql)
	{
	echo "Successful insert this record...";
	}
	else
	{
	echo "Error insert";
      }
      }
   }
}
?>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />
<title>student DB</title>
</head>

<body>
<style>
a 
{
   text=decoration: none;
}

</style>
 <div style="border:1px #000 dotted; width:95%; height:80px;margin:auto;text-align: center;font-size: 36px; color:#0000CC; background-Color:#CCC;">
<div align="center">Student Information  </div>
<br></br>
 <div style="border:1px #000 dotted; width:95%; overflow:auto; margin:auto;background-Color:#CCC;">
 <form action="index.php" method="post" enctype="multipart/form-data">
  <table>
  <tr>
      <td> Student name</td>
	  <td>:</td>
	  <td><input type="text" name="studname"value=""/></td>
   
  </tr>
  <tr>
      <td>Gender</td>
	  <td>:</td>
	  <td> 
	  <select name ="gender" style=" width:140px;">
	  <option value="1">Male</option>
	   <option value="2">Female</option>
	   </select>
	  </td>
  
  </tr>
   <tr>
      <td> Place of Birth</td>
	  <td>:</td>
	  <td><input type="text" name="pob"value=""/></td>
  
  </tr>
  <tr>
      <td> Address</td>
	  <td>:</td>
	  <td><input type="text" name="address"value=""/></td>
  
  </tr>
   <tr>
      <td> Status</td>
	  <td>:</td> 
	  <td><input type="Radio" name="status" value="Student" />Student 
	      <input type="Radio" name="status" value="Staff" />Staff
		  <input type="Radio" name="status" value="teacher" />Teacher
		  <input type="Radio" name="status" value="worker" />Worker
	  </td>
  </tr>
  <tr>
  <td height="35">Student Pic</td>
  <td>:</td>
  <td><label>
    <input name="file" type="file" />
    </label></td>
  </tr>
  </table> 
  <td><input type="submit" value ="save" name="save" /></td>
  </center>
  </form>
   </br>
   <table style="border:2px solid #000; width:100%; overflow:auto; margin:auto;">
  <thead>
  <td>Student ID</td>
  <td>Studname</td>
  <td>Gender</td>
  <td>place of birth</td>
  <td>Address</td>
  <td>Status</td>
  <td>Photo</td>
  <td>Action</td>
  </thead>
  <tbody>
  <?php
  include_once("db.php");
  $sql = mysql_query("select *from db");
  while($row= mysql_fetch_object($sql))
  {
  $gender = $row->gender;
  if($gender =='1')
  {
  $gender ='male';
  }else
  {
  $gender= 'Female';
  
  echo "<tr>
        <td>$row->id</td>
		<td>$row->studname</td>
		<td>$gender</td>
		<td>$row->pob</td>
		<td>$row->address</td>
		<td>$row->status</td>
		<td><img style= 'width:110px; height:100px;'src ='upload/$row->photo'></td>
		<td><a href=Edite.php?ide=$row->id'>Edite</a>|
	     <a href=Delete.php?idd=$row->id'>Delete</a>
				 </td>
  
  </tr>";
  }
  }
  ?>
  </tbody>
  </table>
</div>
</body>
</html>
