<?php
//////INTERFACES///////
include("FlyInterface.php");
include("QuakinterInterface.php");

//////DUCK_SETS/////
include("FlyWithoutWings.php");
include("FlyWithWings.php");
include("HighQuack.php");
include("LowQuack.php");

////Duck_object_set///////
include("Duck.php");

////Duck_object////////
include("RedHeadDuck.php");
include("BlackHeadDuck.php");


$red_head_duck = new RedHeadDuck();
$black_head_duck = new BlackHeadDuck();

?>

<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<title>Ducks</title>
	<link rel="stylesheet" type="text/css" href="style.css">
</head>
<body>
	<div class="ducks" id="<?php echo $red_head_duck->id;  ?>" >
		<img src="<?php echo $red_head_duck->img;?>" alt="<?php echo $red_head_duck->title;  ?>">
		<p><?php  $red_head_duck->fly();  ?></p>
		<p><?php  $red_head_duck->Quack();  ?></p>
	</div>
	<div class="ducks" id="<?php echo $black_head_duck->id;  ?>">
		<img src="<?php echo $black_head_duck->img;?>" alt="<?php echo $red_head_duck->title;  ?>">
		<p><?php  $black_head_duck->fly();  ?></p>
		<p><?php  $black_head_duck->Quack();  ?></p>
	</div>
	
</body>
</html>

