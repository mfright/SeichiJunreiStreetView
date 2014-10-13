<html>
<head>
<meta http-equiv='X-UA-Compatible' content='IE9' />
</head>
<body>

<DIV style="top : 0px;left : 0px;
  position : absolute;
  z-index : 5;
" id="Layer5">
<DIV>
<iframe 

<?php
$wid = $_POST['width'];
$hei = $_POST['height'];
$uri = $_POST['url'];

echo ' width="'.$wid.'" ';
echo ' height="'.$hei.'" ';

echo ' frameborder="0" scrolling="no" marginheight="0" marginwidth="0" ';

echo 'src="http://'.$uri.'"></iframe>';


?>
</DIV></DIV>

</body>
</html>