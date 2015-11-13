 <?php
 include_once('db.php');
 $id = $_GET['idd'];
 if(isset($_GET['idd']))
 {
 $sql = mysql_query("select  photo FROM db WHERE id= '{$id}'");
 $row = mysql_fetch_object($sql);
 $pic = $row->photo;
 $part = 'upload/';
 if(unlink($part.$pic))
 {
 $sqlq = mysql_query("Delete FROM db WHERE id ='{$id}'");
 if($sqlq)
 {
   header ('Location: index.php');
 }
}
 }
 ?>