<html>
<head>
<meta http-equiv='X-UA-Compatible' content='IE10' />
</head>
<frameset rows="*,0">



<?php
$wid = $_POST['width'];
$hei = $_POST['height'];
$uri = $_POST['url'];


echo '<frame src="http://'.$uri.'" name="ue">';


?>

<!-- <frame src="post.htm" name="sita"> -->

</frameset>

</html>