<?PHP
		
			/*if($_POST["data1"])
			{
				echo "data1";
			}
			if($_POST["data2"])
			{
				echo "data2";
			}
			echo "nothing";*/
if(isset($_FILES['file']) and !$_FILES['file']['error']){
	var_dump ($_FILES['file']);
}else{echo"NO!";}
		
?>