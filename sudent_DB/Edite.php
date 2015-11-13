<?php
include_once('db.php');
$id = $_GET['ide'];
if(isset($_GET['ide']))
{
$sql = mysql_query(" select * from db WHERE id= '{$id}' ");
$row = mysql_fetch_object($sql);
$picture = $row->photo;
if (isset($_POST['save'])){
$newpicture = $_FILES['file'] ['name'];
if ($newpicture)
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
		 unlink('upload/.$picture');
		 $sqlnophpto = "UPDATE db SET studname='{$_POST['studname']}', 
		 gender =  '{$_POST['gender']}',
		 pob  =    '{$_POST['pob']}',
		 address = '{$_POST['address']}',
		 status =  '{$_POST['status']}',
		 WHERE id= '{$id}'";
		 $res = mysql_query( $sqlnophpto);
		 if($res)
		 {
		 header('location: index.php');
		 }
		}

}

 else

 $sqlnophpto = "UPDATE db SET studname='{$_POST['studname']}', 
		 gender =  '{$_POST['gender']}',
		 pob  =    '{$_POST['pob']}',
		 address = '{$_POST['address']}',
		 status =  '{$_POST['status']}',
		 WHERE id= '{$id}'";
		 $res = mysql_query( $sqlnophpto);
		 if($res)
		 {
		 header('location: index.php');
		 }
}
}


}
?>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />
<title>student add</title>
</head>

<body>
 <div style="border:1px #666 solid; width:900px; overflow:auto; margin:auto; background: #666; margin-top:20px;">
  <div style="border:1px #000 dotted; width:95%; height:80px;margin:auto text-align: center;font-size: 36px; color:#F00; background-Color:#CCC;"><center>
                Edite Student Information 
   </div>
 <div style="border:1px #000 dotted; width:95%; overflow:auto; margin:auto;background-Color:#CCC;">
 <form action="index.php" method="get" enctype="multipart/form-data">
  <table>
  <input type="hidden" value="<?php echo $row->id; ?>"  />
  <tr>
      <td> Student name</td>
	  <td>:</td>
	  <td><input type="text" name="studname"value="<?php echo $row->studname; ?>"/></td>
  
  </tr>
  <tr>
      <td>Gender</td>
	  <td>:</td>
	  <td> 
	  <select name ="gender" style=" width:140px;">
	  <option value="0" 
	  <?php echo ($row->gender== 0)?'selected ="selected:"':''; ?> >Male</option>
	   <option value="1" 
	   <?php echo ($row->gender== 1)?'selected ="selected:"':''; ?>>Female</option>
	   </select>
	  </td>
  
  </tr>
   <tr>
      <td> Place of Birth</td>
	  <td>:</td>
	  <td><input type="text" name="pob"value="<?php echo $row->pob; ?>"/></td>
  
  </tr>
  <tr>
      <td> Address</td>
	  <td>:</td>
	  <td><input type="text" name="address"value="<?php echo $row->address; ?>"/></td>
  
  </tr>
   <tr>
      <td> Status</td>
	  <td>:</td> 
	  <td><input type="Radio" name="status" value="Student" <?php echo ($row->status=='Student')?'checked':''?>/>Student 
	      <input type="Radio" name="status" value="Staff" <?php echo ($row->status=='Staff')?'checked':''?>/>Staff
		  <input type="Radio" name="status" value="teacher"<?php echo ($row->status=='teacher')?'checked':''?> />Teacher
		  <input type="Radio" name="status" value="worker" <?php echo ($row->status=='worker')?'checked':''?>/>Worker
	  </td>
  </tr>
  <tr>
  <td height="35">Student Pic</td>
  <td>:</td>
  <td><label>
    <input name="file" type="file" />
	<td> <img src="<?php echo 'upload/'.$picture;?>" style=" width:250px; height:250px;"></td>
    </label></td>
  </tr>
  </table> 
  <td><input type="submit" value ="Update" name="save" /></td>
  </center>
   </div>
  </div>
  </form>
</body>
</html>
