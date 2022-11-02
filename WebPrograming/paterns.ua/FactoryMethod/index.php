<?php 

include("PhoneInterface.php");
include("SmartPhone.php");
include("CellPhone.php");
include("PhoneFactory.php");

$factory = new PhoneFactory();
$create_cellphone = $factory->createCellPhone();
$create_smartphone = $factory->createSmartPhone();

$create_smartphone->call("Звоню с Samsung Galaxy S21");
echo "<br/>";
$create_cellphone->call("Звоню с Nokia 3310 в 2022 году!");
?>